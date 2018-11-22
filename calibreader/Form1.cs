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
using System.Xml;

using ICSharpCode.SharpZipLib.BZip2;
using ICSharpCode.SharpZipLib.Tar;
using ClosedXML.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Threading;
using AutoUpdaterDotNET;

namespace calibreader
{
    public partial class Form1 : Form
    {
        public const int max_column_count=17;
        public DataTable cali_dt;
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
                return false;
            }

            try
            {
                tarArchive = TarArchive.CreateInputTarArchive(gzipStream);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return false;
            }
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
                    //else return "empty";

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
            
            this.viewcali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.viewcali.AllowUserToAddRows = false;

            //initial data table;
            cali_dt = new DataTable();
            DataColumn dc;
            dc = new DataColumn("ID", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("lens_type", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("focus_idx", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("zoom_idx", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("inf_tele_focus", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("inf_wide_focus", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("focus_dynamic_offset", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("focus_value", typeof(String));
            cali_dt.Columns.Add(dc);           
            dc = new DataColumn("icr_mode", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("production", typeof(String));
            cali_dt.Columns.Add(dc);          
            dc = new DataColumn("awb_low_adj", typeof(String));
            cali_dt.Columns.Add(dc);

            dc = new DataColumn("awb_high_adj", typeof(String));
            cali_dt.Columns.Add(dc);

            dc = new DataColumn("awb_high_info", typeof(String));
            cali_dt.Columns.Add(dc);           
            dc = new DataColumn("awb_low_info", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("lens_info", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("cali_log", typeof(String));
            cali_dt.Columns.Add(dc);
            dc = new DataColumn("production_time", typeof(String));
            cali_dt.Columns.Add(dc);
            this.viewcali.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.viewcali.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
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


        public void getStats(string filePath, string directory_path)
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
                ExtractTGZ(filePath, tmppath);
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

                string awb_high_adj = getProductionLog(statpath + "\\cam_cali\\awb_high_adj");

                string cali_log = getProductionLog(statpath + "\\cam_cali\\cali_log");
                string awb_high_info = getProductionLog(statpath + "\\cam_cali\\debug\\awb_high_info");
                if (awb_high_info.Equals("none"))
                    awb_high_info = getProductionLog(statpath + "\\cam_cali\\awb_high_info");
                string awb_low_info = getProductionLog(statpath + "\\cam_cali\\debug\\awb_low_info");
                if (awb_low_info.Equals("none"))
                    awb_low_info = getProductionLog(statpath + "\\cam_cali\\awb_low_info");
                string lens_info = getProductionLog(statpath + "\\cam_cali\\debug\\lens_info");
                string[] pathSplit = filePath.Split('\\');
                string[] fileName = pathSplit.Last().Split('.');
                //this.viewcali.Rows.Add(fileName[0].ToString(), lens_type, focus_idx, zoom_idx, inf_tele_focus, inf_wide_focus, focus_dynamic_offset, focus_value, icr_mode, production, awb_low_adj, awb_high_info, awb_low_info, lens_info, cali_log, production_time);
                DataRow newRow = cali_dt.NewRow();
                newRow[0] = fileName[0].ToString();
                newRow[1] = lens_type;
                newRow[2] = focus_idx;
                newRow[3] = zoom_idx;
                newRow[4] = inf_tele_focus;
                newRow[5] = inf_wide_focus;
                newRow[6] = focus_dynamic_offset;
                newRow[7] = focus_value;
                newRow[8] = icr_mode;
                newRow[9] = production;
                newRow[10] = awb_low_adj;
                newRow[11] = awb_high_adj;
                newRow[12] = awb_high_info;
                newRow[13] = awb_low_info;
                newRow[14] = lens_info;
                newRow[15] = cali_log;
                newRow[16] = production_time;
                //cali_dt.Rows.Add(newRow);
                cali_dt.Rows.InsertAt(newRow, 0);
                this.viewcali.DataSource = cali_dt;

            }
            di.Delete(true);
        }

        public void getStatsInFolder(string directory_path)
        {
            string tmppath = directory_path + "\\calitmp";
            string statpath = directory_path + "\\calitmp\\mnt\\nand\\";

            DirectoryInfo di;

            string[] files = Directory.GetFiles(directory_path, "*.tar.gz");
            foreach (string filePath in files)
            {
                if (Directory.Exists(tmppath))
                {
                    if (!IsDirectoryEmpty(tmppath))
                        Directory.Delete(tmppath, true);
                }
                di = Directory.CreateDirectory(tmppath);
                if (File.Exists(filePath))
                {
                    ExtractTGZ(filePath, tmppath);
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

                    string awb_high_adj = getProductionLog(statpath + "\\cam_cali\\awb_high_adj");

                    string cali_log = getProductionLog(statpath + "\\cam_cali\\cali_log");
                    string awb_high_info = getProductionLog(statpath + "\\cam_cali\\debug\\awb_high_info");
                    if (awb_high_info.Equals("none"))
                        awb_high_info = getProductionLog(statpath + "\\cam_cali\\awb_high_info");
                    string awb_low_info = getProductionLog(statpath + "\\cam_cali\\debug\\awb_low_info");
                    if (awb_low_info.Equals("none"))
                        awb_low_info= getProductionLog(statpath + "\\cam_cali\\awb_low_info");
                    string lens_info = getProductionLog(statpath + "\\cam_cali\\debug\\lens_info");
                    string[] pathSplit = filePath.Split('\\');
                    string[] fileName = pathSplit.Last().Split('.');
                    //this.viewcali.Rows.Add(fileName[0].ToString(), lens_type, focus_idx, zoom_idx, inf_tele_focus, inf_wide_focus, focus_dynamic_offset, focus_value, icr_mode, production, awb_low_adj, awb_high_info, awb_low_info, lens_info, cali_log, production_time);
                    DataRow newRow = cali_dt.NewRow();
                    newRow[0] = fileName[0].ToString();
                    newRow[1] = lens_type;
                    newRow[2] = focus_idx;
                    newRow[3] = zoom_idx;
                    newRow[4] = inf_tele_focus;
                    newRow[5] = inf_wide_focus;
                    newRow[6] = focus_dynamic_offset;
                    newRow[7] = focus_value;
                    newRow[8] = icr_mode;
                    newRow[9] = production;
                    newRow[10] = awb_low_adj;
                    newRow[11] = awb_high_adj;
                    newRow[12] = awb_high_info;
                    newRow[13] = awb_low_info;
                    newRow[14] = lens_info;
                    newRow[15] = cali_log;
                    newRow[16] = production_time;
                    cali_dt.Rows.Add(newRow);
                    this.viewcali.DataSource = cali_dt;
                }
                di.Delete(true);
            }
        }

        private void onOpenFileClick(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Camera File|*.tar.gz";
            openFileDialog1.Title = "Select a production log File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                //new Thread(() => new loading_form().ShowDialog()).Start();
                getStats(openFileDialog1.FileName, Path.GetDirectoryName(openFileDialog1.FileName));
                for (int j = 0; j < max_column_count; j++)
                    this.viewcali.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //loading_form f = new loading_form();
                //f = (loading_form)Application.OpenForms["loading_form"];
                //f.Close();
            }
        }

        private void onOpenFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {              
                new Thread(() => new loading_form().ShowDialog()).Start();
                getStatsInFolder(folderDlg.SelectedPath);
                for (int j = 0; j < max_column_count; j++)
                    this.viewcali.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                loading_form f = new loading_form();
                f = (loading_form)Application.OpenForms["loading_form"];
                f.Close();
            }
        }
        public void ExportToExcelWithFormatting(DataGridView dataGridView1)
        {
            string fileName;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.Title = "To Excel";
            saveFileDialog1.FileName = this.Text + " (" + DateTime.Now.ToString("yyyy-MM-dd") + ")";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                new Thread(() => new loading_form().ShowDialog()).Start();
                fileName = saveFileDialog1.FileName;
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add(this.Text);
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].Name;
                }
                Debug.WriteLine(dataGridView1.Rows.Count);
                Debug.WriteLine(dataGridView1.Columns.Count);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Debug.WriteLine(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value.ToString();

                        if (worksheet.Cell(i + 2, j + 1).Value.ToString().Length > 0)
                        {
                            XLAlignmentHorizontalValues align;

                            switch (dataGridView1.Rows[i].Cells[j].Style.Alignment)
                            {
                                case DataGridViewContentAlignment.BottomRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.MiddleRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.TopRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;

                                case DataGridViewContentAlignment.BottomCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                case DataGridViewContentAlignment.MiddleCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                case DataGridViewContentAlignment.TopCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;

                                default:
                                    align = XLAlignmentHorizontalValues.Left;
                                    break;
                            }

                            worksheet.Cell(i + 2, j + 1).Style.Alignment.Horizontal = align;

                            XLColor xlColor = XLColor.FromColor(dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor);
                            worksheet.Cell(i + 2, j + 1).AddConditionalFormat().WhenLessThan(1).Fill.SetBackgroundColor(xlColor);

                            worksheet.Cell(i + 2, j + 1).Style.Font.FontName = dataGridView1.Font.Name;
                            worksheet.Cell(i + 2, j + 1).Style.Font.FontSize = dataGridView1.Font.Size;

                        }
                    }
                }
                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(fileName);
                loading_form f = new loading_form();
                f = (loading_form)Application.OpenForms["loading_form"];
                f.Close();

                //MessageBox.Show("Done");
            }
        }
        private void exportFile(object sender, EventArgs e)
        {
            ExportToExcelWithFormatting(this.viewcali);
        }

        private void importFromXML(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Camera File|*.xlsx";
            openFileDialog1.Title = "Select a excel Log File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                new Thread(() => new loading_form().ShowDialog()).Start();
                Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbook workbook = app.Workbooks.Open(openFileDialog1.FileName);
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                //this.viewcali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                int rcount = worksheet.UsedRange.Rows.Count;               
                int i = 1;
                //this.viewcali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;             
                for (; i < rcount; i++)
                {
                    //dataGridView1.Rows[i].Cells["Column1"].Value = worksheet.Cells[i + 1, 1].Value;
                    //dataGridView1.Rows[i].Cells["Column2"].Value = worksheet.Cells[i + 1, 2].Value;
                    /*this.viewcali.Rows.Add(worksheet.Cells[i + 1, 1].Value, worksheet.Cells[i + 1, 2].Value,
                        worksheet.Cells[i + 1, 3].Value, 
                        worksheet.Cells[i + 1, 4].Value,
                        worksheet.Cells[i + 1, 5].Value, 
                        worksheet.Cells[i + 1, 6].Value, 
                        worksheet.Cells[i + 1, 7].Value, 
                        worksheet.Cells[i + 1, 8].Value, 
                        worksheet.Cells[i + 1, 9].Value, 
                        worksheet.Cells[i + 1, 10].Value, 
                        worksheet.Cells[i + 1, 11].Value, 
                        worksheet.Cells[i + 1, 12].Value, 
                        worksheet.Cells[i + 1, 13].Value, 
                        worksheet.Cells[i + 1, 14].Value, 
                        worksheet.Cells[i + 1, 15].Value, 
                        worksheet.Cells[i + 1, 16].Value);*/
                    DataRow newRow = cali_dt.NewRow();
                    newRow[0] = worksheet.Cells[i + 1, 1].Value;
                    newRow[1] = worksheet.Cells[i + 1, 2].Value;
                    newRow[2] = worksheet.Cells[i + 1, 3].Value;
                    newRow[3] = worksheet.Cells[i + 1, 4].Value;
                    newRow[4] = worksheet.Cells[i + 1, 5].Value;
                    newRow[5] = worksheet.Cells[i + 1, 6].Value;
                    newRow[6] = worksheet.Cells[i + 1, 7].Value;
                    newRow[7] = worksheet.Cells[i + 1, 8].Value;
                    newRow[8] = worksheet.Cells[i + 1, 9].Value;
                    newRow[9] = worksheet.Cells[i + 1, 10].Value;
                    newRow[10] = worksheet.Cells[i + 1, 11].Value;
                    newRow[11] = worksheet.Cells[i + 1, 12].Value;
                    newRow[12] = worksheet.Cells[i + 1, 13].Value;
                    newRow[13] = worksheet.Cells[i + 1, 14].Value;
                    newRow[14] = worksheet.Cells[i + 1, 15].Value;
                    newRow[15] = worksheet.Cells[i + 1, 16].Value;
                    newRow[16] = worksheet.Cells[i + 1, 17].Value;
                    cali_dt.Rows.Add(newRow);
                    this.viewcali.DataSource = cali_dt;
                }
                workbook.Close();
                for (int j = 0; j < max_column_count; j++)
                    this.viewcali.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                loading_form f = new loading_form();
                f = (loading_form)Application.OpenForms["loading_form"];
                f.Close();

            }
        }

        private void OnClearData(object sender, EventArgs e)
        {                     
            this.cali_dt.Clear();         
            this.viewcali.Refresh();
        }

        private void OnTextChange(object sender, EventArgs e)
        {
            if (this.cali_dt.Rows.Count == 0) return;
            if (String.IsNullOrEmpty(findBox.Text)) (this.viewcali.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            else
            (this.viewcali.DataSource as DataTable).DefaultView.RowFilter = string.Format("ID LIKE '*{0}*' OR lens_type  LIKE '*{0}*' OR focus_idx  LIKE '*{0}*' OR zoom_idx  LIKE '*{0}*' OR inf_tele_focus  LIKE '*{0}*' OR inf_wide_focus  LIKE '*{0}*' OR focus_dynamic_offset  LIKE '*{0}*' OR focus_value  LIKE '*{0}*' OR icr_mode  LIKE '*{0}*' OR production  LIKE '*{0}*' OR awb_low_adj  LIKE '*{0}*' OR awb_high_info  LIKE '*{0}*' OR awb_low_info  LIKE '*{0}*' OR lens_info  LIKE '*{0}*' OR cali_log LIKE '*{0}*' OR production_time LIKE '*{0}*'", findBox.Text);
            //Debug.WriteLine(findBox.Text);
        }

        private void onClickAbout(object sender, EventArgs e)
        {
            about ab = new about();
            ab.Show();

        }
        private void AutoUpdater_ApplicationExitEvent()
        {
            Text = @"Closing application...";
            Thread.Sleep(1000);
            Application.Exit();
        }
        private void OnClickAutoUpdate(object sender, EventArgs e)
        {
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
            AutoUpdater.Start("http://172.17.81.213/release/app.xml");

        }
    }
 }
