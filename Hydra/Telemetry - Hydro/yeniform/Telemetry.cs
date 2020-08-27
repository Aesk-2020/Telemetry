using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using GMap.NET;
using telemetry_hydro.Variables;
using System.Threading;

namespace telemetry_hydro
{
    public partial class telemetry : Form
    {
        GMAPController myGmap = new GMAPController(MACROS.centerLat, MACROS.centerLong, MACROS.startLineLat, MACROS.startLineLong);
        SerialPortCOMRF serialportRF = new SerialPortCOMRF(MACROS.RFBufferLength, MACROS.RFBufferHeader);
        MQTT mqtt = new MQTT( MACROS.MQTT_username, MACROS.MQTT_password, MACROS.MQTT_topic);
        Timers timer;
        Logs mylogs;
        myDataGrid myDataGrid = new myDataGrid("HYDRA");
        Thread myTimeTickThread;
        Thread myDisplayThread;
        
        public telemetry()
        {
            InitializeComponent();
            mqtt.MQTTInit(MACROS.client);
            myDataGrid.InitDataGrid(dataGridView1);
            InitBars();
            myDisplayThread = new Thread(displayMyAllData) { IsBackground = true, Priority = ThreadPriority.Normal };
            myTimeTickThread = new Thread(calculateRaceTimeOperations) { IsBackground = true, Priority = ThreadPriority.Highest };
            history_displayer.ValueChanged -= history_displayer_ValueChanged;
            mqtt.LogEvent += logDatas;
            serialportRF.LogRFEvent += logDatas;
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

        private void logDatas()
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
            ThreadMethods.PBoxBackColorDegis(bms_durum, VCU.bms_wake_up_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.PBoxBackColorDegis(driver_durum, VCU.driver_wake_up_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.PBoxBackColorDegis(ems_durum, VCU.ems_wake_up_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.PBoxBackColorDegis(system_durum, VCU.system_on_off_u1 ? MACROS.AeskBlue : Color.Transparent);

            ThreadMethods.TextDegis(driver_fwrv_status ,Driver.direction_u1 ? "REVERSE" : "FORWARD");
            ThreadMethods.TextDegis(driver_brake_status, Driver.brake_u1 ? "BRAKE ON" : "BRAKE OFF");
            ThreadMethods.TextDegis(driver_ign_status, Driver.ignition_u1 ? "IGN ON" : "IGN OFF");
            ThreadMethods.TextDegis(driver_ign_status, Driver.ignition_u1 ? "IGN ON" : "IGN OFF");
            ThreadMethods.TextDegis(gps_verim, GpsTracker.gps_efficiency_u8.ToString());
            ThreadMethods.TextDegis(uydu_sayisi, GpsTracker.gps_sattelite_number_u8.ToString());

            ThreadMethods.LabelBackColorDegis(zpc, !Driver.zpc_ok_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.LabelBackColorDegis(pwm_enabled, !Driver.pwm_enabled_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.LabelBackColorDegis(dc_bus_voltage_error, !Driver.dc_bus_voltager_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.LabelBackColorDegis(dc_bus_amper_error, !Driver.dc_bara_current_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.LabelBackColorDegis(motor_temp_error, !Driver.temp_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.LabelBackColorDegis(tork_limit, !Driver.ID_error_u1 ? Color.Transparent : MACROS.errorColor);

            ThreadMethods.PBoxBackColorDegis(bms_precharge_flag, BMS.precharge_flag_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.PBoxBackColorDegis(bms_discharge_flag, BMS.discharge_flag_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.PBoxBackColorDegis(bms_dc_bus_ready_flag, BMS.dc_bus_ready_flag_u1 ? MACROS.AeskBlue : Color.Transparent);
            ThreadMethods.PBoxBackColorDegis(bms_high_volt_error, !BMS.high_voltage_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(bms_low_volt_error, !BMS.low_voltage_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(bms_temp_error, !BMS.bms_temp_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(bms_comm_error, !BMS.comm_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(bms_over_cur_error, !BMS.over_current_error_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(bms_fatal_error, !BMS.bms_fatal_error_u1 ? Color.Transparent : MACROS.errorColor);

            ThreadMethods.PBoxBackColorDegis(ems_can_error, !VCU.ems_can_control_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(bms_can_error, !VCU.bms_can_control_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.PBoxBackColorDegis(driver_can_error, !VCU.driver_can_control_u1 ? Color.Transparent : MACROS.errorColor);
            ThreadMethods.TextDegis(energy, Math.Round((BMS.soc_f32 / 100.0) * MACROS.total_battery_capacity, 2).ToString());
            #region bms_text_write
            ThreadMethods.TextDegis(bms_bat_voltage, BMS.bat_volt_f32.ToString());
            ThreadMethods.TextDegis(bms_bat_current, BMS.bat_current_f32.ToString());
            ThreadMethods.TextDegis(bms_bat_cons, BMS.bat_cons_f32.ToString());
            ThreadMethods.TextDegis(bms_soc, BMS.soc_f32.ToString());
            ThreadMethods.TextDegis(bms_worst_cell_address,BMS.worst_cell_address_u8.ToString());
            ThreadMethods.TextDegis(bms_worst_cell_voltage, BMS.worst_cell_voltage_f32.ToString());
            ThreadMethods.TextDegis(bms_temp, BMS.temp_u8.ToString());
            ThreadMethods.TextDegis(power_text, ((int)(EMS.bat_volt_f32 * EMS.bat_cur_f32)).ToString());
            #endregion

            #region ems_text_write
            ThreadMethods.TextDegis(ems_bat_cons, EMS.bat_cons_f32.ToString());
            ThreadMethods.TextDegis(ems_bat_current, EMS.bat_cur_f32.ToString());
            ThreadMethods.TextDegis(ems_bat_volt, EMS.bat_volt_f32.ToString());
            ThreadMethods.TextDegis(ems_soc, EMS.bat_soc_f32.ToString());
            ThreadMethods.TextDegis(ems_fc_cons, EMS.fc_cons_f32.ToString());
            ThreadMethods.TextDegis(ems_fc_current, EMS.fc_cur_f32.ToString());
            ThreadMethods.TextDegis(ems_fc_voltage, EMS.fc_volt_f32.ToString());
            ThreadMethods.TextDegis(ems_out_current, EMS.out_cur_f32.ToString());
            ThreadMethods.TextDegis(ems_out_voltage, EMS.out_volt_f32.ToString());
            ThreadMethods.TextDegis(ems_fc_lt_cons, EMS.fc_lt_cons_f32.ToString());
            ThreadMethods.TextDegis(ems_penalty, EMS.penalty_s8.ToString());
            ThreadMethods.TextDegis(ems_temp, EMS.temperature_u8.ToString());
            ThreadMethods.TextDegis(ems_out_cons, EMS.out_cons_f32.ToString());
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
            ThreadMethods.TextDegis(gidilen_yol_driver, Driver.odometer_u32.ToString());
            ThreadMethods.LabelDegis(anlik_hiz, Driver.actual_velocity_u8.ToString());
            ThreadMethods.LabelDegis(anlik_hiz_gps, GpsTracker.gps_velocity_u8.ToString());
            ThreadMethods.TextDegis(set_hizz, VCU.set_velocity_u8.ToString());
            ThreadMethods.TextDegis(maks_hiz, Driver.actual_velocity_u8 > Convert.ToByte(maks_hiz.Text) ? Driver.actual_velocity_u8.ToString() : maks_hiz.Text);
            ThreadMethods.TextDegis(phase_a_cur, Driver.phase_a_current_f32.ToString());
            ThreadMethods.TextDegis(phase_b_cur, Driver.phase_b_current_f32.ToString());
            ThreadMethods.TextDegis(dc_bus_cur, Driver.dc_bus_current_f32.ToString());
            ThreadMethods.TextDegis(dc_bus_volt, Driver.dc_bus_voltage_f32.ToString());
            ThreadMethods.TextDegis(motor_temp, Driver.motor_temperature_u8.ToString());
            ThreadMethods.TextDegis(id, Driver.id_f32.ToString());
            ThreadMethods.TextDegis(iq, Driver.iq_f32.ToString());
            ThreadMethods.TextDegis(gidilen_yol_driver, Driver.odometer_u32.ToString());
            ThreadMethods.TextDegis(torque, Driver.torque_f32.ToString());
            ThreadMethods.TextDegis(phase_a_rms, Driver.phase_a_rms_f32.ToString());
            #endregion

            if (!MACROS.mouse_mod)
            {
                GpsTracker.angle_f64 = myGmap.addGMapCalcAngleCalcOdometer(GpsTracker.gps_latitude_f64, GpsTracker.gps_longtitude_f64);
                AngleControl(GpsTracker.angle_f64);
            }

            ThreadMethods.CBarValueDegis(angle_gauge, (int)GpsTracker.angle_f64);
            ThreadMethods.TextDegis(gidilen_yol_gps, myGmap.odometer_gps.ToString());
            ThreadMethods.TextDegis(kalan_yol_driver, Timers.kalan_yol.ToString());
            ThreadMethods.TextDegis(turrr, Timers.currentTour.ToString());
            ThreadMethods.TextDegis(mqtt_solved_paket, mqtt.mqtt_total_counter.ToString());
            ThreadMethods.TextDegis(mqtt_toplam_paket, mqtt.MQTT_counter_int32.ToString());
            ThreadMethods.TextDegis(mqtt_verim, ((int)(mqtt.MQTT_Efficiency * MACROS.FLOAT_CONVERTER_2)).ToString());
            ThreadMethods.LabelDegis(gsm_yenileme, ((int)(mqtt.mqtt_refresh_time)).ToString());
            ThreadMethods.TextDegis(gelen_bayt, serialportRF.GL_gelen_bayt_u32.ToString());
            ThreadMethods.TextDegis(cozulen_paket, serialportRF.GL_cozulen_paket_u32.ToString());
            ThreadMethods.TextDegis(crc_hatali, serialportRF.GL_crc_hatali_u32.ToString());
            ThreadMethods.TextDegis(baslik_hatali, serialportRF.GL_baslik_hatali_u32.ToString());
            ThreadMethods.TextDegis(verim, serialportRF.GL_rf_efficiency_f32.ToString());
            displayGauges();
            MACROS.newDataCome = false;
            }
        

        private void calculateRaceTimeOperations()
        {
            while (true)
            {
                ThreadMethods.TextDegis(gecen_sure, Timers.Gecen_süre.ToString(MACROS.TimeStringFormat));
                ThreadMethods.TextDegis(kalan_sure, Timers.Kalan_süre.ToString(MACROS.TimeStringFormat));
                ThreadMethods.TextDegis(anlik_tur_suresi, Timers.Anlik_tur_süresi.Elapsed.ToString(MACROS.TimeStringFormat));
                ThreadMethods.TextDegis(ort_hiz, Convert.ToString(Timers.ort_hiz));
                ThreadMethods.LabelDegis(hedef_hiz, Convert.ToString(Timers.hedef_hiz));
                Thread.Sleep(1000);
            }
        }
        private void displayGauges()
        {
            ThreadMethods.GaugeValueDegis(anlikhiz_gauge, Driver.actual_velocity_u8);
            ThreadMethods.GaugeValueDegis(gpshiz_gauge, (GpsTracker.gps_velocity_u8));
            ThreadMethods.GaugeValueDegis(hedefhiz_gauge, Timers.hedef_hiz);
            ThreadMethods.PBarValueDegis(kalanyol_gps, (int)myGmap.odometer_gps);
            ThreadMethods.PBarValueDegis(kalanyol_bar, (int)Driver.odometer_u32);
            ThreadMethods.CBarValueDegis(atilan_Tur, Timers.currentTour);
            ThreadMethods.CBarValueDegis(set_hiz_bar, VCU.set_velocity_u8);
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
                GpsTracker.gps_latitude_f64 = mouse_position.Lat;
                GpsTracker.gps_longtitude_f64 = mouse_position.Lng;
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
            byte code = mqtt.ConnectRequestMQTT();
            if (code == 0x00)
            {
                //Connected
                gsm_durum.BackColor = MACROS.AeskBlue;
                if(!myDisplayThread.IsAlive)
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
            if(MACROS.client.IsConnected)
            {
                mqtt.disConnectMQTT();
                gsm_durum.BackColor = Color.Transparent;
            }

            if (!serialPort1.IsOpen)
            {
                serialportRF.ConnectSerialPort(serialportRF.portname);
                xbee_active.BackColor = MACROS.AeskBlue;
            }

            if(!myDisplayThread.IsAlive)
            {
               myDisplayThread.Start();
            }
        }

        private void bağlantıyıKesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
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
            mylogs = new Logs(false);
            timer = new Timers();

            myTimeTickThread.Start();
            SectorAndTourDatas.sector1_sure.Start();
            MACROS.race_start_flag = true;
            SectorAndTourDatas.gidilen_yol_gps_sector_T_u32 = myGmap.odometer_gps;
            SectorAndTourDatas.gidilen_yol_vcu_sector_T_u32 = Driver.odometer_u32;
            SectorAndTourDatas.consumption_sector_T_f32 = BMS.bat_cons_f32;
            SectorAndTourDatas.consumption_out_sector_T_f32 = EMS.out_cons_f32;
        }

        private void bitirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(myTimeTickThread.IsAlive)
            {
                myTimeTickThread.Abort();
            }
            MACROS.race_start_flag = false;
        }

        private void AngleControl(double angle)
        {

            if ((angle > MACROS.S1_Start || angle < MACROS.S1_Stop))
            {
                if(MACROS.sector_4to_1)
                {
                    SectorAndTourDatas.gidilen_yol_gps_sector_4_u32 = myGmap.odometer_gps - SectorAndTourDatas.gidilen_yol_gps_sector_4_u32;
                    SectorAndTourDatas.consumption_sector_4_f32 = BMS.bat_cons_f32 - SectorAndTourDatas.consumption_sector_4_f32;
                    SectorAndTourDatas.consumption_out_sector_4_f32 = EMS.out_cons_f32 - SectorAndTourDatas.consumption_out_sector_4_f32;
                    SectorAndTourDatas.gidilen_yol_vcu_sector_4_u32 = Driver.odometer_u32 - SectorAndTourDatas.gidilen_yol_vcu_sector_4_u32;

                    if (Logs._IsLog)
                    {
                        myDataGrid.addGrid(mylogs.Hsector4Datas);
                    }
                    else
                    {
                        myDataGrid.addGrid(SectorAndTourDatas.sector4Datas);
                    }
                    SectorAndTourDatas.sector4_sure.Reset();
                    MACROS.sector_4to_1 = false;
                }

                if (MACROS.sector_flag[0] == false && MACROS.race_start_flag)
                {
                    if(!SectorAndTourDatas.sector1_sure.IsRunning)
                    {
                        SectorAndTourDatas.sector1_sure.Start();
                    }
                    SectorAndTourDatas.gidilen_yol_gps_sector_1_u32 = myGmap.odometer_gps;
                    SectorAndTourDatas.consumption_sector_1_f32 = BMS.bat_cons_f32;
                    SectorAndTourDatas.consumption_out_sector_1_f32 = EMS.out_cons_f32;
                    SectorAndTourDatas.gidilen_yol_vcu_sector_1_u32 = Driver.odometer_u32;
                    SectorAndTourDatas.sector_name = "S1";
                    ThreadMethods.LabelDegis(sektor, SectorAndTourDatas.sector_name);
                    MACROS.sector_flag[0] = true;
                }

                if(MACROS.sector_flag[3] == true && (angle >= MACROS.turAtStart || angle <= MACROS.turAtStop))
                {
                    TurAt();
                    MACROS.sector_flag[3] = false;
                    myGmap.OverlayDelete();
                }
            }

            if (angle > MACROS.S2_Start && angle < MACROS.S2_Stop && (MACROS.sector_flag[0]))
            {
                if(MACROS.sector_flag[1] == false)
                {
                    SectorAndTourDatas.sector2_sure.Start();
                    SectorAndTourDatas.gidilen_yol_gps_sector_1_u32 = myGmap.odometer_gps - SectorAndTourDatas.gidilen_yol_gps_sector_1_u32;
                    SectorAndTourDatas.consumption_sector_1_f32 = BMS.bat_cons_f32 - SectorAndTourDatas.consumption_sector_1_f32;
                    SectorAndTourDatas.consumption_out_sector_1_f32 = EMS.out_cons_f32 - SectorAndTourDatas.consumption_out_sector_1_f32;
                    SectorAndTourDatas.gidilen_yol_vcu_sector_1_u32 = Driver.odometer_u32 - SectorAndTourDatas.gidilen_yol_vcu_sector_1_u32;

                    SectorAndTourDatas.gidilen_yol_gps_sector_2_u32 = myGmap.odometer_gps;
                    SectorAndTourDatas.consumption_sector_2_f32 = BMS.bat_cons_f32;
                    SectorAndTourDatas.consumption_out_sector_2_f32 = EMS.out_cons_f32;
                    SectorAndTourDatas.gidilen_yol_vcu_sector_2_u32 = Driver.odometer_u32;

                    SectorAndTourDatas.sector_name = "S1";

                    if (Logs._IsLog)
                    {
                        myDataGrid.addGrid(mylogs.Hsector1Datas);
                    }
                    else
                    {
                        myDataGrid.addGrid(SectorAndTourDatas.sector1Datas);
                    }

                    SectorAndTourDatas.sector1_sure.Reset();
                    SectorAndTourDatas.sector_name = "S2";
                    ThreadMethods.LabelDegis(sektor, SectorAndTourDatas.sector_name);
                    MACROS.sector_flag[0] = false;
                    MACROS.sector_flag[1] = true;
                }
            }

            if (angle > MACROS.S3_Start && angle < MACROS.S3_Stop && MACROS.sector_flag[1])
            {
                if (MACROS.sector_flag[2] == false)
                {
                    SectorAndTourDatas.sector3_sure.Start();
                    SectorAndTourDatas.gidilen_yol_gps_sector_2_u32 = myGmap.odometer_gps - SectorAndTourDatas.gidilen_yol_gps_sector_2_u32;
                    SectorAndTourDatas.consumption_sector_2_f32 = BMS.bat_cons_f32 - SectorAndTourDatas.consumption_sector_2_f32;
                    SectorAndTourDatas.consumption_out_sector_2_f32 = EMS.out_cons_f32 - SectorAndTourDatas.consumption_out_sector_2_f32;
                    SectorAndTourDatas.gidilen_yol_vcu_sector_2_u32 = Driver.odometer_u32 - SectorAndTourDatas.gidilen_yol_vcu_sector_2_u32;

                    SectorAndTourDatas.gidilen_yol_gps_sector_3_u32 = myGmap.odometer_gps;
                    SectorAndTourDatas.consumption_sector_3_f32 = BMS.bat_cons_f32;
                    SectorAndTourDatas.consumption_out_sector_3_f32 = EMS.out_cons_f32;
                    SectorAndTourDatas.gidilen_yol_vcu_sector_3_u32 = Driver.odometer_u32;

                    if (Logs._IsLog)
                    {
                        myDataGrid.addGrid(mylogs.Hsector2Datas);
                    }
                    else
                    {
                        myDataGrid.addGrid(SectorAndTourDatas.sector2Datas);
                    }
                    SectorAndTourDatas.sector2_sure.Reset();
                    SectorAndTourDatas.sector_name = "S3";
                    ThreadMethods.LabelDegis(sektor, SectorAndTourDatas.sector_name);
                    MACROS.sector_flag[2] = true;
                    MACROS.sector_flag[1] = false;
                }
            }

            if (angle > MACROS.S4_Start && angle < MACROS.S4_Stop && MACROS.sector_flag[2])
            {
                if (MACROS.sector_flag[3] == false)
                {
                    SectorAndTourDatas.sector4_sure.Start();
                    SectorAndTourDatas.gidilen_yol_gps_sector_3_u32 = myGmap.odometer_gps - SectorAndTourDatas.gidilen_yol_gps_sector_3_u32;
                    SectorAndTourDatas.consumption_sector_3_f32 = BMS.bat_cons_f32 - SectorAndTourDatas.consumption_sector_3_f32;
                    SectorAndTourDatas.consumption_out_sector_3_f32 = EMS.out_cons_f32 - SectorAndTourDatas.consumption_out_sector_3_f32;
                    SectorAndTourDatas.gidilen_yol_vcu_sector_3_u32 = Driver.odometer_u32 - SectorAndTourDatas.gidilen_yol_vcu_sector_3_u32;

                    SectorAndTourDatas.gidilen_yol_gps_sector_4_u32 = myGmap.odometer_gps;
                    SectorAndTourDatas.consumption_sector_4_f32 = BMS.bat_cons_f32;
                    SectorAndTourDatas.consumption_out_sector_4_f32 = EMS.out_cons_f32;
                    SectorAndTourDatas.gidilen_yol_vcu_sector_4_u32 = Driver.odometer_u32;
                    if (Logs._IsLog)
                    {
                        myDataGrid.addGrid(mylogs.Hsector3Datas);
                    }
                    else
                    {
                        myDataGrid.addGrid(SectorAndTourDatas.sector3Datas);
                    }
                    SectorAndTourDatas.sector3_sure.Reset();
                    SectorAndTourDatas.sector_name = "S4";
                    ThreadMethods.LabelDegis(sektor, SectorAndTourDatas.sector_name);
                    MACROS.sector_flag[3] = true;
                    MACROS.sector_flag[2] = false;
                    MACROS.sector_4to_1 = true;
                }
            }
        }
        
        private void telemetry_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(myDisplayThread.IsAlive)
            {
                myDisplayThread.Abort();
            }
           if(myTimeTickThread.IsAlive)
            {
                myTimeTickThread.Abort();
            }
            
            if (MACROS.client.IsConnected)
            {
                mqtt.disConnectMQTT();
            }

            if(serialPort1.IsOpen)
            {
                serialportRF.DisconnectSerialPort(serialportRF.portname);
            }

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

            if(mylogs.history_counter > history_displayer.Value)
            {
                if(!MACROS.hold_my_history && !MACROS.show_old_datas)
                {
                    mylogs.hold_history_shower = mylogs.history_counter;
                    MACROS.show_old_datas = true;
                    MACROS.hold_my_history = true;
                    myGmap.OverlayDelete();
                }            
            }

            else 
            {
                MACROS.show_old_datas = false;
                if(MACROS.hold_my_history)
                {
                    MACROS.hold_my_history = false;
                    history_displayer.Value = mylogs.hold_history_shower;
                    myGmap.OverlayDelete();                   
                }
            }

            string[] old_datass = mylogs.read_string[mylogs.read_string.Keys.ElementAt(history_displayer.Value)].Split('$');
            if (MACROS.IsSd == false)
            {
                mylogs.ReadArayüz(old_datass);
                displayAllData();
                ThreadMethods.TextDegis(gecen_sure, Timers.Gecen_süre.ToString(MACROS.TimeStringFormat));
                ThreadMethods.TextDegis(kalan_sure, Timers.Kalan_süre.ToString(MACROS.TimeStringFormat));
                ThreadMethods.TextDegis(anlik_tur_suresi, mylogs.anlik_tur_sure);
                ThreadMethods.TextDegis(en_hizli_tur_timer, mylogs.en_hizli_tur_sure);
                ThreadMethods.TextDegis(ort_hiz, ((byte)(Driver.odometer_u32 / Timers.Gecen_süre.TotalSeconds) * MACROS.mstokmh).ToString());
                ThreadMethods.LabelDegis(hedef_hiz, Convert.ToString(Timers.hedef_hiz));
            }
            else
            {
                mylogs.readSdCard(old_datass);
                displayAllData();
            }
            mylogs.history_counter = history_displayer.Value;

     
        }

        private void TurAt()
        {
            SectorAndTourDatas.gidilen_yol_gps_sector_T_u32 = myGmap.odometer_gps - SectorAndTourDatas.gidilen_yol_gps_sector_T_u32;
            SectorAndTourDatas.gidilen_yol_vcu_sector_T_u32 = Driver.odometer_u32 - SectorAndTourDatas.gidilen_yol_vcu_sector_T_u32;
            SectorAndTourDatas.consumption_sector_T_f32 = BMS.bat_cons_f32 - SectorAndTourDatas.consumption_sector_T_f32;

            if (Logs._IsLog)
            {
                myDataGrid.addGrid(mylogs.HturAtDatas);
                ThreadMethods.TextDegis(ortalama_tur_suresi, mylogs.ortalama_tur_sure);
                Timers.currentTour++;
            }

            else
            {
                ThreadMethods.TextDegis(önceki_tur_timer, Timers.Anlik_tur_süresi.Elapsed.ToString(MACROS.TimeStringFormat));
                ThreadMethods.TextDegis(ortalama_tur_suresi, Timers.Ortalama_tur_süresi.ToString(MACROS.TimeStringFormat));
                if (Timers.IsFastestLaps)
                {
                    ThreadMethods.TextDegis(en_hizli_tur_timer, Timers.Anlik_tur_süresi.Elapsed.ToString(MACROS.TimeStringFormat));
                    Timers.en_hizli_tur_suresi = new TimeSpan(Timers.Anlik_tur_süresi.Elapsed.Hours, Timers.Anlik_tur_süresi.Elapsed.Minutes, Timers.Anlik_tur_süresi.Elapsed.Seconds);
                }
                SectorAndTourDatas.sector_name = "ST";
                myDataGrid.addGrid(SectorAndTourDatas.turAtDatas);
                timer.TurAt();
            }
  
          
            SectorAndTourDatas.gidilen_yol_gps_sector_T_u32 = myGmap.odometer_gps;
            SectorAndTourDatas.gidilen_yol_vcu_sector_T_u32 = Driver.odometer_u32;
            SectorAndTourDatas.consumption_sector_T_f32 = BMS.bat_cons_f32;
            SectorAndTourDatas.consumption_out_sector_T_f32 = EMS.out_cons_f32;
            myGmap.OverlayDelete();
        }

        private void gsmResetleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
            {
                serialportRF.ConnectSerialPort(serialportRF.portname);
            }
            serialportRF.write(MACROS.gsm_reset_buffer);
        }

        private void bMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMS_form bmsform = new BMS_form();
            bmsform.Show();
        }

        private void grafiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graph_form grafiklerr = new graph_form();
            grafiklerr.Show();
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

        private void tableLayoutPanel87_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
