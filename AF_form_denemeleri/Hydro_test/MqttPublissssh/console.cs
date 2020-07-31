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
            Control.CheckForIllegalCrossThreadCalls = false;
            richTextBox1.Text = "This console only works with Send Manuelly option.\n";

        }


        private void ConsoleWrite()
        {
            foreach (byte x in Macros.array_of_x)
            {
                richTextBox1.Text += Convert.ToString(x, 2).PadLeft(8, '0') + " ";
            }
            richTextBox1.Text += "\n----------------------------------------------------------------------";
            richTextBox1.Text += "\n";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
