/*
 * SIM800MQTT.c
 *
 *  Created on: 9 Nis 2020
 *      Author: yemrelaydin
 */
#include "SIM800MQTT.h"
#include "StackTrace.h"
#include "string.h"
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
