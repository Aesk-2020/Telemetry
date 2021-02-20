using System;
using System.Drawing;
using System.Windows.Forms;

namespace Telemetri.NewVars
{
    public class MAP
    {
        private string _imagePath;
        private Bitmap _bmp;
        private Pen _p;
        private SolidBrush _solidBrush;
        private Graphics _g;
        private double _pixelRatioX;
        private double _pixelRatioY;

        private GeoMapCoordinate _topLeft;
        private GeoMapCoordinate _botRight;

        public MAP(string path, GeoMapCoordinate TopLeft, GeoMapCoordinate BottomRight)
        {
            _imagePath = path;
            _topLeft = TopLeft;
            _botRight = BottomRight;
            _bmp = new Bitmap(_imagePath);
            _pixelRatioX = (-1) * (_bmp.Width) / (TopLeft.longitude - BottomRight.longitude);
            _pixelRatioY = (_bmp.Height) / (TopLeft.latitude - BottomRight.latitude);
        }


        private BitMapCoordinate GeoToBit(GeoMapCoordinate geoMap, GeoMapCoordinate TopLeft)
        {
            BitMapCoordinate temp = new BitMapCoordinate();
            double tempx = (geoMap.longitude - TopLeft.longitude) * _pixelRatioX;
            double tempy = (TopLeft.latitude - geoMap.latitude) * _pixelRatioY;

            temp.x = Convert.ToInt32(Math.Round(tempx));
            temp.y = Convert.ToInt32(Math.Round(tempy));

            return temp;
        }

        private GeoMapCoordinate BitToGeo(BitMapCoordinate bitMap, GeoMapCoordinate TopLeft)
        {
            GeoMapCoordinate temp = new GeoMapCoordinate();
            double dLong = bitMap.x / _pixelRatioX;
            double dLat = bitMap.y / _pixelRatioY;

            temp.latitude = TopLeft.latitude - dLat;
            temp.longitude = TopLeft.longitude + dLong;

            return temp;
        }

        public void RenderTheMap(GeoMapCoordinate coordinate, ref PictureBox Box)
        {
            Bitmap tempBitMap = new Bitmap(_bmp);
            BitMapCoordinate bitMapCoordinate = GeoToBit(coordinate, _topLeft);

            _g = Graphics.FromImage(tempBitMap);
            _p = new Pen(Color.Red, 2f);
            _solidBrush = new SolidBrush(Color.Red);
            _g.DrawLine(_p, new Point { X = bitMapCoordinate.x, Y = 0 }, new Point { X = bitMapCoordinate.x, Y = GeoToBit(_botRight, _topLeft).y });
            _g.DrawLine(_p, new Point { X = 0, Y = bitMapCoordinate.y }, new Point { X = GeoToBit(_botRight, _topLeft).x, Y = bitMapCoordinate.y });
            Box.Image = tempBitMap;

            _p.Dispose();
            _g.Dispose();


        }
    }
}
