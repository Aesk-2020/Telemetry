using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using GMap.NET;
using telemetry_hydro.Variables;
using System.Threading;
using Telemetri.Variables;

namespace telemetry_hydro
{
    public partial class telemetry : Form
    {

        MQTT mqtt = new MQTT( MACROS.MQTT_username, MACROS.MQTT_password, MACROS.MQTT_topic);
        myDataGrid myDataGrid = new myDataGrid("HYDRA");
        Thread myDisplayThread;
        public bool raceFlag = false;
        
        public telemetry()
        {
            InitializeComponent();
            mqtt.MQTTInit(MACROS.client);
            myDataGrid.InitDataGrid(dataGridView1);
            myDisplayThread = new Thread(displayMyAllData) { IsBackground = true, Priority = ThreadPriority.Normal };
            mqtt.LogEvent += logDatas;
            CheckForIllegalCrossThreadCalls = false;

            TimeOperations.avgLapBox = avgLapTimeBox;
            TimeOperations.currentLapBox = currentLapBox;
            TimeOperations.fastestLapBox = fastestLapBox;
            TimeOperations.lastLapBox = lastLapBox;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GMAPController.GMAPController_Init(gmap);
            gmap.MouseClick -= new MouseEventHandler(gMapControl1_MouseClick);
        }

        private void logDatas()
        {
            if (MACROS.race_start_flag)
            {
                //LogAl
            }
            MACROS.newDataCome = true;
        }

        private void displayMyAllData()
        {
            while (true)
            {
                if (MACROS.newDataCome)
                {
                    displayAllData();
                }
            }
        }

        void displayAllData()
        {
            ThreadMethods.PBoxBackColorDegis(bmsWakeBox, DataVCU.BMS_Wake_u1 ? Color.LimeGreen : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(mcuWakeBox, DataVCU.MCU_Wake_u1 ? Color.LimeGreen : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(emsWakeBox, DataVCU.EMS_Wake_u1 ? Color.LimeGreen : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(igniWakeBox, DataVCU.ignition_u1 ? Color.LimeGreen : MACROS.AeskDark);

            ThreadMethods.TextDegis(driveModeBox, DataVCU.vcu_torque_output_u1 ? "SPEED" : "TORQUE");

            ThreadMethods.TextDegis(gps_verim, DataGPS.gps_efficiency_u8.ToString());
            ThreadMethods.TextDegis(uydu_sayisi, DataGPS.gps_sattelite_number_u8.ToString());

            ThreadMethods.PBoxBackColorDegis(overCurABox, DataMCU.over_cur_IA ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(overCurBBox, DataMCU.over_cur_IB ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(overCurCBox, DataMCU.over_cur_IC ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(overCurIDCBox, DataMCU.over_cur_IDC ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(overVoltVDCBox, DataMCU.over_volt_VDC ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(overTempBox, DataMCU.over_temp ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(underVoltVDCBox, DataMCU.under_volt_VDC ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(underSpeedBox, DataMCU.under_speed ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(overSpeedBox, DataMCU.over_speed ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(zpcBox, DataMCU.input_scaling_calib_finished ? Color.LimeGreen : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(pwmEnabledBox, DataMCU.PWM_enabled ? Color.LimeGreen : MACROS.AeskDark);
            
            ThreadMethods.PBoxBackColorDegis(bmsHighVoltErrBox, DataBMS.high_voltage_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsLowVoltErrorBox, DataBMS.low_voltage_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsTempErrorBox, DataBMS.temp_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsCommErrorBox, DataBMS.communication_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsOverCurErrorBox, DataBMS.over_current_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsFatalErrorBox, DataBMS.fatal_error_u1 ? Color.Crimson : MACROS.AeskDark);

            ThreadMethods.PBoxBackColorDegis(emsCanBox, DataVCU.ems_can_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsCanBox, DataVCU.bms_can_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(mcuCanBox, DataVCU.mcu_can_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(gpsReadyBox, DataGPS.gps_latitude_f64 != 0 ? Color.LimeGreen : Color.Crimson);

            #region bms_text_write
            ThreadMethods.TextDegis(bmsBatVoltBox, DataBMS.volt_u16.ToString());
            ThreadMethods.TextDegis(bmsBatCurBox, DataBMS.cur_s16.ToString());
            ThreadMethods.TextDegis(bmsBatConsBox, DataBMS.cons_u16.ToString());
            ThreadMethods.TextDegis(bmsSocBox, DataBMS.soc_u16.ToString());
            ThreadMethods.TextDegis(bmsWcaBox,DataBMS.worst_cell_address_u8.ToString());
            ThreadMethods.TextDegis(bmsWcvBox, DataBMS.worst_cell_volt_u16.ToString());
            ThreadMethods.TextDegis(bmsTempBox, DataBMS.temperature_u8.ToString());
            #endregion
            #region ems_text_write
            ThreadMethods.TextDegis(emsBatConsBox, EMS.bat_cons_f32.ToString());
            ThreadMethods.TextDegis(emsBatCurBox, EMS.bat_cur_f32.ToString());
            ThreadMethods.TextDegis(emsBatVoltBox, EMS.bat_volt_f32.ToString());
            ThreadMethods.TextDegis(emsSharingBox, EMS.bat_soc_f32.ToString());
            ThreadMethods.TextDegis(emsFcConsBox, EMS.fc_cons_f32.ToString());
            ThreadMethods.TextDegis(emsFcCurBox, EMS.fc_cur_f32.ToString());
            ThreadMethods.TextDegis(emsFcVoltBox, EMS.fc_volt_f32.ToString());
            ThreadMethods.TextDegis(emsOutCurBox, EMS.out_cur_f32.ToString());
            ThreadMethods.TextDegis(emsOutVoltageBox, EMS.out_volt_f32.ToString());
            ThreadMethods.TextDegis(emsFcLtConsBox, EMS.fc_lt_cons_f32.ToString());
            ThreadMethods.TextDegis(emsPenaltyBox, EMS.penalty_s8.ToString());
            ThreadMethods.TextDegis(emsTempBox, EMS.temperature_u8.ToString());
            ThreadMethods.TextDegis(emsOutConsBox, EMS.out_cons_f32.ToString());
            #endregion
            #region ems_error
            ThreadMethods.PBoxBackColorDegis(ems_bat_current_error, !EMS.bat_current_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(ems_bat_volt_error, !EMS.bat_voltage_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(ems_fc_current_error, !EMS.fc_current_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(ems_fc_voltage_error, !EMS.fc_voltage_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(out_current_error, !EMS.out_current_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(ems_out_voltage_error, !EMS.out_voltage_error_u1 ? Color.Transparent : MACROS.errorColor);
            #endregion
            #region driver_text_write
            ThreadMethods.TextDegis(distTravelledBox, (DataGPS.odometer / 1000).ToString("0.000") + "km");
            ThreadMethods.TextDegis(actSpeedBox, DataMCU.act_speed_s16.ToString());
            ThreadMethods.LabelDegis(gpsSpeedBox, DataGPS.gps_velocity_u8.ToString());
            ThreadMethods.TextDegis(setSpeedBox, DataVCU.speed_set_rpm_s16.ToString());
            ThreadMethods.TextDegis(idcBox, DataMCU.i_dc_s16.ToString());
            ThreadMethods.TextDegis(vdcBox, DataMCU.v_dc_s16.ToString());
            ThreadMethods.TextDegis(vdBox, DataMCU.vd_s16.ToString());
            ThreadMethods.TextDegis(vqBox, DataMCU.vq_s16.ToString());
            ThreadMethods.TextDegis(setIdBox, DataMCU.set_id_current_s16.ToString());
            ThreadMethods.TextDegis(setIqBox, DataMCU.set_iq_current_s16.ToString());
            ThreadMethods.TextDegis(actIdBox, DataMCU.act_id_current_s16.ToString());
            ThreadMethods.TextDegis(actIqBox, DataMCU.act_iq_current_s16.ToString());
            ThreadMethods.TextDegis(setTorqueBox, DataMCU.set_torque_s16.ToString());
            ThreadMethods.TextDegis(actTorqueBox, DataMCU.act_torque_s8.ToString());
            #endregion

            if (!MACROS.mouse_mod)
            {
                //GPS VERİLERİNİ İNSAN EVLADI GİBİ AL !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
            
            ThreadMethods.TextDegis(mqtt_solved_paket, mqtt.mqtt_total_counter.ToString());
            ThreadMethods.TextDegis(mqtt_toplam_paket, mqtt.MQTT_counter_int32.ToString());
            ThreadMethods.TextDegis(mqtt_verim, ((int)(mqtt.MQTT_Efficiency * MACROS.FLOAT_CONVERTER_2)).ToString());
            //ThreadMethods.LabelDegis(gsm_yenileme, ((int)(mqtt.mqtt_refresh_time)).ToString());
            MACROS.newDataCome = false;
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            MACROS.newDataCome = true;
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng mouse_position = gmap.FromLocalToLatLng(e.X, e.Y);
                DataGPS.gps_latitude_f64 = mouse_position.Lat;
                DataGPS.gps_longtitude_f64 = mouse_position.Lng;
                //TUR ALGO EKLE
            }

        }

        private void GpsMouseModAktif_Click(object sender, EventArgs e)
        {
            gmap.MouseClick += new MouseEventHandler(gMapControl1_MouseClick);
            MACROS.mouse_mod = true;
        }
        private void GpsMouseModDeaktif_Click(object sender, EventArgs e)
        {
            gmap.MouseClick -= new MouseEventHandler(gMapControl1_MouseClick);
            MACROS.mouse_mod = false;
            MACROS.newDataCome = false;
        }

        private void MarkerTemizlee_Click(object sender, EventArgs e)
        {
            GMAPController.OverlayDelete();
        }
        private void turAtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMAPController.OverlayDelete();
            //TUR ALGO EKLEEEEEEEEEEEEEEEEEEEE
        }
        
        private void telemetry_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MACROS.client.IsConnected)
            {
                mqtt.disConnectMQTT();
            }
        }

        private void bağlanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            byte code = mqtt.ConnectRequestMQTT();
            if (code == 0x00)
            {
                //Connected
                mqttBox.BackColor = Color.LimeGreen;
                if (!myDisplayThread.IsAlive)
                {
                    myDisplayThread.Start();
                }
            }
            else
            {
                mqttBox.BackColor = Color.Crimson;
            }
        }
        private void bağlantıyıKesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mqtt.disConnectMQTT();
            mqttBox.BackColor = MACROS.AeskDark;
            MACROS.newDataCome = false;

            //event kapama
        }

        private void manuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manuelToolStripMenuItem.Checked = true;
            otoToolStripMenuItem.Checked = false;
            turAtToolStripMenuItem1.Enabled = true;
        }

        private void otoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manuelToolStripMenuItem.Checked = false;
            otoToolStripMenuItem.Checked = true;
            turAtToolStripMenuItem1.Enabled = false;
        }

        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeOperations.StartRace();
        }

        private void bitirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeOperations.FinishRace();
        }
    }
}
