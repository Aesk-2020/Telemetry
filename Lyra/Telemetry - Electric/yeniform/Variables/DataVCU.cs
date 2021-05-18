using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri.Variables
{
    public static class DataVCU
    {
        public static char  drive_commands_u8;
        public static short speed_set_rpm_s16;
        public static char  torque_set_u8;
        public static ushort speed_limit_u16;
        public static char  torque_limit_u8;
        public static char  can_error_u8;
        public static byte drive_mode_u3    => Convert.ToByte(drive_commands_u8 & 0b00000011);
        /*
         * Set Drive Mode
         * 0: No operation
         * 1: Freewheeling (Ignition off)
         * 2: Speed control
         * 3: Torque control
         */
        public static bool brake_u1         => Convert.ToBoolean((drive_commands_u8 >> 2 & 0b00000001));
        public static bool direction_u1     => Convert.ToBoolean((drive_commands_u8 >> 3 & 0b00000001));
        /*
         * Brake
         * 0: Off
         * 1: On
         * 
         * Direction
         * 0: Forward
         * 1: Backward
         */
    }
}
