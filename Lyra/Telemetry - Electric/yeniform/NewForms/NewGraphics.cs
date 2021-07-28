using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Defaults;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using Telemetri.Variables;

namespace Telemetri.NewForms
{
    public partial class NewGraphics : Form
    {
        public enum graphs
        {
            batCur = 0,
            batVolt = 1,
            batCons = 2,
            batTemp = 3,
            VDVQ = 4,
            dcBusVolt = 5,
            dcBusCur = 6,
            setIdActId = 7,
            iqActIq = 8,
            iarms = 9,
            torque = 10,
        }

        public NewGraphics()
        {
            InitializeComponent();
        }
        public Action changeGraph = null;
        public Action collectGraphBuf = null;
        public static List<NewGraphics> graphicsList = new List<NewGraphics>();
        public static NewGraphics oldGraph = null;
        public graphs graphType = 0;
        ObservableValue value = new ObservableValue(5);
        public List<ObservableValue> datapoints = new List<ObservableValue>();
        public List<ObservableValue> datapointsSecondary = new List<ObservableValue>();

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

        public NewGraphics(graphs a)
        {
            InitializeComponent();
            #region doubleBuffer
            SetDoubleBuffered(cartesianChart1);
            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(tableLayoutPanel2);
            SetDoubleBuffered(popupBtn);
            SetDoubleBuffered(clsBtn);
            #endregion
            this.ControlBox = false;
            graphType = a;
            switch (graphType)
            {
                case graphs.batCur:
                    cartesianChart1.Series.Add(new LineSeries {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "Battery Current",
                    });
                    changeGraph = this.changeBatCur;
                    break;
                case graphs.batVolt:
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "Battery Voltage",
                    });
                    changeGraph = this.changeBatVolt;
                    break;
                case graphs.batCons:
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "Battery Consumption",
                    });
                    changeGraph = this.changeBatCons;
                    break;
                case graphs.batTemp:
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "Battery Temperature",
                    });
                    changeGraph = this.changeBatTemp;
                    break;
                case graphs.VDVQ:
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "VD",
                    });
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "VQ",
                    });
                    changeGraph = this.changeVDVQ;
                    collectGraphBuf = this.collectVDVQBuf;
                    break;
                case graphs.dcBusCur:
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "DC Bus Current",
                    });
                    changeGraph = this.changeDcBusCur;
                    collectGraphBuf = this.collectIDCBuf;
                    break;
                case graphs.dcBusVolt:
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "DC Bus Voltage",
                    });
                    changeGraph = this.changeDcBusVolt;
                    collectGraphBuf = this.collectVDCBuf;
                    break;
                case graphs.iqActIq:
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "Set IQ",
                    });
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "Actual IQ",
                    });
                    changeGraph = this.changeSetIQActIQ;
                    collectGraphBuf = this.collectSetIQActIQBuf;
                    break;
                case graphs.setIdActId:
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "Set ID",
                    });
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "Actual ID",
                    });
                    changeGraph = this.changeSetIDActID;
                    collectGraphBuf = this.collectSetIDActIDBuf;
                    break;
                case graphs.torque:
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Values = new ChartValues<ObservableValue> { value },
                        Title = "Torque",
                    });
                    changeGraph = this.changeTorque;
                    collectGraphBuf = this.collectTorqueBuf;
                    break;
            }
        }
        private void changeBatCur()
        {
            datapoints.Add(new ObservableValue(DataBMS.cur_s16));
            
            
            if (cartesianChart1.Series[0].Values.Count > 100)
                cartesianChart1.Series[0].Values.RemoveAt(0);
        }
        private void changeBatVolt()
        {
            cartesianChart1.Series[0].Values.Add(new ObservableValue(DataBMS.volt_u16));
            if (cartesianChart1.Series[0].Values.Count > 100)
                cartesianChart1.Series[0].Values.RemoveAt(0);
        }
        private void changeBatCons()
        {
            cartesianChart1.Series[0].Values.Add(new ObservableValue(DataBMS.cons_u16));
            if (cartesianChart1.Series[0].Values.Count > 100)
                cartesianChart1.Series[0].Values.RemoveAt(0);
        }
        private void changeBatTemp()
        {
            cartesianChart1.Series[0].Values.Add(new ObservableValue(DataBMS.temperature_u8));
            if (cartesianChart1.Series[0].Values.Count > 100)
                cartesianChart1.Series[0].Values.RemoveAt(0);
        }
        private void changeVDVQ()
        {
            if (datapoints.Count > 0)
            {
                cartesianChart1.Series[0].Values.AddRange(datapoints);
                cartesianChart1.Series[1].Values.AddRange(datapoints);

                if (cartesianChart1.Series[0].Values.Count > 100)
                    for (int i = 0; i < cartesianChart1.Series[0].Values.Count - 100; i++)
                    {
                        cartesianChart1.Series[0].Values.RemoveAt(0);
                        cartesianChart1.Series[1].Values.RemoveAt(0);
                    }
                datapoints.Clear();
                datapointsSecondary.Clear();
            }
        }
        private void changeDcBusCur()
        {
            if (datapoints.Count > 0)
            {
                cartesianChart1.Series[0].Values.AddRange(datapoints);
                if (cartesianChart1.Series[0].Values.Count > 100)
                    for (int i = 0; i < cartesianChart1.Series[0].Values.Count - 100; i++)
                    {
                        cartesianChart1.Series[0].Values.RemoveAt(0);
                    }
                datapoints.Clear();
            }
        }
        private void changeDcBusVolt()
        {
            if(datapoints.Count > 0)
            {
                cartesianChart1.Series[0].Values.AddRange(datapoints);
                if (cartesianChart1.Series[0].Values.Count > 100)
                    for (int i = 0; i < cartesianChart1.Series[0].Values.Count - 100; i++)
                    {
                        cartesianChart1.Series[0].Values.RemoveAt(0);
                    }
                datapoints.Clear();
            }
            
        }
        private void changeSetIQActIQ()
        {
            if (datapoints.Count > 0)
            {
                cartesianChart1.Series[0].Values.AddRange(datapoints);
                cartesianChart1.Series[1].Values.AddRange(datapoints);

                if (cartesianChart1.Series[0].Values.Count > 100)
                    for (int i = 0; i < cartesianChart1.Series[0].Values.Count - 100; i++)
                    {
                        cartesianChart1.Series[0].Values.RemoveAt(0);
                        cartesianChart1.Series[1].Values.RemoveAt(0);
                    }
                datapoints.Clear();
                datapointsSecondary.Clear();
            }
        }
        private void changeSetIDActID()
        {
            if (datapoints.Count > 0)
            {
                cartesianChart1.Series[0].Values.AddRange(datapoints);
                cartesianChart1.Series[1].Values.AddRange(datapoints);

                if (cartesianChart1.Series[0].Values.Count > 100)
                    for (int i = 0; i < cartesianChart1.Series[0].Values.Count - 100; i++)
                    {
                        cartesianChart1.Series[0].Values.RemoveAt(0);
                        cartesianChart1.Series[1].Values.RemoveAt(0);
                    }
                datapoints.Clear();
                datapointsSecondary.Clear();
            }
        }
        private void changeTorque()
        {
            if (datapoints.Count > 0)
            {
                cartesianChart1.Series[0].Values.AddRange(datapoints);
                if (cartesianChart1.Series[0].Values.Count > 100)
                    for (int i = 0; i < cartesianChart1.Series[0].Values.Count - 100; i++)
                    {
                        cartesianChart1.Series[0].Values.RemoveAt(0);
                    }
                datapoints.Clear();
            }
        }

        private void collectVDCBuf()
        {
            datapoints.Add(new ObservableValue(DataMCU.v_dc_s16));
        }
        private void collectIDCBuf()
        {
            datapoints.Add(new ObservableValue(DataMCU.i_dc_s16));
        }
        private void collectSetIDActIDBuf()
        {
            datapoints.Add(new ObservableValue(DataMCU.set_id_current_s16));
            datapointsSecondary.Add(new ObservableValue(DataMCU.act_id_current_s16));
        }
        private void collectSetIQActIQBuf()
        {
            datapoints.Add(new ObservableValue(DataMCU.set_iq_current_s16));
            datapointsSecondary.Add(new ObservableValue(DataMCU.act_iq_current_s16));
        }
        private void collectVDVQBuf()
        {
            datapoints.Add(new ObservableValue(DataMCU.vd_s16));
            datapointsSecondary.Add(new ObservableValue(DataMCU.vq_s16));
        }
        private void collectTorqueBuf()
        {
            datapoints.Add(new ObservableValue(DataMCU.act_torque_s8));
        }

        private void popupBtn_Click(object sender, EventArgs e)
        {
            NewGraphics.graphicsList.Add(new NewGraphics(graphType));
            NewGraphics.graphicsList.Last().popupBtn.Visible = false;
            NewGraphics.graphicsList.Last().Show();
        }

        private void clsBtn_Click_1(object sender, EventArgs e)
        {
            foreach (var item in NewGraphics.graphicsList.Where(i => i.graphType == this.graphType).ToList())
            {
                item.Close();
            }
            NewGraphics.graphicsList.RemoveAll(i => i.graphType == this.graphType);
            NewGraphics.oldGraph = null;
        }
    }
}
