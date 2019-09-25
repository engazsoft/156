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
   
    public partial class Form_product_type : PL.add_form
    {
        BL.AM_Product_type AM = new BL.AM_Product_type();
        DAL.Databas_Class DB = new DAL.Databas_Class();
        BL.User_class user = new BL.User_class();
        

        DataTable dt;
        public Form_product_type()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_product_type_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = AM.P_AM_Get_Product_type(" ");
            
                cbx_product_type_num.DataSource = dt;
                cbx_product_type_num.DisplayMember = "Type_ID";
                cbx_product_type_num.ValueMember = "Type_ID";
               
     
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_edit_date.Text = txt_edit_user.Text = txt_in_date.Text = txt_by_user.Text=txt_E_N.Text=txt_A_N.Text=cbx_product_type_num.Text = "";
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            
            AM.p_AM_insert_Product_type(Convert.ToInt32( cbx_product_type_num.Text.ToString()), txt_A_N.Text, txt_E_N.Text);
        }

        private void cbx_product_type_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_view.Enabled = false;
            if (cbx_product_type_num.SelectedValue != null)
            {

                btn_view.Enabled = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_data();
           //dt = new DataTable();
           // dt = AM.P_AM_Get_Product_type(" ");
           // if (cbx_product_type_num.SelectedValue!=null)
           // {
               
       //    DataRow[] r = dt.Select("Type_ID = " + cbx_product_type_num.SelectedValue.ToString() + "");
     

           //     txt_A_N.Text = r[0]["A_N"].ToString();
           //     txt_E_N.Text = r[0]["E_N"].ToString();
           //     txt_by_user.Text = r[0]["py_user"].ToString();
           //    txt_in_date.Text = r[0]["in_date"].ToString();
           //     txt_edit_user.Text = r[0]["py_user"].ToString();
           //    txt_edit_date.Text = r[0]["edit_date"].ToString();
           // }
            
           

        }
        private void search_data()
        {

            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم النوع");
            list_C_N.Add(100, "اسم النوع ");
            list_C_N.Add(101, "الاسم الاجنبي ");


            //   string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account";
            string sql = "SELECT Type_ID ,A_N,E_N  FROM [dbo].AM_Product_Type ";
            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();
            frm.Dispose();
        }
        private void btn_serch_Click(object sender, EventArgs e)
        {

            view_data();

            search_data();
            //  s = lb_full_accout_num.Text;
         

            //string sql = "SELECT Type_ID ,A_N,E_N  FROM [dbo].AM_Product_Type ";
            //PL.Am.Form_Search frm = new Form_Search(sql);
            //frm.MdiParent = this.MdiParent;
            //frm.dataGridView1.DataSource = dt;
            //frm.dataGridView1.Columns[6].Visible = false;
            //frm.dataGridView1.Columns[5].Visible = false;
            //frm.dataGridView1.Columns[4].Visible = false;
            //frm.dataGridView1.Columns[3].Visible = false;
            //frm.ShowDialog();
            
            //cbx_product_type_num.Text = frm.dataGridView1.CurrentRow.Cells["رقم_النوع"].Value.ToString();
            //txt_A_N.Text = frm.dataGridView1.CurrentRow.Cells["اسم_النوع"].Value.ToString();
            //txt_by_user.Text = frm.dataGridView1.CurrentRow.Cells["py_user"].Value.ToString();
            //txt_E_N.Text = frm.dataGridView1.CurrentRow.Cells["الاسم_بالاجنبي"].Value.ToString();
            //txt_in_date.Text = frm.dataGridView1.CurrentRow.Cells["in_date"].Value.ToString();
            //txt_edit_user.Text = frm.dataGridView1.CurrentRow.Cells["edit_user"].Value.ToString();
            //txt_edit_date.Text= frm.dataGridView1.CurrentRow.Cells["edit_date"].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            AM.p_AM_insert_Product_type(Convert.ToInt32(cbx_product_type_num.Text.ToString()), txt_A_N.Text, txt_E_N.Text);
        }
        private void view_data()
        {

            DataRow g_info;

            g_info = DB.select_Row("AM_Product_Type ", "Type_ID", cbx_product_type_num.Text);
            if (g_info != null)
            {


                txt_A_N.Text = g_info["A_N"].ToString();
                txt_E_N.Text = g_info["E_N"].ToString();
                txt_in_date.Text = g_info["in_date"].ToString();
                txt_edit_date.Text = g_info["edit_date"].ToString();
                txt_by_user.Text = g_info["py_user"].ToString();
                txt_edit_user.Text = g_info["edit_user"].ToString();
                //if (g_info["edit_user"].ToString() != string.Empty)
                //    txt_edit_user.Text = "" + user.get_User(g_info["edit_user"].ToString());
                //if (g_info["py_user"].ToString() != string.Empty)
                //    txt_by_user.Text = "" + user.get_User(g_info["py_user"].ToString());
            }

        }
        private void cbx_product_type_num_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 )
            {
                
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم النوع");
                list_C_N.Add(100, "اسم النوع ");
                list_C_N.Add(101, "الاسم الاجنبي ");


                //   string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account";
                string sql = "SELECT Type_ID ,A_N,E_N  FROM [dbo].AM_Product_Type ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
             
                frm.ShowDialog();
                cbx_product_type_num.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.Dispose();
           
           
                view_data();
            }
        }
    }
}
