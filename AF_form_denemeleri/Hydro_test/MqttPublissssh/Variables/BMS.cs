using System;


namespace MqttPublissssh.Variables
{
    public class BMS
    {
        public static float bat_volt_f32; // bu graphda olacak
        public static float bat_current_f32; // bu da olacak
        public static float power_emitted => (bat_volt_f32 * bat_current_f32);
        // bi de bunlarin carpimlari

        public static float bat_cons_f32;
        public static float soc_f32;
        public static byte bms_error_u8;
        public static byte dc_bus_state_u8;
        public static float worst_cell_voltage_f32;
        public static byte worst_cell_address_u8;
        public static byte temp_u8;

        public static float[] bms_cells = new float[84];


    }
}
