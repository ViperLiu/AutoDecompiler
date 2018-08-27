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
        private LibraryWorker Decompiler = new LibraryWorker(Library.Decompiler);

        public Form1()
        {
            InitializeComponent();
            var version = Application.ProductVersion;
            this.Text += string.Format(" - v{0}", version);
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
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            string dir = Path.GetDirectoryName(file[0]);
            string extension = Path.GetExtension(file[0]).ToLower();
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
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string extension = Path.GetExtension(file).ToLower();
                string dir = Path.GetDirectoryName(file);
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

            string args1 = textBox1.Text;
            string args2 = textBox1.Text + ".jar";
            string apkName = args1.Split('\\').Last<string>();
            string args3 = tbOutputDir.Text + "\\" + apkName + ".exctracted\\source code";
            string args4 = tbOutputDir.Text + "\\" + apkName + ".exctracted\\manifest";
            string args5 = tbOutputDir.Text + "\\" + apkName + ".exctracted\\manifest\\AndroidManifest.xml";

            Decompiler.SetOutputBox(tbOutput);
            Decompiler.AddParam(new string[] { args1, args2, args3, args4, args5 });
            Decompiler.JobFinished += Decompile_Completed;
            Decompiler.RunLibrary();
        }

        private void Decompile_Completed(object sender, EventArgs e)
        {
            this.btn_selectAPK.Enabled = true;
            this.btn_selectOutputDir.Enabled = true;
            this.btn_decompile.Enabled = true;
            this.lb_status.Visible = false;
            this.toolStripProgressBar1.Visible = false;
            MessageBox.Show("輸出完畢");
        }

        private void Btn_sendToMobSF_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            tb_APKFile.Text = textBox1.Text;
            tabControl1.SelectedTab = tab_MobSF;
            //btn_uploadAPK.Enabled = true;
            tb_APKFile.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProcessManager.TerminateAllProcess();
            /*if (Mobsf.Process != null)
                ProcessManager.KillProcess(Mobsf.Process.Id);
            if (Decompiler.Process != null)
                ProcessManager.KillProcess(Decompiler.Process.Id);*/
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.MobSF.Default.IsToolsUnzip == true)
                return;
            InitializationProcedure InitializationProcedure = new InitializationProcedure();
            InitializationProcedure.ShowDialog();
        }
        
        private void Btn_privacyCheck_Click(object sender, EventArgs e)
        {
            string apkName = textBox1.Text.Split('\\').Last<string>();
            string args = tbOutputDir.Text + "\\" + apkName + ".exctracted\\manifest\\AndroidManifest.xml";

            LibraryWorker PrivacyCheck = new LibraryWorker(Library.PrivacyCheck);
            PrivacyCheck.AddParam(new string[] { args });
            PrivacyCheck.SetOutputBox(this.tbOutput);
            PrivacyCheck.DataProcessor = PrivackyDataProcessor;
            PrivacyCheck.JobFinished += PrivacyCheck_Completed;
            PrivacyCheck.RunLibrary();
        }

        private void PrivacyCheck_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("掃描完成");
        }

        private string PrivackyDataProcessor(string data)
        {
            if (data.StartsWith("APP唯一識別："))
                return null;

            return data;
        }

        private void Btn_whiteSource_Click(object sender, EventArgs e)
        {
            string apkName = textBox1.Text.Split('\\').Last<string>();
            string targetFolder = tbOutputDir.Text + "\\" + apkName + ".exctracted";
            tb_WSTargetFolder.Text = targetFolder;
            tabControl1.SelectedTab = tab_WhiteSource;
            tb_WSTargetFolder.Focus();
        }

        private void Btn_ManifestCheck_Click(object sender, EventArgs e)
        {
            string apkName = textBox1.Text.Split('\\').Last<string>();
            string args = tbOutputDir.Text + "\\" + apkName + ".exctracted\\manifest\\AndroidManifest.xml";

            LibraryWorker ManifestCheck = new LibraryWorker(Library.ManifestCheck);
            ManifestCheck.AddParam(new string[] { args });
            ManifestCheck.SetOutputBox(this.tbOutput);
            //ManifestCheck.DataProcessor = PrivackyDataProcessor;
            //ManifestCheck.JobFinished += PrivacyCheck_Completed;
            ManifestCheck.RunLibrary();
        }
    }
}
