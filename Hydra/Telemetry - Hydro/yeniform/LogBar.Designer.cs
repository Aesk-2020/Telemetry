namespace telemetry_hydro
{
    partial class LogBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogBar));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.logPlayerStick = new XComponent.SliderBar.MACTrackBar();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.logResetBtn = new System.Windows.Forms.Button();
            this.log10secForwBtn = new System.Windows.Forms.Button();
            this.logSpeedUpBtn = new System.Windows.Forms.Button();
            this.logPlayBtn = new System.Windows.Forms.Button();
            this.logSpeedDownBtn = new System.Windows.Forms.Button();
            this.log10secRewBtn = new System.Windows.Forms.Button();
            this.pauseResume = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.logPlayerStick, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.3617F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.6383F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(616, 110);
            this.tableLayoutPanel2.TabIndex = 145;
            // 
            // logPlayerStick
            // 
            this.logPlayerStick.BackColor = System.Drawing.Color.Transparent;
            this.logPlayerStick.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.logPlayerStick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPlayerStick.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logPlayerStick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.logPlayerStick.IndentHeight = 6;
            this.logPlayerStick.Location = new System.Drawing.Point(4, 4);
            this.logPlayerStick.Maximum = 205;
            this.logPlayerStick.Minimum = 0;
            this.logPlayerStick.Name = "logPlayerStick";
            this.logPlayerStick.Size = new System.Drawing.Size(608, 28);
            this.logPlayerStick.TabIndex = 145;
            this.logPlayerStick.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.logPlayerStick.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.logPlayerStick.TickHeight = 4;
            this.logPlayerStick.TickStyle = System.Windows.Forms.TickStyle.None;
            this.logPlayerStick.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.logPlayerStick.TrackerSize = new System.Drawing.Size(16, 16);
            this.logPlayerStick.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.logPlayerStick.TrackLineHeight = 3;
            this.logPlayerStick.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.logPlayerStick.Value = 0;
            this.logPlayerStick.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.logPlayerStick_ValueChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12904F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tableLayoutPanel5.Controls.Add(this.logResetBtn, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.log10secForwBtn, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.logSpeedUpBtn, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.logPlayBtn, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.logSpeedDownBtn, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.log10secRewBtn, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 47);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(608, 59);
            this.tableLayoutPanel5.TabIndex = 146;
            // 
            // logResetBtn
            // 
            this.logResetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logResetBtn.FlatAppearance.BorderSize = 0;
            this.logResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logResetBtn.Image = ((System.Drawing.Image)(resources.GetObject("logResetBtn.Image")));
            this.logResetBtn.Location = new System.Drawing.Point(512, 3);
            this.logResetBtn.Name = "logResetBtn";
            this.logResetBtn.Size = new System.Drawing.Size(93, 53);
            this.logResetBtn.TabIndex = 5;
            this.logResetBtn.UseVisualStyleBackColor = true;
            // 
            // log10secForwBtn
            // 
            this.log10secForwBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log10secForwBtn.FlatAppearance.BorderSize = 0;
            this.log10secForwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log10secForwBtn.Image = ((System.Drawing.Image)(resources.GetObject("log10secForwBtn.Image")));
            this.log10secForwBtn.Location = new System.Drawing.Point(414, 3);
            this.log10secForwBtn.Name = "log10secForwBtn";
            this.log10secForwBtn.Size = new System.Drawing.Size(92, 53);
            this.log10secForwBtn.TabIndex = 4;
            this.log10secForwBtn.UseVisualStyleBackColor = true;
            this.log10secForwBtn.Click += new System.EventHandler(this.log10secForwBtn_Click);
            // 
            // logSpeedUpBtn
            // 
            this.logSpeedUpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logSpeedUpBtn.FlatAppearance.BorderSize = 0;
            this.logSpeedUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logSpeedUpBtn.Image = ((System.Drawing.Image)(resources.GetObject("logSpeedUpBtn.Image")));
            this.logSpeedUpBtn.Location = new System.Drawing.Point(316, 3);
            this.logSpeedUpBtn.Name = "logSpeedUpBtn";
            this.logSpeedUpBtn.Size = new System.Drawing.Size(92, 53);
            this.logSpeedUpBtn.TabIndex = 3;
            this.logSpeedUpBtn.UseVisualStyleBackColor = true;
            this.logSpeedUpBtn.Click += new System.EventHandler(this.logSpeedUpBtn_Click);
            // 
            // logPlayBtn
            // 
            this.logPlayBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPlayBtn.FlatAppearance.BorderSize = 0;
            this.logPlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logPlayBtn.Image = ((System.Drawing.Image)(resources.GetObject("logPlayBtn.Image")));
            this.logPlayBtn.Location = new System.Drawing.Point(199, 3);
            this.logPlayBtn.Name = "logPlayBtn";
            this.logPlayBtn.Size = new System.Drawing.Size(111, 53);
            this.logPlayBtn.TabIndex = 2;
            this.logPlayBtn.UseVisualStyleBackColor = true;
            this.logPlayBtn.Click += new System.EventHandler(this.logPlayBtn_Click);
            // 
            // logSpeedDownBtn
            // 
            this.logSpeedDownBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logSpeedDownBtn.FlatAppearance.BorderSize = 0;
            this.logSpeedDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logSpeedDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("logSpeedDownBtn.Image")));
            this.logSpeedDownBtn.Location = new System.Drawing.Point(101, 3);
            this.logSpeedDownBtn.Name = "logSpeedDownBtn";
            this.logSpeedDownBtn.Size = new System.Drawing.Size(92, 53);
            this.logSpeedDownBtn.TabIndex = 1;
            this.logSpeedDownBtn.UseVisualStyleBackColor = true;
            this.logSpeedDownBtn.Click += new System.EventHandler(this.logSpeedDownBtn_Click);
            // 
            // log10secRewBtn
            // 
            this.log10secRewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log10secRewBtn.FlatAppearance.BorderSize = 0;
            this.log10secRewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log10secRewBtn.Image = ((System.Drawing.Image)(resources.GetObject("log10secRewBtn.Image")));
            this.log10secRewBtn.Location = new System.Drawing.Point(3, 3);
            this.log10secRewBtn.Name = "log10secRewBtn";
            this.log10secRewBtn.Size = new System.Drawing.Size(92, 53);
            this.log10secRewBtn.TabIndex = 0;
            this.log10secRewBtn.UseVisualStyleBackColor = true;
            this.log10secRewBtn.Click += new System.EventHandler(this.log10secRewBtn_Click);
            // 
            // pauseResume
            // 
            this.pauseResume.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pauseResume.ImageStream")));
            this.pauseResume.TransparentColor = System.Drawing.Color.Transparent;
            this.pauseResume.Images.SetKeyName(0, "icons8_pause_button_50px.png");
            this.pauseResume.Images.SetKeyName(1, "icons8_play_button_circled_50px_1.png");
            // 
            // LogBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(616, 110);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LogBar";
            this.ShowIcon = false;
            this.Text = "LogBar";
            this.Load += new System.EventHandler(this.LogBar_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public XComponent.SliderBar.MACTrackBar logPlayerStick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button logResetBtn;
        private System.Windows.Forms.Button log10secForwBtn;
        private System.Windows.Forms.Button logSpeedUpBtn;
        private System.Windows.Forms.Button logPlayBtn;
        private System.Windows.Forms.Button logSpeedDownBtn;
        private System.Windows.Forms.Button log10secRewBtn;
        private System.Windows.Forms.ImageList pauseResume;
    }
}