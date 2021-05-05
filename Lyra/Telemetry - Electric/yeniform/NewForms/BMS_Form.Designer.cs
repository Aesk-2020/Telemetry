namespace Telemetri.NewForms
{
    partial class BMS_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMS_Form));
            this.socImages = new System.Windows.Forms.ImageList(this.components);
            this.graphicsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.batConsGraphBtn = new System.Windows.Forms.Button();
            this.batTempGraphBtn = new System.Windows.Forms.Button();
            this.batCurGraphBtn = new System.Windows.Forms.Button();
            this.batVoltGraphBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.consLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.voltageLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.driveStatusLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.errorsLabel = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // socImages
            // 
            this.socImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("socImages.ImageStream")));
            this.socImages.TransparentColor = System.Drawing.Color.Transparent;
            this.socImages.Images.SetKeyName(0, "asdasdasd.png");
            this.socImages.Images.SetKeyName(1, "Başlıksız-1.png");
            this.socImages.Images.SetKeyName(2, "Başlıksız-2.png");
            this.socImages.Images.SetKeyName(3, "sdmjbhfgasdhjf.png");
            // 
            // graphicsButton
            // 
            this.graphicsButton.AutoSize = true;
            this.graphicsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.graphicsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.graphicsButton.FlatAppearance.BorderSize = 0;
            this.graphicsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.graphicsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphicsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.graphicsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.graphicsButton.Location = new System.Drawing.Point(0, 0);
            this.graphicsButton.Name = "graphicsButton";
            this.graphicsButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.graphicsButton.Size = new System.Drawing.Size(914, 50);
            this.graphicsButton.TabIndex = 12;
            this.graphicsButton.Text = "Graphics";
            this.graphicsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.graphicsButton.UseVisualStyleBackColor = false;
            this.graphicsButton.Click += new System.EventHandler(this.graphicsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.batConsGraphBtn);
            this.panel1.Controls.Add(this.batTempGraphBtn);
            this.panel1.Controls.Add(this.batCurGraphBtn);
            this.panel1.Controls.Add(this.batVoltGraphBtn);
            this.panel1.Controls.Add(this.graphicsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 243);
            this.panel1.TabIndex = 13;
            // 
            // batConsGraphBtn
            // 
            this.batConsGraphBtn.AutoSize = true;
            this.batConsGraphBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.batConsGraphBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.batConsGraphBtn.FlatAppearance.BorderSize = 0;
            this.batConsGraphBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.batConsGraphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batConsGraphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.batConsGraphBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.batConsGraphBtn.Location = new System.Drawing.Point(0, 200);
            this.batConsGraphBtn.Name = "batConsGraphBtn";
            this.batConsGraphBtn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.batConsGraphBtn.Size = new System.Drawing.Size(914, 50);
            this.batConsGraphBtn.TabIndex = 16;
            this.batConsGraphBtn.Text = "Consumption";
            this.batConsGraphBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.batConsGraphBtn.UseVisualStyleBackColor = false;
            this.batConsGraphBtn.Visible = false;
            this.batConsGraphBtn.Click += new System.EventHandler(this.batConsGraphBtn_Click);
            // 
            // batTempGraphBtn
            // 
            this.batTempGraphBtn.AutoSize = true;
            this.batTempGraphBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.batTempGraphBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.batTempGraphBtn.FlatAppearance.BorderSize = 0;
            this.batTempGraphBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.batTempGraphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batTempGraphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.batTempGraphBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.batTempGraphBtn.Location = new System.Drawing.Point(0, 150);
            this.batTempGraphBtn.Name = "batTempGraphBtn";
            this.batTempGraphBtn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.batTempGraphBtn.Size = new System.Drawing.Size(914, 50);
            this.batTempGraphBtn.TabIndex = 15;
            this.batTempGraphBtn.Text = "Battery Temperature";
            this.batTempGraphBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.batTempGraphBtn.UseVisualStyleBackColor = false;
            this.batTempGraphBtn.Visible = false;
            this.batTempGraphBtn.Click += new System.EventHandler(this.batTempGraphBtn_Click);
            // 
            // batCurGraphBtn
            // 
            this.batCurGraphBtn.AutoSize = true;
            this.batCurGraphBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.batCurGraphBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.batCurGraphBtn.FlatAppearance.BorderSize = 0;
            this.batCurGraphBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.batCurGraphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batCurGraphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.batCurGraphBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.batCurGraphBtn.Location = new System.Drawing.Point(0, 100);
            this.batCurGraphBtn.Name = "batCurGraphBtn";
            this.batCurGraphBtn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.batCurGraphBtn.Size = new System.Drawing.Size(914, 50);
            this.batCurGraphBtn.TabIndex = 14;
            this.batCurGraphBtn.Text = "Battery Current";
            this.batCurGraphBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.batCurGraphBtn.UseVisualStyleBackColor = false;
            this.batCurGraphBtn.Visible = false;
            this.batCurGraphBtn.Click += new System.EventHandler(this.batCurGraphBtn_Click);
            // 
            // batVoltGraphBtn
            // 
            this.batVoltGraphBtn.AutoSize = true;
            this.batVoltGraphBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.batVoltGraphBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.batVoltGraphBtn.FlatAppearance.BorderSize = 0;
            this.batVoltGraphBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.batVoltGraphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batVoltGraphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.batVoltGraphBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.batVoltGraphBtn.Location = new System.Drawing.Point(0, 50);
            this.batVoltGraphBtn.Name = "batVoltGraphBtn";
            this.batVoltGraphBtn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.batVoltGraphBtn.Size = new System.Drawing.Size(914, 50);
            this.batVoltGraphBtn.TabIndex = 13;
            this.batVoltGraphBtn.Text = "Battery Voltage";
            this.batVoltGraphBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.batVoltGraphBtn.UseVisualStyleBackColor = false;
            this.batVoltGraphBtn.Visible = false;
            this.batVoltGraphBtn.Click += new System.EventHandler(this.batVoltGraphBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(914, 216);
            this.tableLayoutPanel3.TabIndex = 145;
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
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(908, 102);
            this.tableLayoutPanel8.TabIndex = 140;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.tempLabel, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(608, 4);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(296, 94);
            this.tableLayoutPanel11.TabIndex = 139;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 52);
            this.label12.TabIndex = 131;
            this.label12.Text = "Temp(°C)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tempLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(3, 55);
            this.tempLabel.Multiline = true;
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.ReadOnly = true;
            this.tempLabel.Size = new System.Drawing.Size(290, 36);
            this.tempLabel.TabIndex = 135;
            this.tempLabel.Text = "25°C";
            this.tempLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.consLabel, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(306, 4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(295, 94);
            this.tableLayoutPanel10.TabIndex = 138;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(289, 52);
            this.label13.TabIndex = 131;
            this.label13.Text = "Consumption";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consLabel
            // 
            this.consLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.consLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.consLabel.ForeColor = System.Drawing.Color.White;
            this.consLabel.Location = new System.Drawing.Point(3, 55);
            this.consLabel.Multiline = true;
            this.consLabel.Name = "consLabel";
            this.consLabel.ReadOnly = true;
            this.consLabel.Size = new System.Drawing.Size(289, 36);
            this.consLabel.TabIndex = 135;
            this.consLabel.Text = "250Wh";
            this.consLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.voltageLabel, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(295, 94);
            this.tableLayoutPanel9.TabIndex = 137;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(289, 52);
            this.label14.TabIndex = 131;
            this.label14.Text = "Voltage";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // voltageLabel
            // 
            this.voltageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.voltageLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.voltageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voltageLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.voltageLabel.ForeColor = System.Drawing.Color.White;
            this.voltageLabel.Location = new System.Drawing.Point(3, 55);
            this.voltageLabel.Multiline = true;
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.ReadOnly = true;
            this.voltageLabel.Size = new System.Drawing.Size(289, 36);
            this.voltageLabel.TabIndex = 135;
            this.voltageLabel.Text = "107.6V";
            this.voltageLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 111);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(908, 102);
            this.tableLayoutPanel12.TabIndex = 141;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.driveStatusLabel, 0, 1);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(457, 4);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(447, 94);
            this.tableLayoutPanel14.TabIndex = 138;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(441, 52);
            this.label15.TabIndex = 131;
            this.label15.Text = "SoC";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driveStatusLabel
            // 
            this.driveStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.driveStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driveStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveStatusLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.driveStatusLabel.ForeColor = System.Drawing.Color.White;
            this.driveStatusLabel.Location = new System.Drawing.Point(3, 55);
            this.driveStatusLabel.Multiline = true;
            this.driveStatusLabel.Name = "driveStatusLabel";
            this.driveStatusLabel.ReadOnly = true;
            this.driveStatusLabel.Size = new System.Drawing.Size(441, 36);
            this.driveStatusLabel.TabIndex = 135;
            this.driveStatusLabel.Text = "%75";
            this.driveStatusLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.errorsLabel, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(446, 94);
            this.tableLayoutPanel13.TabIndex = 137;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(440, 52);
            this.label16.TabIndex = 131;
            this.label16.Text = "Current";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorsLabel
            // 
            this.errorsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.errorsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorsLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.errorsLabel.ForeColor = System.Drawing.Color.White;
            this.errorsLabel.Location = new System.Drawing.Point(3, 55);
            this.errorsLabel.Multiline = true;
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.ReadOnly = true;
            this.errorsLabel.Size = new System.Drawing.Size(440, 36);
            this.errorsLabel.TabIndex = 135;
            this.errorsLabel.Text = "20A";
            this.errorsLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(914, 621);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.Name = "BMS_Form";
            this.Text = "BMS";
            this.Load += new System.EventHandler(this.BMS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList socImages;
        private System.Windows.Forms.Button graphicsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button batConsGraphBtn;
        private System.Windows.Forms.Button batTempGraphBtn;
        private System.Windows.Forms.Button batCurGraphBtn;
        private System.Windows.Forms.Button batVoltGraphBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tempLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox consLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox voltageLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox driveStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox errorsLabel;
    }
}