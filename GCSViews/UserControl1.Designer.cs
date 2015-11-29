namespace MissionPlanner.GCSViews
{
    partial class UserControl1
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
            this.SubMainLeft = new System.Windows.Forms.SplitContainer();
            this.tvClientList = new System.Windows.Forms.TreeView();
            this.tabControlactions = new System.Windows.Forms.TabControl();
            this.tabQuick = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelQuick = new System.Windows.Forms.TableLayoutPanel();
            this.quickView6 = new MissionPlanner.Controls.QuickView();
            this.quickView5 = new MissionPlanner.Controls.QuickView();
            this.quickView4 = new MissionPlanner.Controls.QuickView();
            this.quickView3 = new MissionPlanner.Controls.QuickView();
            this.quickView2 = new MissionPlanner.Controls.QuickView();
            this.quickView1 = new MissionPlanner.Controls.QuickView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabGauges = new System.Windows.Forms.TabPage();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.Galt = new AGaugeApp.AGauge();
            this.Gspeed = new AGaugeApp.AGauge();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new MissionPlanner.Controls.MyButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPortNumber = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.mavlinkNumericUpDown2 = new MissionPlanner.Controls.MavlinkNumericUpDown();
            this.imageLabel1 = new MissionPlanner.Controls.ImageLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.mavlinkNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).BeginInit();
            this.SubMainLeft.Panel1.SuspendLayout();
            this.SubMainLeft.Panel2.SuspendLayout();
            this.SubMainLeft.SuspendLayout();
            this.tabControlactions.SuspendLayout();
            this.tabQuick.SuspendLayout();
            this.tableLayoutPanelQuick.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabGauges.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubMainLeft
            // 
            this.SubMainLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubMainLeft.Location = new System.Drawing.Point(10, 129);
            this.SubMainLeft.Margin = new System.Windows.Forms.Padding(0);
            this.SubMainLeft.Name = "SubMainLeft";
            this.SubMainLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SubMainLeft.Panel1
            // 
            this.SubMainLeft.Panel1.AutoScroll = true;
            this.SubMainLeft.Panel1.Controls.Add(this.tvClientList);
            // 
            // SubMainLeft.Panel2
            // 
            this.SubMainLeft.Panel2.Controls.Add(this.tabControlactions);
            this.SubMainLeft.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SubMainLeft.Size = new System.Drawing.Size(472, 454);
            this.SubMainLeft.SplitterDistance = 263;
            this.SubMainLeft.TabIndex = 1;
            // 
            // tvClientList
            // 
            this.tvClientList.Location = new System.Drawing.Point(11, 4);
            this.tvClientList.Margin = new System.Windows.Forms.Padding(4);
            this.tvClientList.Name = "tvClientList";
            this.tvClientList.Size = new System.Drawing.Size(456, 253);
            this.tvClientList.TabIndex = 7;
            this.tvClientList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvClientList_AfterSelect);
            // 
            // tabControlactions
            // 
            this.tabControlactions.Controls.Add(this.tabQuick);
            this.tabControlactions.Controls.Add(this.tabPage1);
            this.tabControlactions.Controls.Add(this.tabGauges);
            this.tabControlactions.Location = new System.Drawing.Point(1, 0);
            this.tabControlactions.Name = "tabControlactions";
            this.tabControlactions.Padding = new System.Drawing.Point(0, 0);
            this.tabControlactions.SelectedIndex = 0;
            this.tabControlactions.Size = new System.Drawing.Size(485, 176);
            this.tabControlactions.TabIndex = 84;
            // 
            // tabQuick
            // 
            this.tabQuick.AutoScroll = true;
            this.tabQuick.Controls.Add(this.tableLayoutPanelQuick);
            this.tabQuick.Location = new System.Drawing.Point(4, 22);
            this.tabQuick.Name = "tabQuick";
            this.tabQuick.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuick.Size = new System.Drawing.Size(477, 150);
            this.tabQuick.TabIndex = 4;
            this.tabQuick.Text = "Quick";
            this.tabQuick.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelQuick
            // 
            this.tableLayoutPanelQuick.AutoScroll = true;
            this.tableLayoutPanelQuick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelQuick.ColumnCount = 2;
            this.tableLayoutPanelQuick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelQuick.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelQuick.Controls.Add(this.quickView6, 1, 2);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView5, 0, 2);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView4, 1, 1);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView3, 0, 1);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView2, 1, 0);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView1, 0, 0);
            this.tableLayoutPanelQuick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQuick.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelQuick.Name = "tableLayoutPanelQuick";
            this.tableLayoutPanelQuick.RowCount = 3;
            this.tableLayoutPanelQuick.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuick.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuick.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuick.Size = new System.Drawing.Size(471, 144);
            this.tableLayoutPanelQuick.TabIndex = 73;
            // 
            // quickView6
            // 
            this.quickView6.desc = "DistToMAV";
            this.quickView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView6.Location = new System.Drawing.Point(238, 99);
            this.quickView6.MinimumSize = new System.Drawing.Size(100, 27);
            this.quickView6.Name = "quickView6";
            this.quickView6.number = 0D;
            this.quickView6.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.quickView6.numberformat = "0.00";
            this.quickView6.Size = new System.Drawing.Size(230, 42);
            this.quickView6.TabIndex = 10;
            // 
            // quickView5
            // 
            this.quickView5.desc = "verticalspeed";
            this.quickView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView5.Location = new System.Drawing.Point(3, 99);
            this.quickView5.MinimumSize = new System.Drawing.Size(100, 27);
            this.quickView5.Name = "quickView5";
            this.quickView5.number = 0D;
            this.quickView5.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(86)))));
            this.quickView5.numberformat = "0.00";
            this.quickView5.Size = new System.Drawing.Size(229, 42);
            this.quickView5.TabIndex = 9;
            // 
            // quickView4
            // 
            this.quickView4.desc = "yaw";
            this.quickView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView4.Location = new System.Drawing.Point(238, 51);
            this.quickView4.MinimumSize = new System.Drawing.Size(100, 27);
            this.quickView4.Name = "quickView4";
            this.quickView4.number = 0D;
            this.quickView4.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(83)))));
            this.quickView4.numberformat = "0.00";
            this.quickView4.Size = new System.Drawing.Size(230, 42);
            this.quickView4.TabIndex = 8;
            // 
            // quickView3
            // 
            this.quickView3.desc = "wp_dist";
            this.quickView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView3.Location = new System.Drawing.Point(3, 51);
            this.quickView3.MinimumSize = new System.Drawing.Size(100, 27);
            this.quickView3.Name = "quickView3";
            this.quickView3.number = 0D;
            this.quickView3.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(91)))));
            this.quickView3.numberformat = "0.00";
            this.quickView3.Size = new System.Drawing.Size(229, 42);
            this.quickView3.TabIndex = 3;
            // 
            // quickView2
            // 
            this.quickView2.desc = "groundspeed";
            this.quickView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView2.Location = new System.Drawing.Point(238, 3);
            this.quickView2.MinimumSize = new System.Drawing.Size(100, 27);
            this.quickView2.Name = "quickView2";
            this.quickView2.number = 9999.99D;
            this.quickView2.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(132)))), ((int)(((byte)(46)))));
            this.quickView2.numberformat = "0.00";
            this.quickView2.Size = new System.Drawing.Size(230, 42);
            this.quickView2.TabIndex = 1;
            // 
            // quickView1
            // 
            this.quickView1.desc = "alt";
            this.quickView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView1.Location = new System.Drawing.Point(3, 3);
            this.quickView1.MinimumSize = new System.Drawing.Size(100, 27);
            this.quickView1.Name = "quickView1";
            this.quickView1.number = 0D;
            this.quickView1.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(151)))), ((int)(((byte)(248)))));
            this.quickView1.numberformat = "0.00";
            this.quickView1.Size = new System.Drawing.Size(229, 42);
            this.quickView1.TabIndex = 1;
            this.quickView1.Load += new System.EventHandler(this.quickView1_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.richTextBox4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.richTextBox3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 150);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(217, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Battery level";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(53, 71);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(104, 27);
            this.richTextBox4.TabIndex = 58;
            this.richTextBox4.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(217, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Hig";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(53, 20);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(104, 27);
            this.richTextBox3.TabIndex = 57;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(15, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Wind";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(303, 74);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(104, 27);
            this.richTextBox2.TabIndex = 56;
            this.richTextBox2.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "GPS";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(303, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(104, 27);
            this.richTextBox1.TabIndex = 55;
            this.richTextBox1.Text = "";
            // 
            // tabGauges
            // 
            this.tabGauges.Controls.Add(this.aGauge1);
            this.tabGauges.Controls.Add(this.Galt);
            this.tabGauges.Controls.Add(this.Gspeed);
            this.tabGauges.Controls.Add(this.aGauge2);
            this.tabGauges.Location = new System.Drawing.Point(4, 22);
            this.tabGauges.Name = "tabGauges";
            this.tabGauges.Padding = new System.Windows.Forms.Padding(3);
            this.tabGauges.Size = new System.Drawing.Size(477, 150);
            this.tabGauges.TabIndex = 0;
            this.tabGauges.Text = "Gauges";
            this.tabGauges.UseVisualStyleBackColor = true;
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.Color.Transparent;
            this.aGauge1.BackgroundImage = global::MissionPlanner.Properties.Resources.Gaugebg;
            this.aGauge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge1.BaseArcRadius = 60;
            this.aGauge1.BaseArcStart = 270;
            this.aGauge1.BaseArcSweep = 360;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(0));
            this.aGauge1.CapColor = System.Drawing.Color.White;
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(68, 85);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(68, 85),
        new System.Drawing.Point(30, 55),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "Alt",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "Alt";
            this.aGauge1.Center = new System.Drawing.Point(75, 75);
            this.aGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aGauge1.Location = new System.Drawing.Point(236, 0);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(0);
            this.aGauge1.MaxValue = 9.99F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.Need_Idx = ((byte)(3));
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.White;
            this.aGauge1.NeedleEnabled = false;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge1.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.aGauge1.NeedlesEnabled = new bool[] {
        true,
        true,
        true,
        false};
            this.aGauge1.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.aGauge1.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge1.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(0));
            this.aGauge1.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge1.RangeEnabled = false;
            this.aGauge1.RangeEndValue = 360F;
            this.aGauge1.RangeInnerRadius = 1;
            this.aGauge1.RangeOuterRadius = 60;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 0F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesInterInnerRadius = 52;
            this.aGauge1.ScaleLinesInterOuterRadius = 60;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesMajorInnerRadius = 50;
            this.aGauge1.ScaleLinesMajorOuterRadius = 60;
            this.aGauge1.ScaleLinesMajorStepValue = 1F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesMinorInnerRadius = 55;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 60;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge1.ScaleNumbersFormat = "";
            this.aGauge1.ScaleNumbersRadius = 42;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 1;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(118, 118);
            this.aGauge1.TabIndex = 83;
            this.aGauge1.Value = 0F;
            this.aGauge1.Value0 = 100F;
            this.aGauge1.Value1 = 10F;
            this.aGauge1.Value2 = 0F;
            this.aGauge1.Value3 = 0F;
            // 
            // Galt
            // 
            this.Galt.BackColor = System.Drawing.Color.Transparent;
            this.Galt.BackgroundImage = global::MissionPlanner.Properties.Resources.Gaugebg;
            this.Galt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Galt.BaseArcColor = System.Drawing.Color.Transparent;
            this.Galt.BaseArcRadius = 60;
            this.Galt.BaseArcStart = 270;
            this.Galt.BaseArcSweep = 360;
            this.Galt.BaseArcWidth = 2;
            this.Galt.Cap_Idx = ((byte)(0));
            this.Galt.CapColor = System.Drawing.Color.White;
            this.Galt.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Galt.CapPosition = new System.Drawing.Point(68, 85);
            this.Galt.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(68, 85),
        new System.Drawing.Point(30, 55),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Galt.CapsText = new string[] {
        "Wind",
        "",
        "",
        "",
        ""};
            this.Galt.CapText = "Wind";
            this.Galt.Center = new System.Drawing.Point(75, 75);
            this.Galt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Galt.Location = new System.Drawing.Point(354, 0);
            this.Galt.Margin = new System.Windows.Forms.Padding(0);
            this.Galt.MaxValue = 9.99F;
            this.Galt.MinValue = 0F;
            this.Galt.Name = "Galt";
            this.Galt.Need_Idx = ((byte)(3));
            this.Galt.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Galt.NeedleColor2 = System.Drawing.Color.White;
            this.Galt.NeedleEnabled = false;
            this.Galt.NeedleRadius = 80;
            this.Galt.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Galt.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.Galt.NeedlesEnabled = new bool[] {
        true,
        true,
        true,
        false};
            this.Galt.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Galt.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Galt.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Galt.NeedleType = 0;
            this.Galt.NeedleWidth = 2;
            this.Galt.Range_Idx = ((byte)(0));
            this.Galt.RangeColor = System.Drawing.Color.LightGreen;
            this.Galt.RangeEnabled = false;
            this.Galt.RangeEndValue = 360F;
            this.Galt.RangeInnerRadius = 1;
            this.Galt.RangeOuterRadius = 60;
            this.Galt.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Galt.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Galt.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Galt.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Galt.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Galt.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Galt.RangeStartValue = 0F;
            this.Galt.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesInterInnerRadius = 52;
            this.Galt.ScaleLinesInterOuterRadius = 60;
            this.Galt.ScaleLinesInterWidth = 1;
            this.Galt.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesMajorInnerRadius = 50;
            this.Galt.ScaleLinesMajorOuterRadius = 60;
            this.Galt.ScaleLinesMajorStepValue = 1F;
            this.Galt.ScaleLinesMajorWidth = 2;
            this.Galt.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesMinorInnerRadius = 55;
            this.Galt.ScaleLinesMinorNumOf = 9;
            this.Galt.ScaleLinesMinorOuterRadius = 60;
            this.Galt.ScaleLinesMinorWidth = 1;
            this.Galt.ScaleNumbersColor = System.Drawing.Color.White;
            this.Galt.ScaleNumbersFormat = "";
            this.Galt.ScaleNumbersRadius = 42;
            this.Galt.ScaleNumbersRotation = 0;
            this.Galt.ScaleNumbersStartScaleLine = 1;
            this.Galt.ScaleNumbersStepScaleLines = 1;
            this.Galt.Size = new System.Drawing.Size(118, 118);
            this.Galt.TabIndex = 81;
            this.Galt.Value = 0F;
            this.Galt.Value0 = 100F;
            this.Galt.Value1 = 10F;
            this.Galt.Value2 = 0F;
            this.Galt.Value3 = 0F;
            // 
            // Gspeed
            // 
            this.Gspeed.BackColor = System.Drawing.Color.Transparent;
            this.Gspeed.BackgroundImage = global::MissionPlanner.Properties.Resources.Gaugebg;
            this.Gspeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gspeed.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gspeed.BaseArcRadius = 70;
            this.Gspeed.BaseArcStart = 135;
            this.Gspeed.BaseArcSweep = 270;
            this.Gspeed.BaseArcWidth = 2;
            this.Gspeed.Cap_Idx = ((byte)(0));
            this.Gspeed.CapColor = System.Drawing.Color.White;
            this.Gspeed.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gspeed.CapPosition = new System.Drawing.Point(58, 85);
            this.Gspeed.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gspeed.CapsText = new string[] {
        "Speed",
        "",
        "",
        "",
        ""};
            this.Gspeed.CapText = "Speed";
            this.Gspeed.Center = new System.Drawing.Point(75, 75);
            this.Gspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Gspeed.Location = new System.Drawing.Point(115, -3);
            this.Gspeed.Margin = new System.Windows.Forms.Padding(0);
            this.Gspeed.MaxValue = 80F;
            this.Gspeed.MinValue = 0F;
            this.Gspeed.Name = "Gspeed";
            this.Gspeed.Need_Idx = ((byte)(3));
            this.Gspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gspeed.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gspeed.NeedleEnabled = false;
            this.Gspeed.NeedleRadius = 70;
            this.Gspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gspeed.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gspeed.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gspeed.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gspeed.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gspeed.NeedleType = 0;
            this.Gspeed.NeedleWidth = 2;
            this.Gspeed.Range_Idx = ((byte)(2));
            this.Gspeed.RangeColor = System.Drawing.Color.Orange;
            this.Gspeed.RangeEnabled = false;
            this.Gspeed.RangeEndValue = 50F;
            this.Gspeed.RangeInnerRadius = 1;
            this.Gspeed.RangeOuterRadius = 70;
            this.Gspeed.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gspeed.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gspeed.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gspeed.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gspeed.RangeStartValue = 35F;
            this.Gspeed.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesInterInnerRadius = 52;
            this.Gspeed.ScaleLinesInterOuterRadius = 60;
            this.Gspeed.ScaleLinesInterWidth = 1;
            this.Gspeed.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gspeed.ScaleLinesMajorStepValue = 10F;
            this.Gspeed.ScaleLinesMajorWidth = 2;
            this.Gspeed.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gspeed.ScaleLinesMinorNumOf = 9;
            this.Gspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gspeed.ScaleLinesMinorWidth = 1;
            this.Gspeed.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gspeed.ScaleNumbersFormat = null;
            this.Gspeed.ScaleNumbersRadius = 42;
            this.Gspeed.ScaleNumbersRotation = 0;
            this.Gspeed.ScaleNumbersStartScaleLine = 1;
            this.Gspeed.ScaleNumbersStepScaleLines = 1;
            this.Gspeed.Size = new System.Drawing.Size(121, 121);
            this.Gspeed.TabIndex = 79;
            this.Gspeed.Value = 30F;
            this.Gspeed.Value0 = 10F;
            this.Gspeed.Value1 = 10F;
            this.Gspeed.Value2 = 0F;
            this.Gspeed.Value3 = 30F;
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.Color.Transparent;
            this.aGauge2.BackgroundImage = global::MissionPlanner.Properties.Resources.Gaugebg;
            this.aGauge2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge2.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge2.BaseArcRadius = 70;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(0));
            this.aGauge2.CapColor = System.Drawing.Color.White;
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "Battery",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "Battery";
            this.aGauge2.Center = new System.Drawing.Point(75, 75);
            this.aGauge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aGauge2.Location = new System.Drawing.Point(-6, -3);
            this.aGauge2.Margin = new System.Windows.Forms.Padding(0);
            this.aGauge2.MaxValue = 100F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.Need_Idx = ((byte)(3));
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge2.NeedleEnabled = false;
            this.aGauge2.NeedleRadius = 70;
            this.aGauge2.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge2.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge2.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge2.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge2.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge2.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.Range_Idx = ((byte)(2));
            this.aGauge2.RangeColor = System.Drawing.Color.OrangeRed;
            this.aGauge2.RangeEnabled = false;
            this.aGauge2.RangeEndValue = 50F;
            this.aGauge2.RangeInnerRadius = 1;
            this.aGauge2.RangeOuterRadius = 50;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.OrangeRed,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        70,
        70,
        50,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 35F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesInterInnerRadius = 52;
            this.aGauge2.ScaleLinesInterOuterRadius = 60;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesMajorInnerRadius = 50;
            this.aGauge2.ScaleLinesMajorOuterRadius = 60;
            this.aGauge2.ScaleLinesMajorStepValue = 10F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesMinorInnerRadius = 55;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 60;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 42;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 1;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(121, 121);
            this.aGauge2.TabIndex = 84;
            this.aGauge2.Value = 30F;
            this.aGauge2.Value0 = 10F;
            this.aGauge2.Value1 = 10F;
            this.aGauge2.Value2 = 0F;
            this.aGauge2.Value3 = 30F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(234, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(234, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Port";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 40);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 27);
            this.textBox3.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(308, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Priorità";
            // 
            // btnSend
            // 
            this.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSend.Location = new System.Drawing.Point(312, 233);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(54, 29);
            this.btnSend.TabIndex = 44;
            this.btnSend.Text = "INVIA";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.tbPortNumber);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.rtbChat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mavlinkNumericUpDown2);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(488, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 454);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHAT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbPortNumber
            // 
            this.tbPortNumber.Location = new System.Drawing.Point(15, 79);
            this.tbPortNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPortNumber.MaxLength = 5;
            this.tbPortNumber.Name = "tbPortNumber";
            this.tbPortNumber.Size = new System.Drawing.Size(203, 23);
            this.tbPortNumber.TabIndex = 49;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 146);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(275, 116);
            this.txtMessage.TabIndex = 48;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(15, 271);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(428, 173);
            this.rtbChat.TabIndex = 47;
            this.rtbChat.Text = "";
            // 
            // mavlinkNumericUpDown2
            // 
            this.mavlinkNumericUpDown2.Enabled = false;
            this.mavlinkNumericUpDown2.Location = new System.Drawing.Point(312, 184);
            this.mavlinkNumericUpDown2.Max = 100F;
            this.mavlinkNumericUpDown2.Min = 0F;
            this.mavlinkNumericUpDown2.Name = "mavlinkNumericUpDown2";
            this.mavlinkNumericUpDown2.param = null;
            this.mavlinkNumericUpDown2.ParamName = null;
            this.mavlinkNumericUpDown2.Size = new System.Drawing.Size(122, 23);
            this.mavlinkNumericUpDown2.TabIndex = 45;
            // 
            // imageLabel1
            // 
            this.imageLabel1.Image = global::MissionPlanner.Properties.Resources.CLIENT_SERVER_WHITE;
            this.imageLabel1.Location = new System.Drawing.Point(10, 10);
            this.imageLabel1.Name = "imageLabel1";
            this.imageLabel1.Size = new System.Drawing.Size(117, 109);
            this.imageLabel1.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.label5.Font = new System.Drawing.Font("Stencil Std", 50F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(177, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 88);
            this.label5.TabIndex = 49;
            this.label5.Text = "SERVER";
            // 
            // myButton1
            // 
            this.myButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton1.Location = new System.Drawing.Point(677, 10);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(83, 88);
            this.myButton1.TabIndex = 50;
            this.myButton1.Text = "START";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // mavlinkNumericUpDown1
            // 
            this.mavlinkNumericUpDown1.Location = new System.Drawing.Point(773, 46);
            this.mavlinkNumericUpDown1.Name = "mavlinkNumericUpDown1";
            this.mavlinkNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.mavlinkNumericUpDown1.TabIndex = 59;
            this.mavlinkNumericUpDown1.ValueChanged += new System.EventHandler(this.mavlinkNumericUpDown1_ValueChanged_1);
            this.mavlinkNumericUpDown1.Click += new System.EventHandler(this.mavlinkNumericUpDown1_Click);
            // 
            // myButton2
            // 
            this.myButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton2.Location = new System.Drawing.Point(519, 10);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(83, 88);
            this.myButton2.TabIndex = 60;
            this.myButton2.Text = "Create External Window";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.mavlinkNumericUpDown1);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imageLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SubMainLeft);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1261, 799);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.SubMainLeft.Panel1.ResumeLayout(false);
            this.SubMainLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).EndInit();
            this.SubMainLeft.ResumeLayout(false);
            this.tabControlactions.ResumeLayout(false);
            this.tabQuick.ResumeLayout(false);
            this.tableLayoutPanelQuick.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabGauges.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.SplitContainer SubMainLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown2;
        private Controls.MyButton btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.ImageLabel imageLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox tbPortNumber;
        private System.Windows.Forms.TreeView tvClientList;
        private Controls.MyButton myButton1;
        private System.Windows.Forms.NumericUpDown mavlinkNumericUpDown1;
        public System.Windows.Forms.TabControl tabControlactions;
        public System.Windows.Forms.TabPage tabQuick;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuick;
        public Controls.QuickView quickView6;
        public Controls.QuickView quickView5;
        public Controls.QuickView quickView4;
        public Controls.QuickView quickView3;
        public Controls.QuickView quickView2;
        public Controls.QuickView quickView1;
        public System.Windows.Forms.TabPage tabGauges;
        public AGaugeApp.AGauge aGauge2;
        public AGaugeApp.AGauge aGauge1;
        public AGaugeApp.AGauge Galt;
        public AGaugeApp.AGauge Gspeed;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Controls.MyButton myButton2;
    }
}
