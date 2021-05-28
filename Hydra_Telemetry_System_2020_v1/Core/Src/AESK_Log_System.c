/*
 * AESK_Log_System.c
 *
 *  Created on: 26 Şub 2021
 *      Author: Yusuf
 */

#include "AESK_Log_System.h"

char *SDHeader =
		"Time\t"
		"Drive_Command\t"
		"Speed_Set_RPM\t"
		"Speed_Set_Torque\t"
		"Speed_Limit\t"
		"Torque_Limit\t"
		"Bat_Voltage\t"
		"Bat_Current\t"
		"Bat_Consumption\t"
		"SoC\t"
		"BMS_Error\t"
		"DC_Bus_State\t"
		"Worst_Cell_Voltage\t"
		"Worst_Cell_Address\t"
		"BMS_Temperature\t"
		"Lattitude\t"
		"Longtitude\t"
		"Speed\t\n";


void vars_to_str(char *buffer, const char *format, ...)
{
	va_list args;
	va_start(args, format);
	vsprintf(buffer, format, args);
	va_end(args);
}

uint8_t a_char = 97;
uint8_t e_char = 101;
uint8_t s_char = 115;
uint8_t k_char = 107;
uint8_t endlinechar = 10;

uint16_t CreateLogBuffer(LyraDatas lyradata, GPS_Handle gps_data, uint8_t* packBuf, uint16_t* index)
{
	HAL_RTC_GetTime(&hrtc, &sTime, RTC_FORMAT_BIN);
	HAL_RTC_GetDate(&hrtc, &sDate, RTC_FORMAT_BIN);
	//RTC
	AESK_UINT8toUINT8CODE(&sTime.Minutes, packBuf, index);
	AESK_UINT8toUINT8CODE(&sTime.Seconds, packBuf, index);

	//VCU
	AESK_UINT8toUINT8CODE(&lyradata.vcu_data.drive_command_union.drive_command_u8, packBuf, index);
	AESK_UINT16toUINT8_LE(&lyradata.vcu_data.speed_set_rpm_u16, packBuf, index);
	AESK_INT16toUINT8_LE(&lyradata.vcu_data.set_torque_s16, packBuf, index);
	AESK_UINT16toUINT8_LE(&lyradata.vcu_data.speed_limit_u16, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.vcu_data.torque_limit_u8, packBuf, index);

	//MCU
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.ID_Act_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.ID_Act_H, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.IQ_Act_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.IQ_Act_H, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.VD_Act_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.VD_Act_H, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.VQ_Act_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.VQ_Act_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.ID_Set_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.ID_Set_H, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.IQ_Set_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.IQ_Set_H, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.set_torque_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.set_torque_H, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.IDC_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.IDC_H, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.VDC_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.VDC_H, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.act_speed_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.act_speed_H, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.motor_temp, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.error_status_L, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.error_status_H, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata.driver_data.act_torque, packBuf, index);

	//BMS
	uint16_t bat_volt_u16 = (uint16_t) (lyradata.bms_data.Bat_Voltage_f32 * FLOAT_CONVERTER_2);
	int16_t bat_cur_s16 = (int16_t) (lyradata.bms_data.Bat_Current_f32 * FLOAT_CONVERTER_2);
	uint16_t bat_cons_u16 = (uint16_t) (lyradata.bms_data.Bat_Cons_f32 * FLOAT_CONVERTER_1);
	uint16_t soc_u16 = (uint16_t) (lyradata.bms_data.Soc_f32 * FLOAT_CONVERTER_2);
	uint16_t worst_cell_voltage_u16 = (uint16_t) (lyradata.bms_data.Worst_Cell_Voltage_f32 * FLOAT_CONVERTER_1);
	AESK_UINT16toUINT8_LE(&bat_volt_u16, packBuf, index);
	AESK_INT16toUINT8_LE(&bat_cur_s16, packBuf, index);
	AESK_UINT16toUINT8_LE(&bat_cons_u16, packBuf, index);
	AESK_UINT16toUINT8_LE(&soc_u16, packBuf, index);
	AESK_UINT16toUINT8_LE(&worst_cell_voltage_u16, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata.bms_data.bms_error.bms_error_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata.bms_data.dc_bus_state.dc_bus_state_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata.bms_data.Worst_Cell_Address_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata.bms_data.Temperature_u8), packBuf, index);

	//GPS
	uint32_t latitude_u32 = gps_data.latitude_f32 * GPS_CONVERTER;
	uint32_t longtitude_u32 = gps_data.longtitude_f32 * GPS_CONVERTER;
	AESK_UINT32toUINT8_LE(&(latitude_u32), packBuf, index);
	AESK_UINT32toUINT8_LE(&(longtitude_u32), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data.speed_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data.satellite_number_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data.gpsEfficiency_u8), packBuf, index);

	//CAN error
	//AESK_UINT8toUINT8CODE(&(lyradata.can_error.can_error_u8), packBuf, index);

	//End line indicator
	AESK_UINT8toUINT8CODE(&(a_char), packBuf, index);
	AESK_UINT8toUINT8CODE(&(e_char), packBuf, index);
	AESK_UINT8toUINT8CODE(&(s_char), packBuf, index);
	AESK_UINT8toUINT8CODE(&(k_char), packBuf, index);
	AESK_UINT8toUINT8CODE(&(endlinechar), packBuf, index);
	return *index;
}

//Dosyanın başına başlık ekleme fonksiyonu. Eski kodun revize edilmiş hali.
//f_close silindi, çünkü yeni sistemde f_sync fonksiyonu kullanılıyor.
//Şu anda fonksiyon, header eklemesi yapmıyor. f_write bulunan satırı yorumdan
//çıkarırsanız ilk satıra header eklemesi yapar. Bunu yaparsanız bu satırları silin.
void LogStart(Sd_Card_Data *sdcard_data)
{
	sdcard_data->result = f_mount(&sdcard_data->myFATAFS, (TCHAR const*) SDPath, 1);
	if (sdcard_data->result == FR_OK)
	{
		HAL_RTC_GetTime(&hrtc, &sTime, RTC_FORMAT_BIN);
		HAL_RTC_GetDate(&hrtc, &sDate, RTC_FORMAT_BIN);
		vars_to_str(sdcard_data->path, "%d_%d_%d_%d_%d_%d_(%d).txt", sDate.Date, sDate.Month, sDate.Year, sTime.Hours, sTime.Minutes, sTime.Seconds, sdcard_data->logger_u32);

		sdcard_data->result_open = f_open(&sdcard_data->myFile, sdcard_data->path, FA_WRITE | FA_OPEN_APPEND | FA_OPEN_EXISTING | FA_OPEN_ALWAYS);
		f_write(&sdcard_data->myFile, SDHeader, strlen(SDHeader), (void*) &sdcard_data->writtenbyte);
		sdcard_data->state = SD_Card_Detect;
		f_close(&sdcard_data->myFile);
	}
}

void LogDataInit(LyraDatas* lyradata, GPS_Handle* gpsdata)
{
	//VCU
	lyradata->vcu_data.drive_command_union.drive_command_u8 	= 21;
	lyradata->vcu_data.speed_set_rpm_u16 						= 21;
	lyradata->vcu_data.set_torque_s16 						= 22;
	lyradata->vcu_data.speed_limit_u16 						= 22;
	lyradata->vcu_data.torque_limit_u8 						= 22;

	//Driver
	lyradata->driver_data.IDC_H					= 0;
	lyradata->driver_data.IDC_L					= 0;
	lyradata->driver_data.VDC_H					= 0;
	lyradata->driver_data.VDC_L					= 0;
	lyradata->driver_data.ID_Act_H				= 0;
	lyradata->driver_data.ID_Act_L				= 0;
	lyradata->driver_data.IQ_Act_H				= 0;
	lyradata->driver_data.IQ_Act_L				= 0;
	lyradata->driver_data.IQ_Set_H				= 0;
	lyradata->driver_data.IQ_Set_L				= 0;
	lyradata->driver_data.ID_Set_H				= 0;
	lyradata->driver_data.ID_Set_L				= 0;
	lyradata->driver_data.act_speed_H			= 0;
	lyradata->driver_data.act_speed_L			= 0;
	lyradata->driver_data.act_torque			= 0;
	lyradata->driver_data.error_status_L		= 0;
	lyradata->driver_data.error_status_H		= 0;
	lyradata->driver_data.VD_Act_H				= 0;
	lyradata->driver_data.VD_Act_L				= 0;
	lyradata->driver_data.VQ_Act_H				= 0;
	lyradata->driver_data.VQ_Act_L				= 0;
	lyradata->driver_data.set_torque_H			= 0;
	lyradata->driver_data.set_torque_L			= 0;
	lyradata->driver_data.motor_temp 			= 0;

	//BMS
	lyradata->bms_data.Bat_Cons_f32 							= 0;
	lyradata->bms_data.Bat_Current_f32 							= 0;
	lyradata->bms_data.Bat_Voltage_f32 							= 0;
	lyradata->bms_data.Soc_f32 									= 0;
	lyradata->bms_data.Temperature_u8 							= 0;
	lyradata->bms_data.Worst_Cell_Address_u8 					= 0;
	lyradata->bms_data.Worst_Cell_Voltage_f32 					= 0;
	lyradata->bms_data.bms_error.bms_error_u8 					= 0;
	lyradata->bms_data.dc_bus_state.dc_bus_state_u8 			= 0;

	//GPS
	gpsdata->latitude_f32 = 0;
	gpsdata->longtitude_f32 = 0;
	gpsdata->satellite_number_u8 = 0;
	gpsdata->gpsEfficiency_u8 = 0;
	gpsdata->speed_u8 = 0;

	//CAN error
	lyradata->can_error.can_error_u8 							= 0;

	lyradata->bms_data.bms_cells.Cell_1_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_2_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_3_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_4_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_5_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_6_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_7_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_8_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_9_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_10_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_11_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_12_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_13_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_14_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_15_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_16_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_17_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_18_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_19_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_20_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_21_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_22_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_23_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_24_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_25_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_26_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_27_u8 = 0;
	lyradata->bms_data.bms_cells.Cell_28_u8 = 0;

	lyradata->bms_data.bms_temps.temp_1_u8 = 0;
	lyradata->bms_data.bms_temps.temp_2_u8 = 0;
	lyradata->bms_data.bms_temps.temp_3_u8 = 0;
	lyradata->bms_data.bms_temps.temp_4_u8 = 0;
	lyradata->bms_data.bms_temps.temp_5_u8 = 0;
	lyradata->bms_data.bms_temps.temp_6_u8 = 0;
	lyradata->bms_data.bms_temps.temp_7_u8 = 0;

	lyradata->bms_data.bms_soc.offset_SoC_1_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_2_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_3_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_4_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_5_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_6_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_7_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_8_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_9_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_10_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_11_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_12_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_13_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_14_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_15_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_16_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_17_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_18_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_19_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_20_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_21_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_22_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_23_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_24_u8 = 33;
	lyradata->bms_data.bms_soc.offset_SoC_25_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_26_u8 = 33;
	lyradata->bms_data.bms_soc.offset_SoC_27_u8 = 0;
	lyradata->bms_data.bms_soc.offset_SoC_28_u8 = 33;

}

FRESULT result_write;
//Yeni kod. Çalışıyor. Açıklamalar .h dosyasında
void LogAsBuffer(LyraDatas lyradata, GPS_Handle gps_data, Sd_Card_Data *sd_card_data)
{
	uint16_t indexo = 0;
	if (sd_card_data->result == FR_OK)
	{
		sd_card_data->bytes_u32 = CreateLogBuffer(lyradata, gps_data, (uint8_t*) (sd_card_data->transmitBuf), &indexo);
		sd_card_data->result_write = f_write(&sd_card_data->myFile, sd_card_data->transmitBuf, sd_card_data->bytes_u32, &(sd_card_data->writtenbyte));

	}
}

uint8_t a;
void LogAsString(LyraDatas lyradata, GPS_Handle gps_data, Sd_Card_Data *sd_card_data)
{
	HAL_RTC_GetTime(&hrtc, &sTime, RTC_FORMAT_BIN);
	HAL_RTC_GetDate(&hrtc, &sDate, RTC_FORMAT_BIN);
	vars_to_str((char*) sd_card_data->transmitBuf, "%d\t%d\t%d\t%d\t%d\t%.2f\t%.2f\t%.1f\t%.2f\t%d\t%d\t%.1f\t%d\t%d\t%.6f\t%.6f\t%d\n",
			lyradata.vcu_data.drive_command_union.drive_command_u8,
			lyradata.vcu_data.speed_set_rpm_u16,
			lyradata.vcu_data.set_torque_s16,
			lyradata.vcu_data.speed_limit_u16,
			lyradata.vcu_data.torque_limit_u8,
			lyradata.bms_data.Bat_Voltage_f32,
			lyradata.bms_data.Bat_Current_f32,
			lyradata.bms_data.Bat_Cons_f32,
			lyradata.bms_data.Soc_f32,
			lyradata.bms_data.bms_error.bms_error_u8,
			lyradata.bms_data.dc_bus_state.dc_bus_state_u8,
			lyradata.bms_data.Worst_Cell_Voltage_f32,
			lyradata.bms_data.Worst_Cell_Address_u8,
			lyradata.bms_data.Temperature_u8,
			gps_data.latitude_f32,
			gps_data.longtitude_f32,
			gps_data.speed_u8);

	vars_to_str((char*) sd_card_data->total_log, "%d:%d:%d\t", sTime.Hours, sTime.Minutes, sTime.Seconds);
	strcat(sd_card_data->total_log, (const char*) sd_card_data->transmitBuf);
	sd_card_data->result_open = f_open(&sd_card_data->myFile, sd_card_data->path,
			FA_WRITE | FA_OPEN_APPEND | FA_OPEN_EXISTING | FA_OPEN_ALWAYS);
	sd_card_data->result_write = f_write(&sd_card_data->myFile, sd_card_data->total_log, strlen(sd_card_data->total_log), (void*) &sd_card_data->writtenbyte);
	if(sd_card_data->result_write == FR_INVALID_OBJECT)
	{
		a = 0;
	}
	if ((sd_card_data->writtenbyte != 0) && (sd_card_data->result_write == FR_OK))
	{
		sd_card_data->result_close = f_close(&sd_card_data->myFile);
		if(sd_card_data->result_close == FR_DISK_ERR)
		{
			sd_card_data->result_close = f_close(&sd_card_data->myFile);
		}
	}

	else
	{
		sd_card_data->result = f_mount(&sd_card_data->myFATAFS, (TCHAR const*) SDPath, 1);
	}
}
