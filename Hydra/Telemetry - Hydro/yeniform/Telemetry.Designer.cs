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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.error_ready = new System.Windows.Forms.ImageList(this.components);
            this.gmap_sag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GpsMouseModAktif = new System.Windows.Forms.ToolStripMenuItem();
            this.GpsMouseModDeaktif = new System.Windows.Forms.ToolStripMenuItem();
            this.MarkerTemizlee = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.actTorqueBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.setTorqueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actIqBox = new System.Windows.Forms.TextBox();
            this.actIdBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.setIdBox = new System.Windows.Forms.TextBox();
            this.setIqBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label53 = new System.Windows.Forms.Label();
            this.actSpeedBox = new System.Windows.Forms.TextBox();
            this.vdcBox = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.idcBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.vdBox = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.vqBox = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.setSpeedBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.emsTempBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.emsSharingBox = new System.Windows.Forms.TextBox();
            this.emsPenaltyBox = new System.Windows.Forms.TextBox();
            this.emsFcLtConsBox = new System.Windows.Forms.TextBox();
            this.emsOutConsBox = new System.Windows.Forms.TextBox();
            this.emsFcConsBox = new System.Windows.Forms.TextBox();
            this.emsBatConsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.emsOutCurBox = new System.Windows.Forms.TextBox();
            this.emsFcCurBox = new System.Windows.Forms.TextBox();
            this.emsBatCurBox = new System.Windows.Forms.TextBox();
            this.emsOutVoltageBox = new System.Windows.Forms.TextBox();
            this.emsFcVoltBox = new System.Windows.Forms.TextBox();
            this.emsBatVoltBox = new System.Windows.Forms.TextBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.targetSpeedBox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.gpsSpeedBox = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yarışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıyıKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eklentilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turAtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turSayımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turAtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bmsTempBox = new System.Windows.Forms.TextBox();
            this.bmsWcaBox = new System.Windows.Forms.TextBox();
            this.bmsWcvBox = new System.Windows.Forms.TextBox();
            this.bmsSocBox = new System.Windows.Forms.TextBox();
            this.bmsBatConsBox = new System.Windows.Forms.TextBox();
            this.bmsBatCurBox = new System.Windows.Forms.TextBox();
            this.bmsBatVoltBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.bmsFatalErrorBox = new System.Windows.Forms.PictureBox();
            this.label45 = new System.Windows.Forms.Label();
            this.bmsOverCurErrorBox = new System.Windows.Forms.PictureBox();
            this.bmsCommErrorBox = new System.Windows.Forms.PictureBox();
            this.bmsTempErrorBox = new System.Windows.Forms.PictureBox();
            this.bmsLowVoltErrorBox = new System.Windows.Forms.PictureBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.bmsHighVoltErrBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.label81 = new System.Windows.Forms.Label();
            this.lastLapBox = new System.Windows.Forms.TextBox();
            this.currentLapBox = new System.Windows.Forms.TextBox();
            this.fastestLapBox = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.distTravelledBox = new System.Windows.Forms.TextBox();
            this.distRemainingBox = new System.Windows.Forms.TextBox();
            this.avgSpeedBox = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.timeElapsedBox = new System.Windows.Forms.TextBox();
            this.timeLeftBox = new System.Windows.Forms.TextBox();
            this.avgLapTimeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.zpcBox = new System.Windows.Forms.PictureBox();
            this.underSpeedBox = new System.Windows.Forms.PictureBox();
            this.underVoltVDCBox = new System.Windows.Forms.PictureBox();
            this.overSpeedBox = new System.Windows.Forms.PictureBox();
            this.pwmEnabledBox = new System.Windows.Forms.PictureBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.driveModeBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.overCurABox = new System.Windows.Forms.PictureBox();
            this.overCurCBox = new System.Windows.Forms.PictureBox();
            this.overCurBBox = new System.Windows.Forms.PictureBox();
            this.overCurIDCBox = new System.Windows.Forms.PictureBox();
            this.overTempBox = new System.Windows.Forms.PictureBox();
            this.overVoltVDCBox = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.label82 = new System.Windows.Forms.Label();
            this.mqttBox = new System.Windows.Forms.PictureBox();
            this.bmsCanBox = new System.Windows.Forms.PictureBox();
            this.gpsReadyBox = new System.Windows.Forms.PictureBox();
            this.mcuCanBox = new System.Windows.Forms.PictureBox();
            this.label65 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.PictureBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.emsCanBox = new System.Windows.Forms.PictureBox();
            this.vcuCanBox = new System.Windows.Forms.PictureBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.bmsWakeBox = new System.Windows.Forms.PictureBox();
            this.mcuWakeBox = new System.Windows.Forms.PictureBox();
            this.emsWakeBox = new System.Windows.Forms.PictureBox();
            this.igniWakeBox = new System.Windows.Forms.PictureBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gmap_sag.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ems_bat_volt_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_fc_voltage_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_out_voltage_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_bat_current_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ems_fc_current_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out_current_error)).BeginInit();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmsFatalErrorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsOverCurErrorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsCommErrorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsTempErrorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsLowVoltErrorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsHighVoltErrBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zpcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underSpeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underVoltVDCBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overSpeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwmEnabledBox)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overCurABox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overCurCBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overCurBBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overCurIDCBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overTempBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overVoltVDCBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mqttBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsCanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpsReadyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcuCanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsCanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcuCanBox)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmsWakeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcuWakeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsWakeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igniWakeBox)).BeginInit();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel13);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(583, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 264);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MCU";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13774F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86226F));
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel15, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel14, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.04546F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(458, 234);
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
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.label26, 0, 5);
            this.tableLayoutPanel15.Controls.Add(this.actTorqueBox, 0, 5);
            this.tableLayoutPanel15.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel15.Controls.Add(this.setTorqueBox, 0, 4);
            this.tableLayoutPanel15.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel15.Controls.Add(this.actIqBox, 0, 3);
            this.tableLayoutPanel15.Controls.Add(this.actIdBox, 1, 2);
            this.tableLayoutPanel15.Controls.Add(this.label29, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.label90, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.label88, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.setIdBox, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.setIqBox, 1, 1);
            this.tableLayoutPanel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel15.Location = new System.Drawing.Point(232, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 6;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(223, 228);
            this.tableLayoutPanel15.TabIndex = 51;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(6, 188);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 37);
            this.label26.TabIndex = 104;
            this.label26.Text = "Act Torque";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actTorqueBox
            // 
            this.actTorqueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.actTorqueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actTorqueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actTorqueBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.actTorqueBox.ForeColor = System.Drawing.Color.White;
            this.actTorqueBox.Location = new System.Drawing.Point(116, 191);
            this.actTorqueBox.Multiline = true;
            this.actTorqueBox.Name = "actTorqueBox";
            this.actTorqueBox.ReadOnly = true;
            this.actTorqueBox.Size = new System.Drawing.Size(101, 31);
            this.actTorqueBox.TabIndex = 103;
            this.actTorqueBox.Text = "NaN";
            this.actTorqueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 34);
            this.label14.TabIndex = 102;
            this.label14.Text = "Set Torque";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setTorqueBox
            // 
            this.setTorqueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.setTorqueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setTorqueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setTorqueBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setTorqueBox.ForeColor = System.Drawing.Color.White;
            this.setTorqueBox.Location = new System.Drawing.Point(116, 154);
            this.setTorqueBox.Multiline = true;
            this.setTorqueBox.Name = "setTorqueBox";
            this.setTorqueBox.ReadOnly = true;
            this.setTorqueBox.Size = new System.Drawing.Size(101, 28);
            this.setTorqueBox.TabIndex = 101;
            this.setTorqueBox.Text = "NaN";
            this.setTorqueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 34);
            this.label1.TabIndex = 100;
            this.label1.Text = "Act Iq";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actIqBox
            // 
            this.actIqBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.actIqBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actIqBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actIqBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.actIqBox.ForeColor = System.Drawing.Color.White;
            this.actIqBox.Location = new System.Drawing.Point(116, 117);
            this.actIqBox.Multiline = true;
            this.actIqBox.Name = "actIqBox";
            this.actIqBox.ReadOnly = true;
            this.actIqBox.Size = new System.Drawing.Size(101, 28);
            this.actIqBox.TabIndex = 99;
            this.actIqBox.Text = "NaN";
            this.actIqBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // actIdBox
            // 
            this.actIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.actIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actIdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actIdBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.actIdBox.ForeColor = System.Drawing.Color.White;
            this.actIdBox.Location = new System.Drawing.Point(116, 80);
            this.actIdBox.Multiline = true;
            this.actIdBox.Name = "actIdBox";
            this.actIdBox.ReadOnly = true;
            this.actIdBox.Size = new System.Drawing.Size(101, 28);
            this.actIdBox.TabIndex = 98;
            this.actIdBox.Text = "NaN";
            this.actIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(6, 77);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 34);
            this.label29.TabIndex = 98;
            this.label29.Text = "Act Id";
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
            this.label90.Size = new System.Drawing.Size(101, 34);
            this.label90.TabIndex = 54;
            this.label90.Text = "Set Id";
            this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label88.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label88.ForeColor = System.Drawing.Color.White;
            this.label88.Location = new System.Drawing.Point(6, 40);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(101, 34);
            this.label88.TabIndex = 3;
            this.label88.Text = "Set Iq";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setIdBox
            // 
            this.setIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.setIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setIdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setIdBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setIdBox.ForeColor = System.Drawing.Color.White;
            this.setIdBox.Location = new System.Drawing.Point(116, 6);
            this.setIdBox.Multiline = true;
            this.setIdBox.Name = "setIdBox";
            this.setIdBox.ReadOnly = true;
            this.setIdBox.Size = new System.Drawing.Size(101, 28);
            this.setIdBox.TabIndex = 10;
            this.setIdBox.Text = "NaN";
            this.setIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setIqBox
            // 
            this.setIqBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.setIqBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setIqBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setIqBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setIqBox.ForeColor = System.Drawing.Color.White;
            this.setIqBox.Location = new System.Drawing.Point(116, 43);
            this.setIqBox.Multiline = true;
            this.setIqBox.Name = "setIqBox";
            this.setIqBox.ReadOnly = true;
            this.setIqBox.Size = new System.Drawing.Size(101, 28);
            this.setIqBox.TabIndex = 11;
            this.setIqBox.Text = "NaN";
            this.setIqBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.label53, 0, 5);
            this.tableLayoutPanel14.Controls.Add(this.actSpeedBox, 0, 5);
            this.tableLayoutPanel14.Controls.Add(this.vdcBox, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.label68, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.label71, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.idcBox, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.label31, 0, 2);
            this.tableLayoutPanel14.Controls.Add(this.vdBox, 1, 2);
            this.tableLayoutPanel14.Controls.Add(this.label35, 0, 3);
            this.tableLayoutPanel14.Controls.Add(this.vqBox, 1, 3);
            this.tableLayoutPanel14.Controls.Add(this.label52, 0, 4);
            this.tableLayoutPanel14.Controls.Add(this.setSpeedBox, 1, 4);
            this.tableLayoutPanel14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableLayoutPanel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 6;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(223, 228);
            this.tableLayoutPanel14.TabIndex = 51;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(6, 188);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(101, 37);
            this.label53.TabIndex = 21;
            this.label53.Text = "Act Speed";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actSpeedBox
            // 
            this.actSpeedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.actSpeedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actSpeedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actSpeedBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.actSpeedBox.ForeColor = System.Drawing.SystemColors.Window;
            this.actSpeedBox.Location = new System.Drawing.Point(116, 191);
            this.actSpeedBox.Multiline = true;
            this.actSpeedBox.Name = "actSpeedBox";
            this.actSpeedBox.Size = new System.Drawing.Size(101, 31);
            this.actSpeedBox.TabIndex = 20;
            this.actSpeedBox.Text = "NaN";
            this.actSpeedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vdcBox
            // 
            this.vdcBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.vdcBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vdcBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vdcBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vdcBox.ForeColor = System.Drawing.Color.White;
            this.vdcBox.Location = new System.Drawing.Point(116, 43);
            this.vdcBox.Multiline = true;
            this.vdcBox.Name = "vdcBox";
            this.vdcBox.ReadOnly = true;
            this.vdcBox.Size = new System.Drawing.Size(101, 28);
            this.vdcBox.TabIndex = 10;
            this.vdcBox.Text = "NaN";
            this.vdcBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label68.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(6, 40);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(101, 34);
            this.label68.TabIndex = 3;
            this.label68.Text = "V DC BUS";
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
            this.label71.Size = new System.Drawing.Size(101, 34);
            this.label71.TabIndex = 0;
            this.label71.Text = "I DC BUS";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idcBox
            // 
            this.idcBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.idcBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idcBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idcBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idcBox.ForeColor = System.Drawing.Color.White;
            this.idcBox.Location = new System.Drawing.Point(116, 6);
            this.idcBox.Multiline = true;
            this.idcBox.Name = "idcBox";
            this.idcBox.ReadOnly = true;
            this.idcBox.Size = new System.Drawing.Size(101, 28);
            this.idcBox.TabIndex = 9;
            this.idcBox.Text = "NaN";
            this.idcBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label31.Location = new System.Drawing.Point(6, 77);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(101, 34);
            this.label31.TabIndex = 14;
            this.label31.Text = "Vd";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vdBox
            // 
            this.vdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.vdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vdBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vdBox.ForeColor = System.Drawing.SystemColors.Window;
            this.vdBox.Location = new System.Drawing.Point(116, 80);
            this.vdBox.Multiline = true;
            this.vdBox.Name = "vdBox";
            this.vdBox.Size = new System.Drawing.Size(101, 28);
            this.vdBox.TabIndex = 15;
            this.vdBox.Text = "NaN";
            this.vdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(6, 114);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(101, 34);
            this.label35.TabIndex = 16;
            this.label35.Text = "Vq";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vqBox
            // 
            this.vqBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.vqBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vqBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vqBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vqBox.ForeColor = System.Drawing.SystemColors.Window;
            this.vqBox.Location = new System.Drawing.Point(116, 117);
            this.vqBox.Multiline = true;
            this.vqBox.Name = "vqBox";
            this.vqBox.Size = new System.Drawing.Size(101, 28);
            this.vqBox.TabIndex = 17;
            this.vqBox.Text = "NaN";
            this.vqBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(6, 151);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(101, 34);
            this.label52.TabIndex = 19;
            this.label52.Text = "Set Speed";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setSpeedBox
            // 
            this.setSpeedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.setSpeedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setSpeedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setSpeedBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setSpeedBox.ForeColor = System.Drawing.SystemColors.Window;
            this.setSpeedBox.Location = new System.Drawing.Point(116, 154);
            this.setSpeedBox.Multiline = true;
            this.setSpeedBox.Name = "setSpeedBox";
            this.setSpeedBox.Size = new System.Drawing.Size(101, 28);
            this.setSpeedBox.TabIndex = 18;
            this.setSpeedBox.Text = "NaN";
            this.setSpeedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 264);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMS";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08031F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91969F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(564, 236);
            this.tableLayoutPanel3.TabIndex = 50;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.74138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.25862F));
            this.tableLayoutPanel1.Controls.Add(this.emsTempBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.emsSharingBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.emsPenaltyBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.emsFcLtConsBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.emsOutConsBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.emsFcConsBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.emsBatConsBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(262, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30275F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.76147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.59633F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 230);
            this.tableLayoutPanel1.TabIndex = 50;
            // 
            // emsTempBox
            // 
            this.emsTempBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsTempBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsTempBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emsTempBox.ForeColor = System.Drawing.Color.White;
            this.emsTempBox.Location = new System.Drawing.Point(167, 195);
            this.emsTempBox.Multiline = true;
            this.emsTempBox.Name = "emsTempBox";
            this.emsTempBox.Size = new System.Drawing.Size(126, 29);
            this.emsTempBox.TabIndex = 103;
            this.emsTempBox.Tag = "";
            this.emsTempBox.Text = "NaN";
            this.emsTempBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(6, 192);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(152, 35);
            this.label25.TabIndex = 103;
            this.label25.Text = "TUBE TEMP";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emsSharingBox
            // 
            this.emsSharingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsSharingBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsSharingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emsSharingBox.ForeColor = System.Drawing.Color.White;
            this.emsSharingBox.Location = new System.Drawing.Point(167, 163);
            this.emsSharingBox.Multiline = true;
            this.emsSharingBox.Name = "emsSharingBox";
            this.emsSharingBox.Size = new System.Drawing.Size(126, 23);
            this.emsSharingBox.TabIndex = 102;
            this.emsSharingBox.Tag = "";
            this.emsSharingBox.Text = "NaN";
            this.emsSharingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsPenaltyBox
            // 
            this.emsPenaltyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsPenaltyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsPenaltyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsPenaltyBox.ForeColor = System.Drawing.Color.White;
            this.emsPenaltyBox.Location = new System.Drawing.Point(167, 131);
            this.emsPenaltyBox.Multiline = true;
            this.emsPenaltyBox.Name = "emsPenaltyBox";
            this.emsPenaltyBox.Size = new System.Drawing.Size(126, 23);
            this.emsPenaltyBox.TabIndex = 101;
            this.emsPenaltyBox.Tag = "";
            this.emsPenaltyBox.Text = "NaN";
            this.emsPenaltyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsFcLtConsBox
            // 
            this.emsFcLtConsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsFcLtConsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsFcLtConsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsFcLtConsBox.ForeColor = System.Drawing.Color.White;
            this.emsFcLtConsBox.Location = new System.Drawing.Point(167, 100);
            this.emsFcLtConsBox.Multiline = true;
            this.emsFcLtConsBox.Name = "emsFcLtConsBox";
            this.emsFcLtConsBox.Size = new System.Drawing.Size(126, 22);
            this.emsFcLtConsBox.TabIndex = 100;
            this.emsFcLtConsBox.Tag = "";
            this.emsFcLtConsBox.Text = "NaN";
            this.emsFcLtConsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsOutConsBox
            // 
            this.emsOutConsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsOutConsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsOutConsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsOutConsBox.ForeColor = System.Drawing.Color.White;
            this.emsOutConsBox.Location = new System.Drawing.Point(167, 70);
            this.emsOutConsBox.Multiline = true;
            this.emsOutConsBox.Name = "emsOutConsBox";
            this.emsOutConsBox.Size = new System.Drawing.Size(126, 21);
            this.emsOutConsBox.TabIndex = 99;
            this.emsOutConsBox.Tag = "";
            this.emsOutConsBox.Text = "NaN";
            this.emsOutConsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsFcConsBox
            // 
            this.emsFcConsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsFcConsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsFcConsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsFcConsBox.ForeColor = System.Drawing.Color.White;
            this.emsFcConsBox.Location = new System.Drawing.Point(167, 38);
            this.emsFcConsBox.Multiline = true;
            this.emsFcConsBox.Name = "emsFcConsBox";
            this.emsFcConsBox.Size = new System.Drawing.Size(126, 23);
            this.emsFcConsBox.TabIndex = 98;
            this.emsFcConsBox.Tag = "";
            this.emsFcConsBox.Text = "NaN";
            this.emsFcConsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsBatConsBox
            // 
            this.emsBatConsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsBatConsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsBatConsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsBatConsBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emsBatConsBox.ForeColor = System.Drawing.Color.White;
            this.emsBatConsBox.Location = new System.Drawing.Point(167, 6);
            this.emsBatConsBox.Multiline = true;
            this.emsBatConsBox.Name = "emsBatConsBox";
            this.emsBatConsBox.Size = new System.Drawing.Size(126, 23);
            this.emsBatConsBox.TabIndex = 97;
            this.emsBatConsBox.Tag = "";
            this.emsBatConsBox.Text = "NaN";
            this.emsBatConsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
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
            this.label5.Size = new System.Drawing.Size(152, 29);
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
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 29);
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
            this.label16.Location = new System.Drawing.Point(6, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 27);
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
            this.label22.Location = new System.Drawing.Point(6, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(152, 29);
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
            this.label24.Location = new System.Drawing.Point(6, 97);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(152, 28);
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
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel7.Controls.Add(this.emsOutCurBox, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.emsFcCurBox, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.emsBatCurBox, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.emsOutVoltageBox, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.emsFcVoltBox, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.emsBatVoltBox, 1, 0);
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
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 6;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(253, 230);
            this.tableLayoutPanel7.TabIndex = 49;
            // 
            // emsOutCurBox
            // 
            this.emsOutCurBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsOutCurBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsOutCurBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsOutCurBox.ForeColor = System.Drawing.Color.White;
            this.emsOutCurBox.Location = new System.Drawing.Point(98, 191);
            this.emsOutCurBox.Multiline = true;
            this.emsOutCurBox.Name = "emsOutCurBox";
            this.emsOutCurBox.Size = new System.Drawing.Size(100, 33);
            this.emsOutCurBox.TabIndex = 102;
            this.emsOutCurBox.Tag = "";
            this.emsOutCurBox.Text = "NaN";
            this.emsOutCurBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsFcCurBox
            // 
            this.emsFcCurBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsFcCurBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsFcCurBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsFcCurBox.ForeColor = System.Drawing.Color.White;
            this.emsFcCurBox.Location = new System.Drawing.Point(98, 154);
            this.emsFcCurBox.Multiline = true;
            this.emsFcCurBox.Name = "emsFcCurBox";
            this.emsFcCurBox.Size = new System.Drawing.Size(100, 28);
            this.emsFcCurBox.TabIndex = 101;
            this.emsFcCurBox.Tag = "";
            this.emsFcCurBox.Text = "NaN";
            this.emsFcCurBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsBatCurBox
            // 
            this.emsBatCurBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsBatCurBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsBatCurBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsBatCurBox.ForeColor = System.Drawing.Color.White;
            this.emsBatCurBox.Location = new System.Drawing.Point(98, 117);
            this.emsBatCurBox.Multiline = true;
            this.emsBatCurBox.Name = "emsBatCurBox";
            this.emsBatCurBox.Size = new System.Drawing.Size(100, 28);
            this.emsBatCurBox.TabIndex = 100;
            this.emsBatCurBox.Tag = "";
            this.emsBatCurBox.Text = "NaN";
            this.emsBatCurBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsOutVoltageBox
            // 
            this.emsOutVoltageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsOutVoltageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsOutVoltageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsOutVoltageBox.ForeColor = System.Drawing.Color.White;
            this.emsOutVoltageBox.Location = new System.Drawing.Point(98, 80);
            this.emsOutVoltageBox.Multiline = true;
            this.emsOutVoltageBox.Name = "emsOutVoltageBox";
            this.emsOutVoltageBox.Size = new System.Drawing.Size(100, 28);
            this.emsOutVoltageBox.TabIndex = 99;
            this.emsOutVoltageBox.Tag = "";
            this.emsOutVoltageBox.Text = "NaN";
            this.emsOutVoltageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsFcVoltBox
            // 
            this.emsFcVoltBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsFcVoltBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsFcVoltBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsFcVoltBox.ForeColor = System.Drawing.Color.White;
            this.emsFcVoltBox.Location = new System.Drawing.Point(98, 43);
            this.emsFcVoltBox.Multiline = true;
            this.emsFcVoltBox.Name = "emsFcVoltBox";
            this.emsFcVoltBox.Size = new System.Drawing.Size(100, 28);
            this.emsFcVoltBox.TabIndex = 98;
            this.emsFcVoltBox.Tag = "";
            this.emsFcVoltBox.Text = "NaN";
            this.emsFcVoltBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsBatVoltBox
            // 
            this.emsBatVoltBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emsBatVoltBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.emsBatVoltBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emsBatVoltBox.ForeColor = System.Drawing.Color.White;
            this.emsBatVoltBox.Location = new System.Drawing.Point(98, 6);
            this.emsBatVoltBox.Multiline = true;
            this.emsBatVoltBox.Name = "emsBatVoltBox";
            this.emsBatVoltBox.Size = new System.Drawing.Size(100, 28);
            this.emsBatVoltBox.TabIndex = 97;
            this.emsBatVoltBox.Tag = "";
            this.emsBatVoltBox.Text = "NaN";
            this.emsBatVoltBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label57.ForeColor = System.Drawing.Color.White;
            this.label57.Location = new System.Drawing.Point(6, 40);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(83, 34);
            this.label57.TabIndex = 3;
            this.label57.Text = "FC VOLT";
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
            this.label59.Size = new System.Drawing.Size(83, 34);
            this.label59.TabIndex = 0;
            this.label59.Text = "BAT VOLT";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label70.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label70.ForeColor = System.Drawing.Color.White;
            this.label70.Location = new System.Drawing.Point(6, 188);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(83, 39);
            this.label70.TabIndex = 6;
            this.label70.Text = "OUT CUR";
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
            this.label55.Location = new System.Drawing.Point(6, 77);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(83, 34);
            this.label55.TabIndex = 6;
            this.label55.Text = "OUT VOLT";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label72.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(6, 151);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(83, 34);
            this.label72.TabIndex = 3;
            this.label72.Text = "FC CUR";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label74.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label74.ForeColor = System.Drawing.Color.White;
            this.label74.Location = new System.Drawing.Point(6, 114);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(83, 34);
            this.label74.TabIndex = 0;
            this.label74.Text = "BAT CUR";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ems_bat_volt_error
            // 
            this.ems_bat_volt_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_bat_volt_error.Location = new System.Drawing.Point(207, 6);
            this.ems_bat_volt_error.Name = "ems_bat_volt_error";
            this.ems_bat_volt_error.Size = new System.Drawing.Size(40, 28);
            this.ems_bat_volt_error.TabIndex = 103;
            this.ems_bat_volt_error.TabStop = false;
            // 
            // ems_fc_voltage_error
            // 
            this.ems_fc_voltage_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_fc_voltage_error.Location = new System.Drawing.Point(207, 43);
            this.ems_fc_voltage_error.Name = "ems_fc_voltage_error";
            this.ems_fc_voltage_error.Size = new System.Drawing.Size(40, 28);
            this.ems_fc_voltage_error.TabIndex = 104;
            this.ems_fc_voltage_error.TabStop = false;
            // 
            // ems_out_voltage_error
            // 
            this.ems_out_voltage_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_out_voltage_error.Location = new System.Drawing.Point(207, 80);
            this.ems_out_voltage_error.Name = "ems_out_voltage_error";
            this.ems_out_voltage_error.Size = new System.Drawing.Size(40, 28);
            this.ems_out_voltage_error.TabIndex = 105;
            this.ems_out_voltage_error.TabStop = false;
            // 
            // ems_bat_current_error
            // 
            this.ems_bat_current_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_bat_current_error.Location = new System.Drawing.Point(207, 117);
            this.ems_bat_current_error.Name = "ems_bat_current_error";
            this.ems_bat_current_error.Size = new System.Drawing.Size(40, 28);
            this.ems_bat_current_error.TabIndex = 106;
            this.ems_bat_current_error.TabStop = false;
            // 
            // ems_fc_current_error
            // 
            this.ems_fc_current_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_fc_current_error.Location = new System.Drawing.Point(207, 154);
            this.ems_fc_current_error.Name = "ems_fc_current_error";
            this.ems_fc_current_error.Size = new System.Drawing.Size(40, 28);
            this.ems_fc_current_error.TabIndex = 107;
            this.ems_fc_current_error.TabStop = false;
            // 
            // out_current_error
            // 
            this.out_current_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out_current_error.Location = new System.Drawing.Point(207, 191);
            this.out_current_error.Name = "out_current_error";
            this.out_current_error.Size = new System.Drawing.Size(40, 33);
            this.out_current_error.TabIndex = 108;
            this.out_current_error.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1283, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 19);
            this.label13.TabIndex = 115;
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
            this.tableLayoutPanel11.Location = new System.Drawing.Point(1278, 164);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(142, 81);
            this.tableLayoutPanel11.TabIndex = 114;
            // 
            // uydu_sayisi
            // 
            this.uydu_sayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.uydu_sayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uydu_sayisi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uydu_sayisi.ForeColor = System.Drawing.Color.White;
            this.uydu_sayisi.Location = new System.Drawing.Point(6, 43);
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
            this.label51.Size = new System.Drawing.Size(62, 34);
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
            this.label63.Size = new System.Drawing.Size(59, 34);
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
            this.gps_verim.Location = new System.Drawing.Point(77, 43);
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
            this.tableLayoutPanel10.Location = new System.Drawing.Point(1054, 164);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(220, 81);
            this.tableLayoutPanel10.TabIndex = 111;
            // 
            // mqtt_toplam_paket
            // 
            this.mqtt_toplam_paket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.mqtt_toplam_paket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mqtt_toplam_paket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mqtt_toplam_paket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mqtt_toplam_paket.ForeColor = System.Drawing.Color.White;
            this.mqtt_toplam_paket.Location = new System.Drawing.Point(6, 45);
            this.mqtt_toplam_paket.Multiline = true;
            this.mqtt_toplam_paket.Name = "mqtt_toplam_paket";
            this.mqtt_toplam_paket.ReadOnly = true;
            this.mqtt_toplam_paket.Size = new System.Drawing.Size(62, 30);
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
            this.mqtt_solved_paket.Location = new System.Drawing.Point(77, 45);
            this.mqtt_solved_paket.Multiline = true;
            this.mqtt_solved_paket.Name = "mqtt_solved_paket";
            this.mqtt_solved_paket.ReadOnly = true;
            this.mqtt_solved_paket.Size = new System.Drawing.Size(64, 30);
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
            this.mqtt_verim.Location = new System.Drawing.Point(150, 45);
            this.mqtt_verim.Multiline = true;
            this.mqtt_verim.Name = "mqtt_verim";
            this.mqtt_verim.ReadOnly = true;
            this.mqtt_verim.Size = new System.Drawing.Size(64, 30);
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
            this.label41.Size = new System.Drawing.Size(62, 36);
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
            this.label42.Size = new System.Drawing.Size(64, 36);
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
            this.label43.Size = new System.Drawing.Size(64, 36);
            this.label43.TabIndex = 7;
            this.label43.Text = "VERİM";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(1056, 142);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(125, 19);
            this.label37.TabIndex = 113;
            this.label37.Text = "MQTT KONTROL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1184, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 109;
            this.label11.Text = "km/h";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1056, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 107;
            this.label12.Text = "Hedef Hız";
            // 
            // targetSpeedBox
            // 
            this.targetSpeedBox.AutoSize = true;
            this.targetSpeedBox.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetSpeedBox.ForeColor = System.Drawing.Color.White;
            this.targetSpeedBox.Location = new System.Drawing.Point(1144, 43);
            this.targetSpeedBox.Name = "targetSpeedBox";
            this.targetSpeedBox.Size = new System.Drawing.Size(49, 32);
            this.targetSpeedBox.TabIndex = 108;
            this.targetSpeedBox.Text = "30";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1184, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 106;
            this.label9.Text = "km/h";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(1056, 81);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 21);
            this.label28.TabIndex = 104;
            this.label28.Text = "GPS Hız";
            // 
            // gpsSpeedBox
            // 
            this.gpsSpeedBox.AutoSize = true;
            this.gpsSpeedBox.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpsSpeedBox.ForeColor = System.Drawing.Color.White;
            this.gpsSpeedBox.Location = new System.Drawing.Point(1144, 75);
            this.gpsSpeedBox.Name = "gpsSpeedBox";
            this.gpsSpeedBox.Size = new System.Drawing.Size(49, 32);
            this.gpsSpeedBox.TabIndex = 105;
            this.gpsSpeedBox.Text = "30";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.Location = new System.Drawing.Point(6, 763);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.RowHeadersWidth = 55;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 241);
            this.dataGridView1.TabIndex = 103;
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
            this.gmap.Location = new System.Drawing.Point(1053, 243);
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
            this.gmap.Size = new System.Drawing.Size(850, 761);
            this.gmap.TabIndex = 101;
            this.gmap.Zoom = 0D;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yarışToolStripMenuItem,
            this.gSMToolStripMenuItem,
            this.eklentilerToolStripMenuItem,
            this.turAtToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 102;
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
            this.başlatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.başlatToolStripMenuItem.Text = "Başlat";
            this.başlatToolStripMenuItem.Click += new System.EventHandler(this.başlatToolStripMenuItem_Click);
            // 
            // bitirToolStripMenuItem
            // 
            this.bitirToolStripMenuItem.Name = "bitirToolStripMenuItem";
            this.bitirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.bitirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.bağlanToolStripMenuItem.Click += new System.EventHandler(this.bağlanToolStripMenuItem_Click_1);
            // 
            // bağlantıyıKesToolStripMenuItem
            // 
            this.bağlantıyıKesToolStripMenuItem.Name = "bağlantıyıKesToolStripMenuItem";
            this.bağlantıyıKesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.bağlantıyıKesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.bağlantıyıKesToolStripMenuItem.Text = "Bağlantıyı kes";
            this.bağlantıyıKesToolStripMenuItem.Click += new System.EventHandler(this.bağlantıyıKesToolStripMenuItem_Click_1);
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
            this.bMSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bMSToolStripMenuItem.Text = "BMS";
            // 
            // grafiklerToolStripMenuItem
            // 
            this.grafiklerToolStripMenuItem.Name = "grafiklerToolStripMenuItem";
            this.grafiklerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grafiklerToolStripMenuItem.Text = "Grafikler";
            // 
            // turAtToolStripMenuItem
            // 
            this.turAtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turSayımıToolStripMenuItem,
            this.turAtToolStripMenuItem1});
            this.turAtToolStripMenuItem.Name = "turAtToolStripMenuItem";
            this.turAtToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.turAtToolStripMenuItem.Text = "Harita";
            // 
            // turSayımıToolStripMenuItem
            // 
            this.turSayımıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelToolStripMenuItem,
            this.otoToolStripMenuItem});
            this.turSayımıToolStripMenuItem.Name = "turSayımıToolStripMenuItem";
            this.turSayımıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.turSayımıToolStripMenuItem.Text = "Tur Sayımı";
            // 
            // manuelToolStripMenuItem
            // 
            this.manuelToolStripMenuItem.Name = "manuelToolStripMenuItem";
            this.manuelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manuelToolStripMenuItem.Text = "Manuel";
            this.manuelToolStripMenuItem.Click += new System.EventHandler(this.manuelToolStripMenuItem_Click);
            // 
            // otoToolStripMenuItem
            // 
            this.otoToolStripMenuItem.Name = "otoToolStripMenuItem";
            this.otoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otoToolStripMenuItem.Text = "Oto";
            this.otoToolStripMenuItem.Click += new System.EventHandler(this.otoToolStripMenuItem_Click);
            // 
            // turAtToolStripMenuItem1
            // 
            this.turAtToolStripMenuItem1.Name = "turAtToolStripMenuItem1";
            this.turAtToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.turAtToolStripMenuItem1.Text = "Tur At";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.86722F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.13278F));
            this.tableLayoutPanel2.Controls.Add(this.bmsTempBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.bmsWcaBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.bmsWcvBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.bmsSocBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.bmsBatConsBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.bmsBatCurBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bmsBatVoltBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label27, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label56, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label38, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label39, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label40, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label44, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(252, 274);
            this.tableLayoutPanel2.TabIndex = 116;
            // 
            // bmsTempBox
            // 
            this.bmsTempBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bmsTempBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmsTempBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsTempBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmsTempBox.ForeColor = System.Drawing.Color.White;
            this.bmsTempBox.Location = new System.Drawing.Point(135, 234);
            this.bmsTempBox.Multiline = true;
            this.bmsTempBox.Name = "bmsTempBox";
            this.bmsTempBox.ReadOnly = true;
            this.bmsTempBox.Size = new System.Drawing.Size(111, 34);
            this.bmsTempBox.TabIndex = 120;
            this.bmsTempBox.Text = "NaN";
            this.bmsTempBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmsWcaBox
            // 
            this.bmsWcaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bmsWcaBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmsWcaBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsWcaBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmsWcaBox.ForeColor = System.Drawing.Color.White;
            this.bmsWcaBox.Location = new System.Drawing.Point(135, 196);
            this.bmsWcaBox.Multiline = true;
            this.bmsWcaBox.Name = "bmsWcaBox";
            this.bmsWcaBox.ReadOnly = true;
            this.bmsWcaBox.Size = new System.Drawing.Size(111, 29);
            this.bmsWcaBox.TabIndex = 119;
            this.bmsWcaBox.Text = "NaN";
            this.bmsWcaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmsWcvBox
            // 
            this.bmsWcvBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bmsWcvBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmsWcvBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsWcvBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmsWcvBox.ForeColor = System.Drawing.Color.White;
            this.bmsWcvBox.Location = new System.Drawing.Point(135, 158);
            this.bmsWcvBox.Multiline = true;
            this.bmsWcvBox.Name = "bmsWcvBox";
            this.bmsWcvBox.ReadOnly = true;
            this.bmsWcvBox.Size = new System.Drawing.Size(111, 29);
            this.bmsWcvBox.TabIndex = 118;
            this.bmsWcvBox.Text = "NaN";
            this.bmsWcvBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmsSocBox
            // 
            this.bmsSocBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bmsSocBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmsSocBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsSocBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmsSocBox.ForeColor = System.Drawing.Color.White;
            this.bmsSocBox.Location = new System.Drawing.Point(135, 120);
            this.bmsSocBox.Multiline = true;
            this.bmsSocBox.Name = "bmsSocBox";
            this.bmsSocBox.ReadOnly = true;
            this.bmsSocBox.Size = new System.Drawing.Size(111, 29);
            this.bmsSocBox.TabIndex = 117;
            this.bmsSocBox.Text = "NaN";
            this.bmsSocBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmsBatConsBox
            // 
            this.bmsBatConsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bmsBatConsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmsBatConsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsBatConsBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmsBatConsBox.ForeColor = System.Drawing.Color.White;
            this.bmsBatConsBox.Location = new System.Drawing.Point(135, 82);
            this.bmsBatConsBox.Multiline = true;
            this.bmsBatConsBox.Name = "bmsBatConsBox";
            this.bmsBatConsBox.ReadOnly = true;
            this.bmsBatConsBox.Size = new System.Drawing.Size(111, 29);
            this.bmsBatConsBox.TabIndex = 117;
            this.bmsBatConsBox.Text = "NaN";
            this.bmsBatConsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmsBatCurBox
            // 
            this.bmsBatCurBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bmsBatCurBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmsBatCurBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsBatCurBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmsBatCurBox.ForeColor = System.Drawing.Color.White;
            this.bmsBatCurBox.Location = new System.Drawing.Point(135, 44);
            this.bmsBatCurBox.Multiline = true;
            this.bmsBatCurBox.Name = "bmsBatCurBox";
            this.bmsBatCurBox.ReadOnly = true;
            this.bmsBatCurBox.Size = new System.Drawing.Size(111, 29);
            this.bmsBatCurBox.TabIndex = 117;
            this.bmsBatCurBox.Text = "NaN";
            this.bmsBatCurBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmsBatVoltBox
            // 
            this.bmsBatVoltBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.bmsBatVoltBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmsBatVoltBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsBatVoltBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmsBatVoltBox.ForeColor = System.Drawing.Color.White;
            this.bmsBatVoltBox.Location = new System.Drawing.Point(135, 6);
            this.bmsBatVoltBox.Multiline = true;
            this.bmsBatVoltBox.Name = "bmsBatVoltBox";
            this.bmsBatVoltBox.ReadOnly = true;
            this.bmsBatVoltBox.Size = new System.Drawing.Size(111, 29);
            this.bmsBatVoltBox.TabIndex = 117;
            this.bmsBatVoltBox.Text = "NaN";
            this.bmsBatVoltBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(6, 41);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 35);
            this.label27.TabIndex = 3;
            this.label27.Text = "BAT CUR";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(6, 231);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(120, 40);
            this.label56.TabIndex = 9;
            this.label56.Text = "BAT TEMP";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(6, 3);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(120, 35);
            this.label36.TabIndex = 0;
            this.label36.Text = "BAT VOLT";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(6, 193);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(120, 35);
            this.label38.TabIndex = 6;
            this.label38.Text = "WCA";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(6, 155);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(120, 35);
            this.label39.TabIndex = 3;
            this.label39.Text = "WCV";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(6, 117);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(120, 35);
            this.label40.TabIndex = 0;
            this.label40.Text = "SoC";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(6, 79);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(120, 35);
            this.label44.TabIndex = 6;
            this.label44.Text = "BAT CONS";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 310);
            this.groupBox3.TabIndex = 117;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BMS";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.46103F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.53897F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(449, 280);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.07692F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
            this.tableLayoutPanel5.Controls.Add(this.bmsFatalErrorBox, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.label45, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.bmsOverCurErrorBox, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.bmsCommErrorBox, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.bmsTempErrorBox, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.bmsLowVoltErrorBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label46, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label47, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label48, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label49, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label50, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.bmsHighVoltErrBox, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(261, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(185, 274);
            this.tableLayoutPanel5.TabIndex = 118;
            // 
            // bmsFatalErrorBox
            // 
            this.bmsFatalErrorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsFatalErrorBox.Location = new System.Drawing.Point(137, 231);
            this.bmsFatalErrorBox.Name = "bmsFatalErrorBox";
            this.bmsFatalErrorBox.Size = new System.Drawing.Size(42, 37);
            this.bmsFatalErrorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bmsFatalErrorBox.TabIndex = 97;
            this.bmsFatalErrorBox.TabStop = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(6, 228);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(122, 43);
            this.label45.TabIndex = 14;
            this.label45.Text = "FATAL ERROR";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bmsOverCurErrorBox
            // 
            this.bmsOverCurErrorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsOverCurErrorBox.Location = new System.Drawing.Point(137, 186);
            this.bmsOverCurErrorBox.Name = "bmsOverCurErrorBox";
            this.bmsOverCurErrorBox.Size = new System.Drawing.Size(42, 36);
            this.bmsOverCurErrorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bmsOverCurErrorBox.TabIndex = 13;
            this.bmsOverCurErrorBox.TabStop = false;
            // 
            // bmsCommErrorBox
            // 
            this.bmsCommErrorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsCommErrorBox.Location = new System.Drawing.Point(137, 141);
            this.bmsCommErrorBox.Name = "bmsCommErrorBox";
            this.bmsCommErrorBox.Size = new System.Drawing.Size(42, 36);
            this.bmsCommErrorBox.TabIndex = 12;
            this.bmsCommErrorBox.TabStop = false;
            // 
            // bmsTempErrorBox
            // 
            this.bmsTempErrorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsTempErrorBox.Location = new System.Drawing.Point(137, 96);
            this.bmsTempErrorBox.Name = "bmsTempErrorBox";
            this.bmsTempErrorBox.Size = new System.Drawing.Size(42, 36);
            this.bmsTempErrorBox.TabIndex = 11;
            this.bmsTempErrorBox.TabStop = false;
            // 
            // bmsLowVoltErrorBox
            // 
            this.bmsLowVoltErrorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsLowVoltErrorBox.Location = new System.Drawing.Point(137, 51);
            this.bmsLowVoltErrorBox.Name = "bmsLowVoltErrorBox";
            this.bmsLowVoltErrorBox.Size = new System.Drawing.Size(42, 36);
            this.bmsLowVoltErrorBox.TabIndex = 10;
            this.bmsLowVoltErrorBox.TabStop = false;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(6, 183);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(122, 42);
            this.label46.TabIndex = 8;
            this.label46.Text = "OVER CUR ERR";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label47.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(6, 138);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(122, 42);
            this.label47.TabIndex = 6;
            this.label47.Text = "COMM ERR";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label48.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(6, 93);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(122, 42);
            this.label48.TabIndex = 4;
            this.label48.Text = "TEMP ERR";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(6, 48);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(122, 42);
            this.label49.TabIndex = 2;
            this.label49.Text = "LOW VOLT ERR";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label50.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(6, 3);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(122, 42);
            this.label50.TabIndex = 0;
            this.label50.Text = "HIGH VOLT ERR";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bmsHighVoltErrBox
            // 
            this.bmsHighVoltErrBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsHighVoltErrBox.Location = new System.Drawing.Point(137, 6);
            this.bmsHighVoltErrBox.Name = "bmsHighVoltErrBox";
            this.bmsHighVoltErrBox.Size = new System.Drawing.Size(42, 36);
            this.bmsHighVoltErrBox.TabIndex = 9;
            this.bmsHighVoltErrBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel18);
            this.groupBox4.Controls.Add(this.tableLayoutPanel17);
            this.groupBox4.Controls.Add(this.tableLayoutPanel6);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(6, 601);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(684, 160);
            this.groupBox4.TabIndex = 118;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "YARIŞ";
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel18.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel18.ColumnCount = 2;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08295F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.91705F));
            this.tableLayoutPanel18.Controls.Add(this.label81, 0, 2);
            this.tableLayoutPanel18.Controls.Add(this.lastLapBox, 0, 2);
            this.tableLayoutPanel18.Controls.Add(this.currentLapBox, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.fastestLapBox, 1, 1);
            this.tableLayoutPanel18.Controls.Add(this.label79, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.label80, 0, 1);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(458, 27);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 3;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(220, 123);
            this.tableLayoutPanel18.TabIndex = 40;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label81.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label81.Location = new System.Drawing.Point(6, 83);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(91, 37);
            this.label81.TabIndex = 109;
            this.label81.Text = "Son Tur";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastLapBox
            // 
            this.lastLapBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.lastLapBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastLapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastLapBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastLapBox.ForeColor = System.Drawing.Color.White;
            this.lastLapBox.Location = new System.Drawing.Point(106, 86);
            this.lastLapBox.Multiline = true;
            this.lastLapBox.Name = "lastLapBox";
            this.lastLapBox.ReadOnly = true;
            this.lastLapBox.Size = new System.Drawing.Size(108, 31);
            this.lastLapBox.TabIndex = 108;
            this.lastLapBox.Text = "00:00:00";
            this.lastLapBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentLapBox
            // 
            this.currentLapBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.currentLapBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentLapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentLapBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentLapBox.ForeColor = System.Drawing.Color.White;
            this.currentLapBox.Location = new System.Drawing.Point(106, 6);
            this.currentLapBox.Multiline = true;
            this.currentLapBox.Name = "currentLapBox";
            this.currentLapBox.ReadOnly = true;
            this.currentLapBox.Size = new System.Drawing.Size(108, 31);
            this.currentLapBox.TabIndex = 107;
            this.currentLapBox.Text = "00:00:00";
            this.currentLapBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fastestLapBox
            // 
            this.fastestLapBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.fastestLapBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fastestLapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastestLapBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fastestLapBox.ForeColor = System.Drawing.Color.White;
            this.fastestLapBox.Location = new System.Drawing.Point(106, 46);
            this.fastestLapBox.Multiline = true;
            this.fastestLapBox.Name = "fastestLapBox";
            this.fastestLapBox.ReadOnly = true;
            this.fastestLapBox.Size = new System.Drawing.Size(108, 31);
            this.fastestLapBox.TabIndex = 106;
            this.fastestLapBox.Text = "00:00:00";
            this.fastestLapBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label79.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label79.Location = new System.Drawing.Point(6, 3);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(91, 37);
            this.label79.TabIndex = 0;
            this.label79.Text = "Şimdiki Tur";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label80.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label80.Location = new System.Drawing.Point(6, 43);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(91, 37);
            this.label80.TabIndex = 7;
            this.label80.Text = "En Hızlı Tur";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel17.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel17.Controls.Add(this.distTravelledBox, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.distRemainingBox, 1, 1);
            this.tableLayoutPanel17.Controls.Add(this.avgSpeedBox, 0, 2);
            this.tableLayoutPanel17.Controls.Add(this.label76, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.label77, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.label78, 0, 2);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(229, 27);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 3;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(226, 123);
            this.tableLayoutPanel17.TabIndex = 39;
            // 
            // distTravelledBox
            // 
            this.distTravelledBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.distTravelledBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.distTravelledBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.distTravelledBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.distTravelledBox.ForeColor = System.Drawing.Color.White;
            this.distTravelledBox.Location = new System.Drawing.Point(101, 6);
            this.distTravelledBox.Multiline = true;
            this.distTravelledBox.Name = "distTravelledBox";
            this.distTravelledBox.ReadOnly = true;
            this.distTravelledBox.Size = new System.Drawing.Size(119, 31);
            this.distTravelledBox.TabIndex = 109;
            this.distTravelledBox.Text = "0.000 km";
            this.distTravelledBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // distRemainingBox
            // 
            this.distRemainingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.distRemainingBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.distRemainingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.distRemainingBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.distRemainingBox.ForeColor = System.Drawing.Color.White;
            this.distRemainingBox.Location = new System.Drawing.Point(101, 46);
            this.distRemainingBox.Multiline = true;
            this.distRemainingBox.Name = "distRemainingBox";
            this.distRemainingBox.ReadOnly = true;
            this.distRemainingBox.Size = new System.Drawing.Size(119, 31);
            this.distRemainingBox.TabIndex = 109;
            this.distRemainingBox.Text = "5.338 km";
            this.distRemainingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avgSpeedBox
            // 
            this.avgSpeedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.avgSpeedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avgSpeedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avgSpeedBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.avgSpeedBox.ForeColor = System.Drawing.Color.White;
            this.avgSpeedBox.Location = new System.Drawing.Point(101, 86);
            this.avgSpeedBox.Multiline = true;
            this.avgSpeedBox.Name = "avgSpeedBox";
            this.avgSpeedBox.ReadOnly = true;
            this.avgSpeedBox.Size = new System.Drawing.Size(119, 31);
            this.avgSpeedBox.TabIndex = 108;
            this.avgSpeedBox.Text = "0 km/h";
            this.avgSpeedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label76.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label76.Location = new System.Drawing.Point(6, 3);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(86, 37);
            this.label76.TabIndex = 0;
            this.label76.Text = "Gidilen Yol";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label77.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label77.Location = new System.Drawing.Point(6, 43);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(86, 37);
            this.label77.TabIndex = 7;
            this.label77.Text = "Kalan Yol";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label78.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label78.Location = new System.Drawing.Point(6, 83);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(86, 37);
            this.label78.TabIndex = 10;
            this.label78.Text = "Ort Hız";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.72126F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.27874F));
            this.tableLayoutPanel6.Controls.Add(this.timeElapsedBox, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.timeLeftBox, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.avgLapTimeBox, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 27);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(220, 123);
            this.tableLayoutPanel6.TabIndex = 38;
            // 
            // timeElapsedBox
            // 
            this.timeElapsedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.timeElapsedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeElapsedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeElapsedBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeElapsedBox.ForeColor = System.Drawing.Color.White;
            this.timeElapsedBox.Location = new System.Drawing.Point(92, 6);
            this.timeElapsedBox.Multiline = true;
            this.timeElapsedBox.Name = "timeElapsedBox";
            this.timeElapsedBox.ReadOnly = true;
            this.timeElapsedBox.Size = new System.Drawing.Size(122, 31);
            this.timeElapsedBox.TabIndex = 107;
            this.timeElapsedBox.Text = "00:00:00";
            this.timeElapsedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeLeftBox
            // 
            this.timeLeftBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.timeLeftBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeLeftBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLeftBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLeftBox.ForeColor = System.Drawing.Color.White;
            this.timeLeftBox.Location = new System.Drawing.Point(92, 46);
            this.timeLeftBox.Multiline = true;
            this.timeLeftBox.Name = "timeLeftBox";
            this.timeLeftBox.ReadOnly = true;
            this.timeLeftBox.Size = new System.Drawing.Size(122, 31);
            this.timeLeftBox.TabIndex = 106;
            this.timeLeftBox.Text = "00:00:00";
            this.timeLeftBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avgLapTimeBox
            // 
            this.avgLapTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.avgLapTimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avgLapTimeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avgLapTimeBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.avgLapTimeBox.ForeColor = System.Drawing.Color.White;
            this.avgLapTimeBox.Location = new System.Drawing.Point(92, 86);
            this.avgLapTimeBox.Multiline = true;
            this.avgLapTimeBox.Name = "avgLapTimeBox";
            this.avgLapTimeBox.ReadOnly = true;
            this.avgLapTimeBox.Size = new System.Drawing.Size(122, 31);
            this.avgLapTimeBox.TabIndex = 105;
            this.avgLapTimeBox.Text = "00:00:00";
            this.avgLapTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Geçen Süre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 37);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kalan Süre";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 37);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ort Tur Süresi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel12);
            this.groupBox5.Controls.Add(this.tableLayoutPanel8);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(467, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(580, 201);
            this.groupBox5.TabIndex = 119;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MCU ERRORS";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel12.ColumnCount = 6;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel12.Controls.Add(this.zpcBox, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.underSpeedBox, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.underVoltVDCBox, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.overSpeedBox, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.pwmEnabledBox, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.label54, 5, 0);
            this.tableLayoutPanel12.Controls.Add(this.label58, 4, 0);
            this.tableLayoutPanel12.Controls.Add(this.label60, 3, 0);
            this.tableLayoutPanel12.Controls.Add(this.label61, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.label62, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.label64, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.driveModeBox, 5, 1);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(571, 80);
            this.tableLayoutPanel12.TabIndex = 112;
            // 
            // zpcBox
            // 
            this.zpcBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zpcBox.Location = new System.Drawing.Point(288, 44);
            this.zpcBox.Name = "zpcBox";
            this.zpcBox.Size = new System.Drawing.Size(85, 30);
            this.zpcBox.TabIndex = 109;
            this.zpcBox.TabStop = false;
            // 
            // underSpeedBox
            // 
            this.underSpeedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.underSpeedBox.Location = new System.Drawing.Point(100, 44);
            this.underSpeedBox.Name = "underSpeedBox";
            this.underSpeedBox.Size = new System.Drawing.Size(85, 30);
            this.underSpeedBox.TabIndex = 108;
            this.underSpeedBox.TabStop = false;
            // 
            // underVoltVDCBox
            // 
            this.underVoltVDCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.underVoltVDCBox.Location = new System.Drawing.Point(6, 44);
            this.underVoltVDCBox.Name = "underVoltVDCBox";
            this.underVoltVDCBox.Size = new System.Drawing.Size(85, 30);
            this.underVoltVDCBox.TabIndex = 107;
            this.underVoltVDCBox.TabStop = false;
            // 
            // overSpeedBox
            // 
            this.overSpeedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overSpeedBox.Location = new System.Drawing.Point(194, 44);
            this.overSpeedBox.Name = "overSpeedBox";
            this.overSpeedBox.Size = new System.Drawing.Size(85, 30);
            this.overSpeedBox.TabIndex = 106;
            this.overSpeedBox.TabStop = false;
            // 
            // pwmEnabledBox
            // 
            this.pwmEnabledBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwmEnabledBox.Location = new System.Drawing.Point(382, 44);
            this.pwmEnabledBox.Name = "pwmEnabledBox";
            this.pwmEnabledBox.Size = new System.Drawing.Size(85, 30);
            this.pwmEnabledBox.TabIndex = 105;
            this.pwmEnabledBox.TabStop = false;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(476, 3);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(89, 35);
            this.label54.TabIndex = 5;
            this.label54.Text = "MODE";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(382, 3);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(85, 35);
            this.label58.TabIndex = 4;
            this.label58.Text = "PWM ENABLED";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(288, 3);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(85, 35);
            this.label60.TabIndex = 3;
            this.label60.Text = "ZPC";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label61.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label61.ForeColor = System.Drawing.Color.White;
            this.label61.Location = new System.Drawing.Point(194, 3);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(85, 35);
            this.label61.TabIndex = 2;
            this.label61.Text = "OVER SPEED";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label62.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(100, 3);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(85, 35);
            this.label62.TabIndex = 1;
            this.label62.Text = "UNDER SPEED";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label64.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(6, 3);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(85, 35);
            this.label64.TabIndex = 0;
            this.label64.Text = "UNDER VOLT VDC";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driveModeBox
            // 
            this.driveModeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.driveModeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driveModeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveModeBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driveModeBox.ForeColor = System.Drawing.Color.White;
            this.driveModeBox.Location = new System.Drawing.Point(476, 44);
            this.driveModeBox.Multiline = true;
            this.driveModeBox.Name = "driveModeBox";
            this.driveModeBox.ReadOnly = true;
            this.driveModeBox.Size = new System.Drawing.Size(89, 30);
            this.driveModeBox.TabIndex = 104;
            this.driveModeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel8.ColumnCount = 6;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.Controls.Add(this.overCurABox, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.overCurCBox, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.overCurBBox, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.overCurIDCBox, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.overTempBox, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.overVoltVDCBox, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label15, 5, 0);
            this.tableLayoutPanel8.Controls.Add(this.label17, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.label21, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.label23, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.label32, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label33, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(571, 82);
            this.tableLayoutPanel8.TabIndex = 111;
            // 
            // overCurABox
            // 
            this.overCurABox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overCurABox.Location = new System.Drawing.Point(6, 45);
            this.overCurABox.Name = "overCurABox";
            this.overCurABox.Size = new System.Drawing.Size(85, 31);
            this.overCurABox.TabIndex = 15;
            this.overCurABox.TabStop = false;
            // 
            // overCurCBox
            // 
            this.overCurCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overCurCBox.Location = new System.Drawing.Point(194, 45);
            this.overCurCBox.Name = "overCurCBox";
            this.overCurCBox.Size = new System.Drawing.Size(85, 31);
            this.overCurCBox.TabIndex = 14;
            this.overCurCBox.TabStop = false;
            // 
            // overCurBBox
            // 
            this.overCurBBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overCurBBox.Location = new System.Drawing.Point(100, 45);
            this.overCurBBox.Name = "overCurBBox";
            this.overCurBBox.Size = new System.Drawing.Size(85, 31);
            this.overCurBBox.TabIndex = 13;
            this.overCurBBox.TabStop = false;
            // 
            // overCurIDCBox
            // 
            this.overCurIDCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overCurIDCBox.Location = new System.Drawing.Point(288, 45);
            this.overCurIDCBox.Name = "overCurIDCBox";
            this.overCurIDCBox.Size = new System.Drawing.Size(85, 31);
            this.overCurIDCBox.TabIndex = 12;
            this.overCurIDCBox.TabStop = false;
            // 
            // overTempBox
            // 
            this.overTempBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overTempBox.Location = new System.Drawing.Point(476, 45);
            this.overTempBox.Name = "overTempBox";
            this.overTempBox.Size = new System.Drawing.Size(89, 31);
            this.overTempBox.TabIndex = 11;
            this.overTempBox.TabStop = false;
            // 
            // overVoltVDCBox
            // 
            this.overVoltVDCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overVoltVDCBox.Location = new System.Drawing.Point(382, 45);
            this.overVoltVDCBox.Name = "overVoltVDCBox";
            this.overVoltVDCBox.Size = new System.Drawing.Size(85, 31);
            this.overVoltVDCBox.TabIndex = 10;
            this.overVoltVDCBox.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(476, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 36);
            this.label15.TabIndex = 5;
            this.label15.Text = "OVER TEMP";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(382, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 36);
            this.label17.TabIndex = 4;
            this.label17.Text = "OVER VOLT VDC";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(288, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 36);
            this.label21.TabIndex = 3;
            this.label21.Text = "OVER CUR IDC";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(194, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 36);
            this.label23.TabIndex = 2;
            this.label23.Text = "OVER CUR C";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(100, 3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(85, 36);
            this.label32.TabIndex = 1;
            this.label32.Text = "OVER CUR B";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(6, 3);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(85, 36);
            this.label33.TabIndex = 0;
            this.label33.Text = "OVER CUR A";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel16);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(467, 492);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(580, 117);
            this.groupBox6.TabIndex = 120;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "STATUS";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel16.ColumnCount = 7;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel16.Controls.Add(this.label82, 6, 0);
            this.tableLayoutPanel16.Controls.Add(this.mqttBox, 4, 1);
            this.tableLayoutPanel16.Controls.Add(this.bmsCanBox, 2, 1);
            this.tableLayoutPanel16.Controls.Add(this.gpsReadyBox, 6, 1);
            this.tableLayoutPanel16.Controls.Add(this.mcuCanBox, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.label65, 5, 0);
            this.tableLayoutPanel16.Controls.Add(this.logBox, 5, 1);
            this.tableLayoutPanel16.Controls.Add(this.label66, 4, 0);
            this.tableLayoutPanel16.Controls.Add(this.label67, 3, 0);
            this.tableLayoutPanel16.Controls.Add(this.emsCanBox, 3, 1);
            this.tableLayoutPanel16.Controls.Add(this.vcuCanBox, 1, 1);
            this.tableLayoutPanel16.Controls.Add(this.label69, 2, 0);
            this.tableLayoutPanel16.Controls.Add(this.label73, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.label75, 0, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(574, 87);
            this.tableLayoutPanel16.TabIndex = 112;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label82.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label82.ForeColor = System.Drawing.Color.White;
            this.label82.Location = new System.Drawing.Point(492, 3);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(76, 39);
            this.label82.TabIndex = 124;
            this.label82.Text = "GPS";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mqttBox
            // 
            this.mqttBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mqttBox.Location = new System.Drawing.Point(330, 48);
            this.mqttBox.Name = "mqttBox";
            this.mqttBox.Size = new System.Drawing.Size(72, 33);
            this.mqttBox.TabIndex = 10;
            this.mqttBox.TabStop = false;
            // 
            // bmsCanBox
            // 
            this.bmsCanBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsCanBox.Location = new System.Drawing.Point(168, 48);
            this.bmsCanBox.Name = "bmsCanBox";
            this.bmsCanBox.Size = new System.Drawing.Size(72, 33);
            this.bmsCanBox.TabIndex = 14;
            this.bmsCanBox.TabStop = false;
            // 
            // gpsReadyBox
            // 
            this.gpsReadyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpsReadyBox.Location = new System.Drawing.Point(492, 48);
            this.gpsReadyBox.Name = "gpsReadyBox";
            this.gpsReadyBox.Size = new System.Drawing.Size(76, 33);
            this.gpsReadyBox.TabIndex = 124;
            this.gpsReadyBox.TabStop = false;
            // 
            // mcuCanBox
            // 
            this.mcuCanBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcuCanBox.Location = new System.Drawing.Point(6, 48);
            this.mcuCanBox.Name = "mcuCanBox";
            this.mcuCanBox.Size = new System.Drawing.Size(72, 33);
            this.mcuCanBox.TabIndex = 15;
            this.mcuCanBox.TabStop = false;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label65.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label65.ForeColor = System.Drawing.Color.White;
            this.label65.Location = new System.Drawing.Point(411, 3);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(72, 39);
            this.label65.TabIndex = 5;
            this.label65.Text = "LOG";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(411, 48);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(72, 33);
            this.logBox.TabIndex = 11;
            this.logBox.TabStop = false;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label66.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(330, 3);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(72, 39);
            this.label66.TabIndex = 4;
            this.label66.Text = "MQTT";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label67.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(249, 3);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(72, 39);
            this.label67.TabIndex = 3;
            this.label67.Text = "EMS CAN";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emsCanBox
            // 
            this.emsCanBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emsCanBox.Location = new System.Drawing.Point(249, 48);
            this.emsCanBox.Name = "emsCanBox";
            this.emsCanBox.Size = new System.Drawing.Size(72, 33);
            this.emsCanBox.TabIndex = 12;
            this.emsCanBox.TabStop = false;
            // 
            // vcuCanBox
            // 
            this.vcuCanBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vcuCanBox.Location = new System.Drawing.Point(87, 48);
            this.vcuCanBox.Name = "vcuCanBox";
            this.vcuCanBox.Size = new System.Drawing.Size(72, 33);
            this.vcuCanBox.TabIndex = 13;
            this.vcuCanBox.TabStop = false;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label69.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(168, 3);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(72, 39);
            this.label69.TabIndex = 2;
            this.label69.Text = "BMS CAN";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label73.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label73.ForeColor = System.Drawing.Color.White;
            this.label73.Location = new System.Drawing.Point(87, 3);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(72, 39);
            this.label73.TabIndex = 1;
            this.label73.Text = "VCU CAN";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label75.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label75.ForeColor = System.Drawing.Color.White;
            this.label75.Location = new System.Drawing.Point(6, 3);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(72, 39);
            this.label75.TabIndex = 0;
            this.label75.Text = "MCU CAN";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel19);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(696, 605);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(351, 156);
            this.groupBox7.TabIndex = 121;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Wake Up";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel19.ColumnCount = 4;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel19.Controls.Add(this.bmsWakeBox, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.mcuWakeBox, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.emsWakeBox, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.igniWakeBox, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.label84, 3, 0);
            this.tableLayoutPanel19.Controls.Add(this.label85, 2, 0);
            this.tableLayoutPanel19.Controls.Add(this.label86, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.label87, 0, 0);
            this.tableLayoutPanel19.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 2;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(342, 78);
            this.tableLayoutPanel19.TabIndex = 113;
            // 
            // bmsWakeBox
            // 
            this.bmsWakeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsWakeBox.Location = new System.Drawing.Point(6, 43);
            this.bmsWakeBox.Name = "bmsWakeBox";
            this.bmsWakeBox.Size = new System.Drawing.Size(75, 29);
            this.bmsWakeBox.TabIndex = 19;
            this.bmsWakeBox.TabStop = false;
            // 
            // mcuWakeBox
            // 
            this.mcuWakeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcuWakeBox.Location = new System.Drawing.Point(90, 43);
            this.mcuWakeBox.Name = "mcuWakeBox";
            this.mcuWakeBox.Size = new System.Drawing.Size(75, 29);
            this.mcuWakeBox.TabIndex = 18;
            this.mcuWakeBox.TabStop = false;
            // 
            // emsWakeBox
            // 
            this.emsWakeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emsWakeBox.Location = new System.Drawing.Point(174, 43);
            this.emsWakeBox.Name = "emsWakeBox";
            this.emsWakeBox.Size = new System.Drawing.Size(75, 29);
            this.emsWakeBox.TabIndex = 17;
            this.emsWakeBox.TabStop = false;
            // 
            // igniWakeBox
            // 
            this.igniWakeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.igniWakeBox.Location = new System.Drawing.Point(258, 43);
            this.igniWakeBox.Name = "igniWakeBox";
            this.igniWakeBox.Size = new System.Drawing.Size(78, 29);
            this.igniWakeBox.TabIndex = 16;
            this.igniWakeBox.TabStop = false;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label84.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label84.ForeColor = System.Drawing.Color.White;
            this.label84.Location = new System.Drawing.Point(258, 3);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(78, 34);
            this.label84.TabIndex = 3;
            this.label84.Text = "IGNITION";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label85.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label85.ForeColor = System.Drawing.Color.White;
            this.label85.Location = new System.Drawing.Point(174, 3);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(75, 34);
            this.label85.TabIndex = 2;
            this.label85.Text = "EMS";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label86.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label86.ForeColor = System.Drawing.Color.White;
            this.label86.Location = new System.Drawing.Point(90, 3);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(75, 34);
            this.label86.TabIndex = 1;
            this.label86.Text = "MCU";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label87.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label87.ForeColor = System.Drawing.Color.White;
            this.label87.Location = new System.Drawing.Point(6, 3);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(75, 34);
            this.label87.TabIndex = 0;
            this.label87.Text = "BMS";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // telemetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tableLayoutPanel11);
            this.Controls.Add(this.tableLayoutPanel10);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.targetSpeedBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.gpsSpeedBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telemetry";
            this.Text = "AESK Telemetry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telemetry_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gmap_sag.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
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
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmsFatalErrorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsOverCurErrorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsCommErrorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsTempErrorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsLowVoltErrorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsHighVoltErrBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zpcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underSpeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underVoltVDCBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overSpeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwmEnabledBox)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overCurABox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overCurCBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overCurBBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overCurIDCBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overTempBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overVoltVDCBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mqttBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmsCanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpsReadyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcuCanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsCanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcuCanBox)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmsWakeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcuWakeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsWakeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igniWakeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TextBox actIdBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox setIdBox;
        private System.Windows.Forms.TextBox setIqBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TextBox vdcBox;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox idcBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox vdBox;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox vqBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox emsTempBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox emsSharingBox;
        private System.Windows.Forms.TextBox emsPenaltyBox;
        private System.Windows.Forms.TextBox emsFcLtConsBox;
        private System.Windows.Forms.TextBox emsOutConsBox;
        private System.Windows.Forms.TextBox emsFcConsBox;
        private System.Windows.Forms.TextBox emsBatConsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox emsOutCurBox;
        private System.Windows.Forms.TextBox emsFcCurBox;
        private System.Windows.Forms.TextBox emsBatCurBox;
        private System.Windows.Forms.TextBox emsOutVoltageBox;
        private System.Windows.Forms.TextBox emsFcVoltBox;
        private System.Windows.Forms.TextBox emsBatVoltBox;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.PictureBox ems_bat_volt_error;
        private System.Windows.Forms.PictureBox ems_fc_voltage_error;
        private System.Windows.Forms.PictureBox ems_out_voltage_error;
        private System.Windows.Forms.PictureBox ems_bat_current_error;
        private System.Windows.Forms.PictureBox ems_fc_current_error;
        private System.Windows.Forms.PictureBox out_current_error;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TextBox uydu_sayisi;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox gps_verim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox mqtt_toplam_paket;
        private System.Windows.Forms.TextBox mqtt_solved_paket;
        private System.Windows.Forms.TextBox mqtt_verim;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label targetSpeedBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label gpsSpeedBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yarışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gSMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlantıyıKesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eklentilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turAtToolStripMenuItem;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox actTorqueBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox setTorqueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox actIqBox;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox actSpeedBox;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox setSpeedBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox bmsTempBox;
        private System.Windows.Forms.TextBox bmsWcaBox;
        private System.Windows.Forms.TextBox bmsWcvBox;
        private System.Windows.Forms.TextBox bmsSocBox;
        private System.Windows.Forms.TextBox bmsBatConsBox;
        private System.Windows.Forms.TextBox bmsBatCurBox;
        private System.Windows.Forms.TextBox bmsBatVoltBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox bmsFatalErrorBox;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.PictureBox bmsOverCurErrorBox;
        private System.Windows.Forms.PictureBox bmsCommErrorBox;
        private System.Windows.Forms.PictureBox bmsTempErrorBox;
        private System.Windows.Forms.PictureBox bmsLowVoltErrorBox;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.PictureBox bmsHighVoltErrBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.PictureBox zpcBox;
        private System.Windows.Forms.PictureBox underSpeedBox;
        private System.Windows.Forms.PictureBox underVoltVDCBox;
        private System.Windows.Forms.PictureBox overSpeedBox;
        private System.Windows.Forms.PictureBox pwmEnabledBox;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox driveModeBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.PictureBox overCurABox;
        private System.Windows.Forms.PictureBox overCurCBox;
        private System.Windows.Forms.PictureBox overCurBBox;
        private System.Windows.Forms.PictureBox overCurIDCBox;
        private System.Windows.Forms.PictureBox overTempBox;
        private System.Windows.Forms.PictureBox overVoltVDCBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.PictureBox mcuCanBox;
        private System.Windows.Forms.PictureBox bmsCanBox;
        private System.Windows.Forms.PictureBox vcuCanBox;
        private System.Windows.Forms.PictureBox emsCanBox;
        private System.Windows.Forms.PictureBox logBox;
        private System.Windows.Forms.PictureBox mqttBox;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.ToolStripMenuItem turSayımıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turAtToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.TextBox currentLapBox;
        private System.Windows.Forms.TextBox fastestLapBox;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.TextBox distTravelledBox;
        private System.Windows.Forms.TextBox distRemainingBox;
        private System.Windows.Forms.TextBox avgSpeedBox;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox timeElapsedBox;
        private System.Windows.Forms.TextBox timeLeftBox;
        private System.Windows.Forms.TextBox avgLapTimeBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.PictureBox bmsWakeBox;
        private System.Windows.Forms.PictureBox mcuWakeBox;
        private System.Windows.Forms.PictureBox emsWakeBox;
        private System.Windows.Forms.PictureBox igniWakeBox;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox lastLapBox;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.PictureBox gpsReadyBox;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
    }
}

