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

namespace trader_app.PL.AC
{
    public partial class Frm_Cash_in_hand : PL.add_form
    {
       BL.process_Class proc = new BL.process_Class();
        BL.AC_Cash_in_hand cash = new BL.AC_Cash_in_hand();
        Account_Class Account = new Account_Class();
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        BL.User_class User = new BL.User_class();
        DAL.DataAccessLayer dal;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        DataTable dt;
        public Frm_Cash_in_hand()
        {
            InitializeComponent();
        }

        private void Frm_Cash_in_hand_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_CASH_TYPE, "SELECT CASH_TYPE_id, CASH_TYPE_A_N FROM AC_CASH_TYPE", "CASH_TYPE_A_N", "CASH_TYPE_id");
            DB.LoadCombo(cbx_CONN_BRN_NO, "select Branch_ID, Branch_A_N from AM_Branches", "Branch_A_N", "Branch_ID");
           cbx_CONN_BRN_NO.SelectedIndex = 1;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_price_trans_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Usde_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_CONN_BRN_NO_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            clear();
                 txt_CASH_NO_id.ReadOnly = true;
            txt_CASH_E_NAME_E_N.FindForm();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.FindDataSet(" select CASH_NO from AC_CASH_IN_HAND  ");

            if (dt.Rows.Count == 0)
                txt_CASH_NO_id.Text = "1";
            else
            txt_CASH_NO_id.Text = proc.max_num_in_Column("AC_CASH_IN_HAND", "CASH_NO");
       
        }
        private void clear()
        {
            txt_A_CODE.Text = txt_CASH_E_NAME_E_N.Text = txt_CASH_NAME_A_N.Text = txt_CASH_NO_id.Text = txt_CASH_SR.Text = txt_edit_date.Text = txt_edit_user.Text = txt_in_date.Text = txt_in_date.Text=txt_A_CODE.Text = " ";
            cbx_CASH_TYPE.Text = " ";
            chbx_INACTIVE.CheckState= CheckState.Unchecked;
            dgv_Cash_curr.DataSource=null;
            
        }

        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            cash.P_AC_insert_CASH_IN_HAND(Convert.ToInt32(txt_CASH_NO_id.Text), txt_CASH_NAME_A_N.Text, txt_CASH_E_NAME_E_N.Text
                , txt_A_CODE.Text,txt_CASH_SR.Text, txt_Cash_name.Text, Convert.ToInt32(proc.Insert_com_to_db(cbx_CASH_TYPE)), chbx_POS_SYS.Checked
                , Convert.ToInt32(proc.Insert_com_to_db(cbx_CONN_BRN_NO)), chbx_INACTIVE.Checked, proc.Insert_DTB_to_db(dtb_INACTIVE_DATE), txt_INACTIVE_RES.Text);

            foreach (DataGridViewRow row in dgv_Cash_curr.Rows)
            {

                if (row.Cells["استخدام"].Value == DBNull.Value)
                {
                    row.Cells["استخدام"].Value = false;
                }
           
           Account.P_AC_insert_Account_Currency( row.Cells["الرمز"].Value.ToString(), txt_A_CODE.Text, Convert.ToBoolean(row.Cells["استخدام"].Value));
            }
        }

        private void view_data()
        {
            DB = new DAL.Databas_Class();
            DataRow cash_Info = DB.select_Row("AC_CASH_IN_HAND", "CASH_NO", txt_CASH_NO_id.Text);
            if (cash_Info != null)
            {

                txt_CASH_NO_id.Text = cash_Info["CASH_NO"].ToString();
                txt_CASH_NAME_A_N.Text = cash_Info["CASH_NAME"].ToString();
                txt_CASH_E_NAME_E_N.Text = cash_Info["CASH_E_NAME"].ToString();
                txt_A_CODE.Text = cash_Info["A_CODE"].ToString();
                txt_CASH_SR.Text = cash_Info["CASH_SR"].ToString();
                txt_CASH_SR.Text = cash_Info["CASH_SR"].ToString();
                cbx_CASH_TYPE.SelectedValue = cash_Info["CASH_TYPE_id"].ToString();
                txt_INACTIVE_RES.Text = cash_Info["INACTIVE_RES"].ToString();
                cbx_CONN_BRN_NO.SelectedValue = cash_Info["CONN_BRN_NO"].ToString();
                dtb_INACTIVE_DATE.Text = cash_Info["INACTIVE_DATE"].ToString();

                if (cash_Info["INACTIVE"] != DBNull.Value)
                    chbx_INACTIVE.Checked = Convert.ToBoolean(cash_Info["INACTIVE"]);
                if (cash_Info["POS_SYS"] != DBNull.Value)
                    chbx_POS_SYS.Checked = Convert.ToBoolean(cash_Info["POS_SYS"]);

                //if (Account_Info["Class_ID"].ToString() != string.Empty)
                //    cbx_Account_Calss.SelectedValue = Account_Info["Class_ID"].ToString();
                //cbx_Account_group.SelectedValue = Account_Info["Account_Group_ID"].ToString();
                //cbx_Account_type.SelectedValue = Account_Info["Type_ID"].ToString();
                //Cbx_Account_status.SelectedValue = Account_Info["stutas"].ToString();
                //if (Account_Info["Account_Parent_ID"] == DBNull.Value)
                //{
                //    cbx_parent.SelectedIndex = -1;
                //    cbx_parent.SelectedValue = DBNull.Value;
                //}
                //else
               
                txt_in_date.Text = cash_Info["in_date"].ToString();
                txt_edit_date.Text = cash_Info["edit_date"].ToString();
                txt_edit_user.Text = cash_Info["edit_user"].ToString();
                txt_by_user.Text = cash_Info["by_user"].ToString();
                dgv_Cash_curr.DataSource = null;
                if (cash_Info["A_CODE"].ToString() !=DBNull.Value.ToString())
                {
                    dal = new DAL.DataAccessLayer();
                    dgv_Cash_curr.DataSource = dal.FindDataSet("select AM.currency_Key as الرمز,currency_name as الاسم,Ac.Used as استخدام from AC_Account_currency  AC right join AM_Currency AM  on ac.currency_Key=Am.currency_Key and Account_ID=N'" + txt_A_CODE.Text + "' where  AM.Used='1' ");
                    dgv_Cash_curr.Columns[0].Width = 30;
                    dgv_Cash_curr.Columns[0].Name = "الرمز";
                    dgv_Cash_curr.Columns[1].Width = 70;
                    dgv_Cash_curr.Columns[1].Name = "الاسم";
                    dgv_Cash_curr.Columns[2].Width = 60;
                    dgv_Cash_curr.Columns[2].Name = "استخدام";

                }

                btn_edit.Enabled = true;
            }
        }
        private void search_data()
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الحساب");
            list_C_N.Add(100, "اسم الحساب ");
            list_C_N.Add(101, "الاسم الاجنبي ");

            string wherestr =" where Type_ID = 2 and ";
            string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account ";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
            frm.ShowDialog();

            txt_A_CODE.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }
        private void txt_CASH_NO_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الصندوق");
                list_C_N.Add(100, "اسم الصندوق ");
                list_C_N.Add(101, "الاسم الاجنبي ");

                string sql = " SELECT  CASH_NO , CASH_NAME , CASH_E_NAME  FROM AC_CASH_IN_HAND ";

                PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
                frm.ShowDialog();

                txt_CASH_NO_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                view_data();
            }

        }

        private void txt_A_CODE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                search_data();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {

            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الصندوق");
            list_C_N.Add(100, "اسم الصندوق ");
            list_C_N.Add(101, "الاسم الاجنبي ");

            string sql = " SELECT  CASH_NO , CASH_NAME , CASH_E_NAME  FROM AC_CASH_IN_HAND ";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();

            txt_CASH_NO_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            view_data();
            
        }

        private void txt_A_CODE_TextChanged(object sender, EventArgs e)
        {
            txt_A_CODE_2.Text = txt_A_CODE.Text;
            txt_CASH_NAME_A_N_2.Text = txt_CASH_NAME_A_N.Text;
            dgv_Cash_user.DataSource = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الحساب");
            list_C_N.Add(100, "اسم الحساب ");
            list_C_N.Add(101, "الاسم الاجنبي ");

            string wherestr =" where Type_ID = 2 and ";
            string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account ";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
            frm.ShowDialog();

            // txt_A_CODE.Text = proc.max_num_in_Column("AC_Account where Account_Parent_ID  = " + frm.dataGridView1.CurrentRow.Cells[0].Value.ToString(), "Account_ID");
            txt_A_CODE.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Cash_name.Text= frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txt_A_CODE.ReadOnly = false;
          //  Account_ID = proc.max_num_in_Column("AC_Account", "Account_ID");
            //  MessageBox.Show("يرجا تحدد الحساب الرئسي ");
            txt_A_CODE.ReadOnly = true;
            btn_seve.Enabled = true;

            //txt_CASH_NO_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            //  s = lb_full_accout_num.Text;
            frm.Dispose();

            try
            {
                if (txt_A_CODE.TextLength !=0)
                {
                    dal = new DAL.DataAccessLayer();
                    dgv_Cash_curr.DataSource = dal.FindDataSet("select AM.currency_Key as الرمز,currency_name as الاسم,Ac.Used as استخدام from AC_Account_currency  AC right join AM_Currency AM  on ac.currency_Key=Am.currency_Key and Account_ID=N'" + txt_A_CODE.Text + "' where  AM.Used='1' ");
                    dgv_Cash_curr.Columns[0].Width = 30;
                    dgv_Cash_curr.Columns[0].Name = "الرمز";
                    dgv_Cash_curr.Columns[1].Width = 70;
                    dgv_Cash_curr.Columns[1].Name = "الاسم";
                    dgv_Cash_curr.Columns[2].Width = 60;
                    dgv_Cash_curr.Columns[2].Name = "استخدام";
                }
                else
                    dgv_Cash_curr.DataSource = null;
            }
            catch (Exception)
            {

                return;
            }


        }

        private void btn_repeal_Click(object sender, EventArgs e)
        {
            txt_A_CODE.ReadOnly = true;
            dgv_Cash_curr.DataSource = null;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cash.P_AC_insert_CASH_IN_HAND(Convert.ToInt32(txt_CASH_NO_id.Text), txt_CASH_NAME_A_N.Text, txt_CASH_E_NAME_E_N.Text
                   , txt_A_CODE.Text, txt_CASH_SR.Text,txt_Cash_name.Text, Convert.ToInt32(proc.Insert_com_to_db(cbx_CASH_TYPE)), chbx_POS_SYS.Checked
                   , Convert.ToInt32(proc.Insert_com_to_db(cbx_CONN_BRN_NO)), chbx_INACTIVE.Checked, proc.Insert_DTB_to_db(dtb_INACTIVE_DATE), txt_INACTIVE_RES.Text);

            foreach (DataGridViewRow row in dgv_Cash_curr.Rows)
            {

                if (row.Cells["استخدام"].Value == DBNull.Value)
                {
                    row.Cells["استخدام"].Value = false;
                }
                try
                {
                    Account.P_AC_insert_Account_Currency(row.Cells["الرمز"].Value.ToString(), txt_A_CODE.Text, Convert.ToBoolean(row.Cells["استخدام"].Value));
                }
                catch
                {

                    throw;
                }
              
            }
        }

        private void btn_show_user_branch_Click(object sender, EventArgs e)
        {

            DAL = new trader_app.DAL.DataAccessLayer();
            dgv_Cash_user.DataSource = null;
            dgv_Cash_user.DataSource = DAL.FindDataSet("select A_U.[U_ID] as'رقم_المستخدم',A_U.[U_A_NAME] as 'اسم_المستخدم',B_U.Adds as 'تعديل_و_اضافة',B_U.Show as'عرض' from Ath_Users A_U left join Ath_Cash_In_Hand_User B_U on A_U.[U_ID]=B_U.User_ID and B_U.A_CODE=" + txt_A_CODE_2.Text);
            DAL = null;
        }

        private void btn_save_change_Click(object sender, EventArgs e)
        {
             foreach (DataGridViewRow row in dgv_Cash_user.Rows)
            {

                if (row.Cells["تعديل_و_اضافة"].Value == DBNull.Value || row.Cells["عرض"].Value == DBNull.Value)
                {
                    row.Cells["تعديل_و_اضافة"].Value = false;
                    row.Cells["عرض"].Value = false;

                }
                User.P_Ath_insert_Cash_In_Hand_User( Convert.ToInt32(row.Cells["رقم_المستخدم"].Value),txt_A_CODE_2.Text ,Convert.ToBoolean(row.Cells["عرض"].Value), Convert.ToBoolean(row.Cells["تعديل_و_اضافة"].Value));
            }

        }
    }
}
