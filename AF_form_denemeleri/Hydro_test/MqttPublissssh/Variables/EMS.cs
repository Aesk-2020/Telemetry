using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttPublissssh.Variables
{
    public struct EMS
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
        //public static float sharing_ratio => bat_cons_f32 / (bat_cons_f32 + (fc_lt_cons_f32 * 3));
        public static byte error_u8;//u8
        public static sbyte penalty_s8;//int8
        public static byte temperature_u8;
    }
}
