using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trader_app.BL;

     
namespace trader_app.PL.SUP
{
    public partial class FRM_VENDOR_GROUP :PL.add_form
    {
        process_Class proc = new process_Class();
        SUP_vendor vendor = new SUP_vendor();
        DAL.DataAccessLayer dal;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        DataTable dt;
        public FRM_VENDOR_GROUP()
        {
            InitializeComponent();
        }

        private void FRM_VENDOR_GROUP_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(100, "اسم الحساب");
                list_C_N.Add(101, "الاسم الاجنبي");

                string wherestr = " where Type_ID = 2 and ";
                string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account ";

                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_V_ACCOUNT_ID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                btn_seve.Enabled = true;
                frm.Dispose();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_E_N.Text = txt_A_N.Text = txt_by_user.Text = txt_edit_date.Text = txt_edit_user.Text = txt_in_date.Text = "";
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.FindDataSet(" select V_GROUP_CODE from VENDOR_GROUP  ");

            if (dt.Rows.Count == 0)
                txt_V_GROUP_CODE.Text = "1";
            else
                txt_V_GROUP_CODE.Text = proc.max_num_in_Column("VENDOR_GROUP","V_GROUP_CODE");
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            vendor.P_SUP_insert_VENDOR_GROUP(Convert.ToInt32(txt_V_GROUP_CODE.Text), txt_A_N.Text, txt_E_N.Text,txt_V_ACCOUNT_ID.Text);
            proc.MessageBox_add_T();
        }

        private void txt_V_GROUP_CODE_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F9)
            {
                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم المجموعة ");
                list_C_N.Add(100, "اسم المجموعة ");
                list_C_N.Add(101, "الاسم الاجنبي ");
                list_C_N.Add(102, "رقم حساب المجموعه ");
                string sql = " SELECT V_GROUP_CODE , V_GROUP_A_NAME , V_GROUP_E_NAME , V_ACCOUNT_ID from VENDOR_GROUP ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
                frm.ShowDialog();
                txt_V_GROUP_CODE.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_A_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_E_N.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_V_ACCOUNT_ID.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                btn_edit.Enabled = true;
                btn_seve.Enabled = false;
                txt_V_GROUP_CODE.Enabled = false;
                frm.Dispose();
            }
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم المجموعة ");
            list_C_N.Add(100, "اسم المجموعة ");
            list_C_N.Add(101, "الاسم الاجنبي ");
            list_C_N.Add(102, "رقم حساب المجموعه ");
            string sql = " SELECT V_GROUP_CODE , V_GROUP_A_NAME , V_GROUP_E_NAME , V_ACCOUNT_ID from VENDOR_GROUP ";
            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();
            txt_V_GROUP_CODE.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_A_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_E_N.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_V_ACCOUNT_ID.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            btn_edit.Enabled = true;
            btn_seve.Enabled = false;
            txt_V_GROUP_CODE.Enabled = false;
            frm.Dispose();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            vendor.P_SUP_insert_VENDOR_GROUP(Convert.ToInt32(txt_V_GROUP_CODE.Text), txt_A_N.Text, txt_E_N.Text, txt_V_ACCOUNT_ID.Text);
            proc.MessageBox_upd_T();
        }
    }
}
