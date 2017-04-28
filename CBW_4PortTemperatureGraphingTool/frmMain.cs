using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkvaData;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Collections;
using System.Net.Sockets;

namespace CBW_4PortTemperatureGraphingTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string selectedFileFullPath = null;
        string selectedRootFolder = null;
        List<string> coreFileData;
        bool showGradBackground = true;
        bool timerRunning = false;

        double deltaTvalue = 0;
        double blowerOutTemperature = 0;
        double doserInTemperature = 0;
        int captureCount = 0;
        string unitIPAddress = null;

        Timer rollingMins;

        enum FilterPeriod : int
        {
            All = 500,
            SixHrs = 10,
            TweleveHrs = 15,
            TwentyFourHrs = 35,
            TwoDays = 50,
            FiveDays = 80,
            SevenDays = 100,
            TwoWeeks = 120,
            ThreeWeeks = 150,
            OneMonth = 170,
            TwoMonths = 250,
            ThreeMonths = 280,
            FourMonths = 290,
            FiveMonths = 300,
            SixMonths = 300
        };  //**


        private DateTime GetFilterFromDateTime()
        {
            DateTime dtNow = DateTime.Now;
            DateTime dtFilter = DateTime.Now.AddYears(-10);

            if (rdoFilterAllData.Checked) { dtFilter = dtNow.AddYears(-10); }
            if (rdoFilterLast6hrs.Checked) { dtFilter = dtNow.AddHours(-6); }
            if (rdoFilterLast12hrs.Checked) { dtFilter = dtNow.AddHours(-12); }
            if (rdoFilterLast24hrs.Checked) { dtFilter = dtNow.AddDays(-1); }
            if (rdoFilterLast2days.Checked) { dtFilter = dtNow.AddDays(-2); }
            if (rdoFilterLast5days.Checked) { dtFilter = dtNow.AddDays(-5); }
            if (rdoFilterLast7days.Checked) { dtFilter = dtNow.AddDays(-7); }
            if (rdoFilterLast2weeks.Checked) { dtFilter = dtNow.AddDays(-14); }
            if (rdoFilterLast3weeks.Checked) { dtFilter = dtNow.AddDays(-21); }
            if (rdoFilterLastMonth.Checked) { dtFilter = dtNow.AddMonths(-1); }
            if (rdoFilterLast2Months.Checked) { dtFilter = dtNow.AddMonths(-2); }
            if (rdoFilterLast3Months.Checked) { dtFilter = dtNow.AddMonths(-3); }
            if (rdoFilterLast4Months.Checked) { dtFilter = dtNow.AddMonths(-4); }
            if (rdoFilterLast5Months.Checked) { dtFilter = dtNow.AddMonths(-5); }
            if (rdoFilterLast6Months.Checked) { dtFilter = dtNow.AddMonths(-6); }

            return dtFilter;
        }

        private string ConvertENtoUSDate(string UKdate)
        {
            string[] d2 = UKdate.Split(' '); // split off date and time
            string[] d3 = d2[0].Split('/');

            return d3[1] + "-" + d3[0] + "-" + d3[2] + " " + d2[1];
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSettings();

            rollingMins = new Timer();
            rollingMins.Tick += RollingMins_Tick;
            rollingMins.Interval = 60000;
            rollingMins.Stop();

            EnableDisableALL(false);
            tmrHMI.Start();
            captureCount = 0;
        }

        private void RollingMins_Tick(object sender, EventArgs e)
        {
            DateTime halfHourAgo = DateTime.Now.AddHours(-1);
            DrawGraph(coreFileData, (int)FilterPeriod.SixHrs, halfHourAgo, DateTime.Now);
        }

        private void btnDataFolderBrowse_Click(object sender, EventArgs e)
        {
            AppSettings appSet = new AppSettings(Path.Combine(Directory.GetCurrentDirectory(), "CBW4PortTempGraphingTool.xml"));
            FolderBrowserDialog fb1 = new FolderBrowserDialog();
            string root = appSet.getValue("RootDataFolder");
            if (root.Length == 0)
            {
                appSet.setValue("RootDataFolder", @"C:\AkvaData\Data");
            }

            fb1.SelectedPath = appSet.getValue("RootDataFolder");
         
            DialogResult result = fb1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRootFolderPath.Text = fb1.SelectedPath;
                appSet.setValue("RootDataFolder", fb1.SelectedPath);        //save selected root path to settings
                selectedRootFolder = fb1.SelectedPath;

                if(selectedRootFolder == null)
                {
                    selectedRootFolder = appSet.getValue("RootDataFolder");
                }

                foreach (var file in Directory.GetFiles(fb1.SelectedPath))
                {
                    cmbDataFiles.Items.Add(Path.GetFileName(file));
                }              
            }
        }

        void DrawGraph(List<string> coreDataLines, int XAxisLabelPeriod, DateTime GraphFromDT, DateTime GraphToDT)
        {
            try
            {
                GetCBWMinMaxValues gmm = new GetCBWMinMaxValues();
                double maxValue = gmm.GetMax(coreDataLines);
                double minValue = gmm.GetMin(coreDataLines);

                var series1 = new Series
                {
                    Name = "Sensor1", Color = Color.Red, IsVisibleInLegend = true, IsXValueIndexed = true, ChartType = SeriesChartType.Line
                };

                var series2 = new Series
                {
                    Name = "Sensor2", Color = Color.Green, IsVisibleInLegend = true, IsXValueIndexed = true, ChartType = SeriesChartType.Line
                };

                var series3 = new Series
                {
                    Name = "Sensor3", Color = Color.Blue, IsVisibleInLegend = true, IsXValueIndexed = true, ChartType = SeriesChartType.Line
                };

                var series4 = new Series
                {
                    Name = "Sensor4", Color = Color.Orange, IsVisibleInLegend = true, IsXValueIndexed = true, ChartType = SeriesChartType.Line
                };

                chart1.Series.Clear();

                chart1.Series.Add("Sensor1");
                chart1.Series.Add("Sensor2");
                chart1.Series.Add("Sensor3");
                chart1.Series.Add("Sensor4");

                chart1.Series["Sensor1"].BorderWidth = 2;
                chart1.Series["Sensor2"].BorderWidth = 2;
                chart1.Series["Sensor3"].BorderWidth = 2;
                chart1.Series["Sensor4"].BorderWidth = 2;

                chart1.ChartAreas[0].AxisX.LabelStyle.Interval = XAxisLabelPeriod;
                chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Verdana", 10, FontStyle.Regular);    // set font style for Y axis values
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0.00}";    // Format Y axis to 2 decimal places.

                this.chart1.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
                //this.chart1.ChartAreas["ChartArea1"].CursorY.IsUserEnabled = true;
                this.chart1.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
                // this.chart1.ChartAreas["ChartArea1"].CursorY.IsUserSelectionEnabled = true;
                this.chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
                //this.chart1.ChartAreas["ChartArea1"].AxisY.ScaleView.Zoomable = true;
                this.chart1.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
                //this.chart1.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;

                if (showGradBackground)
                {
                    chart1.ChartAreas[0].BackGradientStyle = GradientStyle.TopBottom;
                    chart1.ChartAreas[0].BackColor = Color.FromArgb(100, 255, 255, 255);
                    chart1.ChartAreas[0].BackSecondaryColor = Color.FromArgb(130, 220, 220, 250);
                }
                else
                {
                    chart1.ChartAreas[0].BackGradientStyle = GradientStyle.TopBottom;
                    chart1.ChartAreas[0].BackColor = Color.FromArgb(255, 255, 255, 255);
                    chart1.ChartAreas[0].BackSecondaryColor = Color.FromArgb(255, 255, 255, 255);
                }

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = minValue - 0.1;
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = maxValue + 0.1;

                chart1.Series["Sensor1"].ChartType = SeriesChartType.Line;
                chart1.Series["Sensor2"].ChartType = SeriesChartType.Line;
                chart1.Series["Sensor3"].ChartType = SeriesChartType.Line;
                chart1.Series["Sensor4"].ChartType = SeriesChartType.Line;


                // 18/04/2017 10:50:19|19.5|19.2|19.7|19.4
                ArrayList splitData = new ArrayList();

                // void DrawGraph(List<string> coreDataLines, int XAxisLabelPeriod, DateTime GraphFromDT, DateTime GraphToDT)

                foreach (var line in coreDataLines)
                {
                    string[] d = line.Split('|');
                    splitData.Add(d[0]);        // Reading DateTime
                    splitData.Add(d[1]);        // Sensor 1 Reading
                    splitData.Add(d[2]);        // Sensor 2 Reading
                    splitData.Add(d[3]);        // Sensor 3 Reading
                    splitData.Add(d[4]);        // Sensor 4 Reading

                    if (Convert.ToDateTime(d[0]) >= GraphFromDT && Convert.ToDateTime(d[0]) <= GraphToDT)
                    {
                        string[] dt = d[0].Split(' ');

                        chart1.Series["Sensor1"].Points.AddXY(dt[1], d[1]);
                        chart1.Series["Sensor2"].Points.AddXY(dt[1], d[2]);
                        chart1.Series["Sensor3"].Points.AddXY(dt[1], d[3]);
                        chart1.Series["Sensor4"].Points.AddXY(dt[1], d[4]); 
                    }
                }

                chart1.Invalidate();  // draw chart
            }
            catch (Exception ex)
            {
                Logger.WriteToLog("DrawGraph -> " + ex.Message);
            }
        }

        private void cmbDataFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFileFullPath = Path.Combine(selectedRootFolder, cmbDataFiles.Text);
            LoadCoreFileData(selectedFileFullPath);
            btnRollingGraph.Enabled = true;
            btnRefresh.Enabled = true;
        }

        private void LoadCoreFileData(string selectedFileFullPath)
        {
            // Read all the data lines into memory
            //    List<string> coreFileData = new List<string>();

            // 18/04/2017 10:50:19|19.5|19.2|19.7|19.4
            var dataFile = File.ReadAllLines(selectedFileFullPath);      // read logfile lines into a list
            //List<string> coreFileData = new List<string>(dataFile);
            coreFileData = new List<string>(dataFile);
            DrawGraph(coreFileData, 20, DateTime.Now.AddYears(-10), DateTime.Now);
        }

        private void rdoFilterAllData_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int)FilterPeriod.All ,from,DateTime.Now);
        }

        private void rdoFilterLast6hrs_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int) FilterPeriod.SixHrs, from, DateTime.Now);
        }

        private void rdoFilterLast12hrs_Click(object sender, EventArgs e)
        {
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int)FilterPeriod.TweleveHrs, from, DateTime.Now);
        }

        private void rdoFilterLast24hrs_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData,(int)FilterPeriod.TwentyFourHrs, from, DateTime.Now);
        }

        private void rdoFilterLast2days_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData,(int)FilterPeriod.TwoDays, from, DateTime.Now);
        }

        private void rdoFilterLast5days_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int) FilterPeriod.FiveDays, from, DateTime.Now);
        }

        private void rdoFilterLast7days_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int)FilterPeriod.SevenDays, from, DateTime.Now);
        }

        private void rdoFilterLast2weeks_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int) FilterPeriod.TwoWeeks, from, DateTime.Now);
        }

        private void rdoFilterLast3weeks_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int)FilterPeriod.ThreeWeeks, from, DateTime.Now);
        }

        private void rdoFilterLastMonth_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int)FilterPeriod.OneMonth, from, DateTime.Now);
        }

        private void rdoFilterLast2Months_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int)FilterPeriod.TwoMonths, from, DateTime.Now);
        }

        private void rdoFilterLast3Months_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int)FilterPeriod.ThreeMonths, from, DateTime.Now);
        }

        private void rdoFilterLast4Months_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int)FilterPeriod.FourMonths, from, DateTime.Now);
        }

        private void rdoFilterLast5Months_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int)FilterPeriod.FiveMonths, from, DateTime.Now);
        }

        private void rdoFilterLast6Months_Click(object sender, EventArgs e)
        {
            rollingMins.Stop();
            DateTime from = GetFilterFromDateTime();
            DrawGraph(coreFileData, (int)FilterPeriod.SixMonths, from, DateTime.Now);
        }

        private void btnResetGraph_Click(object sender, EventArgs e)
        {
            ResetGraphZoom();       // reset the graph view to 1:1
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AppSettings appSet = new AppSettings(Path.Combine(Directory.GetCurrentDirectory(), "CBW4PortTempGraphingTool.xml"));            //create appsettings XML reader object
            saveFileDialog1.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FilterIndex = 1;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string name = saveFileDialog1.FileName;
                    string versionDT = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "-");             
                    chart1.SaveImage(name, ChartImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving graph... [" + ex.Message + "]", "AKVA Group...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteToLog("btnRefresh_Click -> " + ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LoadSettings()
        {
            AppSettings appSet = new AppSettings(Path.Combine(Directory.GetCurrentDirectory(), "CBW4PortTempGraphingTool.xml"));

            string root = appSet.getValue("RootDataFolder");
            txtRootFolderPath.Text = root;
            selectedRootFolder = root;
            unitIPAddress = appSet.getValue("ipAddress");

            LoadFilesIntoFileList(root);
        }

        private void LoadFilesIntoFileList(string root)
        {
            try
            {
                foreach (var file in Directory.GetFiles(root))
                {
                    cmbDataFiles.Items.Add(Path.GetFileName(file));
                }
            } catch {}
        }

        void ResetGraphZoom()
        {
            chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(1);
            chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset(1);
        }

        private void btnRollingGraph_Click(object sender, EventArgs e)
        {
            timerRunning = !timerRunning;

            if (timerRunning)
            {
                rollingMins.Start();
                btnRollingGraph.Text = "Stop Rolling Chart";
                Application.DoEvents();
            }
            else
            {
                rollingMins.Stop();
                btnRollingGraph.Text = "Rolling 1 Hour";
                Application.DoEvents();
            }
        }

        private void rdoFilterLast24hrs_CheckedChanged(object sender, EventArgs e)
        {

        }

        void EnableDisableALL(bool EnableControls)
        {
            txtRootFolderPath.Enabled = EnableControls;
            cmbDataFiles.Enabled = EnableControls;
            btnDataFolderBrowse.Enabled = EnableControls;
            rdoFilterAllData.Enabled = EnableControls;
            rdoFilterLast6hrs.Enabled = EnableControls;
            rdoFilterLast12hrs.Enabled = EnableControls;
            rdoFilterLast24hrs.Enabled = EnableControls;
            rdoFilterLast2days.Enabled = EnableControls;
            rdoFilterLast5days.Enabled = EnableControls;
            rdoFilterLast7days.Enabled = EnableControls;
            rdoFilterLast2weeks.Enabled = EnableControls;
            rdoFilterLast3weeks.Enabled = EnableControls;
            rdoFilterLastMonth.Enabled = EnableControls;
            rdoFilterLast2Months.Enabled = EnableControls;
            rdoFilterLast3Months.Enabled = EnableControls;
            rdoFilterLast4Months.Enabled = EnableControls;
            rdoFilterLast5Months.Enabled = EnableControls;
            rdoFilterLast6Months.Enabled = EnableControls;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (tabControl1.SelectedIndex == 0)
            {
                EnableDisableALL(false);
                tmrHMI.Start();
                captureCount = 0;
            }
            else
            {
                EnableDisableALL(true);  // HMI
                tmrHMI.Stop();
                captureCount = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int readTemperatures()
        {
            AppSettings appSet = new AppSettings(Path.Combine(Directory.GetCurrentDirectory(), "CBW4PortTempGraphingTool.xml"));
            TcpClient tcpClient = new TcpClient();

            try
            {
                // Attempt the connection
                tcpClient.Connect(appSet.getValue("ipAddress"), Convert.ToInt32(appSet.getValue("httpPort")));

                if (tcpClient.Connected)
                {
                    // Create a network stream object
                    NetworkStream netStream = tcpClient.GetStream();

                    // If we can read and write to the stream then do so
                    if (netStream.CanWrite && netStream.CanRead)
                    {
                        // if there is a password then we need to encode it first convert the password to a byte array
                        byte[] password_bytes = Encoding.ASCII.GetBytes("none:" + appSet.getValue("Password"));
                        string pass = Convert.ToBase64String(password_bytes);

                        // Create the command to send to the temperature module
                        byte[] sendBytes = Encoding.ASCII.GetBytes("GET /state.xml HTTP/1.1" + Environment.NewLine + "Authorization: Basic " + pass + Environment.NewLine + Environment.NewLine);
                        netStream.Write(sendBytes, 0, sendBytes.Length);

                        // Get the response from the temperature module
                        byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                        netStream.Read(bytes, 0, tcpClient.ReceiveBufferSize);

                        // Parse the response and update the temperature text boxes
                        string returndata = Encoding.ASCII.GetString(bytes);

                        char[] splitters = { '<', '>' };

                        string[] strs = returndata.Split(splitters);

                        // go through all the strings and extract the temperatures
                        int sensorNumber = 1;
                      //  string unitsCompareStr = "units";
                        string sensorCompareStr = "sensor" + sensorNumber.ToString() + "temp";

                        for (int i = 0; i < strs.Length; i++)
                        {
                            //if (strs[i] == unitsCompareStr)
                            //{
                            //    lblCF1.Text = strs[i + 1];
                            //    lblCF2.Text = strs[i + 1];
                            //    lblCF3.Text = strs[i + 1];
                            //    lblCF4.Text = strs[i + 1];
                            //}

                            if (strs[i] == sensorCompareStr)
                            {
                                switch (sensorNumber)
                                {
                                    case 1:
                                        txtBlowerOutTemperature.Text = string.Format("{0}\u00B0C",strs[i + 1]);   // sensor 1
                                        break;
                                    case 2:
                                        txtExtTemperature.Text = string.Format("{0}\u00B0C", strs[i + 1]);       // sensor 2
                                        doserInTemperature = Convert.ToDouble(strs[i + 1]);
                                        break;
                                    case 3:
                                        txtHopperInTemperature.Text = string.Format("{0}\u00B0C", strs[i + 1]);   // sensor 3
                                        break;
                                    case 4:
                                        txtAmbientTemperature.Text = string.Format("{0}\u00B0C", strs[i + 1]);
                                        blowerOutTemperature = Convert.ToDouble(strs[i + 1]);
                                        break;
                                }

                                // move to the next sensor
                                sensorNumber++;
                                i++;
                                sensorCompareStr = "sensor" + sensorNumber.ToString() + "temp";
                            }
                        }
                    }

                    // Close the connection
                    tcpClient.Close();
                    //captureCount++;
                    //lblCaptureCount.Text = captureCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem communicting with the unit." + Environment.NewLine + "Message received: " + ex.Message + Environment.NewLine +
                    "Make sure to use a valid IP Address and Port Number as well as a Password if it is required.", "Information", MessageBoxButtons.OK);
                return 3;
            }
            return 3;
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            frmLiveLoggingSetup frmSu = new frmLiveLoggingSetup();
            frmSu.ShowDialog();
        }

        private void tmrHMI_Tick(object sender, EventArgs e)
        {
            int ret = readTemperatures();
            deltaTvalue = Math.Round(doserInTemperature - blowerOutTemperature, 2);

            //double percChange = Math.Round((doserInTemperature + blowerOutTemperature) / ((doserInTemperature - blowerOutTemperature) / 2), 4);
            //double percChange = Math.Round((doserInTemperature - blowerOutTemperature) / ((doserInTemperature + blowerOutTemperature) / 2), 4);
            double percChange = Math.Round((blowerOutTemperature - doserInTemperature) / ((blowerOutTemperature + doserInTemperature) / 2),4);

            percChange *= 100;
            txtPercentageChange.Text = percChange.ToString() + "%";

            if (deltaTvalue < 0)
                txtTempDelta.ForeColor = Color.Blue;
            else
                txtTempDelta.ForeColor = Color.DarkRed;

            txtTempDelta.Text = string.Format("{0}\u00B0C", deltaTvalue.ToString());
            captureCount++;
            lblCaptureCount.Text = "Readings Count: " + captureCount.ToString();
            lblUnitIP.Text = "Unit IP: " + unitIPAddress;
        }
    }
}
