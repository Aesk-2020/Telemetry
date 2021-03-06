/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
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

/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "fatfs.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include "stdio.h"
#include "SIM800MQTT.h"
#include "AESK_CAN_Library.h"
#include "AESK_Gps_lib.h"
#include "TelemetryGlobalvar.h"
#include "Can_Lyra_Header.h"
#include "AESK_Data_Pack_lib.h"
#include "stdarg.h"
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
CAN_HandleTypeDef hcan1;
CAN_HandleTypeDef hcan2;

RTC_HandleTypeDef hrtc;

SD_HandleTypeDef hsd;
DMA_HandleTypeDef hdma_sdio_tx;
DMA_HandleTypeDef hdma_sdio_rx;

TIM_HandleTypeDef htim6;

UART_HandleTypeDef huart1;
UART_HandleTypeDef huart2;
UART_HandleTypeDef huart3;
DMA_HandleTypeDef hdma_usart2_rx;

/* USER CODE BEGIN PV */
int SetTime = 0;
int SetDate = 0;
AESK_CAN_Struct aesk_can;
Time_Task_union time_task;
Xbee_Datas xbee_data;
Gsm_Datas gsm_data;
MQTTPacket_connectData connectData = MQTTPacket_connectData_initializer;
MQTTString topicString = MQTTString_initializer;
LyraDatas lyradata;
Sd_Card_Datas sd_card_data;
GPS_Handle gps_data;
RTC_TimeTypeDef rtctime;
RTC_DateTypeDef rtcdate;
RTC_TimeTypeDef sTime;
RTC_DateTypeDef sDate;

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_DMA_Init(void);
static void MX_CAN1_Init(void);
static void MX_CAN2_Init(void);
static void MX_SDIO_SD_Init(void);
static void MX_TIM6_Init(void);
static void MX_USART1_UART_Init(void);
static void MX_USART2_UART_Init(void);
static void MX_USART3_UART_Init(void);
static void MX_RTC_Init(void);
/* USER CODE BEGIN PFP */
void Gsm_Calibration(Gsm_Datas* gsm_data);
void createMQTTPackage(LyraDatas *lyradata, GPS_Handle*gps_data, uint8_t* packBuf, uint16_t *index);
void RTC_Set_Time_Date(void);
void vars_to_str(char *buffer, const char *format, ...);
uint16_t aeskCRCCalculator(uint8_t * frame, size_t framesize);
void createXBEEPackage(LyraDatas *lyradata, GPS_Handle*gps_data, uint8_t* packBuf, uint16_t *index);
void Can_Error_Control(void);
/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_DMA_Init();
  MX_CAN1_Init();
  MX_CAN2_Init();
  MX_SDIO_SD_Init();
  MX_TIM6_Init();
  MX_USART1_UART_Init();
  MX_USART2_UART_Init();
  MX_USART3_UART_Init();
  MX_RTC_Init();
  MX_FATFS_Init();
  /* USER CODE BEGIN 2 */
   gsm_data.gsm_uart = &huart1;
	 aesk_can.hcan = hcan1;
   MX_RTC_Init();
   RTC_Set_Time_Date();
	 char * SDHeader = "Time\twake_up\tset_velocity\tcan_error\tPhase_A_Current\tPhase_B_Current\tDc_Bus_Current\tDc_Bus_voltage\tId\tIq\tIArms\tTorque\tdrive_status\tdriver_error\tOdometer\tMotor_Temperature\tactual_velocity\tBat_Voltage\tBat_Current\tBat_Cons\tSoc\tbms_error\tdc_bus_state\tWorst_Cell_Voltage\tWorst_Cell_Address\tTemperature\tlatitude\tlongtitude\tspeed_u8\tsatellite_number\tgpsEfficiency\ttrueData\tchecksumError\tvalidDataError\n";
	 
	 //*********SD KART****************//
   if(f_mount(&sd_card_data.myFATAFS,(TCHAR const *)SDPath, 1) == FR_OK)
   {
	   HAL_RTC_GetTime(&hrtc, &sTime, RTC_FORMAT_BIN);
	   HAL_RTC_GetDate(&hrtc, &sDate, RTC_FORMAT_BIN);
	   vars_to_str(sd_card_data.path, "%d_%d_%d_%d_%d_%d_(%d).txt", sDate.Date, sDate.Month, sDate.Year, sTime.Hours, sTime.Minutes, sTime.Seconds, sd_card_data.logger_u32);
		 
		 f_open(&sd_card_data.myFile, sd_card_data.path, FA_WRITE | FA_OPEN_APPEND | FA_OPEN_EXISTING | FA_OPEN_ALWAYS);
		 f_write(&sd_card_data.myFile, SDHeader, strlen(SDHeader), (void*)&sd_card_data.writtenbyte);
	   f_close(&sd_card_data.myFile);
		 
		 sd_card_data.state = SD_Card_Detect;
   }
	 //*********SD KART****************//
	 
   if((GSM_STATUS_GPIO_Port->IDR & GSM_STATUS_Pin) == (uint32_t)GPIO_PIN_RESET)
   {
			GSM_ON_OFF_GPIO_Port->BSRR = GSM_ON_OFF_Pin;
	    HAL_Delay(1500);
	    GSM_ON_OFF_GPIO_Port->BSRR = GSM_ON_OFF_Pin << 16U;
   }

   else
   {
			HAL_UART_Transmit(gsm_data.gsm_uart, (uint8_t*)RESET_AT_COMMAND, (uint16_t)strlen(RESET_AT_COMMAND), HAL_DELAY);
   }

   while((GSM_STATUS_GPIO_Port->IDR & GSM_STATUS_Pin) == (uint32_t)GPIO_PIN_RESET)
   {
	   ;
   }
	

	 
		AESK_CAN_ExtIDMaskFilterConfiguration(&aesk_can, 0, 0, CAN_RX_FIFO0, 0);
	 	AESK_CAN_ExtIDMaskFilterConfiguration(&aesk_can, 0, 0, CAN_RX_FIFO1, 0);
	  AESK_CAN_Init(&aesk_can, CAN_IT_RX_FIFO0_MSG_PENDING | CAN_IT_RX_FIFO1_MSG_PENDING);
	 
  /* CAN1 WAKE - CAN2 SLEEP*/
		CAN2_STDBY_GPIO_Port->BSRR = CAN2_STDBY_Pin;
		CAN1_STDBY_GPIO_Port->BSRR = (uint32_t)CAN1_STDBY_Pin << 16U;
  //////////////////////////
    HAL_UART_Receive_IT(gsm_data.gsm_uart, &gsm_data.receivegsmdata, 1);
    HAL_UART_Receive_IT(&huart3, &xbee_data.receiveData, 1);
    HAL_UART_Receive_DMA(&huart2, &gps_data.uartReceiveData_u8, 1);
    HAL_TIM_Base_Start_IT(&htim6); 
	  lyradata.can_error.can_error_u8 = 7; // every can control bit initialize 1
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
		if(time_task.Time_Task.Task_5000_ms == TRUE)
		{			
			Can_Error_Control();
			time_task.Time_Task.Task_5000_ms = FALSE;			
		}
	  if(time_task.Time_Task.Task_80_ms == TRUE)
	  {
		  Gsm_Calibration(&gsm_data);
		  time_task.Time_Task.Task_80_ms = FALSE;
	  }
		
		if(time_task.Time_Task.Task_500_ms == TRUE)
		{
			xbee_data.xbee_index = 0;
			createXBEEPackage(&lyradata, &gps_data, xbee_data.transmitBuf, &(xbee_data.xbee_index));
			HAL_UART_Transmit(&huart3, xbee_data.transmitBuf, xbee_data.xbee_index, HAL_MAX_DELAY);
			time_task.Time_Task.Task_500_ms = FALSE;
		}

		//*********SD KART****************//
	  if(time_task.Time_Task.Task_50_ms == TRUE)
	  {
		  if(sd_card_data.state == SD_Card_Detect)
		  {
			  HAL_RTC_GetTime(&hrtc, &sTime, RTC_FORMAT_BIN);
			  HAL_RTC_GetDate(&hrtc, &sDate, RTC_FORMAT_BIN);
			  vars_to_str((char *)sd_card_data.transmitBuf, "%d\t%d\t%d\t%.2f\t%.2f\t%.2f\t%.1f\t%.2f\t%.2f\t%.2f\t%.2f\t%d\t%d\t%d\t%d\t%d\t%.1f\t%.2f\t%.1f\t%.2f\t%d\t%d\t%.1f\t%d\t%d\t%.6f\t%.6f%d\t%d\t%d\t%d\t%d\t%d\t%d\n",
				 					 	 	 	 	 	 	 	 	 	 	 lyradata.vcu_data.wake_up_union.wake_up_u8, lyradata.vcu_data.set_velocity_u8,
																			 lyradata.can_error.can_error_u8, lyradata.driver_data.Phase_A_Current_f32, lyradata.driver_data.Phase_B_Current_f32, lyradata.driver_data.Dc_Bus_Current_f32,
																			 lyradata.driver_data.Dc_Bus_voltage_f32, lyradata.driver_data.Id_f32, lyradata.driver_data.Iq_f32, lyradata.driver_data.IArms_f32, lyradata.driver_data.Torque_f32,
																			 lyradata.driver_data.drive_status_union.drive_status_u8, lyradata.driver_data.driver_error_union.driver_error_u8, lyradata.driver_data.Odometer_u32,
																			 lyradata.driver_data.Motor_Temperature_u8, lyradata.driver_data.actual_velocity_u8, lyradata.bms_data.Bat_Voltage_f32,
																			 lyradata.bms_data.Bat_Current_f32, lyradata.bms_data.Bat_Cons_f32, lyradata.bms_data.Soc_f32, lyradata.bms_data.bms_error.bms_error_u8,
																			 lyradata.bms_data.dc_bus_state.dc_bus_state_u8, lyradata.bms_data.Worst_Cell_Voltage_f32, lyradata.bms_data.Worst_Cell_Address_u8,
																			 lyradata.bms_data.Temperature_u8, gps_data.latitude_f32, gps_data.longtitude_f32, gps_data.speed_u8, gps_data.satellite_number_u8, gps_data.gpsEfficiency_u8,
																			 gps_data.gps_errorhandler.trueData_u32, gps_data.gps_errorhandler.checksumError_u32, gps_data.gps_errorhandler.validDataError_u32, gsm_data.gsm_state_current_index);
			  vars_to_str((char *)sd_card_data.total_log, "%d:%d:%d\t", sTime.Hours, sTime.Minutes, sTime.Seconds);
			  strcat(sd_card_data.total_log, (const char*)sd_card_data.transmitBuf);
			  sd_card_data.result = f_open(&sd_card_data.myFile, sd_card_data.path, FA_WRITE | FA_OPEN_APPEND | FA_OPEN_EXISTING | FA_OPEN_ALWAYS);
				f_write(&sd_card_data.myFile, sd_card_data.total_log, strlen(sd_card_data.total_log), (void*)&sd_card_data.writtenbyte);
			  if((sd_card_data.writtenbyte != 0) && (sd_card_data.result == FR_OK))
			  {
				  f_close(&sd_card_data.myFile);
			  }

			  else
			  {
				  f_mount(&sd_card_data.myFATAFS,(TCHAR const *)SDPath, 1);
			  }
			}
	 		time_task.Time_Task.Task_50_ms = FALSE;
		}
		//*********SD KART****************//
		
  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};
  RCC_PeriphCLKInitTypeDef PeriphClkInitStruct = {0};

  /** Configure the main internal regulator output voltage 
  */
  __HAL_RCC_PWR_CLK_ENABLE();
  __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE1);
  /** Initializes the CPU, AHB and APB busses clocks 
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE|RCC_OSCILLATORTYPE_LSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.LSEState = RCC_LSE_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLM = 12;
  RCC_OscInitStruct.PLL.PLLN = 96;
  RCC_OscInitStruct.PLL.PLLP = RCC_PLLP_DIV2;
  RCC_OscInitStruct.PLL.PLLQ = 4;
  RCC_OscInitStruct.PLL.PLLR = 2;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
  /** Initializes the CPU, AHB and APB busses clocks 
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV2;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_3) != HAL_OK)
  {
    Error_Handler();
  }
  PeriphClkInitStruct.PeriphClockSelection = RCC_PERIPHCLK_RTC|RCC_PERIPHCLK_SDIO
                              |RCC_PERIPHCLK_CLK48;
  PeriphClkInitStruct.RTCClockSelection = RCC_RTCCLKSOURCE_LSE;
  PeriphClkInitStruct.Clk48ClockSelection = RCC_CLK48CLKSOURCE_PLLQ;
  PeriphClkInitStruct.SdioClockSelection = RCC_SDIOCLKSOURCE_CLK48;
  if (HAL_RCCEx_PeriphCLKConfig(&PeriphClkInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief CAN1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_CAN1_Init(void)
{

  /* USER CODE BEGIN CAN1_Init 0 */

  /* USER CODE END CAN1_Init 0 */

  /* USER CODE BEGIN CAN1_Init 1 */

  /* USER CODE END CAN1_Init 1 */
  hcan1.Instance = CAN1;
  hcan1.Init.Prescaler = 20;
  hcan1.Init.Mode = CAN_MODE_NORMAL;
  hcan1.Init.SyncJumpWidth = CAN_SJW_1TQ;
  hcan1.Init.TimeSeg1 = CAN_BS1_8TQ;
  hcan1.Init.TimeSeg2 = CAN_BS2_1TQ;
  hcan1.Init.TimeTriggeredMode = DISABLE;
  hcan1.Init.AutoBusOff = ENABLE;
  hcan1.Init.AutoWakeUp = DISABLE;
  hcan1.Init.AutoRetransmission = DISABLE;
  hcan1.Init.ReceiveFifoLocked = DISABLE;
  hcan1.Init.TransmitFifoPriority = DISABLE;
  if (HAL_CAN_Init(&hcan1) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN CAN1_Init 2 */

  /* USER CODE END CAN1_Init 2 */

}

/**
  * @brief CAN2 Initialization Function
  * @param None
  * @retval None
  */
static void MX_CAN2_Init(void)
{

  /* USER CODE BEGIN CAN2_Init 0 */

  /* USER CODE END CAN2_Init 0 */

  /* USER CODE BEGIN CAN2_Init 1 */

  /* USER CODE END CAN2_Init 1 */
  hcan2.Instance = CAN2;
  hcan2.Init.Prescaler = 20;
  hcan2.Init.Mode = CAN_MODE_NORMAL;
  hcan2.Init.SyncJumpWidth = CAN_SJW_1TQ;
  hcan2.Init.TimeSeg1 = CAN_BS1_8TQ;
  hcan2.Init.TimeSeg2 = CAN_BS2_1TQ;
  hcan2.Init.TimeTriggeredMode = DISABLE;
  hcan2.Init.AutoBusOff = ENABLE;
  hcan2.Init.AutoWakeUp = DISABLE;
  hcan2.Init.AutoRetransmission = DISABLE;
  hcan2.Init.ReceiveFifoLocked = DISABLE;
  hcan2.Init.TransmitFifoPriority = DISABLE;
  if (HAL_CAN_Init(&hcan2) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN CAN2_Init 2 */

  /* USER CODE END CAN2_Init 2 */

}

/**
  * @brief RTC Initialization Function
  * @param None
  * @retval None
  */
static void MX_RTC_Init(void)
{

  /* USER CODE BEGIN RTC_Init 0 */

  /* USER CODE END RTC_Init 0 */

  /* USER CODE BEGIN RTC_Init 1 */

  /* USER CODE END RTC_Init 1 */
  /** Initialize RTC Only 
  */
  hrtc.Instance = RTC;
  hrtc.Init.HourFormat = RTC_HOURFORMAT_24;
  hrtc.Init.AsynchPrediv = 127;
  hrtc.Init.SynchPrediv = 255;
  hrtc.Init.OutPut = RTC_OUTPUT_DISABLE;
  hrtc.Init.OutPutPolarity = RTC_OUTPUT_POLARITY_HIGH;
  hrtc.Init.OutPutType = RTC_OUTPUT_TYPE_OPENDRAIN;
  if (HAL_RTC_Init(&hrtc) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN RTC_Init 2 */

  /* USER CODE END RTC_Init 2 */

}

/**
  * @brief SDIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_SDIO_SD_Init(void)
{

  /* USER CODE BEGIN SDIO_Init 0 */

  /* USER CODE END SDIO_Init 0 */

  /* USER CODE BEGIN SDIO_Init 1 */

  /* USER CODE END SDIO_Init 1 */
  hsd.Instance = SDIO;
  hsd.Init.ClockEdge = SDIO_CLOCK_EDGE_RISING;
  hsd.Init.ClockBypass = SDIO_CLOCK_BYPASS_DISABLE;
  hsd.Init.ClockPowerSave = SDIO_CLOCK_POWER_SAVE_DISABLE;
  hsd.Init.BusWide = SDIO_BUS_WIDE_1B;
  hsd.Init.HardwareFlowControl = SDIO_HARDWARE_FLOW_CONTROL_DISABLE;
  hsd.Init.ClockDiv = 0;
  /* USER CODE BEGIN SDIO_Init 2 */

  /* USER CODE END SDIO_Init 2 */

}

/**
  * @brief TIM6 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM6_Init(void)
{

  /* USER CODE BEGIN TIM6_Init 0 */

  /* USER CODE END TIM6_Init 0 */

  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM6_Init 1 */

  /* USER CODE END TIM6_Init 1 */
  htim6.Instance = TIM6;
  htim6.Init.Prescaler = 999;
  htim6.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim6.Init.Period = 99;
  htim6.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_Base_Init(&htim6) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim6, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM6_Init 2 */

  /* USER CODE END TIM6_Init 2 */

}

/**
  * @brief USART1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_USART1_UART_Init(void)
{

  /* USER CODE BEGIN USART1_Init 0 */

  /* USER CODE END USART1_Init 0 */

  /* USER CODE BEGIN USART1_Init 1 */

  /* USER CODE END USART1_Init 1 */
  huart1.Instance = USART1;
  huart1.Init.BaudRate = 57600;
  huart1.Init.WordLength = UART_WORDLENGTH_8B;
  huart1.Init.StopBits = UART_STOPBITS_1;
  huart1.Init.Parity = UART_PARITY_NONE;
  huart1.Init.Mode = UART_MODE_TX_RX;
  huart1.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart1.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart1) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN USART1_Init 2 */

  /* USER CODE END USART1_Init 2 */

}

/**
  * @brief USART2 Initialization Function
  * @param None
  * @retval None
  */
static void MX_USART2_UART_Init(void)
{

  /* USER CODE BEGIN USART2_Init 0 */

  /* USER CODE END USART2_Init 0 */

  /* USER CODE BEGIN USART2_Init 1 */

  /* USER CODE END USART2_Init 1 */
  huart2.Instance = USART2;
  huart2.Init.BaudRate = 9600;
  huart2.Init.WordLength = UART_WORDLENGTH_8B;
  huart2.Init.StopBits = UART_STOPBITS_1;
  huart2.Init.Parity = UART_PARITY_NONE;
  huart2.Init.Mode = UART_MODE_TX_RX;
  huart2.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart2.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart2) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN USART2_Init 2 */

  /* USER CODE END USART2_Init 2 */

}

/**
  * @brief USART3 Initialization Function
  * @param None
  * @retval None
  */
static void MX_USART3_UART_Init(void)
{

  /* USER CODE BEGIN USART3_Init 0 */

  /* USER CODE END USART3_Init 0 */

  /* USER CODE BEGIN USART3_Init 1 */

  /* USER CODE END USART3_Init 1 */
  huart3.Instance = USART3;
  huart3.Init.BaudRate = 9600;
  huart3.Init.WordLength = UART_WORDLENGTH_8B;
  huart3.Init.StopBits = UART_STOPBITS_1;
  huart3.Init.Parity = UART_PARITY_NONE;
  huart3.Init.Mode = UART_MODE_TX_RX;
  huart3.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart3.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart3) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN USART3_Init 2 */

  /* USER CODE END USART3_Init 2 */

}

/** 
  * Enable DMA controller clock
  */
static void MX_DMA_Init(void) 
{

  /* DMA controller clock enable */
  __HAL_RCC_DMA2_CLK_ENABLE();
  __HAL_RCC_DMA1_CLK_ENABLE();

  /* DMA interrupt init */
  /* DMA1_Stream5_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA1_Stream5_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA1_Stream5_IRQn);
  /* DMA2_Stream3_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA2_Stream3_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA2_Stream3_IRQn);
  /* DMA2_Stream6_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA2_Stream6_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA2_Stream6_IRQn);

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{
  GPIO_InitTypeDef GPIO_InitStruct = {0};

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOC_CLK_ENABLE();
  __HAL_RCC_GPIOH_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();
  __HAL_RCC_GPIOD_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(CAN2_STDBY_GPIO_Port, CAN2_STDBY_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(CAN1_STDBY_GPIO_Port, CAN1_STDBY_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GSM_ON_OFF_GPIO_Port, GSM_ON_OFF_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin : CAN2_STDBY_Pin */
  GPIO_InitStruct.Pin = CAN2_STDBY_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(CAN2_STDBY_GPIO_Port, &GPIO_InitStruct);

  /*Configure GPIO pin : CAN1_STDBY_Pin */
  GPIO_InitStruct.Pin = CAN1_STDBY_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(CAN1_STDBY_GPIO_Port, &GPIO_InitStruct);

  /*Configure GPIO pin : PA8 */
  GPIO_InitStruct.Pin = GPIO_PIN_8;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pin : GSM_ON_OFF_Pin */
  GPIO_InitStruct.Pin = GSM_ON_OFF_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GSM_ON_OFF_GPIO_Port, &GPIO_InitStruct);

  /*Configure GPIO pin : GSM_STATUS_Pin */
  GPIO_InitStruct.Pin = GSM_STATUS_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_PULLDOWN;
  HAL_GPIO_Init(GSM_STATUS_GPIO_Port, &GPIO_InitStruct);

}

/* USER CODE BEGIN 4 */

void HAL_TIM_PeriodElapsedCallback(TIM_HandleTypeDef *htim)
{
	static uint32_t  task_counter_50_ms = 0;
	static uint32_t task_counter_80_ms = 0;
	static uint32_t task_counter_500_ms = 0;
	static uint32_t task_counter_5_sn = 0;
	task_counter_80_ms++;
	task_counter_50_ms++;
	task_counter_500_ms++;
	task_counter_5_sn++;
	if(task_counter_50_ms == 50)
	{
		time_task.Time_Task.Task_50_ms = TRUE;
		task_counter_50_ms = 0;
	}

	if(task_counter_80_ms == 80)
	{
		time_task.Time_Task.Task_80_ms = TRUE;
		task_counter_80_ms = 0;
	}
	
	if(task_counter_500_ms == 500)
	{
		time_task.Time_Task.Task_500_ms = TRUE;
		task_counter_500_ms = 0;
	}
	
	if(task_counter_5_sn == 5000)
	{
		time_task.Time_Task.Task_5000_ms = TRUE;
		task_counter_5_sn = 0;
	}
}

void HAL_UART_RxCpltCallback(UART_HandleTypeDef *huart)
{
	//HATA LOGLARI BURADA ALINACAK
		if(huart == &huart1)
		{
			static uint8_t cifsr_control = 0;

			gsm_data.gsmreceivebuffer[gsm_data.gsmreceivebuffer_index++] = gsm_data.receivegsmdata;
			if(strstr((const char *)gsm_data.gsmreceivebuffer, gsm_data.at_response) != NULL)
			{
				gsm_data.gsm_state_current_index = gsm_data.gsm_state_next_index;
				memset(gsm_data.gsmreceivebuffer, 0, sizeof(gsm_data.gsmreceivebuffer));
				gsm_data.gsmreceivebuffer_index = 0;
			}

			else if(strstr((const char *)gsm_data.gsmreceivebuffer, (const char *)"ERROR") != NULL)
			{
				gsm_data.gsm_state_current_index = gsm_data.gsm_state_next_index - 1;
				memset(gsm_data.gsmreceivebuffer, 0, sizeof(gsm_data.gsmreceivebuffer));
				gsm_data.gsmreceivebuffer_index = 0;
			}

			if(gsm_data.receivegsmdata =='.')
			{
				cifsr_control++;
			}

			if(cifsr_control == 3 && gsm_data.receivegsmdata == '\n')
			{
				gsm_data.gsm_state_current_index = gsm_data.gsm_state_next_index;
				memset(gsm_data.gsmreceivebuffer, 0, sizeof(gsm_data.gsmreceivebuffer));
				gsm_data.gsmreceivebuffer_index = 0;
				cifsr_control = 0;
			}

			if(gsm_data.gsm_state_next_index == SendMQTTPublishPack && gsm_data.receivegsmdata == '>')
			{

				gsm_data.gsm_state_current_index = gsm_data.gsm_state_next_index;
				memset(gsm_data.gsmreceivebuffer, 0, sizeof(gsm_data.gsmreceivebuffer));
				gsm_data.gsmreceivebuffer_index = 0;
			}

			if(gsm_data.gsmreceivebuffer_index == 31)
			{
				memset(gsm_data.gsmreceivebuffer, 0, sizeof(gsm_data.gsmreceivebuffer));
				gsm_data.gsmreceivebuffer_index = 0;
			}
			HAL_UART_Receive_IT(gsm_data.gsm_uart, &gsm_data.receivegsmdata, 1);
		}

		if(huart == &huart2)
		{
			GPS_Control(&gps_data);
			HAL_UART_Receive_DMA(&huart2, &gps_data.uartReceiveData_u8, 1);
		}

		if(huart == &huart3)
		{
			switch(xbee_data.states)
			{
				case ID_Control :
				{
					if(xbee_data.receiveData == FIRST_CONTROL_BYTE)
					{
						xbee_data.states = Reset_Data_Control;
					}
				break;
				}
				case Reset_Data_Control:
				{
					if(xbee_data.receiveData == SECOND_CONTROL_BYTE)
					{
						xbee_data.states = End_Communication_Control_1;
					}
					else
					{
						xbee_data.states = Reset_Data_Control;
					}
					break;
				}
				case End_Communication_Control_1:
				{
					if(xbee_data.receiveData == FIRST_COMMAND)
					{
						xbee_data.states = End_Communication_Control_2;
					}
					else
					{
						xbee_data.states = Reset_Data_Control;
					}
					break;
				}

				case End_Communication_Control_2:
				{
					if(xbee_data.receiveData == SECOND_COMMAND)
					{
						gsm_data.gsm_state_current_index = GsmOnOffSet;
						HAL_UART_AbortReceive_IT(&huart1);
					}
					else
					{
						xbee_data.states = Reset_Data_Control;
												
					}
				}
			}
			HAL_UART_Receive_IT(&huart3, &xbee_data.receiveData, 1);
	}
}

void Gsm_Calibration(Gsm_Datas* gsm_data)
{
	switch(gsm_data->gsm_state_current_index)
	{
		case SerialCommunicationControl :
		{
			SendATCommand(gsm_data, "AT\r\n", "OK\r\n");
			gsm_data->gsm_state_next_index = SerialEchoOff;
			gsm_data->gsm_state_current_index = SerialCommunicationControl;
			break;
		}

		case SerialEchoOff :
		{
			SendATCommand(gsm_data, "ATE0\r\n", "OK\r\n");
			gsm_data->gsm_state_next_index = DeactiveGPRS;
			gsm_data->gsm_state_current_index = EmptyState;
			break;
		}

		case DeactiveGPRS :
		{
			SendATCommand(gsm_data, "AT+CIPSHUT\r\n", "SHUT OK\r\n");
			gsm_data->gsm_state_next_index = ConnectGPRS;
			gsm_data->gsm_state_current_index = EmptyState;
			break;
		}


		case ConnectGPRS :
		{
			SendATCommand(gsm_data, "AT+CGATT=1\r\n", "OK\r\n");
			gsm_data->gsm_state_next_index = SetGPRSProfile;
			gsm_data->gsm_state_current_index = EmptyState;
			break;
		}

		case SetGPRSProfile :
		{
			SendATCommand(gsm_data, "AT+CSTT=\"internet\",\"\",\"\"\r\n", "OK\r\n");
			gsm_data->gsm_state_next_index = BringUPGPRS;
			gsm_data->gsm_state_current_index = EmptyState;
			break;
		}

		case BringUPGPRS :
		{
			SendATCommand(gsm_data, "AT+CIICR\r\n", "OK\r\n");
			gsm_data->gsm_state_next_index = LearnSIM800IP;
			gsm_data->gsm_state_current_index = EmptyState;
			break;
		}

		case LearnSIM800IP :
		{
			SendATCommand(gsm_data, "AT+CIFSR\r\n", "OK\r\n");
			gsm_data->gsm_state_next_index = StartTCPConnect;
			gsm_data->gsm_state_current_index = EmptyState;
			break;
		}

		case StartTCPConnect :
		{
			SendATCommand(gsm_data, "AT+CIPSTART=\"TCP\",\"broker.mqttdashboard.com\",\"1883\"\r\n", "CONNECT OK\r\n");
			gsm_data->gsm_state_next_index = CreateMQTTConnectPack;
			gsm_data->gsm_state_current_index = EmptyState;
			break;
		}

		case CreateMQTTConnectPack :
		{
			char atcommand[255];
			connectData.username.cstring = MQTT_USERNAME;
			connectData.password.cstring = MQTT_PASSWORd;
			connectData.clientID.cstring = MQTT_CLIENT_ID;
			connectData.keepAliveInterval = 60;
			connectData.cleansession = SendMQTTConnectPack;
			gsm_data->len =  MQTTSerialize_connect((unsigned char *)gsm_data->gsmconnectpackage, (int)sizeof(gsm_data->gsmconnectpackage),&connectData);
			sprintf(atcommand,(const char*)"AT+CIPSEND=%d\r\n", gsm_data->len);
			SendATCommand(gsm_data, atcommand, ">");
			gsm_data->gsm_state_next_index = SendMQTTConnectPack;
			gsm_data->gsm_state_current_index = EmptyState;
			break;
		}

		case SendMQTTConnectPack :
		{
			HAL_UART_Transmit(gsm_data->gsm_uart, (uint8_t *)gsm_data->gsmconnectpackage, gsm_data->len, HAL_DELAY);
			gsm_data->at_response = "SEND OK\r\n";
			gsm_data->gsm_state_next_index = CreateMQTTPublishPack;
			gsm_data->gsm_state_current_index = CreateMQTTPublishPack;
			break;
		}

		case CreateMQTTPublishPack :
		{

		  topicString.cstring = MQTT_TOPIC;
		  char atcommand[255];
		  uint16_t index = 0;
		  createMQTTPackage(&lyradata, &gps_data, gsm_data->MQTTPackage, &index);
		  gsm_data->mqtt_len = MQTTSerialize_publish(gsm_data->gsmpublishpackage, (int)sizeof(gsm_data->gsmpublishpackage), 0, 0, 0, 0, topicString, gsm_data->MQTTPackage, index);
			sprintf(atcommand,(const char*)"AT+CIPSEND=%d\r\n", gsm_data->mqtt_len);
			SendATCommand(gsm_data, atcommand, "\r\n");
			gsm_data->gsm_state_next_index = SendMQTTPublishPack;
			gsm_data->gsm_state_current_index = EmptyState;
			break;
		}
		
		case SendMQTTPublishPack :
		{
			HAL_UART_Transmit(gsm_data->gsm_uart, (uint8_t *)gsm_data->gsmpublishpackage, gsm_data->mqtt_len, HAL_DELAY);
			//gsm_data->at_response = "SEND OK";
			gsm_data->gsm_state_current_index = CreateMQTTPublishPack;
			gsm_data->gsm_state_next_index = CreateMQTTPublishPack;
			break;
		}

		case GsmOnOffSet :
		{
			HAL_UART_Transmit(gsm_data->gsm_uart, (uint8_t*)RESET_AT_COMMAND, (uint16_t)strlen(RESET_AT_COMMAND), HAL_DELAY);
			gsm_data->gsm_state_current_index = Gsm1500msWait;
			break;
		}
		
		case EmptyState :
		{
			
			if(gsm_data->gsm_state_next_index == SendMQTTPublishPack)
			{
				gsm_data->gsm_state_current_index = CreateMQTTPublishPack;
			}
			break;
		}

		case Gsm1500msWait :
		{
			if((GSM_STATUS_GPIO_Port->IDR & GSM_STATUS_Pin) == (uint32_t)GPIO_PIN_RESET)
			{
				gsm_data->gsm_state_current_index = Gsm1500msWait;
			}

			else
			{
				gsm_data->gsm_state_current_index = SerialCommunicationControl;
				HAL_UART_Receive_IT(gsm_data-> gsm_uart, &gsm_data-> receivegsmdata, 1);
			}
			break;
		}
	}
}


void createMQTTPackage(LyraDatas *lyradata, GPS_Handle*gps_data, uint8_t* packBuf, uint16_t *index)
{
	AESK_UINT8toUINT8CODE(&lyradata->vcu_data.wake_up_union.wake_up_u8, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata->vcu_data.set_velocity_u8, packBuf, index);
	int16_t phase_a_current_s16 = (int16_t)(lyradata->driver_data.Phase_A_Current_f32 * FLOAT_CONVERTER_2);
	int16_t phase_b_current_s16 = (int16_t)(lyradata->driver_data.Phase_B_Current_f32 * FLOAT_CONVERTER_2);
	uint16_t dc_bus_voltage_u16 = (uint16_t)(lyradata->driver_data.Dc_Bus_voltage_f32 * FLOAT_CONVERTER_1);
	int16_t dc_bus_current_s16 = (int16_t)(lyradata->driver_data.Dc_Bus_Current_f32 * FLOAT_CONVERTER_2);
	int16_t id_f32 = (int16_t)(lyradata->driver_data.Id_f32 * FLOAT_CONVERTER_2);
	int16_t iq_f32 = (int16_t)(lyradata->driver_data.Iq_f32 * FLOAT_CONVERTER_2);
	int16_t IArms_f32 = (int16_t)(lyradata->driver_data.IArms_f32 * FLOAT_CONVERTER_2);
	int16_t IBrms_f32 = (int16_t)(lyradata->driver_data.Torque_f32 * FLOAT_CONVERTER_2);
	AESK_INT16toUINT8_LE(&phase_a_current_s16, packBuf, index);
	AESK_INT16toUINT8_LE(&phase_b_current_s16, packBuf, index);
	AESK_INT16toUINT8_LE(&dc_bus_current_s16, packBuf, index);
	AESK_UINT16toUINT8_LE(&dc_bus_voltage_u16, packBuf, index);
	AESK_INT16toUINT8_LE(&id_f32, packBuf, index);
	AESK_INT16toUINT8_LE(&iq_f32, packBuf, index);
	AESK_INT16toUINT8_LE(&IArms_f32, packBuf, index);
	AESK_INT16toUINT8_LE(&IBrms_f32, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.drive_status_union.drive_status_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.driver_error_union.driver_error_u8), packBuf, index);
	AESK_UINT32toUINT8_LE(&(lyradata->driver_data.Odometer_u32), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.Motor_Temperature_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.actual_velocity_u8), packBuf, index);
	uint16_t bat_volt_u16 = (uint16_t)(lyradata->bms_data.Bat_Voltage_f32 * FLOAT_CONVERTER_2);
	int16_t  bat_cur_s16 = (int16_t)(lyradata->bms_data.Bat_Current_f32 * FLOAT_CONVERTER_2);
	uint16_t bat_cons_u16 = (uint16_t)(lyradata->bms_data.Bat_Cons_f32 * FLOAT_CONVERTER_1);
	uint16_t soc_u16 = (uint16_t)(lyradata->bms_data.Soc_f32 * FLOAT_CONVERTER_2);
	uint16_t worst_cell_voltage_u16 = (uint16_t)(lyradata->bms_data.Worst_Cell_Voltage_f32 * FLOAT_CONVERTER_1);
	AESK_UINT16toUINT8_LE(&bat_volt_u16, packBuf, index);
	AESK_INT16toUINT8_LE(&bat_cur_s16, packBuf, index);
	AESK_UINT16toUINT8_LE(&bat_cons_u16, packBuf, index);
	AESK_UINT16toUINT8_LE(&soc_u16, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_error.bms_error_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.dc_bus_state.dc_bus_state_u8), packBuf, index);
	AESK_UINT16toUINT8_LE(&worst_cell_voltage_u16, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.Worst_Cell_Address_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.Temperature_u8), packBuf, index);
	uint32_t latitude_u32 = gps_data->latitude_f32 * GPS_CONVERTER;
	uint32_t longtitude_u32 = gps_data->longtitude_f32 * GPS_CONVERTER;
	AESK_UINT32toUINT8_LE(&(latitude_u32), packBuf, index);
	AESK_UINT32toUINT8_LE(&(longtitude_u32), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data->speed_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data->satellite_number_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data->gpsEfficiency_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_1_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_2_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_3_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_4_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_5_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_6_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_7_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_8_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_9_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_10_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_11_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_12_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_13_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_14_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_15_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_16_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_17_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_18_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_19_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_20_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_21_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_22_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_23_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_24_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_25_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_26_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_27_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_cells.Cell_28_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->can_error.can_error_u8), packBuf, index);
	gsm_data.MQTT_Counter++;
	AESK_UINT32toUINT8_LE(&gsm_data.MQTT_Counter, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_1_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_2_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_3_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_4_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_5_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_6_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_temps.temp_7_u8), packBuf, index);
	
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_1_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_2_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_3_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_4_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_5_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_6_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_7_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_8_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_9_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_10_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_11_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_12_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_13_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_14_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_15_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_16_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_17_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_18_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_19_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_20_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_21_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_22_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_23_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_24_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_25_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_26_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_27_u8), packBuf, index);
	AESK_INT8toUINT8CODE(&(lyradata->bms_data.bms_soc.offset_SoC_28_u8), packBuf, index);
}

void HAL_CAN_RxFifo0MsgPendingCallback(CAN_HandleTypeDef *hcan)
{
		AESK_CAN_ReadExtIDMessage(&aesk_can, CAN_RX_FIFO1);
		switch(aesk_can.rxMsg.ExtId)
		{
			case WAKE_UP_COMMANDS		 :
			{
				uint16_t vcu_wake_up_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.vcu_data.wake_up_union.wake_up_u8, aesk_can.receivedData, &vcu_wake_up_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.vcu_data.drive_command_union.drive_command_u8, aesk_can.receivedData, &vcu_wake_up_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.vcu_data.set_velocity_u8, aesk_can.receivedData, &vcu_wake_up_index);
				break;
			}
			
			case DRIVER_ID_IQ_VD_VQ :
			{
				uint16_t id_iq_index = 0;
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Id_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &id_iq_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Iq_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &id_iq_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.IArms_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &id_iq_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Torque_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &id_iq_index);
				break;
			}
			case DRIVER_CUR_VOLT :
			{
				uint16_t driver_current_voltage_index = 0;
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Phase_A_Current_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &driver_current_voltage_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Phase_B_Current_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &driver_current_voltage_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Dc_Bus_Current_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &driver_current_voltage_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Dc_Bus_voltage_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &driver_current_voltage_index);
				break;
			}
	
	
			case DRIVER_STATE_AREA :
			{
				uint16_t driver_state_area_index = 0;
				AESK_UINT8toUINT8ENCODE((uint8_t *)&lyradata.driver_data.drive_status_union.drive_status_u8,aesk_can.receivedData, &driver_state_area_index);
				AESK_UINT8toUINT8ENCODE((uint8_t *)&lyradata.driver_data.driver_error_union.driver_error_u8, aesk_can.receivedData, &driver_state_area_index);
				AESK_UINT8toUINT32_LE(&lyradata.driver_data.Odometer_u32, aesk_can.receivedData, &driver_state_area_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.driver_data.Motor_Temperature_u8, aesk_can.receivedData, &driver_state_area_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.driver_data.actual_velocity_u8, aesk_can.receivedData, &driver_state_area_index);
				break;
			}
	
			case BMS_MEASUREMENTS :
			{
				uint16_t bms_measurement_index = 0;
					AESK_UINT16toFLOAT_LE(&lyradata.bms_data.Bat_Voltage_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &bms_measurement_index);
					AESK_INT16toFLOAT_LE(&lyradata.bms_data.Bat_Current_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &bms_measurement_index);
					AESK_UINT16toFLOAT_LE(&lyradata.bms_data.Bat_Cons_f32, aesk_can.receivedData, FLOAT_CONVERTER_1, &bms_measurement_index);
					AESK_UINT16toFLOAT_LE(&lyradata.bms_data.Soc_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &bms_measurement_index);
				break;
			}
	
			case BMS_STATE_DATA :
			{
				uint16_t bms_state_data_index = 0;
					AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_error.bms_error_u8, aesk_can.receivedData, &bms_state_data_index);
					AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.dc_bus_state.dc_bus_state_u8, aesk_can.receivedData, &bms_state_data_index);
					AESK_UINT16toFLOAT_LE(&lyradata.bms_data.Worst_Cell_Voltage_f32, aesk_can.receivedData, FLOAT_CONVERTER_1, &bms_state_data_index);
					AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.Worst_Cell_Address_u8, aesk_can.receivedData, &bms_state_data_index);
					AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.Temperature_u8, aesk_can.receivedData, &bms_state_data_index);
				break;
			}
			
			case BMS_CELLS_1 : 
			{
				uint16_t bms_cells_1_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_1_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_2_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_3_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_4_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_5_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_6_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_7_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_8_u8, aesk_can.receivedData, &bms_cells_1_index);
				break;
			}
			
			case BMS_CELLS_2 : 
			{
				uint16_t bms_cells_2_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_9_u8,  aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_10_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_11_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_12_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_13_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_14_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_15_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_16_u8, aesk_can.receivedData, &bms_cells_2_index);
				break;
			}
			
			case BMS_CELLS_3 : 
			{
				uint16_t bms_cells_3_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_17_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_18_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_19_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_20_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_21_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_22_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_23_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_24_u8, aesk_can.receivedData, &bms_cells_3_index);
				break;
			}
			
			case BMS_CELLS_4 : 
			{
				uint16_t bms_cells_4_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_25_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_26_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_27_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_28_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_1_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_2_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_3_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_4_u8, aesk_can.receivedData, &bms_cells_4_index);

				break;
			}
			
			case BMS_SOC_1 : 
			{
				uint16_t bms_soc_1_index = 0;
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_1_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_2_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_3_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_4_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_5_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_6_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_7_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_8_u8, aesk_can.receivedData, &bms_soc_1_index);
				break;
			}
			
			case BMS_SOC_2 : 
			{
				uint16_t bms_soc_2_index = 0;
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_9_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_10_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_11_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_12_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_13_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_14_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_15_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_16_u8, aesk_can.receivedData, &bms_soc_2_index);
				break;
			}
			
			case BMS_SOC_3 : 
			{
				uint16_t bms_soc_3_index = 0;
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_17_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_18_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_19_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_20_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_21_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_22_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_23_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_24_u8, aesk_can.receivedData, &bms_soc_3_index);
				break;
			}
			
			case BMS_SOC_4 : 
			{
				uint16_t bms_soc_4_index = 0;
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_25_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_26_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_27_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_28_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_5_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_6_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_7_u8, aesk_can.receivedData, &bms_soc_4_index);
				break;
			}
		}
}

void HAL_CAN_RxFifo1MsgPendingCallback(CAN_HandleTypeDef *hcan)
{
		AESK_CAN_ReadExtIDMessage(&aesk_can, CAN_RX_FIFO1);
		switch(aesk_can.rxMsg.ExtId)
		{
			case WAKE_UP_COMMANDS		 :
			{
				uint16_t vcu_wake_up_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.vcu_data.wake_up_union.wake_up_u8, aesk_can.receivedData, &vcu_wake_up_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.vcu_data.drive_command_union.drive_command_u8, aesk_can.receivedData, &vcu_wake_up_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.vcu_data.set_velocity_u8, aesk_can.receivedData, &vcu_wake_up_index);
				lyradata.vcu_can_ID_1_counter++;
				break;
			}
			
			case DRIVER_ID_IQ_VD_VQ :
			{
				uint16_t id_iq_index = 0;
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Id_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &id_iq_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Iq_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &id_iq_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.IArms_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &id_iq_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Torque_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &id_iq_index);
				lyradata.driver_can_ID_1_counter++;
				break;
			}
			case DRIVER_CUR_VOLT :
			{
				uint16_t driver_current_voltage_index = 0;
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Phase_A_Current_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &driver_current_voltage_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Phase_B_Current_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &driver_current_voltage_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Dc_Bus_Current_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &driver_current_voltage_index);
				AESK_INT16toFLOAT_LE(&lyradata.driver_data.Dc_Bus_voltage_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &driver_current_voltage_index);
				lyradata.driver_can_ID_2_counter++;
				break;
			}
	
	
			case DRIVER_STATE_AREA :
			{
				uint16_t driver_state_area_index = 0;
				AESK_UINT8toUINT8ENCODE((uint8_t *)&lyradata.driver_data.drive_status_union.drive_status_u8,aesk_can.receivedData, &driver_state_area_index);
				AESK_UINT8toUINT8ENCODE((uint8_t *)&lyradata.driver_data.driver_error_union.driver_error_u8, aesk_can.receivedData, &driver_state_area_index);
				AESK_UINT8toUINT32_LE(&lyradata.driver_data.Odometer_u32, aesk_can.receivedData, &driver_state_area_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.driver_data.Motor_Temperature_u8, aesk_can.receivedData, &driver_state_area_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.driver_data.actual_velocity_u8, aesk_can.receivedData, &driver_state_area_index);
				lyradata.driver_can_ID_3_counter++;
				break;
			}
	
			case BMS_MEASUREMENTS :
			{
				uint16_t bms_measurement_index = 0;
				AESK_UINT16toFLOAT_LE(&lyradata.bms_data.Bat_Voltage_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &bms_measurement_index);
				AESK_INT16toFLOAT_LE(&lyradata.bms_data.Bat_Current_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &bms_measurement_index);
				AESK_UINT16toFLOAT_LE(&lyradata.bms_data.Bat_Cons_f32, aesk_can.receivedData, FLOAT_CONVERTER_1, &bms_measurement_index);
				AESK_UINT16toFLOAT_LE(&lyradata.bms_data.Soc_f32, aesk_can.receivedData, FLOAT_CONVERTER_2, &bms_measurement_index);
				lyradata.bms_can_ID_1_counter++;
				break;
			}
	
			case BMS_STATE_DATA :
			{
				uint16_t bms_state_data_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_error.bms_error_u8, aesk_can.receivedData, &bms_state_data_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.dc_bus_state.dc_bus_state_u8, aesk_can.receivedData, &bms_state_data_index);
				AESK_UINT16toFLOAT_LE(&lyradata.bms_data.Worst_Cell_Voltage_f32, aesk_can.receivedData, FLOAT_CONVERTER_1, &bms_state_data_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.Worst_Cell_Address_u8, aesk_can.receivedData, &bms_state_data_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.Temperature_u8, aesk_can.receivedData, &bms_state_data_index);
				lyradata.bms_can_ID_2_counter++;
				break;
			}
			
			case BMS_CELLS_1 : 
			{
				uint16_t bms_cells_1_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_1_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_2_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_3_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_4_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_5_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_6_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_7_u8, aesk_can.receivedData, &bms_cells_1_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_8_u8, aesk_can.receivedData, &bms_cells_1_index);
				lyradata.bms_can_ID_3_counter++;
				break;
			}
			
			case BMS_CELLS_2 : 
			{
				uint16_t bms_cells_2_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_9_u8,  aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_10_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_11_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_12_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_13_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_14_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_15_u8, aesk_can.receivedData, &bms_cells_2_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_16_u8, aesk_can.receivedData, &bms_cells_2_index);
				lyradata.bms_can_ID_4_counter++;
				break;
			}
			
			case BMS_CELLS_3 : 
			{
				uint16_t bms_cells_3_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_17_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_18_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_19_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_20_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_21_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_22_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_23_u8, aesk_can.receivedData, &bms_cells_3_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_24_u8, aesk_can.receivedData, &bms_cells_3_index);
				lyradata.bms_can_ID_5_counter++;
				break;
			}
			
			case BMS_CELLS_4 : 
			{
				uint16_t bms_cells_4_index = 0;
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_25_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_26_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_27_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_cells.Cell_28_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_1_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_2_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_3_u8, aesk_can.receivedData, &bms_cells_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_4_u8, aesk_can.receivedData, &bms_cells_4_index);
				lyradata.bms_can_ID_6_counter++;
				break;
			}
			
			case BMS_SOC_1 : 
			{
				uint16_t bms_soc_1_index = 0;
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_1_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_2_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_3_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_4_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_5_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_6_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_7_u8, aesk_can.receivedData, &bms_soc_1_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_8_u8, aesk_can.receivedData, &bms_soc_1_index);
				break;
			}
			
			case BMS_SOC_2 : 
			{
				uint16_t bms_soc_2_index = 0;
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_9_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_10_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_11_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_12_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_13_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_14_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_15_u8, aesk_can.receivedData, &bms_soc_2_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_16_u8, aesk_can.receivedData, &bms_soc_2_index);
				break;
			}
			
			case BMS_SOC_3 : 
			{
				uint16_t bms_soc_3_index = 0;
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_17_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_18_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_19_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_20_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_21_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_22_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_23_u8, aesk_can.receivedData, &bms_soc_3_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_24_u8, aesk_can.receivedData, &bms_soc_3_index);
				break;
			}
			
			case BMS_SOC_4 : 
			{
				uint16_t bms_soc_4_index = 0;
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_25_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_26_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_27_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toINT8ENCODE(&lyradata.bms_data.bms_soc.offset_SoC_28_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_5_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_6_u8, aesk_can.receivedData, &bms_soc_4_index);
				AESK_UINT8toUINT8ENCODE(&lyradata.bms_data.bms_temps.temp_7_u8, aesk_can.receivedData, &bms_soc_4_index);
				break;
			}
		}
}


void RTC_Set_Time_Date()
{
	if(SetTime == 1)
	{
	HAL_RTC_SetTime(&hrtc, &rtctime, RTC_FORMAT_BIN);
	SetTime = 0;
	}
	if(SetDate == 1)
	{
	HAL_RTC_SetDate(&hrtc, &rtcdate, RTC_FORMAT_BIN);
	SetDate = 0;
	}
}

void vars_to_str(char *buffer, const char *format, ...)
{
	va_list args;
	va_start (args, format);
	vsprintf (buffer, format, args);
	va_end (args);
}

void createXBEEPackage(LyraDatas *lyradata, GPS_Handle*gps_data, uint8_t* packBuf, uint16_t *index)
{
	uint8_t header = LYRAHEADER;
	AESK_UINT8toUINT8CODE(&header, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata->vcu_data.wake_up_union.wake_up_u8, packBuf, index);
	AESK_UINT8toUINT8CODE(&lyradata->vcu_data.set_velocity_u8, packBuf, index);
	int16_t phase_a_current_s16 = (int16_t)(lyradata->driver_data.Phase_A_Current_f32 * FLOAT_CONVERTER_2);
	int16_t phase_b_current_s16 = (int16_t)(lyradata->driver_data.Phase_B_Current_f32 * FLOAT_CONVERTER_2);
	uint16_t dc_bus_voltage_u16 = (uint16_t)(lyradata->driver_data.Dc_Bus_voltage_f32 * FLOAT_CONVERTER_1);
	int16_t dc_bus_current_s16 = (int16_t)(lyradata->driver_data.Dc_Bus_Current_f32 * FLOAT_CONVERTER_2);
	int16_t id_f32 = (int16_t)(lyradata->driver_data.Id_f32 * FLOAT_CONVERTER_2);
	int16_t iq_f32 = (int16_t)(lyradata->driver_data.Iq_f32 * FLOAT_CONVERTER_2);
	int16_t vd_f32 = (int16_t)(lyradata->driver_data.IArms_f32 * FLOAT_CONVERTER_2);
	int16_t vq_f32 = (int16_t)(lyradata->driver_data.Torque_f32 * FLOAT_CONVERTER_2);
	AESK_INT16toUINT8_LE(&phase_a_current_s16, packBuf, index);
	AESK_INT16toUINT8_LE(&phase_b_current_s16, packBuf, index);
	AESK_INT16toUINT8_LE(&dc_bus_current_s16, packBuf, index);
	AESK_UINT16toUINT8_LE(&dc_bus_voltage_u16, packBuf, index);
	AESK_INT16toUINT8_LE(&id_f32, packBuf, index);
	AESK_INT16toUINT8_LE(&iq_f32, packBuf, index);
	AESK_INT16toUINT8_LE(&vd_f32, packBuf, index);
	AESK_INT16toUINT8_LE(&vq_f32, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.drive_status_union.drive_status_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.driver_error_union.driver_error_u8), packBuf, index);
	AESK_UINT32toUINT8_LE(&(lyradata->driver_data.Odometer_u32), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.Motor_Temperature_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->driver_data.actual_velocity_u8), packBuf, index);
	uint16_t bat_volt_u16 = (uint16_t)(lyradata->bms_data.Bat_Voltage_f32 * FLOAT_CONVERTER_2);
	int16_t  bat_cur_s16 = (int16_t)(lyradata->bms_data.Bat_Current_f32 * FLOAT_CONVERTER_2);
	uint16_t bat_cons_u16 = (uint16_t)(lyradata->bms_data.Bat_Cons_f32 * FLOAT_CONVERTER_1);
	uint16_t soc_u16 = (uint16_t)(lyradata->bms_data.Soc_f32 * FLOAT_CONVERTER_2);
	uint16_t worst_cell_voltage_u16 = (uint16_t)(lyradata->bms_data.Worst_Cell_Voltage_f32 * FLOAT_CONVERTER_1);
	AESK_UINT16toUINT8_LE(&bat_volt_u16, packBuf, index);
	AESK_INT16toUINT8_LE(&bat_cur_s16, packBuf, index);
	AESK_UINT16toUINT8_LE(&bat_cons_u16, packBuf, index);
	AESK_UINT16toUINT8_LE(&soc_u16, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.bms_error.bms_error_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.dc_bus_state.dc_bus_state_u8), packBuf, index);
	AESK_UINT16toUINT8_LE(&worst_cell_voltage_u16, packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.Worst_Cell_Address_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->bms_data.Temperature_u8), packBuf, index);
	uint32_t latitude_u32 = gps_data->latitude_f32 * GPS_CONVERTER;
	uint32_t longtitude_u32 = gps_data->longtitude_f32 * GPS_CONVERTER;
	AESK_UINT32toUINT8_LE(&(latitude_u32), packBuf, index);
	AESK_UINT32toUINT8_LE(&(longtitude_u32), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data->speed_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data->satellite_number_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(gps_data->gpsEfficiency_u8), packBuf, index);
	AESK_UINT8toUINT8CODE(&(lyradata->can_error.can_error_u8), packBuf, index);
	xbee_data.crc = aeskCRCCalculator(packBuf, *(index));
	AESK_UINT16toUINT8_LE(&(xbee_data.crc), packBuf, index); 	
}

uint16_t aeskCRCCalculator(uint8_t * frame, size_t framesize) 
{
  uint16_t crc16_data = 0;
  uint8_t data = 0;
  for (uint8_t mlen = 0; mlen < framesize; mlen++) {
    data = frame[mlen] ^ ((uint8_t)(crc16_data) & (uint8_t)(0xFF));
    data ^= data << 4;
    crc16_data = ((((uint16_t)data << 8) | ((crc16_data & 0xFF00) >> 8)) ^ (uint8_t)(data >> 4) ^ ((uint16_t)data << 3));
  }
  return (crc16_data);
}

void Can_Error_Control(void)
{
	static uint32_t vcu_can_ID_1_counter = 0;
	static uint32_t bms_can_ID_1_counter = 0;
	static uint32_t bms_can_ID_2_counter = 0;
	static uint32_t bms_can_ID_3_counter = 0;
	static uint32_t bms_can_ID_4_counter = 0;
	static uint32_t bms_can_ID_5_counter = 0;
	static uint32_t bms_can_ID_6_counter = 0;
	static uint32_t driver_can_ID_1_counter = 0;
	static uint32_t driver_can_ID_2_counter = 0;
	static uint32_t driver_can_ID_3_counter = 0;

	
	if(lyradata.driver_can_ID_1_counter > driver_can_ID_1_counter || lyradata.driver_can_ID_2_counter > driver_can_ID_2_counter ||
		 lyradata.driver_can_ID_3_counter > driver_can_ID_3_counter)
	{
		lyradata.can_error.can_error_state.driver_can_error = 0;
	}
	
	else
	{
		lyradata.can_error.can_error_state.driver_can_error = 1;
	}
	
	if(lyradata.bms_can_ID_1_counter > bms_can_ID_1_counter || lyradata.bms_can_ID_2_counter > bms_can_ID_2_counter ||
		 lyradata.bms_can_ID_3_counter > bms_can_ID_3_counter || lyradata.bms_can_ID_4_counter > bms_can_ID_4_counter ||
		 lyradata.bms_can_ID_5_counter > bms_can_ID_5_counter || lyradata.bms_can_ID_6_counter > bms_can_ID_6_counter)
	{
		lyradata.can_error.can_error_state.bms_can_error = 0;
	}
	
	else
	{
		lyradata.can_error.can_error_state.bms_can_error = 1;
	}
	
	if(lyradata.vcu_can_ID_1_counter > vcu_can_ID_1_counter)
	{
		lyradata.can_error.can_error_state.vcu_can_error = 0;
	}
	
	else
	{
		lyradata.can_error.can_error_state.vcu_can_error = 1;
	}
	
	
	
	vcu_can_ID_1_counter = lyradata.vcu_can_ID_1_counter;	
	bms_can_ID_1_counter = lyradata.bms_can_ID_1_counter;
	bms_can_ID_2_counter = lyradata.bms_can_ID_2_counter;
	bms_can_ID_3_counter = lyradata.bms_can_ID_3_counter;
	bms_can_ID_4_counter = lyradata.bms_can_ID_4_counter;
	bms_can_ID_5_counter = lyradata.bms_can_ID_5_counter;
	bms_can_ID_6_counter = lyradata.bms_can_ID_6_counter;
	driver_can_ID_1_counter = lyradata.driver_can_ID_1_counter;
	driver_can_ID_2_counter = lyradata.driver_can_ID_2_counter;
	driver_can_ID_3_counter = lyradata.driver_can_ID_3_counter;
	
}
/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */

  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{ 
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     tex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
