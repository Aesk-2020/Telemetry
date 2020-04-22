using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeniform.Variables
{
    class Driver
    {
        static public UInt32 odometer_u32;

        static public float phase_a_current_f32; //bu 3 
        static public float phase_b_current_f32;
        static public float dc_bus_current_f32;

        static public float dc_bus_voltage_f32;// bu yok

        static public float id_f32; //bu 4 olacak
        static public float iq_f32;
        static public float vd_f32;
        static public float vq_f32;

        static public byte actual_velocity_u8;
        static public byte motor_temperature_u8;
        static public byte drive_status_u8;
        static public byte error_u8;
    }
}
