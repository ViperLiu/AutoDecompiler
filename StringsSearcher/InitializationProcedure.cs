using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO.Compression;
using System.Threading;
using System.IO;

namespace MASToolBox
{
    public partial class InitializationProcedure : Form
    {
        public InitializationProcedure()
        {
            InitializeComponent();
        }

        private void UnzipTools()
        {
            string zipPath = @"tools\tools.zip";
            string extractPath = @"tools\";

            try
            {
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
            catch(IOException)
            {
                Properties.MobSF.Default.IsToolsUnzip = true;
                Properties.MobSF.Default.Save();
            }
        }

        private void InitializationProcedure_Shown(object sender, EventArgs e)
        {
            InitializationWorker.RunWorkerAsync();
        }

        private void InitializationWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            InitializationWorker.ReportProgress(10, "解壓縮小工具...");
            UnzipTools();
            InitializationWorker.ReportProgress(75, "開始檢查小工具...");
            Thread.Sleep(1000);
            InitializationWorker.ReportProgress(79, "(1/5) 檢查 keywordSearch...");
            if (!File.Exists("tools\\keywordSearch\\keywordSearch.py"))
            {
                
            }
            Thread.Sleep(1000);
            InitializationWorker.ReportProgress(83, "(2/5) 檢查 nmap.exe...");
            if (!File.Exists("tools\\Nmap\\nmap.exe"))
            {

            }
            Thread.Sleep(1000);
            InitializationWorker.ReportProgress(87, "(3/5) 檢查 apktool...");
            if (!File.Exists("tools\\apktool-2.3.0\\apktool.bat"))
            {

            }
            Thread.Sleep(1000);
            InitializationWorker.ReportProgress(91, "(4/5) 檢查 dex2jar...");
            if (!File.Exists("tools\\dex2jar-2.0\\d2j-dex2jar.bat"))
            {

            }
            Thread.Sleep(1000);
            InitializationWorker.ReportProgress(95, "(5/5) 檢查 jd-cli...");
            if (!File.Exists("tools\\jd-cli-0.9.2-dist\\jd-cli.jar"))
            {

            }
            Thread.Sleep(1000);
            InitializationWorker.ReportProgress(100, "檢查完畢...");
            Thread.Sleep(1000);
        }

        private void InitializationWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void InitializationWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = e.UserState.ToString();
        }
    }
}
