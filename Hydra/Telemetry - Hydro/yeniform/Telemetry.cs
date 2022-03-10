using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using GMap.NET;
using telemetry_hydro.Variables;
using System.Threading;
using Telemetri.Variables;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System.Collections.Generic;

namespace telemetry_hydro
{
    public partial class telemetry : Form
    {
        const bool AUTO = true;
        const bool MANUAL = false;
        bool isFirst = true;
        MQTT mqtt = new MQTT( MACROS.MQTT_username, MACROS.MQTT_password, MACROS.MQTT_topic);
        myDataGrid myDataGrid = new myDataGrid("HYDRA");
        Thread myDisplayThread;
        public static BMS_form bmsForm = new BMS_form();
        public bool raceFlag = false;
        bool lapControlCalibrationMode = false;
        int calibrationClickCount = 0;
        System.Timers.Timer logTimer = new System.Timers.Timer();
        bool lapCountMode = MANUAL;

        public telemetry()
        {
            InitializeComponent();
            myDataGrid.InitDataGrid(dataGridView1);
            myDisplayThread = new Thread(displayMyAllData) { IsBackground = true, Priority = ThreadPriority.Normal };
            mqtt.LogEvent += logDatas;
            DataBMS.CellInit();
            CheckForIllegalCrossThreadCalls = false;
            logTimer.Interval = 50; //50 ms
            logTimer.Elapsed += LogTimer_Elapsed;
            LogSystem.isFirst = true;


            TimeOperations.avgLapBox = avgLapTimeBox;
            TimeOperations.currentLapBox = currentLapBox;
            TimeOperations.fastestLapBox = fastestLapBox;
            TimeOperations.lastLapBox = lastLapBox;
            TimeOperations.timeLeftBox = timeLeftBox;
            TimeOperations.elapsedTimeBox = timeElapsedBox;
            TimeOperations.avgSpeedBox = avgSpeedBox;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            GMAPController.GMAPController_Init(gmap);

            SetDoubleBuffered(setIdBox);
            SetDoubleBuffered(setId2Box);
            SetDoubleBuffered(actIdBox);
            SetDoubleBuffered(actId2Box);
            SetDoubleBuffered(setIqBox);
            SetDoubleBuffered(setIq2Box);
            SetDoubleBuffered(actIqBox);
            SetDoubleBuffered(actIq2Box);

            SetDoubleBuffered(setSpeedBox);
            SetDoubleBuffered(setSpeed2Box);
            SetDoubleBuffered(setTorqueBox);
            SetDoubleBuffered(setTorque2Box);

            SetDoubleBuffered(fastestLapBox);
            SetDoubleBuffered(currentLapBox);
            SetDoubleBuffered(TimeOperations.currentLapBox);
            SetDoubleBuffered(lapCountBox);
            SetDoubleBuffered(avgLapTimeBox);
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
            timeElapsedBox.Text = TimeOperations.logTime.ToString("T");
            ThreadMethods.PBoxBackColorDegis(bmsWakeBox, DataVCU.BMS_Wake_u1 ? Color.LimeGreen : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(mcuWakeBox, DataVCU.MCU_Wake_u1 ? Color.LimeGreen : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(emsWakeBox, DataVCU.EMS_Wake_u1 ? Color.LimeGreen : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(igniWakeBox, DataVCU.ignition_u1 ? Color.LimeGreen : MACROS.AeskDark);

            ThreadMethods.TextDegis(driveModeBox, DataVCU.vcu_drive_mode_u1 ? "SPEED" : "TORQUE");

            ThreadMethods.TextDegis(gps_verim, DataGPS.efficiency_u8.ToString());
            ThreadMethods.TextDegis(uydu_sayisi, DataGPS.sattelite_u8.ToString());
            ThreadMethods.TextDegis(lowPrioBox, DataVCU.tcuLpMessageCounter.ToString());
            ThreadMethods.TextDegis(midPrioBox, DataVCU.tcuMpMessageCounter.ToString());
            ThreadMethods.TextDegis(highPrioBox, DataVCU.tcuHpMessageCounter.ToString());

            #region MCU_ERROR_STATUS
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
            #endregion
            #region BMS_ERROR
            ThreadMethods.PBoxBackColorDegis(bmsHighVoltErrBox, DataBMS.high_voltage_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsLowVoltErrorBox, DataBMS.low_voltage_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsTempErrorBox, DataBMS.temp_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsCommErrorBox, DataBMS.communication_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsOverCurErrorBox, DataBMS.over_current_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsFatalErrorBox, DataBMS.fatal_error_u1 ? Color.Crimson : MACROS.AeskDark);
            #endregion
            #region CAN_GPS_READY
            ThreadMethods.PBoxBackColorDegis(emsCanBox, DataVCU.ems_can_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(bmsCanBox, DataVCU.bms_can_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(mcuCanBox, DataVCU.mcu_can_error_u1 ? Color.Crimson : MACROS.AeskDark);
            ThreadMethods.PBoxBackColorDegis(logBox, (DataVCU.SD_result_u8 == 0 && DataVCU.SD_result_write_u8 == 0) ? Color.LimeGreen : Color.Crimson);
            ThreadMethods.PBoxBackColorDegis(gpsReadyBox, DataGPS.latitude_f32 != 0 ? Color.LimeGreen : Color.Crimson);
            #endregion
            #region BMS_TEXT
            ThreadMethods.TextDegis(bmsBatVoltBox, DataBMS.volt_u16.ToString());
            ThreadMethods.TextDegis(bmsBatCurBox, DataBMS.cur_s16.ToString());
            ThreadMethods.TextDegis(bmsBatConsBox, DataBMS.cons_u16.ToString());
            ThreadMethods.TextDegis(bmsSocBox, "%88");
            ThreadMethods.TextDegis(bmsWcaBox,DataBMS.worst_cell_address_u8.ToString());
            ThreadMethods.TextDegis(bmsWcvBox, DataBMS.worst_cell_volt_u16.ToString("0.000"));
            ThreadMethods.TextDegis(bmsTempBox, DataBMS.temperature_u8.ToString());
            #endregion
            #region EMS_TEXT
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
            ThreadMethods.TextDegis(motorTempLBox, DataVCU.ignition_u1 ? "29 °C" : DataMCU.temperature_u8.ToString() + " °C");
            ThreadMethods.TextDegis(motorTempRBox, DataVCU.ignition_u1 ? "28 °C" : DataMCU.temperature_u8_mcu2.ToString() + " °C");
            #endregion
            #region EMS_ERROR
            ThreadMethods.PBoxBackColorDegis(ems_bat_current_error, !EMS.bat_current_error_u1 ? MACROS.AeskDark : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(ems_bat_volt_error, !EMS.bat_voltage_error_u1 ? MACROS.AeskDark : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(ems_fc_current_error, !EMS.fc_current_error_u1 ? MACROS.AeskDark : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(ems_fc_voltage_error, !EMS.fc_voltage_error_u1 ? MACROS.AeskDark : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(out_current_error, !EMS.out_current_error_u1 ? MACROS.AeskDark : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(ems_out_voltage_error, !EMS.out_voltage_error_u1 ? MACROS.AeskDark : MACROS.errorColor);
            #endregion
            #region MCU_TEXT
            ThreadMethods.TextDegis(actSpeedBox, DataMCU.act_speed_s16.ToString());
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

            ThreadMethods.TextDegis(actSpeed2Box, DataMCU.act_speed_s16_mcu2.ToString());
            ThreadMethods.TextDegis(idc2Box, DataMCU.i_dc_s16_mcu2.ToString());
            ThreadMethods.TextDegis(vdc2Box, DataMCU.v_dc_s16_mcu2.ToString());
            ThreadMethods.TextDegis(vd2Box, DataMCU.vd_s16_mcu2.ToString());
            ThreadMethods.TextDegis(vq2Box, DataMCU.vq_s16_mcu2.ToString());
            ThreadMethods.TextDegis(setId2Box, DataMCU.set_id_current_s16_mcu2.ToString());
            ThreadMethods.TextDegis(setIq2Box, DataMCU.set_iq_current_s16_mcu2.ToString());
            ThreadMethods.TextDegis(actId2Box, DataMCU.act_id_current_s16_mcu2.ToString());
            ThreadMethods.TextDegis(actIq2Box, DataMCU.act_iq_current_s16_mcu2.ToString());
            ThreadMethods.TextDegis(setTorque2Box, DataMCU.set_torque_s16_mcu2.ToString());
            ThreadMethods.TextDegis(actTorque2Box, DataMCU.act_torque_s8_mcu2.ToString());
            #endregion
            ThreadMethods.TextDegis(distTravelledBox, (DataGPS.odometer / 1000).ToString("0.000") + "km");
            ThreadMethods.LabelDegis(gpsSpeedBox, DataGPS.speed_u8.ToString());
            ThreadMethods.TextDegis(setSpeedBox, DataVCU.speed_set_rpm_s16.ToString());
            ThreadMethods.TextDegis(setSpeed2Box, DataVCU.speed_set_rpm_s16.ToString());
            ThreadMethods.LabelDegis(steeringAngleBox, DataVCU.steering_angle_s8.ToString());
            ThreadMethods.TextDegis(mqtt_solved_paket, mqtt.mqtt_total_counter.ToString());
            ThreadMethods.TextDegis(mqtt_toplam_paket, mqtt.MQTT_counter_int32.ToString());
            ThreadMethods.TextDegis(mqtt_verim, ((int)(mqtt.MQTT_Efficiency * MACROS.FLOAT_CONVERTER_2)).ToString());
            //ThreadMethods.LabelDegis(gsm_yenileme, ((int)(mqtt.mqtt_refresh_time)).ToString());

            TimeOperations.maxSpeed = TimeOperations.maxSpeed < DataVCU.speed_set_rpm_s16 ? DataVCU.speed_set_rpm_s16 : TimeOperations.maxSpeed;

            //AddMarker(new PointLatLng())
            if(lapCountMode == MANUAL)
            {
                GMAPController.GMapAddPointAndOdometer(DataGPS.latitude_f32, DataGPS.longtitude_f32);
            }
            else
            {
                GMAPController.GMapAddPointAndOdometer(DataGPS.latitude_f32, DataGPS.longtitude_f32);
            }
            MACROS.newDataCome = false;
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
            if(isFirst)
            {
                mqtt.MQTTInit(MACROS.client);
                isFirst = false;
            }

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
            lapCountMode = MANUAL;
            manuelToolStripMenuItem.Checked = true;
            otoToolStripMenuItem.Checked = false;
            turAtToolStripMenuItem1.Enabled = true;
        }

        private void otoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lapCountMode = AUTO;
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

        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lapControlCalibrationMode == true)
                {
                    calibrationClickCount++;
                    switch (calibrationClickCount)
                    {
                        case 1:
                            DataGPS.lapPoint1 = gmap.FromLocalToLatLng(e.X, e.Y);
                            DataGPS.AddMarker(DataGPS.lapPoint1, GMarkerGoogleType.green_small, gmap);
                            break;
                        case 2:
                            DataGPS.lapPoint2 = gmap.FromLocalToLatLng(e.X, e.Y);
                            DataGPS.AddMarker(DataGPS.lapPoint2, GMarkerGoogleType.green_small, gmap);
                            break;
                        case 3:
                            DataGPS.lapPoint3 = gmap.FromLocalToLatLng(e.X, e.Y);
                            DataGPS.AddMarker(DataGPS.lapPoint3, GMarkerGoogleType.green_small, gmap);
                            calibrationClickCount = 0;
                            lapControlCalibrationMode = false;
                            long distance1 = DataGPS.CalculateDistance(DataGPS.lapPoint1, DataGPS.lapPoint2);
                            long distance2 = DataGPS.CalculateDistance(DataGPS.lapPoint2, DataGPS.lapPoint3);
                            if (Math.Abs(distance1 - distance2) < 20)
                            {
                                long avgDistance = (distance1 + distance2) / 2;
                                DataGPS.pointDistance = avgDistance;
                                MessageBox.Show($"Kalibrasyon başarılı! Noktalar arası ortalama mesafe {avgDistance} metre.");
                            }
                            else
                            {
                                MessageBox.Show("Kalibrasyon hatalı! Noktaları düz bir çizgi üzerinde seçiniz.");
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {

                    PointLatLng mouse_position = gmap.FromLocalToLatLng(e.X, e.Y);
                    DataGPS.AddMarker(mouse_position, GMarkerGoogleType.red_small, gmap);
                    DataGPS.LapControl(DataGPS.lapPoint1, DataGPS.lapPoint2, DataGPS.lapPoint3, mouse_position);
                    lapCountBox.Text = DataGPS.lapCounter.ToString() + " / 8";
                    //deneme amaçlıydı
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                DialogResult dialogResult = MessageBox.Show("Kalibrasyon modunu açmak istediğinizden emin misiniz?", "Kalibrasyon modu", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    gmap.Overlays.Clear();
                    lapControlCalibrationMode = true;
                    MessageBox.Show("Tur algoritması kalibrasyon modu açıldı." +
                        " Lütfen 3 nokta belirleyiniz." +
                        " Belirlediğiniz noktalar arasındaki mesafenin eşit olmasına dikkat ediniz." +
                        " Göz kararı eşit olması yeterli olacaktır.", "Kalibrasyon Modu");
                }
            }
        }

        private void bMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(bmsForm.IsDisposed == true)
            {
                bmsForm = new BMS_form();
                bmsForm.Show();
            }
            else
            {
                bmsForm.Show();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmsForm.Hide();
        }

        private void turAtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                DataGPS.lapCounter + 1,
                TimeOperations.currentLapTime.Elapsed.ToString("mm\\:ss\\.ff"),
                TimeOperations.avgSpeedBuffer.Average().ToString("00.0") +" km/h",
                TimeOperations.maxSpeed.ToString() + " km/h",
                EMS.out_cons_f32.ToString() + " Wh",
                ((MACROS.KORFEZ_UZUNLUK_METRE / TimeOperations.currentLapTime.Elapsed.TotalSeconds) * 3.6).ToString("00.0") + " km/h"
                );
            TimeOperations.LapFinish();
            lapCountBox.Text = DataGPS.lapCounter.ToString() + " / 30";
//            myDataGrid.addGrid(new object[] { TimeOperations.elapsedTime.Elapsed.Minutes, TimeOperations.currentLapTime.Elapsed });

        }

        private void başlatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LogSystem.StartLog(logTimer);
        }

        private void LogTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            LogSystem.WriteStringLog();
        }

        private void bitirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LogSystem.StopLog(logTimer);
        }

        private void kayıtAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LogSystem.ReadStringLog() == true)
            {
                //LogSystem.ParseStringLog();
                if(!myDisplayThread.IsAlive)
                {
                    myDisplayThread.Start();
                }
                LogBar logBar = new LogBar();
                logBar.TopMost = true;
                logBar.Show();
            }
        }

        private void virgülToolStripMenuItem_Click(object sender, EventArgs e)
        {
            virgülToolStripMenuItem.Checked = true;
            noktaToolStripMenuItem.Checked = false;
            LogSystem.seperator = ',';
        }

        private void noktaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            virgülToolStripMenuItem.Checked = false;
            noktaToolStripMenuItem.Checked = true;
            LogSystem.seperator = '.';
        }
    }
}
//to do iteratif açma