namespace StringsSearcher
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_decode = new System.Windows.Forms.Button();
            this.btn_encode = new System.Windows.Forms.Button();
            this.tb_converterOutput = new System.Windows.Forms.TextBox();
            this.tb_converterInput = new System.Windows.Forms.TextBox();
            this.tab_MobSF = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_MobSFPath = new System.Windows.Forms.Button();
            this.tb_MobSFPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_startMobSF = new System.Windows.Forms.Button();
            this.MobSFWorker = new System.ComponentModel.BackgroundWorker();
            this.tb_MobSFOutput = new System.Windows.Forms.TextBox();
            this.btn_stopMobSF = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tab_MobSF.SuspendLayout();
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
            this.btn_selectAPK.Click += new System.EventHandler(this.btn_selectAPK_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\劉建毅\\Desktop";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(394, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "INFO：";
            // 
            // btn_selectOutputDir
            // 
            this.btn_selectOutputDir.Location = new System.Drawing.Point(312, 49);
            this.btn_selectOutputDir.Name = "btn_selectOutputDir";
            this.btn_selectOutputDir.Size = new System.Drawing.Size(76, 39);
            this.btn_selectOutputDir.TabIndex = 7;
            this.btn_selectOutputDir.Text = "選擇資料夾";
            this.btn_selectOutputDir.UseVisualStyleBackColor = true;
            this.btn_selectOutputDir.Click += new System.EventHandler(this.btn_selectOutputDir_Click);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.tbOutput.Font = new System.Drawing.Font("新細明體", 11F);
            this.tbOutput.Location = new System.Drawing.Point(397, 23);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(512, 367);
            this.tbOutput.TabIndex = 13;
            this.tbOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFolderPath_DragDrop);
            this.tbOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFolderPath_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(3, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "ipa檔只能使用hash功能";
            // 
            // decompileWorker
            // 
            this.decompileWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.decompileWorker_DoWork);
            this.decompileWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.decompileWorker_RunWorkerCompleted);
            // 
            // btn_decompile
            // 
            this.btn_decompile.Location = new System.Drawing.Point(6, 234);
            this.btn_decompile.Name = "btn_decompile";
            this.btn_decompile.Size = new System.Drawing.Size(76, 39);
            this.btn_decompile.TabIndex = 15;
            this.btn_decompile.Text = "輸出原始碼";
            this.btn_decompile.UseVisualStyleBackColor = true;
            this.btn_decompile.Click += new System.EventHandler(this.btn_decompile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(459, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 13);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tab_MobSF);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 425);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.tbOutput);
            this.tabPage1.Controls.Add(this.btn_decompile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_selectOutputDir);
            this.tabPage1.Controls.Add(this.tbOutputDir);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_selectAPK);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Decompiler";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Size = new System.Drawing.Size(919, 399);
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
            this.btn_decode.Click += new System.EventHandler(this.btn_decode_Click);
            // 
            // btn_encode
            // 
            this.btn_encode.Location = new System.Drawing.Point(418, 165);
            this.btn_encode.Name = "btn_encode";
            this.btn_encode.Size = new System.Drawing.Size(70, 33);
            this.btn_encode.TabIndex = 2;
            this.btn_encode.Text = "Encode";
            this.btn_encode.UseVisualStyleBackColor = true;
            this.btn_encode.Click += new System.EventHandler(this.btn_encode_Click);
            // 
            // tb_converterOutput
            // 
            this.tb_converterOutput.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_converterOutput.Location = new System.Drawing.Point(494, 22);
            this.tb_converterOutput.Multiline = true;
            this.tb_converterOutput.Name = "tb_converterOutput";
            this.tb_converterOutput.ReadOnly = true;
            this.tb_converterOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_converterOutput.Size = new System.Drawing.Size(394, 371);
            this.tb_converterOutput.TabIndex = 1;
            // 
            // tb_converterInput
            // 
            this.tb_converterInput.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_converterInput.Location = new System.Drawing.Point(18, 22);
            this.tb_converterInput.Multiline = true;
            this.tb_converterInput.Name = "tb_converterInput";
            this.tb_converterInput.Size = new System.Drawing.Size(394, 371);
            this.tb_converterInput.TabIndex = 0;
            // 
            // tab_MobSF
            // 
            this.tab_MobSF.Controls.Add(this.btn_stopMobSF);
            this.tab_MobSF.Controls.Add(this.tb_MobSFOutput);
            this.tab_MobSF.Controls.Add(this.btn_startMobSF);
            this.tab_MobSF.Controls.Add(this.button3);
            this.tab_MobSF.Controls.Add(this.textBox4);
            this.tab_MobSF.Controls.Add(this.label12);
            this.tab_MobSF.Controls.Add(this.btn_MobSFPath);
            this.tab_MobSF.Controls.Add(this.tb_MobSFPath);
            this.tab_MobSF.Controls.Add(this.label9);
            this.tab_MobSF.Location = new System.Drawing.Point(4, 22);
            this.tab_MobSF.Name = "tab_MobSF";
            this.tab_MobSF.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MobSF.Size = new System.Drawing.Size(919, 399);
            this.tab_MobSF.TabIndex = 2;
            this.tab_MobSF.Text = "MobSF";
            this.tab_MobSF.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 39);
            this.button3.TabIndex = 14;
            this.button3.Text = "選擇APK檔";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.AllowDrop = true;
            this.textBox4.Location = new System.Drawing.Point(8, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(284, 22);
            this.textBox4.TabIndex = 12;
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
            this.btn_MobSFPath.Click += new System.EventHandler(this.btn_MobSFPath_Click);
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
            // btn_startMobSF
            // 
            this.btn_startMobSF.Location = new System.Drawing.Point(8, 94);
            this.btn_startMobSF.Name = "btn_startMobSF";
            this.btn_startMobSF.Size = new System.Drawing.Size(76, 39);
            this.btn_startMobSF.TabIndex = 15;
            this.btn_startMobSF.Text = "啟動MobSF";
            this.btn_startMobSF.UseVisualStyleBackColor = true;
            this.btn_startMobSF.Click += new System.EventHandler(this.btn_startMobSF_Click);
            // 
            // MobSFWorker
            // 
            this.MobSFWorker.WorkerSupportsCancellation = true;
            this.MobSFWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MobSFWorker_DoWork);
            this.MobSFWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MobSFWorker_RunWorkerCompleted);
            // 
            // tb_MobSFOutput
            // 
            this.tb_MobSFOutput.Location = new System.Drawing.Point(390, 6);
            this.tb_MobSFOutput.Multiline = true;
            this.tb_MobSFOutput.Name = "tb_MobSFOutput";
            this.tb_MobSFOutput.ReadOnly = true;
            this.tb_MobSFOutput.Size = new System.Drawing.Size(528, 392);
            this.tb_MobSFOutput.TabIndex = 16;
            // 
            // btn_stopMobSF
            // 
            this.btn_stopMobSF.Location = new System.Drawing.Point(90, 94);
            this.btn_stopMobSF.Name = "btn_stopMobSF";
            this.btn_stopMobSF.Size = new System.Drawing.Size(76, 39);
            this.btn_stopMobSF.TabIndex = 17;
            this.btn_stopMobSF.Text = "停止MobSF";
            this.btn_stopMobSF.UseVisualStyleBackColor = true;
            this.btn_stopMobSF.Click += new System.EventHandler(this.btn_stopMobSF_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 449);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutoDecompiler";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFolderPath_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFolderPath_DragEnter);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_selectAPK;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.ProgressBar progressBar1;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_startMobSF;
        private System.ComponentModel.BackgroundWorker MobSFWorker;
        private System.Windows.Forms.TextBox tb_MobSFOutput;
        private System.Windows.Forms.Button btn_stopMobSF;
    }
}

