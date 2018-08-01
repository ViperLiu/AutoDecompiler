using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASToolBox
{
    partial class Form1
    {
        private Process adb;

        private void Btn_checkADB_Click(object sender, EventArgs e)
        {
            adbWorker.RunWorkerAsync();
        }

        private void AdbWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string args1 = "shell";
            //string args2 = "-c";
            string args3 = "su -c \"ls /data/data\"";

            adb = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "tools\\adb\\adb.exe";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.Arguments = string.Format("\"{0}\" \"{1}\"", args1, args3);

            //tbOutput.Text = startInfo.Arguments;
            startInfo.CreateNoWindow = true;
            adb.StartInfo = startInfo;
            adb.SynchronizingObject = this;
            
            adb.Start();
            adb.ErrorDataReceived += Proc_AdbDataReceived;
            adb.OutputDataReceived += Proc_AdbDataReceived;
            adb.EnableRaisingEvents = true;
            adb.BeginOutputReadLine();
            adb.BeginErrorReadLine();
            adb.WaitForExit();
        }

        private void Proc_AdbDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.rtb_adbOutput.Invoke((MethodInvoker)delegate
            {
                rtb_adbOutput.AppendText(e.Data + "\r\n");
                rtb_adbOutput.ScrollToCaret();
            });
        }

        private void AdbWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
