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
    public partial class Frm_Campny : PL.add_form
    {
        BL.process_Class pro = new BL.process_Class();
        BL.AM_Company_Class company = new BL.AM_Company_Class();
        DataTable dt;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        public Frm_Campny()
        {
            InitializeComponent();
        }

        private void Frm_Campny_Load(object sender, EventArgs e)
        {
        //    DB.LoadCombo(cbx_country, "select Country_ID,Country_A_N from AM_Country", "Country_A_N", "Country_ID");
        //    txt_id.ReadOnly = false;
        //    dt = pro.select_data_row("AM_Company", "Company_ID", 1);
        //    txt_id.Text = dt.Rows[0]["Company_ID"].ToString();
        //    txt_A_N.Text = dt.Rows[0]["Company_A_N"].ToString();
        //    txt_E_N.Text = dt.Rows[0]["Company_E_N"].ToString();
        //    txt_A.Text = dt.Rows[0]["A_N"].ToString();
        //    txt_E.Text = dt.Rows[0]["Note"].ToString();
        //    txt_grop_ID.Text = dt.Rows[0]["Group_ID"].ToString();
        //    txt_edit_date.Text = dt.Rows[0]["edit_date"].ToString();
        //    txt_in_date.Text = dt.Rows[0]["in_date"].ToString();
        //    txt_by_user.Text = dt.Rows[0]["py_user"].ToString();
        //    txt_edit_user.Text = dt.Rows[0]["edit_user"].ToString();
        //    pro.select_image_frim_db(pic_log, dt, 0, 8);
        //    pro.selec_value_com_from_db(cbx_country,dt.Rows[0]["Country_ID"].ToString());
        }
        private void search_data()
        {

            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الشركة");
            list_C_N.Add(100, "اسم الشركة");
            list_C_N.Add(101, "الاسم الاجنبي");


            //string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account";

            string sql = "SELECT [Company_ID],[Company_A_N],[Company_E_N] FROM [AM_Company]";
            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();
            txt_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.Dispose();
        }
        private void view_data()
        {

            DataRow g_info;
            g_info = DB.select_Row("AM_Company", "Company_ID", txt_id.Text);

            if (g_info != null)
            {
                txt_A_N.Text = g_info["Company_A_N"].ToString();
                txt_E_N.Text = g_info["Company_E_N"].ToString();
                txt_A.Text = g_info["A_N"].ToString();
                txt_E.Text = g_info["Note"].ToString();
                txt_grop_ID.Text = g_info["Group_ID"].ToString();
                txt_edit_date.Text = g_info["edit_date"].ToString();
                txt_in_date.Text = g_info["in_date"].ToString();
                txt_by_user.Text = g_info["py_user"].ToString();
                txt_edit_user.Text = g_info["edit_user"].ToString();
                if (txt_id.Text!=string.Empty)
                {
                    dt = pro.select_data_row("AM_Company", "Company_ID", Convert.ToInt32(txt_id.Text));
                    pro.select_image_frim_db(pic_log, dt, 0, 8);
                }
               
                pro.selec_value_com_from_db(cbx_country, g_info["Country_ID"].ToString());
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();

            //dt = pro.select_data_row("AM_Company", "Company_ID", Convert.ToInt32(txt_id.Text));
            //txt_A_N.Text = dt.Rows[0]["Company_A_N"].ToString();
            //txt_E_N.Text = dt.Rows[0]["Company_E_N"].ToString();
            //txt_A.Text = dt.Rows[0]["A_N"].ToString();
            //txt_E.Text = dt.Rows[0]["Note"].ToString();
            //txt_grop_ID.Text = dt.Rows[0]["Group_ID"].ToString();
            //txt_edit_date.Text = dt.Rows[0]["edit_date"].ToString();
            //txt_in_date.Text = dt.Rows[0]["in_date"].ToString();
            //txt_by_user.Text = dt.Rows[0]["py_user"].ToString();
            //txt_edit_user.Text = dt.Rows[0]["edit_user"].ToString();
            //pro.select_image_frim_db(pic_log, dt, 0, 8);
            //pro.selec_value_com_from_db(cbx_country, dt.Rows[0]["Country_ID"].ToString());

        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            company.p_AM_insert_Company(Convert.ToInt32(txt_id.Text), txt_A_N.Text, txt_E_N.Text, txt_A.Text, txt_E.Text, txt_note.Text, Convert.ToInt32(txt_grop_ID.Text), Convert.ToInt32(cbx_country.SelectedValue.ToString()), pro.Insert_image_to_db(pic_log));
        }

        private void pic_log_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files|*.jpg;*.png";
            if (of.ShowDialog() == DialogResult.OK)
            {

                pic_log.Image = Image.FromFile(of.FileName);
                
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            company.p_AM_insert_Company(Convert.ToInt32(txt_id.Text), txt_A_N.Text, txt_E_N.Text, txt_A.Text, txt_E.Text, txt_note.Text, Convert.ToInt32(txt_grop_ID.Text), Convert.ToInt32(cbx_country.SelectedValue.ToString()), pro.Insert_image_to_db(pic_log));

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            pic_log.Image = null;
            cbx_country.SelectedIndex = -1;
            txt_id.Focus();
            txt_id.Text = txt_A_N.Text = txt_E_N.Text = txt_A.Text = txt_E.Text = txt_note.Text = txt_grop_ID.Text = txt_in_date.Text=txt_edit_date.Text="";
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search_data();
            view_data();
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if(txt_id.Text!=string.Empty)
            {
                if (e.KeyCode == Keys.F9)
                {
                    search_data();
                    view_data();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    view_data();
                }
            }
           
        }
    }
}
