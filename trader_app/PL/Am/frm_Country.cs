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
    public partial class frm_Country : add_form
    {
        BL.AM_Country_Class Countrys = new BL.AM_Country_Class();
        BL.AM_Currency_Class Currency = new BL.AM_Currency_Class();
        DAL.Databas_Class DB = new DAL.Databas_Class();
        BL.User_class user = new BL.User_class();

        //BL.Process_Class process = new BL.Process_Class();
        DataTable dt;
        public frm_Country()
        {
            InitializeComponent();
        }

        private void Form_Country_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbx_ID_DropDown(object sender, EventArgs e)
        {
            cbx_ID.DataSource = Countrys.P_AM_Get_Country();
            cbx_ID.DisplayMember = "Country_ID";
            cbx_ID.ValueMember = "Country_ID";

        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
        
            search_data();
            view_data();
            cbx_currency.Enabled = true;
            btn_edit.Enabled = true;

            //string sql = " SELECT Country_ID as الرقم ,Country_A_N as الاسم,Country_E_N as الاسم_الاجنبي FROM [dbo].AM_Country ";
            //PL.Am.Form_Search frm = new Form_Search(sql);
            //frm.MdiParent = this.MdiParent;

            //frm.ShowDialog();



        }
        private void view_data()
        {

            DataRow g_info;

            g_info = DB.select_Row("AM_Country", "Country_ID", cbx_ID.Text);
            if (g_info != null)
            {
               

                txt_A_N.Text = g_info["Country_A_N"].ToString();
                txt_E_N.Text = g_info["Country_E_N"].ToString();
             
            
                txt_in_date.Text = g_info["in_date"].ToString();
                txt_edit_date.Text = g_info["edit_date"].ToString();
                txt_by_user.Text = g_info["py_user"].ToString();
                txt_edit_user.Text = g_info["edit_user"].ToString();
               
                if(g_info["currency_ID"].ToString() != string.Empty)

                {
                    cbx_currency.Text = g_info["currency_ID"].ToString();
                    DataRow r = DB.select_Row("AM_Currency", "currency_ID", cbx_currency.Text);
                    LB_Courncy_name.Text = r["currency_name"].ToString();
                }
                else
                {
                    LB_Courncy_name.Text = "";
                    cbx_currency.Text="";
                }
                            


                //if (g_info["edit_user"].ToString() != string.Empty)
                //    txt_edit_user.Text = "" + user.get_User(g_info["edit_user"].ToString());
                //if (g_info["py_user"].ToString() != string.Empty)
                //    txt_by_user.Text = "" + user.get_User(g_info["py_user"].ToString());
            }
        }
        private void search_data()
        {

            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الدولة");
            list_C_N.Add(100, "اسم الدولة");
            list_C_N.Add(101, "الاسم الاجنبي");


            //   string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account";
            string sql = "SELECT  Country_ID,Country_A_N,Country_E_N from [AM_Country]";
            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();
            cbx_ID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.Dispose();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_A_N.ReadOnly = txt_E_N.ReadOnly = false;
            txt_A_N.Clear();
            txt_edit_date.Clear();
            txt_edit_user.Clear();
            txt_E_N.Clear();
            txt_in_date.Clear();
            txt_by_user.Clear();
            cbx_ID.Text = null;
            cbx_currency.Text = null;
            LB_Courncy_name.Text = "";
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_A_N.ReadOnly = txt_E_N.ReadOnly = false;

            Countrys.P_AM_insert_Country(Convert.ToInt32(cbx_ID.Text), txt_A_N.Text, txt_E_N.Text, 0, Convert.ToInt32(cbx_currency.SelectedValue.ToString()));
            txt_A_N.ReadOnly = txt_E_N.ReadOnly = true;
            cbx_currency.Enabled = false;
            cbx_currency.BackColor = Color.Wheat;

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
           
            
            //if (cbx_ID.Text.Length>0)
            //{

                        
          //      try
          //      {
          //          DataRow[] r = Countrys.P_AM_Get_Country().Select("Country_ID= " + cbx_ID.Text.ToString() + "");
          //          if (r[0]["currency_ID"].ToString() != null)
          //              btn_dele.Enabled = true;
          //          txt_A_N.Text = r[0]["Country_A_N"].ToString();
          //          txt_E_N.Text = r[0]["Country_E_N"].ToString();
          //          if (r[0]["currency_ID"].ToString().Length > 0)
          //              cbx_currency.SelectedValue = Convert.ToInt32(r[0]["currency_ID"]);
          //          txt_by_user.Text = r[0]["py_user"].ToString();
          //          txt_in_date.Text = r[0]["in_date"].ToString();
          //          txt_edit_user.Text = r[0]["py_user"].ToString();
          //          txt_edit_date.Text = r[0]["edit_date"].ToString();
          //      }
          //catch
          //      {
                    
          //      }
               
              
          //  }
        }

      
        private void cbx_currency_DropDown(object sender, EventArgs e)
        {
            cbx_currency.DataSource = Currency.P_AM_get_Currency();
            cbx_currency.DisplayMember = "currency_name";
            cbx_currency.ValueMember = "currency_ID";
            cbx_currency.SelectedIndex = -1;

        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            Countrys.P_AM_insert_Country(Convert.ToInt32(cbx_ID.Text), txt_A_N.Text, txt_E_N.Text, 0, Convert.ToInt32(cbx_currency.SelectedValue.ToString()));
            txt_A_N.ReadOnly = txt_E_N.ReadOnly = true;
            cbx_currency.Enabled = false;
            cbx_currency.BackColor = Color.Wheat;
        }

        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
          ////  if(MessageBox.Show("هل انت متاكد من حذف السجل الم"))
          //  string sql = "DELETE FROM [dbo].[AM_Country] WHERE Country_ID=" + cbx_ID.SelectedValue.ToString();
          //  dal.Executecommade(sql);
          //  cbx_ID.DataSource = Countrys.P_AM_Get_Country();
          //  cbx_ID.DisplayMember = "Country_ID";
          //  cbx_ID.ValueMember = "Country_ID";

        }

        private void cbx_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F9 )
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الدولة");
                list_C_N.Add(100, "اسم الدولة");
                list_C_N.Add(101, "الاسم الاجنبي");


                //   string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account";
                string sql = "SELECT  Country_ID,Country_A_N,Country_E_N from [AM_Country]";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
                frm.ShowDialog();
                cbx_ID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbx_currency.Enabled = true;
                frm.Dispose();
                view_data();
            }
        }

        private void cbx_ID_Enter(object sender, EventArgs e)
        {
           
            view_data();
        }

        private void cbx_ID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                view_data();
        }

        private void cbx_ID_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
