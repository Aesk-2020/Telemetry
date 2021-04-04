/*
 * TelemetryGlobalVar.h
 *
 *  Created on: 5 Oca 2020
 *      Author: yemrelaydin
 */
#include "stdint.h"
#include "ff.h"
#ifndef TELEMETRYGLOBALVAR_H_
#define TELEMETRYGLOBALVAR_H_
#define TRUE 								1
#define FALSE               0

#define FIRST_CONTROL_BYTE		0x34
#define	SECOND_CONTROL_BYTE		0xFF
#define FIRST_COMMAND					0xAF
#define SECOND_COMMAND				0xBF

#define HYDRAHEADER						0x31
typedef union
{
	struct
	{
		uint16_t Task_10_ms  	: 1;
		uint16_t Task_50_ms		: 1;
		uint16_t Task_80_ms  	: 1;
		uint16_t Task_100_ms	: 1;
		uint16_t Task_170_ms	: 1;
		uint16_t Task_150_ms 	: 1;
		uint16_t Task_200_ms   	: 1;
		uint16_t Task_250_ms	: 1;
		uint16_t Task_300_ms	: 1;
		uint16_t Task_500_ms	: 1;
		uint16_t Task_1000_ms	: 1;
		uint16_t Task_5000_ms	: 1;
		uint16_t reserved    	: 4;

	}Time_Task;
	uint16_t time_task_u16;
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
	uint8_t transmitBuf[400];
	char path[200];
	uint8_t state;
	char total_log[400];
	uint32_t logger_u32;
	FRESULT result;
	uint32_t writtenbyte;
	FATFS myFATAFS;
	FIL myFile;
}Sd_Card_Datas;

typedef struct
{
	uint8_t states;
	uint8_t receiveData;
	uint8_t transmitBuf[200];
	uint16_t xbee_index;
	uint16_t crc;
}Xbee_Datas;
#endif /* TELEMETRYGLOBALVAR_H_ */
