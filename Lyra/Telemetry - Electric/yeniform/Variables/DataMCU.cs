using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri.Variables
{
    public static class DataMCU
    {
        public static float act_id_current_s16; //int16 / 100 /
        public static float act_iq_current_s16; //int16 / 100 /
        public static float vd_s16;             //int16 / 100 /
        public static float vq_s16;             //int16 / 100 /
        public static float set_id_current_s16; //int16 / 100 /
        public static float set_iq_current_s16; //int16 / 100 /
        public static float set_torque_s16;     //int16 / 100 /
        public static float i_dc_s16;           //int16 / 100 /
        public static float v_dc_s16;           //int16 / 100 /
        public static short act_speed_s16;      //int16 / 100
        public static byte temperature_u8;     //byte
        public static ushort error_status_u16;
        public static sbyte act_torque_s8;      //int8 - 100 /

        public static float act_id_current_s16_mcu2; //int16 / 100 /
        public static float act_iq_current_s16_mcu2; //int16 / 100 /
        public static float vd_s16_mcu2;             //int16 / 100 /
        public static float vq_s16_mcu2;             //int16 / 100 /
        public static float set_id_current_s16_mcu2; //int16 / 100 /
        public static float set_iq_current_s16_mcu2; //int16 / 100 /
        public static float set_torque_s16_mcu2;     //int16 / 100 /
        public static float i_dc_s16_mcu2;           //int16 / 100 /
        public static float v_dc_s16_mcu2;           //int16 / 100 /
        public static short act_speed_s16_mcu2;      //int16 / 100
        public static byte temperature_u8_mcu2;     //byte
        public static ushort error_status_u16_mcu2;
        public static sbyte act_torque_s8_mcu2;      //int8 - 100 /

        public static bool over_cur_IA                     => Convert.ToBoolean((error_status_u16 & 0b00000001));
        public static bool over_cur_IB                     => Convert.ToBoolean((error_status_u16 >> 1 & 0b00000001));
        public static bool over_cur_IC                     => Convert.ToBoolean((error_status_u16 >> 2 & 0b00000001));
        public static bool over_cur_IDC                    => Convert.ToBoolean((error_status_u16 >> 3 & 0b00000001));
        public static bool under_cur_IDC                   => Convert.ToBoolean((error_status_u16 >> 4 & 0b00000001));
        public static bool under_volt_VDC                  => Convert.ToBoolean((error_status_u16 >> 5 & 0b00000001));
        public static bool over_volt_VDC                   => Convert.ToBoolean((error_status_u16 >> 6 & 0b00000001));
        public static bool under_speed                     => Convert.ToBoolean((error_status_u16 >> 7 & 0b00000001));
        public static bool over_speed                      => Convert.ToBoolean((error_status_u16 >> 8 & 0b00000001));
        public static bool over_temp                       => Convert.ToBoolean((error_status_u16 >> 9 & 0b00000001));
        public static bool input_scaling_calib_finished    => Convert.ToBoolean((error_status_u16 >> 10 & 0b00000001));
        public static bool PWM_enabled                     => Convert.ToBoolean((error_status_u16 >> 11 & 0b00000001));
        public static bool free_wheeling_status            => Convert.ToBoolean((error_status_u16 >> 12 & 0b00000001));
        public static bool torque_mode                     => Convert.ToBoolean((error_status_u16 >> 13 & 0b00000001));

        public static bool over_cur_IA_mcu2 => Convert.ToBoolean((error_status_u16 & 0b00000001));
        public static bool over_cur_IB_mcu2 => Convert.ToBoolean((error_status_u16 >> 1 & 0b00000001));
        public static bool over_cur_IC_mcu2 => Convert.ToBoolean((error_status_u16 >> 2 & 0b00000001));
        public static bool over_cur_IDC_mcu2 => Convert.ToBoolean((error_status_u16 >> 3 & 0b00000001));
        public static bool under_cur_IDC_mcu2 => Convert.ToBoolean((error_status_u16 >> 4 & 0b00000001));
        public static bool under_volt_VDC_mcu2 => Convert.ToBoolean((error_status_u16 >> 5 & 0b00000001));
        public static bool over_volt_VDC_mcu2 => Convert.ToBoolean((error_status_u16 >> 6 & 0b00000001));
        public static bool under_speed_mcu2 => Convert.ToBoolean((error_status_u16 >> 7 & 0b00000001));
        public static bool over_speed_mcu2 => Convert.ToBoolean((error_status_u16 >> 8 & 0b00000001));
        public static bool over_temp_mcu2 => Convert.ToBoolean((error_status_u16 >> 9 & 0b00000001));
        public static bool input_scaling_calib_finished_mcu2 => Convert.ToBoolean((error_status_u16 >> 10 & 0b00000001));
        public static bool PWM_enabled_mcu2 => Convert.ToBoolean((error_status_u16 >> 11 & 0b00000001));
        public static bool free_wheeling_status_mcu2 => Convert.ToBoolean((error_status_u16 >> 12 & 0b00000001));
        public static bool torque_mode_mcu2 => Convert.ToBoolean((error_status_u16 >> 13 & 0b00000001));


        public static string log_data => act_id_current_s16.ToString() + "\t" +
                                            act_iq_current_s16.ToString() + "\t" +
                                            vd_s16.ToString() + "\t" +
                                            vq_s16.ToString() + "\t" +
                                            set_id_current_s16.ToString() + "\t" +
                                            set_iq_current_s16.ToString() + "\t" +
                                            set_torque_s16.ToString() + "\t" +
                                            i_dc_s16.ToString() + "\t" +
                                            v_dc_s16.ToString() + "\t" +
                                            act_speed_s16.ToString() + "\t" +
                                            temperature_u8.ToString() + "\t" +
                                            error_status_u16.ToString() + "\t" +
                                            act_torque_s8.ToString() + "\t";

    }
}
