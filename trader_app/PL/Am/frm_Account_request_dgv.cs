using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using trader_app.BL;
using System.Runtime.InteropServices;

namespace trader_app.PL.Am
{
    public partial class frm_Account_request_dgv : Form
    {
        process_Class proc = new process_Class();
        Account_Class Account = new Account_Class();
        DAL.DataAccessLayer dal;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        public static bool Checked;
        DataTable dt;
        public frm_Account_request_dgv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            //foreach (DataGridViewRow row in dgv_Account_request.Rows)
            //{
            //    if (row.Cells["الموافقه"].Value == DBNull.Value)
            //    {

            //        row.Cells["الموافقه"].Value = CheckState.Checked;

            //    }

            //}
        }

        private void frm_Account_request_dgv_Load(object sender, EventArgs e)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dgv_Account_request.DataSource = dal.FindDataSet("select Account_ID as'رقم الحساب', Account_Parent_ID as'رقم الحساب الرئيسي ', A_N as الاسم  , E_N as 'الاسم الاجنبي ', Type_ID as 'النوع', Account_Group_ID as 'نوع المجموعه ', Class_ID as' نوع الصنف' , Note as 'الملاحظة ', by_user as 'المستخدم',add_status as 'الموافقه' from AC_Account_Request where add_status='0'");
            dgv_Account_request.Columns[0].Width = 100;
            dgv_Account_request.Columns[0].Name = "رقم الحساب";
            dgv_Account_request.Columns[1].Width = 200;
            dgv_Account_request.Columns[1].Name="رقم الحساب الرئيسي" ;
            dgv_Account_request.Columns[2].Width = 70;
            dgv_Account_request.Columns[2].Name ="الاسم";
            dgv_Account_request.Columns[3].Width = 100;
            dgv_Account_request.Columns[3].Name = "الاسم الاجنبي";
            dgv_Account_request.Columns[4].Width = 70;
            dgv_Account_request.Columns[4].Name = "النوع";
            dgv_Account_request.Columns[5].Width = 100;
            dgv_Account_request.Columns[5].Name = "نوع المجموعه";
            dgv_Account_request.Columns[6].Width = 100;
            dgv_Account_request.Columns[6].Name = "نوع الصنف";
            dgv_Account_request.Columns[7].Width = 70;
            dgv_Account_request.Columns[7].Name = "الملاحظة";
            dgv_Account_request.Columns[8].Width = 70;
            dgv_Account_request.Columns[8].Name = "المستخدم";
            dgv_Account_request.Columns[9].Width = 70;
            dgv_Account_request.Columns[9].Name = "الموافقه";



        }

        private void dgv_Account_request_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isChecked = (bool)dgv_Account_request[9, e.RowIndex].EditedFormattedValue;
            if (isChecked == true)
            {

                dgv_Account_request.CurrentRow.Cells[9].Value = true;
               
                this.Close();
            }
            // dgv_Account_request.DataSource = dal.FindDataSet("select Account_ID as'رقم الحساب', Account_Parent_ID as'رقم الحساب الرئيسي ', A_N as الاسم  , E_N as 'الاسم الاجنبي ', Type_ID as 'النوع', Account_Group_ID as 'نوع المجموعه ', Class_ID as' نوع الصنف' , Note as 'الملاحظة ', by_user as 'المستخدم',add_status as 'الموافقه' from AC_Account_Request where add_status='0'");
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            this.dgv_Account_request.DataSource = Account.P_AM_Get_Account_request_dgv(txt_search.Text);
        }

        private void dgv_Account_request_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {


            // this.Close();
        }

    }

}