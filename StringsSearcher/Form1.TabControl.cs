using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASToolBox
{
    partial class Form1
    {
        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            TabControl tmp = (TabControl)sender;
            if (tmp.SelectedTab == tmp.TabPages["tab_MobSF"])
            {
                this.LoadMobSFSettings();
            }
        }
    }
}
