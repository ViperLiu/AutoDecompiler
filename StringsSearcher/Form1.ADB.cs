using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MASToolBox
{
    partial class Form1
    {
        string PhoneBrand = "";
        string PhoneModel = "";
        bool IsInstallSuccess = false;
        bool FirstFoundPhone = false;
        List<string> RecievedData = new List<string>();

        #region ADB Check
        private void Btn_checkADB_Click(object sender, EventArgs e)
        {
            ADBCheckPhone();
        }

        private void ADBCheckPhone()
        {
            label_PhoneStatus.Text = "正在檢查裝置 ...";
            LibraryWorker adb = new LibraryWorker(Library.ADB);
            adb.AddParam(new string[] { "-d", "shell", "getprop" });
            adb.SetOutputBox(rtb_adbOutput);
            adb.DataProcessor = AdbGetPhoneBrandModel;
            adb.JobFinished += PhoneFound;
            adb.RunLibrary();
        }

        private void PhoneFound(object sender, EventArgs e)
        {
            if (PhoneBrand == null)
            {
                label_PhoneStatus.Text = "找不到可用的裝置";
                MessageBox.Show("找不到可用的裝置", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                label_PhoneStatus.Text = "找到裝置 : " + PhoneBrand + " " + PhoneModel;
                FirstFoundPhone = true;
            }
        }

        private string AdbGetPhoneBrandModel(string data)
        {
            if (data.StartsWith("error:"))
            {
                PhoneBrand = null;
            }
            var tmp = data.Replace("[", "").Replace("]", "");
            if (tmp.StartsWith("ro.product.brand"))
            {
                var brand = tmp.Split(':')[1].Trim();
                PhoneBrand = brand.ToUpper();
            }
            if(tmp.StartsWith("ro.product.model"))
            {
                var model = tmp.Split(':')[1].Trim();
                PhoneModel = model.ToUpper();
            }
            return "";
        }
        #endregion

        #region Install APK
        private void Btn_InstallAPK_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "apk檔|*.apk";
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;
                rtb_adbOutput.AppendText("正在安裝APK...\r\n");

                LibraryWorker adbInstall = new LibraryWorker(Library.ADB);
                adbInstall.AddParam(new string[] { "-d", "install", file });
                adbInstall.SetOutputBox(rtb_adbOutput);
                adbInstall.JobFinished += APKInstallCompleted;
                adbInstall.DataProcessor = InstallDataProcessor;
                adbInstall.RunLibrary();
            }

            openFileDialog1.Filter = "";
        }

        private string InstallDataProcessor(string data)
        {
            RecievedData.Add(data);
            if(data.StartsWith("Success"))
            {
                IsInstallSuccess = true;
                return "安裝成功";
            }
            return "";
        }

        private void APKInstallCompleted(object sender, EventArgs e)
        {
            if(!IsInstallSuccess)
            {
                rtb_adbOutput.AppendText("安裝失敗：\r\n");
                foreach (var d in RecievedData)
                {
                    rtb_adbOutput.AppendText(d + "\r\n");
                    rtb_adbOutput.ScrollToCaret();
                }
            }
            RecievedData.Clear();
            IsInstallSuccess = false;
            MessageBox.Show("Install completed");
        }
        #endregion

        private void Btn_LoadPackageList_Click(object sender, EventArgs e)
        {
            LibraryWorker pkgListLoader = new LibraryWorker(Library.ADB);
            pkgListLoader.SetOutputBox(rtb_adbOutput);
            pkgListLoader.AddParam(new string[] { "shell", "pm", "list", "packages", "-3" });
            pkgListLoader.DataProcessor = PkgDataProcessor;
            pkgListLoader.RunLibrary();
        }

        private string PkgDataProcessor(string data)
        {
            if (data.StartsWith("package"))
            {
                ListViewItem pkg = new ListViewItem(data.Split(':')[1]);
                
                this.listView1.Invoke((MethodInvoker)delegate
                {
                    listView1.Items.Add(pkg);
                });
            }
            return "";
        }

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    menuItem_PullData.Tag = listView1.FocusedItem.Text;
                    contextMenu_ADB.Show(Cursor.Position);
                }
            }
        }

        private void ContextMenu_ADB_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            contextMenu_ADB.Hide();
            var result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK)
                return;
            var pkgName = e.ClickedItem.Tag as string;
            var dataFolder = "/data/data/" + pkgName;
            var sdcardFolder = "/sdcard/" + pkgName;
            var outputFolder = folderBrowserDialog1.SelectedPath + "\\" + pkgName;
            LibraryWorker cp = new LibraryWorker(Library.ADBPull);
            cp.AddParam(new string[] { dataFolder, sdcardFolder, outputFolder });
            cp.SetOutputBox(rtb_adbOutput);
            cp.JobFinished += Cp_Completed;
            cp.RunLibrary();
            
        }

        private void Cp_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("複製完成");
        }
    }
}
