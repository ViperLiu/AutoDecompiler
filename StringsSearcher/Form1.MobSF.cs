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
        JObject responseJson;
        private LibraryWorker Mobsf = new LibraryWorker(Library.MobSF);

        private static Properties.MobSF MobSFSettings = Properties.MobSF.Default;

        private void Tb_APKFile_DragDrop(object sender, DragEventArgs e)
        {
            String[] file = (String[])e.Data.GetData(DataFormats.FileDrop);
            String dir = Path.GetDirectoryName(file[0]);
            String extension = Path.GetExtension(file[0]).ToLower();
            if (extension == ".apk")
            {
                tb_APKFile.Text = file[0];
            }
        }

        private void Tb_APKFile_DragEnter(object sender, DragEventArgs e)
        {
            String[] file = (String[])e.Data.GetData(DataFormats.FileDrop);
            String extension = Path.GetExtension(file[0]).ToLower();
            if (extension == ".apk")
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //上傳與掃描APK的background worker
        private void RequestWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            var response = MobSF.UploadScan(tb_APKFile.Text);
            responseJson = JObject.Parse(response);
        }

        //上傳與掃描APK的background worker
        private void RequestWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStrip.Visible = false;
            toolStripProgressBar1.Visible = false;
            btn_uploadAPK.Enabled = true;
            var url = "http://127.0.0.1:8000/StaticAnalyzer/?name=" + MobSF.fileInfo["file_name"] +
                    "&type=apk&checksum=" + MobSF.fileInfo["hash"];
            try
            {
                Process.Start(url);
            }
            catch
            {
                tb_MobSFOutput.AppendText("Cannot open \"" + url + "\"\r\n");
            }
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

            //MobSFWorker.RunWorkerAsync();
            string args1 = MobSFSettings.MobSFPath + "\\manage.py";

            this.Mobsf.SetOutputBox(this.tb_MobSFOutput);
            this.Mobsf.AddParam(new string[] { args1 });
            this.Mobsf.JobFinished += Mobsf_Completed;
            this.Mobsf.DataProcessor = MobSFDataProcessor;
            this.Mobsf.RunLibrary();

        }

        private void Mobsf_Completed(object sender, EventArgs e)
        {
            btn_startMobSF.Enabled = true;
            btn_stopMobSF.Enabled = false;
            btn_resetMobSF.Enabled = true;
            btn_uploadAPK.Enabled = false;
            btn_MobSFPath.Enabled = true;
            
            //tb_MobSFOutput.AppendText("MobSF已關閉\r\n");
            MessageBox.Show("MobSF已關閉");
        }

        private void Btn_stopMobSF_Click(object sender, EventArgs e)
        {
            if (Mobsf.Process == null)
                return;
            KillProcessAndChildren(Mobsf.Process.Id);
            btn_uploadAPK.Enabled = false;
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
            if (result == DialogResult.Cancel)
            {
                return;
            }

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

        //關閉process
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
            catch
            {
                // Process already exited.
                //MessageBox.Show(e.Message);
            }
        }

        private void Btn_uploadAPK_Click(object sender, EventArgs e)
        {
            if (tb_APKFile.Text == "")
                return;
            RequestWorker.RunWorkerAsync();
            lb_status.Text = "掃描中...";
            lb_status.Visible = true;
            toolStripProgressBar1.Visible = true;
            btn_uploadAPK.Enabled = false;
        }

        private void Btn_selectAPK2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            String file = openFileDialog1.FileName;
            String extension = System.IO.Path.GetExtension(file).ToLower();
            String dir = System.IO.Path.GetDirectoryName(file);
            if (result == DialogResult.OK)
            {
                if (extension == ".apk")
                {
                    this.tb_APKFile.Text = openFileDialog1.FileName;
                    btn_uploadAPK.Enabled = true;
                }
                else
                {
                    tb_MobSFOutput.AppendText("不支援此檔案格式\r\n");
                }
            }
            openFileDialog1.Dispose();
        }

        private static string MobSFDataProcessor(string data)
        {
            //REST開頭即為APIKey
            if (data.StartsWith("REST"))
            {
                Properties.MobSF.Default.APIKey = data.Split(':')[1].Trim();
                Properties.MobSF.Default.Save();
            }

            //當MobSF輸出這些字時，代表已啟動完成
            else if (data.StartsWith("[WARN] A new version") || data.StartsWith("[INFO] No updates available."))
            {
                data = data + "\r\nReady!!\r\n";
            }
            return data;
        }
    }
}
