namespace Telemetri.NewForms
{
    partial class Graphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphics));
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.popupBtn = new System.Windows.Forms.Button();
            this.clsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            this.SuspendLayout();
            // 
            // myChart
            // 
            this.myChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.myChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisX.MajorGrid.LineWidth = 0;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            chartArea4.BorderColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.myChart.ChartAreas.Add(chartArea4);
            this.myChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            legend4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend4.ForeColor = System.Drawing.Color.White;
            legend4.HeaderSeparatorColor = System.Drawing.Color.White;
            legend4.IsTextAutoFit = false;
            legend4.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend4.Name = "Legend1";
            legend4.TitleForeColor = System.Drawing.Color.White;
            legend4.TitleSeparatorColor = System.Drawing.Color.White;
            this.myChart.Legends.Add(legend4);
            this.myChart.Location = new System.Drawing.Point(0, 0);
            this.myChart.Name = "myChart";
            this.myChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Current";
            series4.Points.Add(dataPoint10);
            series4.Points.Add(dataPoint11);
            series4.Points.Add(dataPoint12);
            this.myChart.Series.Add(series4);
            this.myChart.Size = new System.Drawing.Size(837, 450);
            this.myChart.TabIndex = 12;
            this.myChart.Text = "chart1";
            // 
            // popupBtn
            // 
            this.popupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.popupBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("popupBtn.BackgroundImage")));
            this.popupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.popupBtn.FlatAppearance.BorderSize = 0;
            this.popupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popupBtn.Location = new System.Drawing.Point(710, 394);
            this.popupBtn.Name = "popupBtn";
            this.popupBtn.Size = new System.Drawing.Size(58, 34);
            this.popupBtn.TabIndex = 14;
            this.popupBtn.UseVisualStyleBackColor = true;
            this.popupBtn.Click += new System.EventHandler(this.popupBtn_Click);
            // 
            // clsBtn
            // 
            this.clsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clsBtn.BackgroundImage")));
            this.clsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clsBtn.FlatAppearance.BorderSize = 0;
            this.clsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsBtn.Location = new System.Drawing.Point(761, 396);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(51, 31);
            this.clsBtn.TabIndex = 15;
            this.clsBtn.UseVisualStyleBackColor = true;
            this.clsBtn.Click += new System.EventHandler(this.clsButton_Click);
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.clsBtn);
            this.Controls.Add(this.popupBtn);
            this.Controls.Add(this.myChart);
            this.Name = "Graphics";
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.Button popupBtn;
        private System.Windows.Forms.Button clsBtn;
    }
}