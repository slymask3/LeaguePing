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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool inf = true;
            //while(inf) {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.FileName = @"ping.exe";
                proc.StartInfo.Arguments = "104.160.131.1 -n 1";
                proc.Start();
                string output = proc.StandardOutput.ReadToEnd();


                if (output.Contains("Request timed out") || output.Contains("Unknown host"))
                {
                    //return false;
                    labelPing.Text = "Ping = timed out";
                }
                else
                {
                    //System.Console.WriteLine(output);
                    output = output.Remove(100);

                    output = output.Replace("Pinging 104.160.131.1 with 32 bytes of data:", "");
                    output = output.Replace("Reply from 104.160.131.1: bytes=32 time=", "");
                    output = output.Replace("ms TTL=58", "");
                    output = output.Replace(" ", "");

                    int ping = Int32.Parse(output);

                    string o = ping.ToString();

                    labelPing.Text = "Ping = " + o;
                }
            //}
        }

        private void button2_Click(object sender, EventArgs e) {
            var timer = new System.Threading.Timer((t) =>
            {
                updatePing();
            }, null, 0, 1000);

        }


        private void updatePing()
        {
            this.Invoke(new MethodInvoker(delegate()
            {      
                Ping pingClass = new Ping();
                try
                {
                    PingReply pingReply = pingClass.Send("104.160.131.1", 1000);
                    long ping = pingReply.RoundtripTime;

                    if (ping <= 0)
                    {
                        labelPing.Text = ("timed out");
                    }
                    else
                    {
                        labelPing.Text = (ping.ToString() + "ms");
                    }

                }
                catch (System.Net.NetworkInformation.PingException ex)
                {
                    labelPing.Text = "timed out!";
                }
                catch (Exception ex)
                {
                

                    labelPing.Text = "error";

                }
            }));
        }
    }
}
