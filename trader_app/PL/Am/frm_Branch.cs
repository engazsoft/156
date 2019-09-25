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
    public partial class frm_Branch : PL.add_form
    {
        BL.process_Class pro = new BL.process_Class();
        BL.AM_Branch_Class branch = new BL.AM_Branch_Class();
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        BL.User_class User = new BL.User_class();
        DAL.Databas_Class DB = new DAL.Databas_Class();
        public frm_Branch()
        {
            InitializeComponent();
          
        }
       
        private void frm_Branch_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_country, "select Country_ID,Country_A_N from AM_Country", "Country_A_N", "Country_ID");

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            txt_branch_id2.Text = txt_branch_id.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txt_Compony_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = pro.select_data_row("AM_Company", "Company_ID", Convert.ToInt32(txt_Compony_ID.Text));
                txt_Company_A_N.Text =  dt.Rows[0]["Company_A_N"].ToString();
                txt_Company_E_N.Text =  dt.Rows[0]["Company_E_N"].ToString();
                dt.Dispose();
            }
            catch (Exception)
            {

                txt_Company_A_N.Text = "";
                txt_Company_E_N.Text = "";
            }
         
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();

                //if (txt_branch_id.Text !=string.Empty)
                //{
                //    DataTable dt = pro.select_data_row("AM_Branches", "Branch_ID", Convert.ToInt32(txt_branch_id.Text));

            //    txt_Branch_A_N.Text = dt.Rows[0]["Branch_A_N"].ToString();
            //    txt_Branch_E_N.Text = dt.Rows[0]["Branch_E_N"].ToString();
            //    txt_phone.Text = dt.Rows[0]["Phone_num"].ToString();
            //    txt_Location_A.Text =  dt.Rows[0]["location"].ToString();
            //    txt_Fax_num.Text =  dt.Rows[0]["Fax_num"].ToString();
            //    txt_Mail_box.Text =  dt.Rows[0]["Mail_box"].ToString();
            //    txt_B_F_Tele.Text =  dt.Rows[0]["B_F_Tele"].ToString();
            //    txt_B_F_BOX.Text =  dt.Rows[0]["B_F_Box"].ToString();
            //    txt_B_F_Fax.Text =  dt.Rows[0]["B_F_Fax"].ToString();
            //    txt_A_Note.Text =  dt.Rows[0]["A_note"].ToString();
            //    txt_E_Note.Text =  dt.Rows[0]["E_note"].ToString();
            //    txt_Tax_num.Text =  dt.Rows[0]["Tax_num"].ToString();
            //    txt_year_id.Text =  dt.Rows[0]["year_id"].ToString();
            //    txt_Compony_ID.Text =  dt.Rows[0]["Company_ID"].ToString();
            //    pro.selec_value_com_from_db(cbx_country,  dt.Rows[0]["Country_ID"].ToString());


            //    txt_by_user.Text =  dt.Rows[0]["by_user"].ToString();
            //    txt_in_date.Text =  dt.Rows[0]["in_date"].ToString();
            //    txt_edit_user.Text =  dt.Rows[0]["edit_user"].ToString();
            //    txt_edit_date.Text =  dt.Rows[0]["edit_date"].ToString();

            //    pro.selec_value_com_from_db(cbx_gvr,  dt.Rows[0]["Gov_id"].ToString());

            //    pro.selec_value_com_from_db(cbx_dist,  dt.Rows[0]["Distinct_id"].ToString());

            //        pro.select_image_frim_db(pic_pranch_logo, dt, 0, 15);
            //    }




        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            branch.P_AM_insert_Branches(Convert.ToInt32(txt_branch_id.Text), txt_Branch_A_N.Text, txt_Branch_E_N.Text, txt_phone.Text, txt_Location_A.Text, 
            txt_Mail_box.Text,  txt_Fax_num.Text, txt_B_F_Tele.Text, txt_B_F_Fax.Text,txt_Mail_box.Text,txt_A_Note.Text, txt_E_Note.Text, txt_Tax_num.Text, txt_year_id.Text,Convert.ToInt32(txt_Compony_ID.Text),pro.Insert_image_to_db(pic_pranch_logo),Convert.ToInt32( pro.Insert_com_to_db(cbx_country)),Convert.ToInt32( pro.Insert_com_to_db(cbx_gvr)),Convert.ToInt32( pro.Insert_com_to_db(cbx_dist)));

                
        }

        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }

        private void pic_pranch_logo_Click(object sender, EventArgs e)
        {

        }

        private void cbx_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbx_dist.DataSource = null;
                   DB.LoadCombo(cbx_gvr, "select Gov_id,A_N from AM_Governorates  where Country_ID=" + cbx_country.SelectedValue.ToString(), "A_N", "Gov_id");
            }
           


            catch
            {

            } 
      
        }

        private void cbx_gvr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            clear();
            tabControl1.Enabled = true;
        }
        private void clear()
        {
            txt_branch_id.Text = txt_Branch_A_N.Text = txt_Branch_E_N.Text = txt_phone.Text = txt_Location_A.Text =
              txt_Mail_box.Text = txt_Fax_num.Text = txt_B_F_Tele.Text = txt_B_F_Fax.Text = txt_Mail_box.Text = txt_A_Note.Text = txt_E_Note.Text = txt_Tax_num.Text = txt_year_id.Text = txt_Compony_ID.Text = cbx_country.Text = cbx_gvr.Text = cbx_dist.Text = "";
            pic_pranch_logo.Image = null;
            txt_branch_id.Enabled = true;
            txt_Compony_ID.Enabled = true;
            txt_edit_date.Clear();
        }
        private void view_data()
        {

            DataRow g_info;
            g_info = DB.select_Row("AM_Branches", "Branch_ID",txt_branch_id.Text);

            if (g_info != null)
            {



                txt_Branch_A_N.Text = g_info["Branch_A_N"].ToString();
                txt_Branch_E_N.Text = g_info["Branch_E_N"].ToString();
                txt_phone.Text = g_info["Phone_num"].ToString();
                txt_Location_A.Text = g_info["location"].ToString();
                txt_Fax_num.Text = g_info["Fax_num"].ToString();
                txt_Mail_box.Text = g_info["Mail_box"].ToString();
                txt_B_F_Tele.Text = g_info["B_F_Tele"].ToString();
                txt_B_F_BOX.Text = g_info["B_F_Box"].ToString();
                txt_B_F_Fax.Text = g_info["B_F_Fax"].ToString();
                txt_A_Note.Text = g_info["A_note"].ToString();
                txt_E_Note.Text = g_info["E_note"].ToString();
                txt_Tax_num.Text = g_info["Tax_num"].ToString();
                txt_year_id.Text = g_info["year_id"].ToString();
                txt_Compony_ID.Text = g_info["Company_ID"].ToString();
                pro.selec_value_com_from_db(cbx_country, g_info["Country_ID"].ToString());


                txt_by_user.Text = g_info["by_user"].ToString();
                txt_in_date.Text = g_info["in_date"].ToString();
                txt_edit_user.Text = g_info["edit_user"].ToString();
                txt_edit_date.Text = g_info["edit_date"].ToString();

                pro.selec_value_com_from_db(cbx_gvr, g_info["Gov_id"].ToString());

                pro.selec_value_com_from_db(cbx_dist, g_info["Distinct_id"].ToString());
                if (txt_branch_id.Text != string.Empty)
                {
                    DataTable dt = pro.select_data_row("AM_Branches", "Branch_ID", Convert.ToInt32(txt_branch_id.Text));
                    pro.select_image_frim_db(pic_pranch_logo, dt, 0, 15);

                }







                //if (dt.Rows[0]["edit_user"].ToString() != string.Empty)
                //    txt_edit_user.Text = "" + user.get_User(dt.Rows[0]["edit_user"].ToString());
                //if (dt.Rows[0]["py_user"].ToString() != string.Empty)
                //    txt_by_user.Text = "" + user.get_User(dt.Rows[0]["py_user"].ToString());
            }
        }

        private void cbx_gvr_DropDown(object sender, EventArgs e)
        {
            
        }

        private void cbx_dist_SelectedIndexChanged(object sender, EventArgs e)
        {

              
            
          
        }

        private void cbx_dist_DropDown(object sender, EventArgs e)
        {

            try
            {
                DB.LoadCombo(cbx_dist, "select Distinct_id,A_N from AM_Districts  where Gov_ID=" + cbx_gvr.SelectedValue.ToString(), "A_N", "Distinct_id");
            }
            catch (Exception)
            {

                return;
            }
        }

        private void cbx_gvr_DropDown_1(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_dist, "select Distinct_id,A_N from AM_Districts  where Gov_ID=" + cbx_gvr.SelectedValue.ToString(), "A_N", "Distinct_id");
        }

        private void cbx_gvr_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbx_dist.DataSource = null;
            try
            {
                DB.LoadCombo(cbx_dist, "select Distinct_id,A_N from AM_Districts  where Gov_ID=" + cbx_gvr.SelectedValue.ToString(), "A_N", "Distinct_id");
            }
            catch 
            {

                return;
            }
        }

        private void cbx_gvr_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            DB.LoadCombo(cbx_dist, "select Distinct_id,A_N from AM_Districts  where Gov_ID=" + cbx_gvr.SelectedValue.ToString(), "A_N", "Distinct_id");

        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search_data();
            view_data();
          //  DB.LoadCombo(cbx_dist, "select Distinct_id,District_A_N from AM_Districts  where Gov_ID=" + cbx_gvr.SelectedValue.ToString(), "District_A_N", "Distinct_id");
        }
        private void search_data()
        {

            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الفرع");
            list_C_N.Add(100, "اسم الفرع");
            list_C_N.Add(101, "الاسم الاجنبي");


               //string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account";
            
            string sql = "SELECT  [Branch_ID],[Branch_A_N] ,[Branch_E_N] FROM [AM_Branches]";
            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();
            txt_branch_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
           frm.Dispose();
        }
        private void cbx_gvr_DropDown_2(object sender, EventArgs e)
        {
            //try
            //{
            //    pro.LoadCombo(cbx_dist, "select Distinct_id,District_A_N from AM_Districts  where Gov_ID=" + cbx_gvr.SelectedValue.ToString(), "District_A_N", "Distinct_id");
            //}
            //catch (Exception)
            //{

            //    return;
            //}
            
        }

        private void txt_branch_id2_TextChanged(object sender, EventArgs e)
        {

        }
    
        private void btn_show_user_branch_Click(object sender, EventArgs e)
        {
            DAL = new trader_app.DAL.DataAccessLayer();
            dgv_pranch_user.DataSource = null;
            dgv_pranch_user.DataSource = DAL.FindDataSet("select A_U.[U_ID] as'رقم_المستخدم',A_U.[U_A_NAME] as 'اسم_المستخدم',B_U.Adds as 'تعديل_و_اضافة',B_U.Show as'عرض' from Ath_Users A_U left join Ath_Branches_Users B_U on A_U.[U_ID]=B_U.User_ID and B_U.Branch_ID=" + txt_branch_id2.Text);
            DAL = null;
            
        }

        //public static long? getLongFromDB(object value)
        //{
        //    if (value == DBNull.Value) return null;
        //    return Convert.ToBoolean(value);
        //}
        private void button1_Click(object sender, EventArgs e)
        {
           

            foreach (DataGridViewRow row in dgv_pranch_user.Rows)
            {

                if (row.Cells["تعديل_و_اضافة"].Value ==DBNull.Value || row.Cells["عرض"].Value ==DBNull.Value )
                {
                    row.Cells["تعديل_و_اضافة"].Value = false;
                    row.Cells["عرض"].Value = false;

                }
                User.P_Ath_insert_branch_User(Convert.ToInt32(txt_branch_id2.Text),Convert.ToInt32(row.Cells["رقم_المستخدم"].Value),Convert.ToBoolean( row.Cells["عرض"].Value),Convert.ToBoolean( row.Cells["تعديل_و_اضافة"].Value));
            }
        }

        private void btn_save_change_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in dgv_pranch_user.Rows)
            {

                if (row.Cells["تعديل_و_اضافة"].Value == DBNull.Value || row.Cells["عرض"].Value == DBNull.Value)
                {
                    row.Cells["تعديل_و_اضافة"].Value = false;
                    row.Cells["عرض"].Value = false;

                }
                User.P_Ath_insert_branch_User(Convert.ToInt32(txt_branch_id2.Text), Convert.ToInt32(row.Cells["رقم_المستخدم"].Value), Convert.ToBoolean(row.Cells["عرض"].Value), Convert.ToBoolean(row.Cells["تعديل_و_اضافة"].Value));
            }
        }

        private void txt_branch_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                search_data();
                view_data();
                txt_branch_id.Focus();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            branch.P_AM_insert_Branches(Convert.ToInt32(txt_branch_id.Text), txt_Branch_A_N.Text, txt_Branch_E_N.Text, txt_phone.Text, txt_Location_A.Text,
            txt_Mail_box.Text, txt_Fax_num.Text, txt_B_F_Tele.Text, txt_B_F_Fax.Text, txt_Mail_box.Text, txt_A_Note.Text, txt_E_Note.Text, txt_Tax_num.Text, txt_year_id.Text, Convert.ToInt32(txt_Compony_ID.Text), pro.Insert_image_to_db(pic_pranch_logo), Convert.ToInt32(pro.Insert_com_to_db(cbx_country)), Convert.ToInt32(pro.Insert_com_to_db(cbx_gvr)), Convert.ToInt32(pro.Insert_com_to_db(cbx_dist)));


        }

        private void dgv_pranch_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
 