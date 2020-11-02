namespace EmniyetArac
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Forwardbutton = new System.Windows.Forms.Button();
            this.gotoDate = new System.Windows.Forms.Button();
            this.labelHaft = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.platesearchButton = new System.Windows.Forms.Button();
            this.textboxSearchPlate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSeeData = new System.Windows.Forms.Button();
            this.ExcelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EkleButton = new System.Windows.Forms.Button();
            this.textboxInsertSube = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textboxInsertPlate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSelectedDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datePortionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBoxVehice = new System.Windows.Forms.ComboBox();
            this.tamamlaButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.selectedTarihLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timePortionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.haftExcel = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Forwardbutton
            // 
            this.Forwardbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Forwardbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Forwardbutton.Location = new System.Drawing.Point(67, 199);
            this.Forwardbutton.Name = "Forwardbutton";
            this.Forwardbutton.Size = new System.Drawing.Size(49, 24);
            this.Forwardbutton.TabIndex = 30;
            this.Forwardbutton.Text = ">";
            this.Forwardbutton.UseVisualStyleBackColor = true;
            this.Forwardbutton.Click += new System.EventHandler(this.Forwardbutton_Click);
            // 
            // gotoDate
            // 
            this.gotoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gotoDate.Location = new System.Drawing.Point(296, 165);
            this.gotoDate.Name = "gotoDate";
            this.gotoDate.Size = new System.Drawing.Size(62, 24);
            this.gotoDate.TabIndex = 29;
            this.gotoDate.Text = "Git";
            this.gotoDate.UseVisualStyleBackColor = true;
            this.gotoDate.Click += new System.EventHandler(this.gotoDate_Click);
            // 
            // labelHaft
            // 
            this.labelHaft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelHaft.AutoSize = true;
            this.labelHaft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHaft.Location = new System.Drawing.Point(122, 204);
            this.labelHaft.Name = "labelHaft";
            this.labelHaft.Size = new System.Drawing.Size(11, 13);
            this.labelHaft.TabIndex = 28;
            this.labelHaft.Text = "-";
            // 
            // Backbutton
            // 
            this.Backbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Backbutton.Location = new System.Drawing.Point(12, 199);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(49, 24);
            this.Backbutton.TabIndex = 27;
            this.Backbutton.Text = "<";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.RichTextBox1);
            this.panel3.Controls.Add(this.platesearchButton);
            this.panel3.Controls.Add(this.textboxSearchPlate);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(840, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 198);
            this.panel3.TabIndex = 26;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(20, 60);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(311, 132);
            this.RichTextBox1.TabIndex = 7;
            this.RichTextBox1.Text = "";
            // 
            // platesearchButton
            // 
            this.platesearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.platesearchButton.Location = new System.Drawing.Point(66, 5);
            this.platesearchButton.Name = "platesearchButton";
            this.platesearchButton.Size = new System.Drawing.Size(75, 23);
            this.platesearchButton.TabIndex = 13;
            this.platesearchButton.Text = "Ara";
            this.platesearchButton.UseVisualStyleBackColor = true;
            this.platesearchButton.Click += new System.EventHandler(this.platesearchButton_Click);
            // 
            // textboxSearchPlate
            // 
            this.textboxSearchPlate.Location = new System.Drawing.Point(20, 34);
            this.textboxSearchPlate.Name = "textboxSearchPlate";
            this.textboxSearchPlate.Size = new System.Drawing.Size(140, 20);
            this.textboxSearchPlate.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(17, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Plaka";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Yer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSeeData
            // 
            this.buttonSeeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeeData.Location = new System.Drawing.Point(12, 12);
            this.buttonSeeData.Name = "buttonSeeData";
            this.buttonSeeData.Size = new System.Drawing.Size(104, 65);
            this.buttonSeeData.TabIndex = 19;
            this.buttonSeeData.Text = "Verileri Gör";
            this.buttonSeeData.UseVisualStyleBackColor = true;
            this.buttonSeeData.Click += new System.EventHandler(this.buttonSeeData_Click);
            // 
            // ExcelButton
            // 
            this.ExcelButton.Location = new System.Drawing.Point(122, 12);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(89, 35);
            this.ExcelButton.TabIndex = 17;
            this.ExcelButton.Text = "Excel Yedek";
            this.ExcelButton.UseVisualStyleBackColor = true;
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.EkleButton);
            this.panel2.Controls.Add(this.textboxInsertSube);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textboxInsertPlate);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.labelSelectedDate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(621, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 198);
            this.panel2.TabIndex = 25;
            // 
            // EkleButton
            // 
            this.EkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleButton.Location = new System.Drawing.Point(15, 162);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(75, 23);
            this.EkleButton.TabIndex = 12;
            this.EkleButton.Text = "Ekle";
            this.EkleButton.UseVisualStyleBackColor = true;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // textboxInsertSube
            // 
            this.textboxInsertSube.Location = new System.Drawing.Point(15, 127);
            this.textboxInsertSube.Name = "textboxInsertSube";
            this.textboxInsertSube.Size = new System.Drawing.Size(171, 20);
            this.textboxInsertSube.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(15, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Sube";
            // 
            // textboxInsertPlate
            // 
            this.textboxInsertPlate.Location = new System.Drawing.Point(15, 72);
            this.textboxInsertPlate.Name = "textboxInsertPlate";
            this.textboxInsertPlate.Size = new System.Drawing.Size(171, 20);
            this.textboxInsertPlate.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Plaka";
            // 
            // labelSelectedDate
            // 
            this.labelSelectedDate.AutoSize = true;
            this.labelSelectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSelectedDate.Location = new System.Drawing.Point(12, 30);
            this.labelSelectedDate.Name = "labelSelectedDate";
            this.labelSelectedDate.Size = new System.Drawing.Size(12, 15);
            this.labelSelectedDate.TabIndex = 8;
            this.labelSelectedDate.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Seçili Tarih";
            // 
            // datePortionDateTimePicker
            // 
            this.datePortionDateTimePicker.Location = new System.Drawing.Point(16, 165);
            this.datePortionDateTimePicker.Name = "datePortionDateTimePicker";
            this.datePortionDateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.datePortionDateTimePicker.TabIndex = 24;
            this.datePortionDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.ComboBoxVehice);
            this.panel1.Controls.Add(this.tamamlaButton);
            this.panel1.Controls.Add(this.silButton);
            this.panel1.Controls.Add(this.selectedTarihLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(364, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 198);
            this.panel1.TabIndex = 23;
            // 
            // ComboBoxVehice
            // 
            this.ComboBoxVehice.FormattingEnabled = true;
            this.ComboBoxVehice.Location = new System.Drawing.Point(15, 90);
            this.ComboBoxVehice.Name = "ComboBoxVehice";
            this.ComboBoxVehice.Size = new System.Drawing.Size(225, 21);
            this.ComboBoxVehice.TabIndex = 9;
            this.ComboBoxVehice.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVehice_SelectedIndexChanged);
            // 
            // tamamlaButton
            // 
            this.tamamlaButton.Location = new System.Drawing.Point(15, 117);
            this.tamamlaButton.Name = "tamamlaButton";
            this.tamamlaButton.Size = new System.Drawing.Size(75, 23);
            this.tamamlaButton.TabIndex = 7;
            this.tamamlaButton.Text = "Tamamlandı";
            this.tamamlaButton.UseVisualStyleBackColor = true;
            this.tamamlaButton.Click += new System.EventHandler(this.tamamlaButton_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(15, 144);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(75, 23);
            this.silButton.TabIndex = 2;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // selectedTarihLabel
            // 
            this.selectedTarihLabel.AutoSize = true;
            this.selectedTarihLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectedTarihLabel.Location = new System.Drawing.Point(12, 39);
            this.selectedTarihLabel.Name = "selectedTarihLabel";
            this.selectedTarihLabel.Size = new System.Drawing.Size(12, 15);
            this.selectedTarihLabel.TabIndex = 3;
            this.selectedTarihLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Araclar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 374);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column0
            // 
            this.Column0.HeaderText = "Saat/Gün";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Pzt";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Sl";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Crs";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Prs";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "Cm";
            this.Column5.MinimumWidth = 100;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.HeaderText = "Cmrt";
            this.Column6.MinimumWidth = 100;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column7.HeaderText = "Pz";
            this.Column7.MinimumWidth = 100;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // timePortionDateTimePicker
            // 
            this.timePortionDateTimePicker.Location = new System.Drawing.Point(193, 165);
            this.timePortionDateTimePicker.Name = "timePortionDateTimePicker";
            this.timePortionDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.timePortionDateTimePicker.TabIndex = 31;
            this.timePortionDateTimePicker.ValueChanged += new System.EventHandler(this.timePortionDateTimePicker_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Hakkında";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // haftExcel
            // 
            this.haftExcel.Location = new System.Drawing.Point(217, 13);
            this.haftExcel.Name = "haftExcel";
            this.haftExcel.Size = new System.Drawing.Size(89, 34);
            this.haftExcel.TabIndex = 33;
            this.haftExcel.Text = "Haftalik Excel";
            this.haftExcel.UseVisualStyleBackColor = true;
            this.haftExcel.Click += new System.EventHandler(this.haftExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 643);
            this.Controls.Add(this.haftExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ExcelButton);
            this.Controls.Add(this.buttonSeeData);
            this.Controls.Add(this.timePortionDateTimePicker);
            this.Controls.Add(this.Forwardbutton);
            this.Controls.Add(this.gotoDate);
            this.Controls.Add(this.labelHaft);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datePortionDateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arac Veri Tabanı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Forwardbutton;
        private System.Windows.Forms.Button gotoDate;
        private System.Windows.Forms.Label labelHaft;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ExcelButton;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.Button platesearchButton;
        private System.Windows.Forms.TextBox textboxSearchPlate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.TextBox textboxInsertSube;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textboxInsertPlate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelSelectedDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datePortionDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tamamlaButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Label selectedTarihLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSeeData;
        private System.Windows.Forms.DateTimePicker timePortionDateTimePicker;
        private System.Windows.Forms.ComboBox ComboBoxVehice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button haftExcel;
    }
}

