using System;
using System.Threading;
namespace Telemetri.NewVars
{
    public class GPS
    {
        public GPS()
        {
            _centerPoint = new GeoMapCoordinate { latitude = MACROS.centerLat, longitude = MACROS.centerLong };
            GeoMapCoordinate temp = new GeoMapCoordinate { latitude = MACROS.startLineLat, longitude = MACROS.startLineLong };
            _old_angle = ComputeBearing(temp);
            _new_angle = ComputeBearing(temp);
            _former = temp;
            _current = temp;
        }
        public GeoMapCoordinate GpsCoordinate 
        {
            get 
            {
                return _current;
            }
            set 
            {
                _current = value;
                coordinateReceived();
            } 
        }
        private void coordinateReceived()
        {

            new Thread(() => {
                
            odometer_gps += _greatCircleDistance(ref _former, _current);
            _new_angle = ComputeBearing(_current);
            total_angle += (_new_angle - _old_angle);
            total_angle += 360;
            total_angle %= 360;
            _old_angle = _new_angle;
            
            }).Start();
        }


        public byte gps_velocity_u8;
        public byte gps_sattelite_number_u8;
        public byte gps_efficiency_u8;

        public uint odometer_gps = 0;
        public double total_angle = 0;

        private GeoMapCoordinate _former;
        private GeoMapCoordinate _current;
        private GeoMapCoordinate _centerPoint;
        private double _old_angle;
        private double _new_angle;

  
        
 

        private double _degreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private double _radianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
        private uint _greatCircleDistance(ref GeoMapCoordinate formerCoordinate, GeoMapCoordinate inputCoordinate)
        {
            double Lat1 = _degreeToRadian(inputCoordinate.latitude);
            double Long1 = _degreeToRadian(inputCoordinate.longitude);

            double Lat2 = _degreeToRadian(formerCoordinate.latitude);
            double Long2 = _degreeToRadian(formerCoordinate.longitude);

            double Delta = (2 * Math.Asin(Math.Sqrt((Math.Pow(Math.Sin((Lat1 - Lat2) / 2), 2) + Math.Cos(Lat1) * Math.Cos(Lat2) * (Math.Pow(Math.Sin((Long1 - Long2) / 2), 2))))));
            
            formerCoordinate = inputCoordinate;
            return (uint)(Delta * MACROS.C_RADIUS_EARTH_KM);
        }

        public string LogString()
        {
            return GpsCoordinate.latitude.ToString() + '$' + GpsCoordinate.longitude.ToString() + '\t' +
                   gps_velocity_u8.ToString() + '\t' + gps_sattelite_number_u8.ToString() + '\t' +
                   gps_efficiency_u8.ToString();
        }
        private double ComputeBearing(GeoMapCoordinate current)
        {
            var φ1 = _centerPoint.latitude;
            var λ1 = _centerPoint.longitude; 
            var φ2 = current.latitude;
            var λ2 = current.longitude; 

            var y = Math.Sin(_degreeToRadian(λ2 - λ1)) * Math.Cos(_degreeToRadian(φ2));
            var x = Math.Cos(_degreeToRadian(φ1)) * Math.Sin(_degreeToRadian(φ2)) - Math.Sin(_degreeToRadian(φ1)) * Math.Cos(_degreeToRadian(φ2)) * Math.Cos(_degreeToRadian(λ2 - λ1));

            var θ = Math.Atan2(y, x);
            θ = _radianToDegree(θ);
            θ = (θ + 360) % 360;
            return θ;
        }

    }
    public struct BitMapCoordinate
    {
        public int x;
        public int y;

    }
    public struct GeoMapCoordinate
    {
        public double latitude;
        public double longitude;
    }
}
