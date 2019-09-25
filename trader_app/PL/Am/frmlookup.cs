using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
///using Microsoft.Office.Interop.Excel;

namespace fingercs
{
    public partial class frmlookup : Form
    {
        public bool result=false;
        string[] Col = new string[10];
        string[] Cap = new string[10];
        string [] colfilter=new string[10];
        int[] coltype = new int[10];
       
        string stwhere;
        string strsql;
        int colcount;
        System.Data.DataTable  tb;

        public frmlookup()
        {
            InitializeComponent();
            colcount = -1;
            int i;
            for (i = 0; i < grdView.Columns.Count; i++)
            {
                grdView.Columns[i].Visible = false;
                grdView.Columns[i].DataPropertyName = "fld";
            }



        }

        public string getval(string colname)
        {
            if (grdView.RowCount > 0)
                return  am.ToSafeString ( grdView.CurrentRow.Cells[colname].Value);
            else
                return "0";
        }
        public DateTime  getdateval(string colname)
        {
            if (grdView.RowCount > 0)
                return (DateTime) grdView.CurrentRow.Cells[colname].Value;
            else
                return DateTime.Today;
        }
        public string getstring(string colname)
        {
            if (grdView.RowCount > 0)
                return am.ToSafeString (grdView.CurrentRow.Cells[colname].Value);
            else
                return "";
        }
        public int Setuplookup(string tname, string strwhere)
        {int i;
           strsql = "select  ";
            for (i=0;i<=colcount;i++)
            {
                strsql = strsql + Col[i] +",";
            }
            strsql = strsql + " 1 as fld from " + tname;
            stwhere = strwhere;
            if (stwhere.Equals(""))
                stwhere = " where rownum<200";
            else
               stwhere =  strwhere + " and rownum<200";


            tb = DB.FindDataSet(strsql+stwhere).Tables[0] ;
            grdView.DataSource = tb;

            return 0;
        }

        public int addcoll(string col, string caption,int ftype , int width,int flag)
        {
            
            int i = 0;
            colcount++;
            Col[colcount] = col;
            Cap[colcount] = caption;
            
            
            grdView.Columns[colcount].DataPropertyName = col;
            grdView.Columns[colcount].HeaderText = caption;
            grdView.Columns[colcount].Width = width;
            grdView.Columns[colcount].Name = col;
            grdView.Columns[colcount].Visible = (width > 0);

            if (flag > 0)
            {
                i = cbosearch.Items.Count;
                cbosearch.Items.Add(caption);
                colfilter[i] = col;
                coltype[i]= ftype;
               
            }

            return 0;

        }

static bool IsNumeric(string inputString)
{
    return Regex.IsMatch(inputString, "^[0-9]+$");
}
        private void button1_Click(object sender, EventArgs e)
        {   string st=stwhere;
            int i=cbosearch.SelectedIndex ;
            if (i>=0)
            {if (coltype[i]==0)
            {
                if (!IsNumeric(txtfield.Text))
                {
                    MessageBox.Show("field is not numeric type");
                    return;
                }
                 st = st + " and " + colfilter[i] + "=" + txtfield.Text; 
            }
            else{
            }
               
          if (!txtfield.Text.Trim().Equals("") )
                st=st + " and lower(" + colfilter[i] + ") like '" + txtfield.Text.ToLower()  +"%'";
                

           
            }

            tb = DB.FindDataSet(strsql + st).Tables[0];
            grdView.DataSource = tb;
        }

        private void frmlookup_Load(object sender, EventArgs e)
        {

        }

        private void grdView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdView.RowCount > 0)
                result = true;
           
            this.Close(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (grdView.RowCount > 0)
                result = true;
           
            this.Close(); 
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close(); 
        }

        private void grdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

         protected void ExportExcel(DataTable dt) 
 { 
     /*if (dt == null||dt.Rows.Count==0) return; 
      Microsoft.Office.Interop.Excel.Application xlApp = 
		new Microsoft.Office.Interop.Excel.Application(); 
   
     if (xlApp == null) 
     { 
         return; 
     } 
     System.Globalization.CultureInfo CurrentCI = 
		System.Threading.Thread.CurrentThread.CurrentCulture; 
     System.Threading.Thread.CurrentThread.CurrentCulture = 
			new System.Globalization.CultureInfo("en-US"); 
     Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks; 
      Microsoft.Office.Interop.Excel.Workbook workbook = 
	workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet); 
      Microsoft.Office.Interop.Excel.Worksheet worksheet = 
		(Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1]; 
     Microsoft.Office.Interop.Excel.Range range; 
      long totalCount = dt.Rows.Count; 
      long rowRead = 0; 
      float percent = 0; 
      for (int i = 0; i < dt.Columns.Count; i++) 
      { 
          worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName; 
          range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1]; 
          range.Interior.ColorIndex = 15; 
          range.Font.Bold = true; 
      } 
      for (int r = 0; r < dt.Rows.Count; r++) 
      { 
         for (int i = 0; i < dt.Columns.Count; i++) 
         { 
             worksheet.Cells[r + 2, i + 1] = dt.Rows[r][i].ToString(); 
         } 
          rowRead++; 
         percent = ((float)(100 * rowRead)) / totalCount; 
     } 
     xlApp.Visible = true; 
      * */
 }


         protected void ExportExcel(DataGridView dt)
         { /*
             if (dt == null || dt.Rows.Count == 0) return;
             Microsoft.Office.Interop.Excel.Application xlApp =
                 new Microsoft.Office.Interop.Excel.Application();

             if (xlApp == null)
             {
                 return;
             }
             System.Globalization.CultureInfo CurrentCI =
                System.Threading.Thread.CurrentThread.CurrentCulture;
             System.Threading.Thread.CurrentThread.CurrentCulture =
                    new System.Globalization.CultureInfo("en-US");
             Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
             Microsoft.Office.Interop.Excel.Workbook workbook =
           workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
             Microsoft.Office.Interop.Excel.Worksheet worksheet =
               (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
             Microsoft.Office.Interop.Excel.Range range;
             long totalCount = dt.Rows.Count;
             long rowRead = 0;
             float percent = 0;
             int k = 0;
             for (int i = 0; i < dt.Columns.Count; i++)
             {
                 worksheet.Cells[1, i + 1] = dt.Columns[i].HeaderText;
                 range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
                 range.Interior.ColorIndex = 15;
                 range.Font.Bold = true;
             }
             for (int r = 0; r < dt.Rows.Count; r++)
             {
                 DataGridViewRow row = grdView.Rows[r];
                 for (int i = 0; i < dt.Columns.Count; i++)
                 {
                     worksheet.Cells[r + 2, i + 1] = row.Cells[i].Value.ToString();
                 }
                 rowRead++;
                 percent = ((float)(100 * rowRead)) / totalCount;
             }
             xlApp.Visible = true;
            */

         }
       
       
private void button1_Click_2(object sender, EventArgs e)
        {
            ExportExcel(grdView);
            return;

           
           
         /// ExcelApp.ThisWorkbook.Worksheets.Add(1);

             for (int i = 0; i < grdView.Rows.Count; i++)
             {
                 DataGridViewRow row = grdView.Rows[i];
                 for (int j = 0; j < row.Cells.Count; j++)
                 {
                     ///ExcelApp.Cells[i + 1, j + 1] = row.Cells[j].ToString();
                 }
             }
             

        }
    }
}