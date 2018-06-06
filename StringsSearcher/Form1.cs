using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;


namespace MASToolBox
{
    public partial class Form1 : Form
    {
        Process decompiler;
        
        ProcessStartInfo startInfo = new ProcessStartInfo();
        
        public Form1()
        {
            InitializeComponent();
            this.textBox1.DragEnter += new DragEventHandler(TxtFolderPath_DragEnter);
            this.textBox1.DragDrop += new DragEventHandler(TxtFolderPath_DragDrop);
        }


        public string GetSHA1()
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

        public string GetMD5()
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

        private void TxtFolderPath_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("drop");
            String[] file = (String[])e.Data.GetData(DataFormats.FileDrop);
            String dir = System.IO.Path.GetDirectoryName(file[0]);
            String extension = System.IO.Path.GetExtension(file[0]).ToLower();
            if (extension == ".ipa")
            {
                tbOutput.AppendText("ipa無法反組譯\r\n");
                btn_decompile.Enabled = false;
                btn_sendToMobSF.Enabled = false;
                this.tbOutputDir.Enabled = false;
                this.tbOutputDir.Text = "";
            }
            else if (extension == ".apk")
            {
                btn_decompile.Enabled = true;
                btn_sendToMobSF.Enabled = true;
                this.tbOutputDir.Enabled = true;
            }
            this.textBox1.Text = file[0];
            this.tbOutputDir.Text = dir;
            tbSHA1.Text = GetSHA1();
            tbMD5.Text = GetMD5();
        }

        private void TxtFolderPath_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("enter");
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


        private void Btn_selectAPK_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            String file = openFileDialog1.FileName;
            String extension = System.IO.Path.GetExtension(file).ToLower();
            String dir = System.IO.Path.GetDirectoryName(file);
            if (result == DialogResult.OK)
            {
                if (extension == ".apk")
                {
                    this.textBox1.Text = openFileDialog1.FileName;
                    this.tbOutputDir.Text = dir;
                    btn_decompile.Enabled = true;
                    btn_sendToMobSF.Enabled = true;
                    this.tbOutputDir.Enabled = true;
                    tbSHA1.Text = GetSHA1();
                    tbMD5.Text = GetMD5();
                }
                else if (extension == ".ipa")
                {
                    tbOutput.AppendText("ipa無法反組譯\r\n");
                    btn_decompile.Enabled = false;
                    btn_sendToMobSF.Enabled = false;
                    this.textBox1.Text = openFileDialog1.FileName;
                    this.tbOutputDir.Enabled = false;
                    this.tbOutputDir.Text = "";
                    tbSHA1.Text = GetSHA1();
                    tbMD5.Text = GetMD5();
                }
                else 
                {
                    tbOutput.AppendText("不支援此檔案格式\r\n");
                }
            }
        }

        private void Btn_selectOutputDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbOutputDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        void Process_Exited(object sender, EventArgs e)
        {
            MessageBox.Show("輸出完畢");
        }
        void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.tbOutput.Invoke((MethodInvoker)delegate
            {
                tbOutput.AppendText(e.Data + "\r\n");
            });
        }
        
        void Proc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            decompiler.Dispose();
            decompiler.Close();
            this.tbOutput.Invoke((MethodInvoker)delegate
            {
                tbOutput.AppendText(e.Data + "\r\n");
            });
        }

        private void DecompileWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string args1 = textBox1.Text;
            string args3 = textBox1.Text + ".jar";
            string apkName = args1.Split('\\').Last<string>();
            string args4 = tbOutputDir.Text + "\\" + apkName + ".exctracted\\source code";
            string arg5 = tbOutputDir.Text + "\\" + apkName + ".exctracted\\manifest";


            decompiler = new Process();

            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "tools\\decompiler.bat";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\"", args1, args3, args4, arg5);

            //tbOutput.Text = startInfo.Arguments;
            startInfo.CreateNoWindow = true;
            decompiler.StartInfo = startInfo;
            decompiler.SynchronizingObject = this;


            decompiler.Start();
            decompiler.ErrorDataReceived += Proc_ErrorDataReceived;
            decompiler.OutputDataReceived += Proc_OutputDataReceived;
            decompiler.EnableRaisingEvents = true;
            decompiler.Exited += new EventHandler(Process_Exited);
            decompiler.BeginOutputReadLine();
            decompiler.BeginErrorReadLine();
            decompiler.WaitForExit();
        }

        private void Btn_decompile_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || tbOutputDir.Text == "")
            {
                MessageBox.Show("請先選擇檔案與輸出資料夾");
                return;
            }
            this.btn_selectAPK.Enabled = false;
            this.btn_selectOutputDir.Enabled = false;
            this.btn_decompile.Enabled = false;
            this.lb_status.Text = "正在反組譯...";
            this.lb_status.Visible = true;
            this.toolStripProgressBar1.Visible = true;
            decompileWorker.RunWorkerAsync();
        }

        private void DecompileWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btn_selectAPK.Enabled = true;
            this.btn_selectOutputDir.Enabled = true;
            this.btn_decompile.Enabled = true;
            this.lb_status.Visible = false;
            this.toolStripProgressBar1.Visible = false;
            decompiler = null;
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }
        }

        private void Btn_sendToMobSF_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            tb_APKFile.Text = textBox1.Text;
            tabControl1.SelectedTab = tab_MobSF;
            btn_uploadAPK.Enabled = true;
            tb_APKFile.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mobsf != null)
                KillProcessAndChildren(mobsf.Id);
            if (decompiler != null)
                KillProcessAndChildren(decompiler.Id);
        }

        
    }
}
