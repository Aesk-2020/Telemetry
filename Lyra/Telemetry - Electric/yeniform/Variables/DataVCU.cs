using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri.Variables
{
    public static class DataVCU
    {
        public static byte  drive_commands_u8;
        public static short speed_set_rpm_s16;
        public static short torque_set_s16;
        public static ushort speed_limit_u16;
        public static byte torque_limit_u8;
        public static byte can_error_u8;
        public static float kp = 11;
        public static float ki = 11;
        public static float kd = 1;

        public static bool BMS_Wake_u1 => Convert.ToBoolean((drive_commands_u8 >> 0 & 0b00000001));
        public static bool MCU_Wake_u1 => Convert.ToBoolean((drive_commands_u8 >> 1 & 0b00000001));
        public static bool freewheeling_u1 => Convert.ToBoolean((drive_commands_u8 >> 2 & 0b00000001));
        public static bool vcu_torque_output_u1 => Convert.ToBoolean((drive_commands_u8 >> 3 & 0b00000001));
        public static bool brake_u1         => Convert.ToBoolean((drive_commands_u8 >> 4 & 0b00000001));
        public static bool dcbus_u1     => Convert.ToBoolean((drive_commands_u8 >> 5 & 0b00000001));
        public static bool direction_u1     => Convert.ToBoolean((drive_commands_u8 >> 6 & 0b00000001));
        /*
         * Brake
         * 0: Off
         * 1: On
         * 
         * Direction
         * 0: Forward
         * 1: Backward
         */
        public static string log_data => drive_commands_u8.ToString() + "\t" +
                                            speed_set_rpm_s16.ToString() + "\t" +
                                            torque_set_s16.ToString() + "\t" +
                                            speed_limit_u16.ToString() + "\t" +
                                            torque_limit_u8 + "\t" +
                                            kp + "\t" + ki + "\t" + kd + "\t";
    }
}
