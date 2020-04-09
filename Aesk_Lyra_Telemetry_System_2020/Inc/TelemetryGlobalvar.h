/*
 * TelemetryGlobalVar.h
 *
 *  Created on: 5 Oca 2020
 *      Author: yemrelaydin
 */
#include "stdint.h"
#ifndef TELEMETRYGLOBALVAR_H_
#define TELEMETRYGLOBALVAR_H_
#define TRUE 				1
#define FALSE               0


#define 	Gsm_Kontrol_Port 	GPIOE
#define		KALIBRASYON_TAMAM	"OK"
#define		KALIBRASYON_HATA	"ERROR"
#define  	GPRS_AYARLA			"AT+SAPBR=3,1,\"CONTYPE\",\"GPRS\"\n"
#define		GENEL_AGA_AYARLA    "AT+SAPBR=3,1,\"APN\",\"internet\"\n"
#define		GENEL_AGA_BAGLAN	"AT+SAPBR=1,1\n"
#define		HTTP_INIT			"AT+HTTPINIT\n"
#define 	HTTP_PARAMETER		"AT+HTTPPARA=\"CID\",1\n"
#define 	GSM_Serial			huart2
#define   	XBEE_Serial		    huart4
#define		GPS_Serial			huart3
typedef union
{
	struct
	{
		uint8_t Task_10_Hz  : 1;
		uint8_t	Task_5_Hz	: 1;
		uint8_t Task_2_Hz	: 1;
		uint8_t Task_1_Hz   : 1;
		uint8_t reserved    : 4;

	}Time_Task_u8;
}Time_Task_union;

typedef enum
{
	ID_Control = 0,
	Reset_Data_Control = 1,
	End_Communication_Control_1 = 2,
	End_Communication_Control_2 = 3,
}Xbee_Gsm_Configuration;

typedef enum
{
	NO_SD_Card_Detect = 0,
	SD_Card_Detect = 1,
}SD_Card_States;
typedef enum
{
	N_Gprs_Connection = 0,
	N_Internet_Connection = 1,
	N_Login_Internet = 2,
	N_Http_Init = 3,
	N_Http_Parameter = 4,
	N_Send_Data_Server = 5,
	N_Delay_1 = 6,
	N_Delay_2 = 7,
	N_Delay_3 = 8,
	N_Delay_4 = 9,
	N_Delay_5 = 10,
	N_Delay_6 = 11,
	N_Delay_7 = 12,
	N_Delay_8 = 13,
	N_Delay_9 = 14,
	N_Delay_10 = 15,
	N_Delay_11 = 16,
	N_Delay_12 = 17,
	N_Delay_13 = 18,
	N_Delay_14 = 19,
}Gsm_Calibration_States;

typedef struct
{
	uint8_t states;
	uint8_t receiveData;
	uint8_t receiveBuf[50];
	uint8_t transmitBuf[200];

}Gsm_Datas;

typedef struct
{
	uint8_t transmitBuf[200];
	char path[200];
	uint8_t state;

}Sd_Card_Datas;

typedef struct
{
	uint8_t states;
	uint8_t receiveData;
	uint8_t transmitBuf[200];
}Xbee_Datas;
#endif /* TELEMETRYGLOBALVAR_H_ */
