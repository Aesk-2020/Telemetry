/*
 * stm32_can_libv1.c
 *
 *  Created on: 9 Kas 2019
 *      Author: yemrelaydin
 */

#include <AESK_CAN_Library.h>

CAN_ErrorState AESK_CAN_Init(AESK_CAN_Struct *can_struct, uint32_t activateInterrupt)
{

	  if(HAL_CAN_ActivateNotification(&(can_struct->hcan), activateInterrupt) != HAL_OK)
	  {
		  return CAN_Error;
	  }


	  if(HAL_CAN_Start(&(can_struct->hcan)) != HAL_OK)
	  {
		  return CAN_Error;
	  }

	  return CAN_OK;
}

CAN_ErrorState AESK_CAN_ExtIDListFilterConfiguration(AESK_CAN_Struct *can_struct, uint32_t filterAddress,
									   uint32_t FIFOSelect, uint32_t filterBank)
{
	can_struct->sConfig.FilterActivation = CAN_FILTER_ENABLE;
	can_struct->sConfig.FilterMode = CAN_FILTERMODE_IDLIST;
	can_struct->sConfig.FilterScale = CAN_FILTERSCALE_32BIT;
	can_struct->sConfig.FilterBank = filterBank;
	can_struct->sConfig.FilterIdHigh = (uint16_t)(filterAddress >> 13);
	can_struct->sConfig.FilterIdLow = (uint16_t)(filterAddress << 3) | CAN_IDE_32;
	can_struct->sConfig.FilterMaskIdHigh = (uint16_t)(filterAddress >> 13);
	can_struct->sConfig.FilterMaskIdLow = (uint16_t)(filterAddress << 3) | CAN_IDE_32;
	can_struct->sConfig.FilterFIFOAssignment = FIFOSelect;

	if(HAL_CAN_ConfigFilter(&(can_struct->hcan), &(can_struct->sConfig)) != HAL_OK)
	{
		return CAN_Error;
	}

	return CAN_OK;
}

CAN_ErrorState AESK_CAN_StdtIDListFilterConfiguration(AESK_CAN_Struct *can_struct, uint32_t filterAddress,
									   uint32_t FIFOSelect, uint32_t filterBank)
{
	can_struct->sConfig.FilterActivation = CAN_FILTER_ENABLE;
	can_struct->sConfig.FilterMode = CAN_FILTERMODE_IDLIST;
	can_struct->sConfig.FilterScale = CAN_FILTERSCALE_16BIT;
	can_struct->sConfig.FilterBank = filterBank;
	can_struct->sConfig.FilterIdHigh = (filterAddress << 5);
	can_struct->sConfig.FilterIdLow = 0x0000;
	can_struct->sConfig.FilterMaskIdHigh = (filterAddress << 5);
	can_struct->sConfig.FilterMaskIdLow = 0x0000;
	can_struct->sConfig.FilterFIFOAssignment = FIFOSelect;

	if(HAL_CAN_ConfigFilter(&(can_struct->hcan), &(can_struct->sConfig)) != HAL_OK)
	{
		return CAN_Error;
	}

	return CAN_OK;
}

CAN_ErrorState AESK_CAN_ExtIDMaskFilterConfiguration(AESK_CAN_Struct *can_struct, uint32_t filterAddress,
									   uint32_t filterMaskAddress, uint32_t FIFOSelect, uint32_t filterBank)
{
	can_struct->sConfig.FilterActivation = CAN_FILTER_ENABLE;
	can_struct->sConfig.FilterMode = CAN_FILTERMODE_IDMASK;
	can_struct->sConfig.FilterScale = CAN_FILTERSCALE_32BIT;
	can_struct->sConfig.FilterBank = filterBank;
	can_struct->sConfig.FilterIdHigh = (uint16_t)(filterAddress >> 13);
	can_struct->sConfig.FilterIdLow = (uint16_t)(filterAddress << 3) | CAN_IDE_32;
	can_struct->sConfig.FilterMaskIdHigh = (uint16_t)(filterMaskAddress >> 13);
	can_struct->sConfig.FilterMaskIdLow = (uint16_t)(filterMaskAddress << 3) | CAN_IDE_32;
	can_struct->sConfig.FilterFIFOAssignment = FIFOSelect;

	if(HAL_CAN_ConfigFilter(&(can_struct->hcan), &(can_struct->sConfig)) != HAL_OK)
	{
		return CAN_Error;
	}

	return CAN_OK;
}

CAN_ErrorState AESK_CAN_StdIDMaskFilterConfiguration(AESK_CAN_Struct *can_struct, uint32_t filterAddress,
									   uint32_t filterMaskAddress, uint32_t FIFOSelect, uint32_t filterBank)
{
	can_struct->sConfig.FilterActivation = CAN_FILTER_ENABLE;
	can_struct->sConfig.FilterMode = CAN_FILTERMODE_IDMASK;
	can_struct->sConfig.FilterScale = CAN_FILTERSCALE_16BIT;
	can_struct->sConfig.FilterBank = filterBank;
	can_struct->sConfig.FilterIdHigh = (filterAddress << 5);
	can_struct->sConfig.FilterIdLow = 0x0000;
	can_struct->sConfig.FilterMaskIdHigh = (filterMaskAddress << 5);
	can_struct->sConfig.FilterMaskIdLow = 0x0000;
	can_struct->sConfig.FilterFIFOAssignment = FIFOSelect;

	if(HAL_CAN_ConfigFilter(&(can_struct->hcan), &(can_struct->sConfig)) != HAL_OK)
	{
		return CAN_Error;
	}

	return CAN_OK;
}

CAN_ErrorState AESK_CAN_SendExtIDMessage(AESK_CAN_Struct *can_struct, uint32_t address, uint8_t *transmitBuf, uint32_t size)
{
	can_struct->txMsg.ExtId = address;
	can_struct->txMsg.IDE = CAN_ID_EXT;
	can_struct->txMsg.RTR = CAN_RTR_DATA;
	can_struct->txMsg.DLC = size;

	if(HAL_CAN_AddTxMessage(&(can_struct->hcan), &(can_struct->txMsg), transmitBuf, &(can_struct->pTxMailbox)) != HAL_OK)
	{
		return CAN_TransmitError;
	}

	return CAN_OK;
}

CAN_ErrorState AESK_CAN_SendStdIDMessage(AESK_CAN_Struct *can_struct, uint32_t address, uint8_t *transmitBuf, uint32_t size)
{
	can_struct->txMsg.ExtId = address;
	can_struct->txMsg.IDE = CAN_ID_STD;
	can_struct->txMsg.RTR = CAN_RTR_DATA;
	can_struct->txMsg.DLC = size;

	if(HAL_CAN_AddTxMessage(&(can_struct->hcan), &(can_struct->txMsg), transmitBuf, &(can_struct->pTxMailbox)) != HAL_OK)
	{
		return CAN_TransmitError;
	}

	return CAN_OK;
}

CAN_ErrorState AESK_CAN_ReadExtIDMessage(AESK_CAN_Struct *can_struct, uint32_t FIFOSelect)
{
	if(HAL_CAN_GetRxMessage(&(can_struct->hcan), FIFOSelect, &(can_struct->rxMsg), can_struct->receivedData) != HAL_OK)
	{
		return CAN_ReceiveError;
	}

		return CAN_OK;

}

CAN_ErrorState AESK_CAN_ReadStdIDMessage(AESK_CAN_Struct *can_struct, uint32_t address, uint32_t FIFOSelect,
							   uint8_t *receiveBuf)
{
	uint8_t receivedData[8];
	if(HAL_CAN_GetRxMessage(&(can_struct->hcan), FIFOSelect, &(can_struct->rxMsg), receivedData) != HAL_OK)
	{
		return CAN_ReceiveError;
	}

	if(can_struct->rxMsg.StdId == address)
	{
		uint8_t i;
		for(i = 0; i < can_struct->rxMsg.DLC; i++)
		{
			*(receiveBuf++) = receivedData[i];
		}
		return CAN_OK;
	}
	return CAN_WRONG_ID;
}
