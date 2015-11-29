namespace MissionPlanner.GCSViews
{
    partial class MotionCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotionCamera));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.position = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clear = new System.Windows.Forms.Button();
            this.closePort = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.OpenClosePort = new System.Windows.Forms.Button();
            this.ports = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(25, 172);
            this.trackBar1.Maximum = 170;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(217, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Value = 85;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.position.Location = new System.Drawing.Point(194, 82);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(14, 13);
            this.position.TabIndex = 20;
            this.position.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(22, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Current position of Servo is:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Location = new System.Drawing.Point(25, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 121);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arduino FeedBack Monitor";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(219, 55);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(6, 88);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click_1);
            // 
            // closePort
            // 
            this.closePort.Enabled = false;
            this.closePort.Location = new System.Drawing.Point(118, 43);
            this.closePort.Name = "closePort";
            this.closePort.Size = new System.Drawing.Size(75, 23);
            this.closePort.TabIndex = 17;
            this.closePort.Text = "Close";
            this.closePort.UseVisualStyleBackColor = true;
            this.closePort.Click += new System.EventHandler(this.closePort_Click_1);
            // 
            // right
            // 
            this.right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right.BackgroundImage")));
            this.right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.right.Location = new System.Drawing.Point(187, 108);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(58, 58);
            this.right.TabIndex = 16;
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // reset
            // 
            this.reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reset.BackgroundImage")));
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Location = new System.Drawing.Point(106, 108);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(62, 58);
            this.reset.TabIndex = 15;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // left
            // 
            this.left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left.BackgroundImage")));
            this.left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.left.Location = new System.Drawing.Point(25, 108);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(59, 58);
            this.left.TabIndex = 14;
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click_1);
            // 
            // OpenClosePort
            // 
            this.OpenClosePort.Location = new System.Drawing.Point(25, 43);
            this.OpenClosePort.Name = "OpenClosePort";
            this.OpenClosePort.Size = new System.Drawing.Size(75, 23);
            this.OpenClosePort.TabIndex = 13;
            this.OpenClosePort.Text = "Connect";
            this.OpenClosePort.UseVisualStyleBackColor = true;
            this.OpenClosePort.Click += new System.EventHandler(this.OpenClosePort_Click_1);
            // 
            // ports
            // 
            this.ports.FormattingEnabled = true;
            this.ports.Location = new System.Drawing.Point(25, 16);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(224, 21);
            this.ports.TabIndex = 12;
            this.ports.SelectedIndexChanged += new System.EventHandler(this.ports_SelectedIndexChanged);
            // 
            // MotionCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 515);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closePort);
            this.Controls.Add(this.right);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.left);
            this.Controls.Add(this.OpenClosePort);
            this.Controls.Add(this.ports);
            this.Name = "MotionCamera";
            this.Text = "MotionCamera";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button closePort;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button OpenClosePort;
        private System.Windows.Forms.ComboBox ports;
    }
}