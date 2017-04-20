﻿namespace CBW_4PortTemperatureGraphingTool
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.tabGraphView = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabProcessView = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGraphView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 116);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1085, 62);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(1085, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
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
            this.rdoFilterAllData.CheckedChanged += new System.EventHandler(this.rdoFilterAllData_CheckedChanged);
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
            this.tabControl1.Controls.Add(this.tabGraphView);
            this.tabControl1.Controls.Add(this.tabProcessView);
            this.tabControl1.Location = new System.Drawing.Point(3, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1259, 633);
            this.tabControl1.TabIndex = 1;
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
            this.chart1.Size = new System.Drawing.Size(990, 591);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabProcessView
            // 
            this.tabProcessView.Location = new System.Drawing.Point(4, 22);
            this.tabProcessView.Name = "tabProcessView";
            this.tabProcessView.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcessView.Size = new System.Drawing.Size(1251, 607);
            this.tabProcessView.TabIndex = 1;
            this.tabProcessView.Text = "Process View";
            this.tabProcessView.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "CBW 4 Port Temperature Module Graphing Tool...";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
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
    }
}
