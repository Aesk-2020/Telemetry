namespace Telemetri.NewForms
{
    partial class Telemetry2021
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telemetry2021));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.logplyrButton = new FontAwesome.Sharp.IconButton();
            this.mqttButton = new FontAwesome.Sharp.IconButton();
            this.settingsButton = new System.Windows.Forms.Button();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.motordrButton = new FontAwesome.Sharp.IconButton();
            this.batteryButton = new FontAwesome.Sharp.IconButton();
            this.mapButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.activeChannelLabel = new System.Windows.Forms.TextBox();
            this.mqttPingLabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lapMinusBtn = new FontAwesome.Sharp.IconButton();
            this.lapPlusBtn = new FontAwesome.Sharp.IconButton();
            this.lapCntLabel = new System.Windows.Forms.Label();
            this.LapResetBtn = new FontAwesome.Sharp.IconButton();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.logplyrButton);
            this.panelSideMenu.Controls.Add(this.mqttButton);
            this.panelSideMenu.Controls.Add(this.settingsButton);
            this.panelSideMenu.Controls.Add(this.exitBtn);
            this.panelSideMenu.Controls.Add(this.motordrButton);
            this.panelSideMenu.Controls.Add(this.batteryButton);
            this.panelSideMenu.Controls.Add(this.mapButton);
            this.panelSideMenu.Controls.Add(this.homeButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 761);
            this.panelSideMenu.TabIndex = 1;
            // 
            // logplyrButton
            // 
            this.logplyrButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.logplyrButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logplyrButton.FlatAppearance.BorderSize = 0;
            this.logplyrButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.logplyrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logplyrButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logplyrButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.logplyrButton.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.logplyrButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.logplyrButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logplyrButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logplyrButton.Location = new System.Drawing.Point(0, 382);
            this.logplyrButton.Name = "logplyrButton";
            this.logplyrButton.Size = new System.Drawing.Size(250, 48);
            this.logplyrButton.TabIndex = 8;
            this.logplyrButton.Text = "Log Player";
            this.logplyrButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logplyrButton.UseVisualStyleBackColor = false;
            this.logplyrButton.Click += new System.EventHandler(this.logplyrButton_Click);
            // 
            // mqttButton
            // 
            this.mqttButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.mqttButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mqttButton.FlatAppearance.BorderSize = 0;
            this.mqttButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.mqttButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mqttButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mqttButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.mqttButton.IconChar = FontAwesome.Sharp.IconChar.Satellite;
            this.mqttButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.mqttButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mqttButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mqttButton.Location = new System.Drawing.Point(0, 334);
            this.mqttButton.Name = "mqttButton";
            this.mqttButton.Size = new System.Drawing.Size(250, 48);
            this.mqttButton.TabIndex = 7;
            this.mqttButton.Text = "MQTT";
            this.mqttButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mqttButton.UseVisualStyleBackColor = false;
            this.mqttButton.Click += new System.EventHandler(this.mqttButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 284);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(250, 50);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = " Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.exitBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(0, 713);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(250, 48);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // motordrButton
            // 
            this.motordrButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.motordrButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.motordrButton.FlatAppearance.BorderSize = 0;
            this.motordrButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.motordrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motordrButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motordrButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.motordrButton.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            this.motordrButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.motordrButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.motordrButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motordrButton.Location = new System.Drawing.Point(0, 236);
            this.motordrButton.Name = "motordrButton";
            this.motordrButton.Size = new System.Drawing.Size(250, 48);
            this.motordrButton.TabIndex = 4;
            this.motordrButton.Text = "Motor Driver";
            this.motordrButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.motordrButton.UseVisualStyleBackColor = false;
            this.motordrButton.Click += new System.EventHandler(this.btnMotorDriver_Click);
            // 
            // batteryButton
            // 
            this.batteryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.batteryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.batteryButton.FlatAppearance.BorderSize = 0;
            this.batteryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.batteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batteryButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.batteryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.batteryButton.IconChar = FontAwesome.Sharp.IconChar.CarBattery;
            this.batteryButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.batteryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.batteryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.batteryButton.Location = new System.Drawing.Point(0, 188);
            this.batteryButton.Name = "batteryButton";
            this.batteryButton.Size = new System.Drawing.Size(250, 48);
            this.batteryButton.TabIndex = 3;
            this.batteryButton.Text = "Battery";
            this.batteryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.batteryButton.UseVisualStyleBackColor = false;
            this.batteryButton.Click += new System.EventHandler(this.btnBattery_Click);
            // 
            // mapButton
            // 
            this.mapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.mapButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mapButton.FlatAppearance.BorderSize = 0;
            this.mapButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.mapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mapButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.mapButton.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.mapButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.mapButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mapButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mapButton.Location = new System.Drawing.Point(0, 140);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(250, 48);
            this.mapButton.TabIndex = 2;
            this.mapButton.Text = "Map";
            this.mapButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mapButton.UseVisualStyleBackColor = false;
            this.mapButton.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 92);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(250, 48);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.tableLayoutPanel1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(934, 761);
            this.panelChildForm.TabIndex = 3;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1242F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.8758F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 661);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 100);
            this.tableLayoutPanel1.TabIndex = 144;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.activeChannelLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.mqttPingLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(247, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(684, 94);
            this.tableLayoutPanel2.TabIndex = 145;
            // 
            // activeChannelLabel
            // 
            this.activeChannelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.activeChannelLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activeChannelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeChannelLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.activeChannelLabel.ForeColor = System.Drawing.Color.White;
            this.activeChannelLabel.Location = new System.Drawing.Point(4, 50);
            this.activeChannelLabel.Multiline = true;
            this.activeChannelLabel.Name = "activeChannelLabel";
            this.activeChannelLabel.Size = new System.Drawing.Size(334, 40);
            this.activeChannelLabel.TabIndex = 149;
            this.activeChannelLabel.Text = "RF";
            this.activeChannelLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mqttPingLabel
            // 
            this.mqttPingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mqttPingLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mqttPingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mqttPingLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mqttPingLabel.ForeColor = System.Drawing.Color.White;
            this.mqttPingLabel.Location = new System.Drawing.Point(345, 50);
            this.mqttPingLabel.Multiline = true;
            this.mqttPingLabel.Name = "mqttPingLabel";
            this.mqttPingLabel.Size = new System.Drawing.Size(335, 40);
            this.mqttPingLabel.TabIndex = 148;
            this.mqttPingLabel.Text = "97";
            this.mqttPingLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(345, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 45);
            this.label4.TabIndex = 146;
            this.label4.Text = "MQTT Ping";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 45);
            this.label3.TabIndex = 127;
            this.label3.Text = "Active Channel";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.42424F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.57576F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(238, 94);
            this.tableLayoutPanel15.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 126;
            this.label1.Text = "Lap Counter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.43234F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.79208F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.44224F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0033F));
            this.tableLayoutPanel3.Controls.Add(this.lapMinusBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lapPlusBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lapCntLabel, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.LapResetBtn, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(230, 47);
            this.tableLayoutPanel3.TabIndex = 132;
            // 
            // lapMinusBtn
            // 
            this.lapMinusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lapMinusBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lapMinusBtn.BackgroundImage")));
            this.lapMinusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lapMinusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lapMinusBtn.FlatAppearance.BorderSize = 0;
            this.lapMinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lapMinusBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lapMinusBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.lapMinusBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.lapMinusBtn.IconColor = System.Drawing.Color.Black;
            this.lapMinusBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lapMinusBtn.Location = new System.Drawing.Point(57, 3);
            this.lapMinusBtn.Name = "lapMinusBtn";
            this.lapMinusBtn.Size = new System.Drawing.Size(41, 41);
            this.lapMinusBtn.TabIndex = 128;
            this.lapMinusBtn.UseVisualStyleBackColor = false;
            this.lapMinusBtn.Click += new System.EventHandler(this.lapMinusBtn_Click);
            // 
            // lapPlusBtn
            // 
            this.lapPlusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lapPlusBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lapPlusBtn.BackgroundImage")));
            this.lapPlusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lapPlusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lapPlusBtn.FlatAppearance.BorderSize = 0;
            this.lapPlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lapPlusBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lapPlusBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.lapPlusBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.lapPlusBtn.IconColor = System.Drawing.Color.Black;
            this.lapPlusBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lapPlusBtn.Location = new System.Drawing.Point(3, 3);
            this.lapPlusBtn.Name = "lapPlusBtn";
            this.lapPlusBtn.Size = new System.Drawing.Size(48, 41);
            this.lapPlusBtn.TabIndex = 127;
            this.lapPlusBtn.UseVisualStyleBackColor = false;
            this.lapPlusBtn.Click += new System.EventHandler(this.lapPlusBtn_Click);
            // 
            // lapCntLabel
            // 
            this.lapCntLabel.AutoSize = true;
            this.lapCntLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lapCntLabel.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapCntLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.lapCntLabel.Location = new System.Drawing.Point(155, 0);
            this.lapCntLabel.Name = "lapCntLabel";
            this.lapCntLabel.Size = new System.Drawing.Size(72, 47);
            this.lapCntLabel.TabIndex = 130;
            this.lapCntLabel.Text = "0";
            this.lapCntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LapResetBtn
            // 
            this.LapResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.LapResetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LapResetBtn.BackgroundImage")));
            this.LapResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LapResetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LapResetBtn.FlatAppearance.BorderSize = 0;
            this.LapResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LapResetBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LapResetBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.LapResetBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.LapResetBtn.IconColor = System.Drawing.Color.Black;
            this.LapResetBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LapResetBtn.Location = new System.Drawing.Point(104, 3);
            this.LapResetBtn.Name = "LapResetBtn";
            this.LapResetBtn.Size = new System.Drawing.Size(45, 41);
            this.LapResetBtn.TabIndex = 129;
            this.LapResetBtn.UseVisualStyleBackColor = false;
            this.LapResetBtn.Click += new System.EventHandler(this.LapResetBtn_Click);
            // 
            // Telemetry2021
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Telemetry2021";
            this.Text = "AESK Telemetry 2021";
            this.Load += new System.EventHandler(this.Telemetry2021_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton exitBtn;
        private FontAwesome.Sharp.IconButton motordrButton;
        private FontAwesome.Sharp.IconButton batteryButton;
        private FontAwesome.Sharp.IconButton mapButton;
        private FontAwesome.Sharp.IconButton homeButton;
        private System.Windows.Forms.Button settingsButton;
        private FontAwesome.Sharp.IconButton mqttButton;
        private FontAwesome.Sharp.IconButton logplyrButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton lapMinusBtn;
        private FontAwesome.Sharp.IconButton lapPlusBtn;
        private System.Windows.Forms.Label lapCntLabel;
        private FontAwesome.Sharp.IconButton LapResetBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox activeChannelLabel;
        private System.Windows.Forms.TextBox mqttPingLabel;
    }
}