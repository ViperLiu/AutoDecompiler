﻿namespace MASToolBox
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_selectAPK = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_selectOutputDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutputDir = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMD5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSHA1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.decompileWorker = new System.ComponentModel.BackgroundWorker();
            this.btn_decompile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_whiteSource = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            this.btn_privacyCheck = new System.Windows.Forms.Button();
            this.btn_ManifestCheck = new System.Windows.Forms.Button();
            this.btn_sendToMobSF = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_decode = new System.Windows.Forms.Button();
            this.btn_encode = new System.Windows.Forms.Button();
            this.tb_converterOutput = new System.Windows.Forms.TextBox();
            this.tb_converterInput = new System.Windows.Forms.TextBox();
            this.tab_MobSF = new System.Windows.Forms.TabPage();
            this.tb_MobSFOutput = new System.Windows.Forms.RichTextBox();
            this.btn_uploadAPK = new System.Windows.Forms.Button();
            this.btn_resetMobSF = new System.Windows.Forms.Button();
            this.btn_stopMobSF = new System.Windows.Forms.Button();
            this.btn_startMobSF = new System.Windows.Forms.Button();
            this.btn_selectAPK2 = new System.Windows.Forms.Button();
            this.tb_APKFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_MobSFPath = new System.Windows.Forms.Button();
            this.tb_MobSFPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtb_nmapResult = new System.Windows.Forms.RichTextBox();
            this.btn_screenshot = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.TextBox();
            this.port_txt = new System.Windows.Forms.Label();
            this.port_box = new System.Windows.Forms.TextBox();
            this.ip_txt = new System.Windows.Forms.Label();
            this.ip_box = new System.Windows.Forms.TextBox();
            this.ssl_bt = new System.Windows.Forms.Button();
            this.cer_bt = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_keywordScreenshot = new System.Windows.Forms.Button();
            this.btn_startSearch = new System.Windows.Forms.Button();
            this.rtb_searchResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SearchTargetFolder = new System.Windows.Forms.TextBox();
            this.btn_selectTargetFolder = new System.Windows.Forms.Button();
            this.tb_payloadPath = new System.Windows.Forms.TextBox();
            this.btn_selectPayload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_WhiteSource = new System.Windows.Forms.TabPage();
            this.btn_WSScan = new System.Windows.Forms.Button();
            this.cb_OAInternet = new System.Windows.Forms.CheckBox();
            this.tb_WSProjectName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_WSSelectFolder = new System.Windows.Forms.Button();
            this.tb_WSTargetFolder = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtb_WhiteSource = new System.Windows.Forms.RichTextBox();
            this.tab_ADB = new System.Windows.Forms.TabPage();
            this.btn_LoadPackageList = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_PhoneStatus = new System.Windows.Forms.Label();
            this.btn_InstallAPK = new System.Windows.Forms.Button();
            this.rtb_adbOutput = new System.Windows.Forms.RichTextBox();
            this.btn_checkADB = new System.Windows.Forms.Button();
            this.MobSFWorker = new System.ComponentModel.BackgroundWorker();
            this.RequestWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip = new System.Windows.Forms.StatusStrip();
            this.lb_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.SearchWorker = new System.ComponentModel.BackgroundWorker();
            this.saveScreenshotDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenu_ADB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_PullData = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ADBDriver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tab_MobSF.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tab_WhiteSource.SuspendLayout();
            this.tab_ADB.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenu_ADB.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(5, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(284, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFolderPath_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFolderPath_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "apk或ipa檔：";
            // 
            // btn_selectAPK
            // 
            this.btn_selectAPK.Location = new System.Drawing.Point(312, 6);
            this.btn_selectAPK.Name = "btn_selectAPK";
            this.btn_selectAPK.Size = new System.Drawing.Size(76, 39);
            this.btn_selectAPK.TabIndex = 2;
            this.btn_selectAPK.Text = "選擇檔案";
            this.btn_selectAPK.UseVisualStyleBackColor = true;
            this.btn_selectAPK.Click += new System.EventHandler(this.Btn_selectAPK_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\劉建毅\\Desktop";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // btn_selectOutputDir
            // 
            this.btn_selectOutputDir.Location = new System.Drawing.Point(312, 49);
            this.btn_selectOutputDir.Name = "btn_selectOutputDir";
            this.btn_selectOutputDir.Size = new System.Drawing.Size(76, 39);
            this.btn_selectOutputDir.TabIndex = 7;
            this.btn_selectOutputDir.Text = "選擇資料夾";
            this.btn_selectOutputDir.UseVisualStyleBackColor = true;
            this.btn_selectOutputDir.Click += new System.EventHandler(this.Btn_selectOutputDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(2, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "原始碼輸出資料夾：";
            // 
            // tbOutputDir
            // 
            this.tbOutputDir.AllowDrop = true;
            this.tbOutputDir.Location = new System.Drawing.Point(4, 66);
            this.tbOutputDir.Name = "tbOutputDir";
            this.tbOutputDir.Size = new System.Drawing.Size(284, 22);
            this.tbOutputDir.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "MD5：";
            // 
            // tbMD5
            // 
            this.tbMD5.AllowDrop = true;
            this.tbMD5.Location = new System.Drawing.Point(8, 37);
            this.tbMD5.Name = "tbMD5";
            this.tbMD5.ReadOnly = true;
            this.tbMD5.Size = new System.Drawing.Size(367, 22);
            this.tbMD5.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbSHA1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbMD5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash Values";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(2, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 116);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hash Values";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(8, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(368, 22);
            this.textBox2.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F);
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "SHA1：";
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.Location = new System.Drawing.Point(8, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(367, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F);
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "MD5：";
            // 
            // tbSHA1
            // 
            this.tbSHA1.AllowDrop = true;
            this.tbSHA1.Location = new System.Drawing.Point(8, 81);
            this.tbSHA1.Name = "tbSHA1";
            this.tbSHA1.ReadOnly = true;
            this.tbSHA1.Size = new System.Drawing.Size(368, 22);
            this.tbSHA1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "SHA1：";
            // 
            // btn_decompile
            // 
            this.btn_decompile.Enabled = false;
            this.btn_decompile.Location = new System.Drawing.Point(6, 213);
            this.btn_decompile.Name = "btn_decompile";
            this.btn_decompile.Size = new System.Drawing.Size(76, 39);
            this.btn_decompile.TabIndex = 15;
            this.btn_decompile.Text = "輸出原始碼";
            this.btn_decompile.UseVisualStyleBackColor = true;
            this.btn_decompile.Click += new System.EventHandler(this.Btn_decompile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tab_MobSF);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tab_WhiteSource);
            this.tabControl1.Controls.Add(this.tab_ADB);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 421);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.btn_whiteSource);
            this.tabPage1.Controls.Add(this.tbOutput);
            this.tabPage1.Controls.Add(this.btn_privacyCheck);
            this.tabPage1.Controls.Add(this.btn_ManifestCheck);
            this.tabPage1.Controls.Add(this.btn_sendToMobSF);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btn_decompile);
            this.tabPage1.Controls.Add(this.btn_selectOutputDir);
            this.tabPage1.Controls.Add(this.tbOutputDir);
            this.tabPage1.Controls.Add(this.btn_selectAPK);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Decompiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_whiteSource
            // 
            this.btn_whiteSource.Location = new System.Drawing.Point(273, 294);
            this.btn_whiteSource.Name = "btn_whiteSource";
            this.btn_whiteSource.Size = new System.Drawing.Size(112, 80);
            this.btn_whiteSource.TabIndex = 20;
            this.btn_whiteSource.Text = "WhiteSource掃描";
            this.btn_whiteSource.UseVisualStyleBackColor = true;
            this.btn_whiteSource.Click += new System.EventHandler(this.Btn_whiteSource_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(394, 0);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(524, 395);
            this.tbOutput.TabIndex = 19;
            this.tbOutput.Text = "";
            // 
            // btn_privacyCheck
            // 
            this.btn_privacyCheck.Location = new System.Drawing.Point(140, 294);
            this.btn_privacyCheck.Name = "btn_privacyCheck";
            this.btn_privacyCheck.Size = new System.Drawing.Size(112, 80);
            this.btn_privacyCheck.TabIndex = 18;
            this.btn_privacyCheck.Text = "隱私權政策掃描";
            this.btn_privacyCheck.UseVisualStyleBackColor = true;
            this.btn_privacyCheck.Click += new System.EventHandler(this.Btn_privacyCheck_Click);
            // 
            // btn_ManifestCheck
            // 
            this.btn_ManifestCheck.Location = new System.Drawing.Point(11, 294);
            this.btn_ManifestCheck.Name = "btn_ManifestCheck";
            this.btn_ManifestCheck.Size = new System.Drawing.Size(112, 80);
            this.btn_ManifestCheck.TabIndex = 17;
            this.btn_ManifestCheck.Text = "Manifest 掃描";
            this.btn_ManifestCheck.UseVisualStyleBackColor = true;
            this.btn_ManifestCheck.Click += new System.EventHandler(this.Btn_ManifestCheck_Click);
            // 
            // btn_sendToMobSF
            // 
            this.btn_sendToMobSF.Enabled = false;
            this.btn_sendToMobSF.Location = new System.Drawing.Point(88, 213);
            this.btn_sendToMobSF.Name = "btn_sendToMobSF";
            this.btn_sendToMobSF.Size = new System.Drawing.Size(76, 39);
            this.btn_sendToMobSF.TabIndex = 16;
            this.btn_sendToMobSF.Text = "傳送到MobSF";
            this.btn_sendToMobSF.UseVisualStyleBackColor = true;
            this.btn_sendToMobSF.Click += new System.EventHandler(this.Btn_sendToMobSF_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btn_decode);
            this.tabPage2.Controls.Add(this.btn_encode);
            this.tabPage2.Controls.Add(this.tb_converterOutput);
            this.tabPage2.Controls.Add(this.tb_converterInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base64 converter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F);
            this.label8.Location = new System.Drawing.Point(491, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Output：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F);
            this.label7.Location = new System.Drawing.Point(15, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Input：";
            // 
            // btn_decode
            // 
            this.btn_decode.Location = new System.Drawing.Point(418, 204);
            this.btn_decode.Name = "btn_decode";
            this.btn_decode.Size = new System.Drawing.Size(70, 33);
            this.btn_decode.TabIndex = 3;
            this.btn_decode.Text = "Decode";
            this.btn_decode.UseVisualStyleBackColor = true;
            this.btn_decode.Click += new System.EventHandler(this.Btn_decode_Click);
            // 
            // btn_encode
            // 
            this.btn_encode.Location = new System.Drawing.Point(418, 165);
            this.btn_encode.Name = "btn_encode";
            this.btn_encode.Size = new System.Drawing.Size(70, 33);
            this.btn_encode.TabIndex = 2;
            this.btn_encode.Text = "Encode";
            this.btn_encode.UseVisualStyleBackColor = true;
            this.btn_encode.Click += new System.EventHandler(this.Btn_encode_Click);
            // 
            // tb_converterOutput
            // 
            this.tb_converterOutput.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_converterOutput.Location = new System.Drawing.Point(494, 22);
            this.tb_converterOutput.Multiline = true;
            this.tb_converterOutput.Name = "tb_converterOutput";
            this.tb_converterOutput.ReadOnly = true;
            this.tb_converterOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_converterOutput.Size = new System.Drawing.Size(394, 373);
            this.tb_converterOutput.TabIndex = 1;
            // 
            // tb_converterInput
            // 
            this.tb_converterInput.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_converterInput.Location = new System.Drawing.Point(18, 22);
            this.tb_converterInput.Multiline = true;
            this.tb_converterInput.Name = "tb_converterInput";
            this.tb_converterInput.Size = new System.Drawing.Size(394, 373);
            this.tb_converterInput.TabIndex = 0;
            // 
            // tab_MobSF
            // 
            this.tab_MobSF.Controls.Add(this.tb_MobSFOutput);
            this.tab_MobSF.Controls.Add(this.btn_uploadAPK);
            this.tab_MobSF.Controls.Add(this.btn_resetMobSF);
            this.tab_MobSF.Controls.Add(this.btn_stopMobSF);
            this.tab_MobSF.Controls.Add(this.btn_startMobSF);
            this.tab_MobSF.Controls.Add(this.btn_selectAPK2);
            this.tab_MobSF.Controls.Add(this.tb_APKFile);
            this.tab_MobSF.Controls.Add(this.label12);
            this.tab_MobSF.Controls.Add(this.btn_MobSFPath);
            this.tab_MobSF.Controls.Add(this.tb_MobSFPath);
            this.tab_MobSF.Controls.Add(this.label9);
            this.tab_MobSF.Location = new System.Drawing.Point(4, 22);
            this.tab_MobSF.Name = "tab_MobSF";
            this.tab_MobSF.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MobSF.Size = new System.Drawing.Size(919, 395);
            this.tab_MobSF.TabIndex = 2;
            this.tab_MobSF.Text = "MobSF";
            this.tab_MobSF.UseVisualStyleBackColor = true;
            // 
            // tb_MobSFOutput
            // 
            this.tb_MobSFOutput.Location = new System.Drawing.Point(380, 0);
            this.tb_MobSFOutput.Name = "tb_MobSFOutput";
            this.tb_MobSFOutput.ReadOnly = true;
            this.tb_MobSFOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tb_MobSFOutput.Size = new System.Drawing.Size(538, 395);
            this.tb_MobSFOutput.TabIndex = 20;
            this.tb_MobSFOutput.Text = "";
            // 
            // btn_uploadAPK
            // 
            this.btn_uploadAPK.Enabled = false;
            this.btn_uploadAPK.Location = new System.Drawing.Point(180, 94);
            this.btn_uploadAPK.Name = "btn_uploadAPK";
            this.btn_uploadAPK.Size = new System.Drawing.Size(76, 39);
            this.btn_uploadAPK.TabIndex = 19;
            this.btn_uploadAPK.Text = "上傳APK";
            this.btn_uploadAPK.UseVisualStyleBackColor = true;
            this.btn_uploadAPK.Click += new System.EventHandler(this.Btn_uploadAPK_Click);
            // 
            // btn_resetMobSF
            // 
            this.btn_resetMobSF.Location = new System.Drawing.Point(262, 94);
            this.btn_resetMobSF.Name = "btn_resetMobSF";
            this.btn_resetMobSF.Size = new System.Drawing.Size(76, 39);
            this.btn_resetMobSF.TabIndex = 18;
            this.btn_resetMobSF.Text = "清除設定檔";
            this.btn_resetMobSF.UseVisualStyleBackColor = true;
            this.btn_resetMobSF.Click += new System.EventHandler(this.Btn_resetMobSF_Click);
            // 
            // btn_stopMobSF
            // 
            this.btn_stopMobSF.Enabled = false;
            this.btn_stopMobSF.Location = new System.Drawing.Point(98, 94);
            this.btn_stopMobSF.Name = "btn_stopMobSF";
            this.btn_stopMobSF.Size = new System.Drawing.Size(76, 39);
            this.btn_stopMobSF.TabIndex = 17;
            this.btn_stopMobSF.Text = "停止MobSF";
            this.btn_stopMobSF.UseVisualStyleBackColor = true;
            this.btn_stopMobSF.Click += new System.EventHandler(this.Btn_stopMobSF_Click);
            // 
            // btn_startMobSF
            // 
            this.btn_startMobSF.Location = new System.Drawing.Point(16, 94);
            this.btn_startMobSF.Name = "btn_startMobSF";
            this.btn_startMobSF.Size = new System.Drawing.Size(76, 39);
            this.btn_startMobSF.TabIndex = 15;
            this.btn_startMobSF.Text = "啟動MobSF";
            this.btn_startMobSF.UseVisualStyleBackColor = true;
            this.btn_startMobSF.Click += new System.EventHandler(this.Btn_startMobSF_Click);
            // 
            // btn_selectAPK2
            // 
            this.btn_selectAPK2.Location = new System.Drawing.Point(298, 49);
            this.btn_selectAPK2.Name = "btn_selectAPK2";
            this.btn_selectAPK2.Size = new System.Drawing.Size(76, 39);
            this.btn_selectAPK2.TabIndex = 14;
            this.btn_selectAPK2.Text = "選擇APK檔";
            this.btn_selectAPK2.UseVisualStyleBackColor = true;
            this.btn_selectAPK2.Click += new System.EventHandler(this.Btn_selectAPK2_Click);
            // 
            // tb_APKFile
            // 
            this.tb_APKFile.AllowDrop = true;
            this.tb_APKFile.Location = new System.Drawing.Point(8, 66);
            this.tb_APKFile.Name = "tb_APKFile";
            this.tb_APKFile.ReadOnly = true;
            this.tb_APKFile.Size = new System.Drawing.Size(284, 22);
            this.tb_APKFile.TabIndex = 12;
            this.tb_APKFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.Tb_APKFile_DragDrop);
            this.tb_APKFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Tb_APKFile_DragEnter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F);
            this.label12.Location = new System.Drawing.Point(6, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "上傳APK：";
            // 
            // btn_MobSFPath
            // 
            this.btn_MobSFPath.Location = new System.Drawing.Point(298, 5);
            this.btn_MobSFPath.Name = "btn_MobSFPath";
            this.btn_MobSFPath.Size = new System.Drawing.Size(76, 39);
            this.btn_MobSFPath.TabIndex = 10;
            this.btn_MobSFPath.Text = "選擇資料夾";
            this.btn_MobSFPath.UseVisualStyleBackColor = true;
            this.btn_MobSFPath.Click += new System.EventHandler(this.Btn_MobSFPath_Click);
            // 
            // tb_MobSFPath
            // 
            this.tb_MobSFPath.AllowDrop = true;
            this.tb_MobSFPath.Location = new System.Drawing.Point(8, 22);
            this.tb_MobSFPath.Name = "tb_MobSFPath";
            this.tb_MobSFPath.ReadOnly = true;
            this.tb_MobSFPath.Size = new System.Drawing.Size(284, 22);
            this.tb_MobSFPath.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F);
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "MobSF資料夾：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtb_nmapResult);
            this.tabPage3.Controls.Add(this.btn_screenshot);
            this.tabPage3.Controls.Add(this.state);
            this.tabPage3.Controls.Add(this.port_txt);
            this.tabPage3.Controls.Add(this.port_box);
            this.tabPage3.Controls.Add(this.ip_txt);
            this.tabPage3.Controls.Add(this.ip_box);
            this.tabPage3.Controls.Add(this.ssl_bt);
            this.tabPage3.Controls.Add(this.cer_bt);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(919, 395);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Nmap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtb_nmapResult
            // 
            this.rtb_nmapResult.Location = new System.Drawing.Point(392, 3);
            this.rtb_nmapResult.Name = "rtb_nmapResult";
            this.rtb_nmapResult.ReadOnly = true;
            this.rtb_nmapResult.Size = new System.Drawing.Size(524, 389);
            this.rtb_nmapResult.TabIndex = 14;
            this.rtb_nmapResult.Text = "";
            // 
            // btn_screenshot
            // 
            this.btn_screenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_screenshot.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_screenshot.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_screenshot.Location = new System.Drawing.Point(284, 98);
            this.btn_screenshot.Name = "btn_screenshot";
            this.btn_screenshot.Size = new System.Drawing.Size(97, 62);
            this.btn_screenshot.TabIndex = 13;
            this.btn_screenshot.Text = "儲存截圖";
            this.btn_screenshot.UseVisualStyleBackColor = true;
            this.btn_screenshot.Click += new System.EventHandler(this.Btn_screenshot_Click);
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.LightGreen;
            this.state.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.state.Location = new System.Drawing.Point(309, 15);
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Size = new System.Drawing.Size(72, 27);
            this.state.TabIndex = 12;
            this.state.Text = "等待中";
            this.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // port_txt
            // 
            this.port_txt.AutoSize = true;
            this.port_txt.Location = new System.Drawing.Point(25, 57);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(24, 12);
            this.port_txt.TabIndex = 11;
            this.port_txt.Text = "Port";
            // 
            // port_box
            // 
            this.port_box.BackColor = System.Drawing.Color.Ivory;
            this.port_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.port_box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.port_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_box.Location = new System.Drawing.Point(100, 50);
            this.port_box.MaxLength = 5;
            this.port_box.Name = "port_box";
            this.port_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.port_box.Size = new System.Drawing.Size(190, 26);
            this.port_box.TabIndex = 10;
            // 
            // ip_txt
            // 
            this.ip_txt.AutoSize = true;
            this.ip_txt.Location = new System.Drawing.Point(23, 21);
            this.ip_txt.Name = "ip_txt";
            this.ip_txt.Size = new System.Drawing.Size(61, 12);
            this.ip_txt.TabIndex = 9;
            this.ip_txt.Text = "IP / Domain";
            // 
            // ip_box
            // 
            this.ip_box.BackColor = System.Drawing.Color.Ivory;
            this.ip_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ip_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_box.Location = new System.Drawing.Point(100, 14);
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(190, 26);
            this.ip_box.TabIndex = 8;
            // 
            // ssl_bt
            // 
            this.ssl_bt.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ssl_bt.Location = new System.Drawing.Point(154, 98);
            this.ssl_bt.Name = "ssl_bt";
            this.ssl_bt.Size = new System.Drawing.Size(97, 62);
            this.ssl_bt.TabIndex = 7;
            this.ssl_bt.Text = "SSL";
            this.ssl_bt.UseVisualStyleBackColor = true;
            this.ssl_bt.Click += new System.EventHandler(this.BtSSL_Click);
            // 
            // cer_bt
            // 
            this.cer_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cer_bt.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cer_bt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cer_bt.Location = new System.Drawing.Point(27, 98);
            this.cer_bt.Name = "cer_bt";
            this.cer_bt.Size = new System.Drawing.Size(97, 62);
            this.cer_bt.TabIndex = 1;
            this.cer_bt.Text = "Cer";
            this.cer_bt.UseVisualStyleBackColor = true;
            this.cer_bt.Click += new System.EventHandler(this.BtCer_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_keywordScreenshot);
            this.tabPage4.Controls.Add(this.btn_startSearch);
            this.tabPage4.Controls.Add(this.rtb_searchResult);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.tb_SearchTargetFolder);
            this.tabPage4.Controls.Add(this.btn_selectTargetFolder);
            this.tabPage4.Controls.Add(this.tb_payloadPath);
            this.tabPage4.Controls.Add(this.btn_selectPayload);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(919, 395);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "KeywordSearch";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_keywordScreenshot
            // 
            this.btn_keywordScreenshot.Location = new System.Drawing.Point(88, 94);
            this.btn_keywordScreenshot.Name = "btn_keywordScreenshot";
            this.btn_keywordScreenshot.Size = new System.Drawing.Size(75, 23);
            this.btn_keywordScreenshot.TabIndex = 16;
            this.btn_keywordScreenshot.Text = "儲存截圖";
            this.btn_keywordScreenshot.UseVisualStyleBackColor = true;
            this.btn_keywordScreenshot.Click += new System.EventHandler(this.Btn_keywordScreenshot_Click);
            // 
            // btn_startSearch
            // 
            this.btn_startSearch.Location = new System.Drawing.Point(7, 94);
            this.btn_startSearch.Name = "btn_startSearch";
            this.btn_startSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_startSearch.TabIndex = 15;
            this.btn_startSearch.Text = "一鍵搜尋";
            this.btn_startSearch.UseVisualStyleBackColor = true;
            this.btn_startSearch.Click += new System.EventHandler(this.Btn_startSearch_Click);
            // 
            // rtb_searchResult
            // 
            this.rtb_searchResult.Location = new System.Drawing.Point(374, 3);
            this.rtb_searchResult.Name = "rtb_searchResult";
            this.rtb_searchResult.ReadOnly = true;
            this.rtb_searchResult.Size = new System.Drawing.Size(542, 392);
            this.rtb_searchResult.TabIndex = 14;
            this.rtb_searchResult.Text = "";
            this.rtb_searchResult.WordWrap = false;
            this.rtb_searchResult.TextChanged += new System.EventHandler(this.Rtb_searchResult_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "要搜尋的目標資料夾";
            // 
            // tb_SearchTargetFolder
            // 
            this.tb_SearchTargetFolder.AllowDrop = true;
            this.tb_SearchTargetFolder.Location = new System.Drawing.Point(8, 22);
            this.tb_SearchTargetFolder.Name = "tb_SearchTargetFolder";
            this.tb_SearchTargetFolder.ReadOnly = true;
            this.tb_SearchTargetFolder.Size = new System.Drawing.Size(283, 22);
            this.tb_SearchTargetFolder.TabIndex = 8;
            // 
            // btn_selectTargetFolder
            // 
            this.btn_selectTargetFolder.Location = new System.Drawing.Point(297, 5);
            this.btn_selectTargetFolder.Name = "btn_selectTargetFolder";
            this.btn_selectTargetFolder.Size = new System.Drawing.Size(76, 39);
            this.btn_selectTargetFolder.TabIndex = 13;
            this.btn_selectTargetFolder.Text = "選擇資料夾";
            this.btn_selectTargetFolder.UseVisualStyleBackColor = true;
            this.btn_selectTargetFolder.Click += new System.EventHandler(this.Btn_selectTargetFolder_Click);
            // 
            // tb_payloadPath
            // 
            this.tb_payloadPath.AllowDrop = true;
            this.tb_payloadPath.Location = new System.Drawing.Point(7, 66);
            this.tb_payloadPath.Name = "tb_payloadPath";
            this.tb_payloadPath.Size = new System.Drawing.Size(284, 22);
            this.tb_payloadPath.TabIndex = 11;
            // 
            // btn_selectPayload
            // 
            this.btn_selectPayload.Location = new System.Drawing.Point(297, 50);
            this.btn_selectPayload.Name = "btn_selectPayload";
            this.btn_selectPayload.Size = new System.Drawing.Size(76, 39);
            this.btn_selectPayload.TabIndex = 10;
            this.btn_selectPayload.Text = "選擇檔案";
            this.btn_selectPayload.UseVisualStyleBackColor = true;
            this.btn_selectPayload.Click += new System.EventHandler(this.Btn_selectPayload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(5, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "字串檔(.txt)";
            // 
            // tab_WhiteSource
            // 
            this.tab_WhiteSource.Controls.Add(this.btn_WSScan);
            this.tab_WhiteSource.Controls.Add(this.cb_OAInternet);
            this.tab_WhiteSource.Controls.Add(this.tb_WSProjectName);
            this.tab_WhiteSource.Controls.Add(this.label14);
            this.tab_WhiteSource.Controls.Add(this.btn_WSSelectFolder);
            this.tab_WhiteSource.Controls.Add(this.tb_WSTargetFolder);
            this.tab_WhiteSource.Controls.Add(this.label13);
            this.tab_WhiteSource.Controls.Add(this.rtb_WhiteSource);
            this.tab_WhiteSource.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab_WhiteSource.Location = new System.Drawing.Point(4, 22);
            this.tab_WhiteSource.Name = "tab_WhiteSource";
            this.tab_WhiteSource.Padding = new System.Windows.Forms.Padding(3);
            this.tab_WhiteSource.Size = new System.Drawing.Size(919, 395);
            this.tab_WhiteSource.TabIndex = 5;
            this.tab_WhiteSource.Text = "WhiteSource";
            this.tab_WhiteSource.UseVisualStyleBackColor = true;
            // 
            // btn_WSScan
            // 
            this.btn_WSScan.Location = new System.Drawing.Point(6, 151);
            this.btn_WSScan.Name = "btn_WSScan";
            this.btn_WSScan.Size = new System.Drawing.Size(107, 62);
            this.btn_WSScan.TabIndex = 27;
            this.btn_WSScan.Text = "WhiteSource掃描";
            this.btn_WSScan.UseVisualStyleBackColor = true;
            this.btn_WSScan.Click += new System.EventHandler(this.Btn_WSScan_Click);
            // 
            // cb_OAInternet
            // 
            this.cb_OAInternet.AutoSize = true;
            this.cb_OAInternet.Location = new System.Drawing.Point(8, 120);
            this.cb_OAInternet.Name = "cb_OAInternet";
            this.cb_OAInternet.Size = new System.Drawing.Size(108, 16);
            this.cb_OAInternet.TabIndex = 26;
            this.cb_OAInternet.Text = "公司內網請勾選";
            this.cb_OAInternet.UseVisualStyleBackColor = true;
            // 
            // tb_WSProjectName
            // 
            this.tb_WSProjectName.AllowDrop = true;
            this.tb_WSProjectName.Location = new System.Drawing.Point(8, 80);
            this.tb_WSProjectName.Name = "tb_WSProjectName";
            this.tb_WSProjectName.Size = new System.Drawing.Size(284, 22);
            this.tb_WSProjectName.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F);
            this.label14.Location = new System.Drawing.Point(6, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Project Name：";
            // 
            // btn_WSSelectFolder
            // 
            this.btn_WSSelectFolder.Location = new System.Drawing.Point(298, 6);
            this.btn_WSSelectFolder.Name = "btn_WSSelectFolder";
            this.btn_WSSelectFolder.Size = new System.Drawing.Size(91, 38);
            this.btn_WSSelectFolder.TabIndex = 23;
            this.btn_WSSelectFolder.Text = "選擇資料夾";
            this.btn_WSSelectFolder.UseVisualStyleBackColor = true;
            this.btn_WSSelectFolder.Click += new System.EventHandler(this.Btn_WSSelectFolder_Click);
            // 
            // tb_WSTargetFolder
            // 
            this.tb_WSTargetFolder.AllowDrop = true;
            this.tb_WSTargetFolder.Location = new System.Drawing.Point(8, 22);
            this.tb_WSTargetFolder.Name = "tb_WSTargetFolder";
            this.tb_WSTargetFolder.ReadOnly = true;
            this.tb_WSTargetFolder.Size = new System.Drawing.Size(284, 22);
            this.tb_WSTargetFolder.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F);
            this.label13.Location = new System.Drawing.Point(6, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Target Folder：";
            // 
            // rtb_WhiteSource
            // 
            this.rtb_WhiteSource.Location = new System.Drawing.Point(395, 0);
            this.rtb_WhiteSource.Name = "rtb_WhiteSource";
            this.rtb_WhiteSource.ReadOnly = true;
            this.rtb_WhiteSource.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_WhiteSource.Size = new System.Drawing.Size(524, 395);
            this.rtb_WhiteSource.TabIndex = 20;
            this.rtb_WhiteSource.Text = "";
            this.rtb_WhiteSource.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Rtb_WhiteSource_LinkClicked);
            // 
            // tab_ADB
            // 
            this.tab_ADB.Controls.Add(this.btn_ADBDriver);
            this.tab_ADB.Controls.Add(this.btn_LoadPackageList);
            this.tab_ADB.Controls.Add(this.listView1);
            this.tab_ADB.Controls.Add(this.label_PhoneStatus);
            this.tab_ADB.Controls.Add(this.btn_InstallAPK);
            this.tab_ADB.Controls.Add(this.rtb_adbOutput);
            this.tab_ADB.Controls.Add(this.btn_checkADB);
            this.tab_ADB.Location = new System.Drawing.Point(4, 22);
            this.tab_ADB.Name = "tab_ADB";
            this.tab_ADB.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ADB.Size = new System.Drawing.Size(919, 395);
            this.tab_ADB.TabIndex = 5;
            this.tab_ADB.Text = "ADB";
            this.tab_ADB.UseVisualStyleBackColor = true;
            // 
            // btn_LoadPackageList
            // 
            this.btn_LoadPackageList.Location = new System.Drawing.Point(107, 107);
            this.btn_LoadPackageList.Name = "btn_LoadPackageList";
            this.btn_LoadPackageList.Size = new System.Drawing.Size(95, 41);
            this.btn_LoadPackageList.TabIndex = 19;
            this.btn_LoadPackageList.Text = "載入已安裝的APK";
            this.btn_LoadPackageList.UseVisualStyleBackColor = true;
            this.btn_LoadPackageList.Click += new System.EventHandler(this.Btn_LoadPackageList_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(415, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 394);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Package List";
            this.columnHeader1.Width = 450;
            // 
            // label_PhoneStatus
            // 
            this.label_PhoneStatus.AutoSize = true;
            this.label_PhoneStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PhoneStatus.Location = new System.Drawing.Point(80, 15);
            this.label_PhoneStatus.Name = "label_PhoneStatus";
            this.label_PhoneStatus.Size = new System.Drawing.Size(122, 21);
            this.label_PhoneStatus.TabIndex = 17;
            this.label_PhoneStatus.Text = "正在檢查裝置 ...";
            // 
            // btn_InstallAPK
            // 
            this.btn_InstallAPK.Location = new System.Drawing.Point(6, 107);
            this.btn_InstallAPK.Name = "btn_InstallAPK";
            this.btn_InstallAPK.Size = new System.Drawing.Size(95, 41);
            this.btn_InstallAPK.TabIndex = 16;
            this.btn_InstallAPK.Text = "安裝APK";
            this.btn_InstallAPK.UseVisualStyleBackColor = true;
            this.btn_InstallAPK.Click += new System.EventHandler(this.Btn_InstallAPK_Click);
            // 
            // rtb_adbOutput
            // 
            this.rtb_adbOutput.Location = new System.Drawing.Point(6, 154);
            this.rtb_adbOutput.Name = "rtb_adbOutput";
            this.rtb_adbOutput.ReadOnly = true;
            this.rtb_adbOutput.Size = new System.Drawing.Size(403, 235);
            this.rtb_adbOutput.TabIndex = 15;
            this.rtb_adbOutput.Text = "";
            this.rtb_adbOutput.WordWrap = false;
            // 
            // btn_checkADB
            // 
            this.btn_checkADB.Location = new System.Drawing.Point(6, 6);
            this.btn_checkADB.Name = "btn_checkADB";
            this.btn_checkADB.Size = new System.Drawing.Size(62, 43);
            this.btn_checkADB.TabIndex = 0;
            this.btn_checkADB.Text = "重新整理";
            this.btn_checkADB.UseVisualStyleBackColor = true;
            this.btn_checkADB.Click += new System.EventHandler(this.Btn_checkADB_Click);
            // 
            // MobSFWorker
            // 
            this.MobSFWorker.WorkerSupportsCancellation = true;
            // 
            // RequestWorker
            // 
            this.RequestWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RequestWorker_DoWork);
            this.RequestWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RequestWorker_RunWorkerCompleted);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_status,
            this.toolStripProgressBar1});
            this.toolStrip.Location = new System.Drawing.Point(0, 427);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(930, 22);
            this.toolStrip.TabIndex = 18;
            this.toolStrip.Text = "statusStrip1";
            // 
            // lb_status
            // 
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(128, 17);
            this.lb_status.Text = "toolStripStatusLabel1";
            this.lb_status.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // saveScreenshotDialog
            // 
            this.saveScreenshotDialog.DefaultExt = "jpg";
            this.saveScreenshotDialog.Filter = "jpg|*.jpg";
            // 
            // contextMenu_ADB
            // 
            this.contextMenu_ADB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_PullData});
            this.contextMenu_ADB.Name = "contextMenu_ADB";
            this.contextMenu_ADB.Size = new System.Drawing.Size(187, 26);
            this.contextMenu_ADB.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenu_ADB_ItemClicked);
            // 
            // menuItem_PullData
            // 
            this.menuItem_PullData.Name = "menuItem_PullData";
            this.menuItem_PullData.Size = new System.Drawing.Size(186, 22);
            this.menuItem_PullData.Text = "複製app data到電腦";
            // 
            // btn_ADBDriver
            // 
            this.btn_ADBDriver.Location = new System.Drawing.Point(6, 55);
            this.btn_ADBDriver.Name = "btn_ADBDriver";
            this.btn_ADBDriver.Size = new System.Drawing.Size(95, 42);
            this.btn_ADBDriver.TabIndex = 20;
            this.btn_ADBDriver.Text = "安裝ADB Driver";
            this.btn_ADBDriver.UseVisualStyleBackColor = true;
            this.btn_ADBDriver.Click += new System.EventHandler(this.Btn_ADBDriver_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(930, 449);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASToolBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tab_MobSF.ResumeLayout(false);
            this.tab_MobSF.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tab_WhiteSource.ResumeLayout(false);
            this.tab_WhiteSource.PerformLayout();
            this.tab_ADB.ResumeLayout(false);
            this.tab_ADB.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenu_ADB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_selectAPK;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_selectOutputDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOutputDir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMD5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSHA1;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker decompileWorker;
        private System.Windows.Forms.Button btn_decompile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_decode;
        private System.Windows.Forms.Button btn_encode;
        private System.Windows.Forms.TextBox tb_converterOutput;
        private System.Windows.Forms.TextBox tb_converterInput;
        private System.Windows.Forms.TabPage tab_MobSF;
        private System.Windows.Forms.Button btn_MobSFPath;
        private System.Windows.Forms.TextBox tb_MobSFPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_selectAPK2;
        private System.Windows.Forms.TextBox tb_APKFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_startMobSF;
        private System.ComponentModel.BackgroundWorker MobSFWorker;
        private System.Windows.Forms.Button btn_stopMobSF;
        private System.Windows.Forms.Button btn_resetMobSF;
        private System.Windows.Forms.Button btn_uploadAPK;
        private System.ComponentModel.BackgroundWorker RequestWorker;
        private System.Windows.Forms.StatusStrip toolStrip;
        private System.Windows.Forms.ToolStripStatusLabel lb_status;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btn_sendToMobSF;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label port_txt;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.Label ip_txt;
        private System.Windows.Forms.TextBox ip_box;
        private System.Windows.Forms.Button ssl_bt;
        private System.Windows.Forms.Button cer_bt;
        private System.Windows.Forms.Button btn_privacyCheck;
        private System.Windows.Forms.Button btn_ManifestCheck;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SearchTargetFolder;
        private System.Windows.Forms.Button btn_selectTargetFolder;
        private System.Windows.Forms.TextBox tb_payloadPath;
        private System.Windows.Forms.Button btn_selectPayload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_searchResult;
        private System.ComponentModel.BackgroundWorker SearchWorker;
        private System.Windows.Forms.Button btn_startSearch;
        private System.Windows.Forms.Button btn_screenshot;
        private System.Windows.Forms.SaveFileDialog saveScreenshotDialog;
        private System.Windows.Forms.Button btn_keywordScreenshot;

        private System.Windows.Forms.TabPage tab_ADB;
        private System.Windows.Forms.Button btn_checkADB;
        private System.Windows.Forms.RichTextBox rtb_adbOutput;

        private System.Windows.Forms.RichTextBox rtb_nmapResult;
        private System.Windows.Forms.RichTextBox tb_MobSFOutput;
        private System.Windows.Forms.RichTextBox tbOutput;
        private System.Windows.Forms.Button btn_whiteSource;
        private System.Windows.Forms.TabPage tab_WhiteSource;
        private System.Windows.Forms.Button btn_WSScan;
        private System.Windows.Forms.CheckBox cb_OAInternet;
        private System.Windows.Forms.TextBox tb_WSProjectName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_WSSelectFolder;
        private System.Windows.Forms.TextBox tb_WSTargetFolder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtb_WhiteSource;
        private System.Windows.Forms.Button btn_InstallAPK;
        private System.Windows.Forms.Label label_PhoneStatus;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_LoadPackageList;
        private System.Windows.Forms.ContextMenuStrip contextMenu_ADB;
        private System.Windows.Forms.ToolStripMenuItem menuItem_PullData;
        private System.Windows.Forms.Button btn_ADBDriver;
    }
}

