namespace Telemetri.NewForms
{
    partial class TestForm
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
            this.startSendBtn = new System.Windows.Forms.Button();
            this.testTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.torque_set_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.torque_limit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.torque_set_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speed_set_rpm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drive_commands = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.battery_temperature = new System.Windows.Forms.TextBox();
            this.worst_cell_adress = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dc_bus_state = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.volt = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.TextBox();
            this.cur = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.worst_cell_volt = new System.Windows.Forms.TextBox();
            this.cons = new System.Windows.Forms.TextBox();
            this.soc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.v_dc = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.act_torque = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.error_status = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.act_speed = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.i_dc = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.set_torque = new System.Windows.Forms.TextBox();
            this.act_id_current = new System.Windows.Forms.TextBox();
            this.set_iq_current = new System.Windows.Forms.TextBox();
            this.act_iq_current = new System.Windows.Forms.TextBox();
            this.set_id_current = new System.Windows.Forms.TextBox();
            this.vd = new System.Windows.Forms.TextBox();
            this.vq = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.efficiency = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.sattelite = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.TextBox();
            this.stpBtn = new System.Windows.Forms.Button();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.sendOnceBtn = new System.Windows.Forms.Button();
            this.startSendNC = new System.Windows.Forms.Button();
            this.stopSendNC = new System.Windows.Forms.Button();
            this.sendOnceNC = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.testTimerNC = new System.Windows.Forms.Timer(this.components);
            this.cozulduvtiBox = new System.Windows.Forms.Label();
            this.highbutton = new System.Windows.Forms.Button();
            this.mediumbutton = new System.Windows.Forms.Button();
            this.lowbutton = new System.Windows.Forms.Button();
            this.cozuldulyraBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.steering_angle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.testTimerInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // startSendBtn
            // 
            this.startSendBtn.Location = new System.Drawing.Point(679, 519);
            this.startSendBtn.Name = "startSendBtn";
            this.startSendBtn.Size = new System.Drawing.Size(89, 20);
            this.startSendBtn.TabIndex = 0;
            this.startSendBtn.Text = "START SEND";
            this.startSendBtn.UseVisualStyleBackColor = true;
            this.startSendBtn.Click += new System.EventHandler(this.startSendBtn_Click);
            // 
            // testTimerInterval
            // 
            this.testTimerInterval.Location = new System.Drawing.Point(774, 519);
            this.testTimerInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.testTimerInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.testTimerInterval.Name = "testTimerInterval";
            this.testTimerInterval.Size = new System.Drawing.Size(90, 20);
            this.testTimerInterval.TabIndex = 1;
            this.testTimerInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // testTimer
            // 
            this.testTimer.Tick += new System.EventHandler(this.testTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.steering_angle);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.torque_set_2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.torque_limit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.torque_set_1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.speed_set_rpm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.drive_commands);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(44, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 327);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VCU";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(23, 125);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(84, 16);
            this.label35.TabIndex = 11;
            this.label35.Text = "Set Torque 2";
            // 
            // torque_set_2
            // 
            this.torque_set_2.Location = new System.Drawing.Point(154, 119);
            this.torque_set_2.Name = "torque_set_2";
            this.torque_set_2.Size = new System.Drawing.Size(78, 26);
            this.torque_set_2.TabIndex = 10;
            this.torque_set_2.Text = "35";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Torque Limit";
            // 
            // torque_limit
            // 
            this.torque_limit.Location = new System.Drawing.Point(154, 151);
            this.torque_limit.Name = "torque_limit";
            this.torque_limit.Size = new System.Drawing.Size(78, 26);
            this.torque_limit.TabIndex = 8;
            this.torque_limit.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Set Torque 1";
            // 
            // torque_set_1
            // 
            this.torque_set_1.Location = new System.Drawing.Point(154, 88);
            this.torque_set_1.Name = "torque_set_1";
            this.torque_set_1.Size = new System.Drawing.Size(78, 26);
            this.torque_set_1.TabIndex = 4;
            this.torque_set_1.Text = "35";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set RPM";
            // 
            // speed_set_rpm
            // 
            this.speed_set_rpm.AcceptsReturn = true;
            this.speed_set_rpm.Location = new System.Drawing.Point(154, 57);
            this.speed_set_rpm.Name = "speed_set_rpm";
            this.speed_set_rpm.Size = new System.Drawing.Size(78, 26);
            this.speed_set_rpm.TabIndex = 2;
            this.speed_set_rpm.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drive Commands";
            // 
            // drive_commands
            // 
            this.drive_commands.Location = new System.Drawing.Point(154, 26);
            this.drive_commands.Name = "drive_commands";
            this.drive_commands.Size = new System.Drawing.Size(78, 26);
            this.drive_commands.TabIndex = 0;
            this.drive_commands.Text = "3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.battery_temperature);
            this.groupBox2.Controls.Add(this.worst_cell_adress);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.dc_bus_state);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.volt);
            this.groupBox2.Controls.Add(this.error);
            this.groupBox2.Controls.Add(this.cur);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.worst_cell_volt);
            this.groupBox2.Controls.Add(this.cons);
            this.groupBox2.Controls.Add(this.soc);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(330, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 327);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BMS";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(6, 286);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 16);
            this.label20.TabIndex = 41;
            this.label20.Text = "Temperature";
            // 
            // battery_temperature
            // 
            this.battery_temperature.Location = new System.Drawing.Point(151, 280);
            this.battery_temperature.Name = "battery_temperature";
            this.battery_temperature.Size = new System.Drawing.Size(78, 26);
            this.battery_temperature.TabIndex = 40;
            this.battery_temperature.Text = "27";
            // 
            // worst_cell_adress
            // 
            this.worst_cell_adress.Location = new System.Drawing.Point(151, 248);
            this.worst_cell_adress.Name = "worst_cell_adress";
            this.worst_cell_adress.Size = new System.Drawing.Size(78, 26);
            this.worst_cell_adress.TabIndex = 39;
            this.worst_cell_adress.Text = "5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(6, 258);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 16);
            this.label19.TabIndex = 38;
            this.label19.Text = "Worst Cell Adress";
            // 
            // dc_bus_state
            // 
            this.dc_bus_state.Location = new System.Drawing.Point(151, 216);
            this.dc_bus_state.Name = "dc_bus_state";
            this.dc_bus_state.Size = new System.Drawing.Size(78, 26);
            this.dc_bus_state.TabIndex = 37;
            this.dc_bus_state.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "DC Bus State";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "BMS Error";
            // 
            // volt
            // 
            this.volt.Location = new System.Drawing.Point(151, 26);
            this.volt.Name = "volt";
            this.volt.Size = new System.Drawing.Size(78, 26);
            this.volt.TabIndex = 12;
            this.volt.Text = "117";
            // 
            // error
            // 
            this.error.Location = new System.Drawing.Point(151, 183);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(78, 26);
            this.error.TabIndex = 22;
            this.error.Text = "3";
            // 
            // cur
            // 
            this.cur.Location = new System.Drawing.Point(151, 57);
            this.cur.Name = "cur";
            this.cur.Size = new System.Drawing.Size(78, 26);
            this.cur.TabIndex = 14;
            this.cur.Text = "10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(6, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "Battery Voltage";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "Worst Cell Volt.";
            // 
            // worst_cell_volt
            // 
            this.worst_cell_volt.Location = new System.Drawing.Point(151, 151);
            this.worst_cell_volt.Name = "worst_cell_volt";
            this.worst_cell_volt.Size = new System.Drawing.Size(78, 26);
            this.worst_cell_volt.TabIndex = 20;
            this.worst_cell_volt.Text = "17";
            // 
            // cons
            // 
            this.cons.Location = new System.Drawing.Point(151, 88);
            this.cons.Name = "cons";
            this.cons.Size = new System.Drawing.Size(78, 26);
            this.cons.TabIndex = 16;
            this.cons.Text = "120";
            // 
            // soc
            // 
            this.soc.Location = new System.Drawing.Point(151, 119);
            this.soc.Name = "soc";
            this.soc.Size = new System.Drawing.Size(78, 26);
            this.soc.TabIndex = 18;
            this.soc.Text = "87";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(6, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "Battery Current";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "Battery Cons.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(6, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "SoC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(23, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "IQ Set";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(23, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "ID Act.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(23, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID Set";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(23, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "IQ Act.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(23, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "VQ Act.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(23, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "VD Act.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.v_dc);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.act_torque);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.temperature);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.error_status);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.act_speed);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.i_dc);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.set_torque);
            this.groupBox3.Controls.Add(this.act_id_current);
            this.groupBox3.Controls.Add(this.set_iq_current);
            this.groupBox3.Controls.Add(this.act_iq_current);
            this.groupBox3.Controls.Add(this.set_id_current);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.vd);
            this.groupBox3.Controls.Add(this.vq);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(616, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 453);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MCU";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(23, 286);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 16);
            this.label32.TabIndex = 47;
            this.label32.Text = "VDC";
            // 
            // v_dc
            // 
            this.v_dc.Location = new System.Drawing.Point(148, 280);
            this.v_dc.Name = "v_dc";
            this.v_dc.Size = new System.Drawing.Size(78, 26);
            this.v_dc.TabIndex = 48;
            this.v_dc.Text = "20";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(24, 417);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(76, 16);
            this.label31.TabIndex = 45;
            this.label31.Text = "Act. Torque";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // act_torque
            // 
            this.act_torque.Location = new System.Drawing.Point(148, 413);
            this.act_torque.Name = "act_torque";
            this.act_torque.Size = new System.Drawing.Size(78, 26);
            this.act_torque.TabIndex = 46;
            this.act_torque.Text = "125";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(24, 352);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 16);
            this.label30.TabIndex = 43;
            this.label30.Text = "Motor Temp.";
            // 
            // temperature
            // 
            this.temperature.Location = new System.Drawing.Point(148, 346);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(78, 26);
            this.temperature.TabIndex = 44;
            this.temperature.Text = "27";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(24, 386);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(76, 16);
            this.label29.TabIndex = 41;
            this.label29.Text = "Error Status";
            // 
            // error_status
            // 
            this.error_status.Location = new System.Drawing.Point(149, 380);
            this.error_status.Name = "error_status";
            this.error_status.Size = new System.Drawing.Size(78, 26);
            this.error_status.TabIndex = 42;
            this.error_status.Text = "7";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(23, 320);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(73, 16);
            this.label28.TabIndex = 39;
            this.label28.Text = "Act. Speed";
            // 
            // act_speed
            // 
            this.act_speed.Location = new System.Drawing.Point(148, 314);
            this.act_speed.Name = "act_speed";
            this.act_speed.Size = new System.Drawing.Size(78, 26);
            this.act_speed.TabIndex = 40;
            this.act_speed.Text = "50";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(23, 258);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 16);
            this.label27.TabIndex = 37;
            this.label27.Text = "IDC";
            // 
            // i_dc
            // 
            this.i_dc.Location = new System.Drawing.Point(148, 248);
            this.i_dc.Name = "i_dc";
            this.i_dc.Size = new System.Drawing.Size(78, 26);
            this.i_dc.TabIndex = 38;
            this.i_dc.Text = "20";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(23, 226);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 16);
            this.label26.TabIndex = 35;
            this.label26.Text = "Set Torque";
            // 
            // set_torque
            // 
            this.set_torque.Location = new System.Drawing.Point(148, 216);
            this.set_torque.Name = "set_torque";
            this.set_torque.Size = new System.Drawing.Size(78, 26);
            this.set_torque.TabIndex = 36;
            this.set_torque.Text = "50";
            // 
            // act_id_current
            // 
            this.act_id_current.Location = new System.Drawing.Point(148, 26);
            this.act_id_current.Name = "act_id_current";
            this.act_id_current.Size = new System.Drawing.Size(78, 26);
            this.act_id_current.TabIndex = 24;
            this.act_id_current.Text = "12";
            // 
            // set_iq_current
            // 
            this.set_iq_current.Location = new System.Drawing.Point(148, 183);
            this.set_iq_current.Name = "set_iq_current";
            this.set_iq_current.Size = new System.Drawing.Size(78, 26);
            this.set_iq_current.TabIndex = 34;
            this.set_iq_current.Text = "30";
            // 
            // act_iq_current
            // 
            this.act_iq_current.Location = new System.Drawing.Point(148, 57);
            this.act_iq_current.Name = "act_iq_current";
            this.act_iq_current.Size = new System.Drawing.Size(78, 26);
            this.act_iq_current.TabIndex = 26;
            this.act_iq_current.Text = "24";
            // 
            // set_id_current
            // 
            this.set_id_current.Location = new System.Drawing.Point(148, 151);
            this.set_id_current.Name = "set_id_current";
            this.set_id_current.Size = new System.Drawing.Size(78, 26);
            this.set_id_current.TabIndex = 32;
            this.set_id_current.Text = "30";
            // 
            // vd
            // 
            this.vd.Location = new System.Drawing.Point(148, 88);
            this.vd.Name = "vd";
            this.vd.Size = new System.Drawing.Size(78, 26);
            this.vd.TabIndex = 28;
            this.vd.Text = "38";
            // 
            // vq
            // 
            this.vq.Location = new System.Drawing.Point(148, 119);
            this.vq.Name = "vq";
            this.vq.Size = new System.Drawing.Size(78, 26);
            this.vq.TabIndex = 30;
            this.vq.Text = "40";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.efficiency);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.sattelite);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.speed);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.longitude);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.latitude);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(44, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 193);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GPS";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(23, 157);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 16);
            this.label23.TabIndex = 9;
            this.label23.Text = "GPS Efficiency";
            // 
            // efficiency
            // 
            this.efficiency.Location = new System.Drawing.Point(154, 151);
            this.efficiency.Name = "efficiency";
            this.efficiency.Size = new System.Drawing.Size(78, 26);
            this.efficiency.TabIndex = 8;
            this.efficiency.Text = "87";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(23, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(106, 16);
            this.label22.TabIndex = 7;
            this.label22.Text = "Satellite Number";
            // 
            // sattelite
            // 
            this.sattelite.Location = new System.Drawing.Point(154, 120);
            this.sattelite.Name = "sattelite";
            this.sattelite.Size = new System.Drawing.Size(78, 26);
            this.sattelite.TabIndex = 6;
            this.sattelite.Text = "4";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(23, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 16);
            this.label21.TabIndex = 5;
            this.label21.Text = "Speed";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(154, 88);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(78, 26);
            this.speed.TabIndex = 4;
            this.speed.Text = "40";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(23, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 16);
            this.label24.TabIndex = 3;
            this.label24.Text = "Longtitude";
            // 
            // longitude
            // 
            this.longitude.Location = new System.Drawing.Point(154, 57);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(78, 26);
            this.longitude.TabIndex = 2;
            this.longitude.Text = "500";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(23, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 16);
            this.label25.TabIndex = 1;
            this.label25.Text = "Latitude";
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(154, 26);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(78, 26);
            this.latitude.TabIndex = 0;
            this.latitude.Text = "1200";
            // 
            // stpBtn
            // 
            this.stpBtn.Location = new System.Drawing.Point(679, 545);
            this.stpBtn.Name = "stpBtn";
            this.stpBtn.Size = new System.Drawing.Size(89, 20);
            this.stpBtn.TabIndex = 11;
            this.stpBtn.Text = "STOP";
            this.stpBtn.UseVisualStyleBackColor = true;
            this.stpBtn.Click += new System.EventHandler(this.stpBtn_Click);
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // sendOnceBtn
            // 
            this.sendOnceBtn.Location = new System.Drawing.Point(679, 571);
            this.sendOnceBtn.Name = "sendOnceBtn";
            this.sendOnceBtn.Size = new System.Drawing.Size(89, 20);
            this.sendOnceBtn.TabIndex = 12;
            this.sendOnceBtn.Text = "SEND ONCE";
            this.sendOnceBtn.UseVisualStyleBackColor = true;
            this.sendOnceBtn.Click += new System.EventHandler(this.sendOnceBtn_Click);
            // 
            // startSendNC
            // 
            this.startSendNC.Location = new System.Drawing.Point(584, 519);
            this.startSendNC.Name = "startSendNC";
            this.startSendNC.Size = new System.Drawing.Size(89, 20);
            this.startSendNC.TabIndex = 13;
            this.startSendNC.Text = "START SEND";
            this.startSendNC.UseVisualStyleBackColor = true;
            this.startSendNC.Click += new System.EventHandler(this.startSendNC_Click);
            // 
            // stopSendNC
            // 
            this.stopSendNC.Location = new System.Drawing.Point(584, 545);
            this.stopSendNC.Name = "stopSendNC";
            this.stopSendNC.Size = new System.Drawing.Size(89, 20);
            this.stopSendNC.TabIndex = 14;
            this.stopSendNC.Text = "STOP";
            this.stopSendNC.UseVisualStyleBackColor = true;
            this.stopSendNC.Click += new System.EventHandler(this.stopSendNC_Click);
            // 
            // sendOnceNC
            // 
            this.sendOnceNC.Location = new System.Drawing.Point(584, 571);
            this.sendOnceNC.Name = "sendOnceNC";
            this.sendOnceNC.Size = new System.Drawing.Size(89, 20);
            this.sendOnceNC.TabIndex = 15;
            this.sendOnceNC.Text = "SEND ONCE";
            this.sendOnceNC.UseVisualStyleBackColor = true;
            this.sendOnceNC.Click += new System.EventHandler(this.sendOnceNC_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label33.Location = new System.Drawing.Point(692, 498);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(54, 13);
            this.label33.TabIndex = 16;
            this.label33.Text = "COMPRO";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label34.Location = new System.Drawing.Point(596, 498);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(73, 13);
            this.label34.TabIndex = 17;
            this.label34.Text = "NO COMPRO";
            // 
            // testTimerNC
            // 
            this.testTimerNC.Tick += new System.EventHandler(this.testTimerNC_Tick);
            // 
            // cozulduvtiBox
            // 
            this.cozulduvtiBox.AutoSize = true;
            this.cozulduvtiBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cozulduvtiBox.ForeColor = System.Drawing.Color.White;
            this.cozulduvtiBox.Location = new System.Drawing.Point(414, 491);
            this.cozulduvtiBox.Name = "cozulduvtiBox";
            this.cozulduvtiBox.Size = new System.Drawing.Size(85, 29);
            this.cozulduvtiBox.TabIndex = 19;
            this.cozulduvtiBox.Text = "label36";
            // 
            // highbutton
            // 
            this.highbutton.Location = new System.Drawing.Point(505, 506);
            this.highbutton.Name = "highbutton";
            this.highbutton.Size = new System.Drawing.Size(60, 20);
            this.highbutton.TabIndex = 22;
            this.highbutton.Text = "HIGH";
            this.highbutton.UseVisualStyleBackColor = true;
            this.highbutton.Click += new System.EventHandler(this.highbutton_Click);
            // 
            // mediumbutton
            // 
            this.mediumbutton.Location = new System.Drawing.Point(505, 532);
            this.mediumbutton.Name = "mediumbutton";
            this.mediumbutton.Size = new System.Drawing.Size(60, 20);
            this.mediumbutton.TabIndex = 21;
            this.mediumbutton.Text = "MEDIUM";
            this.mediumbutton.UseVisualStyleBackColor = true;
            this.mediumbutton.Click += new System.EventHandler(this.mediumbutton_Click);
            // 
            // lowbutton
            // 
            this.lowbutton.Location = new System.Drawing.Point(505, 558);
            this.lowbutton.Name = "lowbutton";
            this.lowbutton.Size = new System.Drawing.Size(60, 20);
            this.lowbutton.TabIndex = 20;
            this.lowbutton.Text = "LOW";
            this.lowbutton.UseVisualStyleBackColor = true;
            this.lowbutton.Click += new System.EventHandler(this.lowbutton_Click);
            // 
            // cozuldulyraBox
            // 
            this.cozuldulyraBox.AutoSize = true;
            this.cozuldulyraBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cozuldulyraBox.ForeColor = System.Drawing.Color.White;
            this.cozuldulyraBox.Location = new System.Drawing.Point(414, 448);
            this.cozuldulyraBox.Name = "cozuldulyraBox";
            this.cozuldulyraBox.Size = new System.Drawing.Size(85, 29);
            this.cozuldulyraBox.TabIndex = 18;
            this.cozuldulyraBox.Text = "label35";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Steering Angle";
            // 
            // steering_angle
            // 
            this.steering_angle.Location = new System.Drawing.Point(154, 183);
            this.steering_angle.Name = "steering_angle";
            this.steering_angle.Size = new System.Drawing.Size(78, 26);
            this.steering_angle.TabIndex = 12;
            this.steering_angle.Text = "80";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(914, 621);
            this.Controls.Add(this.highbutton);
            this.Controls.Add(this.mediumbutton);
            this.Controls.Add(this.lowbutton);
            this.Controls.Add(this.cozulduvtiBox);
            this.Controls.Add(this.cozuldulyraBox);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.sendOnceNC);
            this.Controls.Add(this.stopSendNC);
            this.Controls.Add(this.startSendNC);
            this.Controls.Add(this.sendOnceBtn);
            this.Controls.Add(this.stpBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.testTimerInterval);
            this.Controls.Add(this.startSendBtn);
            this.DoubleBuffered = true;
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testTimerInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startSendBtn;
        private System.Windows.Forms.NumericUpDown testTimerInterval;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox torque_limit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox torque_set_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox speed_set_rpm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox drive_commands;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox volt;
        private System.Windows.Forms.TextBox error;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cur;
        private System.Windows.Forms.TextBox worst_cell_volt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cons;
        private System.Windows.Forms.TextBox soc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox act_id_current;
        private System.Windows.Forms.TextBox set_iq_current;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox act_iq_current;
        private System.Windows.Forms.TextBox set_id_current;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox vd;
        private System.Windows.Forms.TextBox vq;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox battery_temperature;
        private System.Windows.Forms.TextBox worst_cell_adress;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox dc_bus_state;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox efficiency;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox sattelite;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.Button stpBtn;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox act_torque;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox temperature;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox error_status;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox act_speed;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox i_dc;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox set_torque;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox v_dc;
        private System.Windows.Forms.Button sendOnceBtn;
        private System.Windows.Forms.Button startSendNC;
        private System.Windows.Forms.Button stopSendNC;
        private System.Windows.Forms.Button sendOnceNC;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Timer testTimerNC;
        private System.Windows.Forms.Label cozulduvtiBox;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox torque_set_2;
        private System.Windows.Forms.Button highbutton;
        private System.Windows.Forms.Button mediumbutton;
        private System.Windows.Forms.Button lowbutton;
        private System.Windows.Forms.Label cozuldulyraBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox steering_angle;
    }
}