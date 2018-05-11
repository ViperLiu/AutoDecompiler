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
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutputDir = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMD5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSHA1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_converterInput = new System.Windows.Forms.TextBox();
            this.tb_converterOutput = new System.Windows.Forms.TextBox();
            this.btn_encode = new System.Windows.Forms.Button();
            this.btn_decode = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "選擇檔案";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "選擇資料夾";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.groupBox1.Controls.Add(this.tbSHA1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbMD5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(2, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash Values";
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
            this.label4.Location = new System.Drawing.Point(-1, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "ipa檔只能使用hash功能";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 39);
            this.button4.TabIndex = 15;
            this.button4.Text = "輸出原始碼";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.tbOutputDir);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
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
            // tb_converterInput
            // 
            this.tb_converterInput.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_converterInput.Location = new System.Drawing.Point(18, 22);
            this.tb_converterInput.Multiline = true;
            this.tb_converterInput.Name = "tb_converterInput";
            this.tb_converterInput.Size = new System.Drawing.Size(394, 371);
            this.tb_converterInput.TabIndex = 0;
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
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 440);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutoDecompiler";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFolderPath_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFolderPath_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
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
    }
}

