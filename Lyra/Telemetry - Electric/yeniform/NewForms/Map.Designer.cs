﻿namespace Telemetri.NewForms
{
    partial class Map
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
            this.gMapTool = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // gMapTool
            // 
            this.gMapTool.Bearing = 0F;
            this.gMapTool.CanDragMap = true;
            this.gMapTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapTool.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapTool.GrayScaleMode = false;
            this.gMapTool.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapTool.LevelsKeepInMemory = 5;
            this.gMapTool.Location = new System.Drawing.Point(0, 0);
            this.gMapTool.MarkersEnabled = true;
            this.gMapTool.MaxZoom = 2;
            this.gMapTool.MinZoom = 2;
            this.gMapTool.MouseWheelZoomEnabled = true;
            this.gMapTool.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapTool.Name = "gMapTool";
            this.gMapTool.NegativeMode = false;
            this.gMapTool.PolygonsEnabled = true;
            this.gMapTool.RetryLoadTile = 0;
            this.gMapTool.RoutesEnabled = true;
            this.gMapTool.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapTool.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapTool.ShowTileGridLines = false;
            this.gMapTool.Size = new System.Drawing.Size(914, 621);
            this.gMapTool.TabIndex = 0;
            this.gMapTool.Zoom = 0D;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(914, 621);
            this.Controls.Add(this.gMapTool);
            this.Name = "Map";
            this.Text = "Harita";
            this.Load += new System.EventHandler(this.Map_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapTool;
    }
}