namespace Telemetry
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıyıKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaGrafiğeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidromobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batConsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fcConsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outConsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fcLtConsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elektromobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikEkranıAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikDurdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yarışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cicikuşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turAtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gpsMouseModAktifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpsMouseModKapalıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markerTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gmaptable = new System.Windows.Forms.TableLayoutPanel();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.grafiktablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.datagridtable = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur_dakika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yol_vcu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yol_gps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalama_hiz_vcu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalama_hiz_gps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuketim_Bat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuketim_FC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuketim_FC_Lt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.süreturpanel = new System.Windows.Forms.TableLayoutPanel();
            this.hedef_hiz = new System.Windows.Forms.TextBox();
            this.anlik_tur_suresi = new System.Windows.Forms.TextBox();
            this.ortalama_tur_suresi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gsmvesüretable = new System.Windows.Forms.TableLayoutPanel();
            this.hiztable = new System.Windows.Forms.TableLayoutPanel();
            this.ort_hiz = new System.Windows.Forms.TextBox();
            this.maks_hiz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.driver_set_tork = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gsm_yenileme = new System.Windows.Forms.TextBox();
            this.set_hiz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mesafehiztable = new System.Windows.Forms.TableLayoutPanel();
            this.kalan_yol = new System.Windows.Forms.TextBox();
            this.gidilen_yol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.anlik_hiz = new System.Windows.Forms.TextBox();
            this.emsvoltpanel = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ems_bat_volt = new System.Windows.Forms.TextBox();
            this.ems_fc_volt = new System.Windows.Forms.TextBox();
            this.ems_out_volt = new System.Windows.Forms.TextBox();
            this.ems_bat_volt_error = new System.Windows.Forms.Label();
            this.ems_fc_volt_error = new System.Windows.Forms.Label();
            this.ems_out_volt_error = new System.Windows.Forms.Label();
            this.emsampertable = new System.Windows.Forms.TableLayoutPanel();
            this.ems_out_current = new System.Windows.Forms.TextBox();
            this.ems_fc_current = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ems_bat_current = new System.Windows.Forms.TextBox();
            this.ems_volt_errortable = new System.Windows.Forms.TableLayoutPanel();
            this.emscurrenterrorpanel = new System.Windows.Forms.TableLayoutPanel();
            this.ems_bat_current_error = new System.Windows.Forms.Label();
            this.ems_fc_current_error = new System.Windows.Forms.Label();
            this.ems_out_current_error = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ems_fc_lt_cons = new System.Windows.Forms.TextBox();
            this.ems_out_cons = new System.Windows.Forms.TextBox();
            this.ems_fc_cons = new System.Windows.Forms.TextBox();
            this.ems_bat_cons = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.ems_penalty = new System.Windows.Forms.TextBox();
            this.ems_bat_soc = new System.Windows.Forms.TextBox();
            this.ems_temp = new System.Windows.Forms.TextBox();
            this.EMS = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rfkontroltable = new System.Windows.Forms.TableLayoutPanel();
            this.verim = new System.Windows.Forms.TextBox();
            this.cozulen_paket = new System.Windows.Forms.TextBox();
            this.crc_hatali = new System.Windows.Forms.TextBox();
            this.baslik_hatali = new System.Windows.Forms.TextBox();
            this.gelen_bayt = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.secilen_port = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gidilen_yol_gps = new System.Windows.Forms.TextBox();
            this.anlik_hiz_gps = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.kalan_yol_gps = new System.Windows.Forms.TextBox();
            this.history_displayer = new System.Windows.Forms.HScrollBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label42 = new System.Windows.Forms.Label();
            this.turr = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.kalan_sure = new System.Windows.Forms.TextBox();
            this.gecen_sure = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.bms_over_cur_error = new System.Windows.Forms.Label();
            this.bms_high_volt_error = new System.Windows.Forms.Label();
            this.bms_low_volt_error = new System.Windows.Forms.Label();
            this.bms_temp_error = new System.Windows.Forms.Label();
            this.bms_comm_error = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label54 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.bms_precharge_flag = new System.Windows.Forms.Label();
            this.bms_discharge_flag = new System.Windows.Forms.Label();
            this.bms_dc_bus_ready_flag = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label41 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.bms_bat_cons = new System.Windows.Forms.TextBox();
            this.bms_bat_current = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.bms_bat_volt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.bms_worst_cell_address = new System.Windows.Forms.TextBox();
            this.bms_worst_cell_volt = new System.Windows.Forms.TextBox();
            this.bms_soc = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.bms_temp = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.gsm_durum = new System.Windows.Forms.TextBox();
            this.xbee_durum = new System.Windows.Forms.TextBox();
            this.ems_durum = new System.Windows.Forms.TextBox();
            this.bms_durum = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.driver_durum = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.motor_temp = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.label85 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.vd = new System.Windows.Forms.TextBox();
            this.vq = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.iq = new System.Windows.Forms.TextBox();
            this.act_torque = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.label73 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.phase_a_volt = new System.Windows.Forms.TextBox();
            this.phase_b_volt = new System.Windows.Forms.TextBox();
            this.phase_c_volt = new System.Windows.Forms.TextBox();
            this.dc_bus_volt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.dc_bus_cur = new System.Windows.Forms.TextBox();
            this.phase_c_cur = new System.Windows.Forms.TextBox();
            this.phase_b_cur = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.phase_a_cur = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.driver_fwrv_command = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.driver_ign_command = new System.Windows.Forms.TextBox();
            this.driver_brake_command = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.driver_fwrv_status = new System.Windows.Forms.TextBox();
            this.driver_brake_status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.driver_ign_status = new System.Windows.Forms.TextBox();
            this.time_counter = new System.Windows.Forms.Timer(this.components);
            this.gsm_trigger = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.id_error = new System.Windows.Forms.Label();
            this.motor_temp_error = new System.Windows.Forms.Label();
            this.dc_bus_amper_error = new System.Windows.Forms.Label();
            this.zpc = new System.Windows.Forms.Label();
            this.pwm_enabled = new System.Windows.Forms.Label();
            this.dc_bus_voltage_error = new System.Windows.Forms.Label();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gmaptable.SuspendLayout();
            this.grafiktablelayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.datagridtable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.süreturpanel.SuspendLayout();
            this.gsmvesüretable.SuspendLayout();
            this.hiztable.SuspendLayout();
            this.mesafehiztable.SuspendLayout();
            this.emsvoltpanel.SuspendLayout();
            this.emsampertable.SuspendLayout();
            this.ems_volt_errortable.SuspendLayout();
            this.emscurrenterrorpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.EMS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.rfkontroltable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gSMToolStripMenuItem,
            this.rFToolStripMenuItem,
            this.grafikToolStripMenuItem,
            this.yarışToolStripMenuItem,
            this.kayıtToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.cicikuşToolStripMenuItem,
            this.turAtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gSMToolStripMenuItem
            // 
            this.gSMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bağlanToolStripMenuItem,
            this.bağlantıyıKesToolStripMenuItem});
            this.gSMToolStripMenuItem.Name = "gSMToolStripMenuItem";
            this.gSMToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.gSMToolStripMenuItem.Text = "GSM";
            // 
            // bağlanToolStripMenuItem
            // 
            this.bağlanToolStripMenuItem.Name = "bağlanToolStripMenuItem";
            this.bağlanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.bağlanToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.bağlanToolStripMenuItem.Text = "Bağlan";
            this.bağlanToolStripMenuItem.Click += new System.EventHandler(this.bağlanToolStripMenuItem_Click);
            // 
            // bağlantıyıKesToolStripMenuItem
            // 
            this.bağlantıyıKesToolStripMenuItem.Name = "bağlantıyıKesToolStripMenuItem";
            this.bağlantıyıKesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.bağlantıyıKesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.bağlantıyıKesToolStripMenuItem.Text = "Bağlantıyı Kes";
            this.bağlantıyıKesToolStripMenuItem.Click += new System.EventHandler(this.bağlantıyıKesToolStripMenuItem_Click);
            // 
            // rFToolStripMenuItem
            // 
            this.rFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pORTToolStripMenuItem,
            this.bağlanToolStripMenuItem1,
            this.bağlantıKesToolStripMenuItem});
            this.rFToolStripMenuItem.Name = "rFToolStripMenuItem";
            this.rFToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.rFToolStripMenuItem.Text = "Xbee";
            // 
            // pORTToolStripMenuItem
            // 
            this.pORTToolStripMenuItem.Name = "pORTToolStripMenuItem";
            this.pORTToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pORTToolStripMenuItem.Text = "Port";
            this.pORTToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.pORTToolStripMenuItem_DropDownItemClicked);
            this.pORTToolStripMenuItem.MouseHover += new System.EventHandler(this.pORTToolStripMenuItem_MouseHover);
            // 
            // bağlanToolStripMenuItem1
            // 
            this.bağlanToolStripMenuItem1.Name = "bağlanToolStripMenuItem1";
            this.bağlanToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.bağlanToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.bağlanToolStripMenuItem1.Text = "Bağlan";
            this.bağlanToolStripMenuItem1.Click += new System.EventHandler(this.bağlanToolStripMenuItem1_Click);
            // 
            // bağlantıKesToolStripMenuItem
            // 
            this.bağlantıKesToolStripMenuItem.Name = "bağlantıKesToolStripMenuItem";
            this.bağlantıKesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.bağlantıKesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.bağlantıKesToolStripMenuItem.Text = "Bağlantı Kes";
            this.bağlantıKesToolStripMenuItem.Click += new System.EventHandler(this.bağlantıKesToolStripMenuItem_Click);
            // 
            // grafikToolStripMenuItem
            // 
            this.grafikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaGrafiğeEkleToolStripMenuItem,
            this.grafikEkranıAçToolStripMenuItem,
            this.grafikDurdurToolStripMenuItem});
            this.grafikToolStripMenuItem.Name = "grafikToolStripMenuItem";
            this.grafikToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.grafikToolStripMenuItem.Text = "Grafik ";
            // 
            // anaGrafiğeEkleToolStripMenuItem
            // 
            this.anaGrafiğeEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hidromobilToolStripMenuItem,
            this.elektromobilToolStripMenuItem});
            this.anaGrafiğeEkleToolStripMenuItem.Name = "anaGrafiğeEkleToolStripMenuItem";
            this.anaGrafiğeEkleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.anaGrafiğeEkleToolStripMenuItem.Text = "Ana Grafiğe Ekle";
            // 
            // hidromobilToolStripMenuItem
            // 
            this.hidromobilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batConsToolStripMenuItem,
            this.fcConsToolStripMenuItem,
            this.outConsToolStripMenuItem,
            this.fcLtConsToolStripMenuItem});
            this.hidromobilToolStripMenuItem.Name = "hidromobilToolStripMenuItem";
            this.hidromobilToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.hidromobilToolStripMenuItem.Text = "Hidromobil";
            this.hidromobilToolStripMenuItem.Click += new System.EventHandler(this.hidromobilToolStripMenuItem_Click);
            // 
            // batConsToolStripMenuItem
            // 
            this.batConsToolStripMenuItem.Name = "batConsToolStripMenuItem";
            this.batConsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.batConsToolStripMenuItem.Text = "Bat Cons";
            this.batConsToolStripMenuItem.Click += new System.EventHandler(this.batConsToolStripMenuItem_Click);
            // 
            // fcConsToolStripMenuItem
            // 
            this.fcConsToolStripMenuItem.Name = "fcConsToolStripMenuItem";
            this.fcConsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.fcConsToolStripMenuItem.Text = "Fc Cons";
            this.fcConsToolStripMenuItem.Click += new System.EventHandler(this.fcConsToolStripMenuItem_Click);
            // 
            // outConsToolStripMenuItem
            // 
            this.outConsToolStripMenuItem.Name = "outConsToolStripMenuItem";
            this.outConsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.outConsToolStripMenuItem.Text = "Out Cons";
            this.outConsToolStripMenuItem.Click += new System.EventHandler(this.outConsToolStripMenuItem_Click);
            // 
            // fcLtConsToolStripMenuItem
            // 
            this.fcLtConsToolStripMenuItem.Name = "fcLtConsToolStripMenuItem";
            this.fcLtConsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.fcLtConsToolStripMenuItem.Text = "Fc Lt Cons";
            this.fcLtConsToolStripMenuItem.Click += new System.EventHandler(this.fcLtConsToolStripMenuItem_Click);
            // 
            // elektromobilToolStripMenuItem
            // 
            this.elektromobilToolStripMenuItem.Name = "elektromobilToolStripMenuItem";
            this.elektromobilToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.elektromobilToolStripMenuItem.Text = "Elektromobil";
            this.elektromobilToolStripMenuItem.Click += new System.EventHandler(this.elektromobilToolStripMenuItem_Click);
            // 
            // grafikEkranıAçToolStripMenuItem
            // 
            this.grafikEkranıAçToolStripMenuItem.Name = "grafikEkranıAçToolStripMenuItem";
            this.grafikEkranıAçToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.grafikEkranıAçToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.grafikEkranıAçToolStripMenuItem.Text = "Grafik Çizdir";
            this.grafikEkranıAçToolStripMenuItem.Click += new System.EventHandler(this.grafikEkranıAçToolStripMenuItem_Click);
            // 
            // grafikDurdurToolStripMenuItem
            // 
            this.grafikDurdurToolStripMenuItem.Name = "grafikDurdurToolStripMenuItem";
            this.grafikDurdurToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.grafikDurdurToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.grafikDurdurToolStripMenuItem.Text = "Grafik Durdur";
            this.grafikDurdurToolStripMenuItem.Click += new System.EventHandler(this.grafikDurdurToolStripMenuItem_Click);
            // 
            // yarışToolStripMenuItem
            // 
            this.yarışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlatToolStripMenuItem,
            this.durdurToolStripMenuItem});
            this.yarışToolStripMenuItem.Name = "yarışToolStripMenuItem";
            this.yarışToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.yarışToolStripMenuItem.Text = "Yarış";
            // 
            // başlatToolStripMenuItem
            // 
            this.başlatToolStripMenuItem.Name = "başlatToolStripMenuItem";
            this.başlatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.başlatToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.başlatToolStripMenuItem.Text = "Başlat";
            this.başlatToolStripMenuItem.Click += new System.EventHandler(this.başlatToolStripMenuItem_Click);
            // 
            // durdurToolStripMenuItem
            // 
            this.durdurToolStripMenuItem.Name = "durdurToolStripMenuItem";
            this.durdurToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.durdurToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.durdurToolStripMenuItem.Text = "Durdur";
            this.durdurToolStripMenuItem.Click += new System.EventHandler(this.durdurToolStripMenuItem_Click);
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtAçToolStripMenuItem});
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.kayıtToolStripMenuItem.Text = "Kayıt";
            // 
            // kayıtAçToolStripMenuItem
            // 
            this.kayıtAçToolStripMenuItem.Name = "kayıtAçToolStripMenuItem";
            this.kayıtAçToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.kayıtAçToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.kayıtAçToolStripMenuItem.Text = "Kayıt Aç ";
            this.kayıtAçToolStripMenuItem.Click += new System.EventHandler(this.kayıtAçToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // cicikuşToolStripMenuItem
            // 
            this.cicikuşToolStripMenuItem.Name = "cicikuşToolStripMenuItem";
            this.cicikuşToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cicikuşToolStripMenuItem.Text = "Cicikuş";
            this.cicikuşToolStripMenuItem.Click += new System.EventHandler(this.cicikuşToolStripMenuItem_Click);
            // 
            // turAtToolStripMenuItem
            // 
            this.turAtToolStripMenuItem.Name = "turAtToolStripMenuItem";
            this.turAtToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.turAtToolStripMenuItem.Text = "Tur At";
            this.turAtToolStripMenuItem.Click += new System.EventHandler(this.turAtToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gpsMouseModAktifToolStripMenuItem,
            this.gpsMouseModKapalıToolStripMenuItem,
            this.markerTemizleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 70);
            // 
            // gpsMouseModAktifToolStripMenuItem
            // 
            this.gpsMouseModAktifToolStripMenuItem.Name = "gpsMouseModAktifToolStripMenuItem";
            this.gpsMouseModAktifToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.gpsMouseModAktifToolStripMenuItem.Text = "Gps Mouse Mod Aktif";
            this.gpsMouseModAktifToolStripMenuItem.Click += new System.EventHandler(this.gpsMouseModAktifToolStripMenuItem_Click);
            // 
            // gpsMouseModKapalıToolStripMenuItem
            // 
            this.gpsMouseModKapalıToolStripMenuItem.Name = "gpsMouseModKapalıToolStripMenuItem";
            this.gpsMouseModKapalıToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.gpsMouseModKapalıToolStripMenuItem.Text = "Gps Mouse Mod Kapalı";
            this.gpsMouseModKapalıToolStripMenuItem.Click += new System.EventHandler(this.gpsMouseModKapalıToolStripMenuItem_Click);
            // 
            // markerTemizleToolStripMenuItem
            // 
            this.markerTemizleToolStripMenuItem.Name = "markerTemizleToolStripMenuItem";
            this.markerTemizleToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.markerTemizleToolStripMenuItem.Text = "Marker Temizle";
            this.markerTemizleToolStripMenuItem.Click += new System.EventHandler(this.markerTemizleToolStripMenuItem_Click);
            // 
            // gmaptable
            // 
            this.gmaptable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmaptable.AutoSize = true;
            this.gmaptable.ColumnCount = 1;
            this.gmaptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gmaptable.Controls.Add(this.gmap, 0, 0);
            this.gmaptable.Location = new System.Drawing.Point(374, 328);
            this.gmaptable.Name = "gmaptable";
            this.gmaptable.RowCount = 1;
            this.gmaptable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gmaptable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.gmaptable.Size = new System.Drawing.Size(658, 706);
            this.gmaptable.TabIndex = 2;
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gmap.CanDragMap = true;
            this.gmap.ContextMenuStrip = this.contextMenuStrip1;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(2, 2);
            this.gmap.Margin = new System.Windows.Forms.Padding(2);
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
            this.gmap.Size = new System.Drawing.Size(654, 702);
            this.gmap.TabIndex = 6;
            this.gmap.Zoom = 0D;
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseClick);
            // 
            // grafiktablelayout
            // 
            this.grafiktablelayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grafiktablelayout.ColumnCount = 1;
            this.grafiktablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grafiktablelayout.Controls.Add(this.chart1, 0, 0);
            this.grafiktablelayout.Location = new System.Drawing.Point(462, 5);
            this.grafiktablelayout.Name = "grafiktablelayout";
            this.grafiktablelayout.RowCount = 1;
            this.grafiktablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grafiktablelayout.Size = new System.Drawing.Size(571, 369);
            this.grafiktablelayout.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "HidroMobil";
            legend1.Title = "Hidromobil";
            legend2.Enabled = false;
            legend2.Name = "ElektroMobil";
            legend2.Title = "Elektromobil";
            this.chart1.Legends.Add(legend1);
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Enabled = false;
            series1.Legend = "HidroMobil";
            series1.MarkerBorderWidth = 5;
            series1.Name = "Bat Cons";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Enabled = false;
            series2.Legend = "HidroMobil";
            series2.MarkerBorderWidth = 5;
            series2.Name = "Fc Cons";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Enabled = false;
            series3.Legend = "HidroMobil";
            series3.MarkerBorderWidth = 5;
            series3.Name = "Out Cons";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Enabled = false;
            series4.Legend = "HidroMobil";
            series4.MarkerBorderWidth = 5;
            series4.Name = "Fc Lt Cons";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(565, 363);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // datagridtable
            // 
            this.datagridtable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.datagridtable.BackColor = System.Drawing.Color.White;
            this.datagridtable.ColumnCount = 1;
            this.datagridtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.datagridtable.Controls.Add(this.dataGridView1, 0, 0);
            this.datagridtable.Location = new System.Drawing.Point(8, 328);
            this.datagridtable.Name = "datagridtable";
            this.datagridtable.RowCount = 1;
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.datagridtable.Size = new System.Drawing.Size(375, 706);
            this.datagridtable.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tur,
            this.tur_dakika,
            this.yol_vcu,
            this.yol_gps,
            this.ortalama_hiz_vcu,
            this.ortalama_hiz_gps,
            this.Tuketim_Bat,
            this.Tuketim_FC,
            this.Tuketim_FC_Lt,
            this.Cons_Out});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Telemetry.Properties.Settings.Default, "my_font4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView1.Font = global::Telemetry.Properties.Settings.Default.my_font4;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(369, 700);
            this.dataGridView1.TabIndex = 0;
            // 
            // tur
            // 
            this.tur.HeaderText = "TUR";
            this.tur.Name = "tur";
            this.tur.Width = 50;
            // 
            // tur_dakika
            // 
            this.tur_dakika.HeaderText = "SÜRE";
            this.tur_dakika.Name = "tur_dakika";
            // 
            // yol_vcu
            // 
            this.yol_vcu.HeaderText = "YOL(VCU)";
            this.yol_vcu.Name = "yol_vcu";
            // 
            // yol_gps
            // 
            this.yol_gps.HeaderText = "YOL(GPS)";
            this.yol_gps.Name = "yol_gps";
            // 
            // ortalama_hiz_vcu
            // 
            this.ortalama_hiz_vcu.HeaderText = "ORTALAMA HIZ (VCU)";
            this.ortalama_hiz_vcu.Name = "ortalama_hiz_vcu";
            // 
            // ortalama_hiz_gps
            // 
            this.ortalama_hiz_gps.HeaderText = "ORTALAMA HIZ(GPS)";
            this.ortalama_hiz_gps.Name = "ortalama_hiz_gps";
            this.ortalama_hiz_gps.Width = 90;
            // 
            // Tuketim_Bat
            // 
            this.Tuketim_Bat.HeaderText = "Cons_BAT";
            this.Tuketim_Bat.Name = "Tuketim_Bat";
            // 
            // Tuketim_FC
            // 
            this.Tuketim_FC.HeaderText = "Cons_FC";
            this.Tuketim_FC.Name = "Tuketim_FC";
            // 
            // Tuketim_FC_Lt
            // 
            this.Tuketim_FC_Lt.HeaderText = "Cons_FC_Lt";
            this.Tuketim_FC_Lt.Name = "Tuketim_FC_Lt";
            // 
            // Cons_Out
            // 
            this.Cons_Out.HeaderText = "Cons_Out";
            this.Cons_Out.Name = "Cons_Out";
            // 
            // süreturpanel
            // 
            this.süreturpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.süreturpanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.süreturpanel.ColumnCount = 3;
            this.süreturpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.51968F));
            this.süreturpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.48032F));
            this.süreturpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.süreturpanel.Controls.Add(this.hedef_hiz, 0, 1);
            this.süreturpanel.Controls.Add(this.anlik_tur_suresi, 0, 1);
            this.süreturpanel.Controls.Add(this.ortalama_tur_suresi, 0, 1);
            this.süreturpanel.Controls.Add(this.label4, 2, 0);
            this.süreturpanel.Controls.Add(this.label2, 1, 0);
            this.süreturpanel.Controls.Add(this.label1, 0, 0);
            this.süreturpanel.Location = new System.Drawing.Point(5, 5);
            this.süreturpanel.Margin = new System.Windows.Forms.Padding(2);
            this.süreturpanel.Name = "süreturpanel";
            this.süreturpanel.RowCount = 2;
            this.süreturpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.15585F));
            this.süreturpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.84415F));
            this.süreturpanel.Size = new System.Drawing.Size(452, 69);
            this.süreturpanel.TabIndex = 20;
            // 
            // hedef_hiz
            // 
            this.hedef_hiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.hedef_hiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hedef_hiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hedef_hiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hedef_hiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.hedef_hiz.Location = new System.Drawing.Point(6, 35);
            this.hedef_hiz.Multiline = true;
            this.hedef_hiz.Name = "hedef_hiz";
            this.hedef_hiz.Size = new System.Drawing.Size(88, 28);
            this.hedef_hiz.TabIndex = 14;
            this.hedef_hiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // anlik_tur_suresi
            // 
            this.anlik_tur_suresi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.anlik_tur_suresi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anlik_tur_suresi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anlik_tur_suresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlik_tur_suresi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.anlik_tur_suresi.Location = new System.Drawing.Point(103, 35);
            this.anlik_tur_suresi.Multiline = true;
            this.anlik_tur_suresi.Name = "anlik_tur_suresi";
            this.anlik_tur_suresi.Size = new System.Drawing.Size(122, 28);
            this.anlik_tur_suresi.TabIndex = 13;
            this.anlik_tur_suresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ortalama_tur_suresi
            // 
            this.ortalama_tur_suresi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.ortalama_tur_suresi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ortalama_tur_suresi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ortalama_tur_suresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ortalama_tur_suresi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.ortalama_tur_suresi.Location = new System.Drawing.Point(234, 35);
            this.ortalama_tur_suresi.Multiline = true;
            this.ortalama_tur_suresi.Name = "ortalama_tur_suresi";
            this.ortalama_tur_suresi.Size = new System.Drawing.Size(212, 28);
            this.ortalama_tur_suresi.TabIndex = 12;
            this.ortalama_tur_suresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.label4.Location = new System.Drawing.Point(234, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "ORT. TUR SÜRESİ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.label2.Location = new System.Drawing.Point(103, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "ANLIK TUR SÜRESİ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "HEDEF HIZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gsmvesüretable
            // 
            this.gsmvesüretable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.gsmvesüretable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.gsmvesüretable.ColumnCount = 1;
            this.gsmvesüretable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gsmvesüretable.Controls.Add(this.süreturpanel, 0, 0);
            this.gsmvesüretable.Controls.Add(this.hiztable, 0, 1);
            this.gsmvesüretable.Location = new System.Drawing.Point(0, 0);
            this.gsmvesüretable.Name = "gsmvesüretable";
            this.gsmvesüretable.RowCount = 2;
            this.gsmvesüretable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gsmvesüretable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.gsmvesüretable.Size = new System.Drawing.Size(462, 162);
            this.gsmvesüretable.TabIndex = 23;
            // 
            // hiztable
            // 
            this.hiztable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.hiztable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.hiztable.ColumnCount = 4;
            this.hiztable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.67742F));
            this.hiztable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.32258F));
            this.hiztable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.hiztable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.hiztable.Controls.Add(this.ort_hiz, 3, 0);
            this.hiztable.Controls.Add(this.maks_hiz, 1, 0);
            this.hiztable.Controls.Add(this.label6, 0, 0);
            this.hiztable.Controls.Add(this.driver_set_tork, 2, 1);
            this.hiztable.Controls.Add(this.label9, 0, 1);
            this.hiztable.Controls.Add(this.label7, 2, 0);
            this.hiztable.Controls.Add(this.gsm_yenileme, 3, 1);
            this.hiztable.Controls.Add(this.set_hiz, 1, 1);
            this.hiztable.Location = new System.Drawing.Point(6, 82);
            this.hiztable.Name = "hiztable";
            this.hiztable.RowCount = 2;
            this.hiztable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hiztable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hiztable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.hiztable.Size = new System.Drawing.Size(450, 74);
            this.hiztable.TabIndex = 25;
            // 
            // ort_hiz
            // 
            this.ort_hiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.ort_hiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ort_hiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ort_hiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ort_hiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.ort_hiz.Location = new System.Drawing.Point(213, 6);
            this.ort_hiz.Multiline = true;
            this.ort_hiz.Name = "ort_hiz";
            this.ort_hiz.ReadOnly = true;
            this.ort_hiz.Size = new System.Drawing.Size(231, 26);
            this.ort_hiz.TabIndex = 31;
            this.ort_hiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maks_hiz
            // 
            this.maks_hiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.maks_hiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maks_hiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maks_hiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maks_hiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.maks_hiz.Location = new System.Drawing.Point(65, 6);
            this.maks_hiz.Multiline = true;
            this.maks_hiz.Name = "maks_hiz";
            this.maks_hiz.ReadOnly = true;
            this.maks_hiz.Size = new System.Drawing.Size(32, 26);
            this.maks_hiz.TabIndex = 30;
            this.maks_hiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "MAKS HIZ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driver_set_tork
            // 
            this.driver_set_tork.AutoSize = true;
            this.driver_set_tork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_set_tork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_set_tork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.driver_set_tork.Location = new System.Drawing.Point(106, 38);
            this.driver_set_tork.Name = "driver_set_tork";
            this.driver_set_tork.Size = new System.Drawing.Size(98, 33);
            this.driver_set_tork.TabIndex = 6;
            this.driver_set_tork.Text = "GSM YENİLEME";
            this.driver_set_tork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 33);
            this.label9.TabIndex = 4;
            this.label9.Text = "SET HIZ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.label7.Location = new System.Drawing.Point(106, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "ORT.HIZ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gsm_yenileme
            // 
            this.gsm_yenileme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.gsm_yenileme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gsm_yenileme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gsm_yenileme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gsm_yenileme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.gsm_yenileme.Location = new System.Drawing.Point(213, 41);
            this.gsm_yenileme.Multiline = true;
            this.gsm_yenileme.Name = "gsm_yenileme";
            this.gsm_yenileme.ReadOnly = true;
            this.gsm_yenileme.Size = new System.Drawing.Size(231, 27);
            this.gsm_yenileme.TabIndex = 13;
            this.gsm_yenileme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // set_hiz
            // 
            this.set_hiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.set_hiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.set_hiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_hiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.set_hiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.set_hiz.Location = new System.Drawing.Point(65, 41);
            this.set_hiz.Multiline = true;
            this.set_hiz.Name = "set_hiz";
            this.set_hiz.ReadOnly = true;
            this.set_hiz.Size = new System.Drawing.Size(32, 27);
            this.set_hiz.TabIndex = 14;
            this.set_hiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "ANLIK HIZ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mesafehiztable
            // 
            this.mesafehiztable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(211)))));
            this.mesafehiztable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.mesafehiztable.ColumnCount = 3;
            this.mesafehiztable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.91262F));
            this.mesafehiztable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.08738F));
            this.mesafehiztable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.mesafehiztable.Controls.Add(this.kalan_yol, 2, 1);
            this.mesafehiztable.Controls.Add(this.gidilen_yol, 2, 0);
            this.mesafehiztable.Controls.Add(this.label10, 1, 0);
            this.mesafehiztable.Controls.Add(this.label15, 1, 1);
            this.mesafehiztable.Controls.Add(this.label5, 0, 0);
            this.mesafehiztable.Controls.Add(this.anlik_hiz, 0, 1);
            this.mesafehiztable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(45)))));
            this.mesafehiztable.Location = new System.Drawing.Point(-2, 162);
            this.mesafehiztable.Name = "mesafehiztable";
            this.mesafehiztable.RowCount = 2;
            this.mesafehiztable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.42105F));
            this.mesafehiztable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.57895F));
            this.mesafehiztable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mesafehiztable.Size = new System.Drawing.Size(464, 75);
            this.mesafehiztable.TabIndex = 24;
            // 
            // kalan_yol
            // 
            this.kalan_yol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(211)))));
            this.kalan_yol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kalan_yol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kalan_yol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalan_yol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(45)))));
            this.kalan_yol.Location = new System.Drawing.Point(168, 37);
            this.kalan_yol.Multiline = true;
            this.kalan_yol.Name = "kalan_yol";
            this.kalan_yol.ReadOnly = true;
            this.kalan_yol.Size = new System.Drawing.Size(290, 32);
            this.kalan_yol.TabIndex = 12;
            this.kalan_yol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gidilen_yol
            // 
            this.gidilen_yol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(211)))));
            this.gidilen_yol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gidilen_yol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gidilen_yol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gidilen_yol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(45)))));
            this.gidilen_yol.Location = new System.Drawing.Point(168, 6);
            this.gidilen_yol.Multiline = true;
            this.gidilen_yol.Name = "gidilen_yol";
            this.gidilen_yol.ReadOnly = true;
            this.gidilen_yol.Size = new System.Drawing.Size(290, 22);
            this.gidilen_yol.TabIndex = 11;
            this.gidilen_yol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(92, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "GİDİLEN YOL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(92, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 38);
            this.label15.TabIndex = 6;
            this.label15.Text = "KALAN YOL";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // anlik_hiz
            // 
            this.anlik_hiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(211)))));
            this.anlik_hiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anlik_hiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anlik_hiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlik_hiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(45)))));
            this.anlik_hiz.Location = new System.Drawing.Point(6, 37);
            this.anlik_hiz.Multiline = true;
            this.anlik_hiz.Name = "anlik_hiz";
            this.anlik_hiz.ReadOnly = true;
            this.anlik_hiz.Size = new System.Drawing.Size(77, 32);
            this.anlik_hiz.TabIndex = 9;
            this.anlik_hiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emsvoltpanel
            // 
            this.emsvoltpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.emsvoltpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.emsvoltpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emsvoltpanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.emsvoltpanel.ColumnCount = 2;
            this.emsvoltpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.emsvoltpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.emsvoltpanel.Controls.Add(this.label18, 0, 2);
            this.emsvoltpanel.Controls.Add(this.label14, 0, 1);
            this.emsvoltpanel.Controls.Add(this.label8, 0, 0);
            this.emsvoltpanel.Controls.Add(this.ems_bat_volt, 1, 0);
            this.emsvoltpanel.Controls.Add(this.ems_fc_volt, 1, 1);
            this.emsvoltpanel.Controls.Add(this.ems_out_volt, 1, 2);
            this.emsvoltpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.emsvoltpanel.Location = new System.Drawing.Point(0, 19);
            this.emsvoltpanel.Name = "emsvoltpanel";
            this.emsvoltpanel.RowCount = 3;
            this.emsvoltpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.emsvoltpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.emsvoltpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.emsvoltpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.emsvoltpanel.Size = new System.Drawing.Size(277, 153);
            this.emsvoltpanel.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(6, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 49);
            this.label18.TabIndex = 6;
            this.label18.Text = "OUT VOLT";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 46);
            this.label14.TabIndex = 3;
            this.label14.Text = "FC VOLT";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "BAT VOLT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ems_bat_volt
            // 
            this.ems_bat_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_bat_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_bat_volt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_bat_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_bat_volt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_bat_volt.Location = new System.Drawing.Point(143, 6);
            this.ems_bat_volt.Multiline = true;
            this.ems_bat_volt.Name = "ems_bat_volt";
            this.ems_bat_volt.ReadOnly = true;
            this.ems_bat_volt.Size = new System.Drawing.Size(128, 40);
            this.ems_bat_volt.TabIndex = 8;
            this.ems_bat_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_fc_volt
            // 
            this.ems_fc_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_fc_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_fc_volt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_fc_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_fc_volt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_fc_volt.Location = new System.Drawing.Point(143, 55);
            this.ems_fc_volt.Multiline = true;
            this.ems_fc_volt.Name = "ems_fc_volt";
            this.ems_fc_volt.ReadOnly = true;
            this.ems_fc_volt.Size = new System.Drawing.Size(128, 40);
            this.ems_fc_volt.TabIndex = 9;
            this.ems_fc_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_out_volt
            // 
            this.ems_out_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_out_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_out_volt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_out_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_out_volt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_out_volt.Location = new System.Drawing.Point(143, 104);
            this.ems_out_volt.Multiline = true;
            this.ems_out_volt.Name = "ems_out_volt";
            this.ems_out_volt.ReadOnly = true;
            this.ems_out_volt.Size = new System.Drawing.Size(128, 43);
            this.ems_out_volt.TabIndex = 10;
            this.ems_out_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_bat_volt_error
            // 
            this.ems_bat_volt_error.AutoSize = true;
            this.ems_bat_volt_error.BackColor = System.Drawing.Color.White;
            this.ems_bat_volt_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_bat_volt_error.Location = new System.Drawing.Point(6, 3);
            this.ems_bat_volt_error.Name = "ems_bat_volt_error";
            this.ems_bat_volt_error.Size = new System.Drawing.Size(44, 47);
            this.ems_bat_volt_error.TabIndex = 2;
            this.ems_bat_volt_error.Text = " ";
            // 
            // ems_fc_volt_error
            // 
            this.ems_fc_volt_error.AutoSize = true;
            this.ems_fc_volt_error.BackColor = System.Drawing.Color.White;
            this.ems_fc_volt_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_fc_volt_error.Location = new System.Drawing.Point(6, 53);
            this.ems_fc_volt_error.Name = "ems_fc_volt_error";
            this.ems_fc_volt_error.Size = new System.Drawing.Size(44, 47);
            this.ems_fc_volt_error.TabIndex = 5;
            this.ems_fc_volt_error.Text = " ";
            this.ems_fc_volt_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ems_out_volt_error
            // 
            this.ems_out_volt_error.AutoSize = true;
            this.ems_out_volt_error.BackColor = System.Drawing.Color.White;
            this.ems_out_volt_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_out_volt_error.Location = new System.Drawing.Point(6, 103);
            this.ems_out_volt_error.Name = "ems_out_volt_error";
            this.ems_out_volt_error.Size = new System.Drawing.Size(44, 47);
            this.ems_out_volt_error.TabIndex = 8;
            this.ems_out_volt_error.Text = " ";
            this.ems_out_volt_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emsampertable
            // 
            this.emsampertable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.emsampertable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.emsampertable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emsampertable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.emsampertable.ColumnCount = 2;
            this.emsampertable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.emsampertable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.emsampertable.Controls.Add(this.ems_out_current, 1, 2);
            this.emsampertable.Controls.Add(this.ems_fc_current, 1, 1);
            this.emsampertable.Controls.Add(this.label16, 0, 2);
            this.emsampertable.Controls.Add(this.label20, 0, 1);
            this.emsampertable.Controls.Add(this.label23, 0, 0);
            this.emsampertable.Controls.Add(this.ems_bat_current, 1, 0);
            this.emsampertable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.emsampertable.Location = new System.Drawing.Point(0, 168);
            this.emsampertable.Name = "emsampertable";
            this.emsampertable.RowCount = 3;
            this.emsampertable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.emsampertable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.emsampertable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.emsampertable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.emsampertable.Size = new System.Drawing.Size(277, 143);
            this.emsampertable.TabIndex = 25;
            // 
            // ems_out_current
            // 
            this.ems_out_current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_out_current.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_out_current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_out_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_out_current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_out_current.Location = new System.Drawing.Point(143, 98);
            this.ems_out_current.Multiline = true;
            this.ems_out_current.Name = "ems_out_current";
            this.ems_out_current.ReadOnly = true;
            this.ems_out_current.Size = new System.Drawing.Size(128, 39);
            this.ems_out_current.TabIndex = 9;
            this.ems_out_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_fc_current
            // 
            this.ems_fc_current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_fc_current.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_fc_current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_fc_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_fc_current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_fc_current.Location = new System.Drawing.Point(143, 52);
            this.ems_fc_current.Multiline = true;
            this.ems_fc_current.Name = "ems_fc_current";
            this.ems_fc_current.ReadOnly = true;
            this.ems_fc_current.Size = new System.Drawing.Size(128, 37);
            this.ems_fc_current.TabIndex = 8;
            this.ems_fc_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 45);
            this.label16.TabIndex = 6;
            this.label16.Text = "OUT CUR";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(6, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 43);
            this.label20.TabIndex = 3;
            this.label20.Text = "FC CUR";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(6, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(128, 43);
            this.label23.TabIndex = 0;
            this.label23.Text = "BAT CUR";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ems_bat_current
            // 
            this.ems_bat_current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_bat_current.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_bat_current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_bat_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_bat_current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_bat_current.Location = new System.Drawing.Point(143, 6);
            this.ems_bat_current.Multiline = true;
            this.ems_bat_current.Name = "ems_bat_current";
            this.ems_bat_current.ReadOnly = true;
            this.ems_bat_current.Size = new System.Drawing.Size(128, 37);
            this.ems_bat_current.TabIndex = 7;
            this.ems_bat_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_volt_errortable
            // 
            this.ems_volt_errortable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ems_volt_errortable.BackColor = System.Drawing.Color.White;
            this.ems_volt_errortable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.ems_volt_errortable.ColumnCount = 1;
            this.ems_volt_errortable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ems_volt_errortable.Controls.Add(this.ems_bat_volt_error, 0, 0);
            this.ems_volt_errortable.Controls.Add(this.ems_fc_volt_error, 0, 1);
            this.ems_volt_errortable.Controls.Add(this.ems_out_volt_error, 0, 2);
            this.ems_volt_errortable.Location = new System.Drawing.Point(277, 19);
            this.ems_volt_errortable.Name = "ems_volt_errortable";
            this.ems_volt_errortable.RowCount = 3;
            this.ems_volt_errortable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ems_volt_errortable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ems_volt_errortable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ems_volt_errortable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ems_volt_errortable.Size = new System.Drawing.Size(56, 153);
            this.ems_volt_errortable.TabIndex = 26;
            // 
            // emscurrenterrorpanel
            // 
            this.emscurrenterrorpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.emscurrenterrorpanel.BackColor = System.Drawing.Color.White;
            this.emscurrenterrorpanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.emscurrenterrorpanel.ColumnCount = 1;
            this.emscurrenterrorpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.emscurrenterrorpanel.Controls.Add(this.ems_bat_current_error, 0, 0);
            this.emscurrenterrorpanel.Controls.Add(this.ems_fc_current_error, 0, 1);
            this.emscurrenterrorpanel.Controls.Add(this.ems_out_current_error, 0, 2);
            this.emscurrenterrorpanel.Location = new System.Drawing.Point(277, 171);
            this.emscurrenterrorpanel.Name = "emscurrenterrorpanel";
            this.emscurrenterrorpanel.RowCount = 3;
            this.emscurrenterrorpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.emscurrenterrorpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.emscurrenterrorpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.emscurrenterrorpanel.Size = new System.Drawing.Size(56, 140);
            this.emscurrenterrorpanel.TabIndex = 27;
            // 
            // ems_bat_current_error
            // 
            this.ems_bat_current_error.AutoSize = true;
            this.ems_bat_current_error.BackColor = System.Drawing.Color.White;
            this.ems_bat_current_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_bat_current_error.Location = new System.Drawing.Point(6, 3);
            this.ems_bat_current_error.Name = "ems_bat_current_error";
            this.ems_bat_current_error.Size = new System.Drawing.Size(44, 42);
            this.ems_bat_current_error.TabIndex = 2;
            this.ems_bat_current_error.Text = " ";
            // 
            // ems_fc_current_error
            // 
            this.ems_fc_current_error.AutoSize = true;
            this.ems_fc_current_error.BackColor = System.Drawing.Color.White;
            this.ems_fc_current_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_fc_current_error.Location = new System.Drawing.Point(6, 48);
            this.ems_fc_current_error.Name = "ems_fc_current_error";
            this.ems_fc_current_error.Size = new System.Drawing.Size(44, 42);
            this.ems_fc_current_error.TabIndex = 5;
            this.ems_fc_current_error.Text = " ";
            this.ems_fc_current_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ems_out_current_error
            // 
            this.ems_out_current_error.AutoSize = true;
            this.ems_out_current_error.BackColor = System.Drawing.Color.White;
            this.ems_out_current_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_out_current_error.Location = new System.Drawing.Point(6, 93);
            this.ems_out_current_error.Name = "ems_out_current_error";
            this.ems_out_current_error.Size = new System.Drawing.Size(44, 44);
            this.ems_out_current_error.TabIndex = 8;
            this.ems_out_current_error.Text = " ";
            this.ems_out_current_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ems_fc_lt_cons, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ems_out_cons, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ems_fc_cons, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ems_bat_cons, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label27, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(337, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 156);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // ems_fc_lt_cons
            // 
            this.ems_fc_lt_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_fc_lt_cons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_fc_lt_cons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_fc_lt_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_fc_lt_cons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_fc_lt_cons.Location = new System.Drawing.Point(186, 120);
            this.ems_fc_lt_cons.Multiline = true;
            this.ems_fc_lt_cons.Name = "ems_fc_lt_cons";
            this.ems_fc_lt_cons.ReadOnly = true;
            this.ems_fc_lt_cons.Size = new System.Drawing.Size(172, 30);
            this.ems_fc_lt_cons.TabIndex = 41;
            this.ems_fc_lt_cons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_out_cons
            // 
            this.ems_out_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_out_cons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_out_cons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_out_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_out_cons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_out_cons.Location = new System.Drawing.Point(186, 82);
            this.ems_out_cons.Multiline = true;
            this.ems_out_cons.Name = "ems_out_cons";
            this.ems_out_cons.ReadOnly = true;
            this.ems_out_cons.Size = new System.Drawing.Size(172, 29);
            this.ems_out_cons.TabIndex = 40;
            this.ems_out_cons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_fc_cons
            // 
            this.ems_fc_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_fc_cons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_fc_cons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_fc_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_fc_cons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_fc_cons.Location = new System.Drawing.Point(186, 44);
            this.ems_fc_cons.Multiline = true;
            this.ems_fc_cons.Name = "ems_fc_cons";
            this.ems_fc_cons.ReadOnly = true;
            this.ems_fc_cons.Size = new System.Drawing.Size(172, 29);
            this.ems_fc_cons.TabIndex = 39;
            this.ems_fc_cons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_bat_cons
            // 
            this.ems_bat_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_bat_cons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_bat_cons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_bat_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_bat_cons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_bat_cons.Location = new System.Drawing.Point(186, 6);
            this.ems_bat_cons.Multiline = true;
            this.ems_bat_cons.Name = "ems_bat_cons";
            this.ems_bat_cons.ReadOnly = true;
            this.ems_bat_cons.Size = new System.Drawing.Size(172, 29);
            this.ems_bat_cons.TabIndex = 38;
            this.ems_bat_cons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(6, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(171, 35);
            this.label29.TabIndex = 0;
            this.label29.Text = "BAT CONS";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(6, 79);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(171, 35);
            this.label25.TabIndex = 6;
            this.label25.Text = "OUT CONS";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(6, 41);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(171, 35);
            this.label27.TabIndex = 3;
            this.label27.Text = "FC CONS";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 36);
            this.label13.TabIndex = 7;
            this.label13.Text = "FC LT CONS";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.label22, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label26, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ems_penalty, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ems_bat_soc, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ems_temp, 1, 2);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(336, 175);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(365, 136);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(6, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(172, 44);
            this.label22.TabIndex = 6;
            this.label22.Text = "TEMP";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(6, 46);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(172, 40);
            this.label26.TabIndex = 3;
            this.label26.Text = "BAT SOC";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(6, 3);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(172, 40);
            this.label30.TabIndex = 0;
            this.label30.Text = "PENALTY";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ems_penalty
            // 
            this.ems_penalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_penalty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_penalty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_penalty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_penalty.Location = new System.Drawing.Point(187, 6);
            this.ems_penalty.Multiline = true;
            this.ems_penalty.Name = "ems_penalty";
            this.ems_penalty.ReadOnly = true;
            this.ems_penalty.Size = new System.Drawing.Size(172, 34);
            this.ems_penalty.TabIndex = 9;
            this.ems_penalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_bat_soc
            // 
            this.ems_bat_soc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_bat_soc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_bat_soc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_bat_soc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_bat_soc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_bat_soc.Location = new System.Drawing.Point(187, 49);
            this.ems_bat_soc.Multiline = true;
            this.ems_bat_soc.Name = "ems_bat_soc";
            this.ems_bat_soc.ReadOnly = true;
            this.ems_bat_soc.Size = new System.Drawing.Size(172, 34);
            this.ems_bat_soc.TabIndex = 10;
            this.ems_bat_soc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_temp
            // 
            this.ems_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(180)))));
            this.ems_temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_temp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.ems_temp.Location = new System.Drawing.Point(187, 92);
            this.ems_temp.Multiline = true;
            this.ems_temp.Name = "ems_temp";
            this.ems_temp.ReadOnly = true;
            this.ems_temp.Size = new System.Drawing.Size(172, 38);
            this.ems_temp.TabIndex = 11;
            this.ems_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EMS
            // 
            this.EMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EMS.Controls.Add(this.tableLayoutPanel1);
            this.EMS.Controls.Add(this.emsvoltpanel);
            this.EMS.Controls.Add(this.tableLayoutPanel2);
            this.EMS.Controls.Add(this.emscurrenterrorpanel);
            this.EMS.Controls.Add(this.emsampertable);
            this.EMS.Controls.Add(this.ems_volt_errortable);
            this.EMS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EMS.Location = new System.Drawing.Point(0, 336);
            this.EMS.Name = "EMS";
            this.EMS.Size = new System.Drawing.Size(701, 317);
            this.EMS.TabIndex = 30;
            this.EMS.TabStop = false;
            this.EMS.Text = "EMS";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rfkontroltable);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(703, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 311);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RF KONTROL";
            // 
            // rfkontroltable
            // 
            this.rfkontroltable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rfkontroltable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.rfkontroltable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.rfkontroltable.ColumnCount = 2;
            this.rfkontroltable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rfkontroltable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rfkontroltable.Controls.Add(this.verim, 1, 5);
            this.rfkontroltable.Controls.Add(this.cozulen_paket, 1, 4);
            this.rfkontroltable.Controls.Add(this.crc_hatali, 1, 3);
            this.rfkontroltable.Controls.Add(this.baslik_hatali, 1, 2);
            this.rfkontroltable.Controls.Add(this.gelen_bayt, 1, 1);
            this.rfkontroltable.Controls.Add(this.label44, 0, 5);
            this.rfkontroltable.Controls.Add(this.label39, 0, 4);
            this.rfkontroltable.Controls.Add(this.label37, 0, 3);
            this.rfkontroltable.Controls.Add(this.label35, 0, 2);
            this.rfkontroltable.Controls.Add(this.label32, 0, 1);
            this.rfkontroltable.Controls.Add(this.label12, 0, 0);
            this.rfkontroltable.Controls.Add(this.secilen_port, 1, 0);
            this.rfkontroltable.Location = new System.Drawing.Point(6, 19);
            this.rfkontroltable.Name = "rfkontroltable";
            this.rfkontroltable.RowCount = 6;
            this.rfkontroltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.rfkontroltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.rfkontroltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.rfkontroltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.rfkontroltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.rfkontroltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.rfkontroltable.Size = new System.Drawing.Size(179, 286);
            this.rfkontroltable.TabIndex = 33;
            // 
            // verim
            // 
            this.verim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.verim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.verim.Location = new System.Drawing.Point(94, 241);
            this.verim.Multiline = true;
            this.verim.Name = "verim";
            this.verim.ReadOnly = true;
            this.verim.Size = new System.Drawing.Size(79, 39);
            this.verim.TabIndex = 17;
            this.verim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cozulen_paket
            // 
            this.cozulen_paket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.cozulen_paket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cozulen_paket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cozulen_paket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.cozulen_paket.Location = new System.Drawing.Point(94, 194);
            this.cozulen_paket.Multiline = true;
            this.cozulen_paket.Name = "cozulen_paket";
            this.cozulen_paket.ReadOnly = true;
            this.cozulen_paket.Size = new System.Drawing.Size(79, 38);
            this.cozulen_paket.TabIndex = 16;
            this.cozulen_paket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // crc_hatali
            // 
            this.crc_hatali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.crc_hatali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crc_hatali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crc_hatali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.crc_hatali.Location = new System.Drawing.Point(94, 147);
            this.crc_hatali.Multiline = true;
            this.crc_hatali.Name = "crc_hatali";
            this.crc_hatali.ReadOnly = true;
            this.crc_hatali.Size = new System.Drawing.Size(79, 38);
            this.crc_hatali.TabIndex = 15;
            this.crc_hatali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baslik_hatali
            // 
            this.baslik_hatali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.baslik_hatali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.baslik_hatali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baslik_hatali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.baslik_hatali.Location = new System.Drawing.Point(94, 100);
            this.baslik_hatali.Multiline = true;
            this.baslik_hatali.Name = "baslik_hatali";
            this.baslik_hatali.ReadOnly = true;
            this.baslik_hatali.Size = new System.Drawing.Size(79, 38);
            this.baslik_hatali.TabIndex = 14;
            this.baslik_hatali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gelen_bayt
            // 
            this.gelen_bayt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.gelen_bayt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gelen_bayt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gelen_bayt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.gelen_bayt.Location = new System.Drawing.Point(94, 53);
            this.gelen_bayt.Multiline = true;
            this.gelen_bayt.Name = "gelen_bayt";
            this.gelen_bayt.ReadOnly = true;
            this.gelen_bayt.Size = new System.Drawing.Size(79, 38);
            this.gelen_bayt.TabIndex = 13;
            this.gelen_bayt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.label44.Location = new System.Drawing.Point(6, 238);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(79, 45);
            this.label44.TabIndex = 11;
            this.label44.Text = "VERİM";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.label39.Location = new System.Drawing.Point(6, 191);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(79, 44);
            this.label39.TabIndex = 8;
            this.label39.Text = "ÇÖZÜLEN PAKET";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.label37.Location = new System.Drawing.Point(6, 144);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(79, 44);
            this.label37.TabIndex = 6;
            this.label37.Text = "CRC HATALI";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.label35.Location = new System.Drawing.Point(6, 97);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(79, 44);
            this.label35.TabIndex = 4;
            this.label35.Text = "BAŞLIK HATALI";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.label32.Location = new System.Drawing.Point(6, 50);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(79, 44);
            this.label32.TabIndex = 2;
            this.label32.Text = "GELEN BAYT";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 44);
            this.label12.TabIndex = 0;
            this.label12.Text = "PORT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secilen_port
            // 
            this.secilen_port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(209)))), ((int)(((byte)(149)))));
            this.secilen_port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secilen_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secilen_port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.secilen_port.Location = new System.Drawing.Point(94, 6);
            this.secilen_port.Multiline = true;
            this.secilen_port.Name = "secilen_port";
            this.secilen_port.ReadOnly = true;
            this.secilen_port.Size = new System.Drawing.Size(79, 38);
            this.secilen_port.TabIndex = 12;
            this.secilen_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.history_displayer);
            this.groupBox1.Controls.Add(this.gsmvesüretable);
            this.groupBox1.Controls.Add(this.mesafehiztable);
            this.groupBox1.Controls.Add(this.datagridtable);
            this.groupBox1.Controls.Add(this.gmaptable);
            this.groupBox1.Controls.Add(this.grafiktablelayout);
            this.groupBox1.Location = new System.Drawing.Point(892, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1212, 1034);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(211)))));
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.55474F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.44526F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tableLayoutPanel3.Controls.Add(this.gidilen_yol_gps, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.anlik_hiz_gps, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label21, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label31, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label33, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.kalan_yol_gps, 2, 1);
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(45)))));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(-2, 237);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.42105F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.57895F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(464, 72);
            this.tableLayoutPanel3.TabIndex = 35;
            // 
            // gidilen_yol_gps
            // 
            this.gidilen_yol_gps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(211)))));
            this.gidilen_yol_gps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gidilen_yol_gps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gidilen_yol_gps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gidilen_yol_gps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(45)))));
            this.gidilen_yol_gps.Location = new System.Drawing.Point(168, 6);
            this.gidilen_yol_gps.Multiline = true;
            this.gidilen_yol_gps.Name = "gidilen_yol_gps";
            this.gidilen_yol_gps.ReadOnly = true;
            this.gidilen_yol_gps.Size = new System.Drawing.Size(290, 21);
            this.gidilen_yol_gps.TabIndex = 38;
            this.gidilen_yol_gps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // anlik_hiz_gps
            // 
            this.anlik_hiz_gps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(211)))));
            this.anlik_hiz_gps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anlik_hiz_gps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anlik_hiz_gps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlik_hiz_gps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(45)))));
            this.anlik_hiz_gps.Location = new System.Drawing.Point(6, 36);
            this.anlik_hiz_gps.Multiline = true;
            this.anlik_hiz_gps.Name = "anlik_hiz_gps";
            this.anlik_hiz_gps.ReadOnly = true;
            this.anlik_hiz_gps.Size = new System.Drawing.Size(76, 30);
            this.anlik_hiz_gps.TabIndex = 11;
            this.anlik_hiz_gps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(91, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 27);
            this.label21.TabIndex = 2;
            this.label21.Text = "GİDİLEN YOL";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(91, 33);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(68, 36);
            this.label31.TabIndex = 6;
            this.label31.Text = "KALAN YOL";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(6, 3);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(76, 27);
            this.label33.TabIndex = 0;
            this.label33.Text = "ANLIK HIZ(GPS)";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kalan_yol_gps
            // 
            this.kalan_yol_gps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(211)))));
            this.kalan_yol_gps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kalan_yol_gps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kalan_yol_gps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalan_yol_gps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(45)))));
            this.kalan_yol_gps.Location = new System.Drawing.Point(168, 36);
            this.kalan_yol_gps.Multiline = true;
            this.kalan_yol_gps.Name = "kalan_yol_gps";
            this.kalan_yol_gps.ReadOnly = true;
            this.kalan_yol_gps.Size = new System.Drawing.Size(290, 30);
            this.kalan_yol_gps.TabIndex = 10;
            this.kalan_yol_gps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // history_displayer
            // 
            this.history_displayer.LargeChange = 1;
            this.history_displayer.Location = new System.Drawing.Point(5, 309);
            this.history_displayer.Name = "history_displayer";
            this.history_displayer.Size = new System.Drawing.Size(1030, 17);
            this.history_displayer.TabIndex = 34;
            this.history_displayer.ValueChanged += new System.EventHandler(this.history_displayer_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel13);
            this.groupBox3.Controls.Add(this.tableLayoutPanel12);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tableLayoutPanel7);
            this.groupBox3.Controls.Add(this.tableLayoutPanel10);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(0, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(698, 309);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BMS";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.tableLayoutPanel13.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.label42, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.turr, 1, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(508, 166);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(190, 68);
            this.tableLayoutPanel13.TabIndex = 37;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.Location = new System.Drawing.Point(6, 3);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(84, 62);
            this.label42.TabIndex = 0;
            this.label42.Text = "TUR";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turr
            // 
            this.turr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.turr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.turr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.turr.Location = new System.Drawing.Point(99, 6);
            this.turr.Multiline = true;
            this.turr.Name = "turr";
            this.turr.Size = new System.Drawing.Size(85, 56);
            this.turr.TabIndex = 1;
            this.turr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.tableLayoutPanel12.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.87156F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.12844F));
            this.tableLayoutPanel12.Controls.Add(this.kalan_sure, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.gecen_sure, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.label38, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label40, 1, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(290, 234);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(408, 72);
            this.tableLayoutPanel12.TabIndex = 36;
            // 
            // kalan_sure
            // 
            this.kalan_sure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.kalan_sure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kalan_sure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kalan_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalan_sure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.kalan_sure.Location = new System.Drawing.Point(6, 32);
            this.kalan_sure.Multiline = true;
            this.kalan_sure.Name = "kalan_sure";
            this.kalan_sure.Size = new System.Drawing.Size(177, 34);
            this.kalan_sure.TabIndex = 9;
            this.kalan_sure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gecen_sure
            // 
            this.gecen_sure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.gecen_sure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gecen_sure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gecen_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gecen_sure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(35)))), ((int)(((byte)(3)))));
            this.gecen_sure.Location = new System.Drawing.Point(192, 32);
            this.gecen_sure.Multiline = true;
            this.gecen_sure.Name = "gecen_sure";
            this.gecen_sure.Size = new System.Drawing.Size(210, 34);
            this.gecen_sure.TabIndex = 8;
            this.gecen_sure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(6, 3);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(177, 23);
            this.label38.TabIndex = 0;
            this.label38.Text = "KALAN SÜRE";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(192, 3);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(210, 23);
            this.label40.TabIndex = 7;
            this.label40.Text = "GEÇEN SÜRE";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.tableLayoutPanel9);
            this.groupBox5.Controls.Add(this.tableLayoutPanel8);
            this.groupBox5.Location = new System.Drawing.Point(296, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(212, 223);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ERRORS";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.bms_over_cur_error, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.bms_high_volt_error, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.bms_low_volt_error, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.bms_temp_error, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.bms_comm_error, 0, 3);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(149, 20);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 5;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(56, 203);
            this.tableLayoutPanel9.TabIndex = 37;
            // 
            // bms_over_cur_error
            // 
            this.bms_over_cur_error.AutoSize = true;
            this.bms_over_cur_error.BackColor = System.Drawing.Color.White;
            this.bms_over_cur_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_over_cur_error.Location = new System.Drawing.Point(6, 163);
            this.bms_over_cur_error.Name = "bms_over_cur_error";
            this.bms_over_cur_error.Size = new System.Drawing.Size(44, 37);
            this.bms_over_cur_error.TabIndex = 10;
            this.bms_over_cur_error.Text = " ";
            this.bms_over_cur_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_high_volt_error
            // 
            this.bms_high_volt_error.AutoSize = true;
            this.bms_high_volt_error.BackColor = System.Drawing.Color.White;
            this.bms_high_volt_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_high_volt_error.Location = new System.Drawing.Point(6, 3);
            this.bms_high_volt_error.Name = "bms_high_volt_error";
            this.bms_high_volt_error.Size = new System.Drawing.Size(44, 37);
            this.bms_high_volt_error.TabIndex = 2;
            this.bms_high_volt_error.Text = " ";
            // 
            // bms_low_volt_error
            // 
            this.bms_low_volt_error.AutoSize = true;
            this.bms_low_volt_error.BackColor = System.Drawing.Color.White;
            this.bms_low_volt_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_low_volt_error.Location = new System.Drawing.Point(6, 43);
            this.bms_low_volt_error.Name = "bms_low_volt_error";
            this.bms_low_volt_error.Size = new System.Drawing.Size(44, 37);
            this.bms_low_volt_error.TabIndex = 5;
            this.bms_low_volt_error.Text = " ";
            this.bms_low_volt_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_temp_error
            // 
            this.bms_temp_error.AutoSize = true;
            this.bms_temp_error.BackColor = System.Drawing.Color.White;
            this.bms_temp_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_temp_error.Location = new System.Drawing.Point(6, 83);
            this.bms_temp_error.Name = "bms_temp_error";
            this.bms_temp_error.Size = new System.Drawing.Size(44, 37);
            this.bms_temp_error.TabIndex = 8;
            this.bms_temp_error.Text = " ";
            this.bms_temp_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_comm_error
            // 
            this.bms_comm_error.AutoSize = true;
            this.bms_comm_error.BackColor = System.Drawing.Color.White;
            this.bms_comm_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_comm_error.Location = new System.Drawing.Point(6, 123);
            this.bms_comm_error.Name = "bms_comm_error";
            this.bms_comm_error.Size = new System.Drawing.Size(44, 37);
            this.bms_comm_error.TabIndex = 9;
            this.bms_comm_error.Text = " ";
            this.bms_comm_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label54, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.label52, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label50, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label48, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label46, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(149, 203);
            this.tableLayoutPanel8.TabIndex = 36;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.label54.Location = new System.Drawing.Point(6, 163);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(137, 37);
            this.label54.TabIndex = 4;
            this.label54.Text = "OVER CUR";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.label52.Location = new System.Drawing.Point(6, 123);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(137, 37);
            this.label52.TabIndex = 3;
            this.label52.Text = "COMM";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.label50.Location = new System.Drawing.Point(6, 83);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(137, 37);
            this.label50.TabIndex = 2;
            this.label50.Text = "TEMP";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.label48.Location = new System.Drawing.Point(6, 43);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(137, 37);
            this.label48.TabIndex = 1;
            this.label48.Text = "LOW VOLT";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.label46.Location = new System.Drawing.Point(6, 3);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(137, 37);
            this.label46.TabIndex = 0;
            this.label46.Text = "HIGH VOLT";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tableLayoutPanel11);
            this.groupBox4.Controls.Add(this.tableLayoutPanel5);
            this.groupBox4.Location = new System.Drawing.Point(501, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 162);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DC BUS STATE";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel11.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.bms_precharge_flag, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.bms_discharge_flag, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.bms_dc_bus_ready_flag, 0, 2);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(149, 23);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(48, 132);
            this.tableLayoutPanel11.TabIndex = 34;
            // 
            // bms_precharge_flag
            // 
            this.bms_precharge_flag.AutoSize = true;
            this.bms_precharge_flag.BackColor = System.Drawing.Color.White;
            this.bms_precharge_flag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_precharge_flag.Location = new System.Drawing.Point(6, 3);
            this.bms_precharge_flag.Name = "bms_precharge_flag";
            this.bms_precharge_flag.Size = new System.Drawing.Size(36, 40);
            this.bms_precharge_flag.TabIndex = 2;
            this.bms_precharge_flag.Text = " ";
            // 
            // bms_discharge_flag
            // 
            this.bms_discharge_flag.AutoSize = true;
            this.bms_discharge_flag.BackColor = System.Drawing.Color.White;
            this.bms_discharge_flag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_discharge_flag.Location = new System.Drawing.Point(6, 46);
            this.bms_discharge_flag.Name = "bms_discharge_flag";
            this.bms_discharge_flag.Size = new System.Drawing.Size(36, 40);
            this.bms_discharge_flag.TabIndex = 5;
            this.bms_discharge_flag.Text = " ";
            this.bms_discharge_flag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_dc_bus_ready_flag
            // 
            this.bms_dc_bus_ready_flag.AutoSize = true;
            this.bms_dc_bus_ready_flag.BackColor = System.Drawing.Color.White;
            this.bms_dc_bus_ready_flag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_dc_bus_ready_flag.Location = new System.Drawing.Point(6, 89);
            this.bms_dc_bus_ready_flag.Name = "bms_dc_bus_ready_flag";
            this.bms_dc_bus_ready_flag.Size = new System.Drawing.Size(36, 40);
            this.bms_dc_bus_ready_flag.TabIndex = 8;
            this.bms_dc_bus_ready_flag.Text = " ";
            this.bms_dc_bus_ready_flag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label41, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label43, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label45, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(143, 131);
            this.tableLayoutPanel5.TabIndex = 33;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.label41.Location = new System.Drawing.Point(6, 87);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(131, 41);
            this.label41.TabIndex = 4;
            this.label41.Text = "DC BUS READY";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.label43.Location = new System.Drawing.Point(6, 45);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(131, 39);
            this.label43.TabIndex = 2;
            this.label43.Text = "DISCHARGE";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.label45.Location = new System.Drawing.Point(6, 3);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(131, 39);
            this.label45.TabIndex = 0;
            this.label45.Text = "PRECHARGE";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.tableLayoutPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.Controls.Add(this.bms_bat_cons, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.bms_bat_current, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label57, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label59, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label55, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.bms_bat_volt, 1, 0);
            this.tableLayoutPanel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 19);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(290, 129);
            this.tableLayoutPanel7.TabIndex = 24;
            // 
            // bms_bat_cons
            // 
            this.bms_bat_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.bms_bat_cons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_bat_cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bms_bat_cons.Location = new System.Drawing.Point(149, 88);
            this.bms_bat_cons.Multiline = true;
            this.bms_bat_cons.Name = "bms_bat_cons";
            this.bms_bat_cons.ReadOnly = true;
            this.bms_bat_cons.Size = new System.Drawing.Size(135, 35);
            this.bms_bat_cons.TabIndex = 38;
            this.bms_bat_cons.Text = " ";
            this.bms_bat_cons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bms_bat_current
            // 
            this.bms_bat_current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.bms_bat_current.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_bat_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bms_bat_current.Location = new System.Drawing.Point(149, 47);
            this.bms_bat_current.Multiline = true;
            this.bms_bat_current.Name = "bms_bat_current";
            this.bms_bat_current.ReadOnly = true;
            this.bms_bat_current.Size = new System.Drawing.Size(135, 32);
            this.bms_bat_current.TabIndex = 38;
            this.bms_bat_current.Text = " ";
            this.bms_bat_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label57.Location = new System.Drawing.Point(6, 44);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(134, 38);
            this.label57.TabIndex = 3;
            this.label57.Text = "BAT CUR";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.label59.Location = new System.Drawing.Point(6, 3);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(134, 38);
            this.label59.TabIndex = 0;
            this.label59.Text = "BAT VOLT";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label55.Location = new System.Drawing.Point(6, 85);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(134, 41);
            this.label55.TabIndex = 6;
            this.label55.Text = "BAT CONS";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_bat_volt
            // 
            this.bms_bat_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.bms_bat_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_bat_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bms_bat_volt.Location = new System.Drawing.Point(149, 6);
            this.bms_bat_volt.Multiline = true;
            this.bms_bat_volt.Name = "bms_bat_volt";
            this.bms_bat_volt.ReadOnly = true;
            this.bms_bat_volt.Size = new System.Drawing.Size(135, 32);
            this.bms_bat_volt.TabIndex = 11;
            this.bms_bat_volt.Text = " ";
            this.bms_bat_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.tableLayoutPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.bms_worst_cell_address, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.bms_worst_cell_volt, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.bms_soc, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label56, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.label70, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.label72, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.label74, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.bms_temp, 1, 3);
            this.tableLayoutPanel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 148);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 4;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(290, 158);
            this.tableLayoutPanel10.TabIndex = 25;
            // 
            // bms_worst_cell_address
            // 
            this.bms_worst_cell_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.bms_worst_cell_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_worst_cell_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_worst_cell_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bms_worst_cell_address.Location = new System.Drawing.Point(149, 82);
            this.bms_worst_cell_address.Multiline = true;
            this.bms_worst_cell_address.Name = "bms_worst_cell_address";
            this.bms_worst_cell_address.ReadOnly = true;
            this.bms_worst_cell_address.Size = new System.Drawing.Size(135, 29);
            this.bms_worst_cell_address.TabIndex = 13;
            this.bms_worst_cell_address.Text = " ";
            this.bms_worst_cell_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bms_worst_cell_volt
            // 
            this.bms_worst_cell_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.bms_worst_cell_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_worst_cell_volt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_worst_cell_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bms_worst_cell_volt.Location = new System.Drawing.Point(149, 44);
            this.bms_worst_cell_volt.Multiline = true;
            this.bms_worst_cell_volt.Name = "bms_worst_cell_volt";
            this.bms_worst_cell_volt.ReadOnly = true;
            this.bms_worst_cell_volt.Size = new System.Drawing.Size(135, 29);
            this.bms_worst_cell_volt.TabIndex = 12;
            this.bms_worst_cell_volt.Text = " ";
            this.bms_worst_cell_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bms_soc
            // 
            this.bms_soc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.bms_soc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_soc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_soc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bms_soc.Location = new System.Drawing.Point(149, 6);
            this.bms_soc.Multiline = true;
            this.bms_soc.Name = "bms_soc";
            this.bms_soc.ReadOnly = true;
            this.bms_soc.Size = new System.Drawing.Size(135, 29);
            this.bms_soc.TabIndex = 11;
            this.bms_soc.Text = "            ";
            this.bms_soc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label56.Location = new System.Drawing.Point(6, 117);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(134, 38);
            this.label56.TabIndex = 9;
            this.label56.Text = "TEMP";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label70.Location = new System.Drawing.Point(6, 79);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(134, 35);
            this.label70.TabIndex = 6;
            this.label70.Text = "WORST CELL ADDRESS";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label72.Location = new System.Drawing.Point(6, 41);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(134, 35);
            this.label72.TabIndex = 3;
            this.label72.Text = "WORST CELL VOLT";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label74.Location = new System.Drawing.Point(6, 3);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(134, 35);
            this.label74.TabIndex = 0;
            this.label74.Text = "SOC";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bms_temp
            // 
            this.bms_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.bms_temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bms_temp.Location = new System.Drawing.Point(149, 120);
            this.bms_temp.Multiline = true;
            this.bms_temp.Name = "bms_temp";
            this.bms_temp.ReadOnly = true;
            this.bms_temp.Size = new System.Drawing.Size(135, 32);
            this.bms_temp.TabIndex = 10;
            this.bms_temp.Text = " ";
            this.bms_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.tableLayoutPanel6);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(704, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(184, 309);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DURUMLAR";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.gsm_durum, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.xbee_durum, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.ems_durum, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.bms_durum, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label47, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.label49, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label51, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label53, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label58, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.driver_durum, 1, 0);
            this.tableLayoutPanel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(166)))), ((int)(((byte)(181)))));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(179, 287);
            this.tableLayoutPanel6.TabIndex = 34;
            // 
            // gsm_durum
            // 
            this.gsm_durum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.gsm_durum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gsm_durum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gsm_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gsm_durum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.gsm_durum.Location = new System.Drawing.Point(94, 230);
            this.gsm_durum.Multiline = true;
            this.gsm_durum.Name = "gsm_durum";
            this.gsm_durum.ReadOnly = true;
            this.gsm_durum.Size = new System.Drawing.Size(79, 51);
            this.gsm_durum.TabIndex = 13;
            this.gsm_durum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xbee_durum
            // 
            this.xbee_durum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.xbee_durum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xbee_durum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xbee_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xbee_durum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.xbee_durum.Location = new System.Drawing.Point(94, 174);
            this.xbee_durum.Multiline = true;
            this.xbee_durum.Name = "xbee_durum";
            this.xbee_durum.ReadOnly = true;
            this.xbee_durum.Size = new System.Drawing.Size(79, 47);
            this.xbee_durum.TabIndex = 12;
            this.xbee_durum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ems_durum
            // 
            this.ems_durum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.ems_durum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ems_durum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ems_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ems_durum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.ems_durum.Location = new System.Drawing.Point(94, 118);
            this.ems_durum.Multiline = true;
            this.ems_durum.Name = "ems_durum";
            this.ems_durum.ReadOnly = true;
            this.ems_durum.Size = new System.Drawing.Size(79, 47);
            this.ems_durum.TabIndex = 11;
            this.ems_durum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bms_durum
            // 
            this.bms_durum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.bms_durum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bms_durum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bms_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bms_durum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.bms_durum.Location = new System.Drawing.Point(94, 62);
            this.bms_durum.Multiline = true;
            this.bms_durum.Name = "bms_durum";
            this.bms_durum.ReadOnly = true;
            this.bms_durum.Size = new System.Drawing.Size(79, 47);
            this.bms_durum.TabIndex = 10;
            this.bms_durum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.label47.Location = new System.Drawing.Point(6, 227);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(79, 57);
            this.label47.TabIndex = 8;
            this.label47.Text = "GSM";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.label49.Location = new System.Drawing.Point(6, 171);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(79, 53);
            this.label49.TabIndex = 6;
            this.label49.Text = "XBEE";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.label51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.label51.Location = new System.Drawing.Point(6, 115);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(79, 53);
            this.label51.TabIndex = 4;
            this.label51.Text = "EMS";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.label53.Location = new System.Drawing.Point(6, 59);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(79, 53);
            this.label53.TabIndex = 2;
            this.label53.Text = "BMS";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.label58.Location = new System.Drawing.Point(6, 3);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(79, 53);
            this.label58.TabIndex = 0;
            this.label58.Text = "DRIVER";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driver_durum
            // 
            this.driver_durum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(235)))), ((int)(((byte)(179)))));
            this.driver_durum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_durum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_durum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.driver_durum.Location = new System.Drawing.Point(94, 6);
            this.driver_durum.Multiline = true;
            this.driver_durum.Name = "driver_durum";
            this.driver_durum.ReadOnly = true;
            this.driver_durum.Size = new System.Drawing.Size(79, 47);
            this.driver_durum.TabIndex = 9;
            this.driver_durum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel19);
            this.groupBox7.Controls.Add(this.tableLayoutPanel17);
            this.groupBox7.Controls.Add(this.tableLayoutPanel16);
            this.groupBox7.Controls.Add(this.tableLayoutPanel15);
            this.groupBox7.Controls.Add(this.tableLayoutPanel14);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(0, 653);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(557, 408);
            this.groupBox7.TabIndex = 36;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DRIVER";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.tableLayoutPanel19.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel19.ColumnCount = 2;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel19.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.motor_temp, 1, 0);
            this.tableLayoutPanel19.Location = new System.Drawing.Point(277, 300);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(277, 50);
            this.tableLayoutPanel19.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(6, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 44);
            this.label17.TabIndex = 1;
            this.label17.Text = "  MOTOR TEMP";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motor_temp
            // 
            this.motor_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.motor_temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.motor_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motor_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motor_temp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.motor_temp.Location = new System.Drawing.Point(110, 6);
            this.motor_temp.Multiline = true;
            this.motor_temp.Name = "motor_temp";
            this.motor_temp.Size = new System.Drawing.Size(161, 38);
            this.motor_temp.TabIndex = 2;
            this.motor_temp.Text = " ";
            this.motor_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.tableLayoutPanel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel17.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Controls.Add(this.label85, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.label87, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.vd, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.vq, 1, 1);
            this.tableLayoutPanel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel17.Location = new System.Drawing.Point(277, 208);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(277, 94);
            this.tableLayoutPanel17.TabIndex = 28;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label85.Location = new System.Drawing.Point(6, 48);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(128, 43);
            this.label85.TabIndex = 3;
            this.label85.Text = "Vq";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label87.Location = new System.Drawing.Point(6, 3);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(128, 42);
            this.label87.TabIndex = 0;
            this.label87.Text = "Vd";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vd
            // 
            this.vd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.vd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.vd.Location = new System.Drawing.Point(143, 6);
            this.vd.Multiline = true;
            this.vd.Name = "vd";
            this.vd.ReadOnly = true;
            this.vd.Size = new System.Drawing.Size(128, 36);
            this.vd.TabIndex = 10;
            this.vd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vq
            // 
            this.vq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.vq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.vq.Location = new System.Drawing.Point(143, 51);
            this.vq.Multiline = true;
            this.vq.Name = "vq";
            this.vq.ReadOnly = true;
            this.vq.Size = new System.Drawing.Size(128, 37);
            this.vq.TabIndex = 11;
            this.vq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.tableLayoutPanel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel16.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Controls.Add(this.label19, 0, 2);
            this.tableLayoutPanel16.Controls.Add(this.label88, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.label90, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.id, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.iq, 1, 1);
            this.tableLayoutPanel16.Controls.Add(this.act_torque, 1, 2);
            this.tableLayoutPanel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 208);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 3;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(277, 142);
            this.tableLayoutPanel16.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(6, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 44);
            this.label19.TabIndex = 29;
            this.label19.Text = "ACT TORQUE";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label88.Location = new System.Drawing.Point(6, 49);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(128, 43);
            this.label88.TabIndex = 3;
            this.label88.Text = "Iq";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label90.Location = new System.Drawing.Point(6, 3);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(128, 43);
            this.label90.TabIndex = 0;
            this.label90.Text = "Id";
            this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.id.Location = new System.Drawing.Point(143, 6);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(128, 37);
            this.id.TabIndex = 10;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iq
            // 
            this.iq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.iq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.iq.Location = new System.Drawing.Point(143, 52);
            this.iq.Multiline = true;
            this.iq.Name = "iq";
            this.iq.ReadOnly = true;
            this.iq.Size = new System.Drawing.Size(128, 37);
            this.iq.TabIndex = 11;
            this.iq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // act_torque
            // 
            this.act_torque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.act_torque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.act_torque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.act_torque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.act_torque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.act_torque.Location = new System.Drawing.Point(143, 98);
            this.act_torque.Multiline = true;
            this.act_torque.Name = "act_torque";
            this.act_torque.Size = new System.Drawing.Size(128, 38);
            this.act_torque.TabIndex = 30;
            this.act_torque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.tableLayoutPanel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel15.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.label73, 0, 3);
            this.tableLayoutPanel15.Controls.Add(this.label76, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.label78, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.label81, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.phase_a_volt, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.phase_b_volt, 1, 1);
            this.tableLayoutPanel15.Controls.Add(this.phase_c_volt, 1, 2);
            this.tableLayoutPanel15.Controls.Add(this.dc_bus_volt, 1, 3);
            this.tableLayoutPanel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel15.Location = new System.Drawing.Point(277, 17);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 4;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(277, 193);
            this.tableLayoutPanel15.TabIndex = 26;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label73.Location = new System.Drawing.Point(6, 144);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(128, 46);
            this.label73.TabIndex = 8;
            this.label73.Text = "DC  BUS VOLT";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label76.Location = new System.Drawing.Point(6, 97);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(128, 44);
            this.label76.TabIndex = 6;
            this.label76.Text = "PHASE C VOLT";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label78.Location = new System.Drawing.Point(6, 50);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(128, 44);
            this.label78.TabIndex = 3;
            this.label78.Text = "PHASE B VOLT";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label81.Location = new System.Drawing.Point(6, 3);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(128, 44);
            this.label81.TabIndex = 0;
            this.label81.Text = "POWER";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phase_a_volt
            // 
            this.phase_a_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.phase_a_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phase_a_volt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phase_a_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phase_a_volt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.phase_a_volt.Location = new System.Drawing.Point(143, 6);
            this.phase_a_volt.Multiline = true;
            this.phase_a_volt.Name = "phase_a_volt";
            this.phase_a_volt.ReadOnly = true;
            this.phase_a_volt.Size = new System.Drawing.Size(128, 38);
            this.phase_a_volt.TabIndex = 10;
            this.phase_a_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phase_b_volt
            // 
            this.phase_b_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.phase_b_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phase_b_volt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phase_b_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phase_b_volt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.phase_b_volt.Location = new System.Drawing.Point(143, 53);
            this.phase_b_volt.Multiline = true;
            this.phase_b_volt.Name = "phase_b_volt";
            this.phase_b_volt.ReadOnly = true;
            this.phase_b_volt.Size = new System.Drawing.Size(128, 38);
            this.phase_b_volt.TabIndex = 11;
            this.phase_b_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phase_c_volt
            // 
            this.phase_c_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.phase_c_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phase_c_volt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phase_c_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phase_c_volt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.phase_c_volt.Location = new System.Drawing.Point(143, 100);
            this.phase_c_volt.Multiline = true;
            this.phase_c_volt.Name = "phase_c_volt";
            this.phase_c_volt.ReadOnly = true;
            this.phase_c_volt.Size = new System.Drawing.Size(128, 38);
            this.phase_c_volt.TabIndex = 12;
            this.phase_c_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dc_bus_volt
            // 
            this.dc_bus_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.dc_bus_volt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dc_bus_volt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dc_bus_volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dc_bus_volt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.dc_bus_volt.Location = new System.Drawing.Point(143, 147);
            this.dc_bus_volt.Multiline = true;
            this.dc_bus_volt.Name = "dc_bus_volt";
            this.dc_bus_volt.ReadOnly = true;
            this.dc_bus_volt.Size = new System.Drawing.Size(128, 40);
            this.dc_bus_volt.TabIndex = 13;
            this.dc_bus_volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.tableLayoutPanel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel14.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.dc_bus_cur, 1, 3);
            this.tableLayoutPanel14.Controls.Add(this.phase_c_cur, 1, 2);
            this.tableLayoutPanel14.Controls.Add(this.phase_b_cur, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.label80, 0, 3);
            this.tableLayoutPanel14.Controls.Add(this.label66, 0, 2);
            this.tableLayoutPanel14.Controls.Add(this.label68, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.label71, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.phase_a_cur, 1, 0);
            this.tableLayoutPanel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 17);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 4;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(277, 193);
            this.tableLayoutPanel14.TabIndex = 25;
            // 
            // dc_bus_cur
            // 
            this.dc_bus_cur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.dc_bus_cur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dc_bus_cur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dc_bus_cur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dc_bus_cur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.dc_bus_cur.Location = new System.Drawing.Point(143, 147);
            this.dc_bus_cur.Multiline = true;
            this.dc_bus_cur.Name = "dc_bus_cur";
            this.dc_bus_cur.ReadOnly = true;
            this.dc_bus_cur.Size = new System.Drawing.Size(128, 40);
            this.dc_bus_cur.TabIndex = 12;
            this.dc_bus_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phase_c_cur
            // 
            this.phase_c_cur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.phase_c_cur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phase_c_cur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phase_c_cur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phase_c_cur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.phase_c_cur.Location = new System.Drawing.Point(143, 100);
            this.phase_c_cur.Multiline = true;
            this.phase_c_cur.Name = "phase_c_cur";
            this.phase_c_cur.ReadOnly = true;
            this.phase_c_cur.Size = new System.Drawing.Size(128, 38);
            this.phase_c_cur.TabIndex = 11;
            this.phase_c_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phase_b_cur
            // 
            this.phase_b_cur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.phase_b_cur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phase_b_cur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phase_b_cur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phase_b_cur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.phase_b_cur.Location = new System.Drawing.Point(143, 53);
            this.phase_b_cur.Multiline = true;
            this.phase_b_cur.Name = "phase_b_cur";
            this.phase_b_cur.ReadOnly = true;
            this.phase_b_cur.Size = new System.Drawing.Size(128, 38);
            this.phase_b_cur.TabIndex = 10;
            this.phase_b_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label80.Location = new System.Drawing.Point(6, 144);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(128, 46);
            this.label80.TabIndex = 8;
            this.label80.Text = "DC  BUS CUR";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label66.Location = new System.Drawing.Point(6, 97);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(128, 44);
            this.label66.TabIndex = 6;
            this.label66.Text = "PHASE C CUR";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label68.Location = new System.Drawing.Point(6, 50);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(128, 44);
            this.label68.TabIndex = 3;
            this.label68.Text = "PHASE B CUR";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label71.Location = new System.Drawing.Point(6, 3);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(128, 44);
            this.label71.TabIndex = 0;
            this.label71.Text = "PHASE A CUR";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phase_a_cur
            // 
            this.phase_a_cur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.phase_a_cur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phase_a_cur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phase_a_cur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phase_a_cur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.phase_a_cur.Location = new System.Drawing.Point(143, 6);
            this.phase_a_cur.Multiline = true;
            this.phase_a_cur.Name = "phase_a_cur";
            this.phase_a_cur.ReadOnly = true;
            this.phase_a_cur.Size = new System.Drawing.Size(128, 38);
            this.phase_a_cur.TabIndex = 9;
            this.phase_a_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.driver_fwrv_command, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.driver_ign_command, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.driver_brake_command, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(165, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(164, 168);
            this.tableLayoutPanel4.TabIndex = 30;
            // 
            // driver_fwrv_command
            // 
            this.driver_fwrv_command.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.driver_fwrv_command.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_fwrv_command.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_fwrv_command.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_fwrv_command.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.driver_fwrv_command.Location = new System.Drawing.Point(6, 136);
            this.driver_fwrv_command.Multiline = true;
            this.driver_fwrv_command.Name = "driver_fwrv_command";
            this.driver_fwrv_command.Size = new System.Drawing.Size(152, 26);
            this.driver_fwrv_command.TabIndex = 4;
            this.driver_fwrv_command.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 61);
            this.label11.TabIndex = 0;
            this.label11.Text = "DRIVE COMMAND";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driver_ign_command
            // 
            this.driver_ign_command.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.driver_ign_command.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_ign_command.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_ign_command.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_ign_command.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.driver_ign_command.Location = new System.Drawing.Point(6, 70);
            this.driver_ign_command.Multiline = true;
            this.driver_ign_command.Name = "driver_ign_command";
            this.driver_ign_command.Size = new System.Drawing.Size(152, 24);
            this.driver_ign_command.TabIndex = 2;
            this.driver_ign_command.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // driver_brake_command
            // 
            this.driver_brake_command.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.driver_brake_command.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_brake_command.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_brake_command.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_brake_command.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.driver_brake_command.Location = new System.Drawing.Point(6, 103);
            this.driver_brake_command.Multiline = true;
            this.driver_brake_command.Name = "driver_brake_command";
            this.driver_brake_command.Size = new System.Drawing.Size(152, 24);
            this.driver_brake_command.TabIndex = 3;
            this.driver_brake_command.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.tableLayoutPanel18.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Controls.Add(this.driver_fwrv_status, 0, 3);
            this.tableLayoutPanel18.Controls.Add(this.driver_brake_status, 0, 2);
            this.tableLayoutPanel18.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.driver_ign_status, 0, 1);
            this.tableLayoutPanel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 4;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(162, 168);
            this.tableLayoutPanel18.TabIndex = 29;
            // 
            // driver_fwrv_status
            // 
            this.driver_fwrv_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.driver_fwrv_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_fwrv_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_fwrv_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_fwrv_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.driver_fwrv_status.Location = new System.Drawing.Point(6, 136);
            this.driver_fwrv_status.Multiline = true;
            this.driver_fwrv_status.Name = "driver_fwrv_status";
            this.driver_fwrv_status.Size = new System.Drawing.Size(150, 26);
            this.driver_fwrv_status.TabIndex = 3;
            this.driver_fwrv_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // driver_brake_status
            // 
            this.driver_brake_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.driver_brake_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_brake_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_brake_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_brake_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.driver_brake_status.Location = new System.Drawing.Point(6, 103);
            this.driver_brake_status.Multiline = true;
            this.driver_brake_status.Name = "driver_brake_status";
            this.driver_brake_status.Size = new System.Drawing.Size(150, 24);
            this.driver_brake_status.TabIndex = 2;
            this.driver_brake_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 61);
            this.label3.TabIndex = 0;
            this.label3.Text = "DRIVE STATUS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driver_ign_status
            // 
            this.driver_ign_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.driver_ign_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_ign_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver_ign_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driver_ign_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.driver_ign_status.Location = new System.Drawing.Point(6, 70);
            this.driver_ign_status.Multiline = true;
            this.driver_ign_status.Name = "driver_ign_status";
            this.driver_ign_status.Size = new System.Drawing.Size(150, 24);
            this.driver_ign_status.TabIndex = 1;
            this.driver_ign_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // time_counter
            // 
            this.time_counter.Tick += new System.EventHandler(this.time_counter_Tick);
            // 
            // gsm_trigger
            // 
            this.gsm_trigger.Interval = 250;
            this.gsm_trigger.Tick += new System.EventHandler(this.gsm_trigger_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel18);
            this.groupBox8.Controls.Add(this.tableLayoutPanel22);
            this.groupBox8.Controls.Add(this.tableLayoutPanel4);
            this.groupBox8.Controls.Add(this.tableLayoutPanel20);
            this.groupBox8.Location = new System.Drawing.Point(560, 653);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(331, 408);
            this.groupBox8.TabIndex = 38;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = " ";
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel22.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel22.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel22.ColumnCount = 1;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Controls.Add(this.id_error, 0, 5);
            this.tableLayoutPanel22.Controls.Add(this.motor_temp_error, 0, 4);
            this.tableLayoutPanel22.Controls.Add(this.dc_bus_amper_error, 0, 3);
            this.tableLayoutPanel22.Controls.Add(this.zpc, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.pwm_enabled, 0, 1);
            this.tableLayoutPanel22.Controls.Add(this.dc_bus_voltage_error, 0, 2);
            this.tableLayoutPanel22.Location = new System.Drawing.Point(268, 174);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 6;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.75978F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.64246F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(63, 185);
            this.tableLayoutPanel22.TabIndex = 41;
            // 
            // id_error
            // 
            this.id_error.AutoSize = true;
            this.id_error.BackColor = System.Drawing.Color.White;
            this.id_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id_error.Location = new System.Drawing.Point(6, 151);
            this.id_error.Name = "id_error";
            this.id_error.Size = new System.Drawing.Size(51, 31);
            this.id_error.TabIndex = 8;
            this.id_error.Text = " ";
            this.id_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motor_temp_error
            // 
            this.motor_temp_error.AutoSize = true;
            this.motor_temp_error.BackColor = System.Drawing.Color.White;
            this.motor_temp_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motor_temp_error.Location = new System.Drawing.Point(6, 123);
            this.motor_temp_error.Name = "motor_temp_error";
            this.motor_temp_error.Size = new System.Drawing.Size(51, 25);
            this.motor_temp_error.TabIndex = 5;
            this.motor_temp_error.Text = " ";
            this.motor_temp_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dc_bus_amper_error
            // 
            this.dc_bus_amper_error.AutoSize = true;
            this.dc_bus_amper_error.BackColor = System.Drawing.Color.White;
            this.dc_bus_amper_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dc_bus_amper_error.Location = new System.Drawing.Point(6, 93);
            this.dc_bus_amper_error.Name = "dc_bus_amper_error";
            this.dc_bus_amper_error.Size = new System.Drawing.Size(51, 27);
            this.dc_bus_amper_error.TabIndex = 2;
            this.dc_bus_amper_error.Text = " ";
            // 
            // zpc
            // 
            this.zpc.AutoSize = true;
            this.zpc.BackColor = System.Drawing.Color.White;
            this.zpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zpc.Location = new System.Drawing.Point(6, 3);
            this.zpc.Name = "zpc";
            this.zpc.Size = new System.Drawing.Size(51, 27);
            this.zpc.TabIndex = 2;
            // 
            // pwm_enabled
            // 
            this.pwm_enabled.AutoSize = true;
            this.pwm_enabled.BackColor = System.Drawing.Color.White;
            this.pwm_enabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwm_enabled.Location = new System.Drawing.Point(6, 33);
            this.pwm_enabled.Name = "pwm_enabled";
            this.pwm_enabled.Size = new System.Drawing.Size(51, 27);
            this.pwm_enabled.TabIndex = 5;
            this.pwm_enabled.Text = " ";
            this.pwm_enabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dc_bus_voltage_error
            // 
            this.dc_bus_voltage_error.AutoSize = true;
            this.dc_bus_voltage_error.BackColor = System.Drawing.Color.White;
            this.dc_bus_voltage_error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dc_bus_voltage_error.Location = new System.Drawing.Point(6, 63);
            this.dc_bus_voltage_error.Name = "dc_bus_voltage_error";
            this.dc_bus_voltage_error.Size = new System.Drawing.Size(51, 27);
            this.dc_bus_voltage_error.TabIndex = 8;
            this.dc_bus_voltage_error.Text = " ";
            this.dc_bus_voltage_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.tableLayoutPanel20.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.36585F));
            this.tableLayoutPanel20.Controls.Add(this.label61, 0, 5);
            this.tableLayoutPanel20.Controls.Add(this.label60, 0, 4);
            this.tableLayoutPanel20.Controls.Add(this.label36, 0, 3);
            this.tableLayoutPanel20.Controls.Add(this.label34, 0, 2);
            this.tableLayoutPanel20.Controls.Add(this.label28, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.label24, 0, 0);
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 174);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 6;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(265, 185);
            this.tableLayoutPanel20.TabIndex = 39;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label61.Location = new System.Drawing.Point(6, 153);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(253, 29);
            this.label61.TabIndex = 17;
            this.label61.Text = "ID";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label60.Location = new System.Drawing.Point(6, 123);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(253, 27);
            this.label60.TabIndex = 16;
            this.label60.Text = "  MOTOR TEMP";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(6, 93);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(253, 27);
            this.label36.TabIndex = 15;
            this.label36.Text = "DC_BUS_I";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(6, 63);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(253, 27);
            this.label34.TabIndex = 14;
            this.label34.Text = "DC_BUS_VOLT";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(6, 33);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(253, 27);
            this.label28.TabIndex = 13;
            this.label28.Text = "PWM ENABLED";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(6, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(253, 27);
            this.label24.TabIndex = 12;
            this.label24.Text = "ZPC";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EMS);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LYRA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gmaptable.ResumeLayout(false);
            this.grafiktablelayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.datagridtable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.süreturpanel.ResumeLayout(false);
            this.süreturpanel.PerformLayout();
            this.gsmvesüretable.ResumeLayout(false);
            this.hiztable.ResumeLayout(false);
            this.hiztable.PerformLayout();
            this.mesafehiztable.ResumeLayout(false);
            this.mesafehiztable.PerformLayout();
            this.emsvoltpanel.ResumeLayout(false);
            this.emsvoltpanel.PerformLayout();
            this.emsampertable.ResumeLayout(false);
            this.emsampertable.PerformLayout();
            this.ems_volt_errortable.ResumeLayout(false);
            this.ems_volt_errortable.PerformLayout();
            this.emscurrenterrorpanel.ResumeLayout(false);
            this.emscurrenterrorpanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.EMS.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.rfkontroltable.ResumeLayout(false);
            this.rfkontroltable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gSMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlantıyıKesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bağlantıKesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem grafikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafikEkranıAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaGrafiğeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yarışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durdurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gpsMouseModAktifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gpsMouseModKapalıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtAçToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel gmaptable;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.TableLayoutPanel grafiktablelayout;
        private System.Windows.Forms.TableLayoutPanel datagridtable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel süreturpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel gsmvesüretable;
        private System.Windows.Forms.TableLayoutPanel mesafehiztable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel hiztable;
        private System.Windows.Forms.Label driver_set_tork;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel emsvoltpanel;
        private System.Windows.Forms.Label ems_out_volt_error;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label ems_fc_volt_error;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label ems_bat_volt_error;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel emsampertable;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TableLayoutPanel ems_volt_errortable;
        private System.Windows.Forms.TableLayoutPanel emscurrenterrorpanel;
        private System.Windows.Forms.Label ems_bat_current_error;
        private System.Windows.Forms.Label ems_fc_current_error;
        private System.Windows.Forms.Label ems_out_current_error;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox EMS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar history_displayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TableLayoutPanel rfkontroltable;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label bms_high_volt_error;
        private System.Windows.Forms.Label bms_low_volt_error;
        private System.Windows.Forms.Label bms_temp_error;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label bms_over_cur_error;
        private System.Windows.Forms.Label bms_comm_error;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label bms_precharge_flag;
        private System.Windows.Forms.Label bms_discharge_flag;
        private System.Windows.Forms.Label bms_dc_bus_ready_flag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ToolStripMenuItem cicikuşToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.ToolStripMenuItem markerTemizleToolStripMenuItem;
        private System.Windows.Forms.TextBox bms_temp;
        private System.Windows.Forms.TextBox ort_hiz;
        private System.Windows.Forms.TextBox maks_hiz;
        private System.Windows.Forms.TextBox gsm_yenileme;
        private System.Windows.Forms.TextBox set_hiz;
        private System.Windows.Forms.TextBox kalan_yol;
        private System.Windows.Forms.TextBox gidilen_yol;
        private System.Windows.Forms.TextBox anlik_hiz;
        private System.Windows.Forms.TextBox gidilen_yol_gps;
        private System.Windows.Forms.TextBox kalan_yol_gps;
        private System.Windows.Forms.TextBox bms_bat_cons;
        private System.Windows.Forms.TextBox bms_bat_current;
        private System.Windows.Forms.TextBox bms_bat_volt;
        private System.Windows.Forms.TextBox bms_worst_cell_address;
        private System.Windows.Forms.TextBox bms_worst_cell_volt;
        private System.Windows.Forms.TextBox bms_soc;
        private System.Windows.Forms.TextBox gsm_durum;
        private System.Windows.Forms.TextBox xbee_durum;
        private System.Windows.Forms.TextBox ems_durum;
        private System.Windows.Forms.TextBox bms_durum;
        private System.Windows.Forms.TextBox driver_durum;
        private System.Windows.Forms.TextBox ems_bat_volt;
        private System.Windows.Forms.TextBox ems_fc_volt;
        private System.Windows.Forms.TextBox ems_out_volt;
        private System.Windows.Forms.TextBox ems_out_current;
        private System.Windows.Forms.TextBox ems_fc_current;
        private System.Windows.Forms.TextBox ems_bat_current;
        private System.Windows.Forms.TextBox ems_fc_lt_cons;
        private System.Windows.Forms.TextBox ems_out_cons;
        private System.Windows.Forms.TextBox ems_fc_cons;
        private System.Windows.Forms.TextBox ems_bat_cons;
        private System.Windows.Forms.TextBox ems_penalty;
        private System.Windows.Forms.TextBox ems_bat_soc;
        private System.Windows.Forms.TextBox ems_temp;
        private System.Windows.Forms.TextBox verim;
        private System.Windows.Forms.TextBox cozulen_paket;
        private System.Windows.Forms.TextBox crc_hatali;
        private System.Windows.Forms.TextBox baslik_hatali;
        private System.Windows.Forms.TextBox gelen_bayt;
        private System.Windows.Forms.TextBox secilen_port;
        private System.Windows.Forms.TextBox vd;
        private System.Windows.Forms.TextBox vq;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox iq;
        private System.Windows.Forms.TextBox phase_a_volt;
        private System.Windows.Forms.TextBox phase_b_volt;
        private System.Windows.Forms.TextBox phase_c_volt;
        private System.Windows.Forms.TextBox dc_bus_volt;
        private System.Windows.Forms.TextBox dc_bus_cur;
        private System.Windows.Forms.TextBox phase_c_cur;
        private System.Windows.Forms.TextBox phase_b_cur;
        private System.Windows.Forms.TextBox phase_a_cur;
        private System.Windows.Forms.Timer time_counter;
        public System.Windows.Forms.TextBox anlik_hiz_gps;
        private System.Windows.Forms.Timer gsm_trigger;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox driver_fwrv_command;
        private System.Windows.Forms.TextBox driver_ign_command;
        private System.Windows.Forms.TextBox driver_brake_command;
        private System.Windows.Forms.TextBox driver_fwrv_status;
        private System.Windows.Forms.TextBox driver_brake_status;
        private System.Windows.Forms.TextBox driver_ign_status;
        private System.Windows.Forms.TextBox motor_temp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox act_torque;
        private System.Windows.Forms.TextBox hedef_hiz;
        private System.Windows.Forms.TextBox anlik_tur_suresi;
        private System.Windows.Forms.TextBox ortalama_tur_suresi;
        private System.Windows.Forms.TextBox turr;
        private System.Windows.Forms.TextBox kalan_sure;
        private System.Windows.Forms.TextBox gecen_sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur_dakika;
        private System.Windows.Forms.DataGridViewTextBoxColumn yol_vcu;
        private System.Windows.Forms.DataGridViewTextBoxColumn yol_gps;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalama_hiz_vcu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalama_hiz_gps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuketim_Bat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuketim_FC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuketim_FC_Lt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_Out;
        private System.Windows.Forms.ToolStripMenuItem hidromobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batConsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fcConsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outConsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fcLtConsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elektromobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafikDurdurToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label dc_bus_amper_error;
        private System.Windows.Forms.Label motor_temp_error;
        private System.Windows.Forms.Label id_error;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.Label zpc;
        private System.Windows.Forms.Label pwm_enabled;
        private System.Windows.Forms.Label dc_bus_voltage_error;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ToolStripMenuItem turAtToolStripMenuItem;
    }
}

