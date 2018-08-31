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
        public static bool ExtractTGZ(String gzArchiveName, String destFolder)
        {
            Stream inStream = File.OpenRead(gzArchiveName);
            Stream gzipStream;
            TarArchive tarArchive;
            try
            {
                gzipStream = new BZip2InputStream(inStream);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return false; }

            try
            {
                tarArchive = TarArchive.CreateInputTarArchive(gzipStream);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return false; }
            tarArchive.ExtractContents(destFolder);
            tarArchive.Close();

            gzipStream.Close();
            inStream.Close();
            return true;
        }
        public static string getProductionLog(String filepath)
        {
            string result = "";
            int lineCount = 1;

            if (!File.Exists(filepath))
                return "none";
            else
            {
                string[] lines = File.ReadAllLines(filepath);
                foreach (string stat in lines)
                {
                    if (!string.IsNullOrEmpty(stat))
                    {

                        if (lines.Length > 1)
                        {
                            result += stat;
                            if (lineCount != lines.Length)
                            {
                                result += "\r\n";
                                lineCount++;
                            }

                        }
                        else
                            result += stat;
                    }
                    else return "empty";

                }
            }
            return result;
        }
        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }
        public Form1()
        {
            InitializeComponent();

            /*DataGridViewRow row = (DataGridViewRow)viewcali.Rows[0].Clone();
            row.Cells[0].Value = "XYZ";
            row.Cells[1].Value = 50.2;
            viewcali.Rows.Add(row);*/
            //this.viewcali.Rows.Add("1", "2", "3", "4", "5", "6", "7");
            //Debug.WriteLine("1234");
            //this.viewcali.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.viewcali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        /*private void viewcali_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not in our 
            if (e.ColumnIndex == this.viewcali.Columns["show_log"].Index && e.RowIndex >= 0)
            {
                String str = this.viewcali.Rows[e.RowIndex].Cells[1].Value.ToString();
                Debug.WriteLine("Button on row {0} clicked value {1}", e.RowIndex,str);
            }
        }*/


        public void getStats(string filePath,string directory_path)
        {          
            string tmppath = directory_path + "\\calitmp";
            string statpath = directory_path + "\\calitmp\\mnt\\nand\\";

            DirectoryInfo di;
            if (Directory.Exists(tmppath))
            {
                if (!IsDirectoryEmpty(tmppath))
                    Directory.Delete(tmppath, true);
            }
            di = Directory.CreateDirectory(tmppath);
            if (File.Exists(filePath))
            {
                ExtractTGZ(filePath,tmppath);
                string focus_idx = getProductionLog(statpath + "\\lens\\focus_idx");
                string focus_dynamic_offset = getProductionLog(statpath + "\\lens\\focus_dynamic_offset");               
                string inf_tele_focus = getProductionLog(statpath + "\\lens\\inf_tele_focus");                
                string inf_wide_focus = getProductionLog(statpath + "\\lens\\inf_wide_focus");                
                string lens_type = getProductionLog(statpath + "\\lens\\lens_type");               
                string zoom_idx = getProductionLog(statpath + "\\lens\\zoom_idx");               
                string focus_value = getProductionLog(statpath + "\\lens\\focus_value");               
                string icr_mode = getProductionLog(statpath + "\\lens\\icr_mode");               
                string production = getProductionLog(statpath + "\\factory\\production");              
                string production_time = getProductionLog(statpath + "\\factory\\production_time");              
                string testcase_time = getProductionLog(statpath + "\\factory\\TestCase_time");             
                string awb_low_adj = getProductionLog(statpath + "\\cam_cali\\awb_low_adj");             
                string cali_log = getProductionLog(statpath + "\\cam_cali\\cali_log");               
                string awb_high_info = getProductionLog(statpath + "\\cam_cali\\debug\\awb_high_info");              
                string awb_low_info = getProductionLog(statpath + "\\cam_cali\\debug\\awb_low_info");               
                string lens_info = getProductionLog(statpath + "\\cam_cali\\debug\\lens_info");
                string[] pathSplit = filePath.Split('\\');
                string[] fileName = pathSplit.Last().Split('.');
                this.viewcali.Rows.Add(fileName[0].ToString(), lens_type, focus_idx,zoom_idx,inf_tele_focus,inf_wide_focus,focus_dynamic_offset,focus_value,icr_mode,production,awb_low_adj,awb_high_info,awb_low_info,lens_info,cali_log,production_time);
            }
            di.Delete(true);
        }
        

        private void onOpenFileClick(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Camera File|*.tar.gz";
            openFileDialog1.Title = "Select a camera log File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Debug.WriteLine(openFileDialog1.FileName);
                //Debug.WriteLine(Path.GetDirectoryName(openFileDialog1.FileName));
                getStats(openFileDialog1.FileName, Path.GetDirectoryName(openFileDialog1.FileName));
            }
        }

    }
}
