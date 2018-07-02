namespace MASToolBox
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decompileWorker = new System.ComponentModel.BackgroundWorker();
            this.btn_decompile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_sendToMobSF = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_decode = new System.Windows.Forms.Button();
            this.btn_encode = new System.Windows.Forms.Button();
            this.tb_converterOutput = new System.Windows.Forms.TextBox();
            this.tb_converterInput = new System.Windows.Forms.TextBox();
            this.tab_MobSF = new System.Windows.Forms.TabPage();
            this.btn_uploadAPK = new System.Windows.Forms.Button();
            this.btn_resetMobSF = new System.Windows.Forms.Button();
            this.btn_stopMobSF = new System.Windows.Forms.Button();
            this.tb_MobSFOutput = new System.Windows.Forms.TextBox();
            this.btn_startMobSF = new System.Windows.Forms.Button();
            this.btn_selectAPK2 = new System.Windows.Forms.Button();
            this.tb_APKFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_MobSFPath = new System.Windows.Forms.Button();
            this.tb_MobSFPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.state = new System.Windows.Forms.TextBox();
            this.port_txt = new System.Windows.Forms.Label();
            this.port_box = new System.Windows.Forms.TextBox();
            this.ip_txt = new System.Windows.Forms.Label();
            this.ip_box = new System.Windows.Forms.TextBox();
            this.ssl_bt = new System.Windows.Forms.Button();
            this.cer_bt = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.MobSFWorker = new System.ComponentModel.BackgroundWorker();
            this.RequestWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip = new System.Windows.Forms.StatusStrip();
            this.lb_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tab_MobSF.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip.SuspendLayout();
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
            // tbOutput
            // 
            this.tbOutput.AllowDrop = true;
            this.tbOutput.Font = new System.Drawing.Font("Consolas", 12F);
            this.tbOutput.Location = new System.Drawing.Point(397, 6);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(516, 389);
            this.tbOutput.TabIndex = 13;
            this.tbOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFolderPath_DragDrop);
            this.tbOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFolderPath_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(0, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "ipa檔只能使用hash功能";
            // 
            // decompileWorker
            // 
            this.decompileWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DecompileWorker_DoWork);
            this.decompileWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DecompileWorker_RunWorkerCompleted);
            // 
            // btn_decompile
            // 
            this.btn_decompile.Enabled = false;
            this.btn_decompile.Location = new System.Drawing.Point(3, 234);
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
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 421);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            this.tabControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFolderPath_DragDrop);
            this.tabControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFolderPath_DragEnter);
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.btn_sendToMobSF);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.tbOutput);
            this.tabPage1.Controls.Add(this.btn_decompile);
            this.tabPage1.Controls.Add(this.btn_selectOutputDir);
            this.tabPage1.Controls.Add(this.tbOutputDir);
            this.tabPage1.Controls.Add(this.label4);
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
            this.tabPage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFolderPath_DragDrop);
            this.tabPage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFolderPath_DragEnter);
            // 
            // btn_sendToMobSF
            // 
            this.btn_sendToMobSF.Enabled = false;
            this.btn_sendToMobSF.Location = new System.Drawing.Point(85, 234);
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
            this.tab_MobSF.Controls.Add(this.btn_uploadAPK);
            this.tab_MobSF.Controls.Add(this.btn_resetMobSF);
            this.tab_MobSF.Controls.Add(this.btn_stopMobSF);
            this.tab_MobSF.Controls.Add(this.tb_MobSFOutput);
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
            // tb_MobSFOutput
            // 
            this.tb_MobSFOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_MobSFOutput.Location = new System.Drawing.Point(380, 6);
            this.tb_MobSFOutput.Multiline = true;
            this.tb_MobSFOutput.Name = "tb_MobSFOutput";
            this.tb_MobSFOutput.ReadOnly = true;
            this.tb_MobSFOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_MobSFOutput.Size = new System.Drawing.Size(532, 389);
            this.tb_MobSFOutput.TabIndex = 16;
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
            this.tabPage3.Controls.Add(this.state);
            this.tabPage3.Controls.Add(this.port_txt);
            this.tabPage3.Controls.Add(this.port_box);
            this.tabPage3.Controls.Add(this.ip_txt);
            this.tabPage3.Controls.Add(this.ip_box);
            this.tabPage3.Controls.Add(this.ssl_bt);
            this.tabPage3.Controls.Add(this.cer_bt);
            this.tabPage3.Controls.Add(this.result);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(919, 395);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Nmap";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.ssl_bt.Location = new System.Drawing.Point(193, 98);
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
            // result
            // 
            this.result.Location = new System.Drawing.Point(397, 3);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result.Size = new System.Drawing.Size(519, 389);
            this.result.TabIndex = 0;
            // 
            // MobSFWorker
            // 
            this.MobSFWorker.WorkerSupportsCancellation = true;
            this.MobSFWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MobSFWorker_DoWork);
            this.MobSFWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MobSFWorker_RunWorkerCompleted);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoDecompiler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFolderPath_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFolderPath_DragEnter);
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
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.TextBox tb_MobSFOutput;
        private System.Windows.Forms.Button btn_stopMobSF;
        private System.Windows.Forms.Button btn_resetMobSF;
        private System.Windows.Forms.Button btn_uploadAPK;
        private System.ComponentModel.BackgroundWorker RequestWorker;
        private System.Windows.Forms.StatusStrip toolStrip;
        private System.Windows.Forms.ToolStripStatusLabel lb_status;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btn_sendToMobSF;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label port_txt;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.Label ip_txt;
        private System.Windows.Forms.TextBox ip_box;
        private System.Windows.Forms.Button ssl_bt;
        private System.Windows.Forms.Button cer_bt;
    }
}

