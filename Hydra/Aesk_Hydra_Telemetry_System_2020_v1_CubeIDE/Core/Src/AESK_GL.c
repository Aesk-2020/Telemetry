/*
 * AESK_GL.c
 *
 *  Created on: Dec 12, 2020
 *      Author: basri
 */


#include "AESK_GL.h"

void AESK_GL_Init(AESK_GL* aesk_gl)
{
	for(uint32_t i = 0; i < sizeof(AESK_GL); i++)
	{
		((uint8_t*)aesk_gl)[i] = 0;
	}
}

void HAL_CAN_TxMailbox0CompleteCallback(CAN_HandleTypeDef *hcan)
 {
		if(hcan == aesk_gl.aesk_can_2.hcan)
		{
			AESK_CAN_Send_RingBuffer(&aesk_gl.aesk_can_2, &aesk_gl.CAN2_Rng_Buf_Tx, aesk_gl.aesk_can_2.txMsg.ExtId);
		}
		else
		{
			AESK_CAN_Send_RingBuffer(&aesk_gl.aesk_can_1, &aesk_gl.CAN1_Rng_Buf_Tx, aesk_gl.aesk_can_1.txMsg.ExtId);
		}
 }

 void HAL_CAN_TxMailbox1CompleteCallback(CAN_HandleTypeDef *hcan)
 {
		if(hcan == aesk_gl.aesk_can_2.hcan)
		{
			AESK_CAN_Send_RingBuffer(&aesk_gl.aesk_can_2, &aesk_gl.CAN2_Rng_Buf_Tx, aesk_gl.aesk_can_2.txMsg.ExtId);
		}
		else
		{
			AESK_CAN_Send_RingBuffer(&aesk_gl.aesk_can_1, &aesk_gl.CAN1_Rng_Buf_Tx, aesk_gl.aesk_can_1.txMsg.ExtId);
		}
 }
 void HAL_CAN_TxMailbox2CompleteCallback(CAN_HandleTypeDef *hcan)
 {
		if(hcan == aesk_gl.aesk_can_2.hcan)
		{
			AESK_CAN_Send_RingBuffer(&aesk_gl.aesk_can_2, &aesk_gl.CAN2_Rng_Buf_Tx, aesk_gl.aesk_can_2.txMsg.ExtId);
		}
		else
		{
			AESK_CAN_Send_RingBuffer(&aesk_gl.aesk_can_1, &aesk_gl.CAN1_Rng_Buf_Tx, aesk_gl.aesk_can_1.txMsg.ExtId);
		}
 }

void HAL_CAN_RxFifo0MsgPendingCallback(CAN_HandleTypeDef *hcan)
{
	if(hcan == aesk_gl.aesk_can_1.hcan)
	{
		AESK_CAN_ReadExtIDMessage(&aesk_gl.aesk_can_1, FIFO_0);
		Write_Data_Ring_Buffer(&(aesk_gl.CAN_Rng_Buf_1[FIFO_0]), aesk_gl.aesk_can_1.receivedData, aesk_gl.aesk_can_1.rxMsg.DLC);
	}
	else
	{
		AESK_CAN_ReadExtIDMessage(&aesk_gl.aesk_can_2, FIFO_0);
		Write_Data_Ring_Buffer(&(aesk_gl.CAN_Rng_Buf_2[FIFO_0]), aesk_gl.aesk_can_2.receivedData, aesk_gl.aesk_can_2.rxMsg.DLC);
	}
}

void HAL_CAN_RxFifo1MsgPendingCallback(CAN_HandleTypeDef *hcan)
{
	if(hcan == aesk_gl.aesk_can_1.hcan)
	{
		AESK_CAN_ReadExtIDMessage(&aesk_gl.aesk_can_1, FIFO_1);
		Write_Data_Ring_Buffer(&(aesk_gl.CAN_Rng_Buf_1[FIFO_1]), aesk_gl.aesk_can_1.receivedData, aesk_gl.aesk_can_1.rxMsg.DLC);
	}
	else
	{
		AESK_CAN_ReadExtIDMessage(&aesk_gl.aesk_can_2, FIFO_1);
		Write_Data_Ring_Buffer(&(aesk_gl.CAN_Rng_Buf_2[FIFO_1]), aesk_gl.aesk_can_2.receivedData, aesk_gl.aesk_can_2.rxMsg.DLC);
	}
}



void HAL_SYSTICK_Callback(void)
{
	aesk_gl.system_clock_counter_1ms++;

		if(aesk_gl.system_clock_counter_1ms % 10 == 0)
		{
			tt.time_task_t.task_100_Hz = 1;
		}

		if(aesk_gl.system_clock_counter_1ms % 20 == 0)
		{
			tt.time_task_t.task_50_Hz = 1;
		}

		if(aesk_gl.system_clock_counter_1ms % 50 == 0)
		{
			tt.time_task_t.task_20_Hz = 1;
		}

}




