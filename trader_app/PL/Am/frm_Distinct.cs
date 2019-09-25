using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trader_app.PL.Am
{
    public partial class frm_Distinct : add_form
    {
        BL.AM_Distinct_Class Distinct = new BL.AM_Distinct_Class();
        BL.process_Class proc = new BL.process_Class();
        DAL.Databas_Class DB = new DAL.Databas_Class();
        public frm_Distinct()
        {
            InitializeComponent();
        }

        private void frm_Distinct_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_Country, "select Country_ID,Country_A_N from AM_Country", "Country_A_N", "Country_ID");
            txt_id.ReadOnly = false;
        }
        
        private void btn_seve_Click(object sender, EventArgs e)
        {
          
            
                Distinct.P_AM_insert_Distinct(Convert.ToInt32(txt_id.Text), Convert.ToInt32(cbx_Gov.SelectedValue.ToString()), txt_A_N.Text, txt_E_N.Text);
            
           
        }

        private void search_data()
        {

            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم المدينة");
            list_C_N.Add(100, "اسم المدينة");
            list_C_N.Add(101, "الاسم الاجنبي");


            //   string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account";
            string sql = " SELECT  Distinct_id , A_N , E_N from AM_Districts ";
            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();
             txt_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.Dispose();
            view_data();
        }
        private void view_data()
        {

            DataRow g_info;
            g_info = DB.select_Row("[AM_Districts]", "Distinct_id", txt_id.Text);

            if (g_info != null)
            {
                txt_id.Text = g_info["Distinct_id"].ToString();
                txt_A_N.Text = g_info["A_N"].ToString();
                txt_E_N.Text = g_info["E_N"].ToString();
                cbx_Gov.SelectedValue = g_info["Gov_id"].ToString();
                cbx_Country.SelectedValue = DB.select_Row("AM_Governorates", "Gov_id", g_info["Gov_id"].ToString())["Country_ID"].ToString();
                txt_edit_user.Text = g_info["edit_user"].ToString();
                txt_by_user.Text = g_info["by_user"].ToString();
                txt_edit_date.Text = g_info["edit_date"].ToString();
                txt_in_date.Text = g_info["in_date"].ToString();


            }
        }
        
        //private void view_data()
        //{

        //    DB = new DAL.Databas_Class();

        //    DataRow GOV_Info = DB.select_Row(this.Tag.ToString(), txt_id.Tag.ToString(), txt_id.Text);
        //    if (GOV_Info != null)
        //    {


        //        txt_A_N.Text = GOV_Info["A_N"].ToString();
        //        txt_E_N.Text = GOV_Info["E_N"].ToString();
        //        cbx_Country.SelectedValue = GOV_Info["Gov_id"].ToString();
        //        cbx_Country.SelectedValue = DB.select_Row("AM_Governorates", "Gov_id", GOV_Info["Gov_id"].ToString())["Country_ID"].ToString();
        //        txt_edit_user.Text = GOV_Info["edit_user"].ToString();
        //        txt_by_user.Text = GOV_Info["by_user"].ToString();
        //        txt_edit_date.Text = GOV_Info["edit_date"].ToString();
        //        txt_in_date.Text = GOV_Info["in_date"].ToString();



        //    }
        //}
        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text = proc.max_num_in_Column(this.Tag.ToString(), txt_id.Tag.ToString());

            cbx_Gov.Text = cbx_Country.Text = " ";
        }

        private void cbx_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_Gov, "select Gov_id,A_N from AM_Governorates where Country_ID=" + cbx_Country.SelectedValue.ToString(), "A_N", "Gov_id");
            cbx_Gov.Enabled = true;
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search_data();
            view_data();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
            cbx_Gov.Enabled = false;
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {
                e.Handled = true;
            }
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Distinct.P_AM_insert_Distinct(Convert.ToInt32(txt_id.Text), Convert.ToInt32(cbx_Gov.SelectedValue.ToString()), txt_A_N.Text, txt_E_N.Text);
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                search_data();
                view_data();
            }
            if (e.KeyCode == Keys.Enter)
            {
                view_data();
                frm_View(this);
            }
        }
    }
}
