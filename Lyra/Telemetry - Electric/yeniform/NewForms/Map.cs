using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.Variables;

namespace Telemetri.NewForms
{
    public partial class Map : Form
    {

        GMAPController myGmap = new GMAPController(MACROS.centerLat, MACROS.centerLong, MACROS.startLineLat, MACROS.startLineLong);

        public Map()
        {
            InitializeComponent();
        }
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        #endregion

        #region .. code for Flucuring ..
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /*
         * 40.9570334,29.4104751
         *  PointLatLng receivedPosition = new PointLatLng(latitude, longtitude);
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(receivedPosition, GMarkerGoogleType.red_small);
             markers.Markers.Add(marker);
            _gmap.Overlays.Add(markers);
         */
        Bitmap aeskIcon;
        private void Map_Load(object sender, EventArgs e)
        {
            aeskIcon = new Bitmap(aeskPicture.Image);
            #region doubleBuffer
            myGmap.GMAPController_Init(gMapTool);

            AddMarker(GpsTracker.intercityPoint1, GMarkerGoogleType.arrow, gMapTool);
            AddMarker(GpsTracker.intercityPoint2, GMarkerGoogleType.arrow, gMapTool);
            AddMarker(GpsTracker.intercityPoint3, GMarkerGoogleType.arrow, gMapTool);
            //SetDoubleBuffered(tableLayoutPanel1);
            #endregion
        }


        /*
         *  İSTANBUL PARK 3 NOKTA KOORDİNATLARI 
         *  1.nokta   =  40.9520173224503, 29.4054678082466     //1.nokta
         *  2.nokta   =  40.9520861983152, 29.4059774279594     //2.nokta
         *  3.nokta   =  40.9521798896338, 29.4065064936876     //3.nokta
         *  
         *  DURUM 0: Gelen nokta ile 1.nokta arası mesafe 20 metreden küçük mü?
         *  Evet: DURUM 1'e geç.
         *  Hayır: DURUM 0 devam.
         *  
         *  DURUM 1: Gelen nokta ile 2.nokta ve 1.nokta arası mesafe 20 metreden küçük mü?
         *  Evet: DURUM 2'ye geç.
         *  Hayır: DURUM 1 devam.
         *  
         *  DURUM 2: Gelen nokta ile 2.nokta ve 3.nokta arası mesafe 20 metreden küçük mü?
         *  Evet: Tur at. DURUM 0'a dön. Sayacı sıfırla.
         *  Hayır: DURUM 2 devam.
         *  DURUM 2'de sayaç tut. Sayaç "hayır" koşulunda artsın. Sayaç 5'i geçerse turAlgoHata++ ve DURUM 0'a dönüş;
         */

        private void gMapTool_MouseClick(object sender, MouseEventArgs e)
        {
            gMapTool.Overlays.Clear();
            PointLatLng mouse_position = gMapTool.FromLocalToLatLng(e.X, e.Y);

            AddMarker(mouse_position, GMarkerGoogleType.red_small, gMapTool);
            GpsTracker.LapControl(GpsTracker.intercityPoint1, GpsTracker.intercityPoint2, GpsTracker.intercityPoint3, mouse_position);
        }
        private void AddMarker(PointLatLng point, GMarkerGoogleType gMarker, GMapControl gMap)
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
