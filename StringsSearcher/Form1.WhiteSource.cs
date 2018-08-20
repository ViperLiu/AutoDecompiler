using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASToolBox
{
    partial class Form1
    {
        bool progressbar = false;
        string previousData = "";

        private void Btn_WSScan_Click(object sender, EventArgs e)
        {
            if(tb_WSProjectName.Text == "" || tb_WSTargetFolder.Text == "")
            {
                MessageBox.Show("目標資料夾與Project Name不可為空");
                return;
            }

            var targetFolder = tb_WSTargetFolder.Text;
            var projectName = tb_WSProjectName.Text;
            var configFile = cb_OAInternet.Checked ?
                "tools\\wss\\OA-whitesource-fs-agent.config" : "tools\\wss\\whitesource-fs-agent.config";

            LibraryWorker WhiteSource = new LibraryWorker(Library.WhiteSource);
            WhiteSource.AddParam(new string[] { configFile, targetFolder, projectName });
            WhiteSource.SetOutputBox(this.rtb_WhiteSource);
            WhiteSource.JobFinished += WhiteSoutce_Completed;
            WhiteSource.DataProcessor = WSDataProcessor;
            WhiteSource.RunLibrary();
        }

        private string WSDataProcessor(string data)
        {
            if (data.Contains("0% - 0 of"))
            {
                progressbar = true;
                previousData = data;
                return data;
            }

            if (progressbar)
            {
                if (data.Contains("100%"))
                    progressbar = false;
                this.rtb_WhiteSource.Invoke((MethodInvoker)delegate
                {
                    rtb_WhiteSource.Text = rtb_WhiteSource.Text.Replace(previousData, data);
                    previousData = data;
                });
                return "";
            }

            return data;
        }

        private void WhiteSoutce_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("WhiteSource Completed");
        }

        private void Btn_WSSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_WSTargetFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Rtb_WhiteSource_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
