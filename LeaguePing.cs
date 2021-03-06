﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Timers;
using System.Diagnostics;
//using System.Management;

namespace LeaguePing
{
    public partial class LeaguePing : Form
    {
        public LeaguePing()
        {
            InitializeComponent();
        }

        private void LeaguePing_Load(object sender, EventArgs e)
        {
            radioButtonNA.Checked = true;
        }

        private String ip;
        private String server;
        private int lowest = 10000;
        private int highest = 0;
        private System.Threading.Timer timer;
        private String[] pingHistory = { "", "", "", "", "", "", "", "", "", "" };
        private String[] timestamp = { "", "", "", "", "", "", "", "", "", "" };
        private int[] pings = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int delay = 1000;

        private void resetValues()
        {
            lowest = 10000;
            highest = 0;
            labelLowest.Text = "Lowest Ping in Current Session: 0ms";
            labelHighest.Text = "Highest Ping in Current Session: 0ms";
            labelAverage.Text = "Average Ping from Last 10 Results: 0ms";
            pingHistory[0] = "";
            pingHistory[1] = "";
            pingHistory[2] = "";
            pingHistory[3] = "";
            pingHistory[4] = "";
            pingHistory[5] = "";
            pingHistory[6] = "";
            pingHistory[7] = "";
            pingHistory[8] = "";
            pingHistory[9] = "";
            timestamp[0] = "";
            timestamp[1] = "";
            timestamp[2] = "";
            timestamp[3] = "";
            timestamp[4] = "";
            timestamp[5] = "";
            timestamp[6] = "";
            timestamp[7] = "";
            timestamp[8] = "";
            timestamp[9] = "";
            pings[0] = 0;
            pings[1] = 0;
            pings[2] = 0;
            pings[3] = 0;
            pings[4] = 0;
            pings[5] = 0;
            pings[6] = 0;
            pings[7] = 0;
            pings[8] = 0;
            pings[9] = 0;
            labelPing0.Text = pingHistory[0];
            labelPing1.Text = pingHistory[1];
            labelPing2.Text = pingHistory[2];
            labelPing3.Text = pingHistory[3];
            labelPing4.Text = pingHistory[4];
            labelPing5.Text = pingHistory[5];
            labelPing6.Text = pingHistory[6];
            labelPing7.Text = pingHistory[7];
            labelPing8.Text = pingHistory[8];
            labelPing9.Text = pingHistory[9];
            labelTime0.Text = timestamp[0];
            labelTime1.Text = timestamp[1];
            labelTime2.Text = timestamp[2];
            labelTime3.Text = timestamp[3];
            labelTime4.Text = timestamp[4];
            labelTime5.Text = timestamp[5];
            labelTime6.Text = timestamp[6];
            labelTime7.Text = timestamp[7];
            labelTime8.Text = timestamp[8];
            labelTime9.Text = timestamp[9];

            pictureBoxPing.Image = Properties.Resources.pingGray;

            this.Icon = Properties.Resources.iconGray;

            chartPing.Series["Ping"].Points.Clear();
        }

        private void updatePingHistory(String ping, DateTime time)
        {
            pingHistory[0] = pingHistory[1];
            pingHistory[1] = pingHistory[2];
            pingHistory[2] = pingHistory[3];
            pingHistory[3] = pingHistory[4];
            pingHistory[4] = pingHistory[5];
            pingHistory[5] = pingHistory[6];
            pingHistory[6] = pingHistory[7];
            pingHistory[7] = pingHistory[8];
            pingHistory[8] = pingHistory[9];
            pingHistory[9] = ping;

            timestamp[0] = timestamp[1];
            timestamp[1] = timestamp[2];
            timestamp[2] = timestamp[3];
            timestamp[3] = timestamp[4];
            timestamp[4] = timestamp[5];
            timestamp[5] = timestamp[6];
            timestamp[6] = timestamp[7];
            timestamp[7] = timestamp[8];
            timestamp[8] = timestamp[9];
            timestamp[9] = "[" + cleanTime(time.Hour) + ":" + cleanTime(time.Minute) + ":" + cleanTime(time.Second) + "]";

            labelPing0.Text = pingHistory[0];
            labelPing1.Text = pingHistory[1];
            labelPing2.Text = pingHistory[2];
            labelPing3.Text = pingHistory[3];
            labelPing4.Text = pingHistory[4];
            labelPing5.Text = pingHistory[5];
            labelPing6.Text = pingHistory[6];
            labelPing7.Text = pingHistory[7];
            labelPing8.Text = pingHistory[8];
            labelPing9.Text = pingHistory[9];

            labelTime0.Text = timestamp[0];
            labelTime1.Text = timestamp[1];
            labelTime2.Text = timestamp[2];
            labelTime3.Text = timestamp[3];
            labelTime4.Text = timestamp[4];
            labelTime5.Text = timestamp[5];
            labelTime6.Text = timestamp[6];
            labelTime7.Text = timestamp[7];
            labelTime8.Text = timestamp[8];
            labelTime9.Text = timestamp[9];

            chartPing.Series["Ping"].Points.Clear();

            for (int i = 0; i < 10; i++ )
            {
                if (pingHistory[i].Contains("Timed Out") || pingHistory[i].Contains("Failed") || pingHistory[i].Contains("Error"))
                {
                    pings[i] = -1;
                    chartPing.Series["Ping"].Points.AddXY(i + 1, 299);
                    chartPing.Series["Ping"].Color = Color.Red;
                }
                else if (pingHistory[i].Equals(""))
                {
                    pings[i] = 0;
                    chartPing.Series["Ping"].Points.AddXY(i + 1, 1);
                    chartPing.Series["Ping"].Color = Color.Green;
                }
                else
                {
                    //pingHistory[i] = pingHistory[i].Remove(10);
                    //string temp = pingHistory[i];
                    //temp = temp.
                    //temp = temp.Replace("ms", "");
                    pings[i] = int.Parse(pingHistory[i].Replace("ms", ""));

                    if(pings[i] >= 300) {
                        chartPing.Series["Ping"].Points.AddXY(i+1, 299);
                    } else {
                        chartPing.Series["Ping"].Points.AddXY(i+1, pings[i]);
                    }
                    chartPing.Series["Ping"].Color = getColor(pings[i]);
                }
            }

            labelPing0.ForeColor = getColor(pings[0]);
            labelPing1.ForeColor = getColor(pings[1]);
            labelPing2.ForeColor = getColor(pings[2]);
            labelPing3.ForeColor = getColor(pings[3]);
            labelPing4.ForeColor = getColor(pings[4]);
            labelPing5.ForeColor = getColor(pings[5]);
            labelPing6.ForeColor = getColor(pings[6]);
            labelPing7.ForeColor = getColor(pings[7]);
            labelPing8.ForeColor = getColor(pings[8]);
            labelPing9.ForeColor = getColor(pings[9]);
        }

        private string cleanTime(int time)
        {
            if (time < 10) {
                return "0" + time.ToString();
            }
            else
            {
                return time.ToString();
            }
        }

        private string getAveragePing()
        {
            for (int i = 0; i < 10; i++)
            {
                if (pings[i] == -1)
                {
                    return "Timed Out"; 
                }

                if (pings[i] == 0)
                {
                    return "Processing";
                }
            }

            return ((pings[0] + pings[1] + pings[2] + pings[3] + pings[4] + pings[5] + pings[6] + pings[7] + pings[8] + pings[9]) / 10).ToString()+"ms";
        }

        private Color getColor(int ping)
        {
            if(ping >= 250) {
                return Color.Red;
            }
            else if (ping >= 100)
            {
                return Color.Orange;
            }
            else if (ping >= 1)
            {
                return Color.Green;
            }
            else if (ping >= -1)
            {
                return Color.Red;
            }

            return Color.Black;
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            timer = new System.Threading.Timer((t) =>
            {
                updatePing();
            }, null, 0, delay);
            
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonReset.Enabled = true;

            textBoxCustom.Enabled = false;

            numericUpDownDelay.Enabled = false;

            delay = (int)(numericUpDownDelay.Value * 1000);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Dispose();

            labelPing.ForeColor = Color.Black;
            labelPing.Text = "Currently not sending any ping requests.";

            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            buttonReset.Enabled = false;

            resetValues();

            textBoxCustom.Enabled = true;

            numericUpDownDelay.Enabled = true;
        }

        private void updatePing()
        {
            try 
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    Ping pingClass = new Ping();
                    try
                    {
                        PingReply pingReply = pingClass.Send(ip, 1000);
                        if (pingReply.Status == IPStatus.Success)
                        {
                            long ping = pingReply.RoundtripTime;
                            if (ping <= 0)
                            {
                                labelPing.ForeColor = Color.Red;
                                labelPing.Text = ("Pinging " + server + " (" + ip + ") : Reply = Timed Out");
                                updatePingHistory("Timed Out", System.DateTime.Now);
                                pictureBoxPing.Image = Properties.Resources.pingRed;
                                this.Icon = Properties.Resources.iconRed;
                            }
                            else if (ping >= 250)
                            {
                                labelPing.ForeColor = Color.Red;
                                labelPing.Text = ("Pinging " + server + " (" + ip + ") : Reply = " + ping.ToString() + "ms");
                                updatePingHistory(ping.ToString() + "ms", System.DateTime.Now);
                                pictureBoxPing.Image = Properties.Resources.pingRed;
                                this.Icon = Properties.Resources.iconRed;

                                if (ping > highest)
                                {
                                    highest = (int)ping;
                                    labelHighest.Text = "Highest Ping in Current Session: " + highest + "ms";
                                }
                                if (ping < lowest)
                                {
                                    lowest = (int)ping;
                                    labelLowest.Text = "Lowest Ping in Current Session: " + lowest + "ms";
                                }
                            }
                            else if (ping >= 100)
                            {
                                labelPing.ForeColor = Color.Orange;
                                labelPing.Text = ("Pinging " + server + " (" + ip + ") : Reply = " + ping.ToString() + "ms");
                                updatePingHistory(ping.ToString() + "ms", System.DateTime.Now);
                                pictureBoxPing.Image = Properties.Resources.pingOrange;
                                this.Icon = Properties.Resources.iconOrange;

                                if (ping > highest)
                                {
                                    highest = (int)ping;
                                    labelHighest.Text = "Highest Ping in Current Session: " + highest + "ms";
                                }
                                if (ping < lowest)
                                {
                                    lowest = (int)ping;
                                    labelLowest.Text = "Lowest Ping in Current Session: " + lowest + "ms";
                                }
                            }
                            else if (ping >= 1)
                            {
                                labelPing.ForeColor = Color.Green;
                                labelPing.Text = ("Pinging " + server + " (" + ip + ") : Reply = " + ping.ToString() + "ms");
                                updatePingHistory(ping.ToString() + "ms", System.DateTime.Now);
                                pictureBoxPing.Image = Properties.Resources.pingGreen;
                                this.Icon = Properties.Resources.iconGreen;

                                if (ping > highest)
                                {
                                    highest = (int)ping;
                                    labelHighest.Text = "Highest Ping in Current Session: " + highest + "ms";
                                }
                                if (ping < lowest)
                                {
                                    lowest = (int)ping;
                                    labelLowest.Text = "Lowest Ping in Current Session: " + lowest + "ms";
                                }
                            }
                        }
                        else
                        {
                            labelPing.ForeColor = Color.Red;
                            labelPing.Text = ("Pinging " + server + " (" + ip + ") : Reply = Failed");
                            updatePingHistory("Timed Out", System.DateTime.Now);
                            pictureBoxPing.Image = Properties.Resources.pingRed;
                            this.Icon = Properties.Resources.iconRed;
                        }
                    }
                    catch (System.Net.NetworkInformation.PingException ex)
                    {
                        labelPing.ForeColor = Color.Red;
                        labelPing.Text = ("Pinging " + server + " (" + ip + ") : Reply = Timed Out");
                        updatePingHistory("Timed Out", System.DateTime.Now);
                        pictureBoxPing.Image = Properties.Resources.pingRed;
                        this.Icon = Properties.Resources.iconRed;
                    }
                    catch (Exception ex)
                    {
                        labelPing.ForeColor = Color.Red;
                        labelPing.Text = ("Pinging " + server + " (" + ip + ") : Reply = Error");
                        updatePingHistory("Timed Out", System.DateTime.Now);
                        pictureBoxPing.Image = Properties.Resources.pingRed;
                        this.Icon = Properties.Resources.iconRed;
                    }

                    labelAverage.Text = "Average Ping in Current Session: " + getAveragePing();

                    //network check, could be useful
                    //NetworkInterface.GetIsNetworkAvailable();
                }));
            }
            catch (System.ObjectDisposedException ex)
            {

            }
        }

        private void radioButtonNA_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonNA.Checked) {
                server = "North America";
                ip = "104.160.131.1"; //na chicago //104.160.131.1
                //ip = "95.172.65.1"; //euw? //mx1.eu.lol.riotgames.com
                //ip = "104.16.22.33"; //euw in toronto? //cloudflare usa, cali
                //ip = "riot.de"; //euw? //188.40.93.11 //hetzner online //static.11.93.40.188.clients.your-server.de
                //ip = "95.172.67.1"; //euw //InterNAP Network Services U.K. Limited //TIMEOUT
                //ip = "114.31.192.105"; //oce? //ten-1-0-0.bdr03.syd04.nsw.vocus.net.au //Vocus Pty Ltd //TIMEOUT
                //59.100.95.192 and 59.100.95.145 //oce //TIMEOUT
                //190.93.246.186 //oce? //CloudFlare Latin America S.R.L
                //14.200.100.27 //oce? //14-200-100-27.static.tpgi.com.au //i avg 280ms //TPG Internet //oceania, australia
                //95.172.65.154 and 31.186.224.112 //na? //TIMEOUT
                //203.174.139.185 //oce? //203-174-139-185.syd.static-ipl.aapt.com.au //AAPT Limited //PowerTel/ i avg 260ms

                resetValues();
            }

        }

        private void radioButtonEUW_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEUW.Checked)
            {
                server = "Europe West";
                ip = "95.172.65.1"; //euw?

                resetValues();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Dispose();
            }

            labelPing.ForeColor = Color.Black;
            labelPing.Text = "Currently not sending any ping requests.";

            buttonStop.Enabled = false;
            buttonStart.Enabled = true;

            resetValues();

            timer = new System.Threading.Timer((t) =>
            {
                updatePing();
            }, null, 0, 1000);

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;

            textBoxCustom.Enabled = false;

            numericUpDownDelay.Enabled = false;
        }

        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustom.Checked)
            {
                textBoxCustom.Enabled = true;
                textBoxCustom.Focus();
                textBoxCustom.SelectAll();

                if (timer != null)
                {
                    timer.Dispose();
                }

                labelPing.ForeColor = Color.Black;
                labelPing.Text = "Currently not sending any ping requests.";

                buttonStop.Enabled = false;
                buttonStart.Enabled = true;
                buttonReset.Enabled = false;
                numericUpDownDelay.Enabled = true;

                resetValues();

                server = "Custom";
                ip = textBoxCustom.Text;
            }
            else
            {
                textBoxCustom.Enabled = false;
            }
        }

        private void textBoxCustom_TextChanged(object sender, EventArgs e)
        {
            ip = textBoxCustom.Text;
        }

        private void radioButtonOCE_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOCE.Checked)
            {
                server = "Oceania";
                ip = "14.200.100.27";

                resetValues();
            }
        }

        private void numericUpDownDelay_ValueChanged(object sender, EventArgs e)
        {
            delay = (int)(numericUpDownDelay.Value * 1000);
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.FileName = @"C:\WINDOWS\System32\ipconfig.exe";
            pInfo.Arguments = "/release";
            pInfo.RedirectStandardOutput = true;
            pInfo.UseShellExecute = false;
            pInfo.CreateNoWindow = true;
            Process p = Process.Start(pInfo);
            p.WaitForExit();

            ProcessStartInfo pInfo2 = new ProcessStartInfo();
            pInfo2.FileName = @"C:\WINDOWS\System32\ipconfig.exe";
            pInfo2.Arguments = "/renew";
            pInfo2.RedirectStandardOutput = true;
            pInfo2.UseShellExecute = false;
            pInfo2.CreateNoWindow = true;
            Process p2 = Process.Start(pInfo2);
            p2.WaitForExit();
        }
    }
}
