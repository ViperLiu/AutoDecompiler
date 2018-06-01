using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Management;
using Newtonsoft.Json.Linq;


namespace MASToolBox
{
    public partial class Form1
    {
        Process mobsf;
        JObject responseJson;
        private static MASToolBox.Properties.MobSF MobSFSettings = MASToolBox.Properties.MobSF.Default;

        private void RequestWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            var response = MobSF.UploadScan("http://127.0.0.1:8000/api/v1/upload", tb_APKFile.Text);
            responseJson = JObject.Parse(response);
        }

        private void RequestWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStrip.Visible = false;
            toolStripProgressBar1.Visible = false;
            btn_uploadAPK.Enabled = true;
            tb_MobSFOutput.AppendText(responseJson["manifest"][0]["title"] + "\r\n");
            MessageBox.Show((responseJson["manifest"][0]["title"]).ToString());
        }

        private void MobSFWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string args1 = MobSFSettings.MobSFPath + "\\manage.py";
            string args2 = "runserver";

            this.mobsf = new Process();

            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "python.exe";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.Arguments = string.Format("\"{0}\" \"{1}\"", args1, args2);
            startInfo.CreateNoWindow = true;

            mobsf.StartInfo = startInfo;
            mobsf.SynchronizingObject = this;

            //執行python.exe
            try
            {
                mobsf.Start();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("找不到python.exe，請確定python.exe的路徑是否有加入至系統路徑中");
            }

            mobsf.ErrorDataReceived += Proc_mobsf_OutputDataReceived;
            mobsf.OutputDataReceived += Proc_mobsf_OutputDataReceived;
            mobsf.BeginOutputReadLine();
            mobsf.BeginErrorReadLine();
            mobsf.WaitForExit();
        }

        private void Proc_mobsf_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
                return;

            //在textbox上輸出MobSF狀態
            this.tbOutput.Invoke((MethodInvoker)delegate
            {
                tb_MobSFOutput.AppendText(e.Data + "\r\n");
            });

            //REST開頭即為APIKey
            if (e.Data.StartsWith("REST"))
            {
                MobSFSettings.APIKey = e.Data.Split(':')[1].Trim();
                MobSFSettings.Save();
            }

            //當MobSF輸出這些字時，代表已啟動完成
            if (e.Data.StartsWith("[WARN] A new version") || e.Data.StartsWith("[INFO] No updates available."))
            {
                btn_uploadAPK.Enabled = true;
                this.tbOutput.Invoke((MethodInvoker)delegate
                {
                    tb_MobSFOutput.AppendText("Ready!!\r\n");
                });
            }
        }

        private void MobSFWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_startMobSF.Enabled = true;
            btn_stopMobSF.Enabled = false;
            btn_resetMobSF.Enabled = true;
            btn_uploadAPK.Enabled = false;
            btn_MobSFPath.Enabled = false;
            tb_MobSFOutput.AppendText("MobSF已關閉\r\n");
            MessageBox.Show("MobSF已關閉");
        }

        private void Btn_startMobSF_Click(object sender, EventArgs e)
        {
            this.tb_MobSFOutput.Text = "";
            if (!File.Exists(MobSFSettings.MobSFPath + "\\manage.py"))
            {
                MessageBox.Show("選取的路徑下沒有發現manage.py，請選取manage.py所在的資料夾");
                return;
            }

            //初次啟動MobSF時的程序
            if (MobSFSettings.IsFirstRun)
            {
                FirstRunProcedure();
            }

            btn_startMobSF.Enabled = false;
            btn_stopMobSF.Enabled = true;
            btn_resetMobSF.Enabled = false;
            btn_MobSFPath.Enabled = false;

            MobSFWorker.RunWorkerAsync();
        }

        private void Btn_stopMobSF_Click(object sender, EventArgs e)
        {
            if (mobsf == null)
                return;
            KillProcessAndChildren(mobsf.Id);
        }

        private void Btn_MobSFPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_MobSFPath.Text = folderBrowserDialog1.SelectedPath;
                MobSFSettings.MobSFPath = folderBrowserDialog1.SelectedPath;
                MobSFSettings.Save();
            }
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            TabControl tmp = (TabControl)sender;
            if (tmp.SelectedTab == tmp.TabPages["tab_MobSF"])
            {
                this.LoadSettings();
            }
        }

        //初次啟動MobSF時會執行
        private void FirstRunProcedure()
        {
            bool isProcedureFail = false;
            this.tb_MobSFOutput.AppendText("正在準備MobSF...\r\n");
            foreach (var file in MobSF.filesToProcess)
            {
                try
                {
                    this.tb_MobSFOutput.AppendText("正在備份" + file + "到" + MobSFSettings.MobSFPath + "\\backup\\...\r\n");
                    MobSF.BackupFile(file);

                    this.tb_MobSFOutput.AppendText("正在修改" + file + "...\r\n");
                    MobSF.PatchMobSF(file);
                }
                catch(Exception error)
                {
                    this.tb_MobSFOutput.AppendText(error.Message + "\r\n");
                    isProcedureFail = true;
                }
            }

            //上方執行成功才執行這段
            if (!isProcedureFail)
            {
                //將設定檔中的初次執行flag設成false，表示已經執行過初次啟動的程序了
                MobSFSettings.IsFirstRun = false;

                //表示已經修改過utils.py了
                MobSFSettings.IsMobSFPatched = true;
                MobSFSettings.Save();
            }
        }

        public void LoadSettings()
        {
            this.tb_MobSFPath.Text = MobSFSettings.MobSFPath;
        }

        private void Btn_resetMobSF_Click(object sender, EventArgs e)
        {
            //從設定中取得MobSF的資料夾路徑
            string path = MobSFSettings.MobSFPath;

            if (path == "")
            {
                MessageBox.Show("請先指定MobSF路徑");
                return;
            }
            var totalFilesCount = MobSF.filesToProcess.Length;
            var successFilesCount = totalFilesCount;
            var failFilesCount = 0;

            var result = MessageBox.Show("即將把所有MobSF相關設定及檔案還原成預設值，確定嗎？", "還原成預設值"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Cancel)
                return;

            tb_MobSFOutput.Text = "";

            foreach (var file in MobSF.filesToProcess)
            {
                try
                {
                    this.tb_MobSFOutput.AppendText("正在還原" + file + "...\r\n");
                    MobSF.RecoveryFileFromBackup(file);
                }
                catch (Exception error)
                {
                    this.tb_MobSFOutput.AppendText(error.Message + "\r\n");
                    successFilesCount--;
                    failFilesCount++;
                }
            }
            tb_MobSFOutput.AppendText("總檔案數：" + totalFilesCount + "\r\n");
            tb_MobSFOutput.AppendText("成功：" + successFilesCount + ", 失敗：" + failFilesCount + "\r\n");

            tb_MobSFOutput.AppendText("正在還原設定檔...\r\n");
            MobSFSettings.Reset();
            MobSFSettings.Save();

            tb_MobSFOutput.AppendText("還原完畢，MobSF已經回復成預設值\r\n");
            LoadSettings();
        }

        private static void KillProcessAndChildren(int pid)
        {
            // Cannot close 'system idle process'.
            if (pid == 0)
            {
                return;
            }
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
              ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
                MessageBox.Show("停止MobSF時發生錯誤");
            }
        }

        private void Btn_uploadAPK_Click(object sender, EventArgs e)
        {
            /*var result = MobSF.UploadScan("http://127.0.0.1:8000/api/v1/upload", tb_APKFile.Text);

            JObject json = JObject.Parse(result);

            tb_MobSFOutput.AppendText(json["manifest"][0]["title"] + "\r\n");*/

            RequestWorker.RunWorkerAsync();
            lb_status.Text = "掃描中...";
            lb_status.Visible = true;
            toolStripProgressBar1.Visible = true;
            btn_uploadAPK.Enabled = false;
            
        }
    }
}
