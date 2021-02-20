using System;

namespace Telemetri.NewVars
{
    public class MCU
    {
        public UInt32 odometer_u32;

        public float phase_a_current_f32;
        public float phase_b_current_f32;
        public float dc_bus_current_f32;

        public float dc_bus_voltage_f32;

        public float id_f32;
        public float iq_f32;
        public float IArms_f32;
        public float Torque_f32;

        public byte actual_velocity_u8;
        public byte motor_temperature_u8;
        public byte drive_status_u8;
        public byte driver_error_u8;
        

        public bool direction_u1 => Convert.ToBoolean((drive_status_u8 & 0b00000001));
        public bool brake_u1 => Convert.ToBoolean((drive_status_u8 >> 1 & 0b00000001));
        public bool ignition_u1 => Convert.ToBoolean((drive_status_u8 >> 2 & 0b00000001));

        public bool zpc_ok_u1 => Convert.ToBoolean((driver_error_u8 & 0b00000001));
        public bool pwm_enabled_u1 => Convert.ToBoolean((driver_error_u8 >> 1 & 0b00000001));
        public bool dc_bus_voltager_error_u1 => Convert.ToBoolean((this.driver_error_u8 >> 2 & 0b00000001));
        public bool temp_error_u1 => Convert.ToBoolean((driver_error_u8 >> 3 & 0b00000001));
        public bool dc_bara_current_error_u1 => Convert.ToBoolean((driver_error_u8 >> 4 & 0b00000001));
        public bool ID_error_u1 => Convert.ToBoolean((driver_error_u8 >> 5 & 0b00000001));

        public string LogString()
        {
            return phase_a_current_f32.ToString() + '\t' + phase_b_current_f32.ToString() + '\t' +
                                        dc_bus_current_f32.ToString() + '\t' + dc_bus_voltage_f32.ToString() + '\t' +
                                        id_f32.ToString() + '\t' + iq_f32.ToString() + '\t' + IArms_f32.ToString() + '\t' +
                                        Torque_f32.ToString() + '\t' + drive_status_u8.ToString() + '\t' + driver_error_u8.ToString() +
                                        '\t' + odometer_u32.ToString() + '\t' + motor_temperature_u8 + '\t' + actual_velocity_u8.ToString() + '\t';
        }


    }
}
