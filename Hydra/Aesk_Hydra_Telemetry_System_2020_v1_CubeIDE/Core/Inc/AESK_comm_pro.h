/*
 * AESK_comm_pro.h
 *
 *  Created on: Nov 28, 2020
 *      Author: basri
 */

#ifndef SRC_AESK_COMM_PRO_H_
#define SRC_AESK_COMM_PRO_H_

#include "AESK_Ring_Buffer.h"

#define HEADER_CONST1  0x14
#define HEADER_CONST2  0x04
#define MAX_MSG_SIZE   255
#define OFFSET         7

typedef enum
{
	Electromobile = 0x31,
	Hydromobile = 0x69,
	Autonomous = 0x52,
}Vehicle_Id;

typedef enum
{
	H_CONST1_CNT = 0,
	H_CONST2_CNT = 1,
	VEHIC_ID_CNT = 2, 
	TARGET_ID_CNT = 3,
	SOURCE_ID_CNT = 4,
	SOURCE_MSG_ID_CNT = 5,
	MSG_SIZE_CNT = 6,
	MSG_CNT = 7,
	CRC_L_CNT = 8,
	CRC_H_CNT =9
}Pack_States;

typedef enum
{
	MCU = 1,
	VCU = 2,
	TELEMETRI = 4,
	BMS = 8,
	EYS = 16
}Hardware_No;

typedef struct
{
	uint32_t vehicle_id_err;
	uint32_t CRC_err;
}Error_States;

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
	uint8_t CRC_L;
	uint8_t CRC_H;

}Aesk_Compro_Pack;

typedef struct
{
	uint8_t vehicle_id_set;
	uint8_t target_id_set;
	uint8_t source_id_set;
	uint32_t true_pack;
	uint32_t received_byte;
	Error_States eror_states;
	Aesk_Compro_Pack aesk_compro;
	void (*pack_solver)(const Aesk_Compro_Pack*);
	
}Aesk_Compro_Settings;

Aesk_Compro_Settings compro_set_can_rx;
Aesk_Compro_Settings compro_set_uart_rx;



void AESK_Compro_Init( 		Aesk_Compro_Settings* com_set,
					  const Vehicle_Id vehicle_id,
					  const Hardware_No hardware_id,
					  const uint8_t target_id,
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

#endif /* SRC_AESK_COMM_PRO_H_ */
