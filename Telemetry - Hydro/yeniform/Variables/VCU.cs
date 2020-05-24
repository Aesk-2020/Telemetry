﻿using System;

namespace telemetry_hydro.Variables
{
    public struct VCU
    {
       public static byte wake_up_u8;
       public static byte set_velocity_u8;
       public static byte drive_commands_u8;

       public static bool bms_wake_up_u1 => Convert.ToBoolean((wake_up_u8 & 0b00000001));
       public static bool driver_wake_up_u1 => Convert.ToBoolean((wake_up_u8 >> 2 & 0b00000001));
       public static bool Vcu_direction_u1 => Convert.ToBoolean((drive_commands_u8 & 0b00000001));
       public static bool Vcu_brake_u1 => Convert.ToBoolean((drive_commands_u8 >> 1 & 0b00000001));
       public static bool Vcu_ignition_u1 => Convert.ToBoolean((drive_commands_u8 >> 2 & 0b00000001));
       public static string log_datas => wake_up_u8.ToString() + '$' + drive_commands_u8.ToString() + '$' + set_velocity_u8.ToString() + '$';
    }
}