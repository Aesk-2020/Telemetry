using GMap.NET;
using System;
using telemetry_hydro.Variables;

namespace Telemetri.Variables
{
    public static class DataGPS
    {
        public static double angle_f64 { get; set; }
        public static double gps_latitude_f64 { get; set; }
        public static double gps_longtitude_f64 { get; set; }
        public static byte gps_velocity_u8 { get; set; }
        public static byte gps_sattelite_number_u8 { get; set; }
        public static byte gps_efficiency_u8 { get; set; }

        public static long odometer = 0;
        public static PointLatLng point1;
        public static PointLatLng point2;

        //UPDATED
        public static string log_gps_data => gps_latitude_f64.ToString("0.0000000") + '\t' + gps_longtitude_f64.ToString("0.0000000") + '\t' +
                                              gps_velocity_u8.ToString() + '\t' + gps_sattelite_number_u8.ToString() + '\t' +
                                              gps_efficiency_u8.ToString();
        //NEW
        public static PointLatLng lapPoint1 = new PointLatLng(40.9520173224503, 29.4054678082466); //İSTANBUL PARK VARSAYILAN 1.NOKTA
        public static PointLatLng lapPoint2 = new PointLatLng(40.9520861983152, 29.4059774279594); //İSTANBUL PARK VARSAYILAN 2.NOKTA
        public static PointLatLng lapPoint3 = new PointLatLng(40.9521798896338, 29.4065064936876); //İSTANBUL PARK VARSAYILAN 3.NOKTA
        public static LapCountSteps step = LapCountSteps.PointOne;
        public static int lapCounter = 0;
        public static long pointDistance = 40;

        //NEW
        public enum LapCountSteps
        {
            PointOne    = 0,
            PointTwo    = 1,
            PointThree  = 2,
        }


        public static void LapControl(PointLatLng p1, PointLatLng p2, PointLatLng p3, PointLatLng pRecieved)
        {
            switch (step)
            {
                case LapCountSteps.PointOne:
                    {
                        long distance = CalculateDistance(p1, pRecieved);
                        if(distance < pointDistance)
                        {
                            step = LapCountSteps.PointTwo;
                        }
                        break;
                    }
                case LapCountSteps.PointTwo:
                    {
                        long distance1 = CalculateDistance(p1, pRecieved);
                        long distance2 = CalculateDistance(p2, pRecieved);
                        if(distance1 < pointDistance && distance2 < pointDistance)
                        {
                            step = LapCountSteps.PointThree;
                        }
                        break;
                    }
                case LapCountSteps.PointThree:
                    {
                        long distance1 = CalculateDistance(p2, pRecieved);
                        long distance2 = CalculateDistance(p3, pRecieved);
                        if (distance1 < pointDistance && distance2 < pointDistance)
                        {
                            step = LapCountSteps.PointOne;
                            lapCounter++;
                            //UITools.Telemetry2021.lapCount.Text = lapCounter.ToString() + "/8";
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        public static long CalculateDistance(PointLatLng p1, PointLatLng p2)
        {
            Int64 p1Lat = (Int64)(Math.Round(p1.Lat, 6, MidpointRounding.AwayFromZero) * MACROS.GPS_DIVIDER);
            Int64 p1Lng = (Int64)(Math.Round(p1.Lng, 6, MidpointRounding.AwayFromZero) * MACROS.GPS_DIVIDER);

            Int64 p2Lat = (Int64)(Math.Round(p2.Lat, 6, MidpointRounding.AwayFromZero) * MACROS.GPS_DIVIDER);
            Int64 p2Lng = (Int64)(Math.Round(p2.Lng, 6, MidpointRounding.AwayFromZero) * MACROS.GPS_DIVIDER);

            Int64 distanceX = Math.Abs(p1Lat - p2Lat);
            Int64 distanceY = Math.Abs(p1Lng - p2Lng);
            Int64 distance = (Int64)Math.Round(Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2)) / 10);

            return distance;
        }

    }
}
