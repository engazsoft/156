using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace trader_app.PL.Am
{
     partial class Frm_currency : PL.add_form
    {
        DAL.DataAccessLayer dal;
        DataTable dt;
        BL.process_Class proc;
        BL.AM_Currency_Class Currency = new BL.AM_Currency_Class();
        DAL.Databas_Class DB = new DAL.Databas_Class();
        public Frm_currency()
        {
            InitializeComponent();
            txt_currenccy_id.Focus();
        }

        private void currency_frm_Load(object sender, EventArgs e)
        {
            txt_currenccy_id.ReadOnly = false;
            txt_currenccy_id.Focus();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
            //if (txt_branch_id.Text != string.Empty)
            //{
            //    DataTable dt = pro.select_data_row("AM_Branches", "Branch_ID", Convert.ToInt32(txt_branch_id.Text));

            //    txt_Branch_A_N.Text = g_info"Branch_A_N"].ToString();
            //    txt_Branch_E_N.Text = g_info"Branch_E_N"].ToString();
            //    txt_phone.Text = g_info"Phone_num"].ToString();
            //    txt_Location_A.Text = g_info"location"].ToString();
            //    txt_Fax_num.Text = g_info"Fax_num"].ToString();
            //    txt_Mail_box.Text = g_info"Mail_box"].ToString();
            //    txt_B_F_Tele.Text = g_info"B_F_Tele"].ToString();
            //    txt_B_F_BOX.Text = g_info"B_F_Box"].ToString();
            //    txt_B_F_Fax.Text = g_info"B_F_Fax"].ToString();
            //    txt_A_Note.Text = g_info"A_note"].ToString();
            //    txt_E_Note.Text = g_info"E_note"].ToString();
            //    txt_Tax_num.Text = g_info"Tax_num"].ToString();
            //    txt_year_id.Text = g_info"year_id"].ToString();
            //    txt_Compony_ID.Text = g_info"Company_ID"].ToString();
            //    pro.selec_value_com_from_db(cbx_country, g_info"Country_ID"].ToString());


            //    txt_by_user.Text = g_info"by_user"].ToString();
            //    txt_in_date.Text = g_info"in_date"].ToString();
            //    txt_edit_user.Text = g_info"edit_user"].ToString();
            //    txt_edit_date.Text = g_info"edit_date"].ToString();

            //    pro.selec_value_com_from_db(cbx_gvr, g_info"Gov_id"].ToString());

            //    pro.selec_value_com_from_db(cbx_dist, g_info"Distinct_id"].ToString());

            //    pro.select_image_frim_db(pic_pranch_logo, dt, 0, 15);
            //}

        }

        private void currency_frm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                dt = new DataTable();
                dal = new DAL.DataAccessLayer();
                string sql = "SELECT  [currency_ID] as رقم_العملة ,[currency_Key] as اختصار  ,[currency_name] as اسم_العملة  ,[currency_name_e]  as الاسم_الاجنبي     FROM [trader_db].[dbo].[AM_Currency]";
                //dt.Columns.RemoveAt(6);
                //dt.Columns.RemoveAt(5);
                //dt.Columns.RemoveAt(4);
                //dt.Columns.RemoveAt(3);
               
                PL.Am.Form_Search frm = new PL.Am.Form_Search(sql);
                frm.MdiParent = this.MdiParent;
                frm.ShowDialog();

                //txt_id.Text = frm.dataGridView1.CurrentRow.Cells["رقم_المخزن"].Value.ToString();
                //txt_A_N.Text = frm.dataGridView1.CurrentRow.Cells["اسم_المخزن"].Value.ToString();
                //txt_by_user.Text = frm.dataGridView1.CurrentRow.Cells["py_user"].Value.ToString();
                //txt_E_N.Text = frm.dataGridView1.CurrentRow.Cells["الاسم_بالاجنبي"].Value.ToString();
                //txt_in_date.Text = frm.dataGridView1.CurrentRow.Cells["in_date"].Value.ToString();
                //txt_edit_user.Text = frm.dataGridView1.CurrentRow.Cells["edit_user"].Value.ToString();
                //txt_edit_date.Text = frm.dataGridView1.CurrentRow.Cells["edit_date"].Value.ToString();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                search_data();
                view_data();
            }
         if   (e.KeyCode==Keys.Enter)
            {
                view_data();
            }
        }

        private void search_data()
        {

            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم العملة");
            list_C_N.Add(100, "اسم العملة");
            list_C_N.Add(101, "الاسم الاجنبي");


            //   string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account";
            string sql = " SELECT currency_ID , currency_name_e , currency_name FROM AM_Currency ";
            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();
            txt_currenccy_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.Dispose();
        }
        private void view_data()
        {

            DataRow g_info;
            g_info = DB.select_Row("[AM_Currency]", "currency_ID", txt_currenccy_id.Text);

            if (g_info != null)
            {

                txt_currency_kye.Text = g_info["currency_Key"].ToString();
                txt_currency_A_N.Text = g_info["currency_name"].ToString();
                txt_E_N.Text = g_info["currency_name_e"].ToString();
                txt_curr_sname.Text = g_info["CURR_SNAME"].ToString();
                txt_part_name.Text = g_info["part_name"].ToString();
                txt_price_trans.Text = g_info["curr_exch_rate"].ToString();
                txt_in_date.Text = g_info["in_date"].ToString();
                txt_edit_date.Text = g_info["edit_date"].ToString();
                txt_edit_user.Text = g_info["edit_user"].ToString();
                txt_by_user.Text = g_info["by_user"].ToString();
                if (g_info["Used"] != DBNull.Value)
                    cbx_Usde.Checked = Convert.ToBoolean(g_info["Used"]);
                if (g_info["locally"] != DBNull.Value)
                    chbx_locally_currency.Checked = Convert.ToBoolean(g_info["locally"]);
                if (g_info["stor_currency"] != DBNull.Value)
                {
                    chbx_stor_currency.Checked = Convert.ToBoolean(g_info["stor_currency"]);
                }

            }
        }
        //private void view_dataq()
        //{
          
                
                //txt_currency_kye.Text = g_info"currency_Key"].ToString();
                //txt_currency_A_N.Text = g_info"currency_name"].ToString();
                //txt_E_N.Text = g_info"currency_name_e"].ToString();
                //txt_curr_sname.Text = g_info"CURR_SNAME"].ToString();
                //txt_part_name.Text = g_info"part_name"].ToString();
                //txt_price_trans.Text = g_info"price_tans"].ToString();
                //txt_in_date.Text = g_info"in_date"].ToString();
                //txt_edit_date.Text = g_info"edit_date"].ToString();
                //txt_edit_user.Text = g_info"edit_user"].ToString();
                //txt_by_user.Text = g_info"by_user"].ToString();
                //if (g_info"Used"] != DBNull.Value)
                //    cbx_Usde.Checked = Convert.ToBoolean(g_info"locally"]);
                //if (g_info"locally"] != DBNull.Value)
                //    chbx_locally_currency.Checked = Convert.ToBoolean(g_info"locally"]);
                //if (g_info"stor_currency"] != DBNull.Value)
                //{
                //    chbx_stor_currency.Checked = Convert.ToBoolean(g_info"stor_currency"]);
                //}
            
       // }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            proc = new BL.process_Class();
            txt_currenccy_id.Text = proc.max_num_in_Column("AM_Currency", "currency_ID").ToString();
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            Currency.p_AM_insert_Currency(Convert.ToInt32(txt_currenccy_id.Text), txt_currency_kye.Text, txt_currency_A_N.Text, txt_E_N.Text, txt_curr_sname.Text, txt_part_name.Text, chbx_locally_currency.Checked, chbx_stor_currency.Checked, cbx_Usde.Checked, txt_price_trans.Text);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Currency.p_AM_insert_Currency(Convert.ToInt32(txt_currenccy_id.Text), txt_currency_kye.Text, txt_currency_A_N.Text, txt_E_N.Text, txt_curr_sname.Text, txt_part_name.Text, chbx_locally_currency.Checked, chbx_stor_currency.Checked, cbx_Usde.Checked, txt_price_trans.Text);

        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search_data();
            view_data();


        }

        private void txt_price_trans_KeyPress(object sender, KeyPressEventArgs e)
        {

            char decimalseprator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != decimalseprator)
            {
                e.Handled = true;
            }
        }
    }
}
