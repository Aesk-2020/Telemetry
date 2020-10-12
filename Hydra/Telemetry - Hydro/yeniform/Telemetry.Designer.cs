namespace telemetry_hydro
{
    partial class telemetry
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telemetry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.error_ready = new System.Windows.Forms.ImageList(this.components);
            this.gmap_sag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GpsMouseModAktif = new System.Windows.Forms.ToolStripMenuItem();
            this.GpsMouseModDeaktif = new System.Windows.Forms.ToolStripMenuItem();
            this.MarkerTemizlee = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.system_durum = new System.Windows.Forms.PictureBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.gsm_durum = new System.Windows.Forms.PictureBox();
            this.label62 = new System.Windows.Forms.Label();
            this.nextion_durum = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.bms_dc_bus_ready_flag = new System.Windows.Forms.PictureBox();
            this.label94 = new System.Windows.Forms.Label();
            this.bms_discharge_flag = new System.Windows.Forms.PictureBox();
            this.label93 = new System.Windows.Forms.Label();
            this.bms_precharge_flag = new System.Windows.Forms.PictureBox();
            this.label95 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.ems_durum = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.bms_durum = new System.Windows.Forms.PictureBox();
            this.xbee_active = new System.Windows.Forms.PictureBox();
            this.label49 = new System.Windows.Forms.Label();
            this.driver_durum = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.driver_fwrv_status = new System.Windows.Forms.TextBox();
            this.driver_brake_status = new System.Windows.Forms.TextBox();
            this.driver_ign_status = new System.Windows.Forms.TextBox();
            this.gidilen_yol_gps = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.label64 = new System.Windows.Forms.Label();
            this.power_text = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.set_hiz_bar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.set_hizz = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.atilan_Tur = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.turrr = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel86 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel87 = new System.Windows.Forms.TableLayoutPanel();
            this.kalan_yol_driver = new System.Windows.Forms.TextBox();
            this.gidilen_yol_driver = new System.Windows.Forms.TextBox();
            this.anlik_tur_suresi = new System.Windows.Forms.TextBox();
            this.en_hizli_tur_timer = new System.Windows.Forms.TextBox();
            this.önceki_tur_timer = new System.Windows.Forms.TextBox();
            this.ort_hiz = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.maks_hiz = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel85 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ortalama_tur_suresi = new System.Windows.Forms.TextBox();
            this.kalan_sure = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.gecen_sure = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.tork_limit = new System.Windows.Forms.Label();
            this.motor_temp_error = new System.Windows.Forms.Label();
            this.dc_bus_amper_error = new System.Windows.Forms.Label();
            this.zpc = new System.Windows.Forms.Label();
            this.pwm_enabled = new System.Windows.Forms.Label();
            this.dc_bus_voltage_error = new System.Windows.Forms.Label();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.torque = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.iq = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.phase_b_cur = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.phase_a_cur = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.dc_bus_cur = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.dc_bus_volt = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.motor_temp = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.phase_a_rms = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.bms_fatal_error = new System.Windows.Forms.PictureBox();
            this.label85 = new System.Windows.Forms.Label();
            this.bms_over_cur_error = new System.Windows.Forms.PictureBox();
            this.bms_comm_error = new System.Windows.Forms.PictureBox();
            this.bms_temp_error = new System.Windows.Forms.PictureBox();
            this.bms_low_volt_error = new System.Windows.Forms.PictureBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.bms_high_volt_error = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ems_can_error = new System.Windows.Forms.PictureBox();
            this.label44 = new System.Windows.Forms.Label();
            this.bms_can_error = new System.Windows.Forms.PictureBox();
            this.label45 = new System.Windows.Forms.Label();
            this.driver_can_error = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.bms_temp = new System.Windows.Forms.TextBox();
            this.bms_worst_cell_address = new System.Windows.Forms.TextBox();
            this.bms_worst_cell_voltage = new System.Windows.Forms.TextBox();
            this.bms_soc = new System.Windows.Forms.TextBox();
            this.bms_bat_cons = new System.Windows.Forms.TextBox();
            this.bms_bat_current = new System.Windows.Forms.TextBox();
            this.bms_bat_voltage = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.energy = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ems_temp = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.ems_soc = new System.Windows.Forms.TextBox();
            this.ems_penalty = new System.Windows.Forms.TextBox();
            this.ems_fc_lt_cons = new System.Windows.Forms.TextBox();
            this.ems_out_cons = new System.Windows.Forms.TextBox();
            this.ems_fc_cons = new System.Windows.Forms.TextBox();
            this.ems_bat_cons = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.ems_out_current = new System.Windows.Forms.TextBox();
            this.ems_fc_current = new System.Windows.Forms.TextBox();
            this.ems_bat_current = new System.Windows.Forms.TextBox();
            this.ems_out_voltage = new System.Windows.Forms.TextBox();
            this.ems_fc_voltage = new System.Windows.Forms.TextBox();
            this.ems_bat_volt = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.ems_bat_volt_error = new System.Windows.Forms.PictureBox();
            this.ems_fc_voltage_error = new System.Windows.Forms.PictureBox();
            this.ems_out_voltage_error = new System.Windows.Forms.PictureBox();
            this.ems_bat_current_error = new System.Windows.Forms.PictureBox();
            this.ems_fc_current_error = new System.Windows.Forms.PictureBox();
            this.out_current_error = new System.Windows.Forms.PictureBox();
            this.angle_gauge = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.sektor = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.uydu_sayisi = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.gps_verim = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.mqtt_toplam_paket = new System.Windows.Forms.TextBox();
            this.mqtt_solved_paket = new System.Windows.Forms.TextBox();
            this.mqtt_verim = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.gsm_yenileme = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.verim = new System.Windows.Forms.TextBox();
            this.cozulen_paket = new System.Windows.Forms.TextBox();
            this.crc_hatali = new System.Windows.Forms.TextBox();
            this.baslik_hatali = new System.Windows.Forms.TextBox();
            this.gelen_bayt = new System.Windows.Forms.TextBox();
            this.secilen_port = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.history_displayer = new System.Windows.Forms.HScrollBar();
            this.kalanyol_bar = new Guna.UI.WinForms.GunaProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hedef_hiz = new System.Windows.Forms.Label();
            this.hedefhiz_gauge = new Guna.UI.WinForms.GunaGauge();
            this.kalanyol_gps = new Guna.UI.WinForms.GunaProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.anlik_hiz_gps = new System.Windows.Forms.Label();
            this.gpshiz_gauge = new Guna.UI.WinForms.GunaGauge();
            this.label36 = new System.Windows.Forms.Label();
            this.yol_gps = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yarışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıyıKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xbeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıyıKesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gsmResetleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sDKayıtAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eklentilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turAtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.anlik_hiz = new System.Windows.Forms.Label();
            this.anlikhiz_gauge = new Guna.UI.WinForms.GunaGauge();
            this.ana_sekme = new System.Windows.Forms.TabControl();
            this.gmap_sag.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.system_durum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsm_durum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextion_durum)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bms_dc_bus_ready_flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_discharge_flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_precharge_flag)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ems_durum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_durum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbee_active)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_durum)).BeginInit();
            this.tableLayoutPanel18.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.set_hiz_bar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.atilan_Tur.SuspendLayout();
            this.tableLayoutPanel86.SuspendLayout();
            this.tableLayoutPanel87.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tableLayoutPanel85.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bms_fatal_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_over_cur_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_comm_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_temp_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_low_volt_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_high_volt_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_can_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_can_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_can_error)).BeginInit();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ems_bat_volt_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_fc_voltage_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_out_voltage_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_bat_current_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_fc_current_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out_current_error)).BeginInit();
            this.angle_gauge.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ana_sekme.SuspendLayout();
            this.SuspendLayout();
            // 
            // error_ready
            // 
            this.error_ready.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("error_ready.ImageStream")));
            this.error_ready.TransparentColor = System.Drawing.Color.Transparent;
            this.error_ready.Images.SetKeyName(0, "cooltext347148855345307.png");
            this.error_ready.Images.SetKeyName(1, "cooltext347148907798044.png");
            this.error_ready.Images.SetKeyName(2, "asdasdasdsad.png");
            // 
            // gmap_sag
            // 
            this.gmap_sag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GpsMouseModAktif,
            this.GpsMouseModDeaktif,
            this.MarkerTemizlee});
            this.gmap_sag.Name = "gmap_sag";
            this.gmap_sag.Size = new System.Drawing.Size(202, 70);
            // 
            // GpsMouseModAktif
            // 
            this.GpsMouseModAktif.Name = "GpsMouseModAktif";
            this.GpsMouseModAktif.Size = new System.Drawing.Size(201, 22);
            this.GpsMouseModAktif.Text = "Gps Mouse Mod Aktif";
            this.GpsMouseModAktif.Click += new System.EventHandler(this.GpsMouseModAktif_Click);
            // 
            // GpsMouseModDeaktif
            // 
            this.GpsMouseModDeaktif.Name = "GpsMouseModDeaktif";
            this.GpsMouseModDeaktif.Size = new System.Drawing.Size(201, 22);
            this.GpsMouseModDeaktif.Text = "Gps Mouse Mod Deaktif";
            this.GpsMouseModDeaktif.Click += new System.EventHandler(this.GpsMouseModDeaktif_Click);
            // 
            // MarkerTemizlee
            // 
            this.MarkerTemizlee.Name = "MarkerTemizlee";
            this.MarkerTemizlee.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.MarkerTemizlee.Size = new System.Drawing.Size(201, 22);
            this.MarkerTemizlee.Text = "Marker Temizle";
            this.MarkerTemizlee.Click += new System.EventHandler(this.MarkerTemizlee_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(200, 40);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel8);
            this.tabPage1.Controls.Add(this.gidilen_yol_gps);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.angle_gauge);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.tableLayoutPanel11);
            this.tabPage1.Controls.Add(this.tableLayoutPanel10);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.gsm_yenileme);
            this.tabPage1.Controls.Add(this.tableLayoutPanel9);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.history_displayer);
            this.tabPage1.Controls.Add(this.kalanyol_bar);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.hedef_hiz);
            this.tabPage1.Controls.Add(this.hedefhiz_gauge);
            this.tabPage1.Controls.Add(this.kalanyol_gps);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.anlik_hiz_gps);
            this.tabPage1.Controls.Add(this.gpshiz_gauge);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.yol_gps);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.gmap);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.anlik_hiz);
            this.tabPage1.Controls.Add(this.anlikhiz_gauge);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1896, 1015);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.89109F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.39604F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71287F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel19, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel18, 2, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 567);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(585, 126);
            this.tableLayoutPanel8.TabIndex = 59;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 1;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(145, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(134, 120);
            this.tableLayoutPanel19.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel12.Controls.Add(this.system_durum, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.label47, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label27, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.gsm_durum, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.label62, 0, 2);
            this.tableLayoutPanel12.Controls.Add(this.nextion_durum, 1, 2);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.71698F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.28302F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(128, 114);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // system_durum
            // 
            this.system_durum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.system_durum.Location = new System.Drawing.Point(75, 48);
            this.system_durum.Name = "system_durum";
            this.system_durum.Size = new System.Drawing.Size(47, 26);
            this.system_durum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.system_durum.TabIndex = 98;
            this.system_durum.TabStop = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label47.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(6, 3);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(60, 39);
            this.label47.TabIndex = 8;
            this.label47.Text = "GSM";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(6, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 32);
            this.label27.TabIndex = 99;
            this.label27.Text = "SYSTEM";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gsm_durum
            // 
            this.gsm_durum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gsm_durum.Location = new System.Drawing.Point(75, 6);
            this.gsm_durum.Name = "gsm_durum";
            this.gsm_durum.Size = new System.Drawing.Size(47, 33);
            this.gsm_durum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gsm_durum.TabIndex = 13;
            this.gsm_durum.TabStop = false;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label62.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(6, 80);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(60, 31);
            this.label62.TabIndex = 100;
            this.label62.Text = "NEXTION";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextion_durum
            // 
            this.nextion_durum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextion_durum.Location = new System.Drawing.Point(75, 83);
            this.nextion_durum.Name = "nextion_durum";
            this.nextion_durum.Size = new System.Drawing.Size(47, 25);
            this.nextion_durum.TabIndex = 101;
            this.nextion_durum.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.14689F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.85311F));
            this.tableLayoutPanel5.Controls.Add(this.bms_dc_bus_ready_flag, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label94, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.bms_discharge_flag, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label93, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.bms_precharge_flag, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label95, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(398, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.01205F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.98795F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(183, 120);
            this.tableLayoutPanel5.TabIndex = 35;
            // 
            // bms_dc_bus_ready_flag
            // 
            this.bms_dc_bus_ready_flag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bms_dc_bus_ready_flag.Location = new System.Drawing.Point(117, 89);
            this.bms_dc_bus_ready_flag.Name = "bms_dc_bus_ready_flag";
            this.bms_dc_bus_ready_flag.Size = new System.Drawing.Size(60, 25);
            this.bms_dc_bus_ready_flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bms_dc_bus_ready_flag.TabIndex = 102;
            this.bms_dc_bus_ready_flag.TabStop = false;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label94.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label94.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label94.ForeColor = System.Drawing.Color.White;
            this.label94.Location = new System.Drawing.Point(6, 3);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(102, 41);
            this.label94.TabIndex = 99;
            this.label94.Text = "PRECHARGE";
            this.label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_discharge_flag
            // 
            this.bms_discharge_flag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bms_discharge_flag.Location = new System.Drawing.Point(117, 50);
            this.bms_discharge_flag.Name = "bms_discharge_flag";
            this.bms_discharge_flag.Size = new System.Drawing.Size(60, 30);
            this.bms_discharge_flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bms_discharge_flag.TabIndex = 102;
            this.bms_discharge_flag.TabStop = false;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label93.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label93.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label93.ForeColor = System.Drawing.Color.White;
            this.label93.Location = new System.Drawing.Point(6, 47);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(102, 36);
            this.label93.TabIndex = 98;
            this.label93.Text = "DISCHARGE";
            this.label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_precharge_flag
            // 
            this.bms_precharge_flag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bms_precharge_flag.Location = new System.Drawing.Point(117, 6);
            this.bms_precharge_flag.Name = "bms_precharge_flag";
            this.bms_precharge_flag.Size = new System.Drawing.Size(60, 35);
            this.bms_precharge_flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bms_precharge_flag.TabIndex = 102;
            this.bms_precharge_flag.TabStop = false;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label95.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label95.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label95.ForeColor = System.Drawing.Color.White;
            this.label95.Location = new System.Drawing.Point(6, 86);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(102, 31);
            this.label95.TabIndex = 100;
            this.label95.Text = "READY";
            this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.92308F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.07692F));
            this.tableLayoutPanel6.Controls.Add(this.ems_durum, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label26, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label53, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label58, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.bms_durum, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.xbee_active, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.label49, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.driver_durum, 1, 0);
            this.tableLayoutPanel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(133, 120);
            this.tableLayoutPanel6.TabIndex = 34;
            // 
            // ems_durum
            // 
            this.ems_durum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_durum.Location = new System.Drawing.Point(79, 64);
            this.ems_durum.Name = "ems_durum";
            this.ems_durum.Size = new System.Drawing.Size(48, 20);
            this.ems_durum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ems_durum.TabIndex = 98;
            this.ems_durum.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(6, 61);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 26);
            this.label26.TabIndex = 98;
            this.label26.Text = "EMS";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(6, 32);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(64, 26);
            this.label53.TabIndex = 2;
            this.label53.Text = "BMS";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(6, 3);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(64, 26);
            this.label58.TabIndex = 0;
            this.label58.Text = "DRIVER";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_durum
            // 
            this.bms_durum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_durum.Location = new System.Drawing.Point(79, 35);
            this.bms_durum.Name = "bms_durum";
            this.bms_durum.Size = new System.Drawing.Size(48, 20);
            this.bms_durum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bms_durum.TabIndex = 10;
            this.bms_durum.TabStop = false;
            // 
            // xbee_active
            // 
            this.xbee_active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.xbee_active.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xbee_active.Location = new System.Drawing.Point(79, 93);
            this.xbee_active.Name = "xbee_active";
            this.xbee_active.Size = new System.Drawing.Size(48, 21);
            this.xbee_active.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xbee_active.TabIndex = 12;
            this.xbee_active.TabStop = false;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(6, 90);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(64, 27);
            this.label49.TabIndex = 6;
            this.label49.Text = "XBEE";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driver_durum
            // 
            this.driver_durum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driver_durum.Location = new System.Drawing.Point(79, 6);
            this.driver_durum.Name = "driver_durum";
            this.driver_durum.Size = new System.Drawing.Size(48, 20);
            this.driver_durum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.driver_durum.TabIndex = 9;
            this.driver_durum.TabStop = false;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel18.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.driver_fwrv_status, 0, 3);
            this.tableLayoutPanel18.Controls.Add(this.driver_brake_status, 0, 2);
            this.tableLayoutPanel18.Controls.Add(this.driver_ign_status, 0, 1);
            this.tableLayoutPanel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel18.Location = new System.Drawing.Point(285, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 4;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.93162F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.93162F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.93162F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(107, 120);
            this.tableLayoutPanel18.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "DRIVE STATUS";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driver_fwrv_status
            // 
            this.driver_fwrv_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.driver_fwrv_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_fwrv_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_fwrv_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_fwrv_status.ForeColor = System.Drawing.Color.White;
            this.driver_fwrv_status.Location = new System.Drawing.Point(6, 94);
            this.driver_fwrv_status.Multiline = true;
            this.driver_fwrv_status.Name = "driver_fwrv_status";
            this.driver_fwrv_status.Size = new System.Drawing.Size(95, 20);
            this.driver_fwrv_status.TabIndex = 3;
            this.driver_fwrv_status.Text = "BRAKE OFF";
            this.driver_fwrv_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // driver_brake_status
            // 
            this.driver_brake_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.driver_brake_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_brake_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_brake_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_brake_status.ForeColor = System.Drawing.Color.White;
            this.driver_brake_status.Location = new System.Drawing.Point(6, 67);
            this.driver_brake_status.Multiline = true;
            this.driver_brake_status.Name = "driver_brake_status";
            this.driver_brake_status.Size = new System.Drawing.Size(95, 18);
            this.driver_brake_status.TabIndex = 2;
            this.driver_brake_status.Text = "FORWARD";
            this.driver_brake_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // driver_ign_status
            // 
            this.driver_ign_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.driver_ign_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_ign_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_ign_status.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_ign_status.ForeColor = System.Drawing.Color.White;
            this.driver_ign_status.Location = new System.Drawing.Point(6, 40);
            this.driver_ign_status.Multiline = true;
            this.driver_ign_status.Name = "driver_ign_status";
            this.driver_ign_status.Size = new System.Drawing.Size(95, 18);
            this.driver_ign_status.TabIndex = 1;
            this.driver_ign_status.Text = "IGN OFF";
            this.driver_ign_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gidilen_yol_gps
            // 
            this.gidilen_yol_gps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.gidilen_yol_gps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gidilen_yol_gps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gidilen_yol_gps.ForeColor = System.Drawing.Color.White;
            this.gidilen_yol_gps.Location = new System.Drawing.Point(1386, 152);
            this.gidilen_yol_gps.Name = "gidilen_yol_gps";
            this.gidilen_yol_gps.Size = new System.Drawing.Size(100, 19);
            this.gidilen_yol_gps.TabIndex = 97;
            this.gidilen_yol_gps.Text = "00000";
            this.gidilen_yol_gps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel16);
            this.groupBox2.Controls.Add(this.tableLayoutPanel26);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel86);
            this.groupBox2.Controls.Add(this.tableLayoutPanel13);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(591, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 656);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DRIVER";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Controls.Add(this.label64, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.power_text, 0, 1);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(127, 267);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.61538F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.38461F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(213, 89);
            this.tableLayoutPanel16.TabIndex = 106;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label64.Location = new System.Drawing.Point(6, 3);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(201, 27);
            this.label64.TabIndex = 0;
            this.label64.Text = "POWER";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // power_text
            // 
            this.power_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.power_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.power_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.power_text.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.power_text.ForeColor = System.Drawing.Color.White;
            this.power_text.Location = new System.Drawing.Point(6, 36);
            this.power_text.Multiline = true;
            this.power_text.Name = "power_text";
            this.power_text.Size = new System.Drawing.Size(201, 47);
            this.power_text.TabIndex = 2;
            this.power_text.Text = "NaN";
            this.power_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 1;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel26.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel26.Controls.Add(this.set_hiz_bar, 0, 1);
            this.tableLayoutPanel26.Location = new System.Drawing.Point(343, 238);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 2;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(115, 137);
            this.tableLayoutPanel26.TabIndex = 105;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 23);
            this.textBox2.TabIndex = 100;
            this.textBox2.Text = "SET HIZ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // set_hiz_bar
            // 
            this.set_hiz_bar.AnimationSpeed = 0.6F;
            this.set_hiz_bar.BaseColor = System.Drawing.Color.Transparent;
            this.set_hiz_bar.Controls.Add(this.set_hizz);
            this.set_hiz_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_hiz_bar.ForeColor = System.Drawing.Color.White;
            this.set_hiz_bar.IdleColor = System.Drawing.Color.Gainsboro;
            this.set_hiz_bar.IdleOffset = 10;
            this.set_hiz_bar.IdleThickness = 10;
            this.set_hiz_bar.Image = null;
            this.set_hiz_bar.ImageSize = new System.Drawing.Size(52, 52);
            this.set_hiz_bar.Location = new System.Drawing.Point(3, 32);
            this.set_hiz_bar.Maximum = 65;
            this.set_hiz_bar.Name = "set_hiz_bar";
            this.set_hiz_bar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.set_hiz_bar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.set_hiz_bar.ProgressOffset = 10;
            this.set_hiz_bar.ProgressThickness = 10;
            this.set_hiz_bar.Size = new System.Drawing.Size(109, 102);
            this.set_hiz_bar.TabIndex = 98;
            // 
            // set_hizz
            // 
            this.set_hizz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.set_hizz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.set_hizz.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.set_hizz.ForeColor = System.Drawing.Color.White;
            this.set_hizz.Location = new System.Drawing.Point(26, 26);
            this.set_hizz.Multiline = true;
            this.set_hizz.Name = "set_hizz";
            this.set_hizz.Size = new System.Drawing.Size(51, 50);
            this.set_hizz.TabIndex = 102;
            this.set_hizz.Text = "0";
            this.set_hizz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.atilan_Tur, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 238);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(118, 137);
            this.tableLayoutPanel2.TabIndex = 60;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 23);
            this.textBox3.TabIndex = 101;
            this.textBox3.Text = "TUR";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // atilan_Tur
            // 
            this.atilan_Tur.AnimationSpeed = 0.6F;
            this.atilan_Tur.BaseColor = System.Drawing.Color.Transparent;
            this.atilan_Tur.Controls.Add(this.turrr);
            this.atilan_Tur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atilan_Tur.ForeColor = System.Drawing.Color.White;
            this.atilan_Tur.IdleColor = System.Drawing.Color.Gainsboro;
            this.atilan_Tur.IdleOffset = 10;
            this.atilan_Tur.IdleThickness = 10;
            this.atilan_Tur.Image = null;
            this.atilan_Tur.ImageSize = new System.Drawing.Size(52, 52);
            this.atilan_Tur.Location = new System.Drawing.Point(3, 32);
            this.atilan_Tur.Maximum = 30;
            this.atilan_Tur.Name = "atilan_Tur";
            this.atilan_Tur.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.atilan_Tur.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.atilan_Tur.ProgressOffset = 10;
            this.atilan_Tur.ProgressThickness = 10;
            this.atilan_Tur.Size = new System.Drawing.Size(112, 102);
            this.atilan_Tur.TabIndex = 99;
            // 
            // turrr
            // 
            this.turrr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.turrr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.turrr.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turrr.ForeColor = System.Drawing.Color.White;
            this.turrr.Location = new System.Drawing.Point(34, 26);
            this.turrr.Multiline = true;
            this.turrr.Name = "turrr";
            this.turrr.Size = new System.Drawing.Size(45, 50);
            this.turrr.TabIndex = 99;
            this.turrr.Text = "0";
            this.turrr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel86
            // 
            this.tableLayoutPanel86.ColumnCount = 2;
            this.tableLayoutPanel86.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.75779F));
            this.tableLayoutPanel86.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.24221F));
            this.tableLayoutPanel86.Controls.Add(this.tableLayoutPanel87, 1, 0);
            this.tableLayoutPanel86.Controls.Add(this.tableLayoutPanel85, 0, 0);
            this.tableLayoutPanel86.Location = new System.Drawing.Point(3, 378);
            this.tableLayoutPanel86.Name = "tableLayoutPanel86";
            this.tableLayoutPanel86.RowCount = 1;
            this.tableLayoutPanel86.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel86.Size = new System.Drawing.Size(458, 275);
            this.tableLayoutPanel86.TabIndex = 58;
            // 
            // tableLayoutPanel87
            // 
            this.tableLayoutPanel87.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel87.ColumnCount = 3;
            this.tableLayoutPanel87.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.81819F));
            this.tableLayoutPanel87.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69697F));
            this.tableLayoutPanel87.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel87.Controls.Add(this.kalan_yol_driver, 2, 6);
            this.tableLayoutPanel87.Controls.Add(this.gidilen_yol_driver, 2, 5);
            this.tableLayoutPanel87.Controls.Add(this.anlik_tur_suresi, 2, 4);
            this.tableLayoutPanel87.Controls.Add(this.en_hizli_tur_timer, 2, 3);
            this.tableLayoutPanel87.Controls.Add(this.önceki_tur_timer, 2, 2);
            this.tableLayoutPanel87.Controls.Add(this.ort_hiz, 2, 1);
            this.tableLayoutPanel87.Controls.Add(this.pictureBox5, 0, 5);
            this.tableLayoutPanel87.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel87.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel87.Controls.Add(this.pictureBox13, 0, 1);
            this.tableLayoutPanel87.Controls.Add(this.label17, 1, 1);
            this.tableLayoutPanel87.Controls.Add(this.pictureBox7, 0, 2);
            this.tableLayoutPanel87.Controls.Add(this.label23, 1, 2);
            this.tableLayoutPanel87.Controls.Add(this.label33, 1, 6);
            this.tableLayoutPanel87.Controls.Add(this.label32, 1, 5);
            this.tableLayoutPanel87.Controls.Add(this.pictureBox2, 0, 3);
            this.tableLayoutPanel87.Controls.Add(this.label21, 1, 3);
            this.tableLayoutPanel87.Controls.Add(this.pictureBox3, 0, 4);
            this.tableLayoutPanel87.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel87.Controls.Add(this.pictureBox6, 0, 6);
            this.tableLayoutPanel87.Controls.Add(this.maks_hiz, 2, 0);
            this.tableLayoutPanel87.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel87.Location = new System.Drawing.Point(244, 3);
            this.tableLayoutPanel87.Name = "tableLayoutPanel87";
            this.tableLayoutPanel87.RowCount = 7;
            this.tableLayoutPanel87.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel87.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel87.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel87.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel87.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel87.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel87.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel87.Size = new System.Drawing.Size(211, 269);
            this.tableLayoutPanel87.TabIndex = 58;
            this.tableLayoutPanel87.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel87_Paint);
            // 
            // kalan_yol_driver
            // 
            this.kalan_yol_driver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.kalan_yol_driver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kalan_yol_driver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kalan_yol_driver.ForeColor = System.Drawing.Color.White;
            this.kalan_yol_driver.Location = new System.Drawing.Point(112, 232);
            this.kalan_yol_driver.Multiline = true;
            this.kalan_yol_driver.Name = "kalan_yol_driver";
            this.kalan_yol_driver.Size = new System.Drawing.Size(95, 33);
            this.kalan_yol_driver.TabIndex = 74;
            this.kalan_yol_driver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gidilen_yol_driver
            // 
            this.gidilen_yol_driver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.gidilen_yol_driver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gidilen_yol_driver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gidilen_yol_driver.ForeColor = System.Drawing.Color.White;
            this.gidilen_yol_driver.Location = new System.Drawing.Point(112, 194);
            this.gidilen_yol_driver.Multiline = true;
            this.gidilen_yol_driver.Name = "gidilen_yol_driver";
            this.gidilen_yol_driver.Size = new System.Drawing.Size(95, 31);
            this.gidilen_yol_driver.TabIndex = 73;
            this.gidilen_yol_driver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // anlik_tur_suresi
            // 
            this.anlik_tur_suresi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.anlik_tur_suresi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anlik_tur_suresi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anlik_tur_suresi.ForeColor = System.Drawing.Color.White;
            this.anlik_tur_suresi.Location = new System.Drawing.Point(112, 156);
            this.anlik_tur_suresi.Multiline = true;
            this.anlik_tur_suresi.Name = "anlik_tur_suresi";
            this.anlik_tur_suresi.Size = new System.Drawing.Size(95, 31);
            this.anlik_tur_suresi.TabIndex = 72;
            this.anlik_tur_suresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // en_hizli_tur_timer
            // 
            this.en_hizli_tur_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.en_hizli_tur_timer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.en_hizli_tur_timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.en_hizli_tur_timer.ForeColor = System.Drawing.Color.White;
            this.en_hizli_tur_timer.Location = new System.Drawing.Point(112, 118);
            this.en_hizli_tur_timer.Multiline = true;
            this.en_hizli_tur_timer.Name = "en_hizli_tur_timer";
            this.en_hizli_tur_timer.Size = new System.Drawing.Size(95, 31);
            this.en_hizli_tur_timer.TabIndex = 71;
            this.en_hizli_tur_timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // önceki_tur_timer
            // 
            this.önceki_tur_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.önceki_tur_timer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.önceki_tur_timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.önceki_tur_timer.ForeColor = System.Drawing.Color.White;
            this.önceki_tur_timer.Location = new System.Drawing.Point(112, 80);
            this.önceki_tur_timer.Multiline = true;
            this.önceki_tur_timer.Name = "önceki_tur_timer";
            this.önceki_tur_timer.Size = new System.Drawing.Size(95, 31);
            this.önceki_tur_timer.TabIndex = 70;
            this.önceki_tur_timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ort_hiz
            // 
            this.ort_hiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ort_hiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ort_hiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ort_hiz.ForeColor = System.Drawing.Color.White;
            this.ort_hiz.Location = new System.Drawing.Point(112, 42);
            this.ort_hiz.Multiline = true;
            this.ort_hiz.Name = "ort_hiz";
            this.ort_hiz.Size = new System.Drawing.Size(95, 31);
            this.ort_hiz.TabIndex = 69;
            this.ort_hiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::telemetry_hydro.Properties.Resources.road;
            this.pictureBox5.Location = new System.Drawing.Point(4, 194);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 64;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::telemetry_hydro.Properties.Resources.speed_vector;
            this.pictureBox4.Location = new System.Drawing.Point(4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(50, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 37);
            this.label15.TabIndex = 12;
            this.label15.Text = "Maks Hız";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(4, 42);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(39, 31);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 19;
            this.pictureBox13.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(50, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 37);
            this.label17.TabIndex = 16;
            this.label17.Text = "Ort. Hız";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Image = global::telemetry_hydro.Properties.Resources.czxcxz1;
            this.pictureBox7.Location = new System.Drawing.Point(4, 80);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 31);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(50, 77);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 37);
            this.label23.TabIndex = 9;
            this.label23.Text = "Önceki Tur\r\n";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(55, 231);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(45, 34);
            this.label33.TabIndex = 63;
            this.label33.Text = "Kalan Yol";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(51, 192);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 34);
            this.label32.TabIndex = 62;
            this.label32.Text = "Gidilen Yol";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::telemetry_hydro.Properties.Resources.checkered_flag_clip_art_9511_kopya;
            this.pictureBox2.Location = new System.Drawing.Point(4, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(50, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 37);
            this.label21.TabIndex = 7;
            this.label21.Text = "En Hızlı Tur";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::telemetry_hydro.Properties.Resources.dadadadda;
            this.pictureBox3.Location = new System.Drawing.Point(4, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şimdiki Tur";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::telemetry_hydro.Properties.Resources.road;
            this.pictureBox6.Location = new System.Drawing.Point(4, 232);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 65;
            this.pictureBox6.TabStop = false;
            // 
            // maks_hiz
            // 
            this.maks_hiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.maks_hiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maks_hiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maks_hiz.ForeColor = System.Drawing.Color.White;
            this.maks_hiz.Location = new System.Drawing.Point(112, 4);
            this.maks_hiz.Multiline = true;
            this.maks_hiz.Name = "maks_hiz";
            this.maks_hiz.Size = new System.Drawing.Size(95, 31);
            this.maks_hiz.TabIndex = 68;
            this.maks_hiz.Text = "0";
            this.maks_hiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel85
            // 
            this.tableLayoutPanel85.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel85.ColumnCount = 1;
            this.tableLayoutPanel85.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel85.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel85.Controls.Add(this.tableLayoutPanel21, 0, 0);
            this.tableLayoutPanel85.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel85.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel85.Name = "tableLayoutPanel85";
            this.tableLayoutPanel85.RowCount = 2;
            this.tableLayoutPanel85.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.86288F));
            this.tableLayoutPanel85.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.13712F));
            this.tableLayoutPanel85.Size = new System.Drawing.Size(235, 269);
            this.tableLayoutPanel85.TabIndex = 58;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ortalama_tur_suresi, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.kalan_sure, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label38, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label40, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.gecen_sure, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label39, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 161);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44481F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44482F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.11037F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(227, 104);
            this.tableLayoutPanel4.TabIndex = 37;
            // 
            // ortalama_tur_suresi
            // 
            this.ortalama_tur_suresi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ortalama_tur_suresi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ortalama_tur_suresi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ortalama_tur_suresi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ortalama_tur_suresi.ForeColor = System.Drawing.Color.White;
            this.ortalama_tur_suresi.Location = new System.Drawing.Point(118, 72);
            this.ortalama_tur_suresi.Multiline = true;
            this.ortalama_tur_suresi.Name = "ortalama_tur_suresi";
            this.ortalama_tur_suresi.Size = new System.Drawing.Size(103, 26);
            this.ortalama_tur_suresi.TabIndex = 13;
            this.ortalama_tur_suresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kalan_sure
            // 
            this.kalan_sure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.kalan_sure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kalan_sure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kalan_sure.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalan_sure.ForeColor = System.Drawing.Color.White;
            this.kalan_sure.Location = new System.Drawing.Point(118, 6);
            this.kalan_sure.Multiline = true;
            this.kalan_sure.Name = "kalan_sure";
            this.kalan_sure.Size = new System.Drawing.Size(103, 24);
            this.kalan_sure.TabIndex = 9;
            this.kalan_sure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(6, 3);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(103, 30);
            this.label38.TabIndex = 0;
            this.label38.Text = "KALAN SÜRE";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(6, 36);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(103, 30);
            this.label40.TabIndex = 7;
            this.label40.Text = "GEÇEN SÜRE";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gecen_sure
            // 
            this.gecen_sure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.gecen_sure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gecen_sure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gecen_sure.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gecen_sure.ForeColor = System.Drawing.Color.White;
            this.gecen_sure.Location = new System.Drawing.Point(118, 39);
            this.gecen_sure.Multiline = true;
            this.gecen_sure.Name = "gecen_sure";
            this.gecen_sure.Size = new System.Drawing.Size(103, 24);
            this.gecen_sure.TabIndex = 8;
            this.gecen_sure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.Location = new System.Drawing.Point(6, 69);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(103, 32);
            this.label39.TabIndex = 10;
            this.label39.Text = "ORT. TUR SÜRESİ";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel21.ColumnCount = 2;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.08511F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.91489F));
            this.tableLayoutPanel21.Controls.Add(this.tableLayoutPanel22, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.tableLayoutPanel20, 0, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(227, 150);
            this.tableLayoutPanel21.TabIndex = 1;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel22.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel22.ColumnCount = 1;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Controls.Add(this.tork_limit, 0, 5);
            this.tableLayoutPanel22.Controls.Add(this.motor_temp_error, 0, 4);
            this.tableLayoutPanel22.Controls.Add(this.dc_bus_amper_error, 0, 3);
            this.tableLayoutPanel22.Controls.Add(this.zpc, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.pwm_enabled, 0, 1);
            this.tableLayoutPanel22.Controls.Add(this.dc_bus_voltage_error, 0, 2);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(157, 4);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 6;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.75978F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.64246F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(66, 142);
            this.tableLayoutPanel22.TabIndex = 41;
            // 
            // tork_limit
            // 
            this.tork_limit.AutoSize = true;
            this.tork_limit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tork_limit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tork_limit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tork_limit.Location = new System.Drawing.Point(6, 117);
            this.tork_limit.Name = "tork_limit";
            this.tork_limit.Size = new System.Drawing.Size(54, 22);
            this.tork_limit.TabIndex = 8;
            this.tork_limit.Text = " ";
            this.tork_limit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motor_temp_error
            // 
            this.motor_temp_error.AutoSize = true;
            this.motor_temp_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.motor_temp_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motor_temp_error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motor_temp_error.Location = new System.Drawing.Point(6, 95);
            this.motor_temp_error.Name = "motor_temp_error";
            this.motor_temp_error.Size = new System.Drawing.Size(54, 19);
            this.motor_temp_error.TabIndex = 5;
            this.motor_temp_error.Text = " ";
            this.motor_temp_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dc_bus_amper_error
            // 
            this.dc_bus_amper_error.AutoSize = true;
            this.dc_bus_amper_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.dc_bus_amper_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dc_bus_amper_error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dc_bus_amper_error.Location = new System.Drawing.Point(6, 72);
            this.dc_bus_amper_error.Name = "dc_bus_amper_error";
            this.dc_bus_amper_error.Size = new System.Drawing.Size(54, 20);
            this.dc_bus_amper_error.TabIndex = 2;
            this.dc_bus_amper_error.Text = " ";
            // 
            // zpc
            // 
            this.zpc.AutoSize = true;
            this.zpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.zpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zpc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zpc.Location = new System.Drawing.Point(6, 3);
            this.zpc.Name = "zpc";
            this.zpc.Size = new System.Drawing.Size(54, 20);
            this.zpc.TabIndex = 2;
            // 
            // pwm_enabled
            // 
            this.pwm_enabled.AutoSize = true;
            this.pwm_enabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.pwm_enabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwm_enabled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pwm_enabled.Location = new System.Drawing.Point(6, 26);
            this.pwm_enabled.Name = "pwm_enabled";
            this.pwm_enabled.Size = new System.Drawing.Size(54, 20);
            this.pwm_enabled.TabIndex = 5;
            this.pwm_enabled.Text = " ";
            this.pwm_enabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dc_bus_voltage_error
            // 
            this.dc_bus_voltage_error.AutoSize = true;
            this.dc_bus_voltage_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.dc_bus_voltage_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dc_bus_voltage_error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dc_bus_voltage_error.Location = new System.Drawing.Point(6, 49);
            this.dc_bus_voltage_error.Name = "dc_bus_voltage_error";
            this.dc_bus_voltage_error.Size = new System.Drawing.Size(54, 20);
            this.dc_bus_voltage_error.TabIndex = 8;
            this.dc_bus_voltage_error.Text = " ";
            this.dc_bus_voltage_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel20.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.36585F));
            this.tableLayoutPanel20.Controls.Add(this.label61, 0, 5);
            this.tableLayoutPanel20.Controls.Add(this.label60, 0, 4);
            this.tableLayoutPanel20.Controls.Add(this.label48, 0, 3);
            this.tableLayoutPanel20.Controls.Add(this.label50, 0, 2);
            this.tableLayoutPanel20.Controls.Add(this.label52, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.label54, 0, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 6;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(146, 142);
            this.tableLayoutPanel20.TabIndex = 39;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label61.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label61.Location = new System.Drawing.Point(6, 118);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(134, 21);
            this.label61.TabIndex = 17;
            this.label61.Text = "Tork Limit";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label60.Location = new System.Drawing.Point(6, 95);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(134, 20);
            this.label60.TabIndex = 16;
            this.label60.Text = "  MOTOR TEMP";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label48.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label48.Location = new System.Drawing.Point(6, 72);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(134, 20);
            this.label48.TabIndex = 15;
            this.label48.Text = "DC_BUS_I";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label50.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label50.Location = new System.Drawing.Point(6, 49);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(134, 20);
            this.label50.TabIndex = 14;
            this.label50.Text = "DC_BUS_VOLT";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label52.Location = new System.Drawing.Point(6, 26);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(134, 20);
            this.label52.TabIndex = 13;
            this.label52.Text = "PWM ENABLED";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label54.Location = new System.Drawing.Point(6, 3);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(134, 20);
            this.label54.TabIndex = 12;
            this.label54.Text = "ZPC";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13774F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86226F));
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel15, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel14, 0, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(5, 20);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.04546F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(452, 215);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel15.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.2212F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.7788F));
            this.tableLayoutPanel15.Controls.Add(this.torque, 1, 2);
            this.tableLayoutPanel15.Controls.Add(this.label29, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.label90, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.label88, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.id, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.iq, 1, 1);
            this.tableLayoutPanel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel15.Location = new System.Drawing.Point(229, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 3;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.95146F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.03883F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.49514F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(220, 209);
            this.tableLayoutPanel15.TabIndex = 51;
            // 
            // torque
            // 
            this.torque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.torque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.torque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.torque.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.torque.ForeColor = System.Drawing.Color.White;
            this.torque.Location = new System.Drawing.Point(127, 142);
            this.torque.Multiline = true;
            this.torque.Name = "torque";
            this.torque.ReadOnly = true;
            this.torque.Size = new System.Drawing.Size(87, 61);
            this.torque.TabIndex = 98;
            this.torque.Text = "NaN";
            this.torque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(6, 139);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(112, 67);
            this.label29.TabIndex = 98;
            this.label29.Text = "Torque";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label90.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label90.ForeColor = System.Drawing.Color.White;
            this.label90.Location = new System.Drawing.Point(6, 3);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(112, 68);
            this.label90.TabIndex = 54;
            this.label90.Text = "Id";
            this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label88.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label88.ForeColor = System.Drawing.Color.White;
            this.label88.Location = new System.Drawing.Point(6, 74);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(112, 62);
            this.label88.TabIndex = 3;
            this.label88.Text = "Iq";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(127, 6);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(87, 62);
            this.id.TabIndex = 10;
            this.id.Text = "NaN";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iq
            // 
            this.iq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.iq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iq.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iq.ForeColor = System.Drawing.Color.White;
            this.iq.Location = new System.Drawing.Point(127, 77);
            this.iq.Multiline = true;
            this.iq.Name = "iq";
            this.iq.ReadOnly = true;
            this.iq.Size = new System.Drawing.Size(87, 56);
            this.iq.TabIndex = 11;
            this.iq.Text = "NaN";
            this.iq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel14.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel14.Controls.Add(this.phase_b_cur, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.label68, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.label71, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.phase_a_cur, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.label73, 0, 3);
            this.tableLayoutPanel14.Controls.Add(this.dc_bus_cur, 1, 2);
            this.tableLayoutPanel14.Controls.Add(this.label80, 0, 2);
            this.tableLayoutPanel14.Controls.Add(this.dc_bus_volt, 1, 3);
            this.tableLayoutPanel14.Controls.Add(this.label31, 0, 4);
            this.tableLayoutPanel14.Controls.Add(this.motor_temp, 1, 4);
            this.tableLayoutPanel14.Controls.Add(this.label35, 0, 5);
            this.tableLayoutPanel14.Controls.Add(this.phase_a_rms, 1, 5);
            this.tableLayoutPanel14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableLayoutPanel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 6;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.5625F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.65625F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.78125F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(220, 209);
            this.tableLayoutPanel14.TabIndex = 51;
            // 
            // phase_b_cur
            // 
            this.phase_b_cur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.phase_b_cur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phase_b_cur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phase_b_cur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phase_b_cur.ForeColor = System.Drawing.Color.White;
            this.phase_b_cur.Location = new System.Drawing.Point(146, 43);
            this.phase_b_cur.Multiline = true;
            this.phase_b_cur.Name = "phase_b_cur";
            this.phase_b_cur.ReadOnly = true;
            this.phase_b_cur.Size = new System.Drawing.Size(68, 23);
            this.phase_b_cur.TabIndex = 10;
            this.phase_b_cur.Text = "NaN";
            this.phase_b_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label68.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(6, 40);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(131, 29);
            this.label68.TabIndex = 3;
            this.label68.Text = "PHASE B CUR";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label71.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label71.ForeColor = System.Drawing.Color.White;
            this.label71.Location = new System.Drawing.Point(6, 3);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(131, 34);
            this.label71.TabIndex = 0;
            this.label71.Text = "PHASE A CUR";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phase_a_cur
            // 
            this.phase_a_cur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.phase_a_cur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phase_a_cur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phase_a_cur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phase_a_cur.ForeColor = System.Drawing.Color.White;
            this.phase_a_cur.Location = new System.Drawing.Point(146, 6);
            this.phase_a_cur.Multiline = true;
            this.phase_a_cur.Name = "phase_a_cur";
            this.phase_a_cur.ReadOnly = true;
            this.phase_a_cur.Size = new System.Drawing.Size(68, 28);
            this.phase_a_cur.TabIndex = 9;
            this.phase_a_cur.Text = "NaN";
            this.phase_a_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label73.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label73.ForeColor = System.Drawing.Color.White;
            this.label73.Location = new System.Drawing.Point(6, 108);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(131, 32);
            this.label73.TabIndex = 8;
            this.label73.Text = "DC  BUS VOLT";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dc_bus_cur
            // 
            this.dc_bus_cur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.dc_bus_cur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dc_bus_cur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dc_bus_cur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dc_bus_cur.ForeColor = System.Drawing.Color.White;
            this.dc_bus_cur.Location = new System.Drawing.Point(146, 75);
            this.dc_bus_cur.Multiline = true;
            this.dc_bus_cur.Name = "dc_bus_cur";
            this.dc_bus_cur.ReadOnly = true;
            this.dc_bus_cur.Size = new System.Drawing.Size(68, 27);
            this.dc_bus_cur.TabIndex = 12;
            this.dc_bus_cur.Text = "NaN";
            this.dc_bus_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label80.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label80.ForeColor = System.Drawing.Color.White;
            this.label80.Location = new System.Drawing.Point(6, 72);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(131, 33);
            this.label80.TabIndex = 8;
            this.label80.Text = "DC  BUS CUR";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dc_bus_volt
            // 
            this.dc_bus_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.dc_bus_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dc_bus_volt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dc_bus_volt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dc_bus_volt.ForeColor = System.Drawing.Color.White;
            this.dc_bus_volt.Location = new System.Drawing.Point(146, 111);
            this.dc_bus_volt.Multiline = true;
            this.dc_bus_volt.Name = "dc_bus_volt";
            this.dc_bus_volt.ReadOnly = true;
            this.dc_bus_volt.Size = new System.Drawing.Size(68, 26);
            this.dc_bus_volt.TabIndex = 13;
            this.dc_bus_volt.Text = "NaN";
            this.dc_bus_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label31.Location = new System.Drawing.Point(6, 143);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 29);
            this.label31.TabIndex = 14;
            this.label31.Text = "MOTOR TEMP";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motor_temp
            // 
            this.motor_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.motor_temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.motor_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motor_temp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motor_temp.ForeColor = System.Drawing.SystemColors.Window;
            this.motor_temp.Location = new System.Drawing.Point(146, 146);
            this.motor_temp.Multiline = true;
            this.motor_temp.Name = "motor_temp";
            this.motor_temp.Size = new System.Drawing.Size(68, 23);
            this.motor_temp.TabIndex = 15;
            this.motor_temp.Text = "NaN";
            this.motor_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(6, 175);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(131, 31);
            this.label35.TabIndex = 16;
            this.label35.Text = "PHASE A RMS";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phase_a_rms
            // 
            this.phase_a_rms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.phase_a_rms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phase_a_rms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phase_a_rms.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phase_a_rms.ForeColor = System.Drawing.SystemColors.Window;
            this.phase_a_rms.Location = new System.Drawing.Point(146, 178);
            this.phase_a_rms.Multiline = true;
            this.phase_a_rms.Name = "phase_a_rms";
            this.phase_a_rms.Size = new System.Drawing.Size(68, 25);
            this.phase_a_rms.TabIndex = 17;
            this.phase_a_rms.Text = "NaN";
            this.phase_a_rms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 528);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMS - BMS";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08031F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91969F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel24, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel23, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(570, 500);
            this.tableLayoutPanel3.TabIndex = 50;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel24.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel24.ColumnCount = 2;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel24.Controls.Add(this.bms_fatal_error, 1, 5);
            this.tableLayoutPanel24.Controls.Add(this.label85, 0, 5);
            this.tableLayoutPanel24.Controls.Add(this.bms_over_cur_error, 1, 4);
            this.tableLayoutPanel24.Controls.Add(this.bms_comm_error, 1, 3);
            this.tableLayoutPanel24.Controls.Add(this.bms_temp_error, 1, 2);
            this.tableLayoutPanel24.Controls.Add(this.bms_low_volt_error, 1, 1);
            this.tableLayoutPanel24.Controls.Add(this.label86, 0, 4);
            this.tableLayoutPanel24.Controls.Add(this.label87, 0, 3);
            this.tableLayoutPanel24.Controls.Add(this.label89, 0, 2);
            this.tableLayoutPanel24.Controls.Add(this.label91, 0, 1);
            this.tableLayoutPanel24.Controls.Add(this.label92, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.bms_high_volt_error, 1, 0);
            this.tableLayoutPanel24.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel24.Controls.Add(this.ems_can_error, 1, 6);
            this.tableLayoutPanel24.Controls.Add(this.label44, 0, 7);
            this.tableLayoutPanel24.Controls.Add(this.bms_can_error, 1, 7);
            this.tableLayoutPanel24.Controls.Add(this.label45, 0, 8);
            this.tableLayoutPanel24.Controls.Add(this.driver_can_error, 1, 8);
            this.tableLayoutPanel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.tableLayoutPanel24.Location = new System.Drawing.Point(265, 230);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 9;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18497F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18497F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18497F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.76301F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.86047F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.12865F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(302, 266);
            this.tableLayoutPanel24.TabIndex = 98;
            // 
            // bms_fatal_error
            // 
            this.bms_fatal_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_fatal_error.Location = new System.Drawing.Point(234, 143);
            this.bms_fatal_error.Name = "bms_fatal_error";
            this.bms_fatal_error.Size = new System.Drawing.Size(62, 21);
            this.bms_fatal_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bms_fatal_error.TabIndex = 97;
            this.bms_fatal_error.TabStop = false;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label85.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label85.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label85.ForeColor = System.Drawing.Color.White;
            this.label85.Location = new System.Drawing.Point(6, 140);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(219, 27);
            this.label85.TabIndex = 14;
            this.label85.Text = "FATAL ERROR";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_over_cur_error
            // 
            this.bms_over_cur_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_over_cur_error.Location = new System.Drawing.Point(234, 115);
            this.bms_over_cur_error.Name = "bms_over_cur_error";
            this.bms_over_cur_error.Size = new System.Drawing.Size(62, 19);
            this.bms_over_cur_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bms_over_cur_error.TabIndex = 13;
            this.bms_over_cur_error.TabStop = false;
            // 
            // bms_comm_error
            // 
            this.bms_comm_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_comm_error.Location = new System.Drawing.Point(234, 87);
            this.bms_comm_error.Name = "bms_comm_error";
            this.bms_comm_error.Size = new System.Drawing.Size(62, 19);
            this.bms_comm_error.TabIndex = 12;
            this.bms_comm_error.TabStop = false;
            // 
            // bms_temp_error
            // 
            this.bms_temp_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_temp_error.Location = new System.Drawing.Point(234, 60);
            this.bms_temp_error.Name = "bms_temp_error";
            this.bms_temp_error.Size = new System.Drawing.Size(62, 18);
            this.bms_temp_error.TabIndex = 11;
            this.bms_temp_error.TabStop = false;
            // 
            // bms_low_volt_error
            // 
            this.bms_low_volt_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_low_volt_error.Location = new System.Drawing.Point(234, 33);
            this.bms_low_volt_error.Name = "bms_low_volt_error";
            this.bms_low_volt_error.Size = new System.Drawing.Size(62, 18);
            this.bms_low_volt_error.TabIndex = 10;
            this.bms_low_volt_error.TabStop = false;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label86.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label86.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label86.ForeColor = System.Drawing.Color.White;
            this.label86.Location = new System.Drawing.Point(6, 112);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(219, 25);
            this.label86.TabIndex = 8;
            this.label86.Text = "OVER CURRENT";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label87.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label87.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label87.ForeColor = System.Drawing.Color.White;
            this.label87.Location = new System.Drawing.Point(6, 84);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(219, 25);
            this.label87.TabIndex = 6;
            this.label87.Text = "COMM ERROR";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label89.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label89.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label89.ForeColor = System.Drawing.Color.White;
            this.label89.Location = new System.Drawing.Point(6, 57);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(219, 24);
            this.label89.TabIndex = 4;
            this.label89.Text = "TEMP ERROR";
            this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label91.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label91.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label91.ForeColor = System.Drawing.Color.White;
            this.label91.Location = new System.Drawing.Point(6, 30);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(219, 24);
            this.label91.TabIndex = 2;
            this.label91.Text = "LOW VOLT ERROR";
            this.label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label92.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label92.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label92.ForeColor = System.Drawing.Color.White;
            this.label92.Location = new System.Drawing.Point(6, 3);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(219, 24);
            this.label92.TabIndex = 0;
            this.label92.Text = "HIGH VOLT ERROR";
            this.label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_high_volt_error
            // 
            this.bms_high_volt_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_high_volt_error.Location = new System.Drawing.Point(234, 6);
            this.bms_high_volt_error.Name = "bms_high_volt_error";
            this.bms_high_volt_error.Size = new System.Drawing.Size(62, 18);
            this.bms_high_volt_error.TabIndex = 9;
            this.bms_high_volt_error.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 98;
            this.label1.Text = "EMS CAN ERROR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ems_can_error
            // 
            this.ems_can_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_can_error.Location = new System.Drawing.Point(234, 173);
            this.ems_can_error.Name = "ems_can_error";
            this.ems_can_error.Size = new System.Drawing.Size(62, 25);
            this.ems_can_error.TabIndex = 99;
            this.ems_can_error.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Location = new System.Drawing.Point(6, 204);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(219, 28);
            this.label44.TabIndex = 100;
            this.label44.Text = "BMS CAN ERROR";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_can_error
            // 
            this.bms_can_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_can_error.Location = new System.Drawing.Point(234, 207);
            this.bms_can_error.Name = "bms_can_error";
            this.bms_can_error.Size = new System.Drawing.Size(62, 22);
            this.bms_can_error.TabIndex = 101;
            this.bms_can_error.TabStop = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.Location = new System.Drawing.Point(6, 235);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(219, 28);
            this.label45.TabIndex = 102;
            this.label45.Text = "DRIVER CAN ERROR";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driver_can_error
            // 
            this.driver_can_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_can_error.Location = new System.Drawing.Point(234, 238);
            this.driver_can_error.Name = "driver_can_error";
            this.driver_can_error.Size = new System.Drawing.Size(62, 22);
            this.driver_can_error.TabIndex = 103;
            this.driver_can_error.TabStop = false;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel23.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel23.ColumnCount = 2;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.05534F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.94466F));
            this.tableLayoutPanel23.Controls.Add(this.bms_temp, 1, 6);
            this.tableLayoutPanel23.Controls.Add(this.bms_worst_cell_address, 1, 5);
            this.tableLayoutPanel23.Controls.Add(this.bms_worst_cell_voltage, 1, 4);
            this.tableLayoutPanel23.Controls.Add(this.bms_soc, 1, 3);
            this.tableLayoutPanel23.Controls.Add(this.bms_bat_cons, 1, 2);
            this.tableLayoutPanel23.Controls.Add(this.bms_bat_current, 1, 1);
            this.tableLayoutPanel23.Controls.Add(this.bms_bat_voltage, 1, 0);
            this.tableLayoutPanel23.Controls.Add(this.label77, 0, 1);
            this.tableLayoutPanel23.Controls.Add(this.label78, 0, 6);
            this.tableLayoutPanel23.Controls.Add(this.label79, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.label81, 0, 5);
            this.tableLayoutPanel23.Controls.Add(this.label82, 0, 2);
            this.tableLayoutPanel23.Controls.Add(this.label83, 0, 4);
            this.tableLayoutPanel23.Controls.Add(this.label84, 0, 3);
            this.tableLayoutPanel23.Controls.Add(this.label46, 0, 7);
            this.tableLayoutPanel23.Controls.Add(this.energy, 1, 7);
            this.tableLayoutPanel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel23.Location = new System.Drawing.Point(3, 230);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 8;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.7619F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.7931F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14141F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14141F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14141F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(256, 266);
            this.tableLayoutPanel23.TabIndex = 51;
            // 
            // bms_temp
            // 
            this.bms_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bms_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bms_temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_temp.ForeColor = System.Drawing.Color.White;
            this.bms_temp.Location = new System.Drawing.Point(162, 204);
            this.bms_temp.Multiline = true;
            this.bms_temp.Name = "bms_temp";
            this.bms_temp.Size = new System.Drawing.Size(88, 24);
            this.bms_temp.TabIndex = 103;
            this.bms_temp.Tag = "";
            this.bms_temp.Text = "NaN";
            this.bms_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bms_worst_cell_address
            // 
            this.bms_worst_cell_address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bms_worst_cell_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bms_worst_cell_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_worst_cell_address.ForeColor = System.Drawing.Color.White;
            this.bms_worst_cell_address.Location = new System.Drawing.Point(162, 171);
            this.bms_worst_cell_address.Multiline = true;
            this.bms_worst_cell_address.Name = "bms_worst_cell_address";
            this.bms_worst_cell_address.Size = new System.Drawing.Size(88, 24);
            this.bms_worst_cell_address.TabIndex = 102;
            this.bms_worst_cell_address.Tag = "";
            this.bms_worst_cell_address.Text = "NaN";
            this.bms_worst_cell_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bms_worst_cell_voltage
            // 
            this.bms_worst_cell_voltage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bms_worst_cell_voltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bms_worst_cell_voltage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_worst_cell_voltage.ForeColor = System.Drawing.Color.White;
            this.bms_worst_cell_voltage.Location = new System.Drawing.Point(162, 138);
            this.bms_worst_cell_voltage.Multiline = true;
            this.bms_worst_cell_voltage.Name = "bms_worst_cell_voltage";
            this.bms_worst_cell_voltage.Size = new System.Drawing.Size(88, 24);
            this.bms_worst_cell_voltage.TabIndex = 101;
            this.bms_worst_cell_voltage.Tag = "";
            this.bms_worst_cell_voltage.Text = "NaN";
            this.bms_worst_cell_voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bms_soc
            // 
            this.bms_soc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bms_soc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bms_soc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_soc.ForeColor = System.Drawing.Color.White;
            this.bms_soc.Location = new System.Drawing.Point(162, 105);
            this.bms_soc.Multiline = true;
            this.bms_soc.Name = "bms_soc";
            this.bms_soc.Size = new System.Drawing.Size(88, 24);
            this.bms_soc.TabIndex = 100;
            this.bms_soc.Tag = "";
            this.bms_soc.Text = "NaN";
            this.bms_soc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bms_bat_cons
            // 
            this.bms_bat_cons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bms_bat_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bms_bat_cons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_bat_cons.ForeColor = System.Drawing.Color.White;
            this.bms_bat_cons.Location = new System.Drawing.Point(162, 73);
            this.bms_bat_cons.Multiline = true;
            this.bms_bat_cons.Name = "bms_bat_cons";
            this.bms_bat_cons.Size = new System.Drawing.Size(88, 23);
            this.bms_bat_cons.TabIndex = 99;
            this.bms_bat_cons.Tag = "";
            this.bms_bat_cons.Text = "NaN";
            this.bms_bat_cons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bms_bat_current
            // 
            this.bms_bat_current.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bms_bat_current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bms_bat_current.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_bat_current.ForeColor = System.Drawing.Color.White;
            this.bms_bat_current.Location = new System.Drawing.Point(162, 39);
            this.bms_bat_current.Multiline = true;
            this.bms_bat_current.Name = "bms_bat_current";
            this.bms_bat_current.Size = new System.Drawing.Size(88, 25);
            this.bms_bat_current.TabIndex = 98;
            this.bms_bat_current.Tag = "";
            this.bms_bat_current.Text = "NaN";
            this.bms_bat_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bms_bat_voltage
            // 
            this.bms_bat_voltage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bms_bat_voltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bms_bat_voltage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_bat_voltage.ForeColor = System.Drawing.Color.White;
            this.bms_bat_voltage.Location = new System.Drawing.Point(162, 6);
            this.bms_bat_voltage.Multiline = true;
            this.bms_bat_voltage.Name = "bms_bat_voltage";
            this.bms_bat_voltage.Size = new System.Drawing.Size(88, 24);
            this.bms_bat_voltage.TabIndex = 97;
            this.bms_bat_voltage.Tag = "";
            this.bms_bat_voltage.Text = "NaN";
            this.bms_bat_voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label77.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(6, 36);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(147, 31);
            this.label77.TabIndex = 3;
            this.label77.Text = "BAT CUR";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label78.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label78.ForeColor = System.Drawing.Color.White;
            this.label78.Location = new System.Drawing.Point(6, 201);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(147, 30);
            this.label78.TabIndex = 9;
            this.label78.Text = "MAX CELL TEMP";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label79.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label79.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label79.ForeColor = System.Drawing.Color.White;
            this.label79.Location = new System.Drawing.Point(6, 3);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(147, 30);
            this.label79.TabIndex = 0;
            this.label79.Text = "BAT VOLT";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label81.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label81.ForeColor = System.Drawing.Color.White;
            this.label81.Location = new System.Drawing.Point(6, 168);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(147, 30);
            this.label81.TabIndex = 6;
            this.label81.Text = "WORST CELL ADDRESS";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label82
            // 
            this.label82.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label82.ForeColor = System.Drawing.Color.White;
            this.label82.Location = new System.Drawing.Point(6, 70);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(147, 29);
            this.label82.TabIndex = 6;
            this.label82.Text = "BAT CONS";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label83.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label83.ForeColor = System.Drawing.Color.White;
            this.label83.Location = new System.Drawing.Point(6, 135);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(147, 30);
            this.label83.TabIndex = 3;
            this.label83.Text = "WORST CELL VOLT";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label84.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label84.ForeColor = System.Drawing.Color.White;
            this.label84.Location = new System.Drawing.Point(6, 102);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(147, 30);
            this.label84.TabIndex = 0;
            this.label84.Text = "SOC";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(6, 234);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(147, 29);
            this.label46.TabIndex = 104;
            this.label46.Text = "ENERGY";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // energy
            // 
            this.energy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.energy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.energy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.energy.ForeColor = System.Drawing.Color.White;
            this.energy.Location = new System.Drawing.Point(162, 237);
            this.energy.Name = "energy";
            this.energy.Size = new System.Drawing.Size(88, 24);
            this.energy.TabIndex = 105;
            this.energy.Text = "NaN";
            this.energy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.74138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.25862F));
            this.tableLayoutPanel1.Controls.Add(this.ems_temp, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ems_soc, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ems_penalty, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ems_fc_lt_cons, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ems_out_cons, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ems_fc_cons, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ems_bat_cons, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30275F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.76147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.59633F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 221);
            this.tableLayoutPanel1.TabIndex = 50;
            // 
            // ems_temp
            // 
            this.ems_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_temp.ForeColor = System.Drawing.Color.White;
            this.ems_temp.Location = new System.Drawing.Point(144, 189);
            this.ems_temp.Multiline = true;
            this.ems_temp.Name = "ems_temp";
            this.ems_temp.Size = new System.Drawing.Size(106, 26);
            this.ems_temp.TabIndex = 103;
            this.ems_temp.Tag = "";
            this.ems_temp.Text = "NaN";
            this.ems_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(6, 186);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(129, 32);
            this.label25.TabIndex = 103;
            this.label25.Text = "TEMPERATURE";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ems_soc
            // 
            this.ems_soc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_soc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_soc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_soc.ForeColor = System.Drawing.Color.White;
            this.ems_soc.Location = new System.Drawing.Point(144, 158);
            this.ems_soc.Multiline = true;
            this.ems_soc.Name = "ems_soc";
            this.ems_soc.Size = new System.Drawing.Size(106, 22);
            this.ems_soc.TabIndex = 102;
            this.ems_soc.Tag = "";
            this.ems_soc.Text = "NaN";
            this.ems_soc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_penalty
            // 
            this.ems_penalty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_penalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_penalty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_penalty.ForeColor = System.Drawing.Color.White;
            this.ems_penalty.Location = new System.Drawing.Point(144, 127);
            this.ems_penalty.Multiline = true;
            this.ems_penalty.Name = "ems_penalty";
            this.ems_penalty.Size = new System.Drawing.Size(106, 22);
            this.ems_penalty.TabIndex = 101;
            this.ems_penalty.Tag = "";
            this.ems_penalty.Text = "NaN";
            this.ems_penalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_fc_lt_cons
            // 
            this.ems_fc_lt_cons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_fc_lt_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_fc_lt_cons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_fc_lt_cons.ForeColor = System.Drawing.Color.White;
            this.ems_fc_lt_cons.Location = new System.Drawing.Point(144, 97);
            this.ems_fc_lt_cons.Multiline = true;
            this.ems_fc_lt_cons.Name = "ems_fc_lt_cons";
            this.ems_fc_lt_cons.Size = new System.Drawing.Size(106, 21);
            this.ems_fc_lt_cons.TabIndex = 100;
            this.ems_fc_lt_cons.Tag = "";
            this.ems_fc_lt_cons.Text = "NaN";
            this.ems_fc_lt_cons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_out_cons
            // 
            this.ems_out_cons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_out_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_out_cons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_out_cons.ForeColor = System.Drawing.Color.White;
            this.ems_out_cons.Location = new System.Drawing.Point(144, 68);
            this.ems_out_cons.Multiline = true;
            this.ems_out_cons.Name = "ems_out_cons";
            this.ems_out_cons.Size = new System.Drawing.Size(106, 20);
            this.ems_out_cons.TabIndex = 99;
            this.ems_out_cons.Tag = "";
            this.ems_out_cons.Text = "NaN";
            this.ems_out_cons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_fc_cons
            // 
            this.ems_fc_cons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_fc_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_fc_cons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_fc_cons.ForeColor = System.Drawing.Color.White;
            this.ems_fc_cons.Location = new System.Drawing.Point(144, 37);
            this.ems_fc_cons.Multiline = true;
            this.ems_fc_cons.Name = "ems_fc_cons";
            this.ems_fc_cons.Size = new System.Drawing.Size(106, 22);
            this.ems_fc_cons.TabIndex = 98;
            this.ems_fc_cons.Tag = "";
            this.ems_fc_cons.Text = "NaN";
            this.ems_fc_cons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_bat_cons
            // 
            this.ems_bat_cons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_bat_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_bat_cons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_bat_cons.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_bat_cons.ForeColor = System.Drawing.Color.White;
            this.ems_bat_cons.Location = new System.Drawing.Point(144, 6);
            this.ems_bat_cons.Multiline = true;
            this.ems_bat_cons.Name = "ems_bat_cons";
            this.ems_bat_cons.Size = new System.Drawing.Size(106, 22);
            this.ems_bat_cons.TabIndex = 97;
            this.ems_bat_cons.Tag = "";
            this.ems_bat_cons.Text = "NaN";
            this.ems_bat_cons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "FC CONS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "BAT CONS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "SHARING";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 26);
            this.label16.TabIndex = 6;
            this.label16.Text = "OUT CONS";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(6, 124);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(129, 28);
            this.label22.TabIndex = 3;
            this.label22.Text = "PENALTY";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(6, 94);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(129, 27);
            this.label24.TabIndex = 0;
            this.label24.Text = "FC LT CONS";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.64865F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.35135F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel7.Controls.Add(this.ems_out_current, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.ems_fc_current, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.ems_bat_current, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.ems_out_voltage, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.ems_fc_voltage, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.ems_bat_volt, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label57, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label59, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label70, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.label55, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label72, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.label74, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.ems_bat_volt_error, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.ems_fc_voltage_error, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.ems_out_voltage_error, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.ems_bat_current_error, 2, 3);
            this.tableLayoutPanel7.Controls.Add(this.ems_fc_current_error, 2, 4);
            this.tableLayoutPanel7.Controls.Add(this.out_current_error, 2, 5);
            this.tableLayoutPanel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(265, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 6;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(302, 221);
            this.tableLayoutPanel7.TabIndex = 49;
            // 
            // ems_out_current
            // 
            this.ems_out_current.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_out_current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_out_current.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_out_current.ForeColor = System.Drawing.Color.White;
            this.ems_out_current.Location = new System.Drawing.Point(140, 186);
            this.ems_out_current.Multiline = true;
            this.ems_out_current.Name = "ems_out_current";
            this.ems_out_current.Size = new System.Drawing.Size(54, 29);
            this.ems_out_current.TabIndex = 102;
            this.ems_out_current.Tag = "";
            this.ems_out_current.Text = "NaN";
            this.ems_out_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_fc_current
            // 
            this.ems_fc_current.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_fc_current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_fc_current.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_fc_current.ForeColor = System.Drawing.Color.White;
            this.ems_fc_current.Location = new System.Drawing.Point(140, 150);
            this.ems_fc_current.Multiline = true;
            this.ems_fc_current.Name = "ems_fc_current";
            this.ems_fc_current.Size = new System.Drawing.Size(54, 27);
            this.ems_fc_current.TabIndex = 101;
            this.ems_fc_current.Tag = "";
            this.ems_fc_current.Text = "NaN";
            this.ems_fc_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_bat_current
            // 
            this.ems_bat_current.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_bat_current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_bat_current.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_bat_current.ForeColor = System.Drawing.Color.White;
            this.ems_bat_current.Location = new System.Drawing.Point(140, 114);
            this.ems_bat_current.Multiline = true;
            this.ems_bat_current.Name = "ems_bat_current";
            this.ems_bat_current.Size = new System.Drawing.Size(54, 27);
            this.ems_bat_current.TabIndex = 100;
            this.ems_bat_current.Tag = "";
            this.ems_bat_current.Text = "NaN";
            this.ems_bat_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_out_voltage
            // 
            this.ems_out_voltage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_out_voltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_out_voltage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_out_voltage.ForeColor = System.Drawing.Color.White;
            this.ems_out_voltage.Location = new System.Drawing.Point(140, 78);
            this.ems_out_voltage.Multiline = true;
            this.ems_out_voltage.Name = "ems_out_voltage";
            this.ems_out_voltage.Size = new System.Drawing.Size(54, 27);
            this.ems_out_voltage.TabIndex = 99;
            this.ems_out_voltage.Tag = "";
            this.ems_out_voltage.Text = "NaN";
            this.ems_out_voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_fc_voltage
            // 
            this.ems_fc_voltage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_fc_voltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_fc_voltage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_fc_voltage.ForeColor = System.Drawing.Color.White;
            this.ems_fc_voltage.Location = new System.Drawing.Point(140, 42);
            this.ems_fc_voltage.Multiline = true;
            this.ems_fc_voltage.Name = "ems_fc_voltage";
            this.ems_fc_voltage.Size = new System.Drawing.Size(54, 27);
            this.ems_fc_voltage.TabIndex = 98;
            this.ems_fc_voltage.Tag = "";
            this.ems_fc_voltage.Text = "NaN";
            this.ems_fc_voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_bat_volt
            // 
            this.ems_bat_volt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ems_bat_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ems_bat_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_bat_volt.ForeColor = System.Drawing.Color.White;
            this.ems_bat_volt.Location = new System.Drawing.Point(140, 6);
            this.ems_bat_volt.Multiline = true;
            this.ems_bat_volt.Name = "ems_bat_volt";
            this.ems_bat_volt.Size = new System.Drawing.Size(54, 27);
            this.ems_bat_volt.TabIndex = 97;
            this.ems_bat_volt.Tag = "";
            this.ems_bat_volt.Text = "NaN";
            this.ems_bat_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label57.ForeColor = System.Drawing.Color.White;
            this.label57.Location = new System.Drawing.Point(6, 39);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(125, 33);
            this.label57.TabIndex = 3;
            this.label57.Text = "FC VOLTAGE";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(6, 3);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(125, 33);
            this.label59.TabIndex = 0;
            this.label59.Text = "BAT VOLTAGE";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label70.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label70.ForeColor = System.Drawing.Color.White;
            this.label70.Location = new System.Drawing.Point(6, 183);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(125, 35);
            this.label70.TabIndex = 6;
            this.label70.Text = "OUT CURRENT";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(6, 75);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(125, 33);
            this.label55.TabIndex = 6;
            this.label55.Text = "OUT VOLTAGE";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label72.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(6, 147);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(125, 33);
            this.label72.TabIndex = 3;
            this.label72.Text = "FC CURRENT";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label74.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label74.ForeColor = System.Drawing.Color.White;
            this.label74.Location = new System.Drawing.Point(6, 111);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(125, 33);
            this.label74.TabIndex = 0;
            this.label74.Text = "BAT CURRENT";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ems_bat_volt_error
            // 
            this.ems_bat_volt_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_bat_volt_error.Location = new System.Drawing.Point(203, 6);
            this.ems_bat_volt_error.Name = "ems_bat_volt_error";
            this.ems_bat_volt_error.Size = new System.Drawing.Size(93, 27);
            this.ems_bat_volt_error.TabIndex = 103;
            this.ems_bat_volt_error.TabStop = false;
            // 
            // ems_fc_voltage_error
            // 
            this.ems_fc_voltage_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_fc_voltage_error.Location = new System.Drawing.Point(203, 42);
            this.ems_fc_voltage_error.Name = "ems_fc_voltage_error";
            this.ems_fc_voltage_error.Size = new System.Drawing.Size(93, 27);
            this.ems_fc_voltage_error.TabIndex = 104;
            this.ems_fc_voltage_error.TabStop = false;
            // 
            // ems_out_voltage_error
            // 
            this.ems_out_voltage_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_out_voltage_error.Location = new System.Drawing.Point(203, 78);
            this.ems_out_voltage_error.Name = "ems_out_voltage_error";
            this.ems_out_voltage_error.Size = new System.Drawing.Size(93, 27);
            this.ems_out_voltage_error.TabIndex = 105;
            this.ems_out_voltage_error.TabStop = false;
            // 
            // ems_bat_current_error
            // 
            this.ems_bat_current_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_bat_current_error.Location = new System.Drawing.Point(203, 114);
            this.ems_bat_current_error.Name = "ems_bat_current_error";
            this.ems_bat_current_error.Size = new System.Drawing.Size(93, 27);
            this.ems_bat_current_error.TabIndex = 106;
            this.ems_bat_current_error.TabStop = false;
            // 
            // ems_fc_current_error
            // 
            this.ems_fc_current_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_fc_current_error.Location = new System.Drawing.Point(203, 150);
            this.ems_fc_current_error.Name = "ems_fc_current_error";
            this.ems_fc_current_error.Size = new System.Drawing.Size(93, 27);
            this.ems_fc_current_error.TabIndex = 107;
            this.ems_fc_current_error.TabStop = false;
            // 
            // out_current_error
            // 
            this.out_current_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out_current_error.Location = new System.Drawing.Point(203, 186);
            this.out_current_error.Name = "out_current_error";
            this.out_current_error.Size = new System.Drawing.Size(93, 29);
            this.out_current_error.TabIndex = 108;
            this.out_current_error.TabStop = false;
            // 
            // angle_gauge
            // 
            this.angle_gauge.AnimationSpeed = 0.6F;
            this.angle_gauge.BaseColor = System.Drawing.Color.Transparent;
            this.angle_gauge.Controls.Add(this.sektor);
            this.angle_gauge.ForeColor = System.Drawing.Color.White;
            this.angle_gauge.IdleColor = System.Drawing.Color.Gainsboro;
            this.angle_gauge.IdleOffset = 10;
            this.angle_gauge.IdleThickness = 15;
            this.angle_gauge.Image = null;
            this.angle_gauge.ImageSize = new System.Drawing.Size(52, 52);
            this.angle_gauge.Location = new System.Drawing.Point(1769, 37);
            this.angle_gauge.Maximum = 360;
            this.angle_gauge.Name = "angle_gauge";
            this.angle_gauge.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.angle_gauge.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.angle_gauge.ProgressOffset = 10;
            this.angle_gauge.ProgressThickness = 15;
            this.angle_gauge.Size = new System.Drawing.Size(120, 120);
            this.angle_gauge.TabIndex = 96;
            // 
            // sektor
            // 
            this.sektor.AutoSize = true;
            this.sektor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sektor.ForeColor = System.Drawing.Color.White;
            this.sektor.Location = new System.Drawing.Point(47, 51);
            this.sektor.Name = "sektor";
            this.sektor.Size = new System.Drawing.Size(27, 21);
            this.sektor.TabIndex = 7;
            this.sektor.Text = "S0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1752, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 19);
            this.label13.TabIndex = 95;
            this.label13.Text = "GPS";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.77305F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.22695F));
            this.tableLayoutPanel11.Controls.Add(this.uydu_sayisi, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.label51, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.label63, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.gps_verim, 1, 1);
            this.tableLayoutPanel11.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(1747, 175);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(142, 77);
            this.tableLayoutPanel11.TabIndex = 94;
            // 
            // uydu_sayisi
            // 
            this.uydu_sayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.uydu_sayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uydu_sayisi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uydu_sayisi.ForeColor = System.Drawing.Color.White;
            this.uydu_sayisi.Location = new System.Drawing.Point(6, 41);
            this.uydu_sayisi.Multiline = true;
            this.uydu_sayisi.Name = "uydu_sayisi";
            this.uydu_sayisi.Size = new System.Drawing.Size(62, 27);
            this.uydu_sayisi.TabIndex = 98;
            this.uydu_sayisi.Text = "NaN";
            this.uydu_sayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label51.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(6, 3);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(62, 32);
            this.label51.TabIndex = 9;
            this.label51.Text = "UYDU SAYISI";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label63.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(77, 3);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(59, 32);
            this.label63.TabIndex = 11;
            this.label63.Text = "VERİM";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gps_verim
            // 
            this.gps_verim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.gps_verim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gps_verim.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gps_verim.ForeColor = System.Drawing.Color.White;
            this.gps_verim.Location = new System.Drawing.Point(77, 41);
            this.gps_verim.Multiline = true;
            this.gps_verim.Name = "gps_verim";
            this.gps_verim.Size = new System.Drawing.Size(59, 27);
            this.gps_verim.TabIndex = 99;
            this.gps_verim.Text = "NaN";
            this.gps_verim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.82353F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Controls.Add(this.mqtt_toplam_paket, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.mqtt_solved_paket, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.mqtt_verim, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.label41, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label42, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label43, 2, 0);
            this.tableLayoutPanel10.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(1527, 175);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(220, 77);
            this.tableLayoutPanel10.TabIndex = 91;
            // 
            // mqtt_toplam_paket
            // 
            this.mqtt_toplam_paket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.mqtt_toplam_paket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mqtt_toplam_paket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mqtt_toplam_paket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mqtt_toplam_paket.ForeColor = System.Drawing.Color.White;
            this.mqtt_toplam_paket.Location = new System.Drawing.Point(6, 43);
            this.mqtt_toplam_paket.Multiline = true;
            this.mqtt_toplam_paket.Name = "mqtt_toplam_paket";
            this.mqtt_toplam_paket.ReadOnly = true;
            this.mqtt_toplam_paket.Size = new System.Drawing.Size(62, 28);
            this.mqtt_toplam_paket.TabIndex = 21;
            this.mqtt_toplam_paket.Text = "NaN";
            this.mqtt_toplam_paket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mqtt_solved_paket
            // 
            this.mqtt_solved_paket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.mqtt_solved_paket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mqtt_solved_paket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mqtt_solved_paket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mqtt_solved_paket.ForeColor = System.Drawing.Color.White;
            this.mqtt_solved_paket.Location = new System.Drawing.Point(77, 43);
            this.mqtt_solved_paket.Multiline = true;
            this.mqtt_solved_paket.Name = "mqtt_solved_paket";
            this.mqtt_solved_paket.ReadOnly = true;
            this.mqtt_solved_paket.Size = new System.Drawing.Size(64, 28);
            this.mqtt_solved_paket.TabIndex = 20;
            this.mqtt_solved_paket.Text = "NaN";
            this.mqtt_solved_paket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mqtt_verim
            // 
            this.mqtt_verim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.mqtt_verim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mqtt_verim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mqtt_verim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mqtt_verim.ForeColor = System.Drawing.Color.White;
            this.mqtt_verim.Location = new System.Drawing.Point(150, 43);
            this.mqtt_verim.Multiline = true;
            this.mqtt_verim.Name = "mqtt_verim";
            this.mqtt_verim.ReadOnly = true;
            this.mqtt_verim.Size = new System.Drawing.Size(64, 28);
            this.mqtt_verim.TabIndex = 19;
            this.mqtt_verim.Text = "NaN";
            this.mqtt_verim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(6, 3);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(62, 34);
            this.label41.TabIndex = 5;
            this.label41.Text = "TOPLAM PAKET";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label42.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(77, 3);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(64, 34);
            this.label42.TabIndex = 6;
            this.label42.Text = "ÇÖZÜLEN PAKET";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(150, 3);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(64, 34);
            this.label43.TabIndex = 7;
            this.label43.Text = "VERİM";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(1529, 157);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(125, 19);
            this.label37.TabIndex = 93;
            this.label37.Text = "MQTT KONTROL";
            // 
            // gsm_yenileme
            // 
            this.gsm_yenileme.AutoSize = true;
            this.gsm_yenileme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gsm_yenileme.ForeColor = System.Drawing.Color.White;
            this.gsm_yenileme.Location = new System.Drawing.Point(1677, 157);
            this.gsm_yenileme.Name = "gsm_yenileme";
            this.gsm_yenileme.Size = new System.Drawing.Size(54, 19);
            this.gsm_yenileme.TabIndex = 79;
            this.gsm_yenileme.Text = "Delay";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel9.ColumnCount = 6;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.Controls.Add(this.verim, 5, 1);
            this.tableLayoutPanel9.Controls.Add(this.cozulen_paket, 4, 1);
            this.tableLayoutPanel9.Controls.Add(this.crc_hatali, 3, 1);
            this.tableLayoutPanel9.Controls.Add(this.baslik_hatali, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.gelen_bayt, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.secilen_port, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label30, 5, 0);
            this.tableLayoutPanel9.Controls.Add(this.label20, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.label19, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.label18, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(1058, 175);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(469, 77);
            this.tableLayoutPanel9.TabIndex = 90;
            // 
            // verim
            // 
            this.verim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.verim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verim.ForeColor = System.Drawing.Color.White;
            this.verim.Location = new System.Drawing.Point(391, 43);
            this.verim.Multiline = true;
            this.verim.Name = "verim";
            this.verim.ReadOnly = true;
            this.verim.Size = new System.Drawing.Size(72, 28);
            this.verim.TabIndex = 18;
            this.verim.Text = "NaN";
            this.verim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cozulen_paket
            // 
            this.cozulen_paket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.cozulen_paket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cozulen_paket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cozulen_paket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cozulen_paket.ForeColor = System.Drawing.Color.White;
            this.cozulen_paket.Location = new System.Drawing.Point(314, 43);
            this.cozulen_paket.Multiline = true;
            this.cozulen_paket.Name = "cozulen_paket";
            this.cozulen_paket.ReadOnly = true;
            this.cozulen_paket.Size = new System.Drawing.Size(68, 28);
            this.cozulen_paket.TabIndex = 17;
            this.cozulen_paket.Text = "NaN";
            this.cozulen_paket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // crc_hatali
            // 
            this.crc_hatali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.crc_hatali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crc_hatali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crc_hatali.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.crc_hatali.ForeColor = System.Drawing.Color.White;
            this.crc_hatali.Location = new System.Drawing.Point(237, 43);
            this.crc_hatali.Multiline = true;
            this.crc_hatali.Name = "crc_hatali";
            this.crc_hatali.ReadOnly = true;
            this.crc_hatali.Size = new System.Drawing.Size(68, 28);
            this.crc_hatali.TabIndex = 16;
            this.crc_hatali.Text = "NaN";
            this.crc_hatali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baslik_hatali
            // 
            this.baslik_hatali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.baslik_hatali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.baslik_hatali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baslik_hatali.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik_hatali.ForeColor = System.Drawing.Color.White;
            this.baslik_hatali.Location = new System.Drawing.Point(160, 43);
            this.baslik_hatali.Multiline = true;
            this.baslik_hatali.Name = "baslik_hatali";
            this.baslik_hatali.ReadOnly = true;
            this.baslik_hatali.Size = new System.Drawing.Size(68, 28);
            this.baslik_hatali.TabIndex = 15;
            this.baslik_hatali.Text = "NaN";
            this.baslik_hatali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gelen_bayt
            // 
            this.gelen_bayt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.gelen_bayt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gelen_bayt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gelen_bayt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelen_bayt.ForeColor = System.Drawing.Color.White;
            this.gelen_bayt.Location = new System.Drawing.Point(83, 43);
            this.gelen_bayt.Multiline = true;
            this.gelen_bayt.Name = "gelen_bayt";
            this.gelen_bayt.ReadOnly = true;
            this.gelen_bayt.Size = new System.Drawing.Size(68, 28);
            this.gelen_bayt.TabIndex = 14;
            this.gelen_bayt.Text = "NaN";
            this.gelen_bayt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secilen_port
            // 
            this.secilen_port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.secilen_port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secilen_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secilen_port.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secilen_port.ForeColor = System.Drawing.Color.White;
            this.secilen_port.Location = new System.Drawing.Point(6, 43);
            this.secilen_port.Multiline = true;
            this.secilen_port.Name = "secilen_port";
            this.secilen_port.ReadOnly = true;
            this.secilen_port.Size = new System.Drawing.Size(68, 28);
            this.secilen_port.TabIndex = 13;
            this.secilen_port.Text = "NaN";
            this.secilen_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(391, 3);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 34);
            this.label30.TabIndex = 5;
            this.label30.Text = "VERİM";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(314, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 34);
            this.label20.TabIndex = 4;
            this.label20.Text = "ÇÖZÜLEN PAKET";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(237, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 34);
            this.label19.TabIndex = 3;
            this.label19.Text = "CRC HATALI";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(160, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 34);
            this.label18.TabIndex = 2;
            this.label18.Text = "BAŞLIK HATALI";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(83, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 34);
            this.label6.TabIndex = 1;
            this.label6.Text = "GELEN BYTE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "PORT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(1061, 157);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(101, 19);
            this.label34.TabIndex = 92;
            this.label34.Text = "RF KONTROL";
            // 
            // history_displayer
            // 
            this.history_displayer.Location = new System.Drawing.Point(3, 696);
            this.history_displayer.Name = "history_displayer";
            this.history_displayer.Size = new System.Drawing.Size(1052, 15);
            this.history_displayer.TabIndex = 80;
            this.history_displayer.ValueChanged += new System.EventHandler(this.history_displayer_ValueChanged);
            // 
            // kalanyol_bar
            // 
            this.kalanyol_bar.BorderColor = System.Drawing.Color.Black;
            this.kalanyol_bar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.kalanyol_bar.IdleColor = System.Drawing.Color.Gainsboro;
            this.kalanyol_bar.Location = new System.Drawing.Point(1585, 134);
            this.kalanyol_bar.Name = "kalanyol_bar";
            this.kalanyol_bar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.kalanyol_bar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.kalanyol_bar.Size = new System.Drawing.Size(144, 16);
            this.kalanyol_bar.TabIndex = 78;
            this.kalanyol_bar.Value = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1199, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "km/h";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1156, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 74;
            this.label12.Text = "Hedef Hız";
            // 
            // hedef_hiz
            // 
            this.hedef_hiz.AutoSize = true;
            this.hedef_hiz.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hedef_hiz.ForeColor = System.Drawing.Color.White;
            this.hedef_hiz.Location = new System.Drawing.Point(1159, 97);
            this.hedef_hiz.Name = "hedef_hiz";
            this.hedef_hiz.Size = new System.Drawing.Size(49, 32);
            this.hedef_hiz.TabIndex = 75;
            this.hedef_hiz.Text = "30";
            // 
            // hedefhiz_gauge
            // 
            this.hedefhiz_gauge.BackThickness = 20;
            this.hedefhiz_gauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.hedefhiz_gauge.ForeColor = System.Drawing.Color.White;
            this.hedefhiz_gauge.IdleColor = System.Drawing.Color.Gainsboro;
            this.hedefhiz_gauge.Location = new System.Drawing.Point(1112, 55);
            this.hedefhiz_gauge.Margin = new System.Windows.Forms.Padding(6);
            this.hedefhiz_gauge.MaximumColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.hedefhiz_gauge.MinimumColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.hedefhiz_gauge.Name = "hedefhiz_gauge";
            this.hedefhiz_gauge.ShowText = false;
            this.hedefhiz_gauge.Size = new System.Drawing.Size(164, 67);
            this.hedefhiz_gauge.TabIndex = 77;
            this.hedefhiz_gauge.Thickness = 20;
            this.hedefhiz_gauge.Value = 50;
            // 
            // kalanyol_gps
            // 
            this.kalanyol_gps.BorderColor = System.Drawing.Color.Black;
            this.kalanyol_gps.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.kalanyol_gps.IdleColor = System.Drawing.Color.Gainsboro;
            this.kalanyol_gps.Location = new System.Drawing.Point(1365, 134);
            this.kalanyol_gps.Name = "kalanyol_gps";
            this.kalanyol_gps.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.kalanyol_gps.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.kalanyol_gps.Size = new System.Drawing.Size(144, 16);
            this.kalanyol_gps.TabIndex = 73;
            this.kalanyol_gps.Value = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1441, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "km/h";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(1403, 39);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 21);
            this.label28.TabIndex = 68;
            this.label28.Text = "GPS Hız";
            // 
            // anlik_hiz_gps
            // 
            this.anlik_hiz_gps.AutoSize = true;
            this.anlik_hiz_gps.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anlik_hiz_gps.ForeColor = System.Drawing.Color.White;
            this.anlik_hiz_gps.Location = new System.Drawing.Point(1401, 97);
            this.anlik_hiz_gps.Name = "anlik_hiz_gps";
            this.anlik_hiz_gps.Size = new System.Drawing.Size(49, 32);
            this.anlik_hiz_gps.TabIndex = 69;
            this.anlik_hiz_gps.Text = "30";
            // 
            // gpshiz_gauge
            // 
            this.gpshiz_gauge.BackThickness = 20;
            this.gpshiz_gauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.gpshiz_gauge.ForeColor = System.Drawing.Color.White;
            this.gpshiz_gauge.IdleColor = System.Drawing.Color.Gainsboro;
            this.gpshiz_gauge.Location = new System.Drawing.Point(1354, 55);
            this.gpshiz_gauge.Margin = new System.Windows.Forms.Padding(6);
            this.gpshiz_gauge.MaximumColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.gpshiz_gauge.MinimumColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.gpshiz_gauge.Name = "gpshiz_gauge";
            this.gpshiz_gauge.ShowText = false;
            this.gpshiz_gauge.Size = new System.Drawing.Size(164, 67);
            this.gpshiz_gauge.TabIndex = 71;
            this.gpshiz_gauge.Thickness = 20;
            this.gpshiz_gauge.Value = 50;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(1544, 134);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 16);
            this.label36.TabIndex = 66;
            this.label36.Text = "YOL";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yol_gps
            // 
            this.yol_gps.AutoSize = true;
            this.yol_gps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yol_gps.ForeColor = System.Drawing.Color.White;
            this.yol_gps.Location = new System.Drawing.Point(1294, 134);
            this.yol_gps.Name = "yol_gps";
            this.yol_gps.Size = new System.Drawing.Size(65, 16);
            this.yol_gps.TabIndex = 65;
            this.yol_gps.Text = "GPS YOL";
            this.yol_gps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(3, 714);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 55;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 273);
            this.dataGridView1.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1663, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "km/h";
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.ContextMenuStrip = this.gmap_sag;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(1058, 256);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(835, 756);
            this.gmap.TabIndex = 54;
            this.gmap.Zoom = 0D;
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yarışToolStripMenuItem,
            this.gSMToolStripMenuItem,
            this.xbeeToolStripMenuItem,
            this.kayıtToolStripMenuItem,
            this.eklentilerToolStripMenuItem,
            this.turAtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1890, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yarışToolStripMenuItem
            // 
            this.yarışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlatToolStripMenuItem,
            this.bitirToolStripMenuItem});
            this.yarışToolStripMenuItem.Name = "yarışToolStripMenuItem";
            this.yarışToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.yarışToolStripMenuItem.Text = "Yarış ";
            // 
            // başlatToolStripMenuItem
            // 
            this.başlatToolStripMenuItem.Name = "başlatToolStripMenuItem";
            this.başlatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.başlatToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.başlatToolStripMenuItem.Text = "Başlat";
            this.başlatToolStripMenuItem.Click += new System.EventHandler(this.başlatToolStripMenuItem_Click);
            // 
            // bitirToolStripMenuItem
            // 
            this.bitirToolStripMenuItem.Name = "bitirToolStripMenuItem";
            this.bitirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.bitirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.bitirToolStripMenuItem.Text = "Bitir";
            this.bitirToolStripMenuItem.Click += new System.EventHandler(this.bitirToolStripMenuItem_Click);
            // 
            // gSMToolStripMenuItem
            // 
            this.gSMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bağlanToolStripMenuItem,
            this.bağlantıyıKesToolStripMenuItem});
            this.gSMToolStripMenuItem.Name = "gSMToolStripMenuItem";
            this.gSMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gSMToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.gSMToolStripMenuItem.Text = "GSM";
            // 
            // bağlanToolStripMenuItem
            // 
            this.bağlanToolStripMenuItem.Name = "bağlanToolStripMenuItem";
            this.bağlanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.bağlanToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.bağlanToolStripMenuItem.Text = "Bağlan";
            this.bağlanToolStripMenuItem.Click += new System.EventHandler(this.bağlanToolStripMenuItem_Click);
            // 
            // bağlantıyıKesToolStripMenuItem
            // 
            this.bağlantıyıKesToolStripMenuItem.Name = "bağlantıyıKesToolStripMenuItem";
            this.bağlantıyıKesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.bağlantıyıKesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.bağlantıyıKesToolStripMenuItem.Text = "Bağlantıyı kes";
            this.bağlantıyıKesToolStripMenuItem.Click += new System.EventHandler(this.bağlantıyıKesToolStripMenuItem_Click);
            // 
            // xbeeToolStripMenuItem
            // 
            this.xbeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.bağlanToolStripMenuItem1,
            this.bağlantıyıKesToolStripMenuItem1,
            this.gsmResetleToolStripMenuItem});
            this.xbeeToolStripMenuItem.Name = "xbeeToolStripMenuItem";
            this.xbeeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.xbeeToolStripMenuItem.Text = "Xbee";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.portToolStripMenuItem.Text = "Port";
            this.portToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.portToolStripMenuItem_DropDownItemClicked);
            this.portToolStripMenuItem.MouseHover += new System.EventHandler(this.portToolStripMenuItem_MouseHover);
            // 
            // bağlanToolStripMenuItem1
            // 
            this.bağlanToolStripMenuItem1.Name = "bağlanToolStripMenuItem1";
            this.bağlanToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.bağlanToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.bağlanToolStripMenuItem1.Text = "Bağlan";
            this.bağlanToolStripMenuItem1.Click += new System.EventHandler(this.bağlanToolStripMenuItem1_Click);
            // 
            // bağlantıyıKesToolStripMenuItem1
            // 
            this.bağlantıyıKesToolStripMenuItem1.Name = "bağlantıyıKesToolStripMenuItem1";
            this.bağlantıyıKesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.bağlantıyıKesToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.bağlantıyıKesToolStripMenuItem1.Text = "Bağlantıyı Kes";
            this.bağlantıyıKesToolStripMenuItem1.Click += new System.EventHandler(this.bağlantıyıKesToolStripMenuItem1_Click);
            // 
            // gsmResetleToolStripMenuItem
            // 
            this.gsmResetleToolStripMenuItem.Name = "gsmResetleToolStripMenuItem";
            this.gsmResetleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gsmResetleToolStripMenuItem.Text = "Gsm Resetle";
            this.gsmResetleToolStripMenuItem.Click += new System.EventHandler(this.gsmResetleToolStripMenuItem_Click);
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtAçToolStripMenuItem,
            this.sDKayıtAçToolStripMenuItem});
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.kayıtToolStripMenuItem.Text = "Kayıt";
            // 
            // kayıtAçToolStripMenuItem
            // 
            this.kayıtAçToolStripMenuItem.Name = "kayıtAçToolStripMenuItem";
            this.kayıtAçToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kayıtAçToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.kayıtAçToolStripMenuItem.Text = "Arayüz Kayıt Aç";
            this.kayıtAçToolStripMenuItem.Click += new System.EventHandler(this.kayıtAçToolStripMenuItem_Click);
            // 
            // sDKayıtAçToolStripMenuItem
            // 
            this.sDKayıtAçToolStripMenuItem.Name = "sDKayıtAçToolStripMenuItem";
            this.sDKayıtAçToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.sDKayıtAçToolStripMenuItem.Text = "SD Kayıt Aç";
            this.sDKayıtAçToolStripMenuItem.Click += new System.EventHandler(this.sDKayıtAçToolStripMenuItem_Click);
            // 
            // eklentilerToolStripMenuItem
            // 
            this.eklentilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMSToolStripMenuItem,
            this.grafiklerToolStripMenuItem});
            this.eklentilerToolStripMenuItem.Name = "eklentilerToolStripMenuItem";
            this.eklentilerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.eklentilerToolStripMenuItem.Text = "Eklentiler";
            // 
            // bMSToolStripMenuItem
            // 
            this.bMSToolStripMenuItem.Name = "bMSToolStripMenuItem";
            this.bMSToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.bMSToolStripMenuItem.Text = "BMS";
            this.bMSToolStripMenuItem.Click += new System.EventHandler(this.bMSToolStripMenuItem_Click);
            // 
            // grafiklerToolStripMenuItem
            // 
            this.grafiklerToolStripMenuItem.Name = "grafiklerToolStripMenuItem";
            this.grafiklerToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.grafiklerToolStripMenuItem.Text = "Grafikler";
            this.grafiklerToolStripMenuItem.Click += new System.EventHandler(this.grafiklerToolStripMenuItem_Click);
            // 
            // turAtToolStripMenuItem
            // 
            this.turAtToolStripMenuItem.Name = "turAtToolStripMenuItem";
            this.turAtToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.turAtToolStripMenuItem.Text = "Tur At";
            this.turAtToolStripMenuItem.Click += new System.EventHandler(this.turAtToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1615, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Anlık Hız";
            // 
            // anlik_hiz
            // 
            this.anlik_hiz.AutoSize = true;
            this.anlik_hiz.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anlik_hiz.ForeColor = System.Drawing.Color.White;
            this.anlik_hiz.Location = new System.Drawing.Point(1622, 95);
            this.anlik_hiz.Name = "anlik_hiz";
            this.anlik_hiz.Size = new System.Drawing.Size(49, 32);
            this.anlik_hiz.TabIndex = 7;
            this.anlik_hiz.Text = "30";
            // 
            // anlikhiz_gauge
            // 
            this.anlikhiz_gauge.BackThickness = 20;
            this.anlikhiz_gauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.anlikhiz_gauge.ForeColor = System.Drawing.Color.White;
            this.anlikhiz_gauge.IdleColor = System.Drawing.Color.Gainsboro;
            this.anlikhiz_gauge.Location = new System.Drawing.Point(1573, 55);
            this.anlikhiz_gauge.Margin = new System.Windows.Forms.Padding(6);
            this.anlikhiz_gauge.MaximumColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.anlikhiz_gauge.MinimumColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.anlikhiz_gauge.Name = "anlikhiz_gauge";
            this.anlikhiz_gauge.ShowText = false;
            this.anlikhiz_gauge.Size = new System.Drawing.Size(164, 67);
            this.anlikhiz_gauge.TabIndex = 57;
            this.anlikhiz_gauge.Thickness = 20;
            this.anlikhiz_gauge.Value = 50;
            // 
            // ana_sekme
            // 
            this.ana_sekme.Controls.Add(this.tabPage1);
            this.ana_sekme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ana_sekme.Location = new System.Drawing.Point(0, 0);
            this.ana_sekme.Name = "ana_sekme";
            this.ana_sekme.SelectedIndex = 0;
            this.ana_sekme.Size = new System.Drawing.Size(1904, 1041);
            this.ana_sekme.TabIndex = 48;
            // 
            // telemetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.ana_sekme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "telemetry";
            this.Text = "AESK Telemetry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telemetry_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gmap_sag.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.system_durum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsm_durum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextion_durum)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bms_dc_bus_ready_flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_discharge_flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_precharge_flag)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ems_durum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_durum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbee_active)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_durum)).EndInit();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.set_hiz_bar.ResumeLayout(false);
            this.set_hiz_bar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.atilan_Tur.ResumeLayout(false);
            this.atilan_Tur.PerformLayout();
            this.tableLayoutPanel86.ResumeLayout(false);
            this.tableLayoutPanel87.ResumeLayout(false);
            this.tableLayoutPanel87.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tableLayoutPanel85.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bms_fatal_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_over_cur_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_comm_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_temp_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_low_volt_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_high_volt_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_can_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bms_can_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_can_error)).EndInit();
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ems_bat_volt_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_fc_voltage_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_out_voltage_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_bat_current_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_fc_current_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out_current_error)).EndInit();
            this.angle_gauge.ResumeLayout(false);
            this.angle_gauge.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ana_sekme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList error_ready;
        private System.Windows.Forms.ImageList imageList1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip gmap_sag;
        private System.Windows.Forms.ToolStripMenuItem GpsMouseModAktif;
        private System.Windows.Forms.ToolStripMenuItem GpsMouseModDeaktif;
        private System.Windows.Forms.ToolStripMenuItem MarkerTemizlee;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox gidilen_yol_gps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel86;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel87;
        private System.Windows.Forms.TextBox kalan_yol_driver;
        private System.Windows.Forms.TextBox gidilen_yol_driver;
        private System.Windows.Forms.TextBox anlik_tur_suresi;
        private System.Windows.Forms.TextBox en_hizli_tur_timer;
        private System.Windows.Forms.TextBox önceki_tur_timer;
        private System.Windows.Forms.TextBox ort_hiz;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox maks_hiz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel85;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox ortalama_tur_suresi;
        private System.Windows.Forms.TextBox kalan_sure;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox gecen_sure;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.Label tork_limit;
        private System.Windows.Forms.Label motor_temp_error;
        private System.Windows.Forms.Label dc_bus_amper_error;
        private System.Windows.Forms.Label zpc;
        private System.Windows.Forms.Label pwm_enabled;
        private System.Windows.Forms.Label dc_bus_voltage_error;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox iq;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TextBox phase_b_cur;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox phase_a_cur;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox dc_bus_cur;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox dc_bus_volt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox ems_out_current;
        private System.Windows.Forms.TextBox ems_fc_current;
        private System.Windows.Forms.TextBox ems_bat_current;
        private System.Windows.Forms.TextBox ems_out_voltage;
        private System.Windows.Forms.TextBox ems_fc_voltage;
        private System.Windows.Forms.TextBox ems_bat_volt;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.TextBox driver_fwrv_status;
        private System.Windows.Forms.TextBox driver_brake_status;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox driver_ign_status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.PictureBox gsm_durum;
        private Guna.UI.WinForms.GunaCircleProgressBar angle_gauge;
        private System.Windows.Forms.Label sektor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TextBox uydu_sayisi;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox mqtt_toplam_paket;
        private System.Windows.Forms.TextBox mqtt_solved_paket;
        private System.Windows.Forms.TextBox mqtt_verim;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label gsm_yenileme;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox verim;
        private System.Windows.Forms.TextBox cozulen_paket;
        private System.Windows.Forms.TextBox crc_hatali;
        private System.Windows.Forms.TextBox baslik_hatali;
        private System.Windows.Forms.TextBox gelen_bayt;
        private System.Windows.Forms.TextBox secilen_port;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.HScrollBar history_displayer;
        private Guna.UI.WinForms.GunaProgressBar kalanyol_bar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label hedef_hiz;
        private Guna.UI.WinForms.GunaGauge hedefhiz_gauge;
        private Guna.UI.WinForms.GunaProgressBar kalanyol_gps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label anlik_hiz_gps;
        private Guna.UI.WinForms.GunaGauge gpshiz_gauge;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label yol_gps;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yarışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gSMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlantıyıKesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xbeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bağlantıyıKesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gsmResetleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sDKayıtAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turAtToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label anlik_hiz;
        private Guna.UI.WinForms.GunaGauge anlikhiz_gauge;
        private System.Windows.Forms.TabControl ana_sekme;
        private System.Windows.Forms.TextBox gps_verim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ems_temp;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox ems_soc;
        private System.Windows.Forms.TextBox ems_penalty;
        private System.Windows.Forms.TextBox ems_fc_lt_cons;
        private System.Windows.Forms.TextBox ems_out_cons;
        private System.Windows.Forms.TextBox ems_fc_cons;
        private System.Windows.Forms.TextBox ems_bat_cons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox system_durum;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.TextBox bms_temp;
        private System.Windows.Forms.TextBox bms_worst_cell_address;
        private System.Windows.Forms.TextBox bms_worst_cell_voltage;
        private System.Windows.Forms.TextBox bms_soc;
        private System.Windows.Forms.TextBox bms_bat_cons;
        private System.Windows.Forms.TextBox bms_bat_current;
        private System.Windows.Forms.TextBox bms_bat_voltage;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.PictureBox bms_fatal_error;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.PictureBox bms_over_cur_error;
        private System.Windows.Forms.PictureBox bms_comm_error;
        private System.Windows.Forms.PictureBox bms_temp_error;
        private System.Windows.Forms.PictureBox bms_low_volt_error;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.PictureBox bms_high_volt_error;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.PictureBox bms_dc_bus_ready_flag;
        private System.Windows.Forms.PictureBox bms_discharge_flag;
        private System.Windows.Forms.PictureBox bms_precharge_flag;
        private System.Windows.Forms.TextBox torque;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ToolStripMenuItem eklentilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafiklerToolStripMenuItem;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox motor_temp;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox phase_a_rms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.TextBox textBox2;
        private Guna.UI.WinForms.GunaCircleProgressBar set_hiz_bar;
        private System.Windows.Forms.TextBox set_hizz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox3;
        private Guna.UI.WinForms.GunaCircleProgressBar atilan_Tur;
        private System.Windows.Forms.TextBox turrr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox ems_bat_volt_error;
        private System.Windows.Forms.PictureBox ems_fc_voltage_error;
        private System.Windows.Forms.PictureBox ems_out_voltage_error;
        private System.Windows.Forms.PictureBox ems_bat_current_error;
        private System.Windows.Forms.PictureBox ems_fc_current_error;
        private System.Windows.Forms.PictureBox out_current_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ems_can_error;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.PictureBox bms_can_error;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.PictureBox driver_can_error;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.PictureBox ems_durum;
        private System.Windows.Forms.PictureBox bms_durum;
        private System.Windows.Forms.PictureBox xbee_active;
        private System.Windows.Forms.PictureBox driver_durum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox energy;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.PictureBox nextion_durum;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox power_text;
    }
}

