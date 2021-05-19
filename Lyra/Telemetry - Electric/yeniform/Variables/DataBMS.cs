using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri.Variables
{
    public class DataBMS
    {
        public static float volt_u16;               // uint16 / 100
        public static float cur_s16;                // int16 / 100
        public static float cons_u16;               // uint16 / 10
        public static float soc_u16;                // uint16 / 100
        public static float worst_cell_volt_u16;    // uint16 / 100
        public static byte error_u8;                // uint8
        public static byte dc_bus_state_u8;         // uint8
        public static byte worst_cell_address_u8;   // uint8
        public static byte temperature_u8;          // uint8
        public class Cell
        {
            public byte voltage_u8;
            public byte soc_u8;
            public byte temperature_u8;
        }
        public static List<Cell> cells = new List<Cell>(28);

        public static bool high_voltage_error_u1    => Convert.ToBoolean((error_u8 & 0b00000001));
        public static bool low_voltage_error_u1     => Convert.ToBoolean((error_u8 >> 1 & 0b00000001));
        public static bool temp_error_u1            => Convert.ToBoolean((error_u8 >> 2 & 0b00000001));
        public static bool communication_error_u1   => Convert.ToBoolean((error_u8 >> 3 & 0b00000001));
        public static bool over_current_error_u1    => Convert.ToBoolean((error_u8 >> 6 & 0b00000001));
        public static bool fatal_error_u1           => Convert.ToBoolean((error_u8 >> 4 & 0b00000001));
        public static bool wakeup_error_u1          => Convert.ToBoolean((error_u8 >> 5 & 0b00000001));
        
        public static bool precharge_flag_u1        => Convert.ToBoolean((dc_bus_state_u8 & 0b00000001));
        public static bool discharge_flag_u1        => Convert.ToBoolean((dc_bus_state_u8 >> 1 & 0b00000001));
        public static bool dcbus_ready_flag_u1      => Convert.ToBoolean((dc_bus_state_u8 >> 2 & 0b00000001));
        public static bool charging_flag_u1         => Convert.ToBoolean((dc_bus_state_u8 >> 3 & 0b00000001));
        public static bool balance_flag_u1          => Convert.ToBoolean((dc_bus_state_u8 >> 4 & 0b00000001));
        public static bool precharge_error_u1       => Convert.ToBoolean((dc_bus_state_u8 >> 5 & 0b00000001));

    }
}
