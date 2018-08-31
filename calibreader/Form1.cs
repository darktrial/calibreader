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
using System.IO;
using System.IO.Compression;

using ICSharpCode.SharpZipLib.BZip2;
using ICSharpCode.SharpZipLib.Tar;

namespace calibreader
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*DataGridViewRow row = (DataGridViewRow)viewcali.Rows[0].Clone();
            row.Cells[0].Value = "XYZ";
            row.Cells[1].Value = 50.2;
            viewcali.Rows.Add(row);*/
            //this.viewcali.Rows.Add("1", "2", "3", "4", "5", "6", "7");
            //Debug.WriteLine("1234");
           
        }
        private void viewcali_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not in our 
            if (e.ColumnIndex == this.viewcali.Columns["show_log"].Index && e.RowIndex >= 0)
            {
                String str = this.viewcali.Rows[e.RowIndex].Cells[1].Value.ToString();
                Debug.WriteLine("Button on row {0} clicked value {1}", e.RowIndex,str);
            }
        }




        private void onOpenFileClick(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Camera File|*.tar.gz";
            openFileDialog1.Title = "Select a camera log File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Debug.WriteLine(openFileDialog1.FileName);
            }
        }
    }
}
