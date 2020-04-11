/*
 * AESK_Gps_lib.c
 *
 *  Created on: 20 Eki 2019
 *      Author: yemrelaydin
 */

#include <AESK_GPS_lib.h>

void AESK_Receive_Interrupt_Control(UART_HandleTypeDef *huart, GPS_Handle *gpsDatas)
{
	HAL_UART_Receive_IT(huart, &gpsDatas->uartReceiveData_u8, SIZE_OF_INTERRUPT);
}
uint16_t CHECKSUM_Find(const char *data)
{
	uint16_t CHK;
	CHK = Hex2Int(*(strchr(data, '*') + 1)) * 16 + Hex2Int(*(strchr(data, '*') + 2));
	return CHK;
}


uint16_t NMEA_CheckSum(const char * data)
{
	uint16_t CHK = 0;
	char *startSearch = strchr(data, '$') + 2;
	char *finishSearch = strchr(data, '*');

	while(startSearch != finishSearch)
	{
		CHK ^= *startSearch;
		startSearch++;
	}
	return CHK;
}



uint8_t Hex2Int(char c)
{
	uint8_t result = 0;
	if (c >= '0' && c <= '9')
	{
	result = c - '0';
	}
	if (c >= 'A' && c <= 'F')
	{
	result = c - 'A' + 10;
	}
	if (c >= 'a' && c <= 'f')
	{
	result = c - 'a' + 10;
	}
	return result;
}



char* Find_Comma_Address(const char * data, uint8_t commaNumber)
{
	char* startAddress = (char *)data;

	while (commaNumber)
	{
		if (*(startAddress) == ',')
		{
			commaNumber--;
			startAddress++;
		}
		else
		{
			startAddress++;
		}
	}
	return startAddress;
}


double convertDegMinToDecDeg(float degMin)
{
	double min = 0.0;
	double decDeg = 0.0;

	//get the minutes, fmod() requires double
	min = fmod((double)degMin, 100.0);

	//rebuild coordinates in decimal degrees
	degMin = (int)(degMin / 100);
	decDeg = degMin + (min / 60);

	return decDeg;
}


void GPS_Control(GPS_Handle *gpsDatas)
{
	if(gpsDatas->uartReceiveData_u8 != FINAL_CHARACTER)
	{
		gpsDatas->gpsDatasArray[gpsDatas->indeks_u16++] = gpsDatas->uartReceiveData_u8;
	}

	else
	{
		GPRMC_Parser(gpsDatas);
		gpsDatas->indeks_u16 = 0;
		memset(gpsDatas->gpsDatasArray, '0', BUFFER_SIZE);
	}
}
/* $GPRMC
 * $GPRMC,hhmmss.ss,A,llll.ll,a,yyyyy.yy,a,x.x,x.x,ddmmyy,x.x,a*hh
 * ex: $GPRMC,105508.00,A,3814.47700,N,02719.03213,E,0.640,,081115,,,A*73,
 *
 * WORDS:
 *  0    = $GPRMC - Recommended Minimum Specific GNSS Data
 *  1    = UTC of position fix
 *  2    = Data status (V=navigation receiver warning, A: Valid)
 *  3    = Latitude of fix
 *  4    = N or S
 *  5    = Longitude of fix
 *  6    = E or W
 *  7    = Speed over ground in knots
 *  8    = Track made good in degrees NMEA_TRUE, Bearing This indicates the direction that the device is currently moving in, from 0 to 360, measured in ?azimuth?.
 *  9    = UT date
 *  10   = Magnetic variation degrees (Easterly var. subtracts from NMEA_TRUE course)
 *  11   = E or W
 *  12   = Checksum
*/

void GPRMC_Parser(GPS_Handle *gpsDatas)
{
	char* startAddress = strstr((const char*)gpsDatas->gpsDatasArray, "$GPRMC");
	if (startAddress && gpsDatas->gpsDatasArray[0] == '$')
	{
		if (NMEA_CheckSum((const char *)gpsDatas->gpsDatasArray) == CHECKSUM_Find((const char *)gpsDatas->gpsDatasArray))
		{
			if (*Find_Comma_Address((const char *)gpsDatas->gpsDatasArray, VALID_CONTROL_COMMA) == 'A')
			{
				memcpy(gpsDatas->gpsLatitudeArray, Find_Comma_Address((const char *)gpsDatas->gpsDatasArray, LATITUDE_START_COMMA), Find_Comma_Address((const char *)gpsDatas->gpsDatasArray, LATITUDE_STOP_COMMA) - Find_Comma_Address((const char *)gpsDatas->gpsDatasArray, LATITUDE_START_COMMA) - 1);
				memcpy(gpsDatas->gpsLongtitudeArray, Find_Comma_Address((const char *)gpsDatas->gpsDatasArray, LONGTITUDE_START_COMMA), Find_Comma_Address((const char *)gpsDatas->gpsDatasArray, LONGTITUDE_STOP_COMMA) - Find_Comma_Address((const char *)gpsDatas->gpsDatasArray, LONGTITUDE_START_COMMA) - 1);
				memcpy(gpsDatas->gpsSpeedKnotArray, Find_Comma_Address((const char *)gpsDatas->gpsDatasArray, KNOT_START_COMMA), Find_Comma_Address((const char *)gpsDatas->gpsDatasArray, KNOT_STOP_COMMA) - Find_Comma_Address((const char *)gpsDatas->gpsDatasArray, KNOT_START_COMMA) - 1);
				gpsDatas->speed_u8 = atoi((const char *)gpsDatas->gpsSpeedKnotArray) * KNOT_TO_KMH_CONVERTER;
			    gpsDatas->latitude_f32 = (float)convertDegMinToDecDeg(atof(gpsDatas->gpsLatitudeArray));
			    gpsDatas->longtitude_f32 = (float)convertDegMinToDecDeg(atof(gpsDatas->gpsLongtitudeArray));
			    gpsDatas->gps_errorhandler.trueData_u32++;


			 }

			else
			{
				gpsDatas->gps_errorhandler.validDataError_u32++;
			}
		}

		else
		{
			gpsDatas->gps_errorhandler.checksumError_u32++;
		}

	}

	else
	{
		gpsDatas->gps_errorhandler.headerError_u32++;
	}

	gpsDatas->gpsEfficiency_u8 = ((float)gpsDatas->gps_errorhandler.trueData_u32 /(gpsDatas->gps_errorhandler.checksumError_u32 + gpsDatas->gps_errorhandler.headerError_u32 + gpsDatas->gps_errorhandler.validDataError_u32 + gpsDatas->gps_errorhandler.trueData_u32) * PERCENTAGE_CONVERTER);
}
