using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MASToolBox
{
    public partial class Form1
    {
        int mode = 0;
        void Proc_NmapDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.rtb_nmapResult.Invoke((MethodInvoker)delegate
            {
                if (e.Data == null)
                {
                    cer_bt.Enabled = true;
                    ssl_bt.Enabled = true;
                    state.Text = "已結束";
                    state.BackColor = Color.LightGreen;
                }
                else
                {
                    //Cer
                    if (mode == 1)
                    {
                        if (e.Data.StartsWith("| Issuer:")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("| Public Key type:")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("| Public Key bits:")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("| Signature Algorithm:")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("| Not valid before:")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("| Not valid after:")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("|_SHA-1:")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("|_ssl-date:")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                    }


                    //SSL
                    if (mode == 2)
                    {
                        if (e.Data.StartsWith("| ")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("|_")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                    }


                    //common
                    if (e.Data.StartsWith("Nmap done:")) { rtb_nmapResult.AppendText(e.Data + "\r\n"); }
                }



            });
        }
        
        private void BtCer_Click(object sender, EventArgs e)
        {
            rtb_nmapResult.Focus();
            mode = 1;
            if (Check())
            {
                Process process = new Process();
                state.Text = "掃描中";
                state.BackColor = Color.Coral;
                cer_bt.Enabled = false;
                ssl_bt.Enabled = false;
                rtb_nmapResult.Text = "";

                string str1 = "-sC";
                string str2 = "-p";
                string str3 = "-v";
                
                process.StartInfo.FileName = "tools/nmap.bat";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                
                if (port_box.Text == null || port_box.Text == "")
                    port_box.Text = "443";

                process.StartInfo.Arguments = 
                    string.Format(str3 + " " + str1 + " " + ip_box.Text + " " + str2 + " " + port_box.Text);
                
                process.Start();
                process.OutputDataReceived += Proc_NmapDataReceived;
                process.BeginOutputReadLine();
                process.StandardInput.AutoFlush = true;
                process.Close();

            }
        }
        
        private void BtSSL_Click(object sender, EventArgs e)
        {
            rtb_nmapResult.Focus();
            mode = 2;
            if (Check())
            {
                Process process = new Process();
                state.Text = "掃描中";
                state.BackColor = Color.Coral;
                cer_bt.Enabled = false;
                ssl_bt.Enabled = false;
                rtb_nmapResult.Text = "";
                string str = Console.ReadLine();

                process.StartInfo.FileName = "tools/nmap.bat";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                string str1 = "--script";  //--script ssl-enum-ciphers
                string str2 = "-p";
                string str3 = "ssl-enum-ciphers";

                if (port_box.Text == null || port_box.Text == "")
                    port_box.Text = "443";

                process.StartInfo.Arguments = string.Format(str1 + " " + str3 + " " + ip_box.Text + " " + str2 + " " + port_box.Text);
                process.Start();
                process.OutputDataReceived += Proc_NmapDataReceived;
                process.BeginOutputReadLine();
                process.StandardInput.AutoFlush = true;
                process.Close();
            }

        }

        private void Btn_screenshot_Click(object sender, EventArgs e)
        {
            var result = saveScreenshotDialog.ShowDialog();
            var fileName = saveScreenshotDialog.FileName;
            if(result == DialogResult.OK)
            {
                ScreenCapture.Capture(this.rtb_nmapResult, fileName);
            }
        }

        private bool Check()
        {

            Regex ipRgx = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$");
            Regex portRgx = new Regex(@"^\d{1,5}$");
            Regex domainRex = new Regex(@"^(([\w][\w\-\.]*)\.)?([\w][\w\-]+)(\.([\w][\w\.]*))?$");
            if (!(portRgx.IsMatch(port_box.Text, 0) | port_box.Text == ""))
            {
                rtb_nmapResult.Text = "port is not correct";
                return false;
            }
            if (ipRgx.IsMatch(ip_box.Text, 0) | domainRex.IsMatch(ip_box.Text, 0))
            {
                return true;
            }
            else
            {
                rtb_nmapResult.Text = "ip is not correct";
                return false;
            }

        }

        

        public delegate string LibraryEvent(string data);
    }
}
