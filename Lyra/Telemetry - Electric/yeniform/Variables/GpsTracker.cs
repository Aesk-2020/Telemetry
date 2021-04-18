using System;

namespace Telemetri.Variables
{
    public class GpsTracker
    {
        public static double angle_f64 { get; set; }
        public static double gps_latitude_f64 { get; set; }
        public static double gps_longtitude_f64 { get; set; }
        public static byte gps_velocity_u8 { get; set; }
        public static byte gps_sattelite_number_u8 { get; set; }
        public static byte gps_efficiency_u8 { get; set; }
        public static string log_gps_data => gps_latitude_f64.ToString("0.0000000") + '\t' + gps_longtitude_f64.ToString("0.0000000") + '\t' +
                                              gps_velocity_u8.ToString() + '\t' + gps_sattelite_number_u8.ToString() + '\t' +
                                              gps_efficiency_u8.ToString();
        public uint odometer_gps;
        public double total_angle = 0;
        public double old_angle;
        public double new_angle;
        public static double old_latitude;
        public static double old_longtitude;
        private double _startLatitude;
        private double _startLongtitude;
        private double _FirststopLatitude;
        private double _FirststopLongtitude;
        public GpsTracker(double centerLat, double centerLong, double startLineLatitude, double startLineLong)
        {
            _startLatitude = centerLat;
            _startLongtitude = centerLong;
            _FirststopLatitude = startLineLatitude;
            _FirststopLongtitude = startLineLong;
        }

        public double ComputeBearing(double car_current_lat, double car_current_long) //PATLAK
        {
            var φ1 = _startLatitude; //latitude 1
            var λ1 = _startLongtitude; //longitude 1
            var φ2 = car_current_lat; //latitude 2
            var λ2 = car_current_long; //longitude 2

            var y = Math.Sin(this.degreeToRadian(λ2 - λ1)) * Math.Cos(this.degreeToRadian(φ2));
            var x = Math.Cos(this.degreeToRadian(φ1)) * Math.Sin(this.degreeToRadian(φ2)) - Math.Sin(this.degreeToRadian(φ1)) * Math.Cos(this.degreeToRadian(φ2)) * Math.Cos(this.degreeToRadian(λ2 - λ1));

            var θ = Math.Atan2(y, x);
            θ = this.radianToDegree(θ);
            θ = (θ + 360) % 360;
            return θ;
        }

        public double degreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public double radianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        public void GpsTracker_Init()
        {
            old_angle = ComputeBearing(_FirststopLatitude, _FirststopLongtitude);
            old_latitude = _FirststopLatitude;
            old_longtitude = _FirststopLongtitude;
        }

        internal uint GreatCircleDistance(double Latitude1, double Longtitude1)
        {
            double Lat1;
            double Lat2;
            double Long1;
            double Long2;
            double Delta;

            Lat1 = degreeToRadian(Latitude1);
            Lat2 = degreeToRadian(old_latitude);
            Long1 = degreeToRadian(Longtitude1);
            Long2 = degreeToRadian(old_longtitude);
            Delta = (2 * Math.Asin(Math.Sqrt((Math.Pow(Math.Sin((Lat1 - Lat2) / 2), 2) + Math.Cos(Lat1) * Math.Cos(Lat2) * (Math.Pow(Math.Sin((Long1 - Long2) / 2), 2))))));
            return (uint)(Delta * MACROS.C_RADIUS_EARTH_KM);
        }
    }
}
