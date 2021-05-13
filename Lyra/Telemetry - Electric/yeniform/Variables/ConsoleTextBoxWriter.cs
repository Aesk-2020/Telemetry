using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telemetri.Variables
{
    public class ConsoleTextBoxWriter : TextWriter
    {
        private TextBox textBox;

        public ConsoleTextBoxWriter(TextBox textBox)
        {
            //Console.SetOut(this);
            this.textBox = textBox;
        }
        public override Encoding Encoding { get { return Encoding.UTF8; } }

        public override void Write(string value)
        {
            WriteImp(value);
        }

        public override void WriteLine(string value)
        {
            WriteImp(value + Environment.NewLine);
        }

        private void WriteImp(string value)
        {
            if (this.textBox.InvokeRequired)
                this.textBox.Invoke(new MethodInvoker(delegate ()
                {
                    textBox.AppendText(value);
                }));
            else
                textBox.AppendText(value);
        }
    }
}
