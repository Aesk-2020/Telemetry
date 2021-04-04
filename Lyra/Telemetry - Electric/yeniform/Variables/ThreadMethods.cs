using Guna.UI.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace Telemetri.Variables
{
    //İsimleri değişebilir
    static class ThreadMethods
    {
        public static void TextDegis(TextBox mytext, string value)
        {
            if (mytext.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    TextDegis(mytext,  value);
                };
                mytext.Invoke(del);
                return;
            }
            mytext.Text = value;
        }

        public static void LabelDegis(Label myLabel, string value)
        {
            if (myLabel.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    LabelDegis(myLabel, value);
                };
                myLabel.Invoke(del);
                return;
            }
            myLabel.Text = value;            
        }

        public static void LabelBackColorDegis(Label myLabel, Color value)
        {
            if (myLabel.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    LabelBackColorDegis(myLabel, value);
                };
                myLabel.Invoke(del);
                return;
            }
            myLabel.BackColor = value;
        }

        public static void PBoxBackColorDegis(PictureBox myPBox, Color value)
        {
            if (myPBox.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    PBoxBackColorDegis(myPBox, value);
                };
                myPBox.Invoke(del);
                return;
            }
                myPBox.BackColor = value;           
        }

        public static void GaugeValueDegis(GunaGauge myGauge, int value)
        {
            if (myGauge.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    GaugeValueDegis(myGauge, value);
                };
                myGauge.Invoke(del);
                return;
            }
            myGauge.Value = value;        
        }

        public static void PBarValueDegis(GunaProgressBar myBar, int value)
        {
            if (myBar.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    PBarValueDegis(myBar, value);
                };         
                myBar.Invoke(del);
                return;
            }       
            myBar.Value = value;
        }

        public static void CBarValueDegis(GunaCircleProgressBar myCircle, int value)
        {
            if (myCircle.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    CBarValueDegis(myCircle, value);

                };
                myCircle.Invoke(del);
                return;
            }
            myCircle.Value = value;
        }
    }
}
