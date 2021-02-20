using System;

namespace Telemetri.NewVars
{
    public class BMS
    {
        public float bat_volt_f32;
        public float bat_current_f32;
        public float power_emitted => (this.bat_current_f32 * this.bat_volt_f32);
        public float bat_cons_f32;
        public float soc_f32;
        public byte bms_error_u8;
        public byte dc_bus_state_u8;
        public float worst_cell_voltage_f32;

        public byte worst_cell_address_u8;
        public byte temp_u8;

        public byte temp1_u8;
        public byte temp2_u8;
        public byte temp3_u8;
        public byte temp4_u8;
        public byte temp5_u8;
        public byte temp6_u8;
        public byte temp7_u8;

        public float[] bms_cells = new float[84];
        public float[] bms_soc = new float[84];

        public bool precharge_flag_u1 => Convert.ToBoolean(this.dc_bus_state_u8 & 0b00000001);
        public bool discharge_flag_u1 => Convert.ToBoolean(this.dc_bus_state_u8 >> 1 & 0b00000001);
        public bool dc_bus_ready_flag_u1 => Convert.ToBoolean(this.dc_bus_state_u8 >> 2 & 0b00000001);
        public bool charging_u1 => Convert.ToBoolean(this.dc_bus_state_u8 >> 3 & 0b00000001);

        public bool high_voltage_error_u1 => Convert.ToBoolean((this.bms_error_u8 & 0b00000001));
        public bool low_voltage_u1 => Convert.ToBoolean((this.bms_error_u8 >> 1 & 0b00000001));
        public bool bms_temp_error_u1 => Convert.ToBoolean((this.bms_error_u8 >> 2 & 0b00000001));
        public bool comm_error_u1 => Convert.ToBoolean((this.bms_error_u8 >> 3 & 0b00000001));
        public bool over_current_error_u1 => Convert.ToBoolean((this.bms_error_u8 >> 4 & 0b00000001));
        public bool bms_fatal_error_u1 => Convert.ToBoolean((this.bms_error_u8 >> 5 & 0b00000001));

        public string LogString()
        {
            return bat_volt_f32.ToString() + '\t' + bat_current_f32.ToString() + '\t' + bat_cons_f32.ToString()
                                              + '\t' + soc_f32.ToString() + '\t' + bms_error_u8.ToString() + '\t' + dc_bus_state_u8.ToString()
                                              + '\t' + worst_cell_voltage_f32.ToString() + '\t' + worst_cell_address_u8.ToString()
                                              + '\t' + temp_u8.ToString() + '\t';
        }




    }
}
