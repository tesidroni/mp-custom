namespace MissionPlanner.GCSViews
{
    partial class ExternalClient
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
            this.imageLabel1 = new MissionPlanner.Controls.ImageLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mavlinkNumericUpDown1 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.Disconnect = new MissionPlanner.Controls.MyButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLabel1
            // 
            this.imageLabel1.Image = global::MissionPlanner.Properties.Resources.CLIENT_SERVER_WHITE;
            this.imageLabel1.Location = new System.Drawing.Point(9, 12);
            this.imageLabel1.Name = "imageLabel1";
            this.imageLabel1.Size = new System.Drawing.Size(80, 65);
            this.imageLabel1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.label4.Font = new System.Drawing.Font("Stencil Std", 25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(116, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 45);
            this.label4.TabIndex = 58;
            this.label4.Text = "CLIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Priorità";
            // 
            // mavlinkNumericUpDown1
            // 
            this.mavlinkNumericUpDown1.Enabled = false;
            this.mavlinkNumericUpDown1.Location = new System.Drawing.Point(94, 571);
            this.mavlinkNumericUpDown1.Max = 1F;
            this.mavlinkNumericUpDown1.Min = 0F;
            this.mavlinkNumericUpDown1.Name = "mavlinkNumericUpDown1";
            this.mavlinkNumericUpDown1.param = null;
            this.mavlinkNumericUpDown1.ParamName = null;
            this.mavlinkNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.mavlinkNumericUpDown1.TabIndex = 56;
            // 
            // myButton2
            // 
            this.myButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton2.Location = new System.Drawing.Point(12, 528);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(123, 29);
            this.myButton2.TabIndex = 55;
            this.myButton2.Text = "INVIA";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton1
            // 
            this.myButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton1.Location = new System.Drawing.Point(9, 290);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(123, 29);
            this.myButton1.TabIndex = 54;
            this.myButton1.Text = "CONNETTI";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Disconnect.Location = new System.Drawing.Point(204, 290);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(123, 29);
            this.Disconnect.TabIndex = 53;
            this.Disconnect.Text = "DISCONNETTI";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Port";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 113);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 27);
            this.textBox4.TabIndex = 50;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 80);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 27);
            this.textBox3.TabIndex = 49;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 325);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 197);
            this.textBox2.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 129);
            this.textBox1.TabIndex = 47;
            // 
            // ExternalClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 600);
            this.Controls.Add(this.imageLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mavlinkNumericUpDown1);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "ExternalClient";
            this.Text = "ExternalClient";
            this.Load += new System.EventHandler(this.ExternalClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ImageLabel imageLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown1;
        private Controls.MyButton myButton2;
        private Controls.MyButton myButton1;
        private Controls.MyButton Disconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}