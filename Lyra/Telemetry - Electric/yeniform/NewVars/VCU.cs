using System;
namespace Telemetri.NewVars
{
    public class VCU
    {
        public byte wake_up_u8;
        public byte set_velocity_u8;
        public byte drive_commands_u8;
        public byte can_error_u8;
        
        public bool bms_wake_up_u1 => Convert.ToBoolean((this.wake_up_u8 & 0b00000001));
        public bool driver_wake_up_u1 => Convert.ToBoolean((this.wake_up_u8 >> 2 & 0b00000001));
        public bool system_wake_up_u1 => Convert.ToBoolean((this.wake_up_u8 >> 3 & 0b00000001));
        public bool nextion_control_u1 => Convert.ToBoolean((this.wake_up_u8 >> 4 & 0b00000001));
        public bool Vcu_direction_u1 => Convert.ToBoolean((this.drive_commands_u8 & 0b00000001));
        public bool Vcu_brake_u1 => Convert.ToBoolean((this.drive_commands_u8 >> 1 & 0b00000001));
        public bool Vcu_ignition_u1 => Convert.ToBoolean((this.drive_commands_u8 >> 2 & 0b00000001));
        public bool vcu_can_control_u1 => Convert.ToBoolean((this.can_error_u8 & 0b00000001));
        public bool bms_can_control_u1 => Convert.ToBoolean((this.can_error_u8 >> 1 & 0b00000001));
        public bool driver_can_control_u1 => Convert.ToBoolean((this.can_error_u8 >> 2 & 0b00000001));

        public string LogString()
        {
            return wake_up_u8.ToString() + '\t' + drive_commands_u8.ToString() + '\t' + set_velocity_u8.ToString() + '\t' + can_error_u8.ToString() + '\t';
        }
    }
}
