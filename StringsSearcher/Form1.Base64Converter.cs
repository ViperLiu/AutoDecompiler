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
using MASToolBox;

namespace MASToolBox
{
    public partial class Form1
    {
        private void btn_encode_Click(object sender, EventArgs e)
        {
            string input = tb_converterInput.Text;
            string output = "";
            try
            {
                byte[] input_bytes = System.Text.Encoding.UTF8.GetBytes(input);
                output = Convert.ToBase64String(input_bytes);
                tb_converterOutput.Text = output;
            }
            catch
            {
                MessageBox.Show("轉換失敗!");
            }
        }

        private void btn_decode_Click(object sender, EventArgs e)
        {
            string input = tb_converterInput.Text;
            string output = "";
            try
            {
                output = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
                tb_converterOutput.Text = output;
            }
            catch
            {
                MessageBox.Show("轉換失敗!");
            }
        }
    }
}
