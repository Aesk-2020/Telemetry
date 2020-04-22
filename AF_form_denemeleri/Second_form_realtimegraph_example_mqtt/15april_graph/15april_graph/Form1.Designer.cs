namespace _15april_graph
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
            this.connect_mqtt = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.open_graph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_mqtt
            // 
            this.connect_mqtt.Location = new System.Drawing.Point(12, 12);
            this.connect_mqtt.Name = "connect_mqtt";
            this.connect_mqtt.Size = new System.Drawing.Size(138, 77);
            this.connect_mqtt.TabIndex = 0;
            this.connect_mqtt.Text = "Connect Mqtt";
            this.connect_mqtt.UseVisualStyleBackColor = true;
            this.connect_mqtt.Click += new System.EventHandler(this.connect_mqtt_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(190, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(598, 218);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // open_graph
            // 
            this.open_graph.Location = new System.Drawing.Point(12, 153);
            this.open_graph.Name = "open_graph";
            this.open_graph.Size = new System.Drawing.Size(138, 77);
            this.open_graph.TabIndex = 2;
            this.open_graph.Text = "Graph ";
            this.open_graph.UseVisualStyleBackColor = true;
            this.open_graph.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.open_graph);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.connect_mqtt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connect_mqtt;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button open_graph;
    }
}

