/*
 * AESK_Log_System.h
 *
 *  Created on: 26 Şub 2021
 *      Author: Yusuf
 *      Contact: ykemalpalaci@gmail.com
 */

/*
 *
 * Bu kütüphane, log işlemleri için 2 seçenek sunar.
 * Bu seçenekler aşağıda prototipleri verilen LogAsString ve LogAsBuffer
 * fonksiyonlarıdır. Açıklamaları üstlerinde yapılmıştır.
 *
 */

#ifndef INC_AESK_LOG_SYSTEM_H_
#define INC_AESK_LOG_SYSTEM_H_

#include "stdint.h"
#include "string.h"
#include "ff.h"
#include "fatfs.h"
#include "Can_Lyra_Header.h"
#include "stm32f4xx_hal_rtc.h"
#include "AESK_Gps_lib.h"
#include "stdarg.h"
#include "AESK_Data_Pack_lib.h"
#include "stdio.h"

/*
 * RTC değişkenleri, sadece bu blokta ve read only olarak kullanılacağı
 * için tanımlamalar burada yapılmıştır.
 */
RTC_TimeTypeDef sTime;
RTC_DateTypeDef sDate;
RTC_HandleTypeDef hrtc;

typedef enum
{
	NO_SD_Card_Detect = 0,
	SD_Card_Detect = 1,
}SD_Card_States;

//ESKİ KODA AİT BAZI KULLANILMAYAN DEĞİŞKENLER VAR BUNLARI MUTLAKA SİLİN Bİ ARA
typedef struct
{
	uint8_t transmitBuf[100];
	char path[200];
	uint8_t state;
	char total_log[400];
	uint32_t logger_u32;
	uint32_t bytes_u32;
	uint32_t errorcounter_u32;
	FRESULT result;
	FRESULT result_open;
	FRESULT result_write;
	FRESULT result_sync;
	FRESULT result_close;
	uint8_t minute;
	unsigned int writtenbyte;
	FATFS myFATAFS;
	FIL myFile;
}Sd_Card_Data;


void vars_to_str(char *buffer, const char *format, ...);
uint16_t CreateLogBuffer(LyraDatas lyradata, GPS_Handle gps_data, uint8_t* packBuf, uint16_t* index);

/*
 * LogStart fonksiyonu, SD kartı yazılımsal olarak takar ve kaydı başlatır.
 * .txt uzantılı dosyanın ilk satırına verilerin başlığını ekler.
 * Başlık metni .c dosyasında tanımlanmıştır.
 */
void LogStart(Sd_Card_Data* sdcard_data);

/*
 * LogDataInit fonksiyonu, kaydı alınacak verilerin bulunduğu struct'taki
 * değerleri 0 ile ilklendirir. Eğer veriler ilklendirilmeden kayıt
 * alınmaya çalışılsaydı CreateLogBuffer fonksiyonuna gelen lyradata ve
 * gpsdata yapılarındaki değişkenler, "NULL" değerinde olacağı için bu fonksiyon
 * LogAsBuffer fonksiyonuna NULL değerlerine sahip bir transmit buffer
 * gönderecek ve bu nedenle LogAsBuffer fonksiyonu hiçbir değer kaydetmeyecekti.
 */
void LogDataInit(LyraDatas* lyradata, GPS_Handle* gpsdata);

/*
 * LogAsString fonksiyonu, verileri 2020 yılı telemetri sistemindeki
 * biçime göre kaydeder. Bu biçim tüm verilerin excel'e direkt aktarılabileceği
 * bir biçimdir. Dezavantajı çok fazla string işleminin bulunmasından dolayı
 * işlem yükünün fazla olmasıdır.
 *
 */
void LogAsString(LyraDatas lyradata, GPS_Handle gps_data, Sd_Card_Data* sd_card_data);

/*
 * LogAsBuffer fonksiyonu, verileri CAN veya RS485 hattından geldiği gibi bir byte
 * dizisi olarak kaydeder. Bu fonksiyon ile oluşturulan kaydı açabilmek için
 * AESK Telemetry 2021 uygulaması gerekmektedir. Bu fonksiyonu x periyotlu bir
 * taskta çağırıyorsanız en az 2x periyotlu başka bir taskta LogSync fonksiyonunu
 * çağırın.
 */
void LogAsBuffer(LyraDatas lyradata, GPS_Handle gps_data, Sd_Card_Data* sd_card_data);

#endif /* INC_AESK_LOG_SYSTEM_H_ */
