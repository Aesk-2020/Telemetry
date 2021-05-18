using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri.Variables
{
    public static class DataGPS
    {
        public static double latitude_f32;      // uint64 / 1000000
        public static double longtitude_f32;    // uint64 / 1000000
        public static char speed_u8;
        public static char sattelite_u8;
        public static char efficiency_u8;
    }
}
