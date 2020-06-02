using System;
using System.Windows.Forms;

namespace telemetry_hydro.Variables
{
    public class EMS
    {
        public static float bat_cons_f32;
        public static float fc_cons_f32;
        public static float fc_lt_cons_f32;
        public static float bat_cur_f32;
        public static float fc_cur_f32;
        public static float out_cur_f32;
        public static float bat_volt_f32;
        public static float fc_volt_f32;
        public static float out_volt_f32;
        public static float bat_soc_f32;
        public static byte error_u8;
        public static sbyte penalty_s8;

        public static bool bat_current_error_u1 => Convert.ToBoolean((error_u8 & 0b00000001));
        public static bool fc_current_error_u1 => Convert.ToBoolean((error_u8 >> 1 & 0b00000001));
        public static bool out_current_error_u1 => Convert.ToBoolean((error_u8 >> 2 & 0b00000001));
        public static bool bat_voltage_error_u1 => Convert.ToBoolean((error_u8 >> 3 & 0b00000001));
        public static bool fc_voltage_error_u1 => Convert.ToBoolean((error_u8 >> 4 & 0b00000001));
        public static bool out_voltage_error_u1 => Convert.ToBoolean((error_u8 >> 5 & 0b00000001));
        public static bool wake_up_u1 => Convert.ToBoolean((error_u8 >> 6 & 0b00000001));
    }
}
