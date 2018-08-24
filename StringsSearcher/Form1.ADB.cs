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
    }
}
