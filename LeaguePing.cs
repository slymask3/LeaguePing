using System;
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
            labelPing.Text = "Currently not sending any ping requests.";
            radioButtonNA.Checked = true;
        }

        private String ip;
        private String server;
        private int lowest = 10000;
        private int highest = 0;
        private System.Threading.Timer timer;

        private void resetValues()
        {
            lowest = 10000;
            highest = 0;
            labelLowest.Text = "Lowest Ping in Current Session: 0ms";
            labelHighest.Text = "Highest Ping in Current Session: 0ms";
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            timer = new System.Threading.Timer((t) =>
            {
                updatePing();
            }, null, 0, 1000);
            
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Dispose();

            labelPing.ForeColor = Color.Black;
            labelPing.Text = "Currently not sending any ping requests.";

            buttonStop.Enabled = false;
            buttonStart.Enabled = true;

            resetValues();
        }

        private void updatePing()
        {
            this.Invoke(new MethodInvoker(delegate()
            {      
                Ping pingClass = new Ping();
                try
                {
                    PingReply pingReply = pingClass.Send(ip, 1000);
                    long ping = pingReply.RoundtripTime;

                    if (ping <= 0)
                    {
                        labelPing.ForeColor = Color.Red;
                        labelPing.Text = ("Pinging " + server + " : Reply = Timed Out");
                    }
                    else if (ping >= 250)
                    {
                        labelPing.ForeColor = Color.Red;
                        labelPing.Text = ("Pinging " + server + " : Reply = " + ping.ToString() + "ms");

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
                        labelPing.Text = ("Pinging " + server + " : Reply = " + ping.ToString() + "ms");

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
                    else if(ping >= 1)
                    {
                        labelPing.ForeColor = Color.Green;
                        labelPing.Text = ("Pinging " + server + " : Reply = " + ping.ToString() + "ms");

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
                catch (System.Net.NetworkInformation.PingException ex)
                {
                    labelPing.ForeColor = Color.Red;
                    labelPing.Text = ("Pinging " + server + " : Reply = Timed Out");
                }
                catch (Exception ex)
                {

                    labelPing.ForeColor = Color.Red;
                    labelPing.Text = ("Pinging " + server + " : Reply = Error");

                }
            }));
        }

        private void radioButtonNA_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonNA.Checked) {
                server = "North America";
                ip = "104.160.131.1";

                resetValues();
            }
        }

        private void radioButtonEUW_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEUW.Checked)
            {
                server = "Google";
                ip = "www.google.ca";

                resetValues();
            }
        }
    }
}
