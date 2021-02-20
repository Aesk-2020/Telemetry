using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri.NewVars
{
    public static class DATA
    {
        public static BMS Bms = new BMS();
        public static VCU Vcu = new VCU();
        public static MCU Mcu = new MCU();
        public static GPS Gps = new GPS();

        public static string MainLogString()
        {
            //time vcu mcu bms gps
            return (Vcu.LogString() + Mcu.LogString() + Bms.LogString()+Gps.LogString());
        }
    }
}
