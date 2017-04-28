using AkvaData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBW_4PortTemperatureGraphingTool
{
    public partial class frmLiveLoggingSetup : Form
    {
        public frmLiveLoggingSetup()
        {
            InitializeComponent();
        }

        AppSettings appSet = new AppSettings(Path.Combine(Directory.GetCurrentDirectory(), "CBW4PortTempGraphingTool.xml"));

        int readingCounter = 0;

        private void frmLiveLoggingSetup_Load(object sender, EventArgs e)
        {
            ReadSettings();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            tmrLogTimer.Start();
            int ret = readTemperatures();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrLogTimer.Stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void tmrLogTimer_Tick(object sender, EventArgs e)
        {
            int ret = readTemperatures();
            readingCounter++;
            lblReadCounter.Text = "Read Counter: " + readingCounter.ToString();
        }

        private void ReadSettings()
        {
            txIpAddress.Text = appSet.getValue("ipAddress");
            txtPort.Text = appSet.getValue("httpPort");
            txtPassword.Text = appSet.getValue("Password");
            btnTestConnection.Enabled = true;
            numUpDwnSampleRate.Value = Convert.ToDecimal(appSet.getValue("SampleRate"));
        }

        private void SaveSettings()
        {
            appSet.setValue("ipAddress", txIpAddress.Text.Trim());
            appSet.setValue("httpPort", txtPort.Text.Trim());
            appSet.setValue("Password", txtPassword.Text.Trim());
        }

        private int readTemperatures()
        {
            TcpClient tcpClient = new TcpClient();
           
            try
            {
                // Attempt the connection
                tcpClient.Connect(txIpAddress.Text, Convert.ToInt32(txtPort.Text));

                if (tcpClient.Connected)
                {
                    // Create a network stream object
                    NetworkStream netStream = tcpClient.GetStream();

                    // If we can read and write to the stream then do so
                    if (netStream.CanWrite && netStream.CanRead)
                    {
                        // if there is a password then we need to encode it first convert the password to a byte array
                        byte[] password_bytes = Encoding.ASCII.GetBytes("none:" + txtPassword.Text);
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
                        //string unitsCompareStr = "units";
                        string sensorCompareStr = "sensor" + sensorNumber.ToString() + "temp";

                        for (int i = 0; i < strs.Length; i++)
                        {
                            //if (strs[i] == unitsCompareStr)
                            //{
                            //    //lblCF1.Text = strs[i + 1];
                            //    //lblCF2.Text = strs[i + 1];
                            //    //lblCF3.Text = strs[i + 1];
                            //    //lblCF4.Text = strs[i + 1];
                            //}

                            if (strs[i] == sensorCompareStr)
                            {
                                // the next string is the current temperature for this sensor
                                switch (sensorNumber)
                                {
                                    case 1:
                                        txtSensor1Reading.Text = strs[i + 1];
                                        break;
                                    case 2:
                                        txtSensor2Reading.Text = strs[i + 1];
                                        break;
                                    case 3:
                                        txtSensor3Reading.Text = strs[i + 1];
                                        break;
                                    case 4:
                                        txtSensor4Reading.Text = strs[i + 1];
                                        break;
                                }

                                // move to the next sensor
                                sensorNumber++;
                                i++;
                                sensorCompareStr = "sensor" + sensorNumber.ToString() + "temp";
                            }
                        }
                    }

                    tcpClient.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem communicating with the unit." + Environment.NewLine + "Message received: " + ex.Message + Environment.NewLine +
                    "Make sure to use a valid IP Address and Port Number as well as a Password if it is required.", "Information", MessageBoxButtons.OK);
                return 3;
            }
            return 0;
        }

        private void txIpAddress_Leave(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void txtPort_Leave(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void numUpDwnSampleRate_ValueChanged(object sender, EventArgs e)
        {
            decimal rate = numUpDwnSampleRate.Value;
            appSet.setValue("SampleRate", rate.ToString());
        }
    }
}
