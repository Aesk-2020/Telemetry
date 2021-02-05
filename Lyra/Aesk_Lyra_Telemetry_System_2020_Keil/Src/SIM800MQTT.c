/*
 * SIM800MQTT.c
 *
 *  Created on: 9 Nis 2020
 *      Author: yemrelaydin
 */
#include "SIM800MQTT.h"
#include "StackTrace.h"
#include "string.h"
#include "AESK_Data_Pack_lib.h"
#include "AESK_Gps_lib.h"
#include "Can_Lyra_Header.h"

void SendATCommand(Gsm_Datas* gsm_data, char * command, char* response)
{
	gsm_data->at_response = response;
	HAL_UART_Transmit(gsm_data->gsm_uart, (uint8_t *)command, strlen(command), HAL_DELAY);
}

void writeChar(unsigned char** pptr, char c)
{
	**pptr = c;
	(*pptr)++;
}


/**
 * Writes an integer as 2 bytes to an output buffer.
 * @param pptr pointer to the output buffer - incremented by the number of bytes used & returned
 * @param anInt the integer to write
 */
void writeInt(unsigned char** pptr, int anInt)
{
	**pptr = (unsigned char)(anInt / 256);
	(*pptr)++;
	**pptr = (unsigned char)(anInt % 256);
	(*pptr)++;
}


/**
 * Writes a "UTF" string to an output buffer.  Converts C string to length-delimited.
 * @param pptr pointer to the output buffer - incremented by the number of bytes used & returned
 * @param string the C string to write
 */
void writeCString(unsigned char** pptr, const char* string)
{
	int len = strlen(string);
	writeInt(pptr, len);
	memcpy(*pptr, string, len);
	*pptr += len;
}

int MQTTPacket_encode(unsigned char* buf, int length)
{
	int rc = 0;

	//FUNC_ENTRY;
	do
	{
		char d = length % 128;
		length /= 128;
		/* if there are more digits to encode, set the top bit of this digit */
		if (length > 0)
			d |= 0x80;
		buf[rc++] = d;
	} while (length > 0);
	FUNC_EXIT_RC(rc);
	return rc;
}

int MQTTstrlen(MQTTString mqttstring)
{
	int rc = 0;

	if (mqttstring.cstring)
		rc = strlen(mqttstring.cstring);
	else
		rc = mqttstring.lenstring.len;
	return rc;
}

int MQTTSerialize_connectLength(MQTTPacket_connectData* options)
{
	int len = 0;

	//FUNC_ENTRY;

	if (options->MQTTVersion == 3)
		len = 12; /* variable depending on MQTT or MQIsdp */
	else if (options->MQTTVersion == 4)
		len = 10;

	len += MQTTstrlen(options->clientID)+2;
	if (options->willFlag)
		len += MQTTstrlen(options->will.topicName)+2 + MQTTstrlen(options->will.message)+2;
	if (options->username.cstring || options->username.lenstring.data)
		len += MQTTstrlen(options->username)+2;
	if (options->password.cstring || options->password.lenstring.data)
		len += MQTTstrlen(options->password)+2;

	FUNC_EXIT_RC(len);
	return len;
}

int MQTTPacket_len(int rem_len)
{
	rem_len += 1; /* header byte */

	/* now remaining_length field */
	if (rem_len < 128)
		rem_len += 1;
	else if (rem_len < 16384)
		rem_len += 2;
	else if (rem_len < 2097151)
		rem_len += 3;
	else
		rem_len += 4;
	return rem_len;
}

void writeMQTTString(unsigned char** pptr, MQTTString mqttstring)
{
	if (mqttstring.lenstring.len > 0)
	{
		writeInt(pptr, mqttstring.lenstring.len);
		memcpy(*pptr, mqttstring.lenstring.data, mqttstring.lenstring.len);
		*pptr += mqttstring.lenstring.len;
	}
	else if (mqttstring.cstring)
		writeCString(pptr, mqttstring.cstring);
	else
		writeInt(pptr, 0);
}

int MQTTSerialize_connect(unsigned char* buf, int buflen, MQTTPacket_connectData* options)
{
	unsigned char *ptr = buf;
	MQTTHeader header = {0};
	MQTTConnectFlags flags = {0};
	int len = 0;
	int rc = -1;

	//FUNC_ENTRY;
	if (MQTTPacket_len(len = MQTTSerialize_connectLength(options)) > buflen)
	{
		rc = MQTTPACKET_BUFFER_TOO_SHORT;
		goto exit;
	}

	header.byte = 0;
	header.bits.type = CONNECT;
	writeChar(&ptr, header.byte); /* write header */

	ptr += MQTTPacket_encode(ptr, len); /* write remaining length */

	if (options->MQTTVersion == 4)
	{
		writeCString(&ptr, "MQTT");
		writeChar(&ptr, (char) 4);
	}
	else
	{
		writeCString(&ptr, "MQIsdp");
		writeChar(&ptr, (char) 3);
	}

	flags.all = 0;
	flags.bits.cleansession = options->cleansession;
	flags.bits.will = (options->willFlag) ? 1 : 0;
	if (flags.bits.will)
	{
		flags.bits.willQoS = options->will.qos;
		flags.bits.willRetain = options->will.retained;
	}

	if (options->username.cstring || options->username.lenstring.data)
		flags.bits.username = 1;
	if (options->password.cstring || options->password.lenstring.data)
		flags.bits.password = 1;

	writeChar(&ptr, flags.all);
	writeInt(&ptr, options->keepAliveInterval);
	writeMQTTString(&ptr, options->clientID);
	if (options->willFlag)
	{
		writeMQTTString(&ptr, options->will.topicName);
		writeMQTTString(&ptr, options->will.message);
	}
	if (flags.bits.username)
		writeMQTTString(&ptr, options->username);
	if (flags.bits.password)
		writeMQTTString(&ptr, options->password);

	rc = ptr - buf;

	exit: FUNC_EXIT_RC(rc);
	return rc;
}

int MQTTSerialize_publishLength(int qos, MQTTString topicName, int payloadlen)
{
	int len = 0;

	len += 2 + MQTTstrlen(topicName) + payloadlen;
	if (qos > 0)
		len += 2; /* packetid */
	return len;
}


int MQTTSerialize_publish(unsigned char* buf, int buflen, unsigned char dup, int qos, unsigned char retained, unsigned short packetid,
		MQTTString topicName, unsigned char* payload, int payloadlen)
{
	unsigned char *ptr = buf;
	MQTTHeader header = {0};
	int rem_len = 0;
	int rc = 0;

	//FUNC_ENTRY;
	if (MQTTPacket_len(rem_len = MQTTSerialize_publishLength(qos, topicName, payloadlen)) > buflen)
	{
		rc = MQTTPACKET_BUFFER_TOO_SHORT;
		goto exit;
	}

	header.bits.type = PUBLISH;
	header.bits.dup = dup;
	header.bits.qos = qos;
	header.bits.retain = retained;
	writeChar(&ptr, header.byte); /* write header */

	ptr += MQTTPacket_encode(ptr, rem_len); /* write remaining length */;

	writeMQTTString(&ptr, topicName);

	if (qos > 0)
		writeInt(&ptr, packetid);

	memcpy(ptr, payload, payloadlen);
	ptr += payloadlen;

	rc = ptr - buf;

exit:
	FUNC_EXIT_RC(rc);
	return rc;
}

void createMQTTPackage(Gsm_Datas* gsm_data,LyraDatas *lyradata, GPS_Handle*gps_data, uint8_t* packBuf, uint16_t *index)
{
	AESK_UINT8toUINT8CODE(&lyradata->vcu_data.wake_up_union.wake_up_u8, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata->vcu_data.set_velocity_u8, packBuf, index);
	int16_t phase_a_current_s16 = (int16_t)(lyradata->driver_data.Phase_A_Current_f32 * FLOAT_CONVERTER_2);
	int16_t phase_b_current_s16 = (int16_t)(lyradata->driver_data.Phase_B_Current_f32 * FLOAT_CONVERTER_2);
	uint16_t dc_bus_voltage_u16 = (uint16_t)(lyradata->driver_data.Dc_Bus_voltage_f32 * FLOAT_CONVERTER_1);
	int16_t dc_bus_current_s16 = (int16_t)(lyradata->driver_data.Dc_Bus_Current_f32 * FLOAT_CONVERTER_2);
	int16_t id_f32 = (int16_t)(lyradata->driver_data.Id_f32 * FLOAT_CONVERTER_2);
	int16_t iq_f32 = (int16_t)(lyradata->driver_data.Iq_f32 * FLOAT_CONVERTER_2);
	int16_t IArms_f32 = (int16_t)(lyradata->driver_data.IArms_f32 * FLOAT_CONVERTER_2);
	int16_t IBrms_f32 = (int16_t)(lyradata->driver_data.Torque_f32 * FLOAT_CONVERTER_2);
	AESK_INT16toUINT8_LE(&phase_a_current_s16, packBuf, index);
	AESK_INT16toUINT8_LE(&phase_b_current_s16, packBuf, index);
	AESK_INT16toUINT8_LE(&dc_bus_current_s16, packBuf, index);
	AESK_UINT16toUINT8_LE(&dc_bus_voltage_u16, packBuf, index);
	AESK_INT16toUINT8_LE(&id_f32, packBuf, index);
	AESK_INT16toUINT8_LE(&iq_f32, packBuf, index);
	AESK_INT16toUINT8_LE(&IArms_f32, packBuf, index);
	AESK_INT16toUINT8_LE(&IBrms_f32, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.drive_status_union.drive_status_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.driver_error_union.driver_error_u8), packBuf, index);
	AESK_UINT32toUINT8_LE(&(lyradata->driver_data.Odometer_u32), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.Motor_Temperature_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.actual_velocity_u8), packBuf, index);
	uint16_t bat_volt_u16 = (uint16_t)(lyradata->bms_data.Bat_Voltage_f32 * FLOAT_CONVERTER_2);
	int16_t  bat_cur_s16 = (int16_t)(lyradata->bms_data.Bat_Current_f32 * FLOAT_CONVERTER_2);
	uint16_t bat_cons_u16 = (uint16_t)(lyradata->bms_data.Bat_Cons_f32 * FLOAT_CONVERTER_1);
	uint16_t soc_u16 = (uint16_t)(lyradata->bms_data.Soc_f32 * FLOAT_CONVERTER_2);
	uint16_t worst_cell_voltage_u16 = (uint16_t)(lyradata->bms_data.Worst_Cell_Voltage_f32 * FLOAT_CONVERTER_1);
	AESK_UINT16toUINT8_LE(&bat_volt_u16, packBuf, index);
	AESK_INT16toUINT8_LE(&bat_cur_s16, packBuf, index);
	AESK_UINT16toUINT8_LE(&bat_cons_u16, packBuf, index);
	AESK_UINT16toUINT8_LE(&soc_u16, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_error.bms_error_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.dc_bus_state.dc_bus_state_u8), packBuf, index);
	AESK_UINT16toUINT8_LE(&worst_cell_voltage_u16, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.Worst_Cell_Address_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.Temperature_u8), packBuf, index);
	uint32_t latitude_u32 = gps_data->latitude_f32 * GPS_CONVERTER;
	uint32_t longtitude_u32 = gps_data->longtitude_f32 * GPS_CONVERTER;
	AESK_UINT32toUINT8_LE(&(latitude_u32), packBuf, index);
	AESK_UINT32toUINT8_LE(&(longtitude_u32), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data->speed_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data->satellite_number_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data->gpsEfficiency_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_1_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_2_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_3_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_4_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_5_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_6_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_7_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_8_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_9_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_10_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_11_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_12_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_13_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_14_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_15_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_16_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_17_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_18_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_19_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_20_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_21_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_22_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_23_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_24_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_25_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_26_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_27_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_28_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->can_error.can_error_u8), packBuf, index);
	gsm_data->MQTT_Counter++;
	AESK_UINT32toUINT8_LE(&(gsm_data->MQTT_Counter), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_1_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_2_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_3_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_4_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_5_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_6_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_7_u8), packBuf, index);
	
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_1_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_2_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_3_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_4_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_5_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_6_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_7_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_8_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_9_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_10_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_11_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_12_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_13_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_14_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_15_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_16_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_17_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_18_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_19_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_20_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_21_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_22_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_23_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_24_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_25_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_26_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_27_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_28_u8), packBuf, index);
}
