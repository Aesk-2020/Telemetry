using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;
using System.Drawing;
using Telemetri.Variables;

namespace telemetry_hydro.Variables
{
    public delegate double GMAPDelegate(double latitude, double longtitude);
    public delegate void GMAPDeleteOverlay();
    public static class GMAPController
    {
        public static GMapControl _gmap;
        private static GMapOverlay markers = new GMapOverlay("markers");
        static bool isFirst = true;

        public static void GMAPController_Init(GMapControl gmap_)
        {
            _gmap = gmap_;
            gmap_.ShowCenter = false;
            gmap_.Position = new GMap.NET.PointLatLng(MACROS.centerLat, MACROS.centerLong);
            gmap_.DragButton = MouseButtons.Middle;
            gmap_.MapProvider = GMapProviders.BingSatelliteMap;
            gmap_.MaxZoom = 150;
            gmap_.MinZoom = 5;
            gmap_.Zoom = 15.8;
            
        }

        public static void GMapAddPointAndOdometer(double latitude, double longtitude)
        {
            if(_gmap.InvokeRequired)
            {
                MethodInvoker del = delegate
                    {
                        GMapAddPointAndOdometer(latitude, longtitude);
                    };
                _gmap.Invoke(del);
            }
            if(isFirst == true)
            {
                DataGPS.point1 = new PointLatLng(latitude, longtitude);
            }
            else
            {
                DataGPS.point1 = DataGPS.point2;
                DataGPS.point2 = new PointLatLng(latitude, longtitude);
                GMapOverlay markers = new GMapOverlay("markers");
                GMapMarker marker = new GMarkerGoogle(DataGPS.point2, GMarkerGoogleType.red_small);
                markers.Markers.Add(marker);
                _gmap.Overlays.Add(markers);
                DataGPS.odometer += DataGPS.CalculateDistance(DataGPS.point1, DataGPS.point2);
                isFirst = false;
            }
            _gmap.Zoom += 0.00000001;
            _gmap.Zoom -= 0.00000001;
        }

        public static void OverlayDelete()
        {
            if(_gmap.InvokeRequired)
            {
                GMAPDeleteOverlay del = new GMAPDeleteOverlay(OverlayDelete);
                _gmap.Invoke(del);
            }
            else
            {
                _gmap.Overlays.Clear();
                _gmap.Zoom += 0.00000001;
                _gmap.Zoom -= 0.00000001;
            }

        }
       
    }
}
