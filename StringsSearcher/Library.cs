using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MASToolBox
{
    class Library
    {
        private readonly string LibPath = "";

        private RichTextBox OutputBox;

        private string[] Parameters;

        public Process Process { get; private set;}

        public Library(LibraryPath path)
        {
            this.LibPath = path.Path;
        }

        public void SetOutputBox(RichTextBox outputBox)
        {
            this.OutputBox = outputBox;
        }

        public void AddParam(string[] parameters)
        {
            this.Parameters = parameters;
        }

        public void RunLibrary()
        {
            if (this.OutputBox == null)
                throw new Exception("Please specify the output textbox with SetOutputBox method first");

            BackgroundWorker LibWorker = new BackgroundWorker();
            LibWorker.DoWork += this.LibWorker_DoWork;
            LibWorker.RunWorkerCompleted += this.LibWorker_RunWorkerCompleted;

            LibWorker.RunWorkerAsync();
        }

        private void LibWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Process.Dispose();
            this.Process = null;

            EventHandler jobFinishEvent = this.JobFinished;

            // Check for no subscribers
            if (jobFinishEvent == null)
                return;
            
            jobFinishEvent(this, e);
        }

        private void LibWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //parameters
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < this.Parameters.Length; i++)
            {
                sb.Append("\"").Append(this.Parameters[i]).Append("\"").Append(" ");
            }
            var argument = sb.ToString();

            Process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = this.LibPath;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.Arguments = argument;
            
            startInfo.CreateNoWindow = true;
            Process.StartInfo = startInfo;

            Process.Start();
            Process.ErrorDataReceived += Proc_OutputDataReceived;
            Process.OutputDataReceived += Proc_OutputDataReceived;
            Process.EnableRaisingEvents = true;
            Process.BeginOutputReadLine();
            Process.BeginErrorReadLine();
            Process.WaitForExit();
        }

        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
                return;
            this.OutputBox.Invoke((MethodInvoker)delegate
            {
                this.OutputBox.AppendText(e.Data + "\r\n");
                this.OutputBox.ScrollToCaret();
            });
        }

        public event EventHandler JobFinished;
    }
}
