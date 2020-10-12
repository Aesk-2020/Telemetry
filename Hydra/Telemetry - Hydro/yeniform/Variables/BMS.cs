using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeniform.Variables
{
    class BMS
    {

        static public float bat_volt_f32; // bu graphda olacak
        static public float bat_current_f32; // bu da olacak

        static public float power_emitted;
        // bi de bunlarin carpimlari
        
        static public float bat_cons_f32;
        static public float soc_f32;
        static public byte error_u8;
        static public byte dc_bus_state_u8;
        static public float worst_cell_voltage_f32;
        static public byte worst_cell_address_u8;
        static public byte temp_u8;
    }
}
