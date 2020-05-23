/*
 * Can_Hydra_Header.h
 *
 *  Created on: 8 Nis 2020
 *      Author: ahmet
 */

#ifndef CAN_HYDRA_HEADER_H_
#define CAN_HYDRA_HEADER_H_

#define DRIVER_CUR_VOLT					0x1555DDD0
#define DRIVER_ID_IQ_VD_VQ				0x1555DDD1
#define	DRIVER_STATE_AREA				0x1555DDD2
#define WAKE_UP_COMMANDS				0x15550000
#define EMS_CURRENT            			0x1555EEE0
#define EMS_VOLTAGE						0x1555EEE1
#define EMS_CONSUMPTION					0x1555EEE2
#define EMS_STATE_DATA					0x1555EEE3
#define BMS_MEASUREMENTS				0x1555BBB0
#define BMS_STATE_DATA					0x1555BBB1

typedef union
{
	struct
	{
		uint8_t ZPC_Completed 		  : 1;
		uint8_t PWM_Enabled	  		  : 1;
		uint8_t Dc_Bara_Error 		  : 1;
		uint8_t Temp_Error	  		  : 1;
		uint8_t Dc_Bara_Current_Error : 1;
		uint8_t ID_Error			  : 1;
		uint8_t Wake_Up_Control       : 1;
		uint8_t Reserved			  : 1;
	}Driver_error;
	uint8_t driver_error_u8;
}Driver_error_union;
Driver_error_union driver_states;

typedef union
{
	struct
	{
		uint8_t Direction : 1;
		uint8_t Brake	  : 1;
		uint8_t Ignition  : 1;
	}Drive_status;
	uint8_t drive_status_u8;
}Drive_status_union;



typedef struct
{
	float Phase_A_Current_f32;
	float Phase_B_Current_f32;
	float Dc_Bus_Current_f32;
	float Dc_Bus_voltage_f32;
	float Id_f32;
	float Iq_f32;
	float Vd_f32;
	float Vq_f32;
	uint32_t Odometer_u32;
	uint8_t Motor_Temperature_u8;
	uint8_t actual_velocity_u8;
	Driver_error_union driver_error_union;
	Drive_status_union drive_status_union;
}Driver_Datas;

typedef union
{
	struct
	{
		uint8_t bms_wake_up 	: 1;
		uint8_t ems_wake_up		: 1;
		uint8_t driver_wake_up	: 1;
		uint8_t system_on_off	: 1;
		uint8_t reserved		: 4;
	}wake_up;
	uint8_t wake_up_u8;
}WakeUp_Union;

typedef union
{
	struct
	{
		uint8_t Direction : 1;
		uint8_t Brake	  : 1;
		uint8_t Brake_2	  : 1;
		uint8_t Ignition  : 1;
		uint8_t reserved  : 4;
	}Drive_status;
	uint8_t drive_command_u8;
}Drive_command_union;

typedef struct
{
	WakeUp_Union wake_up_union;
	Drive_command_union drive_command_union;
	uint8_t set_velocity_u8;
}VCU_Datas;


typedef union
{
	struct
	{
		uint8_t High_Voltage_Error   :1;
		uint8_t Low_Voltage_Error    :1;
		uint8_t Temp_Error           :1;
		uint8_t Comminication_Errror :1;
		uint8_t Over_Current_Error   :1;
		uint8_t Wake_Up_Control      :1;
		uint8_t Fatal_Error			 :1;
		uint8_t Reserved             :1;
	}State_Data_Error;
	uint8_t bms_error_u8;
}Bms_State_Union;

typedef union
{
	struct
	{
		uint8_t Precharge_Flag : 1;
		uint8_t Discharge_Flag : 1;
		uint8_t Dc_Bus_Ready   : 1;
		uint8_t Reserved       : 5;
	}Bms_State_Data_Dc_Bus_State;
	uint8_t dc_bus_state_u8;
}Dc_Bus_State_union;

typedef struct
{
	float    Bat_Voltage_f32;
	float    Bat_Current_f32;
	float    Bat_Cons_f32;
	float    Soc_f32;
	float    Worst_Cell_Voltage_f32;
	uint8_t  Worst_Cell_Address_u8;
	uint8_t  Temperature_u8;
	Bms_State_Union bms_error;
	Dc_Bus_State_union dc_bus_state;
}Bms_Datas;

typedef union
{
	struct
	{
		uint8_t Bat_Current_Error : 1;
		uint8_t Fc_Current_Error  : 1;
		uint8_t Out_Current_Error : 1;
		uint8_t Bat_Voltage_Error : 1;
		uint8_t Fc_Voltage_Error  : 1;
		uint8_t Out_Voltage_Error : 1;
		uint8_t Wake_Up_Control   : 1;
		uint8_t Reserved          : 1;
	}State_Data_Error;
	uint8_t ems_error_u8;
}Ems_State_Union;

typedef struct
{
	float   Bat_Current_f32;
	float   FC_Current_f32;
	float   Out_Current_f32;
	float   Bat_Voltage_f32;
	float   FC_Voltage_f32;
	float   Out_Voltage_f32;
	float   Bat_Cons_f32;
	float   FC_Cons_f32;
	float   FC_Lt_Cons_f32;
	float   Out_Cons_f32;
	int8_t  Penalty_s8;
	float   Bat_Soc_f32;
	uint8_t Temperature_u8;
	Ems_State_Union ems_state;

}Ems_Datas;


typedef struct
{
	Bms_Datas 	 bms_data;
	VCU_Datas 	 vcu_data;
	Driver_Datas driver_data;
	Ems_Datas 	 ems_datas;
}HydraDatas;
#endif /* CAN_HYDRA_HEADER_H_ */
