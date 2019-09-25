using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using trader_app.BL;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace trader_app.PL.AC
{
    public partial class Frm_CASH_AT_BANK : PL.add_form
    {
        BL.process_Class proc = new BL.process_Class();
        BL.AC_CASH_AT_BANK BANk = new BL.AC_CASH_AT_BANK();
        Account_Class Account = new Account_Class();
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        BL.User_class User = new BL.User_class();
        DAL.DataAccessLayer dal;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        DataTable dt;
        public Frm_CASH_AT_BANK()
        {
            InitializeComponent();
        }

        private void Frm_CASH_AT_BANK_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_CONN_BRN_NO, "select Branch_ID, Branch_A_N from AM_Branches", "Branch_A_N", "Branch_ID");
            cbx_CONN_BRN_NO.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_A_CODE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_A_CODE_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_CONN_BRN_NO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CASH_NO_id_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txt_REC_LETTER_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            txt_AC_Bank_Name.Text = txt_BANK_ACC.Text = txt_BANK_NAME_A.Text = txt_BANK_NAME_E.Text = txt_BANK_NO_id.Text = txt_BANK_SR.Text
                = txt_by_user.Text = txt_B_ADDRESS.Text = txt_B_BOX.Text = txt_B_E_MAIL.Text = txt_B_FAX.Text = txt_B_TEL.Text = txt_B_WEB_SITE.Text
                = txt_edit_date.Text = txt_edit_user.Text = txt_INACTIVE_RES.Text = txt_in_date.Text = txt_PAY_LETTER.Text = txt_REC_LETTER.Text = " ";
            chbx_INACTIVE.CheckState = CheckState.Unchecked;
            chbx_INACTIVE.CheckState = CheckState.Unchecked;
            pic_BANK_IMG.Image = null;
            dgv_BANK_curr.DataSource = null;
            txt_A_CODE.Text = "";
        }
        private void view_data()
        {
            DB = new DAL.Databas_Class();
            DataRow Bank_Info = DB.select_Row("AC_CASH_AT_BANK", "BANK_NO", txt_BANK_NO_id.Text);
            if (Bank_Info != null)
            {

              txt_BANK_NO_id.Text = Bank_Info["BANK_NO"].ToString();
               txt_BANK_NAME_A.Text = Bank_Info["BANK_NAME_A"].ToString();
               txt_BANK_NAME_E.Text = Bank_Info["BANK_NAME_E"].ToString();
                txt_A_CODE.Text = Bank_Info["A_CODE"].ToString();
                txt_BANK_SR.Text = Bank_Info["BANK_SR"].ToString();
                txt_AC_Bank_Name.Text = Bank_Info["AC_Bank_Name"].ToString();
                txt_BANK_ACC.Text = Bank_Info["BANK_ACC"].ToString();
               cbx_CONN_BRN_NO.SelectedValue= Bank_Info["CONN_BRN_NO"].ToString();
                txt_B_TEL.Text= Bank_Info["B_TEL"].ToString();
                txt_B_FAX.Text = Bank_Info["B_FAX"].ToString();
                txt_B_BOX.Text = Bank_Info["B_BOX"].ToString();
                txt_B_ADDRESS.Text = Bank_Info["B_ADDRESS"].ToString();
                txt_B_E_MAIL.Text = Bank_Info["B_E_MAIL"].ToString();
                txt_B_WEB_SITE.Text= Bank_Info["B_WEB_SITE"].ToString();
             
            
                txt_INACTIVE_RES.Text = Bank_Info["INACTIVE_RES"].ToString();
                cbx_CONN_BRN_NO.SelectedValue = Bank_Info["CONN_BRN_NO"].ToString();
                dtb_INACTIVE_DATE.Text = Bank_Info["INACTIVE_DATE"].ToString();
                txt_PAY_LETTER.Text = Bank_Info["PAY_LETTER"].ToString();
                txt_REC_LETTER.Text = Bank_Info["REC_LETTER"].ToString();
                if (Bank_Info["INACTIVE"] != DBNull.Value)
                    chbx_INACTIVE.Checked = Convert.ToBoolean(Bank_Info["INACTIVE"]);
                if (Bank_Info["MEDIATOR"] != DBNull.Value)
                    chbx_MEDIATOR.Checked = Convert.ToBoolean(Bank_Info["MEDIATOR"]);

                if (txt_BANK_NO_id.Text != string.Empty)
                {

                    DataTable dt1 = proc.select_data_row("AC_CASH_AT_BANK", "BANK_NO", Convert.ToInt32(txt_BANK_NO_id.Text));

                    proc.select_image_frim_db(pic_BANK_IMG, dt1, 0, 18);
                }


                txt_in_date.Text = Bank_Info["in_date"].ToString();
                txt_edit_date.Text = Bank_Info["edit_date"].ToString();
                txt_edit_user.Text = Bank_Info["edit_user"].ToString();
                txt_by_user.Text = Bank_Info["by_user"].ToString();
                dgv_BANK_curr.DataSource = null;

            
            if (Bank_Info["A_CODE"].ToString() != DBNull.Value.ToString())
                {

                dal = new DAL.DataAccessLayer();
                dgv_BANK_curr.DataSource = dal.FindDataSet("select AM.currency_Key as الرمز,currency_name as الاسم,Ac.Used as استخدام from AC_Account_currency  AC right join AM_Currency AM  on ac.currency_Key=Am.currency_Key and Account_ID=N'" +txt_A_CODE.Text+ "' where  AM.Used='1' ");
                dgv_BANK_curr.Columns[0].Width = 30;
                dgv_BANK_curr.Columns[0].Name = "الرمز";
                dgv_BANK_curr.Columns[1].Width = 70;
                dgv_BANK_curr.Columns[1].Name = "الاسم";
                dgv_BANK_curr.Columns[2].Width = 60;
                dgv_BANK_curr.Columns[2].Name = "استخدام";
             
                }

                btn_edit.Enabled = true;
            }
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            BANk.P_AC_insert_CASH_AT_BANK(Convert.ToInt32(txt_BANK_NO_id.Text), txt_BANK_NAME_A.Text, txt_BANK_NAME_E.Text,
                txt_A_CODE.Text, txt_BANK_SR.Text, txt_AC_Bank_Name.Text, txt_BANK_ACC.Text, Convert.ToInt32(proc.Insert_com_to_db(cbx_CONN_BRN_NO)),
                txt_B_TEL.Text, txt_B_FAX.Text, txt_B_BOX.Text, txt_B_ADDRESS.Text, txt_B_E_MAIL.Text, txt_B_WEB_SITE.Text,
                chbx_MEDIATOR.Checked, chbx_INACTIVE.Checked, proc.Insert_DTB_to_db(dtb_INACTIVE_DATE), txt_INACTIVE_RES.Text,
                proc.Insert_image_to_db(pic_BANK_IMG), txt_REC_LETTER.Text, txt_PAY_LETTER.Text);

            foreach (DataGridViewRow row in dgv_BANK_curr.Rows)
            {

                if (row.Cells["استخدام"].Value == DBNull.Value)
                {
                    row.Cells["استخدام"].Value = false;
                }
                Account.P_AC_insert_Account_Currency (row.Cells["الرمز"].Value.ToString(), txt_A_CODE.Text, Convert.ToBoolean(row.Cells["استخدام"].Value));
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الحساب");
            list_C_N.Add(100, "اسم الحساب ");
            list_C_N.Add(101, "الاسم الاجنبي ");

            string wherestr = " where Type_ID = 2 and ";
            string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account ";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
            frm.ShowDialog();

          
            txt_A_CODE.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_AC_Bank_Name.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_A_CODE.ReadOnly = true;
            btn_seve.Enabled = true;
            frm.Dispose();

            try
            {
                if (txt_A_CODE.TextLength != 0)
                {
                    dal = new DAL.DataAccessLayer();
                    dgv_BANK_curr.DataSource = dal.FindDataSet("select AM.currency_Key as الرمز,currency_name as الاسم,Ac.Used as استخدام from AC_Account_currency  AC right join AM_Currency AM  on ac.currency_Key=Am.currency_Key and Account_ID=N'" + txt_A_CODE.Text + "' where  AM.Used='1' ");
                    dgv_BANK_curr.Columns[0].Width = 30;
                    dgv_BANK_curr.Columns[0].Name = "الرمز";
                    dgv_BANK_curr.Columns[1].Width = 70;
                    dgv_BANK_curr.Columns[1].Name = "الاسم";
                    dgv_BANK_curr.Columns[2].Width = 60;
                    dgv_BANK_curr.Columns[2].Name = "استخدام";
                }
                else
                    dgv_BANK_curr.DataSource = null;
            }
            catch (Exception)
            {

                return;
            }

        }
         private void search()
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الحساب");
            list_C_N.Add(100, "اسم الحساب ");
            list_C_N.Add(101, "الاسم الاجنبي ");

            string wherestr = " where Type_ID = 2 and ";
            string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account ";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
            frm.ShowDialog();


            txt_A_CODE.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_AC_Bank_Name.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_A_CODE.ReadOnly = true;
            btn_seve.Enabled = true;
            frm.Dispose();

            try
            {
                if (txt_A_CODE.TextLength != 0)
                {
                    dal = new DAL.DataAccessLayer();
                    dgv_BANK_curr.DataSource = dal.FindDataSet("select AM.currency_Key as الرمز,currency_name as الاسم,Ac.Used as استخدام from AC_Account_currency  AC right join AM_Currency AM  on ac.currency_Key=Am.currency_Key and Account_ID=N'" + txt_A_CODE.Text + "' where  AM.Used='1' ");
                    dgv_BANK_curr.Columns[0].Width = 30;
                    dgv_BANK_curr.Columns[0].Name = "الرمز";
                    dgv_BANK_curr.Columns[1].Width = 70;
                    dgv_BANK_curr.Columns[1].Name = "الاسم";
                    dgv_BANK_curr.Columns[2].Width = 60;
                    dgv_BANK_curr.Columns[2].Name = "استخدام";
                }
                else
                    dgv_BANK_curr.DataSource = null;
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            clear();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.FindDataSet(" select BANK_NO from AC_CASH_AT_BANK  ");

            if (dt.Rows.Count == 0)
                txt_BANK_NO_id.Text= "1";
            else
             
            txt_BANK_NO_id.Text = proc.max_num_in_Column("AC_CASH_AT_BANK", "BANK_NO");
        }

        private void pic_BANK_IMG_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.Filter = "bmp files (*.bmp*.JPG;*.PNG;*.JPEG;*.GIF;*.jfif)| *.bmp;*.JPG;*.PNG;*.JPEG;*.GIF;*.jfif";

            // ofd.Filter = " image |*.JPG;*.PNG;*.GIF;*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_BANK_IMG.Image = Image.FromFile(ofd.FileName);
            }
            ofd.Dispose();
        }

    
        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
        }

        private void pic_BANK_IMG_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            BANk.P_AC_insert_CASH_AT_BANK(Convert.ToInt32(txt_BANK_NO_id.Text), txt_BANK_NAME_A.Text, txt_BANK_NAME_E.Text,
                txt_A_CODE.Text, txt_BANK_SR.Text, txt_AC_Bank_Name.Text, txt_BANK_ACC.Text, Convert.ToInt32(proc.Insert_com_to_db(cbx_CONN_BRN_NO)),
                txt_B_TEL.Text, txt_B_FAX.Text, txt_B_BOX.Text, txt_B_ADDRESS.Text, txt_B_E_MAIL.Text, txt_B_WEB_SITE.Text,
                chbx_MEDIATOR.Checked, chbx_INACTIVE.Checked, proc.Insert_DTB_to_db(dtb_INACTIVE_DATE), txt_INACTIVE_RES.Text,
                proc.Insert_image_to_db(pic_BANK_IMG), txt_REC_LETTER.Text, txt_PAY_LETTER.Text);

            foreach (DataGridViewRow row in dgv_BANK_curr.Rows)
            {

                if (row.Cells["استخدام"].Value == DBNull.Value)
                {
                    row.Cells["استخدام"].Value = false;
                }

                Account.P_AC_insert_Account_Currency(row.Cells["الرمز"].Value.ToString(), txt_A_CODE.Text, Convert.ToBoolean(row.Cells["استخدام"].Value));
            }

        }

        private void btn_show_user_branch_Click(object sender, EventArgs e)
        {

            DAL = new trader_app.DAL.DataAccessLayer();
            dgv_Bank_user.DataSource = null;
            dgv_Bank_user.DataSource = DAL.FindDataSet("select A_U.[U_ID] as'رقم_المستخدم',A_U.[U_A_NAME] as 'اسم_المستخدم',B_U.Adds as 'تعديل_و_اضافة',B_U.Show as'عرض' from Ath_Users A_U left join Ath_cash_In_Bank_User B_U on A_U.[U_ID]=B_U.User_ID and B_U.A_CODE=" + txt_A_CODE_2.Text);
            DAL = null;
        }

        private void btn_save_change_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dgv_Bank_user.Rows)
            {

                if (row.Cells["تعديل_و_اضافة"].Value == DBNull.Value || row.Cells["عرض"].Value == DBNull.Value)
                {
                    row.Cells["تعديل_و_اضافة"].Value = false;
                    row.Cells["عرض"].Value = false;

                }
                User.P_Ath_insert_Cash_Bank_User(Convert.ToInt32(row.Cells["رقم_المستخدم"].Value), txt_A_CODE_2.Text, Convert.ToBoolean(row.Cells["عرض"].Value), Convert.ToBoolean(row.Cells["تعديل_و_اضافة"].Value));
            }

        
    }

        private void txt_A_CODE_TextChanged_1(object sender, EventArgs e)
        {

            txt_A_CODE_2.Text = txt_A_CODE.Text;
            txt_CASH_NAME_A_N_2.Text = txt_BANK_NAME_A.Text;
            dgv_Bank_user.DataSource = null;
        }

        private void txt_BANK_NO_id_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_BANK_NO_id_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                view_data();
            }
            if(e.KeyCode==Keys.F9)
            {
                if (e.KeyCode == Keys.F9)
                {
                    Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                    list_C_N.Add(50, "رقم البنك");
                    list_C_N.Add(100, "اسم البنك ");
                    list_C_N.Add(101, "الاسم الاجنبي ");

                    string sql = " SELECT  BANK_NO , BANK_NAME_A , BANK_NAME_E  FROM AC_CASH_AT_BANK ";

                    PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
                    frm.ShowDialog();

                    txt_BANK_NO_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    view_data();
                }
            }
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search();
            view_data();


        }

        private void txt_BANK_NO_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
