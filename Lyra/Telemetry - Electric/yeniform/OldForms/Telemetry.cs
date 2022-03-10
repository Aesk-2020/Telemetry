using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using GMap.NET;
using Telemetri.Variables;
using System.Threading;

namespace Telemetri
{
    public partial class telemetry : Form
    {
        GMAPController myGmap = new GMAPController(MACROS.centerLat, MACROS.centerLong, MACROS.startLineLat, MACROS.startLineLong);
        SerialPortCOMRF serialportRF = new SerialPortCOMRF(MACROS.RFBufferLength, MACROS.RFBufferHeader);
        MQTT mqtt = new MQTT(MACROS.MQTT_username, MACROS.MQTT_password, MACROS.MQTT_topic);
        Timers timer;
        Logs mylogs;
        myDataGrid myDataGrid = new myDataGrid("Lyra");
        Thread myTimeTickThread;
        Thread myDisplayThread;
        public bool raceFlag = false;

        public telemetry()
        {
            InitializeComponent();
            mqtt.MQTTInit(MACROS.client);
            myDataGrid.InitDataGrid(dataGridView1);
            InitBars();
            myDisplayThread = new Thread(displayMyAllData) { IsBackground = true, Priority = ThreadPriority.Normal };
            history_displayer.ValueChanged -= history_displayer_ValueChanged;
            mqtt.LogEvent += logdata;
            serialportRF.LogRFEvent += logdata;
        }

        private void InitBars()
        {
            kalanyol_bar.Maximum = (int)MACROS.toplam_yol;
            kalanyol_gps.Maximum = (int)MACROS.toplam_yol;
            atilan_Tur.Maximum = (int)MACROS.total_Tur;
            set_hiz_bar.Maximum = MACROS.maks_set_hiz;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myGmap.GMAPController_Init(gmap);
            serialportRF.SerialPortInit(serialPort1);
            gmap.MouseClick -= new MouseEventHandler(gMapControl1_MouseClick);
        }

        private void logdata()
        {
            if (MACROS.race_start_flag)
            {
                mylogs.Writer();
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
            ThreadMethods.ChangePBoxBackColor(bms_durum, VCU.bms_wake_up_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.ChangePBoxBackColor(driver_durum, VCU.driver_wake_up_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.ChangePBoxBackColor(system_durum, VCU.system_wake_up_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.ChangePBoxBackColor(nextion_durum, VCU.nextion_control_u1 ? MACROS.AeskBlue : Color.Transparent);

            ThreadMethods.ChangeText(driver_fwrv_status, Driver.direction_u1 ? "REVERSE" : "FORWARD");
            ThreadMethods.ChangeText(driver_brake_status, Driver.brake_u1 ? "BRAKE ON" : "BRAKE OFF");
            ThreadMethods.ChangeText(driver_ign_status, Driver.ignition_u1 ? "IGN ON" : "IGN OFF");
            ThreadMethods.ChangeText(driver_ign_status, Driver.ignition_u1 ? "IGN ON" : "IGN OFF");
            ThreadMethods.ChangeText(gps_verim, GpsTracker.gps_efficiency_u8.ToString());
            ThreadMethods.ChangeText(uydu_sayisi, GpsTracker.gps_sattelite_number_u8.ToString());

            ThreadMethods.ChangeLabelBackColor(zpc, !Driver.zpc_ok_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.ChangeLabelBackColor(pwm_enabled, !Driver.pwm_enabled_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.ChangeLabelBackColor(dc_bus_voltage_error, !Driver.dc_bus_voltager_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.ChangeLabelBackColor(dc_bus_amper_error, !Driver.dc_bara_current_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.ChangeLabelBackColor(motor_temp_error, !Driver.temp_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.ChangeLabelBackColor(tork_limit, !Driver.ID_error_u1 ? Color.Transparent : MACROS.errorColor);

            ThreadMethods.ChangePBoxBackColor(bms_precharge_flag, BMS.precharge_flag_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.ChangePBoxBackColor(bms_discharge_flag, BMS.discharge_flag_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.ChangePBoxBackColor(bms_dc_bus_ready_flag, BMS.dc_bus_ready_flag_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.ChangePBoxBackColor(bms_high_volt_error, !BMS.high_voltage_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.ChangePBoxBackColor(bms_low_volt_error, !BMS.low_voltage_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.ChangePBoxBackColor(bms_temp_error, !BMS.bms_temp_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.ChangePBoxBackColor(bms_comm_error, !BMS.comm_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.ChangePBoxBackColor(bms_over_cur_error, !BMS.over_current_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.ChangePBoxBackColor(bms_fatal_error, !BMS.bms_fatal_error_u1 ? Color.Transparent : MACROS.errorColor);

            ThreadMethods.ChangePBoxBackColor(vcu_can_control, !VCU.vcu_can_control_u1 ? MACROS.AeskBlue : MACROS.errorColor);
            ThreadMethods.ChangePBoxBackColor(bms_can_control, !VCU.bms_can_control_u1 ? MACROS.AeskBlue : MACROS.errorColor);
            ThreadMethods.ChangePBoxBackColor(driver_can_control, !VCU.driver_can_control_u1 ? MACROS.AeskBlue : MACROS.errorColor);
            ThreadMethods.ChangeText(energy, Math.Round(((BMS.soc_f32 / 100.0) * MACROS.total_battery_capacity), 2).ToString());
            #region bms_text_write
            ThreadMethods.ChangeText(bms_bat_volt, BMS.bat_volt_f32.ToString());
            ThreadMethods.ChangeText(bms_bat_current, BMS.bat_current_f32.ToString());
            ThreadMethods.ChangeText(bms_bat_cons, BMS.bat_cons_f32.ToString());
            ThreadMethods.ChangeText(bms_soc, BMS.soc_f32.ToString());
            ThreadMethods.ChangeText(bms_worst_cell_address, BMS.worst_cell_address_u8.ToString());
            ThreadMethods.ChangeText(bms_worst_cell_volt, BMS.worst_cell_voltage_f32.ToString());
            ThreadMethods.ChangeText(bms_temp, BMS.temp_u8.ToString());
            ThreadMethods.ChangeText(power_text, ((int)(BMS.bat_volt_f32 * BMS.bat_current_f32)).ToString());
            #endregion
            #region driver_text_write
            ThreadMethods.ChangeText(gidilen_yol_driver, Driver.odometer_u32.ToString());
            ThreadMethods.ChangeLabel(anlik_hiz, Driver.actual_velocity_u8.ToString());
            ThreadMethods.ChangeLabel(anlik_hiz_gps, GpsTracker.gps_velocity_u8.ToString());
            ThreadMethods.ChangeText(set_hizz, VCU.set_velocity_u8.ToString());

            ThreadMethods.ChangeText(maks_hiz, Driver.actual_velocity_u8 > Convert.ToByte(maks_hiz.Text) ? Driver.actual_velocity_u8.ToString() : maks_hiz.Text);
            ThreadMethods.ChangeText(phase_a_cur, Driver.phase_a_current_f32.ToString());
            ThreadMethods.ChangeText(phase_b_cur, Driver.phase_b_current_f32.ToString());
            ThreadMethods.ChangeText(dc_bus_cur, Driver.dc_bus_current_f32.ToString());
            ThreadMethods.ChangeText(dc_bus_volt, Driver.dc_bus_voltage_f32.ToString());
            ThreadMethods.ChangeText(motor_temp, Driver.motor_temperature_u8.ToString());
            ThreadMethods.ChangeText(id, Driver.id_f32.ToString());
            ThreadMethods.ChangeText(iq, Driver.iq_f32.ToString());
            ThreadMethods.ChangeText(phase_a_rms, Driver.IArms_f32.ToString());
            ThreadMethods.ChangeText(torque, Driver.Torque_f32.ToString());
            #endregion

            if (!MACROS.mouse_mod)
            {
                GpsTracker.angle_f64 = myGmap.addGMapCalcAngleCalcOdometer(GpsTracker.gps_latitude_f64, GpsTracker.gps_longtitude_f64);
                if (!MACROS.IsSd)
                {
                    AngleControl(GpsTracker.angle_f64);
                }
            }

            ThreadMethods.ChangeCBarValue(angle_gauge, (int)GpsTracker.angle_f64);
            ThreadMethods.ChangeText(gidilen_yol_gps, myGmap.odometer_gps.ToString());
            ThreadMethods.ChangeText(kalan_yol_driver, Timers.kalan_yol.ToString());
            ThreadMethods.ChangeText(turrr, Timers.currentTour.ToString());
            ThreadMethods.ChangeText(mqtt_solved_paket, mqtt.mqtt_total_counter.ToString());
            ThreadMethods.ChangeText(mqtt_toplam_paket, mqtt.MQTT_counter_int32.ToString());
            ThreadMethods.ChangeText(mqtt_verim, ((int)(mqtt.MQTT_Efficiency * MACROS.FLOAT_CONVERTER_2)).ToString());
            ThreadMethods.ChangeLabel(gsm_yenileme, ((int)(mqtt.mqtt_refresh_time)).ToString());
            ThreadMethods.ChangeText(gelen_bayt, serialportRF.GL_gelen_bayt_u32.ToString());
            ThreadMethods.ChangeText(cozulen_paket, serialportRF.GL_cozulen_paket_u32.ToString());
            ThreadMethods.ChangeText(crc_hatali, serialportRF.GL_crc_hatali_u32.ToString());
            ThreadMethods.ChangeText(baslik_hatali, serialportRF.GL_baslik_hatali_u32.ToString());
            ThreadMethods.ChangeText(verim, ((float)(serialportRF.GL_rf_efficiency_f32 * 100)).ToString());
            displayGauges();
            MACROS.newDataCome = false;
        }


        private void calculateRaceTimeOperations()
        {
            while (raceFlag == true)
            {
                ThreadMethods.ChangeText(gecen_sure, Timers.Gecen_süre.ToString(MACROS.TimeStringFormat));
                ThreadMethods.ChangeText(kalan_sure, Timers.Kalan_süre.ToString(MACROS.TimeStringFormat));
                ThreadMethods.ChangeText(anlik_tur_suresi, Timers.Anlik_tur_süresi.Elapsed.ToString(MACROS.TimeStringFormat));
                ThreadMethods.ChangeText(ort_hiz, Convert.ToString(Timers.ort_hiz));
                ThreadMethods.ChangeLabel(hedef_hiz, Convert.ToString(Timers.hedef_hiz));
                float score = Timers.currentTour * 5 - (BMS.bat_cons_f32 / (float)Timers.currentTour) - MACROS.ceza_puani + MACROS.odul_puani;

                ThreadMethods.ChangeText(score_txt, Convert.ToString(score));

                Thread.Sleep(1000);
            }
        }
        private void displayGauges()
        {
            ThreadMethods.ChangeGaugeValue(anlikhiz_gauge, Driver.actual_velocity_u8);
            ThreadMethods.ChangeGaugeValue(gpshiz_gauge, (GpsTracker.gps_velocity_u8));
            ThreadMethods.ChangeGaugeValue(hedefhiz_gauge, Timers.hedef_hiz);
            ThreadMethods.ChangePBarValue(kalanyol_gps, (int)myGmap.odometer_gps);
            ThreadMethods.ChangePBarValue(kalanyol_bar, (int)Driver.odometer_u32);
            ThreadMethods.ChangeCBarValue(atilan_Tur, Timers.currentTour);
            ThreadMethods.ChangeCBarValue(set_hiz_bar, VCU.set_velocity_u8);
        }

        private void portToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            portToolStripMenuItem.DropDownItems.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                portToolStripMenuItem.DropDownItems.Add(port);
            }
        }


        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            MACROS.newDataCome = true;
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng mouse_position = gmap.FromLocalToLatLng(e.X, e.Y);
                GpsTracker.angle_f64 = myGmap.addGMapCalcAngleCalcOdometer(mouse_position.Lat, mouse_position.Lng);
                angle_gauge.Value = (int)GpsTracker.angle_f64;
                AngleControl(GpsTracker.angle_f64);
                gidilen_yol_gps.Text = myGmap.odometer_gps.ToString();
            }
        }



        private void bağlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialportRF.DisconnectSerialPort(serialportRF.portname);
                xbee_active.BackColor = Color.Transparent;
            }
            byte code = mqtt.MQTTsubscribe();
            if (code == 0x00)
            {
                //Connected
                gsm_durum.BackColor = MACROS.AeskBlue;
                if (!myDisplayThread.IsAlive)
                {
                    myDisplayThread.Start();
                }

            }
            else
            {
                gsm_durum.BackColor = MACROS.errorColor;
            }
        }

        private void bağlantıyıKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mqtt.disConnectMQTT();
            gsm_durum.BackColor = Color.Transparent;
            MACROS.newDataCome = false;

            //event kapama
        }

        private void bağlanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MACROS.client.IsConnected)
            {
                mqtt.disConnectMQTT();
                gsm_durum.BackColor = Color.Transparent;
            }

            if (!serialPort1.IsOpen)
            {
                serialportRF.ConnectSerialPort(serialportRF.portname);
                xbee_active.BackColor = MACROS.AeskBlue;
            }

            if (!myDisplayThread.IsAlive)
            {
                myDisplayThread.Start();
            }
        }

        private void bağlantıyıKesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialportRF.DisconnectSerialPort(serialportRF.portname);
            }
            MACROS.newDataCome = false;
        }

        private void portToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            serialportRF.portname = e.ClickedItem.Text;
            secilen_port.Text = serialportRF.portname;
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
            myGmap.OverlayDelete();
        }


        private void turAtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurAt();
            myGmap.OverlayDelete();
        }

        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raceFlag = true;
            mylogs = new Logs(false);
            timer = new Timers();

            myTimeTickThread = new Thread(calculateRaceTimeOperations) { IsBackground = true, Priority = ThreadPriority.Highest };
            myTimeTickThread.Start();
            SectorAndTourdata.sector1_sure.Start();
            MACROS.race_start_flag = true;
            SectorAndTourdata.gidilen_yol_gps_sector_T_u32 = myGmap.odometer_gps;
            SectorAndTourdata.gidilen_yol_vcu_sector_T_u32 = Driver.odometer_u32;
            SectorAndTourdata.consumption_sector_T_f32 = BMS.bat_cons_f32;
        }

        private void bitirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raceFlag = false;
            /*if (myTimeTickThread.IsAlive)
            {
                myTimeTickThread.Abort();
            }*/
            MACROS.race_start_flag = false;
        }

        private void AngleControl(double angle)
        {
            if ((angle > MACROS.S1_Start || angle < MACROS.S1_Stop))
            {
                if (MACROS.sector_4to_1)
                {
                    SectorAndTourdata.gidilen_yol_gps_sector_4_u32 = myGmap.odometer_gps - SectorAndTourdata.gidilen_yol_gps_sector_4_u32;
                    SectorAndTourdata.consumption_sector_4_f32 = BMS.bat_cons_f32 - SectorAndTourdata.consumption_sector_4_f32;
                    SectorAndTourdata.gidilen_yol_vcu_sector_4_u32 = Driver.odometer_u32 - SectorAndTourdata.gidilen_yol_vcu_sector_4_u32;

                    if (Logs._IsLog)
                    {
                        myDataGrid.addGrid(mylogs.Hsector4data);
                    }
                    else
                    {
                        myDataGrid.addGrid(SectorAndTourdata.sector4data);
                    }
                    SectorAndTourdata.sector4_sure.Reset();
                    MACROS.sector_4to_1 = false;
                }

                if (MACROS.sector_flag[0] == false && MACROS.race_start_flag)
                {
                    if (!SectorAndTourdata.sector1_sure.IsRunning)
                    {
                        SectorAndTourdata.sector1_sure.Start();
                    }
                    SectorAndTourdata.gidilen_yol_gps_sector_1_u32 = myGmap.odometer_gps;
                    SectorAndTourdata.consumption_sector_1_f32 = BMS.bat_cons_f32;
                    SectorAndTourdata.gidilen_yol_vcu_sector_1_u32 = Driver.odometer_u32;
                    SectorAndTourdata.sector_name = "S1";
                    ThreadMethods.ChangeLabel(sektor, SectorAndTourdata.sector_name);
                    MACROS.sector_flag[0] = true;
                }

                if (MACROS.sector_flag[3] == true && (angle >= MACROS.turAtStart || angle <= MACROS.turAtStop))
                {
                    TurAt();
                    MACROS.sector_flag[3] = false;
                    myGmap.OverlayDelete();
                }
            }

            if (angle > MACROS.S2_Start && angle < MACROS.S2_Stop && (MACROS.sector_flag[0]))
            {
                if (MACROS.sector_flag[1] == false)
                {
                    SectorAndTourdata.sector2_sure.Start();
                    SectorAndTourdata.gidilen_yol_gps_sector_1_u32 = myGmap.odometer_gps - SectorAndTourdata.gidilen_yol_gps_sector_1_u32;
                    SectorAndTourdata.consumption_sector_1_f32 = BMS.bat_cons_f32 - SectorAndTourdata.consumption_sector_1_f32;
                    SectorAndTourdata.gidilen_yol_vcu_sector_1_u32 = Driver.odometer_u32 - SectorAndTourdata.gidilen_yol_vcu_sector_1_u32;

                    SectorAndTourdata.gidilen_yol_gps_sector_2_u32 = myGmap.odometer_gps;
                    SectorAndTourdata.consumption_sector_2_f32 = BMS.bat_cons_f32;
                    SectorAndTourdata.gidilen_yol_vcu_sector_2_u32 = Driver.odometer_u32;

                    SectorAndTourdata.sector_name = "S1";

                    if (Logs._IsLog)
                    {
                        myDataGrid.addGrid(mylogs.Hsector1data);
                    }
                    else
                    {
                        myDataGrid.addGrid(SectorAndTourdata.sector1data);
                    }

                    SectorAndTourdata.sector1_sure.Reset();
                    SectorAndTourdata.sector_name = "S2";
                    ThreadMethods.ChangeLabel(sektor, SectorAndTourdata.sector_name);
                    MACROS.sector_flag[0] = false;
                    MACROS.sector_flag[1] = true;
                }
            }

            if (angle > MACROS.S3_Start && angle < MACROS.S3_Stop && MACROS.sector_flag[1])
            {
                if (MACROS.sector_flag[2] == false)
                {
                    SectorAndTourdata.sector3_sure.Start();
                    SectorAndTourdata.gidilen_yol_gps_sector_2_u32 = myGmap.odometer_gps - SectorAndTourdata.gidilen_yol_gps_sector_2_u32;
                    SectorAndTourdata.consumption_sector_2_f32 = BMS.bat_cons_f32 - SectorAndTourdata.consumption_sector_2_f32;
                    SectorAndTourdata.gidilen_yol_vcu_sector_2_u32 = Driver.odometer_u32 - SectorAndTourdata.gidilen_yol_vcu_sector_2_u32;

                    SectorAndTourdata.gidilen_yol_gps_sector_3_u32 = myGmap.odometer_gps;
                    SectorAndTourdata.consumption_sector_3_f32 = BMS.bat_cons_f32;
                    SectorAndTourdata.gidilen_yol_vcu_sector_3_u32 = Driver.odometer_u32;

                    if (Logs._IsLog)
                    {
                        myDataGrid.addGrid(mylogs.Hsector2data);
                    }
                    else
                    {
                        myDataGrid.addGrid(SectorAndTourdata.sector2data);
                    }
                    SectorAndTourdata.sector2_sure.Reset();
                    SectorAndTourdata.sector_name = "S3";
                    ThreadMethods.ChangeLabel(sektor, SectorAndTourdata.sector_name);
                    MACROS.sector_flag[2] = true;
                    MACROS.sector_flag[1] = false;
                }
            }

            if (angle > MACROS.S4_Start && angle < MACROS.S4_Stop && MACROS.sector_flag[2])
            {
                if (MACROS.sector_flag[3] == false)
                {
                    SectorAndTourdata.sector4_sure.Start();
                    SectorAndTourdata.gidilen_yol_gps_sector_3_u32 = myGmap.odometer_gps - SectorAndTourdata.gidilen_yol_gps_sector_3_u32;
                    SectorAndTourdata.consumption_sector_3_f32 = BMS.bat_cons_f32 - SectorAndTourdata.consumption_sector_3_f32;
                    SectorAndTourdata.gidilen_yol_vcu_sector_3_u32 = Driver.odometer_u32 - SectorAndTourdata.gidilen_yol_vcu_sector_3_u32;

                    SectorAndTourdata.gidilen_yol_gps_sector_4_u32 = myGmap.odometer_gps;
                    SectorAndTourdata.consumption_sector_4_f32 = BMS.bat_cons_f32;
                    SectorAndTourdata.gidilen_yol_vcu_sector_4_u32 = Driver.odometer_u32;
                    if (Logs._IsLog)
                    {
                        myDataGrid.addGrid(mylogs.Hsector3data);
                    }
                    else
                    {
                        myDataGrid.addGrid(SectorAndTourdata.sector3data);
                    }
                    SectorAndTourdata.sector3_sure.Reset();
                    SectorAndTourdata.sector_name = "S4";
                    ThreadMethods.ChangeLabel(sektor, SectorAndTourdata.sector_name);
                    MACROS.sector_flag[3] = true;
                    MACROS.sector_flag[2] = false;
                    MACROS.sector_4to_1 = true;
                }
            }
        }

        private void telemetry_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void kayıtAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mylogs = new Logs(true);
            mylogs.Reader();
            history_displayer.Maximum = mylogs.dataCounter;
            MACROS.race_start_flag = true;
            history_displayer.ValueChanged += history_displayer_ValueChanged;
            history_displayer.Value = 0;

        }

        private void history_displayer_ValueChanged(object sender, EventArgs e)
        {

            if (mylogs.history_counter > history_displayer.Value)
            {
                if (!MACROS.hold_my_history && !MACROS.show_old_data)
                {
                    mylogs.hold_history_shower = mylogs.history_counter;
                    MACROS.show_old_data = true;
                    MACROS.hold_my_history = true;
                    myGmap.OverlayDelete();
                }
            }

            else
            {
                MACROS.show_old_data = false;
                if (MACROS.hold_my_history)
                {
                    MACROS.hold_my_history = false;
                    history_displayer.Value = mylogs.hold_history_shower;
                    myGmap.OverlayDelete();
                }
            }

            string[] old_datas = mylogs.read_string[mylogs.read_string.Keys.ElementAt(history_displayer.Value)].Split('\t');
            if (MACROS.IsSd == false)
            {
                mylogs.ReadArayüz(old_datas);
                displayAllData();
                ThreadMethods.ChangeText(gecen_sure, Timers.Gecen_süre.ToString(MACROS.TimeStringFormat));
                ThreadMethods.ChangeText(kalan_sure, Timers.Kalan_süre.ToString(MACROS.TimeStringFormat));
                ThreadMethods.ChangeText(anlik_tur_suresi, mylogs.anlik_tur_sure);
                ThreadMethods.ChangeText(en_hizli_tur_timer, mylogs.en_hizli_tur_sure);
                ThreadMethods.ChangeText(ort_hiz, ((byte)(Driver.odometer_u32 / Timers.Gecen_süre.TotalSeconds) * MACROS.mstokmh).ToString());
                ThreadMethods.ChangeLabel(hedef_hiz, Convert.ToString(Timers.hedef_hiz));
            }
            else
            {
                gecen_sure.Text = Timers.Gecen_süre.ToString();
                mylogs.readSdCard(old_datas);
                displayAllData();
            }
            mylogs.history_counter = history_displayer.Value;
        }

        private void TurAt()
        {
            SectorAndTourdata.gidilen_yol_gps_sector_T_u32 = myGmap.odometer_gps - SectorAndTourdata.gidilen_yol_gps_sector_T_u32;
            SectorAndTourdata.gidilen_yol_vcu_sector_T_u32 = Driver.odometer_u32 - SectorAndTourdata.gidilen_yol_vcu_sector_T_u32;
            SectorAndTourdata.consumption_sector_T_f32 = BMS.bat_cons_f32 - SectorAndTourdata.consumption_sector_T_f32;

            if (Logs._IsLog)
            {
                myDataGrid.addGrid(mylogs.HturAtdata);
                ThreadMethods.ChangeText(ortalama_tur_suresi, mylogs.ortalama_tur_sure);
                Timers.currentTour++;
            }

            else
            {
                ThreadMethods.ChangeText(önceki_tur_timer, Timers.Anlik_tur_süresi.Elapsed.ToString(MACROS.TimeStringFormat));
                ThreadMethods.ChangeText(ortalama_tur_suresi, Timers.Ortalama_tur_süresi.ToString(MACROS.TimeStringFormat));
                if (Timers.IsFastestLaps)
                {
                    ThreadMethods.ChangeText(en_hizli_tur_timer, Timers.Anlik_tur_süresi.Elapsed.ToString(MACROS.TimeStringFormat));
                    Timers.en_hizli_tur_suresi = new TimeSpan(Timers.Anlik_tur_süresi.Elapsed.Hours, Timers.Anlik_tur_süresi.Elapsed.Minutes, Timers.Anlik_tur_süresi.Elapsed.Seconds);
                }
                SectorAndTourdata.sector_name = "ST";
                myDataGrid.addGrid(SectorAndTourdata.turAtdata);
                timer.TurAt();
            }


            SectorAndTourdata.gidilen_yol_gps_sector_T_u32 = myGmap.odometer_gps;
            SectorAndTourdata.gidilen_yol_vcu_sector_T_u32 = Driver.odometer_u32;
            SectorAndTourdata.consumption_sector_T_f32 = BMS.bat_cons_f32;
            int tour_est = (int)((MACROS.total_battery_capacity - BMS.bat_cons_f32) / (BMS.bat_cons_f32 / (float)Timers.currentTour));
            ThreadMethods.ChangeText(lap_est_txt, Convert.ToString(tour_est));
            myGmap.OverlayDelete();
        }

        private void gsmResetleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialportRF.ConnectSerialPort(serialportRF.portname);
            }
            serialportRF.write(MACROS.gsm_reset_buffer);
        }

        private void sDKayıtAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mylogs = new Logs(true);
            mylogs.Reader();
            history_displayer.Maximum = mylogs.dataCounter;
            MACROS.race_start_flag = true;
            MACROS.IsSd = true;
            history_displayer.ValueChanged += history_displayer_ValueChanged;
            history_displayer.Value = 0;
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed by Aesk Telemetry Team");
        }

        private void bMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMS_form bmsform = new BMS_form();
            bmsform.Show();
        }

        private void grafiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MACROS.race_start_flag == false)
            {
                MessageBox.Show("Grafikler sadece yarış esnasında çizdirilir!!");
            }

            else
            {
                graph_form grafiklerr = new graph_form();
                grafiklerr.Show();
            }
        }
    }
}
