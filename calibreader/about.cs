using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace calibreader
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            appVersion.Text = Application.ProductVersion;
        }

        private void OnHelpClick(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/open?id=1VKXiTcAx_j6Myg7-96C0fwshLN5X1ZITcFRh95Jd-WY");
        }
    }
}
