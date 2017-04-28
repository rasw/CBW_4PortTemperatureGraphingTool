namespace CBW_4PortTemperatureGraphingTool
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnRollingGraph = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetGraph = new System.Windows.Forms.Button();
            this.rdoFilterAllData = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast6Months = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast6hrs = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast5Months = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast12hrs = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast4Months = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast24hrs = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast3Months = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast2days = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast2Months = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast5days = new System.Windows.Forms.RadioButton();
            this.rdoFilterLastMonth = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast7days = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast3weeks = new System.Windows.Forms.RadioButton();
            this.rdoFilterLast2weeks = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDataFolderBrowse = new System.Windows.Forms.Button();
            this.txtRootFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDataFiles = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProcessView = new System.Windows.Forms.TabPage();
            this.lblUnitIP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBlowerOutTemperature = new System.Windows.Forms.TextBox();
            this.txtHopperInTemperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPercentageChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCaptureCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTempDelta = new System.Windows.Forms.TextBox();
            this.txtExtTemperature = new System.Windows.Forms.TextBox();
            this.txtAmbientTemperature = new System.Windows.Forms.TextBox();
            this.picProcessView = new System.Windows.Forms.PictureBox();
            this.tabGraphView = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tmrHMI = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProcessView.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessView)).BeginInit();
            this.tabGraphView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnSetup);
            this.panel1.Controls.Add(this.btnRollingGraph);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 116);
            this.panel1.TabIndex = 0;
            // 
            // btnSetup
            // 
            this.btnSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetup.Location = new System.Drawing.Point(1003, 63);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(105, 37);
            this.btnSetup.TabIndex = 5;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnRollingGraph
            // 
            this.btnRollingGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRollingGraph.Enabled = false;
            this.btnRollingGraph.Location = new System.Drawing.Point(1002, 17);
            this.btnRollingGraph.Name = "btnRollingGraph";
            this.btnRollingGraph.Size = new System.Drawing.Size(105, 38);
            this.btnRollingGraph.TabIndex = 4;
            this.btnRollingGraph.Text = "Rolling 1 Hour";
            this.btnRollingGraph.UseVisualStyleBackColor = true;
            this.btnRollingGraph.Click += new System.EventHandler(this.btnRollingGraph_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1131, 62);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(1131, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Save Graph";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetGraph);
            this.groupBox2.Controls.Add(this.rdoFilterAllData);
            this.groupBox2.Controls.Add(this.rdoFilterLast6Months);
            this.groupBox2.Controls.Add(this.rdoFilterLast6hrs);
            this.groupBox2.Controls.Add(this.rdoFilterLast5Months);
            this.groupBox2.Controls.Add(this.rdoFilterLast12hrs);
            this.groupBox2.Controls.Add(this.rdoFilterLast4Months);
            this.groupBox2.Controls.Add(this.rdoFilterLast24hrs);
            this.groupBox2.Controls.Add(this.rdoFilterLast3Months);
            this.groupBox2.Controls.Add(this.rdoFilterLast2days);
            this.groupBox2.Controls.Add(this.rdoFilterLast2Months);
            this.groupBox2.Controls.Add(this.rdoFilterLast5days);
            this.groupBox2.Controls.Add(this.rdoFilterLastMonth);
            this.groupBox2.Controls.Add(this.rdoFilterLast7days);
            this.groupBox2.Controls.Add(this.rdoFilterLast3weeks);
            this.groupBox2.Controls.Add(this.rdoFilterLast2weeks);
            this.groupBox2.Location = new System.Drawing.Point(324, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // btnResetGraph
            // 
            this.btnResetGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetGraph.Enabled = false;
            this.btnResetGraph.Location = new System.Drawing.Point(533, 17);
            this.btnResetGraph.Name = "btnResetGraph";
            this.btnResetGraph.Size = new System.Drawing.Size(85, 26);
            this.btnResetGraph.TabIndex = 47;
            this.btnResetGraph.Text = "Reset Zoom";
            this.btnResetGraph.UseVisualStyleBackColor = true;
            this.btnResetGraph.Click += new System.EventHandler(this.btnResetGraph_Click);
            // 
            // rdoFilterAllData
            // 
            this.rdoFilterAllData.AutoSize = true;
            this.rdoFilterAllData.Location = new System.Drawing.Point(24, 19);
            this.rdoFilterAllData.Name = "rdoFilterAllData";
            this.rdoFilterAllData.Size = new System.Drawing.Size(62, 17);
            this.rdoFilterAllData.TabIndex = 32;
            this.rdoFilterAllData.Text = "All Data";
            this.rdoFilterAllData.UseVisualStyleBackColor = true;
            this.rdoFilterAllData.Click += new System.EventHandler(this.rdoFilterAllData_Click);
            // 
            // rdoFilterLast6Months
            // 
            this.rdoFilterLast6Months.AutoSize = true;
            this.rdoFilterLast6Months.Location = new System.Drawing.Point(424, 64);
            this.rdoFilterLast6Months.Name = "rdoFilterLast6Months";
            this.rdoFilterLast6Months.Size = new System.Drawing.Size(92, 17);
            this.rdoFilterLast6Months.TabIndex = 46;
            this.rdoFilterLast6Months.Text = "Last 6 Months";
            this.rdoFilterLast6Months.UseVisualStyleBackColor = true;
            this.rdoFilterLast6Months.Click += new System.EventHandler(this.rdoFilterLast6Months_Click);
            // 
            // rdoFilterLast6hrs
            // 
            this.rdoFilterLast6hrs.AutoSize = true;
            this.rdoFilterLast6hrs.Location = new System.Drawing.Point(24, 41);
            this.rdoFilterLast6hrs.Name = "rdoFilterLast6hrs";
            this.rdoFilterLast6hrs.Size = new System.Drawing.Size(71, 17);
            this.rdoFilterLast6hrs.TabIndex = 33;
            this.rdoFilterLast6hrs.Text = "Last 6 hrs";
            this.rdoFilterLast6hrs.UseVisualStyleBackColor = true;
            this.rdoFilterLast6hrs.Click += new System.EventHandler(this.rdoFilterLast6hrs_Click);
            // 
            // rdoFilterLast5Months
            // 
            this.rdoFilterLast5Months.AutoSize = true;
            this.rdoFilterLast5Months.Location = new System.Drawing.Point(424, 41);
            this.rdoFilterLast5Months.Name = "rdoFilterLast5Months";
            this.rdoFilterLast5Months.Size = new System.Drawing.Size(92, 17);
            this.rdoFilterLast5Months.TabIndex = 45;
            this.rdoFilterLast5Months.Text = "Last 5 Months";
            this.rdoFilterLast5Months.UseVisualStyleBackColor = true;
            this.rdoFilterLast5Months.Click += new System.EventHandler(this.rdoFilterLast5Months_Click);
            // 
            // rdoFilterLast12hrs
            // 
            this.rdoFilterLast12hrs.AutoSize = true;
            this.rdoFilterLast12hrs.Location = new System.Drawing.Point(24, 64);
            this.rdoFilterLast12hrs.Name = "rdoFilterLast12hrs";
            this.rdoFilterLast12hrs.Size = new System.Drawing.Size(77, 17);
            this.rdoFilterLast12hrs.TabIndex = 34;
            this.rdoFilterLast12hrs.Text = "Last 12 hrs";
            this.rdoFilterLast12hrs.UseVisualStyleBackColor = true;
            this.rdoFilterLast12hrs.Click += new System.EventHandler(this.rdoFilterLast12hrs_Click);
            // 
            // rdoFilterLast4Months
            // 
            this.rdoFilterLast4Months.AutoSize = true;
            this.rdoFilterLast4Months.BackColor = System.Drawing.Color.Gainsboro;
            this.rdoFilterLast4Months.Location = new System.Drawing.Point(424, 19);
            this.rdoFilterLast4Months.Name = "rdoFilterLast4Months";
            this.rdoFilterLast4Months.Size = new System.Drawing.Size(92, 17);
            this.rdoFilterLast4Months.TabIndex = 44;
            this.rdoFilterLast4Months.Text = "Last 4 Months";
            this.rdoFilterLast4Months.UseVisualStyleBackColor = false;
            this.rdoFilterLast4Months.Click += new System.EventHandler(this.rdoFilterLast4Months_Click);
            // 
            // rdoFilterLast24hrs
            // 
            this.rdoFilterLast24hrs.AutoSize = true;
            this.rdoFilterLast24hrs.Checked = true;
            this.rdoFilterLast24hrs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoFilterLast24hrs.Location = new System.Drawing.Point(112, 19);
            this.rdoFilterLast24hrs.Name = "rdoFilterLast24hrs";
            this.rdoFilterLast24hrs.Size = new System.Drawing.Size(77, 17);
            this.rdoFilterLast24hrs.TabIndex = 35;
            this.rdoFilterLast24hrs.TabStop = true;
            this.rdoFilterLast24hrs.Text = "Last 24 hrs";
            this.rdoFilterLast24hrs.UseVisualStyleBackColor = true;
            this.rdoFilterLast24hrs.Click += new System.EventHandler(this.rdoFilterLast24hrs_Click);
            // 
            // rdoFilterLast3Months
            // 
            this.rdoFilterLast3Months.AutoSize = true;
            this.rdoFilterLast3Months.Location = new System.Drawing.Point(320, 64);
            this.rdoFilterLast3Months.Name = "rdoFilterLast3Months";
            this.rdoFilterLast3Months.Size = new System.Drawing.Size(92, 17);
            this.rdoFilterLast3Months.TabIndex = 43;
            this.rdoFilterLast3Months.Text = "Last 3 Months";
            this.rdoFilterLast3Months.UseVisualStyleBackColor = true;
            this.rdoFilterLast3Months.Click += new System.EventHandler(this.rdoFilterLast3Months_Click);
            // 
            // rdoFilterLast2days
            // 
            this.rdoFilterLast2days.AutoSize = true;
            this.rdoFilterLast2days.Location = new System.Drawing.Point(112, 41);
            this.rdoFilterLast2days.Name = "rdoFilterLast2days";
            this.rdoFilterLast2days.Size = new System.Drawing.Size(79, 17);
            this.rdoFilterLast2days.TabIndex = 36;
            this.rdoFilterLast2days.Text = "Last 2 days";
            this.rdoFilterLast2days.UseVisualStyleBackColor = true;
            this.rdoFilterLast2days.Click += new System.EventHandler(this.rdoFilterLast2days_Click);
            // 
            // rdoFilterLast2Months
            // 
            this.rdoFilterLast2Months.AutoSize = true;
            this.rdoFilterLast2Months.Location = new System.Drawing.Point(320, 41);
            this.rdoFilterLast2Months.Name = "rdoFilterLast2Months";
            this.rdoFilterLast2Months.Size = new System.Drawing.Size(92, 17);
            this.rdoFilterLast2Months.TabIndex = 42;
            this.rdoFilterLast2Months.Text = "Last 2 Months";
            this.rdoFilterLast2Months.UseVisualStyleBackColor = true;
            this.rdoFilterLast2Months.Click += new System.EventHandler(this.rdoFilterLast2Months_Click);
            // 
            // rdoFilterLast5days
            // 
            this.rdoFilterLast5days.AutoSize = true;
            this.rdoFilterLast5days.Location = new System.Drawing.Point(112, 64);
            this.rdoFilterLast5days.Name = "rdoFilterLast5days";
            this.rdoFilterLast5days.Size = new System.Drawing.Size(79, 17);
            this.rdoFilterLast5days.TabIndex = 37;
            this.rdoFilterLast5days.Text = "Last 5 days";
            this.rdoFilterLast5days.UseVisualStyleBackColor = true;
            this.rdoFilterLast5days.Click += new System.EventHandler(this.rdoFilterLast5days_Click);
            // 
            // rdoFilterLastMonth
            // 
            this.rdoFilterLastMonth.AutoSize = true;
            this.rdoFilterLastMonth.Location = new System.Drawing.Point(320, 19);
            this.rdoFilterLastMonth.Name = "rdoFilterLastMonth";
            this.rdoFilterLastMonth.Size = new System.Drawing.Size(78, 17);
            this.rdoFilterLastMonth.TabIndex = 41;
            this.rdoFilterLastMonth.Text = "Last Month";
            this.rdoFilterLastMonth.UseVisualStyleBackColor = true;
            this.rdoFilterLastMonth.Click += new System.EventHandler(this.rdoFilterLastMonth_Click);
            // 
            // rdoFilterLast7days
            // 
            this.rdoFilterLast7days.AutoSize = true;
            this.rdoFilterLast7days.Location = new System.Drawing.Point(215, 19);
            this.rdoFilterLast7days.Name = "rdoFilterLast7days";
            this.rdoFilterLast7days.Size = new System.Drawing.Size(79, 17);
            this.rdoFilterLast7days.TabIndex = 38;
            this.rdoFilterLast7days.Text = "Last 7 days";
            this.rdoFilterLast7days.UseVisualStyleBackColor = true;
            this.rdoFilterLast7days.Click += new System.EventHandler(this.rdoFilterLast7days_Click);
            // 
            // rdoFilterLast3weeks
            // 
            this.rdoFilterLast3weeks.AutoSize = true;
            this.rdoFilterLast3weeks.Location = new System.Drawing.Point(215, 64);
            this.rdoFilterLast3weeks.Name = "rdoFilterLast3weeks";
            this.rdoFilterLast3weeks.Size = new System.Drawing.Size(88, 17);
            this.rdoFilterLast3weeks.TabIndex = 40;
            this.rdoFilterLast3weeks.Text = "Last 3 weeks";
            this.rdoFilterLast3weeks.UseVisualStyleBackColor = true;
            this.rdoFilterLast3weeks.Click += new System.EventHandler(this.rdoFilterLast3weeks_Click);
            // 
            // rdoFilterLast2weeks
            // 
            this.rdoFilterLast2weeks.AutoSize = true;
            this.rdoFilterLast2weeks.Location = new System.Drawing.Point(215, 41);
            this.rdoFilterLast2weeks.Name = "rdoFilterLast2weeks";
            this.rdoFilterLast2weeks.Size = new System.Drawing.Size(88, 17);
            this.rdoFilterLast2weeks.TabIndex = 39;
            this.rdoFilterLast2weeks.Text = "Last 2 weeks";
            this.rdoFilterLast2weeks.UseVisualStyleBackColor = true;
            this.rdoFilterLast2weeks.Click += new System.EventHandler(this.rdoFilterLast2weeks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDataFolderBrowse);
            this.groupBox1.Controls.Add(this.txtRootFolderPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDataFiles);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Data File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Folder:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDataFolderBrowse
            // 
            this.btnDataFolderBrowse.Location = new System.Drawing.Point(254, 22);
            this.btnDataFolderBrowse.Name = "btnDataFolderBrowse";
            this.btnDataFolderBrowse.Size = new System.Drawing.Size(28, 23);
            this.btnDataFolderBrowse.TabIndex = 3;
            this.btnDataFolderBrowse.Text = "...";
            this.btnDataFolderBrowse.UseVisualStyleBackColor = true;
            this.btnDataFolderBrowse.Click += new System.EventHandler(this.btnDataFolderBrowse_Click);
            // 
            // txtRootFolderPath
            // 
            this.txtRootFolderPath.Location = new System.Drawing.Point(77, 23);
            this.txtRootFolderPath.Name = "txtRootFolderPath";
            this.txtRootFolderPath.Size = new System.Drawing.Size(173, 20);
            this.txtRootFolderPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDataFiles
            // 
            this.cmbDataFiles.FormattingEnabled = true;
            this.cmbDataFiles.Location = new System.Drawing.Point(77, 51);
            this.cmbDataFiles.Name = "cmbDataFiles";
            this.cmbDataFiles.Size = new System.Drawing.Size(205, 21);
            this.cmbDataFiles.TabIndex = 0;
            this.cmbDataFiles.SelectedIndexChanged += new System.EventHandler(this.cmbDataFiles_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabProcessView);
            this.tabControl1.Controls.Add(this.tabGraphView);
            this.tabControl1.Location = new System.Drawing.Point(3, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1259, 633);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabProcessView
            // 
            this.tabProcessView.Controls.Add(this.lblUnitIP);
            this.tabProcessView.Controls.Add(this.panel2);
            this.tabProcessView.Controls.Add(this.txtPercentageChange);
            this.tabProcessView.Controls.Add(this.label7);
            this.tabProcessView.Controls.Add(this.lblCaptureCount);
            this.tabProcessView.Controls.Add(this.label5);
            this.tabProcessView.Controls.Add(this.txtTempDelta);
            this.tabProcessView.Controls.Add(this.txtExtTemperature);
            this.tabProcessView.Controls.Add(this.txtAmbientTemperature);
            this.tabProcessView.Controls.Add(this.picProcessView);
            this.tabProcessView.Location = new System.Drawing.Point(4, 22);
            this.tabProcessView.Name = "tabProcessView";
            this.tabProcessView.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcessView.Size = new System.Drawing.Size(1251, 607);
            this.tabProcessView.TabIndex = 1;
            this.tabProcessView.Text = "Process View";
            this.tabProcessView.UseVisualStyleBackColor = true;
            // 
            // lblUnitIP
            // 
            this.lblUnitIP.AutoSize = true;
            this.lblUnitIP.Location = new System.Drawing.Point(1108, 552);
            this.lblUnitIP.Name = "lblUnitIP";
            this.lblUnitIP.Size = new System.Drawing.Size(90, 13);
            this.lblUnitIP.TabIndex = 16;
            this.lblUnitIP.Text = "Unit IP: ---.---.---.---";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBlowerOutTemperature);
            this.panel2.Controls.Add(this.txtHopperInTemperature);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(691, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 145);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "External Temperature:";
            // 
            // txtBlowerOutTemperature
            // 
            this.txtBlowerOutTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBlowerOutTemperature.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBlowerOutTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlowerOutTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlowerOutTemperature.ForeColor = System.Drawing.Color.Black;
            this.txtBlowerOutTemperature.Location = new System.Drawing.Point(410, 73);
            this.txtBlowerOutTemperature.Name = "txtBlowerOutTemperature";
            this.txtBlowerOutTemperature.Size = new System.Drawing.Size(130, 33);
            this.txtBlowerOutTemperature.TabIndex = 1;
            this.txtBlowerOutTemperature.Text = "- - -";
            this.txtBlowerOutTemperature.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHopperInTemperature
            // 
            this.txtHopperInTemperature.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHopperInTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHopperInTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHopperInTemperature.ForeColor = System.Drawing.Color.Black;
            this.txtHopperInTemperature.Location = new System.Drawing.Point(410, 22);
            this.txtHopperInTemperature.Name = "txtHopperInTemperature";
            this.txtHopperInTemperature.Size = new System.Drawing.Size(130, 33);
            this.txtHopperInTemperature.TabIndex = 2;
            this.txtHopperInTemperature.Text = "- - -";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ambient Temperature:";
            // 
            // txtPercentageChange
            // 
            this.txtPercentageChange.BackColor = System.Drawing.Color.White;
            this.txtPercentageChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPercentageChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentageChange.ForeColor = System.Drawing.Color.Black;
            this.txtPercentageChange.Location = new System.Drawing.Point(768, 267);
            this.txtPercentageChange.Name = "txtPercentageChange";
            this.txtPercentageChange.Size = new System.Drawing.Size(96, 31);
            this.txtPercentageChange.TabIndex = 12;
            this.txtPercentageChange.Text = "- - -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(551, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cooling Efficiency:";
            // 
            // lblCaptureCount
            // 
            this.lblCaptureCount.AutoSize = true;
            this.lblCaptureCount.Location = new System.Drawing.Point(1109, 570);
            this.lblCaptureCount.Name = "lblCaptureCount";
            this.lblCaptureCount.Size = new System.Drawing.Size(22, 13);
            this.lblCaptureCount.TabIndex = 10;
            this.lblCaptureCount.Text = "- - -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(454, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cooling Temperature Drop:";
            // 
            // txtTempDelta
            // 
            this.txtTempDelta.BackColor = System.Drawing.Color.White;
            this.txtTempDelta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTempDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempDelta.ForeColor = System.Drawing.Color.Black;
            this.txtTempDelta.Location = new System.Drawing.Point(768, 236);
            this.txtTempDelta.Name = "txtTempDelta";
            this.txtTempDelta.Size = new System.Drawing.Size(96, 31);
            this.txtTempDelta.TabIndex = 7;
            this.txtTempDelta.Text = "- - -";
            // 
            // txtExtTemperature
            // 
            this.txtExtTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtTemperature.BackColor = System.Drawing.Color.White;
            this.txtExtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtTemperature.ForeColor = System.Drawing.Color.Black;
            this.txtExtTemperature.Location = new System.Drawing.Point(789, 403);
            this.txtExtTemperature.Name = "txtExtTemperature";
            this.txtExtTemperature.Size = new System.Drawing.Size(107, 40);
            this.txtExtTemperature.TabIndex = 6;
            this.txtExtTemperature.Text = "- - -";
            this.txtExtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmbientTemperature
            // 
            this.txtAmbientTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmbientTemperature.BackColor = System.Drawing.Color.White;
            this.txtAmbientTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmbientTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmbientTemperature.ForeColor = System.Drawing.Color.Black;
            this.txtAmbientTemperature.Location = new System.Drawing.Point(328, 402);
            this.txtAmbientTemperature.Name = "txtAmbientTemperature";
            this.txtAmbientTemperature.Size = new System.Drawing.Size(122, 40);
            this.txtAmbientTemperature.TabIndex = 5;
            this.txtAmbientTemperature.Text = "- - -";
            this.txtAmbientTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picProcessView
            // 
            this.picProcessView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picProcessView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picProcessView.Image = global::CBW_4PortTemperatureGraphingTool.Properties.Resources.CBW_SystemGraphic3;
            this.picProcessView.Location = new System.Drawing.Point(3, 9);
            this.picProcessView.Name = "picProcessView";
            this.picProcessView.Size = new System.Drawing.Size(1240, 591);
            this.picProcessView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProcessView.TabIndex = 0;
            this.picProcessView.TabStop = false;
            // 
            // tabGraphView
            // 
            this.tabGraphView.Controls.Add(this.chart1);
            this.tabGraphView.Location = new System.Drawing.Point(4, 22);
            this.tabGraphView.Name = "tabGraphView";
            this.tabGraphView.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraphView.Size = new System.Drawing.Size(1251, 607);
            this.tabGraphView.TabIndex = 0;
            this.tabGraphView.Text = "Temperatures Graph";
            this.tabGraphView.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1237, 591);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(936, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 47);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "- - -";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(951, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 40);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "- - -";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(951, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 40);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "- - -";
            // 
            // tmrHMI
            // 
            this.tmrHMI.Interval = 2000;
            this.tmrHMI.Tick += new System.EventHandler(this.tmrHMI_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "CBW 4 Port Temperature Module Graphing Tool...";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabProcessView.ResumeLayout(false);
            this.tabProcessView.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessView)).EndInit();
            this.tabGraphView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGraphView;
        private System.Windows.Forms.TabPage tabProcessView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDataFolderBrowse;
        private System.Windows.Forms.TextBox txtRootFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDataFiles;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResetGraph;
        private System.Windows.Forms.RadioButton rdoFilterAllData;
        private System.Windows.Forms.RadioButton rdoFilterLast6Months;
        private System.Windows.Forms.RadioButton rdoFilterLast6hrs;
        private System.Windows.Forms.RadioButton rdoFilterLast5Months;
        private System.Windows.Forms.RadioButton rdoFilterLast12hrs;
        private System.Windows.Forms.RadioButton rdoFilterLast4Months;
        private System.Windows.Forms.RadioButton rdoFilterLast24hrs;
        private System.Windows.Forms.RadioButton rdoFilterLast3Months;
        private System.Windows.Forms.RadioButton rdoFilterLast2days;
        private System.Windows.Forms.RadioButton rdoFilterLast2Months;
        private System.Windows.Forms.RadioButton rdoFilterLast5days;
        private System.Windows.Forms.RadioButton rdoFilterLastMonth;
        private System.Windows.Forms.RadioButton rdoFilterLast7days;
        private System.Windows.Forms.RadioButton rdoFilterLast3weeks;
        private System.Windows.Forms.RadioButton rdoFilterLast2weeks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnRollingGraph;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtBlowerOutTemperature;
        private System.Windows.Forms.PictureBox picProcessView;
        private System.Windows.Forms.TextBox txtExtTemperature;
        private System.Windows.Forms.TextBox txtAmbientTemperature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHopperInTemperature;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Timer tmrHMI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTempDelta;
        private System.Windows.Forms.Label lblCaptureCount;
        private System.Windows.Forms.TextBox txtPercentageChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUnitIP;
    }
}

