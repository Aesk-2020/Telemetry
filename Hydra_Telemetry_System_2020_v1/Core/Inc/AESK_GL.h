/*
 * AESK_GL.h
 *
 *  Created on: Dec 12, 2020
 *      Author: basri
 */

#ifndef INC_AESK_GL_H_
#define INC_AESK_GL_H_

#include "AESK_Ring_Buffer.h"
#include "main.h"
#include "AESK_CAN_Library.h"
#include "AESK_comm_pro.h"

 typedef enum
 {
	 FIFO_0 = 0,
	 FIFO_1,
	 TOTAL_FIFO,
 }FIFO_NUMBER;

 typedef union
 {
     struct
     {
         uint8_t task_1000_Hz : 1 ;
         uint8_t task_100_Hz : 1;
         uint8_t task_50_Hz : 1;
         uint8_t task_20_Hz : 1;
         uint8_t task_2_Hz : 1;
         uint8_t task_1_Hz : 1;
         uint8_t reserved : 2;
     }time_task_t;
     uint8_t all_u8;
 }time_task_union;

 time_task_union tt;

  typedef struct
  {
	  AESK_CAN_Struct aesk_can_1;
	  AESK_CAN_Struct aesk_can_2;

	  AESK_Ring_Buffer CAN_Rng_Buf_1[TOTAL_FIFO];
	  AESK_Ring_Buffer CAN_Rng_Buf_2[TOTAL_FIFO];

	  AESK_Ring_Buffer CAN1_Rng_Buf_Tx;
	  AESK_Ring_Buffer CAN2_Rng_Buf_Tx;

	  AESK_Ring_Buffer UART_Rng_Buf_Tx;

	  uint32_t system_clock_counter_1ms;
  }AESK_GL;

  AESK_GL aesk_gl;

  void AESK_GL_Init(AESK_GL* aesk_gl);


#endif /* INC_AESK_GL_H_ */
