using System;

namespace telemetry_hydro.Variables
{
    public struct Driver
    {

        static public UInt32 odometer_u32;

        static public float phase_a_current_f32; //bu 3 
        static public float phase_b_current_f32;
        static public float dc_bus_current_f32;

        static public float dc_bus_voltage_f32;// bu yok

        static public float id_f32; //bu 4 olacak
        static public float iq_f32;
        static public float iArms_f32; //I could die in your iArms
        static public float vd_f32;
        static public float vq_f32;

        static public byte actual_velocity_u8;
        static public byte motor_temperature_u8;
        static public byte drive_status_u8;
        static public byte driver_error_u8;


        public static bool direction_u1 => Convert.ToBoolean((drive_status_u8 & 0b00000001));
        public static bool brake_u1 => Convert.ToBoolean((drive_status_u8 >> 1 & 0b00000001));
        public static bool ignition_u1 => Convert.ToBoolean((drive_status_u8 >> 2 & 0b00000001));

        public static bool zpc_ok_u1 => Convert.ToBoolean((driver_error_u8 & 0b00000001));
        public static bool pwm_enabled_u1 => Convert.ToBoolean((driver_error_u8 >> 1 & 0b00000001));
        public static bool dc_bus_voltager_error_u1 => Convert.ToBoolean((driver_error_u8 >> 2 & 0b00000001));
        public static bool temp_error_u1 => Convert.ToBoolean((driver_error_u8 >> 3 & 0b00000001));
        public static bool dc_bara_current_error_u1 => Convert.ToBoolean((driver_error_u8 >> 4 & 0b00000001));
        public static bool ID_error_u1 => Convert.ToBoolean((driver_error_u8 >> 5 & 0b00000001));

        public static string log_datas_driver => phase_a_current_f32.ToString() + '$' + phase_b_current_f32.ToString() + '$' +
                                                dc_bus_current_f32.ToString() + '$' + dc_bus_voltage_f32.ToString() + '$' +
                                                id_f32.ToString() + '$' + iq_f32.ToString() + '$' + vd_f32.ToString() + '$' +
                                                vq_f32.ToString() + '$' + drive_status_u8.ToString() + '$' + driver_error_u8.ToString() +
                                                '$' + odometer_u32.ToString() + '$' + motor_temperature_u8 +'$' + actual_velocity_u8.ToString() + '$';
                                        
    }
}
