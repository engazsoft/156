
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using trader_app.BL;
using System.Runtime.InteropServices;

           
namespace trader_app.PL.SUP
{
    public partial class frm_VI_DETAILS : PL.add_form
    {

        Am.frm_Account_request_dgv frm = new Am.frm_Account_request_dgv();
        process_Class proc = new process_Class();
        Account_Class Account = new Account_Class();
        DAL.DataAccessLayer dal;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        public int check;
        DataTable dt;
        string Account_ID;

        public frm_VI_DETAILS()
        {
            InitializeComponent();
        }

        private void frm_VI_DETAILS_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_currency, "select currency_Key,currency_name from AM_Currency where Used='1' ", "currency_name", "currency_Key");
            cbx_currency.SelectedIndex = 3;
        }

        private void dgv_V_curr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txt_Account_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_V_TAX_CODE_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbx_minor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbx_minor.SelectedIndex == 0)
            {
                txt_Product_ID_to.Visible = false;
                txt_V_CODE_to.Visible = true;
                label3.Visible = false;
                label22.Visible = true;
            }
            else
            {
                txt_V_CODE_to.Visible = false;
                txt_Product_ID_to.Visible = true;
                label3.Visible = true;
                label22.Visible = false;
            }

        }

        private void txt_V_CODE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F9)
            {
                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم المورد");
                list_C_N.Add(100, "اسم المورد ");
                list_C_N.Add(101, "الاسم الاجنبي ");


                string sql = " SELECT  V_CODE , V_A_NAME , V_E_NAME  FROM   V_DETAILS ";

                PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
                frm.ShowDialog();
                txt_V_CODE.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();;
                btn_seve.Enabled = true;
                frm.Dispose();
            }
        }

        private void txt_V_CODE_to_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم المورد");
                list_C_N.Add(100, "اسم المورد ");
                list_C_N.Add(101, "الاسم الاجنبي ");
                string sql = " SELECT  V_CODE , V_A_NAME , V_E_NAME  FROM   V_DETAILS ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
                frm.ShowDialog();
                txt_V_CODE_to.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString(); ;
                btn_seve.Enabled = true;
                frm.Dispose();
            }
        }
    }
}
