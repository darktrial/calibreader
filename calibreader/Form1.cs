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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*DataGridViewRow row = (DataGridViewRow)viewcali.Rows[0].Clone();
            row.Cells[0].Value = "XYZ";
            row.Cells[1].Value = 50.2;
            viewcali.Rows.Add(row);*/
            this.viewcali.Rows.Add("1", "2", "3", "4", "5", "6", "7");
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
    }
}
