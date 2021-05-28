/*
 * AESK_comm_pro.h
 *
 *  Created on: Nov 28, 2020
 *      Author: basri
 */

#ifndef SRC_AESK_COMM_PRO_H_
#define SRC_AESK_COMM_PRO_H_

#include "AESK_Ring_Buffer.h"

#define HEADER_CONST1  		0x14
#define HEADER_CONST2  		0x04
#define MAX_MSG_SIZE   		255
#define OFFSET         		7
#define TOTAL_HARDWARE_NO	65
#define MAX_MSG_ID			20

typedef enum
{
	Electromobile = 0x31,
	Hydromobile = 0x69,
	Autonomous = 0x52,
}Vehicle_Id;

typedef enum
{
	S_WAKEUP_COMMANDS 	= 0,
	S_VELOCITY 			= 1,
	S_MCU_ID_IQ_VD_VQ 	= 2,
	S_MCU_STATE_AREA 	= 3,
	S_BMS_MEASUREMENTS 	= 4,
	S_BMS_STATE_DATA 	= 5,
	S_EMS_CURRENT 		= 6,
	S_EMS_VOLTAGE 		= 7,
	S_EMS_CONSUMPTION 	= 8,
	S_EMS_STATE_DATA 	= 9,
	S_BMS_CELLS_1 		= 10,
	S_BMS_CELLS_2		= 11,
	S_BMS_CELLS_3 		= 12,
	S_BMS_CELLS_4 		= 13,
	S_BMS_SOC_1		 	= 14,
	S_BMS_SOC_2 		= 15,
	S_BMS_SOC_3 		= 16,
	S_BMS_SOC_4 		= 17,
	S_BMS_TO_CHARGER	= 18,
	S_PID_TUNNING		= 19,
	S_PID_QUERY			= 20,
	S_PID_QUERY_ANSWER	= 21,
	S_COMM_QUERY		= 22,
	S_UI_PACK			= 23,
	S_RESET_TELEMETRY   = 24,
	MSG_ID_COUNT		= 25,
}Source_Message_Id;

typedef enum
{
	H_CONST1_CNT 		= 0,
	H_CONST2_CNT 		= 1,
	VEHIC_ID_CNT 		= 2,
	TARGET_ID_CNT 		= 3,
	SOURCE_ID_CNT 		= 4,
	SOURCE_MSG_ID_CNT 	= 5,
	MSG_SIZE_CNT 		= 6,
	MSG_CNT 			= 7,
	MSG_INDEX_CNT_L		= 8,
	MSG_INDEX_CNT_H		= 9,
	CRC_L_CNT 			= 10,
	CRC_H_CNT 			= 11
}Pack_States;

typedef enum
{
	MCU = 1,
	VCU = 2,
	TELEMETRI = 4,
	BMS = 8,
	EYS = 16,
	CHARGER = 32,
	UI = 64
}Hardware_No;

typedef struct
{
	uint32_t vehicle_id_err;
	uint32_t CRC_err;
	uint32_t true_pack;
	uint32_t received_byte;
	uint32_t msg_id_err;
	uint32_t header_err;
	uint32_t bad_err;
}Comm_Status;
/*
 * indeks_error
 * gelen_bayt_sayisi
 */

typedef struct
{
	uint8_t s_ID;
	uint16_t s_index;
}Source_Msg;

/* Eski sürüm
typedef struct
{
	uint8_t header_const_1;
	uint8_t header_const_2;
	uint8_t vehicle_id;
	uint8_t target_id;
	uint8_t source_id;
	Source_Msg source_msg; // bu ve indexi struct
	uint8_t msg_size;
	uint8_t msg[MAX_MSG_SIZE];
	uint8_t CRC_L;
	uint8_t CRC_H;

}Aesk_Compro_Pack;
*/

typedef struct
{
	uint8_t header_const_1;
	uint8_t header_const_2;
	uint8_t vehicle_id;
	uint8_t target_id;
	uint8_t source_id;
	uint8_t source_msg_id;
	uint8_t msg_size;
	uint8_t msg[MAX_MSG_SIZE];
	uint8_t msg_index_L;
	uint8_t msg_index_H;
	uint8_t CRC_L;
	uint8_t CRC_H;
}Aesk_Compro_Pack;

typedef struct
{
	uint8_t vehicle_id_set;
	uint8_t source_id_set;
	Comm_Status com_status;
	Aesk_Compro_Pack aesk_compro;
	void (*pack_solver)(const Aesk_Compro_Pack*);
	uint16_t current_index_matrix[TOTAL_HARDWARE_NO];
	uint16_t current_index;
	
}Aesk_Compro_Settings;

Aesk_Compro_Settings compro_set_can_rx;
Aesk_Compro_Settings compro_set_uart_rx;



void AESK_Compro_Init( 		Aesk_Compro_Settings* com_set,
					  const Vehicle_Id vehicle_id,
					  const Hardware_No source_id,
					  void(*pack_solver_func)(const Aesk_Compro_Pack*));

uint16_t AESK_calcCRC16(uint8_t *pt,
						size_t msgLen);

void AESK_Compro_Create(	  Aesk_Compro_Pack* compro,
						const Vehicle_Id vehicle_id,
						const Hardware_No target_id,
						const Hardware_No source_id,
						const uint8_t* msg,
						const size_t msg_size,
						const uint8_t msg_id);

void AESK_Compro_Unpack(Aesk_Compro_Settings* com_set,
						uint8_t* buf_rx,
						size_t size);

void AESK_Compro_Send_Ring_Buf(Aesk_Compro_Pack* compro, AESK_Ring_Buffer* ring_buf);

uint8_t index_control(uint16_t gelen_index, uint16_t *son_index);

#endif /* SRC_AESK_COMM_PRO_H_ */
