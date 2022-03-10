using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using telemetry_hydro.Variables;

namespace Telemetri.Variables
{
    public static class DataGPS
    {
        public static double angle_f64 { get; set; }
        public static double latitude_f32 { get; set; }
        public static double longtitude_f32 { get; set; }
        public static byte speed_u8 { get; set; }
        public static byte sattelite_u8 { get; set; }
        public static byte efficiency_u8 { get; set; }

        public static long odometer = 0;
        public static PointLatLng point1;
        public static PointLatLng point2;

        //UPDATED
        public static string log_gps_data => latitude_f32.ToString("0.0000000") + '\t' + longtitude_f32.ToString("0.0000000") + '\t' +
                                              speed_u8.ToString() + '\t' + sattelite_u8.ToString() + '\t' +
                                              efficiency_u8.ToString() + "\t" + lapCounter.ToString();
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
                            GMAPController._gmap.Overlays.Clear();
                            AddMarker(lapPoint1, GMarkerGoogleType.green_small, GMAPController._gmap);
                            AddMarker(lapPoint2, GMarkerGoogleType.green_small, GMAPController._gmap);
                            AddMarker(lapPoint3, GMarkerGoogleType.green_small, GMAPController._gmap);
                            //TUR ALGO NOKTALARINI HARİTAYA EKLE
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
        public static void AddMarker(PointLatLng point, GMarkerGoogleType gMarker, GMapControl gMap)
        {
            GMapOverlay gMapOverlay = new GMapOverlay("markers");
            GMapMarker mapMarker = new GMarkerGoogle(point, gMarker);
            gMapOverlay.Markers.Add(mapMarker);
            gMap.Overlays.Add(gMapOverlay);
            gMap.Zoom += 0.00000001;
            gMap.Zoom -= 0.00000001;
        }
    }
}
