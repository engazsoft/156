using System;
using System.Collections;
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
    public partial class FRM_V_DETAILS : PL.add_form
    {
        process_Class pro = new process_Class();
        Account_AN account = new Account_AN();
        SUP_vendor vendor = new SUP_vendor();
        DAL.DataAccessLayer dal;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        DataTable dt;
        public FRM_V_DETAILS()
        {
            InitializeComponent();
        }

        private void FRM_V_DETAILS_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_VENDOR_GROUP, " select V_GROUP_CODE , V_GROUP_A_NAME from VENDOR_GROUP ", "V_GROUP_A_NAME", "V_GROUP_CODE");
            DB.LoadCombo(cbx_Cost_Center_ID, "select Cost_Center_ID , A_N  from AC_Cost_Center", "A_N", "Cost_Center_ID");
            DB.LoadCombo(cbx_Country, "select Country_ID,Country_A_N from AM_Country", "Country_A_N", "Country_ID");
            DB.LoadCombo(cbx_V_CLASS, "select V_CLASS , V_CLASS_NAME from SUP_VENDOR_CLASS", "V_CLASS_NAME", "V_CLASS");
            DB.LoadCombo(cbx_V_DEGREE, "select V_DEGREE , V_DEGREE_A_NAME from IAS_VENDOR_DEGREE", "V_DEGREE_A_NAME", "V_DEGREE");
            cbx_VENDOR_GROUP.SelectedIndex = -1;
            cbx_Country.SelectedIndex = -1;
            cbx_V_CLASS.SelectedIndex = -1;
            cbx_V_DEGREE.SelectedIndex = -1;
            cbx_Cost_Center_ID.SelectedIndex = -1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void cbx_inv_group_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Country_SelectedValueChanged(object sender, EventArgs e)
        {

        }


        private void cbx_VENDOR_GROUP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = pro.select_data_row("VENDOR_GROUP", "V_GROUP_CODE", Convert.ToUInt16(cbx_VENDOR_GROUP.SelectedValue.ToString()));
                txt_Account_ID.Text = dt.Rows[0]["V_ACCOUNT_ID"].ToString();
                dt.Dispose();
            }
            catch (Exception)
            {

                txt_Account_ID.Text = "";

            }
            try
            {
                DataTable dt = pro.select_data_row("AC_Account", "Account_ID", txt_Account_ID.Text);
                txt_A_N.Text = dt.Rows[0]["A_N"].ToString();
                dt.Dispose();
            }
            catch (Exception)
            {

                txt_A_N.Text = "";

            }

            try
            {
                if (txt_Account_ID.TextLength != 0)
                {
                    dal = new DAL.DataAccessLayer();
                    dgv_V_curr.DataSource = dal.FindDataSet("select AM.currency_Key as الرمز,currency_name as الاسم,AC.Used as استخدام from AC_ACCOUNT_AN__CURR  AC right join AM_Currency AM  on ac.currency_Key=Am.currency_Key and ac.N_AN=N'" + txt_V_CODE.Text + "' where  AM.Used='1' ");
                    dgv_V_curr.Columns[0].Width = 100;
                    dgv_V_curr.Columns[0].Name = "الرمز";
                    dgv_V_curr.Columns[1].Width = 130;
                    dgv_V_curr.Columns[1].Name = "الاسم";
                    dgv_V_curr.Columns[2].Width = 130;
                    dgv_V_curr.Columns[2].Name = "استخدام";
                    btn_seve.Enabled = true;
                }
                else
                    dgv_V_curr.DataSource = null;
            }
            catch (Exception)
            {

                return;
            }
        }

        private void txt_Account_ID_TextChanged(object sender, EventArgs e)
        {


        }

        private void cbx_VENDOR_GROUP_Leave(object sender, EventArgs e)
        {

        }

        private void cbx_Country_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                cbx_Gov.DataSource = null;
                DB.LoadCombo(cbx_Gov, "select Gov_id,A_N from AM_Governorates  where Country_ID=" + cbx_Country.SelectedValue.ToString(), "A_N", "Gov_id");
            }



            catch
            {

            }

        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            vendor.P_Sup_insert_V_DETAILS(txt_V_CODE.Text, txt_V_A_NAME.Text, txt_V_E_NAME.Text, txt_Account_ID.Text, Convert.ToInt32(pro.Insert_com_to_db(cbx_VENDOR_GROUP))
                , Convert.ToInt32(pro.Insert_com_to_db(cbx_V_CLASS)), Convert.ToInt32(pro.Insert_com_to_db(cbx_V_DEGREE)), txt_V_TAX_CODE.Text, txt_V_ADDRESS.Text, Convert.ToInt32(pro.Insert_com_to_db(cbx_V_DEGREE)), Convert.ToInt32(pro.Insert_com_to_db(cbx_Gov))
                , Convert.ToInt32(pro.Insert_com_to_db(cbx_Cost_Center_ID)), txt_V_PHONE.Text, txt_V_FAX.Text, txt_V_BOX.Text, txt_V_E_MAIL.Text, txt_V_WEB_SITE.Text
                , txt_V_MOBILE.Text, pro.Insert_DTB_to_db(dtb_V_SINCE), checkBox_INACTIVE.Checked, txt_V_NOTE.Text, chbx_BLK_LST.Checked, txt_BLK_LST_RES.Text
                , Convert.ToInt32(txt_VCREDIT_PERIOD.Text), Convert.ToInt32(txt_AC_OP_NO.Text), pro.Insert_DTB_to_db(dtb_V_Last_Pyment));

            account.P_AC_insert_ACCOUNT_AN(txt_Account_ID.Text, txt_V_CODE.Text, txt_V_A_NAME.Text);

            foreach (DataGridViewRow row in dgv_V_curr.Rows)
            {

                if (row.Cells["استخدام"].Value == DBNull.Value)
                {
                    row.Cells["استخدام"].Value = false;
                }

                account.P_AC_inser_ACCOUNT_AN__CURR(row.Cells["الرمز"].Value.ToString(), txt_Account_ID.Text, txt_V_CODE.Text, Convert.ToBoolean(row.Cells["استخدام"].Value));

            }

        }
        private void search()
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم المورد");
            list_C_N.Add(100, "اسم المورد ");
            list_C_N.Add(101, "الاسم الاجنبي ");

          
            string sql = " SELECT  V_CODE , V_A_NAME , V_E_NAME  FROM   V_DETAILS ";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();

            txt_V_CODE.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            view_data();
            txt_V_CODE.ReadOnly = true;
            btn_seve.Enabled = true;
            frm.Dispose();

           
        }

        private void view_data()
        {
            DB = new DAL.Databas_Class();
            DataRow VENDOR_Info = DB.select_Row("V_DETAILS", "V_CODE", txt_V_CODE.Text);
            if (VENDOR_Info != null)
            {
                txt_V_CODE.Text = VENDOR_Info["V_CODE"].ToString();
                txt_V_A_NAME.Text = VENDOR_Info["V_A_NAME"].ToString();
                txt_V_E_NAME.Text = VENDOR_Info["V_E_NAME"].ToString();
                txt_Account_ID.Text = VENDOR_Info["Account_ID"].ToString();
                cbx_VENDOR_GROUP.SelectedValue = VENDOR_Info["V_GROUP_CODE"].ToString();
                cbx_V_CLASS.SelectedValue = VENDOR_Info["V_CLASS"].ToString();
                cbx_V_DEGREE.SelectedValue = VENDOR_Info["V_DEGREE"].ToString();
                txt_V_TAX_CODE.Text = VENDOR_Info["V_TAX_CODE"].ToString();
                txt_V_ADDRESS.Text = VENDOR_Info["V_ADDRESS"].ToString();
                cbx_Country.SelectedValue = VENDOR_Info["Country_ID"].ToString();
                cbx_Gov.SelectedValue = VENDOR_Info["Gov_id"].ToString();
                cbx_Cost_Center_ID.SelectedValue = VENDOR_Info["Cost_Center_ID"].ToString();
                txt_V_PHONE.Text = VENDOR_Info["V_PHONE"].ToString();
                txt_V_FAX.Text = VENDOR_Info["V_FAX"].ToString();
                txt_V_BOX.Text = VENDOR_Info["V_BOX"].ToString();
                txt_V_E_MAIL.Text = VENDOR_Info["V_E_MAIL"].ToString();
                txt_V_WEB_SITE.Text = VENDOR_Info["V_WEB_SITE"].ToString();
                txt_V_MOBILE.Text = VENDOR_Info["V_MOBILE"].ToString();

                dtb_V_SINCE.Text = VENDOR_Info["V_SINCE"].ToString();
                txt_V_NOTE.Text = VENDOR_Info["V_NOTE"].ToString();
                txt_BLK_LST_RES.Text = VENDOR_Info["BLK_LST_RES"].ToString();
                txt_VCREDIT_PERIOD.Text = VENDOR_Info["CREDIT_PERIOD"].ToString();
                txt_AC_OP_NO.Text = VENDOR_Info["AC_OP_NO"].ToString();
                dtb_V_Last_Pyment.Text = VENDOR_Info["V_Last_Pyment"].ToString();

                if (VENDOR_Info["INACTIVE"] != DBNull.Value)
                    checkBox_INACTIVE.Checked = Convert.ToBoolean(VENDOR_Info["INACTIVE"]);
                if (VENDOR_Info["BLK_LST"] != DBNull.Value)
                    chbx_BLK_LST.Checked = Convert.ToBoolean(VENDOR_Info["BLK_LST"]);

                txt_in_date.Text = VENDOR_Info["in_date"].ToString();
                txt_edit_date.Text = VENDOR_Info["edit_date"].ToString();
                txt_edit_user.Text = VENDOR_Info["edit_user"].ToString();
                txt_by_user.Text = VENDOR_Info["by_user"].ToString();
                dgv_V_curr.DataSource = null;


                if (VENDOR_Info["V_CODE"].ToString() != DBNull.Value.ToString())
                {
                    dal = new DAL.DataAccessLayer();
                    dgv_V_curr.DataSource = dal.FindDataSet("select AM.currency_Key as الرمز,currency_name as الاسم,AC.Used as استخدام from AC_ACCOUNT_AN__CURR  AC right join AM_Currency AM  on ac.currency_Key=Am.currency_Key where  ac.N_AN=N'" + txt_V_CODE.Text + "' and  AM.Used='1'");
                    dgv_V_curr.Columns[0].Width = 100;
                    dgv_V_curr.Columns[0].Name = "الرمز";
                    dgv_V_curr.Columns[1].Width = 130;
                    dgv_V_curr.Columns[1].Name = "الاسم";
                    dgv_V_curr.Columns[2].Width = 130;
                    dgv_V_curr.Columns[2].Name = "استخدام";
                }

                btn_edit.Enabled = true;
            }
        }

        private void dgv_V_curr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgv_V_curr_MultiSelectChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbx_VENDOR_GROUP.SelectedValue.ToString()))
                {
                    MessageBox.Show("يرجا تحدد المجموعة الرئيسية ");
                    btn_seve.Enabled = false;
                }
                else
                {

                    txt_A_N.Text = "";
                  
                }
            }
            catch
            {

                MessageBox.Show("يرجا تحدد المجموعة الرئيسية ");
                btn_seve.Enabled = false;
                cbx_VENDOR_GROUP.Focus();
            }
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.FindDataSet(" select V_CODE from V_DETAILS  ");

            if (dt.Rows.Count == 0)
                txt_V_CODE.Text = "1";
            else
            txt_V_CODE.Text = pro.max_num_in_Column("V_DETAILS", " V_CODE");
            txt_V_CODE.ReadOnly = true;
            txt_V_E_NAME.Text = txt_A_N.Text = txt_Account_ID.Text = txt_by_user.Text = txt_edit_date.Text = txt_edit_user.Text = txt_in_date.Text = "";
            cbx_VENDOR_GROUP.SelectedIndex = -1;
            cbx_Country.SelectedIndex = -1;
            cbx_V_CLASS.SelectedIndex = -1;
            cbx_V_DEGREE.SelectedIndex = -1;
            cbx_Cost_Center_ID.SelectedIndex = -1;

        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
                vendor.P_Sup_insert_V_DETAILS(txt_V_CODE.Text, txt_V_A_NAME.Text, txt_V_E_NAME.Text, txt_Account_ID.Text, Convert.ToInt32(pro.Insert_com_to_db(cbx_VENDOR_GROUP))
                , Convert.ToInt32(pro.Insert_com_to_db(cbx_V_CLASS)), Convert.ToInt32(pro.Insert_com_to_db(cbx_V_DEGREE)), txt_V_TAX_CODE.Text, txt_V_ADDRESS.Text, Convert.ToInt32(pro.Insert_com_to_db(cbx_V_DEGREE)), Convert.ToInt32(pro.Insert_com_to_db(cbx_Gov))
                , Convert.ToInt32(pro.Insert_com_to_db(cbx_Cost_Center_ID)), txt_V_PHONE.Text, txt_V_FAX.Text, txt_V_BOX.Text, txt_V_E_MAIL.Text, txt_V_WEB_SITE.Text
                , txt_V_MOBILE.Text, pro.Insert_DTB_to_db(dtb_V_SINCE), checkBox_INACTIVE.Checked, txt_V_NOTE.Text, chbx_BLK_LST.Checked, txt_BLK_LST_RES.Text
                , Convert.ToInt32(txt_VCREDIT_PERIOD.Text), Convert.ToInt32(txt_AC_OP_NO.Text), pro.Insert_DTB_to_db(dtb_V_Last_Pyment));

                account.P_AC_insert_ACCOUNT_AN(txt_Account_ID.Text, txt_V_CODE.Text, txt_V_A_NAME.Text);

            foreach (DataGridViewRow row in dgv_V_curr.Rows)
            {

                if (row.Cells["استخدام"].Value == DBNull.Value)
                {
                    row.Cells["استخدام"].Value = false;
                }

                account.P_AC_inser_ACCOUNT_AN__CURR(row.Cells["الرمز"].Value.ToString(), txt_Account_ID.Text, txt_V_CODE.Text, Convert.ToBoolean(row.Cells["استخدام"].Value));

            }
        }
    }
}
