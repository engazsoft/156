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
    public partial class frm_VENDOR_CLASS : PL.add_form
    {
        process_Class proc = new process_Class();
        SUP_vendor vendor = new SUP_vendor();
        DAL.DataAccessLayer dal;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        DataTable dt;
        public frm_VENDOR_CLASS()
        {
            InitializeComponent();
        }

        private void frm_VENDOR_CLASS_Load(object sender, EventArgs e)
        {

        }

        private void txt_A_N_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_E_N.Text = txt_A_N.Text = txt_by_user.Text = txt_edit_date.Text = txt_edit_user.Text = txt_in_date.Text = "";
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer(); 
            DataTable dt = new DataTable();
            dt = dal.FindDataSet(" select V_CLASS from SUP_VENDOR_CLASS  ");
         
            if (dt.Rows.Count ==0)
                txt_V_CLASS.Text = "1";
            else
                txt_V_CLASS.Text = proc.max_num_in_Column("SUP_VENDOR_CLASS", " V_CLASS");
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            vendor.P_SUP_insert_VENDOR_CLASS(Convert.ToInt32(txt_V_CLASS.Text), txt_A_N.Text, txt_E_N.Text);
            proc.MessageBox_add_T();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            vendor.P_SUP_insert_VENDOR_CLASS(Convert.ToInt32(txt_V_CLASS.Text), txt_A_N.Text, txt_E_N.Text);
            proc.MessageBox_upd_T();
        }

        private void txt_V_CLASS_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F9 )
                {
                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم المورد");
                list_C_N.Add(100, "اسم المورد ");
                list_C_N.Add(101, "الاسم الاجنبي ");
                string sql = " SELECT V_CLASS , V_CLASS_NAME , V_CLASS_E_NAME from SUP_VENDOR_CLASS  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
                frm.ShowDialog();
                txt_V_CLASS.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_A_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_E_N.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                btn_edit.Enabled = true;
                btn_seve.Enabled = false ;
                txt_V_CLASS.Enabled = false;
                frm.Dispose();
            }
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم المورد");
            list_C_N.Add(100, "اسم المورد ");
            list_C_N.Add(101, "الاسم الاجنبي ");
            string sql = " SELECT V_CLASS , V_CLASS_NAME , V_CLASS_E_NAME from SUP_VENDOR_CLASS  ";
            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();
            
            txt_V_CLASS.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_A_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_E_N.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            btn_edit.Enabled = true;
            btn_seve.Enabled = false;
            txt_V_CLASS.Enabled = false;
            frm.Dispose();
        }
    }
}
