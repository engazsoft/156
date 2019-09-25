
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

namespace trader_app.PL.AC
{
    public partial class frm_Account_LMT : PL.add_form
    {
        Am.frm_Account_request_dgv frm = new Am.frm_Account_request_dgv();
        process_Class proc = new process_Class();
        Account_Class Account = new Account_Class();
        DAL.DataAccessLayer dal;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        public int check;
        DataTable dt;
        string Account_ID;
        public frm_Account_LMT()
        {
            InitializeComponent();
        }

        private void frm_Account_LMT_Load(object sender, EventArgs e)
        {


            DB.LoadCombo(cbx_Account_type, "select Type_ID,A_N from AC_Account_Type ", "A_N", "Type_ID");
            DB.LoadCombo(cbx_currency, "select currency_Key,currency_name from AM_Currency where Used='1' ", "currency_name", "currency_Key");

            cbx_currency.SelectedIndex = 3;
            cbx_EXCEED_LMT.SelectedIndex = 0;
            cbx_DR_CR.SelectedIndex = 0;
            cbx_INACTIVE.SelectedIndex = 0;
        }

        private void pic_BANK_IMG_Click(object sender, EventArgs e)
        {

        }

        private void txt_REC_LETTER_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_A_CODE_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_BANK_NO_id_Enter(object sender, EventArgs e)
        {

        }

        private void txt_BANK_NO_id_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_BANK_NO_id_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbx_Acount_group_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            txt_id_from.Enabled = true;
            txt_id_to.Enabled = true;
            btn_search1.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الحساب");
            list_C_N.Add(100, "اسم الحساب");
            list_C_N.Add(101, "الاسم الاجنبي");

            string wherestr = " where Type_ID = 2 and ";
            string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account ";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
            frm.ShowDialog();
            txt_Account_ID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_A_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Account_ID.ReadOnly = true;
            btn_seve.Enabled = true;
            frm.Dispose();
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            Account.P_AC_insert_Account_LMT(txt_Account_ID.Text, txt_A_N.Text, proc.Insert_com_to_db(cbx_currency), Convert.ToInt32(txt_MIN_AMT.Text), Convert.ToInt32(txt_MAX_AMT.Text), Convert.ToInt32(txt_MIN_TRNS_AMT.Text)
                , Convert.ToInt32(txt_MAX_TRNS_AMT.Text), Convert.ToBoolean(cbx_EXCEED_LMT.SelectedIndex)
                , Convert.ToBoolean(cbx_DR_CR.SelectedIndex), txt_LMT_DESC.Text, Convert.ToBoolean(cbx_INACTIVE.SelectedIndex));

            dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.FindDataSet("SELECT Account_ID, A_N , currency_Key, MIN_AMT , MAX_AMT , MIN_TRNS_AMT , MAX_TRNS_AMT, EXCEED_LMT , DR_CR , LMT_DESC , INACTIVE  FROM AC_Account_LMT where Account_ID=" + txt_Account_ID.Text + "");
            if (dt.Rows.Count > 0)
            {
                dgv_account_LMT.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dal = new DAL.DataAccessLayer();
                    int n = dgv_account_LMT.Rows.Add();

                    dgv_account_LMT.Rows[n].Cells[0].Value = row["Account_ID"];
                    dgv_account_LMT.Rows[n].Cells[1].Value = row["A_N"];
                    dgv_account_LMT.Rows[n].Cells[2].Value = row["currency_Key"];
                    dgv_account_LMT.Rows[n].Cells[3].Value = row["MIN_AMT"];
                    dgv_account_LMT.Rows[n].Cells[4].Value = row["MAX_AMT"];
                    dgv_account_LMT.Rows[n].Cells[5].Value = row["MIN_TRNS_AMT"];
                    dgv_account_LMT.Rows[n].Cells[6].Value = row["MAX_TRNS_AMT"];
                    dgv_account_LMT.Rows[n].Cells[7].Value = Convert.ToInt16(row["EXCEED_LMT"]);
                    dgv_account_LMT.Rows[n].Cells[8].Value = Convert.ToInt16(row["DR_CR"]);
                    dgv_account_LMT.Rows[n].Cells[9].Value = Convert.ToInt16(row["INACTIVE"]);
                    dgv_account_LMT.Rows[n].Cells[10].Value = row["LMT_DESC"];
                }
            }





        }

        private void btn_search1_Click(object sender, EventArgs e)
        {

            dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.FindDataSet("SELECT Account_ID , A_N , currency_Key , MIN_AMT , MAX_AMT , MIN_TRNS_AMT , MAX_TRNS_AMT , EXCEED_LMT , DR_CR , LMT_DESC , INACTIVE  FROM AC_Account_LMT where Account_ID between '"+txt_id_from.Text+"' and '"+txt_id_to.Text+"'");
            if (dt.Rows.Count > 0)
            {
                dgv_account_LMT.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {

                    dal = new DAL.DataAccessLayer();
                    int n = dgv_account_LMT.Rows.Add();
                    dgv_account_LMT.Rows[n].Cells[0].Value = row["Account_ID"];
                    dgv_account_LMT.Rows[n].Cells[1].Value = row["A_N"];
                    dgv_account_LMT.Rows[n].Cells[2].Value = row["currency_Key"];
                    dgv_account_LMT.Rows[n].Cells[3].Value = row["MIN_AMT"];
                    dgv_account_LMT.Rows[n].Cells[4].Value = row["MAX_AMT"];
                    dgv_account_LMT.Rows[n].Cells[5].Value = row["MIN_TRNS_AMT"];
                    dgv_account_LMT.Rows[n].Cells[6].Value = row["MAX_TRNS_AMT"];
                    dgv_account_LMT.Rows[n].Cells[7].Value = Convert.ToInt16(row["EXCEED_LMT"]);
                    dgv_account_LMT.Rows[n].Cells[8].Value = Convert.ToInt16(row["DR_CR"]);
                    dgv_account_LMT.Rows[n].Cells[9].Value = Convert.ToInt16(row["INACTIVE"]);
                    dgv_account_LMT.Rows[n].Cells[10].Value = row["LMT_DESC"];

                }
            }
        }

        private void txt_id_from_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F9)
            {
                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(100, "اسم الحساب");


                string sql = " SELECT  Account_ID , A_N   FROM  AC_Account_LMT ";

                PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
                frm.ShowDialog();
                txt_id_from.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_Account_ID.ReadOnly = true;
                btn_seve.Enabled = true;
                frm.Dispose();
            }
        }

        private void txt_id_to_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(100, "اسم الحساب ");

                string sql = " SELECT  Account_ID , A_N   FROM   AC_Account_LMT ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
                frm.ShowDialog();
                txt_id_to.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_Account_ID.ReadOnly = true;
                btn_seve.Enabled = true;
                frm.Dispose();
            }
        }

        private void dgv_account_LMT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_account_LMT_SelectionChanged(object sender, EventArgs e)
        {

     

        }

        private void dgv_account_LMT_MouseClick(object sender, MouseEventArgs e)
        {

            txt_id_from.Text = txt_id_to.Text = " ";
            btn_seve.Enabled = false;
            btn_edit.Enabled = true;
            txt_Account_ID.Text = dgv_account_LMT.CurrentRow.Cells[0].Value.ToString();
            txt_A_N.Text = dgv_account_LMT.CurrentRow.Cells[1].Value.ToString();
            cbx_currency.SelectedValue = dgv_account_LMT.CurrentRow.Cells[2].Value.ToString();
            txt_MIN_AMT.Text = dgv_account_LMT.CurrentRow.Cells[3].Value.ToString();
            txt_MAX_AMT.Text = dgv_account_LMT.CurrentRow.Cells[4].Value.ToString();
            txt_MIN_TRNS_AMT.Text = dgv_account_LMT.CurrentRow.Cells[5].Value.ToString();
            txt_MAX_TRNS_AMT.Text = dgv_account_LMT.CurrentRow.Cells[6].Value.ToString();
            cbx_EXCEED_LMT.SelectedIndex = Convert.ToInt32( dgv_account_LMT.CurrentRow.Cells[7].Value);
            cbx_DR_CR.SelectedIndex = Convert.ToInt32(dgv_account_LMT.CurrentRow.Cells[8].Value);
            cbx_INACTIVE.SelectedIndex = Convert.ToInt32(dgv_account_LMT.CurrentRow.Cells[9].Value);
            txt_LMT_DESC.Text = dgv_account_LMT.CurrentRow.Cells[10].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Account.P_AC_insert_Account_LMT(txt_Account_ID.Text, txt_A_N.Text, proc.Insert_com_to_db(cbx_currency), Convert.ToInt32(txt_MIN_AMT.Text), Convert.ToInt32(txt_MAX_AMT.Text), Convert.ToInt32(txt_MIN_TRNS_AMT.Text)
               , Convert.ToInt32(txt_MAX_TRNS_AMT.Text), Convert.ToBoolean(cbx_EXCEED_LMT.SelectedIndex)
               , Convert.ToBoolean(cbx_DR_CR.SelectedIndex), txt_LMT_DESC.Text, Convert.ToBoolean(cbx_INACTIVE.SelectedIndex));

          
            if (dgv_account_LMT.RowCount>0)
            {
              
                    dgv_account_LMT.CurrentRow.Cells[0].Value = txt_Account_ID.Text;
                    dgv_account_LMT.CurrentRow.Cells[1].Value = txt_A_N.Text;
                    dgv_account_LMT.CurrentRow.Cells[2].Value = cbx_currency.SelectedValue;
                    dgv_account_LMT.CurrentRow.Cells[3].Value = txt_MIN_AMT.Text;
                    dgv_account_LMT.CurrentRow.Cells[4].Value = txt_MAX_AMT.Text;
                    dgv_account_LMT.CurrentRow.Cells[5].Value = txt_MIN_TRNS_AMT.Text;
                    dgv_account_LMT.CurrentRow.Cells[6].Value = txt_MAX_TRNS_AMT.Text;
                    dgv_account_LMT.CurrentRow.Cells[7].Value = cbx_EXCEED_LMT.SelectedIndex;
                    dgv_account_LMT.CurrentRow.Cells[8].Value = cbx_DR_CR.SelectedIndex;
                    dgv_account_LMT.CurrentRow.Cells[9].Value =  cbx_INACTIVE.SelectedIndex;
                    dgv_account_LMT.CurrentRow.Cells[10].Value = txt_LMT_DESC.Text;
                }
            }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_Account_ID.Text = txt_A_N.Text = txt_id_from.Text = txt_by_user.Text = txt_edit_date.Text = txt_id_to.Text
                = txt_LMT_DESC.Text = txt_MAX_TRNS_AMT.Text = txt_MIN_AMT.Text = txt_MIN_TRNS_AMT.Text = txt_MAX_AMT.Text = " ";
            dgv_account_LMT.Rows.Clear();
            txt_id_to.Enabled = false;
            txt_id_from.Enabled = false;btn_search1.Enabled = false;
                
        }
    }
    }


