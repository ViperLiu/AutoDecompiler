using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASToolBox
{
    partial class Form1
    {
        string PhoneBrand = "";
        string PhoneModel = "";

        private void Btn_checkADB_Click(object sender, EventArgs e)
        {
            LibraryWorker adb = new LibraryWorker(Library.ADB);
            adb.AddParam(new string[] { "shell", "\"getprop\"" });
            adb.SetOutputBox(rtb_adbOutput);
            adb.DataProcessor = AdbGetPhoneBrandModel;
            adb.JobFinished += PhoneFound;
            adb.RunLibrary();
        }

        private void PhoneFound(object sender, EventArgs e)
        {
            MessageBox.Show("Found Phone : " + PhoneBrand + " " + PhoneModel);
        }

        private string AdbGetPhoneBrandModel(string data)
        {
            var tmp = data.Replace("[", "").Replace("]", "");
            if (tmp.StartsWith("ro.product.brand"))
            {
                var brand = tmp.Split(':')[1].Trim();
                PhoneBrand = brand.ToUpper();
                return "Brand : " + brand;
            }
            if(tmp.StartsWith("ro.product.model"))
            {
                var model = tmp.Split(':')[1].Trim();
                PhoneModel = model.ToUpper();
                return "Model : " + model;
            }
            return "";
        }
    }
}
