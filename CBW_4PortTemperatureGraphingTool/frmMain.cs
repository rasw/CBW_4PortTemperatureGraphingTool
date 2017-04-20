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
        List<string> coreFileData = new List<string>();

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


        private DateTime GetFilterDateTime(DateTime lastLineDT, DateTime FirstLineDT)
        {
            DateTime dtFilter = FirstLineDT;
            if (rdoFilterAllData.Checked) { dtFilter = FirstLineDT; }
            if (rdoFilterLast6hrs.Checked) { dtFilter = lastLineDT.AddHours(-6); }
            if (rdoFilterLast12hrs.Checked) { dtFilter = lastLineDT.AddHours(-12); }
            if (rdoFilterLast24hrs.Checked) { dtFilter = lastLineDT.AddDays(-1); }
            if (rdoFilterLast2days.Checked) { dtFilter = lastLineDT.AddDays(-2); }
            if (rdoFilterLast5days.Checked) { dtFilter = lastLineDT.AddDays(-5); }
            if (rdoFilterLast7days.Checked) { dtFilter = lastLineDT.AddDays(-7); }
            if (rdoFilterLast2weeks.Checked) { dtFilter = lastLineDT.AddDays(-14); }
            if (rdoFilterLast3weeks.Checked) { dtFilter = lastLineDT.AddDays(-21); }
            if (rdoFilterLastMonth.Checked) { dtFilter = lastLineDT.AddMonths(-1); }
            if (rdoFilterLast2Months.Checked) { dtFilter = lastLineDT.AddMonths(-2); }
            if (rdoFilterLast3Months.Checked) { dtFilter = lastLineDT.AddMonths(-3); }
            if (rdoFilterLast4Months.Checked) { dtFilter = lastLineDT.AddMonths(-4); }
            if (rdoFilterLast5Months.Checked) { dtFilter = lastLineDT.AddMonths(-5); }
            if (rdoFilterLast6Months.Checked) { dtFilter = lastLineDT.AddMonths(-6); }

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

        void DrawGraph()
        {
            try
            {
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
               

            }
            catch (Exception ex)
            {

            }
        }

        private void cmbDataFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFileFullPath = Path.Combine(selectedRootFolder, cmbDataFiles.Text);

            LoadCoreFileData(selectedFileFullPath);
        }

        private void LoadCoreFileData(string selectedFileFullPath)
        {
           
        }

        private void rdoFilterAllData_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast6hrs_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast12hrs_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast24hrs_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast2days_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast5days_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast7days_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast2weeks_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast3weeks_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLastMonth_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast2Months_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast3Months_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast4Months_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast5Months_Click(object sender, EventArgs e)
        {

        }

        private void rdoFilterLast6Months_Click(object sender, EventArgs e)
        {

        }

        private void btnResetGraph_Click(object sender, EventArgs e)
        {
            ResetGraphZoom();       // reset the graph view to 1:1
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

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

        private void rdoFilterAllData_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
