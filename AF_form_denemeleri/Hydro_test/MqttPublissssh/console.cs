using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MqttPublissssh.Variables;


namespace MqttPublissssh
{
    public partial class console : Form
    {
        public console()
        {
            InitializeComponent();
        }

        private void console_Load(object sender, EventArgs e)
        {
            Macros.consoleFront = ConsoleWrite;

        }

        int x = 0;
        private void ConsoleWrite()
        {
            x++;
            if (x == 15)
            {

                richTextBox1.Text = " ";
                x = 0;

            }


            foreach(byte x in Macros.array_of_x)
            {
                richTextBox1.Text += Convert.ToString(x, 2).PadLeft(8, '0') + " ";


            }
            richTextBox1.Text += "\n----------------------------------------------------------------------";
            richTextBox1.Text += "\n";

        }
    }
}
