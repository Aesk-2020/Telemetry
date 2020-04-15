namespace yeniform
{
    partial class graph_form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.batconst_checkbox = new System.Windows.Forms.CheckBox();
            this.fcconst_checkbox = new System.Windows.Forms.CheckBox();
            this.outconst_checkbox = new System.Windows.Forms.CheckBox();
            this.fcltconst_checkbox = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // batconst_checkbox
            // 
            this.batconst_checkbox.AutoSize = true;
            this.batconst_checkbox.Location = new System.Drawing.Point(682, 31);
            this.batconst_checkbox.Name = "batconst_checkbox";
            this.batconst_checkbox.Size = new System.Drawing.Size(69, 17);
            this.batconst_checkbox.TabIndex = 0;
            this.batconst_checkbox.Text = "Bat Cons";
            this.batconst_checkbox.UseVisualStyleBackColor = true;
            // 
            // fcconst_checkbox
            // 
            this.fcconst_checkbox.AutoSize = true;
            this.fcconst_checkbox.Location = new System.Drawing.Point(682, 54);
            this.fcconst_checkbox.Name = "fcconst_checkbox";
            this.fcconst_checkbox.Size = new System.Drawing.Size(65, 17);
            this.fcconst_checkbox.TabIndex = 1;
            this.fcconst_checkbox.Text = "Fc Cons";
            this.fcconst_checkbox.UseVisualStyleBackColor = true;
            // 
            // outconst_checkbox
            // 
            this.outconst_checkbox.AutoSize = true;
            this.outconst_checkbox.Location = new System.Drawing.Point(682, 77);
            this.outconst_checkbox.Name = "outconst_checkbox";
            this.outconst_checkbox.Size = new System.Drawing.Size(70, 17);
            this.outconst_checkbox.TabIndex = 2;
            this.outconst_checkbox.Text = "Out Cons";
            this.outconst_checkbox.UseVisualStyleBackColor = true;
            // 
            // fcltconst_checkbox
            // 
            this.fcltconst_checkbox.AutoSize = true;
            this.fcltconst_checkbox.Location = new System.Drawing.Point(682, 100);
            this.fcltconst_checkbox.Name = "fcltconst_checkbox";
            this.fcltconst_checkbox.Size = new System.Drawing.Size(77, 17);
            this.fcltconst_checkbox.TabIndex = 3;
            this.fcltconst_checkbox.Text = "Fc Lt Cons";
            this.fcltconst_checkbox.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(654, 426);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // graph_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.fcltconst_checkbox);
            this.Controls.Add(this.outconst_checkbox);
            this.Controls.Add(this.fcconst_checkbox);
            this.Controls.Add(this.batconst_checkbox);
            this.Name = "graph_form";
            this.Text = "Grafikler";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox batconst_checkbox;
        private System.Windows.Forms.CheckBox fcconst_checkbox;
        private System.Windows.Forms.CheckBox outconst_checkbox;
        private System.Windows.Forms.CheckBox fcltconst_checkbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}