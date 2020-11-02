namespace EmniyetArac
{
    partial class AllDataAcces
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
            this.dataGridViewVehice = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPendings = new System.Windows.Forms.DataGridView();
            this.ColPendingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVehiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVehice
            // 
            this.dataGridViewVehice.AllowUserToAddRows = false;
            this.dataGridViewVehice.AllowUserToDeleteRows = false;
            this.dataGridViewVehice.AllowUserToResizeRows = false;
            this.dataGridViewVehice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColPlaka,
            this.ColStation});
            this.dataGridViewVehice.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVehice.Name = "dataGridViewVehice";
            this.dataGridViewVehice.ReadOnly = true;
            this.dataGridViewVehice.RowHeadersVisible = false;
            this.dataGridViewVehice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewVehice.Size = new System.Drawing.Size(328, 150);
            this.dataGridViewVehice.TabIndex = 0;
            this.dataGridViewVehice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            // 
            // ColPlaka
            // 
            this.ColPlaka.HeaderText = "Plaka";
            this.ColPlaka.Name = "ColPlaka";
            this.ColPlaka.ReadOnly = true;
            // 
            // ColStation
            // 
            this.ColStation.HeaderText = "Sube";
            this.ColStation.Name = "ColStation";
            this.ColStation.ReadOnly = true;
            // 
            // dataGridViewPendings
            // 
            this.dataGridViewPendings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPendingID,
            this.ColVehiceID,
            this.ColDate,
            this.ColIsCompleted});
            this.dataGridViewPendings.Location = new System.Drawing.Point(12, 180);
            this.dataGridViewPendings.Name = "dataGridViewPendings";
            this.dataGridViewPendings.RowHeadersVisible = false;
            this.dataGridViewPendings.Size = new System.Drawing.Size(429, 249);
            this.dataGridViewPendings.TabIndex = 1;
            this.dataGridViewPendings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ColPendingID
            // 
            this.ColPendingID.HeaderText = "ID";
            this.ColPendingID.Name = "ColPendingID";
            // 
            // ColVehiceID
            // 
            this.ColVehiceID.HeaderText = "VehiceID";
            this.ColVehiceID.Name = "ColVehiceID";
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Tarih";
            this.ColDate.Name = "ColDate";
            // 
            // ColIsCompleted
            // 
            this.ColIsCompleted.HeaderText = "Durum";
            this.ColIsCompleted.Name = "ColIsCompleted";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(344, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllDataAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPendings);
            this.Controls.Add(this.dataGridViewVehice);
            this.Name = "AllDataAcces";
            this.Text = "Veriler";
            this.Load += new System.EventHandler(this.AllDataAcces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehice;
        private System.Windows.Forms.DataGridView dataGridViewPendings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPendingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVehiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIsCompleted;
        private System.Windows.Forms.Button button1;
    }
}