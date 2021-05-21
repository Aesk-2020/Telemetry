namespace Telemetri.NewForms
{
    partial class Anasayfa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 11D);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.portsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.finishBtn = new FontAwesome.Sharp.IconButton();
            this.startBtn = new FontAwesome.Sharp.IconButton();
            this.portConnectBtn = new FontAwesome.Sharp.IconButton();
            this.portDisconnectBtn = new FontAwesome.Sharp.IconButton();
            this.mqttDisconnectBtn = new FontAwesome.Sharp.IconButton();
            this.mqttConnectBtn = new FontAwesome.Sharp.IconButton();
            this.openGUILogBtn = new FontAwesome.Sharp.IconButton();
            this.openSDLogBtn = new FontAwesome.Sharp.IconButton();
            this.stopLogBtn = new FontAwesome.Sharp.IconButton();
            this.startLogBtn = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.actVelocityLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.setVelocityLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.batConsLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.batCurLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.socLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.startTimeLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.logTimer = new System.Windows.Forms.Timer(this.components);
            this.mqttWorker = new System.ComponentModel.BackgroundWorker();
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.driveStatusLabel = new System.Windows.Forms.TextBox();
            this.errorsLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(914, 92);
            this.tableLayoutPanel2.TabIndex = 123;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.portsListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(793, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 86);
            this.panel1.TabIndex = 141;
            // 
            // portsListBox
            // 
            this.portsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.portsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portsListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portsListBox.ForeColor = System.Drawing.Color.White;
            this.portsListBox.FormattingEnabled = true;
            this.portsListBox.ItemHeight = 21;
            this.portsListBox.Location = new System.Drawing.Point(0, 0);
            this.portsListBox.Name = "portsListBox";
            this.portsListBox.Size = new System.Drawing.Size(116, 84);
            this.portsListBox.TabIndex = 118;
            this.portsListBox.Click += new System.EventHandler(this.portsListBox_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.finishBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.startBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.portConnectBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.portDisconnectBtn, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.mqttDisconnectBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.mqttConnectBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.openGUILogBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.openSDLogBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.stopLogBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.startLogBtn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 86);
            this.tableLayoutPanel1.TabIndex = 121;
            // 
            // finishBtn
            // 
            this.finishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finishBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishBtn.Enabled = false;
            this.finishBtn.FlatAppearance.BorderSize = 0;
            this.finishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.finishBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.finishBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.finishBtn.IconColor = System.Drawing.Color.Black;
            this.finishBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.finishBtn.Location = new System.Drawing.Point(4, 46);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(149, 36);
            this.finishBtn.TabIndex = 122;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = false;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.startBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.startBtn.IconColor = System.Drawing.Color.Black;
            this.startBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.startBtn.Location = new System.Drawing.Point(4, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(149, 35);
            this.startBtn.TabIndex = 121;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // portConnectBtn
            // 
            this.portConnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.portConnectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portConnectBtn.FlatAppearance.BorderSize = 0;
            this.portConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portConnectBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portConnectBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.portConnectBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.portConnectBtn.IconColor = System.Drawing.Color.Black;
            this.portConnectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.portConnectBtn.Location = new System.Drawing.Point(628, 4);
            this.portConnectBtn.Name = "portConnectBtn";
            this.portConnectBtn.Size = new System.Drawing.Size(152, 35);
            this.portConnectBtn.TabIndex = 119;
            this.portConnectBtn.Text = "Port Connect";
            this.portConnectBtn.UseVisualStyleBackColor = false;
            this.portConnectBtn.Click += new System.EventHandler(this.portConnectBtn_Click);
            // 
            // portDisconnectBtn
            // 
            this.portDisconnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.portDisconnectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portDisconnectBtn.Enabled = false;
            this.portDisconnectBtn.FlatAppearance.BorderSize = 0;
            this.portDisconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portDisconnectBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portDisconnectBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.portDisconnectBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.portDisconnectBtn.IconColor = System.Drawing.Color.Black;
            this.portDisconnectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.portDisconnectBtn.Location = new System.Drawing.Point(628, 46);
            this.portDisconnectBtn.Name = "portDisconnectBtn";
            this.portDisconnectBtn.Size = new System.Drawing.Size(152, 36);
            this.portDisconnectBtn.TabIndex = 120;
            this.portDisconnectBtn.Text = "Port Disconnect";
            this.portDisconnectBtn.UseVisualStyleBackColor = false;
            // 
            // mqttDisconnectBtn
            // 
            this.mqttDisconnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mqttDisconnectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mqttDisconnectBtn.Enabled = false;
            this.mqttDisconnectBtn.FlatAppearance.BorderSize = 0;
            this.mqttDisconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mqttDisconnectBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mqttDisconnectBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.mqttDisconnectBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.mqttDisconnectBtn.IconColor = System.Drawing.Color.Black;
            this.mqttDisconnectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mqttDisconnectBtn.Location = new System.Drawing.Point(472, 46);
            this.mqttDisconnectBtn.Name = "mqttDisconnectBtn";
            this.mqttDisconnectBtn.Size = new System.Drawing.Size(149, 36);
            this.mqttDisconnectBtn.TabIndex = 114;
            this.mqttDisconnectBtn.Text = "MQTT Disconnect";
            this.mqttDisconnectBtn.UseVisualStyleBackColor = false;
            this.mqttDisconnectBtn.Click += new System.EventHandler(this.mqttDisconnectBtn_Click);
            // 
            // mqttConnectBtn
            // 
            this.mqttConnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mqttConnectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mqttConnectBtn.FlatAppearance.BorderSize = 0;
            this.mqttConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mqttConnectBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mqttConnectBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.mqttConnectBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.mqttConnectBtn.IconColor = System.Drawing.Color.Black;
            this.mqttConnectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mqttConnectBtn.Location = new System.Drawing.Point(472, 4);
            this.mqttConnectBtn.Name = "mqttConnectBtn";
            this.mqttConnectBtn.Size = new System.Drawing.Size(149, 35);
            this.mqttConnectBtn.TabIndex = 110;
            this.mqttConnectBtn.Text = "MQTT Connect";
            this.mqttConnectBtn.UseVisualStyleBackColor = false;
            this.mqttConnectBtn.Click += new System.EventHandler(this.mqttConnectBtn_Click);
            // 
            // openGUILogBtn
            // 
            this.openGUILogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openGUILogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGUILogBtn.FlatAppearance.BorderSize = 0;
            this.openGUILogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openGUILogBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.openGUILogBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.openGUILogBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.openGUILogBtn.IconColor = System.Drawing.Color.Black;
            this.openGUILogBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.openGUILogBtn.Location = new System.Drawing.Point(316, 46);
            this.openGUILogBtn.Name = "openGUILogBtn";
            this.openGUILogBtn.Size = new System.Drawing.Size(149, 36);
            this.openGUILogBtn.TabIndex = 116;
            this.openGUILogBtn.Text = "Open GUI Log";
            this.openGUILogBtn.UseVisualStyleBackColor = false;
            // 
            // openSDLogBtn
            // 
            this.openSDLogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openSDLogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openSDLogBtn.FlatAppearance.BorderSize = 0;
            this.openSDLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSDLogBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.openSDLogBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.openSDLogBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.openSDLogBtn.IconColor = System.Drawing.Color.Black;
            this.openSDLogBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.openSDLogBtn.Location = new System.Drawing.Point(316, 4);
            this.openSDLogBtn.Name = "openSDLogBtn";
            this.openSDLogBtn.Size = new System.Drawing.Size(149, 35);
            this.openSDLogBtn.TabIndex = 115;
            this.openSDLogBtn.Text = "Open SD Log";
            this.openSDLogBtn.UseVisualStyleBackColor = false;
            this.openSDLogBtn.Click += new System.EventHandler(this.openSDLogBtn_Click);
            // 
            // stopLogBtn
            // 
            this.stopLogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopLogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopLogBtn.Enabled = false;
            this.stopLogBtn.FlatAppearance.BorderSize = 0;
            this.stopLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopLogBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopLogBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.stopLogBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.stopLogBtn.IconColor = System.Drawing.Color.Black;
            this.stopLogBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.stopLogBtn.Location = new System.Drawing.Point(160, 46);
            this.stopLogBtn.Name = "stopLogBtn";
            this.stopLogBtn.Size = new System.Drawing.Size(149, 36);
            this.stopLogBtn.TabIndex = 109;
            this.stopLogBtn.Text = "Stop Logging";
            this.stopLogBtn.UseVisualStyleBackColor = false;
            this.stopLogBtn.Click += new System.EventHandler(this.stopLogBtn_Click);
            // 
            // startLogBtn
            // 
            this.startLogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startLogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startLogBtn.Enabled = false;
            this.startLogBtn.FlatAppearance.BorderSize = 0;
            this.startLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startLogBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startLogBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.startLogBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.startLogBtn.IconColor = System.Drawing.Color.Black;
            this.startLogBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.startLogBtn.Location = new System.Drawing.Point(160, 4);
            this.startLogBtn.Name = "startLogBtn";
            this.startLogBtn.Size = new System.Drawing.Size(149, 35);
            this.startLogBtn.TabIndex = 108;
            this.startLogBtn.Text = "Start Logging";
            this.startLogBtn.UseVisualStyleBackColor = false;
            this.startLogBtn.Click += new System.EventHandler(this.startLogBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 52);
            this.label3.TabIndex = 131;
            this.label3.Text = "Set Velocity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 111);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(278, 102);
            this.tableLayoutPanel4.TabIndex = 134;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.actVelocityLabel, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(142, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(132, 94);
            this.tableLayoutPanel6.TabIndex = 136;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 52);
            this.label4.TabIndex = 131;
            this.label4.Text = "Act Velocity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actVelocityLabel
            // 
            this.actVelocityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.actVelocityLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actVelocityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actVelocityLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.actVelocityLabel.ForeColor = System.Drawing.Color.White;
            this.actVelocityLabel.Location = new System.Drawing.Point(3, 55);
            this.actVelocityLabel.Multiline = true;
            this.actVelocityLabel.Name = "actVelocityLabel";
            this.actVelocityLabel.ReadOnly = true;
            this.actVelocityLabel.Size = new System.Drawing.Size(126, 36);
            this.actVelocityLabel.TabIndex = 135;
            this.actVelocityLabel.Text = "17 km/h";
            this.actVelocityLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.setVelocityLabel, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(131, 94);
            this.tableLayoutPanel5.TabIndex = 135;
            // 
            // setVelocityLabel
            // 
            this.setVelocityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.setVelocityLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setVelocityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setVelocityLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setVelocityLabel.ForeColor = System.Drawing.Color.White;
            this.setVelocityLabel.Location = new System.Drawing.Point(3, 55);
            this.setVelocityLabel.Multiline = true;
            this.setVelocityLabel.Name = "setVelocityLabel";
            this.setVelocityLabel.ReadOnly = true;
            this.setVelocityLabel.Size = new System.Drawing.Size(125, 36);
            this.setVelocityLabel.TabIndex = 135;
            this.setVelocityLabel.Text = "24 km/h";
            this.setVelocityLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(287, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(624, 102);
            this.tableLayoutPanel8.TabIndex = 140;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.batConsLabel, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(418, 4);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(202, 94);
            this.tableLayoutPanel11.TabIndex = 139;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 52);
            this.label8.TabIndex = 131;
            this.label8.Text = "Consumption";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batConsLabel
            // 
            this.batConsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.batConsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.batConsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batConsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.batConsLabel.ForeColor = System.Drawing.Color.White;
            this.batConsLabel.Location = new System.Drawing.Point(3, 55);
            this.batConsLabel.Multiline = true;
            this.batConsLabel.Name = "batConsLabel";
            this.batConsLabel.ReadOnly = true;
            this.batConsLabel.Size = new System.Drawing.Size(196, 36);
            this.batConsLabel.TabIndex = 135;
            this.batConsLabel.Text = "639Wh";
            this.batConsLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.batCurLabel, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(211, 4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(200, 94);
            this.tableLayoutPanel10.TabIndex = 138;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 52);
            this.label7.TabIndex = 131;
            this.label7.Text = "Battery Current";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batCurLabel
            // 
            this.batCurLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.batCurLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.batCurLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batCurLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.batCurLabel.ForeColor = System.Drawing.Color.White;
            this.batCurLabel.Location = new System.Drawing.Point(3, 55);
            this.batCurLabel.Multiline = true;
            this.batCurLabel.Name = "batCurLabel";
            this.batCurLabel.ReadOnly = true;
            this.batCurLabel.Size = new System.Drawing.Size(194, 36);
            this.batCurLabel.TabIndex = 135;
            this.batCurLabel.Text = "5.00A";
            this.batCurLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.socLabel, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(200, 94);
            this.tableLayoutPanel9.TabIndex = 137;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 52);
            this.label6.TabIndex = 131;
            this.label6.Text = "State of Charge";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // socLabel
            // 
            this.socLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.socLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.socLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.socLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.socLabel.ForeColor = System.Drawing.Color.White;
            this.socLabel.Location = new System.Drawing.Point(3, 55);
            this.socLabel.Multiline = true;
            this.socLabel.Name = "socLabel";
            this.socLabel.ReadOnly = true;
            this.socLabel.Size = new System.Drawing.Size(194, 36);
            this.socLabel.TabIndex = 135;
            this.socLabel.Text = "%67.74";
            this.socLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel14, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(287, 111);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(624, 102);
            this.tableLayoutPanel12.TabIndex = 141;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.driveStatusLabel, 0, 1);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(315, 4);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(305, 94);
            this.tableLayoutPanel14.TabIndex = 138;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 52);
            this.label2.TabIndex = 131;
            this.label2.Text = "Set Mode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.errorsLabel, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(304, 94);
            this.tableLayoutPanel13.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 52);
            this.label1.TabIndex = 131;
            this.label1.Text = "Graph Scale (Last X)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.startTimeLabel, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(276, 100);
            this.tableLayoutPanel7.TabIndex = 139;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.startTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startTimeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startTimeLabel.ForeColor = System.Drawing.Color.White;
            this.startTimeLabel.Location = new System.Drawing.Point(3, 47);
            this.startTimeLabel.Multiline = true;
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.ReadOnly = true;
            this.startTimeLabel.Size = new System.Drawing.Size(270, 50);
            this.startTimeLabel.TabIndex = 136;
            this.startTimeLabel.Text = "NULL";
            this.startTimeLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 44);
            this.label5.TabIndex = 135;
            this.label5.Text = "Start Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 102);
            this.panel2.TabIndex = 143;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.11849F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.88151F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel12, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 92);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(914, 216);
            this.tableLayoutPanel3.TabIndex = 144;
            // 
            // logTimer
            // 
            this.logTimer.Interval = 50;
            this.logTimer.Tick += new System.EventHandler(this.logTimer_Tick);
            // 
            // mqttWorker
            // 
            this.mqttWorker.WorkerSupportsCancellation = true;
            this.mqttWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mqttWorker_DoWork);
            this.mqttWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.mqttWorker_ProgressChanged);
            this.mqttWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.mqttWorker_RunWorkerCompleted);
            // 
            // myChart
            // 
            this.myChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.myChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisX.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea5.AxisX.MajorGrid.LineWidth = 0;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea5.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisY.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea5.BorderColor = System.Drawing.Color.White;
            chartArea5.Name = "ChartArea1";
            this.myChart.ChartAreas.Add(chartArea5);
            this.myChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend5.ForeColor = System.Drawing.Color.White;
            legend5.HeaderSeparatorColor = System.Drawing.Color.White;
            legend5.IsTextAutoFit = false;
            legend5.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend5.Name = "Legend1";
            legend5.TitleForeColor = System.Drawing.Color.White;
            legend5.TitleSeparatorColor = System.Drawing.Color.White;
            this.myChart.Legends.Add(legend5);
            this.myChart.Location = new System.Drawing.Point(0, 308);
            this.myChart.Name = "myChart";
            this.myChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series9.LabelForeColor = System.Drawing.Color.White;
            series9.Legend = "Legend1";
            series9.Name = "Set Hız";
            series9.Points.Add(dataPoint25);
            series9.Points.Add(dataPoint26);
            series9.Points.Add(dataPoint27);
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Act Hız";
            series10.Points.Add(dataPoint28);
            series10.Points.Add(dataPoint29);
            series10.Points.Add(dataPoint30);
            this.myChart.Series.Add(series9);
            this.myChart.Series.Add(series10);
            this.myChart.Size = new System.Drawing.Size(914, 313);
            this.myChart.TabIndex = 145;
            this.myChart.Text = "chart1";
            // 
            // driveStatusLabel
            // 
            this.driveStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.driveStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driveStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveStatusLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driveStatusLabel.ForeColor = System.Drawing.Color.White;
            this.driveStatusLabel.Location = new System.Drawing.Point(3, 55);
            this.driveStatusLabel.Multiline = true;
            this.driveStatusLabel.Name = "driveStatusLabel";
            this.driveStatusLabel.ReadOnly = true;
            this.driveStatusLabel.Size = new System.Drawing.Size(299, 36);
            this.driveStatusLabel.TabIndex = 135;
            this.driveStatusLabel.Text = "IGNITION ON";
            this.driveStatusLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorsLabel
            // 
            this.errorsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.errorsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.errorsLabel.ForeColor = System.Drawing.Color.White;
            this.errorsLabel.Location = new System.Drawing.Point(3, 55);
            this.errorsLabel.Multiline = true;
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(298, 36);
            this.errorsLabel.TabIndex = 135;
            this.errorsLabel.Text = "50";
            this.errorsLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(914, 621);
            this.Controls.Add(this.myChart);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton finishBtn;
        private FontAwesome.Sharp.IconButton startBtn;
        private FontAwesome.Sharp.IconButton portConnectBtn;
        private FontAwesome.Sharp.IconButton portDisconnectBtn;
        private FontAwesome.Sharp.IconButton mqttDisconnectBtn;
        private FontAwesome.Sharp.IconButton mqttConnectBtn;
        private FontAwesome.Sharp.IconButton openGUILogBtn;
        private FontAwesome.Sharp.IconButton openSDLogBtn;
        private FontAwesome.Sharp.IconButton stopLogBtn;
        private FontAwesome.Sharp.IconButton startLogBtn;
        private System.Windows.Forms.ListBox portsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox setVelocityLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox actVelocityLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox startTimeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox batConsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox batCurLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox socLabel;
        public System.Windows.Forms.Timer logTimer;
        private System.ComponentModel.BackgroundWorker mqttWorker;
        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.TextBox driveStatusLabel;
        private System.Windows.Forms.TextBox errorsLabel;
    }
}