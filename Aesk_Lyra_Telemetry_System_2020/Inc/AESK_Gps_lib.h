/*
 * AEKS_Gps_lib.h
 *
 *  Created on: 20 Eki 2019
 *      Author: yemrelaydin
 */

#ifndef AEKS_GPS_LIB_H_
#define AEKS_GPS_LIB_H_
#include "main.h"
#include "stdint.h"
#include "math.h"
#include "string.h"
#include "stdlib.h"
#define BUFFER_SIZE  						512
#define SIZE_OF_INTERRUPT					1
#define FINAL_CHARACTER						'\n'
#define VALID_CONTROL_COMMA 				2
#define LATITUDE_START_COMMA 				3
#define LATITUDE_STOP_COMMA 				4
#define LONGTITUDE_START_COMMA				5
#define LONGTITUDE_STOP_COMMA				6
#define KNOT_START_COMMA					7
#define KNOT_STOP_COMMA						8
#define KNOT_TO_KMH_CONVERTER				1.852
#define PERCENTAGE_CONVERTER				100
typedef struct
{
	uint32_t checksumError_u32;
	uint32_t validDataError_u32;
	uint32_t trueData_u32;
}GPS_ErrorHandle;



typedef struct
{
	uint16_t indeks_u16;
	uint8_t uartReceiveData_u8;
	uint8_t gpsDatasArray[BUFFER_SIZE];
	char gpsLatitudeArray[20];
	char gpsLongtitudeArray[20];
	char gpsSpeedKnotArray[20];
	char gpsSatelliteNumberArray[20];
	float latitude_f32;
	float longtitude_f32;
	uint8_t speed_u8;
	uint8_t gpsEfficiency_u8;
	uint8_t satellite_number_u8;
	GPS_ErrorHandle gps_errorhandler;

}GPS_Handle;


void AESK_Receive_Interrupt_Control(UART_HandleTypeDef *huart, GPS_Handle *gpsDatas);
void GPRMC_Parser(GPS_Handle *gpsDatas);
void GPS_Control(GPS_Handle *gpsDatas);
uint16_t CHECKSUM_Find(const char *data);
uint16_t NMEA_CheckSum(const char * data, char* startSearch);
uint8_t Hex2Int(char c);
char* Find_Comma_Address(const char * data, uint8_t commaNumber);
double convertDegMinToDecDeg(float degMin);

#endif /* AEKS_GPS_LIB_H_ */
