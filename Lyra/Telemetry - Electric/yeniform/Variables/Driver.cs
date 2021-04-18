using System;

namespace Telemetri.Variables
{
    public struct Driver
    {

        static public UInt32 odometer_u32;

        static public float phase_a_current_f32; 
        static public float phase_b_current_f32;
        static public float dc_bus_current_f32;

        static public float dc_bus_voltage_f32;

        static public float id_f32;
        static public float iq_f32;
        static public float IArms_f32;
        static public float Torque_f32;

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

        public static string log_data_driver => phase_a_current_f32.ToString("0.00") + '\t' + phase_b_current_f32.ToString("0.00") + '\t' +
                                                dc_bus_current_f32.ToString("0.00") + '\t' + dc_bus_voltage_f32.ToString("0.00") + '\t' +
                                                id_f32.ToString("0.00") + '\t' + iq_f32.ToString("0.00") + '\t' + IArms_f32.ToString("0.00") + '\t' +
                                                Torque_f32.ToString("0.00") + '\t' + drive_status_u8.ToString() + '\t' + driver_error_u8.ToString() +
                                                '\t' + odometer_u32.ToString() + '\t' + motor_temperature_u8 +'\t' + actual_velocity_u8.ToString() + '\t';
                                        
    }
}
