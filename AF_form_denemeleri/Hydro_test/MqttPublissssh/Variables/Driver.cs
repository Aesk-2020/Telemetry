using System;

namespace MqttPublissssh.Variables
{
    public struct Driver
    {
        static public byte drive_command_u8;
        static public UInt32 odometer_u32;

        static public float phase_a_current_f32; 
        static public float phase_b_current_f32;
        static public float dc_bus_current_f32;

        static public float dc_bus_voltage_f32;

        static public float id_f32; 
        static public float iq_f32;
        static public float torque_f32;
        static public float phase_a_rms_f32;

        static public byte actual_velocity_u8;
        static public byte motor_temperature_u8;
        static public byte drive_status_u8;
        static public byte driver_error_u8;
    }
}
