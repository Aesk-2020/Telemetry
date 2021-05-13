namespace Telemetri.NewForms
{
    partial class PIDTuningForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.kpBox = new System.Windows.Forms.TextBox();
            this.kiBox = new System.Windows.Forms.TextBox();
            this.kdBox = new System.Windows.Forms.TextBox();
            this.macTrackBar1 = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.macTrackBar2 = new XComponent.SliderBar.MACTrackBar();
            this.macTrackBar3 = new XComponent.SliderBar.MACTrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sendButton = new FontAwesome.Sharp.IconButton();
            this.queryButton = new FontAwesome.Sharp.IconButton();
            this.logBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kp";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kpBox
            // 
            this.kpBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.kpBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpBox.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kpBox.ForeColor = System.Drawing.Color.White;
            this.kpBox.Location = new System.Drawing.Point(128, 4);
            this.kpBox.Multiline = true;
            this.kpBox.Name = "kpBox";
            this.kpBox.Size = new System.Drawing.Size(118, 49);
            this.kpBox.TabIndex = 6;
            this.kpBox.Text = "1,27";
            this.kpBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kiBox
            // 
            this.kiBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.kiBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kiBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiBox.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiBox.ForeColor = System.Drawing.Color.White;
            this.kiBox.Location = new System.Drawing.Point(128, 60);
            this.kiBox.Multiline = true;
            this.kiBox.Name = "kiBox";
            this.kiBox.Size = new System.Drawing.Size(118, 49);
            this.kiBox.TabIndex = 14;
            this.kiBox.Text = "1,27";
            this.kiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kdBox
            // 
            this.kdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.kdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdBox.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdBox.ForeColor = System.Drawing.Color.White;
            this.kdBox.Location = new System.Drawing.Point(128, 116);
            this.kdBox.Multiline = true;
            this.kdBox.Name = "kdBox";
            this.kdBox.Size = new System.Drawing.Size(118, 50);
            this.kdBox.TabIndex = 15;
            this.kdBox.Text = "1,27";
            this.kdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // macTrackBar1
            // 
            this.macTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.macTrackBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.macTrackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.macTrackBar1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar1.IndentHeight = 6;
            this.macTrackBar1.Location = new System.Drawing.Point(253, 4);
            this.macTrackBar1.Maximum = 500;
            this.macTrackBar1.Minimum = 0;
            this.macTrackBar1.Name = "macTrackBar1";
            this.macTrackBar1.Size = new System.Drawing.Size(450, 48);
            this.macTrackBar1.TabIndex = 16;
            this.macTrackBar1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackBar1.TickFrequency = 50;
            this.macTrackBar1.TickHeight = 5;
            this.macTrackBar1.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.macTrackBar1.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBar1.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1.TrackLineHeight = 3;
            this.macTrackBar1.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1.Value = 0;
            this.macTrackBar1.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 55);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ki";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 56);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kd";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // macTrackBar2
            // 
            this.macTrackBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.macTrackBar2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.macTrackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.macTrackBar2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar2.IndentHeight = 6;
            this.macTrackBar2.Location = new System.Drawing.Point(253, 60);
            this.macTrackBar2.Maximum = 500;
            this.macTrackBar2.Minimum = 0;
            this.macTrackBar2.Name = "macTrackBar2";
            this.macTrackBar2.Size = new System.Drawing.Size(450, 48);
            this.macTrackBar2.TabIndex = 19;
            this.macTrackBar2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackBar2.TickFrequency = 50;
            this.macTrackBar2.TickHeight = 5;
            this.macTrackBar2.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.macTrackBar2.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBar2.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar2.TrackLineHeight = 3;
            this.macTrackBar2.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar2.Value = 0;
            this.macTrackBar2.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar2_ValueChanged);
            // 
            // macTrackBar3
            // 
            this.macTrackBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.macTrackBar3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.macTrackBar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.macTrackBar3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar3.IndentHeight = 6;
            this.macTrackBar3.Location = new System.Drawing.Point(253, 116);
            this.macTrackBar3.Maximum = 500;
            this.macTrackBar3.Minimum = 0;
            this.macTrackBar3.Name = "macTrackBar3";
            this.macTrackBar3.Size = new System.Drawing.Size(450, 48);
            this.macTrackBar3.TabIndex = 20;
            this.macTrackBar3.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackBar3.TickFrequency = 50;
            this.macTrackBar3.TickHeight = 5;
            this.macTrackBar3.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.macTrackBar3.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBar3.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar3.TrackLineHeight = 3;
            this.macTrackBar3.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar3.Value = 0;
            this.macTrackBar3.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar3_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.56374F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.70538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.73088F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.macTrackBar3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.kpBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.macTrackBar2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.macTrackBar1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.kiBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.kdBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(113, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(707, 170);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.sendButton.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.sendButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.sendButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendButton.Location = new System.Drawing.Point(113, 249);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(358, 63);
            this.sendButton.TabIndex = 22;
            this.sendButton.Text = "SEND";
            this.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // queryButton
            // 
            this.queryButton.Enabled = false;
            this.queryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queryButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.queryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.queryButton.IconChar = FontAwesome.Sharp.IconChar.Quora;
            this.queryButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(202)))));
            this.queryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.queryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.queryButton.Location = new System.Drawing.Point(477, 249);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(343, 63);
            this.queryButton.TabIndex = 23;
            this.queryButton.Text = "QUERY";
            this.queryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // logBox
            // 
            this.logBox.AcceptsReturn = true;
            this.logBox.AcceptsTab = true;
            this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.logBox.ForeColor = System.Drawing.Color.White;
            this.logBox.Location = new System.Drawing.Point(113, 318);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(707, 173);
            this.logBox.TabIndex = 24;
            this.logBox.Text = "App started\r\n";
            // 
            // PIDTuningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(924, 616);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PIDTuningForm";
            this.Text = "PIDTuningForm";
            this.Load += new System.EventHandler(this.PIDTuningForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kpBox;
        private System.Windows.Forms.TextBox kiBox;
        private System.Windows.Forms.TextBox kdBox;
        private XComponent.SliderBar.MACTrackBar macTrackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private XComponent.SliderBar.MACTrackBar macTrackBar2;
        private XComponent.SliderBar.MACTrackBar macTrackBar3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton sendButton;
        private FontAwesome.Sharp.IconButton queryButton;
        private System.Windows.Forms.TextBox logBox;
    }
}