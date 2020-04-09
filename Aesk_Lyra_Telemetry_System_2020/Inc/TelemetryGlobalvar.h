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
