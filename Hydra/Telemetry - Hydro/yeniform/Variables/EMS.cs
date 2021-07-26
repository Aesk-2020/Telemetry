using System;
using System.Windows.Forms;

namespace telemetry_hydro.Variables
{
    public class EMS
    {
        public static float bat_cons_f32;//uint16/100
        public static float fc_cons_f32;//uint16/100
        public static float fc_lt_cons_f32;//uint16/100
        public static float out_cons_f32;//uint16/100

        public static float bat_cur_f32;//int16/100
        public static float fc_cur_f32;//int16/100
        public static float out_cur_f32;//int16/100

        public static float bat_volt_f32;//uint16/100
        public static float fc_volt_f32;//uin16//100
        public static float out_volt_f32;//uint16/100

        public static float bat_soc_f32;//uin16/100
        public static byte  error_u8;//u8
        public static sbyte penalty_s8;//int8
        public static byte temperature_u8;

        public static bool bat_current_error_u1 => Convert.ToBoolean((error_u8 & 0b00000001));
        public static bool fc_current_error_u1 => Convert.ToBoolean((error_u8 >> 1 & 0b00000001));
        public static bool out_current_error_u1 => Convert.ToBoolean((error_u8 >> 2 & 0b00000001));
        public static bool bat_voltage_error_u1 => Convert.ToBoolean((error_u8 >> 3 & 0b00000001));
        public static bool fc_voltage_error_u1 => Convert.ToBoolean((error_u8 >> 4 & 0b00000001));
        public static bool out_voltage_error_u1 => Convert.ToBoolean((error_u8 >> 5 & 0b00000001));

        public static string log_datas_ems => bat_cons_f32.ToString() + '\t' + fc_cons_f32.ToString() + '\t' + fc_lt_cons_f32.ToString() + '\t' + out_cons_f32.ToString() + '\t' + 
                                              bat_cur_f32.ToString()  + '\t' + fc_cur_f32.ToString()  + '\t' + out_cur_f32.ToString()    + '\t' + 
                                              bat_volt_f32.ToString() + '\t' + fc_volt_f32.ToString() + '\t' + out_volt_f32.ToString()   + '\t' + 
                                              bat_soc_f32.ToString()  +'\t'  + error_u8.ToString()    + '\t' + penalty_s8.ToString()     + '\t' + temperature_u8.ToString();
    }
}
