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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
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
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.stpBtn = new System.Windows.Forms.Button();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.sendOnceBtn = new System.Windows.Forms.Button();
            this.startSendNC = new System.Windows.Forms.Button();
            this.stopSendNC = new System.Windows.Forms.Button();
            this.sendOnceNC = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.testTimerNC = new System.Windows.Forms.Timer(this.components);
            this.cozuldulyraBox = new System.Windows.Forms.Label();
            this.cozulduvtiBox = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(44, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 327);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VCU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Torque Limit";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(154, 151);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 26);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Speed Limit";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(154, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 26);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "45";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Set Torque";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(154, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 26);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "35";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set RPM";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drive Commands";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBox20);
            this.groupBox2.Controls.Add(this.textBox19);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
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
            this.label20.Size = new System.Drawing.Size(86, 16);
            this.label20.TabIndex = 41;
            this.label20.Text = "Temperature";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(151, 280);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(78, 26);
            this.textBox20.TabIndex = 40;
            this.textBox20.Text = "27";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(151, 248);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(78, 26);
            this.textBox19.TabIndex = 39;
            this.textBox19.Text = "5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(6, 258);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 16);
            this.label19.TabIndex = 38;
            this.label19.Text = "Worst Cell Adress";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(151, 216);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(78, 26);
            this.textBox6.TabIndex = 37;
            this.textBox6.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "DC Bus State";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "BMS Error";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(151, 26);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(78, 26);
            this.textBox12.TabIndex = 12;
            this.textBox12.Text = "117";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(151, 183);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(78, 26);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "3";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(151, 57);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(78, 26);
            this.textBox11.TabIndex = 14;
            this.textBox11.Text = "10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(6, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "Battery Voltage";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "Worst Cell Volt.";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(151, 151);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(78, 26);
            this.textBox8.TabIndex = 20;
            this.textBox8.Text = "17";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(151, 88);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(78, 26);
            this.textBox10.TabIndex = 16;
            this.textBox10.Text = "120";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(151, 119);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(78, 26);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "87";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(6, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "Battery Current";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "Battery Cons.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(6, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "SoC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(23, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "IQ Set";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(23, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "ID Act.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(23, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID Set";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(23, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "IQ Act.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(23, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "VQ Act.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(23, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "VD Act.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.textBox32);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.textBox31);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.textBox30);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.textBox29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.textBox28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.textBox27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.textBox26);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox18);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.textBox17);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.textBox15);
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
            this.label32.Location = new System.Drawing.Point(23, 290);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(36, 16);
            this.label32.TabIndex = 47;
            this.label32.Text = "VDC";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(148, 280);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(78, 26);
            this.textBox32.TabIndex = 48;
            this.textBox32.Text = "20";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(24, 417);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(77, 16);
            this.label31.TabIndex = 45;
            this.label31.Text = "Act. Torque";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(148, 413);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(78, 26);
            this.textBox31.TabIndex = 46;
            this.textBox31.Text = "125";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(24, 352);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(84, 16);
            this.label30.TabIndex = 43;
            this.label30.Text = "Motor Temp.";
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(148, 346);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(78, 26);
            this.textBox30.TabIndex = 44;
            this.textBox30.Text = "27";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(24, 386);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 16);
            this.label29.TabIndex = 41;
            this.label29.Text = "Error Status";
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(149, 380);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(78, 26);
            this.textBox29.TabIndex = 42;
            this.textBox29.Text = "7";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(23, 320);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 16);
            this.label28.TabIndex = 39;
            this.label28.Text = "Act. Speed";
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(148, 314);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(78, 26);
            this.textBox28.TabIndex = 40;
            this.textBox28.Text = "50";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(23, 258);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 16);
            this.label27.TabIndex = 37;
            this.label27.Text = "IDC";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(148, 248);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(78, 26);
            this.textBox27.TabIndex = 38;
            this.textBox27.Text = "20";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(23, 226);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 16);
            this.label26.TabIndex = 35;
            this.label26.Text = "Set Torque";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(148, 216);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(78, 26);
            this.textBox26.TabIndex = 36;
            this.textBox26.Text = "50";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(148, 26);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(78, 26);
            this.textBox18.TabIndex = 24;
            this.textBox18.Text = "12";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(148, 183);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(78, 26);
            this.textBox13.TabIndex = 34;
            this.textBox13.Text = "30";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(148, 57);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(78, 26);
            this.textBox17.TabIndex = 26;
            this.textBox17.Text = "24";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(148, 151);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(78, 26);
            this.textBox14.TabIndex = 32;
            this.textBox14.Text = "30";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(148, 88);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(78, 26);
            this.textBox16.TabIndex = 28;
            this.textBox16.Text = "38";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(148, 119);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(78, 26);
            this.textBox15.TabIndex = 30;
            this.textBox15.Text = "40";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.textBox23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.textBox22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.textBox21);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.textBox24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.textBox25);
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
            this.label23.Size = new System.Drawing.Size(96, 16);
            this.label23.TabIndex = 9;
            this.label23.Text = "GPS Efficiency";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(154, 151);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(78, 26);
            this.textBox23.TabIndex = 8;
            this.textBox23.Text = "87";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(23, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 16);
            this.label22.TabIndex = 7;
            this.label22.Text = "Satellite Number";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(154, 120);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(78, 26);
            this.textBox22.TabIndex = 6;
            this.textBox22.Text = "4";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(23, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 16);
            this.label21.TabIndex = 5;
            this.label21.Text = "Speed";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(154, 88);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(78, 26);
            this.textBox21.TabIndex = 4;
            this.textBox21.Text = "40";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(23, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 16);
            this.label24.TabIndex = 3;
            this.label24.Text = "Longtitude";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(154, 57);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(78, 26);
            this.textBox24.TabIndex = 2;
            this.textBox24.Text = "500";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(23, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 16);
            this.label25.TabIndex = 1;
            this.label25.Text = "Latitude";
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(154, 26);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(78, 26);
            this.textBox25.TabIndex = 0;
            this.textBox25.Text = "1200";
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
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(914, 621);
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Button stpBtn;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox26;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Button sendOnceBtn;
        private System.Windows.Forms.Button startSendNC;
        private System.Windows.Forms.Button stopSendNC;
        private System.Windows.Forms.Button sendOnceNC;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Timer testTimerNC;
        private System.Windows.Forms.Label cozuldulyraBox;
        private System.Windows.Forms.Label cozulduvtiBox;
    }
}