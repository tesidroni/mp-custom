namespace MissionPlanner.GCSViews
{
    partial class Oculus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageLabel1 = new MissionPlanner.Controls.ImageLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.myButton7 = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.closePort = new System.Windows.Forms.Button();
            this.OpenClosePort = new System.Windows.Forms.Button();
            this.ports = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLabel1
            // 
            this.imageLabel1.Image = global::MissionPlanner.Properties.Resources.fpv2;
            this.imageLabel1.Location = new System.Drawing.Point(3, 3);
            this.imageLabel1.Name = "imageLabel1";
            this.imageLabel1.Size = new System.Drawing.Size(91, 94);
            this.imageLabel1.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(3, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 493);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VIDEO FPV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1139, 474);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.label5.Font = new System.Drawing.Font("Tekton Pro Ext", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(100, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(778, 82);
            this.label5.TabIndex = 50;
            this.label5.Text = "FIRST PERSON VIEW";
            // 
            // myButton3
            // 
            this.myButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton3.Location = new System.Drawing.Point(1161, 210);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(121, 82);
            this.myButton3.TabIndex = 53;
            this.myButton3.Text = "TORNA AL DESKTOP";
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // myButton7
            // 
            this.myButton7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton7.Location = new System.Drawing.Point(1160, 116);
            this.myButton7.Name = "myButton7";
            this.myButton7.Size = new System.Drawing.Size(120, 82);
            this.myButton7.TabIndex = 57;
            this.myButton7.Text = "PASSA AD OCULUS";
            this.myButton7.UseVisualStyleBackColor = true;
            this.myButton7.Click += new System.EventHandler(this.myButton7_Click);
            // 
            // myButton2
            // 
            this.myButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton2.Location = new System.Drawing.Point(1160, 395);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(121, 82);
            this.myButton2.TabIndex = 58;
            this.myButton2.Text = "MUOVI CAMERA";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click_1);
            // 
            // closePort
            // 
            this.closePort.Enabled = false;
            this.closePort.Location = new System.Drawing.Point(1225, 353);
            this.closePort.Name = "closePort";
            this.closePort.Size = new System.Drawing.Size(57, 23);
            this.closePort.TabIndex = 61;
            this.closePort.Text = "Close";
            this.closePort.UseVisualStyleBackColor = true;
            this.closePort.Click += new System.EventHandler(this.closePort_Click);
            // 
            // OpenClosePort
            // 
            this.OpenClosePort.Location = new System.Drawing.Point(1160, 353);
            this.OpenClosePort.Name = "OpenClosePort";
            this.OpenClosePort.Size = new System.Drawing.Size(59, 23);
            this.OpenClosePort.TabIndex = 60;
            this.OpenClosePort.Text = "Connect";
            this.OpenClosePort.UseVisualStyleBackColor = true;
            this.OpenClosePort.Click += new System.EventHandler(this.OpenClosePort_Click);
            // 
            // ports
            // 
            this.ports.FormattingEnabled = true;
            this.ports.Location = new System.Drawing.Point(1160, 326);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(121, 21);
            this.ports.TabIndex = 59;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Oculus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.closePort);
            this.Controls.Add(this.OpenClosePort);
            this.Controls.Add(this.ports);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton7);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageLabel1);
            this.Name = "Oculus";
            this.Size = new System.Drawing.Size(1301, 599);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Oculus_KeyPress);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ImageLabel imageLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private Controls.MyButton myButton3;
        private Controls.MyButton myButton7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.MyButton myButton2;
        private System.Windows.Forms.Button closePort;
        private System.Windows.Forms.Button OpenClosePort;
        private System.Windows.Forms.ComboBox ports;
        private System.Windows.Forms.Timer timer1;
    }
}
