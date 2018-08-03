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
        private LibraryWorker KeywordSearcher = new LibraryWorker(Library.KeywordSearch);

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
            string args1 = tb_SearchTargetFolder.Text;
            string args2 = tb_payloadPath.Text;

            KeywordSearcher.SetOutputBox(this.rtb_searchResult);
            KeywordSearcher.AddParam(new string[] { args1, args2 });
            KeywordSearcher.JobFinished += KeywordSearch_Completed;
            KeywordSearcher.RunLibrary();
        }

        private void KeywordSearch_Completed(object sender, EventArgs e)
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

        private void Btn_keywordScreenshot_Click(object sender, EventArgs e)
        {
            var result = saveScreenshotDialog.ShowDialog();
            var fileName = saveScreenshotDialog.FileName;
            if (result == DialogResult.OK)
            {
                ScreenCapture.Capture(this.rtb_searchResult, fileName);
            }
        }
    }
}
