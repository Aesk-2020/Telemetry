/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.h
  * @brief          : Header for main.c file.
  *                   This file contains the common defines of the application.
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2020 STMicroelectronics.
  * All rights reserved.</center></h2>
  *
  * This software component is licensed by ST under Ultimate Liberty license
  * SLA0044, the "License"; You may not use this file except in compliance with
  * the License. You may obtain a copy of the License at:
  *                             www.st.com/SLA0044
  *
  ******************************************************************************
  */
/* USER CODE END Header */

/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __MAIN_H
#define __MAIN_H

#ifdef __cplusplus
extern "C" {
#endif

/* Includes ------------------------------------------------------------------*/
#include "stm32f4xx_hal.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */

/* USER CODE END Includes */

/* Exported types ------------------------------------------------------------*/
/* USER CODE BEGIN ET */

/* USER CODE END ET */

/* Exported constants --------------------------------------------------------*/
/* USER CODE BEGIN EC */

/* USER CODE END EC */

/* Exported macro ------------------------------------------------------------*/
/* USER CODE BEGIN EM */

/* USER CODE END EM */

/* Exported functions prototypes ---------------------------------------------*/
void Error_Handler(void);

/* USER CODE BEGIN EFP */

/* USER CODE END EFP */

/* Private defines -----------------------------------------------------------*/
#define GPS_TXD_Pin GPIO_PIN_2
#define GPS_TXD_GPIO_Port GPIOA
#define GPS_RXD_Pin GPIO_PIN_3
#define GPS_RXD_GPIO_Port GPIOA
#define XBEE_RXD_Pin GPIO_PIN_5
#define XBEE_RXD_GPIO_Port GPIOC
#define XBEE_TXD_Pin GPIO_PIN_10
#define XBEE_TXD_GPIO_Port GPIOB
#define CAN2_STDBY_Pin GPIO_PIN_14
#define CAN2_STDBY_GPIO_Port GPIOB
#define CAN1_STDBY_Pin GPIO_PIN_9
#define CAN1_STDBY_GPIO_Port GPIOC
#define GSM_RXD_Pin GPIO_PIN_9
#define GSM_RXD_GPIO_Port GPIOA
#define GSM_TXD_Pin GPIO_PIN_10
#define GSM_TXD_GPIO_Port GPIOA
#define GSM_ON_OFF_Pin GPIO_PIN_2
#define GSM_ON_OFF_GPIO_Port GPIOD
#define GSM_STATUS_Pin GPIO_PIN_9
#define GSM_STATUS_GPIO_Port GPIOB
/* USER CODE BEGIN Private defines */

/* USER CODE END Private defines */

#ifdef __cplusplus
}
#endif

#endif /* __MAIN_H */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
