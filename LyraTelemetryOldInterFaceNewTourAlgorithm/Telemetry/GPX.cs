using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetry
{
    public class GPX
    {
        public struct StartCoordinate
        {
            double X { get; set; }
            double Y { get; set; }
        }

        public struct EndCoordinate
        {
            double X { get; set; }
            double Y { get; set; }
        }
    }
}
