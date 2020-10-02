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
namespace telemetry_hydro.Variables
{
    public delegate double GMAPDelegate(double latitude, double longtitude);
    public delegate void GMAPDeleteOverlay();
    public class GMAPController : GpsTracker
    {
        private GMapControl _gmap;
        private GMapOverlay markers = new GMapOverlay("markers");

        public GMAPController(double centerLat, double centerLong, double startLineLatitude, double startLineLong) : base(centerLat, centerLong, startLineLatitude, startLineLong)
        {
            GpsTracker_Init();
        }

        public void GMAPController_Init(GMapControl gmap_)
        {
            _gmap = gmap_;
            gmap_.ShowCenter = false;
            gmap_.SetPositionByKeywords("Korfez Yaris Pisti,Turkey");
            gmap_.DragButton = MouseButtons.Middle;
            gmap_.MapProvider = GMapProviders.BingSatelliteMap;
            gmap_.MaxZoom = 150;
            gmap_.MinZoom = 5;
            gmap_.Zoom = 17;
            
        }

        public double addGMapCalcAngleCalcOdometer(double latitude, double longtitude)
        {
            if(_gmap.InvokeRequired)
            {
                MethodInvoker del = delegate
                    {
                        addGMapCalcAngleCalcOdometer(latitude, longtitude);
                    };
                _gmap.Invoke(del);
                return total_angle;
            }
            PointLatLng receivedPosition = new PointLatLng(latitude, longtitude);
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(receivedPosition, GMarkerGoogleType.red_small);
             markers.Markers.Add(marker);
            _gmap.Overlays.Add(markers);

            if (MACROS.race_start_flag && !MACROS.show_old_datas)
            {
                new_angle = ComputeBearing(latitude, longtitude);
                total_angle += (new_angle - old_angle);
                total_angle += 360;
                total_angle %= 360;
                old_angle = new_angle;
                odometer_gps += GreatCircleDistance(latitude, longtitude);
            }
            old_latitude = latitude;
            old_longtitude = longtitude;
            _gmap.Zoom += 0.00000001;
            _gmap.Zoom -= 0.00000001;
            return total_angle;  
        }

        public void OverlayDelete()
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
