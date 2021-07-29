
namespace Telemetri.NewForms
{
    partial class NewGraphics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGraphics));
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.popupBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.clsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(3, 3);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(858, 465);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.02174F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.978261F));
            this.tableLayoutPanel1.Controls.Add(this.cartesianChart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.0828F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 471);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // popupBtn
            // 
            this.popupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.popupBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("popupBtn.BackgroundImage")));
            this.popupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.popupBtn.FlatAppearance.BorderSize = 0;
            this.popupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popupBtn.Location = new System.Drawing.Point(3, 380);
            this.popupBtn.Name = "popupBtn";
            this.popupBtn.Size = new System.Drawing.Size(44, 34);
            this.popupBtn.TabIndex = 19;
            this.popupBtn.UseVisualStyleBackColor = true;
            this.popupBtn.Click += new System.EventHandler(this.popupBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.clsBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.popupBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(867, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.81042F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.18957F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(50, 465);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // clsBtn
            // 
            this.clsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clsBtn.BackgroundImage")));
            this.clsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clsBtn.FlatAppearance.BorderSize = 0;
            this.clsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsBtn.Location = new System.Drawing.Point(3, 431);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(44, 31);
            this.clsBtn.TabIndex = 18;
            this.clsBtn.UseVisualStyleBackColor = true;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click_1);
            // 
            // NewGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(920, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewGraphics";
            this.Text = "NewGraphics";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button popupBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button clsBtn;
    }
}