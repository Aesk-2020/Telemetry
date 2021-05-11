using Guna.UI.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace Telemetri.Variables
{
    static class ThreadMethods
    {
        public static void ChangeText(TextBox mytext, string value)
        {
            if (mytext.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    ChangeText(mytext,  value);
                };
                mytext.Invoke(del);
                return;
            }
            mytext.Text = value;
        }

        public static void ChangeLabel(Label myLabel, string value)
        {
            if (myLabel.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    ChangeLabel(myLabel, value);
                };
                myLabel.Invoke(del);
                return;
            }
            myLabel.Text = value;            
        }

        public static void ChangeLabelBackColor(Label myLabel, Color value)
        {
            if (myLabel.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    ChangeLabelBackColor(myLabel, value);
                };
                myLabel.Invoke(del);
                return;
            }
            myLabel.BackColor = value;
        }

        public static void ChangePBoxBackColor(PictureBox myPBox, Color value)
        {
            if (myPBox.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    ChangePBoxBackColor(myPBox, value);
                };
                myPBox.Invoke(del);
                return;
            }
                myPBox.BackColor = value;           
        }

        public static void ChangeGaugeValue(GunaGauge myGauge, int value)
        {
            if (myGauge.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    ChangeGaugeValue(myGauge, value);
                };
                myGauge.Invoke(del);
                return;
            }
            myGauge.Value = value;        
        }

        public static void ChangePBarValue(GunaProgressBar myBar, int value)
        {
            if (myBar.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    ChangePBarValue(myBar, value);
                };         
                myBar.Invoke(del);
                return;
            }       
            myBar.Value = value;
        }

        public static void ChangeCBarValue(GunaCircleProgressBar myCircle, int value)
        {
            if (myCircle.InvokeRequired)
            {
                MethodInvoker del = delegate
                {
                    ChangeCBarValue(myCircle, value);

                };
                myCircle.Invoke(del);
                return;
            }
            myCircle.Value = value;
        }
    }
}
