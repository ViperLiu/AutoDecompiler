using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Management;
using System.Web;
using AndroidDecompiler;


namespace StringsSearcher
{
    public partial class Form1 : Form
    {
        Process process;
        Process mobsf;
        ProcessStartInfo startInfo = new ProcessStartInfo();
        public Form1()
        {
            InitializeComponent();
            this.textBox1.DragEnter += new DragEventHandler(txtFolderPath_DragEnter);
            this.textBox1.DragDrop += new DragEventHandler(txtFolderPath_DragDrop);
        }

        public string getSHA1()
        {
            if (textBox1.Text == "")
                return null;
            string location = textBox1.Text;
            byte[] apkByte = File.ReadAllBytes(location);
            SHA1 sha1 = new SHA1CryptoServiceProvider();//建立一個SHA1
            byte[] crypto = sha1.ComputeHash(apkByte);//進行SHA1加密
            string result = BitConverter.ToString(crypto);//把加密後的字串從Byte[]轉為字串
            result = result.Replace("-", "").ToLower();
            return result;
        }

        public string getMD5()
        {
            if (textBox1.Text == "")
                return null;
            string location = textBox1.Text;
            byte[] apkByte = File.ReadAllBytes(location);
            MD5 md5 = MD5.Create();//建立一個md5
            byte[] crypto = md5.ComputeHash(apkByte);//進行md5加密
            string result = BitConverter.ToString(crypto);//把加密後的字串從Byte[]轉為字串
            result = result.Replace("-", "").ToLower();
            return result;
        }

        private void txtFolderPath_DragDrop(object sender, DragEventArgs e)
        {
            String[] file = (String[])e.Data.GetData(DataFormats.FileDrop);
            String dir = System.IO.Path.GetDirectoryName(file[0]);
            String extension = System.IO.Path.GetExtension(file[0]).ToLower();
            if (extension == ".ipa")
            {
                tbOutput.AppendText("ipa無法反組譯\r\n");
                btn_decompile.Enabled = false;
                this.tbOutputDir.Enabled = false;
                this.tbOutputDir.Text = "";
            }
            else if (extension == ".apk")
            {
                btn_decompile.Enabled = true;
                this.tbOutputDir.Enabled = true;
            }
            this.textBox1.Text = file[0];
            this.tbOutputDir.Text = dir;
            tbSHA1.Text = getSHA1();
            tbMD5.Text = getMD5();
        }

        private void txtFolderPath_DragEnter(object sender, DragEventArgs e)
        {
            String[] file = (String[])e.Data.GetData(DataFormats.FileDrop);
            String extension = System.IO.Path.GetExtension(file[0]);
            extension = extension.ToLower();
            if (extension == ".apk" || extension ==".ipa")
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void btn_selectAPK_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            String file = openFileDialog1.FileName;
            String extension = System.IO.Path.GetExtension(file);
            String dir = System.IO.Path.GetDirectoryName(file);
            if (result == DialogResult.OK)
            {
                if (extension == ".apk" || extension == ".APK")
                {
                    this.textBox1.Text = openFileDialog1.FileName;
                    this.tbOutputDir.Text = dir;
                    btn_decompile.Enabled = true;
                    this.tbOutputDir.Enabled = true;
                    tbSHA1.Text = getSHA1();
                    tbMD5.Text = getMD5();
                }
                else if (extension == ".ipa")
                {
                    tbOutput.AppendText("ipa無法反組譯\r\n");
                    btn_decompile.Enabled = false;
                    this.textBox1.Text = openFileDialog1.FileName;
                    this.tbOutputDir.Enabled = false;
                    this.tbOutputDir.Text = "";
                    tbSHA1.Text = getSHA1();
                    tbMD5.Text = getMD5();
                }
                else 
                {
                    tbOutput.AppendText("不支援此檔案格式\r\n");
                }
            }
        }

        private void btn_selectOutputDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbOutputDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        void process_Exited(object sender, EventArgs e)
        {
            MessageBox.Show("輸出完畢");
        }
        void proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.tbOutput.Invoke((MethodInvoker)delegate
            {
                tbOutput.AppendText(e.Data + "\r\n");
            });
        }
        
        void proc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            process.Dispose();
            process.Close();
            this.tbOutput.Invoke((MethodInvoker)delegate
            {
                tbOutput.AppendText(e.Data + "\r\n");
            });
        }

        private void decompileWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string args1 = textBox1.Text;
            string args3 = textBox1.Text + ".jar";
            string apkName = args1.Split('\\').Last<string>();
            string args4 = tbOutputDir.Text + "\\" + apkName + ".exctracted\\source code";
            string arg5 = tbOutputDir.Text + "\\" + apkName + ".exctracted\\manifest";


            process = new Process();

            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "tools\\decompiler.bat";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\"", args1, args3, args4, arg5);

            //tbOutput.Text = startInfo.Arguments;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.SynchronizingObject = this;


            process.Start();
            process.ErrorDataReceived += proc_ErrorDataReceived;
            process.OutputDataReceived += proc_OutputDataReceived;
            process.EnableRaisingEvents = true;
            process.Exited += new EventHandler(process_Exited);
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
        }

        private void btn_decompile_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || tbOutputDir.Text == "")
            {
                MessageBox.Show("請先選擇檔案與輸出資料夾");
                return;
            }
            this.btn_selectAPK.Enabled = false;
            this.btn_selectOutputDir.Enabled = false;
            this.btn_decompile.Enabled = false;
            this.progressBar1.Visible = true;
            decompileWorker.RunWorkerAsync();
        }

        private void decompileWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btn_selectAPK.Enabled = true;
            this.btn_selectOutputDir.Enabled = true;
            this.btn_decompile.Enabled = true;
            this.progressBar1.Visible = false;
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }
        }

        private void btn_encode_Click(object sender, EventArgs e)
        {
            string input = tb_converterInput.Text;
            string output = "";
            byte[] input_bytes = System.Text.Encoding.UTF8.GetBytes(input);
            output = Convert.ToBase64String(input_bytes);
            tb_converterOutput.Text = output;
        }

        private void btn_decode_Click(object sender, EventArgs e)
        {
            string input = tb_converterInput.Text;
            string output = "";
            output = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
            tb_converterOutput.Text = output;
        }

        private void MobSFWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string args1 = tb_MobSFPath.Text + "\\manage.py";
            string args2 = "runserver";

            this.mobsf = new Process();


            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "python.exe";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.Arguments = string.Format("\"{0}\" \"{1}\"", args1, args2);

            //tbOutput.Text = startInfo.Arguments;
            startInfo.CreateNoWindow = true;
            mobsf.StartInfo = startInfo;
            mobsf.SynchronizingObject = this;

            try
            {
                mobsf.Start();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("找不到python.exe，請確定python.exe的路徑是否有加入至系統路徑中");
            }
            mobsf.ErrorDataReceived += proc_mobsf_OutputDataReceived;
            mobsf.OutputDataReceived += proc_mobsf_OutputDataReceived;
            mobsf.EnableRaisingEvents = true;
            mobsf.Exited += new EventHandler(proc_mobsf_Exited);
            mobsf.BeginOutputReadLine();
            mobsf.BeginErrorReadLine();
            mobsf.WaitForExit();
        }

        void proc_mobsf_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
                return;
            this.tbOutput.Invoke((MethodInvoker)delegate
            {
                tb_MobSFOutput.AppendText(e.Data + "\r\n");
            });
            if (e.Data.StartsWith("REST"))
            {
                MobSF.APIKey = e.Data.Split(':')[1];
                AndroidDecompiler.Properties.MobSF.Default.APIKey = e.Data.Split(':')[1];
                AndroidDecompiler.Properties.MobSF.Default.Save();
            }
            if (e.Data.StartsWith("[WARN] A new version") || e.Data.StartsWith("[INFO] No updates available."))
            {
                this.tbOutput.Invoke((MethodInvoker)delegate
                {
                    tb_MobSFOutput.AppendText("Ready!!\r\n");
                });
            }
        }
        void proc_mobsf_Exited(object sender, EventArgs e)
        {
            MessageBox.Show("MobSF已關閉");
        }

        private void btn_startMobSF_Click(object sender, EventArgs e)
        {
            this.tb_MobSFOutput.Text = "";
            if (!File.Exists(this.tb_MobSFPath.Text + "\\manage.py"))
            {
                MessageBox.Show("路徑下沒有發現manage.py，請選取manage.py所在的資料夾");
                return;
            }

            if (AndroidDecompiler.Properties.MobSF.Default.IsFirstRun)
            {
                this.tb_MobSFOutput.AppendText("正在準備MobSF...\r\n");
                try
                {
                    this.tb_MobSFOutput.AppendText("正在備份utils.py到" + this.tb_MobSFPath.Text + "\\backup\\...\r\n");
                    MobSF.BackupFile();
                    this.tb_MobSFOutput.AppendText("正在修改utils.py...\r\n");
                    MobSF.Patch();
                }
                catch (Exception error)
                {
                    this.tb_MobSFOutput.AppendText(error.Message);
                    return;
                }
                AndroidDecompiler.Properties.MobSF.Default.IsFirstRun = false;
                AndroidDecompiler.Properties.MobSF.Default.IsMobSFPatched = true;
                AndroidDecompiler.Properties.MobSF.Default.Save();
            }


            btn_startMobSF.Enabled = false;
            btn_stopMobSF.Enabled = true;
            
            MobSFWorker.RunWorkerAsync();
        }

        private void MobSFWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_startMobSF.Enabled = true;
            btn_stopMobSF.Enabled = false;
        }

        private void btn_stopMobSF_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("此動作將會結束\"所有\"的python程式，請確認沒有任何重要的python程式在運行", "即將關閉所有python程式", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Cancel)
                return;
            Process[] localByName = Process.GetProcessesByName("python");
            try
            {
                for (int i = 0; i < localByName.Length; i++)
                    localByName[i].Kill();
                tb_MobSFOutput.AppendText("MobSF已關閉\r\n");
            }
            catch { }
        }

        private void btn_MobSFPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_MobSFPath.Text = folderBrowserDialog1.SelectedPath;
                AndroidDecompiler.Properties.MobSF.Default.MobSFPath = folderBrowserDialog1.SelectedPath;
                AndroidDecompiler.Properties.MobSF.Default.Save();
            }
        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            TabControl tmp = (TabControl)sender;
            if (tmp.SelectedTab == tmp.TabPages["tab_MobSF"])
            {
                this.loadSettings();
            }
        }

        public void loadSettings()
        {
            this.tb_MobSFPath.Text = AndroidDecompiler.Properties.MobSF.Default.MobSFPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AndroidDecompiler.Properties.MobSF.Default.Reset();
        }

        
    }
}
