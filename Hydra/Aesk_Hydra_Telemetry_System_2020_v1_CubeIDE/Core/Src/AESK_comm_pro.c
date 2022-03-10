/*
 * AESK_comm_pro.c
 *
 *  Created on: Nov 28, 2020
 *      Author: basri
 */

#include "AESK_comm_pro.h"

void AESK_Compro_Init(Aesk_Compro_Settings* com_set, const Vehicle_Id vehicle_id, const Hardware_No hardware_id, const uint8_t target_id, void(*pack_solver_func)(const Aesk_Compro_Pack*))
{
	for (uint16_t i = 0; i < sizeof(Aesk_Compro_Settings); i++)
	{
		((uint8_t*)com_set)[i] = 0;
	}
	com_set->vehicle_id_set = vehicle_id;
	com_set->source_id_set = hardware_id;
	com_set->target_id_set = target_id;
	com_set->pack_solver = pack_solver_func;
}

uint16_t AESK_calcCRC16(uint8_t *pt, size_t msgLen)
{
	uint16_t crc16_data = 0;
	uint8_t data = 0;

	for (uint8_t mlen = 0; mlen < msgLen; mlen++) {
		data = pt[mlen] ^ ((uint8_t)(crc16_data) & (uint8_t)(0xFF));
		data ^= data << 4;
		crc16_data = ((((uint16_t)data << 8) | ((crc16_data & 0xFF00) >> 8))
			^ (uint8_t)(data >> 4)
			^ ((uint16_t)data << 3));
	}
	return(crc16_data);
}
void AESK_Compro_Create(	  Aesk_Compro_Pack* compro,
						const Vehicle_Id vehicle_id,
						const Hardware_No target_id,
						const Hardware_No source_id,
						const uint8_t* msg,
						const size_t msg_size,
						const uint8_t msg_id)
{
	uint16_t CRC_ = 0;

	compro->header_const_1 = HEADER_CONST1;
	compro->header_const_2 = HEADER_CONST2;
	compro->vehicle_id = vehicle_id;
	compro->target_id = target_id;
	compro->source_id = source_id;
	compro->source_msg_id = msg_id;
	compro->msg_size = msg_size;

	for(uint8_t i = 0; i < msg_size; i++)
	{
		compro->msg[i] = msg[i];
	}

	CRC_ = AESK_calcCRC16((uint8_t*)compro, msg_size + OFFSET);

	compro->CRC_L = (uint8_t)(CRC_ & 0x00FF);
	compro->CRC_H = (uint8_t)((CRC_ >> 8) & 0x00FF);

}

void AESK_Compro_Send_Ring_Buf(Aesk_Compro_Pack* compro, AESK_Ring_Buffer* ring_buf)
{
	uint8_t tmp_buf[255] = { 0 };
	uint8_t i = 0;
	for(; i < compro->msg_size + OFFSET; i++)
	{
		tmp_buf[i] = ((uint8_t*)compro)[i];
	}

	tmp_buf[i++] = compro->CRC_L;
	tmp_buf[i++] = compro->CRC_H;

	Write_Data_Ring_Buffer(ring_buf, tmp_buf, i);
}

void AESK_Compro_Unpack(Aesk_Compro_Settings* com_set, uint8_t* buf_rx, size_t size)
{
	static uint8_t states = H_CONST1_CNT;
	com_set->received_byte += size;
	for(uint8_t i = 0; i < size; i++)
	{
		switch (states) 
		{
			case  H_CONST1_CNT :
			{
				if(buf_rx[i] == HEADER_CONST1)
				{
					com_set->aesk_compro.header_const_1 = buf_rx[i];
					states = H_CONST2_CNT;
				}
				else
				{
					states = H_CONST1_CNT;
				}
				break;
			}
			case  H_CONST2_CNT :
			{
				if(buf_rx[i] == HEADER_CONST2)
				{
					com_set->aesk_compro.header_const_2 = buf_rx[i];
					states = VEHIC_ID_CNT;
				}
				else
				{
					states = H_CONST1_CNT;
				}
				break;
			}

			case VEHIC_ID_CNT :
			{
				if(buf_rx[i] == com_set->vehicle_id_set)
				{
					com_set->aesk_compro.vehicle_id = com_set->vehicle_id_set;
					states = TARGET_ID_CNT;
				}
				else
				{
					states = H_CONST1_CNT;
					com_set->eror_states.vehicle_id_err++;
				}
				break;
			}
			case TARGET_ID_CNT :
			{
				if(buf_rx[i] == com_set->target_id_set)
				{
					com_set->aesk_compro.target_id = com_set->target_id_set;
					states = SOURCE_ID_CNT;
				}
				else
				{
					states = H_CONST1_CNT;
				}
				break;
			}

			case SOURCE_ID_CNT :
			{
					com_set->aesk_compro.source_id = buf_rx[i];
					states = SOURCE_MSG_ID_CNT;
		
				break;
			}
			case SOURCE_MSG_ID_CNT :
			{
					com_set->aesk_compro.source_msg_id = buf_rx[i];
					states = MSG_SIZE_CNT;
				
				break;
			}

			case MSG_SIZE_CNT :
			{
					com_set->aesk_compro.msg_size = buf_rx[i];
					states = MSG_CNT;
				break;
			}

			case MSG_CNT :
			{
				static uint8_t msg_size = 0;
				com_set->aesk_compro.msg[msg_size++] = buf_rx[i];
				if(msg_size >= com_set->aesk_compro.msg_size)
				{
					states = CRC_L_CNT;
					msg_size = 0;
				}
				break;
			}

			case CRC_L_CNT :
			{
				com_set->aesk_compro.CRC_L= buf_rx[i];
				states = CRC_H_CNT;
				break;
			}

			case CRC_H_CNT :
			{
				uint16_t crc_calculated = 0;
				
				com_set->aesk_compro.CRC_H = buf_rx[i];
				
				crc_calculated = (com_set->aesk_compro.CRC_L)|((com_set->aesk_compro.CRC_H) << 8);
				
				if( crc_calculated == AESK_calcCRC16((uint8_t*)&(com_set->aesk_compro), com_set->aesk_compro.msg_size + OFFSET))
				{
					com_set->true_pack++;
					com_set->pack_solver(&com_set->aesk_compro);
				}

				else
				{
					com_set->eror_states.CRC_err++;
				}
				states = H_CONST1_CNT;
				break;
			}
			
			default : break;
		}
	}
}


