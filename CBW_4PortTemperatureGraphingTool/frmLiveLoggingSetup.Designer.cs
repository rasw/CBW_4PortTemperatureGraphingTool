namespace CBW_4PortTemperatureGraphingTool
{
    partial class frmLiveLoggingSetup
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txIpAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSensor4Name = new System.Windows.Forms.TextBox();
            this.txtSensor3Name = new System.Windows.Forms.TextBox();
            this.txtSensor2Name = new System.Windows.Forms.TextBox();
            this.txtSensor1Name = new System.Windows.Forms.TextBox();
            this.txtSensor4Reading = new System.Windows.Forms.TextBox();
            this.txtSensor3Reading = new System.Windows.Forms.TextBox();
            this.txtSensor2Reading = new System.Windows.Forms.TextBox();
            this.txtSensor1Reading = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrLogTimer = new System.Windows.Forms.Timer(this.components);
            this.lblReadCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numUpDwnSampleRate = new System.Windows.Forms.NumericUpDown();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnSampleRate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numUpDwnSampleRate);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtPassword);
            this.groupBox4.Controls.Add(this.txtPort);
            this.groupBox4.Controls.Add(this.txIpAddress);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 146);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Temperature Module Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(126, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "admin";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(99, 53);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(51, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "80";
            this.txtPort.Leave += new System.EventHandler(this.txtPort_Leave);
            // 
            // txIpAddress
            // 
            this.txIpAddress.Location = new System.Drawing.Point(99, 27);
            this.txIpAddress.Name = "txIpAddress";
            this.txIpAddress.Size = new System.Drawing.Size(126, 20);
            this.txIpAddress.TabIndex = 0;
            this.txIpAddress.Leave += new System.EventHandler(this.txIpAddress_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Port:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "IP Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtSensor4Name);
            this.groupBox1.Controls.Add(this.txtSensor3Name);
            this.groupBox1.Controls.Add(this.txtSensor2Name);
            this.groupBox1.Controls.Add(this.txtSensor1Name);
            this.groupBox1.Controls.Add(this.txtSensor4Reading);
            this.groupBox1.Controls.Add(this.txtSensor3Reading);
            this.groupBox1.Controls.Add(this.txtSensor2Reading);
            this.groupBox1.Controls.Add(this.txtSensor1Reading);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 162);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Sensor Readings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "o";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "o";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "o";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(261, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "C";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(253, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "o";
            // 
            // txtSensor4Name
            // 
            this.txtSensor4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor4Name.Location = new System.Drawing.Point(22, 124);
            this.txtSensor4Name.Name = "txtSensor4Name";
            this.txtSensor4Name.Size = new System.Drawing.Size(165, 26);
            this.txtSensor4Name.TabIndex = 6;
            this.txtSensor4Name.Text = "Sensor 4";
            this.txtSensor4Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSensor3Name
            // 
            this.txtSensor3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor3Name.Location = new System.Drawing.Point(22, 90);
            this.txtSensor3Name.Name = "txtSensor3Name";
            this.txtSensor3Name.Size = new System.Drawing.Size(165, 26);
            this.txtSensor3Name.TabIndex = 4;
            this.txtSensor3Name.Text = "Sensor 3";
            this.txtSensor3Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSensor2Name
            // 
            this.txtSensor2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor2Name.Location = new System.Drawing.Point(22, 57);
            this.txtSensor2Name.Name = "txtSensor2Name";
            this.txtSensor2Name.Size = new System.Drawing.Size(165, 26);
            this.txtSensor2Name.TabIndex = 2;
            this.txtSensor2Name.Text = "Sensor 2";
            this.txtSensor2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSensor1Name
            // 
            this.txtSensor1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor1Name.Location = new System.Drawing.Point(22, 24);
            this.txtSensor1Name.Name = "txtSensor1Name";
            this.txtSensor1Name.Size = new System.Drawing.Size(165, 26);
            this.txtSensor1Name.TabIndex = 0;
            this.txtSensor1Name.Text = "Sensor 1";
            this.txtSensor1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSensor4Reading
            // 
            this.txtSensor4Reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor4Reading.Location = new System.Drawing.Point(194, 124);
            this.txtSensor4Reading.Name = "txtSensor4Reading";
            this.txtSensor4Reading.Size = new System.Drawing.Size(52, 26);
            this.txtSensor4Reading.TabIndex = 7;
            this.txtSensor4Reading.TabStop = false;
            this.txtSensor4Reading.Text = "xx.x";
            // 
            // txtSensor3Reading
            // 
            this.txtSensor3Reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor3Reading.Location = new System.Drawing.Point(193, 90);
            this.txtSensor3Reading.Name = "txtSensor3Reading";
            this.txtSensor3Reading.Size = new System.Drawing.Size(53, 26);
            this.txtSensor3Reading.TabIndex = 5;
            this.txtSensor3Reading.TabStop = false;
            this.txtSensor3Reading.Text = "xx.x";
            // 
            // txtSensor2Reading
            // 
            this.txtSensor2Reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor2Reading.Location = new System.Drawing.Point(192, 57);
            this.txtSensor2Reading.Name = "txtSensor2Reading";
            this.txtSensor2Reading.Size = new System.Drawing.Size(54, 26);
            this.txtSensor2Reading.TabIndex = 3;
            this.txtSensor2Reading.TabStop = false;
            this.txtSensor2Reading.Text = "xx.x";
            // 
            // txtSensor1Reading
            // 
            this.txtSensor1Reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensor1Reading.Location = new System.Drawing.Point(193, 24);
            this.txtSensor1Reading.Name = "txtSensor1Reading";
            this.txtSensor1Reading.Size = new System.Drawing.Size(53, 26);
            this.txtSensor1Reading.TabIndex = 1;
            this.txtSensor1Reading.TabStop = false;
            this.txtSensor1Reading.Text = "xx.x";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(334, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Enabled = false;
            this.btnTestConnection.Location = new System.Drawing.Point(334, 24);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(143, 32);
            this.btnTestConnection.TabIndex = 0;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(334, 69);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(143, 32);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmrLogTimer
            // 
            this.tmrLogTimer.Interval = 3000;
            this.tmrLogTimer.Tick += new System.EventHandler(this.tmrLogTimer_Tick);
            // 
            // lblReadCounter
            // 
            this.lblReadCounter.Location = new System.Drawing.Point(334, 151);
            this.lblReadCounter.Name = "lblReadCounter";
            this.lblReadCounter.Size = new System.Drawing.Size(143, 23);
            this.lblReadCounter.TabIndex = 13;
            this.lblReadCounter.Text = "Read Counter: - - -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sample Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Seconds";
            // 
            // numUpDwnSampleRate
            // 
            this.numUpDwnSampleRate.Location = new System.Drawing.Point(99, 110);
            this.numUpDwnSampleRate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numUpDwnSampleRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwnSampleRate.Name = "numUpDwnSampleRate";
            this.numUpDwnSampleRate.Size = new System.Drawing.Size(56, 20);
            this.numUpDwnSampleRate.TabIndex = 8;
            this.numUpDwnSampleRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwnSampleRate.ValueChanged += new System.EventHandler(this.numUpDwnSampleRate_ValueChanged);
            // 
            // frmLiveLoggingSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 341);
            this.Controls.Add(this.lblReadCounter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmLiveLoggingSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Logging Setup...";
            this.Load += new System.EventHandler(this.frmLiveLoggingSetup_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnSampleRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txIpAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSensor4Name;
        private System.Windows.Forms.TextBox txtSensor3Name;
        private System.Windows.Forms.TextBox txtSensor2Name;
        private System.Windows.Forms.TextBox txtSensor1Name;
        private System.Windows.Forms.TextBox txtSensor4Reading;
        private System.Windows.Forms.TextBox txtSensor3Reading;
        private System.Windows.Forms.TextBox txtSensor2Reading;
        private System.Windows.Forms.TextBox txtSensor1Reading;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrLogTimer;
        private System.Windows.Forms.Label lblReadCounter;
        private System.Windows.Forms.NumericUpDown numUpDwnSampleRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}