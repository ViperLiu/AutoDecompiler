using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MASToolBox
{
    partial class Form1
    {
        private void Btn_selectTargetFolder_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                tb_SearchTargetFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Btn_selectPayload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文字檔|*.txt";
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;
                tb_payloadPath.Text = file;
            }

            openFileDialog1.Filter = "";
        }

        private void Btn_startSearch_Click(object sender, EventArgs e)
        {
            SearchWorker.RunWorkerAsync();
        }

        private void SearchWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string args1 = tb_SearchTargetFolder.Text;
            string args2 = tb_payloadPath.Text;


            Process searcher = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "tools\\KeywordSearch.bat";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.Arguments = string.Format("\"{0}\" \"{1}\"", args1, args2);

            //tbOutput.Text = startInfo.Arguments;
            startInfo.CreateNoWindow = true;
            searcher.StartInfo = startInfo;
            searcher.SynchronizingObject = this;


            searcher.Start();
            searcher.ErrorDataReceived += Proc_Searcher_OutputDataReceived;
            searcher.OutputDataReceived += Proc_Searcher_OutputDataReceived;
            searcher.EnableRaisingEvents = true;
            searcher.BeginOutputReadLine();
            searcher.BeginErrorReadLine();
            searcher.WaitForExit();
        }

        private void Proc_Searcher_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
                return;
            this.tbOutput.Invoke((MethodInvoker)delegate
            {
                //var str = e.Data.Replace("\'", "");
                rtb_searchResult.AppendText(e.Data + "\r\n");
                rtb_searchResult.ScrollToCaret();
            });

        }

        private void SearchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("搜尋完成");
        }

        private void Rtb_searchResult_TextChanged(object sender, EventArgs e)
        {
            string[] keywords;
            using (StreamReader file = new StreamReader(tb_payloadPath.Text))
            {
                keywords = file.ReadToEnd().Split(',');
            }

            foreach(var keyword in keywords)
            {
                CheckKeyword(keyword, Color.Red, 0);
            }
        }

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (rtb_searchResult.Text.Contains(word))
            {
                int index = -1;
                int selectStart = rtb_searchResult.SelectionStart;

                while ((index = rtb_searchResult.Text.IndexOf(word, (index + 1))) != -1)
                {
                    rtb_searchResult.Select((index + startIndex), word.Length);
                    rtb_searchResult.SelectionColor = color;
                    rtb_searchResult.Select(selectStart, 0);
                    rtb_searchResult.SelectionColor = Color.Black;
                }
            }
        }
    }
}
