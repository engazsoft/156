using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using trader_app.BL;

namespace trader_app.PL.AC
{
    public partial class frm_Account_request : PL.add_form
    {

        process_Class proc = new process_Class();
        Account_Class Account = new Account_Class();
        DAL.DataAccessLayer dal;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        DataTable dt;
        public frm_Account_request()
        {
            InitializeComponent();
        }

        private void frm_Account_request_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_Account_group, "select Group_ID,A_N from AC_Account_Group ", "A_N", "Group_ID");

            DB.LoadCombo(cbx_Account_type, "select Type_ID,A_N from AC_Account_Type ", "A_N", "Type_ID");
            DB.LoadCombo(cbx_Account_Calss, "select Class_ID,A_N from AC_Account_Class ", "A_N", "Class_ID");
            DB.LoadCombo(cbx_parent, "SELECT  Account_ID ,A_N ,E_N  FROM [dbo].AC_Account where Type_id=1", "A_N", "Account_ID");
            cbx_parent.SelectedItem = null;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbx_parent.SelectedValue.ToString()))
                {
                    MessageBox.Show("يرجا تحدد الحساب الرئسي ");
                    btn_seve.Enabled = false;
                }
                else
                {

                    txt_A_N.Text = "";
                    txt_E_N.Text = "";

                    //Account_ID = proc.max_num_in_Column("AC_Account", "Account_ID");
                    txt_id.Text = proc.max_num_in_Column("AC_Account where Account_Parent_ID  = " + cbx_parent.SelectedValue.ToString(), "Account_ID");

                    if (txt_id.Text.Length == 0)
                    {
                        txt_id.Text = cbx_parent.SelectedValue + "1";
                        txt_id.ReadOnly = false;
                    }
                }
            }
            catch
            {

                MessageBox.Show("يرجا تحدد الحساب الرئسي ");
                btn_seve.Enabled = false;
                cbx_parent.Focus();
            }

        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            Account.P_AC_insert_Account_Request(txt_id.Text, proc.Insert_com_to_db(cbx_parent), txt_A_N.Text, txt_E_N.Text
                , Convert.ToInt32(proc.Insert_com_to_db(cbx_Account_type)), Convert.ToInt32(proc.Insert_com_to_db(cbx_Account_group)),
                Convert.ToInt32(proc.Insert_com_to_db(cbx_Account_Calss)), chbx_INACTIVE_add.Checked, txt_Note.Text);
        }

        private void btn_view_Click(object sender, EventArgs e)
        {

            DB = new DAL.Databas_Class();
            DataRow Account_Info = DB.select_Row("AC_Account_Request", "Account_ID", txt_id.Text);

            if (Account_Info != null)
            {

                txt_id.Text = Account_Info["Account_ID"].ToString();

                txt_A_N.Text = Account_Info["A_N"].ToString();
                txt_E_N.Text = Account_Info["E_N"].ToString();
                txt_Note.Text = Account_Info["Note"].ToString();
                if (Account_Info["Class_ID"].ToString() != string.Empty)
                    cbx_Account_Calss.SelectedValue = Account_Info["Class_ID"].ToString();
                cbx_Account_group.SelectedValue = Account_Info["Account_Group_ID"].ToString();
                cbx_Account_type.SelectedValue = Account_Info["Type_ID"].ToString();

                if (Account_Info["Account_Parent_ID"] == DBNull.Value)
                {
                    cbx_parent.SelectedIndex = -1;
                    cbx_parent.SelectedValue = DBNull.Value;
                }
                else
                    cbx_parent.SelectedValue = Account_Info["Account_Parent_ID"].ToString();
                txt_in_date.Text = Account_Info["in_date"].ToString();
                txt_edit_date.Text = Account_Info["edit_date"].ToString();
                txt_edit_user.Text = Account_Info["edit_user"].ToString();
                txt_by_user.Text = Account_Info["by_user"].ToString();

                if (Account_Info["Type_ID"].ToString() == "2")
                {

                }

                btn_edit.Enabled = true;
            }
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                search_data();
                view_data();
            }

        }
        private void search_data()
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الحساب");
            list_C_N.Add(100, "اسم الحساب ");
            list_C_N.Add(101, "الاسم الاجنبي ");


            string sql = " SELECT  Account_ID , A_N , E_N  FROM   AC_Account_Request ";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            frm.ShowDialog();

            txt_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            view_data();

        }

        private void view_data()
        {
            DB = new DAL.Databas_Class();
            DataRow Account_Info = DB.select_Row("AC_Account_Request", "Account_ID", txt_id.Text);

            if (Account_Info != null)
            {

                txt_id.Text = Account_Info["Account_ID"].ToString();

                txt_A_N.Text = Account_Info["A_N"].ToString();
                txt_E_N.Text = Account_Info["E_N"].ToString();
                txt_Note.Text = Account_Info["Note"].ToString();
                if (Account_Info["Class_ID"].ToString() != string.Empty)
                    cbx_Account_Calss.SelectedValue = Account_Info["Class_ID"].ToString();
                cbx_Account_group.SelectedValue = Account_Info["Account_Group_ID"].ToString();
                cbx_Account_type.SelectedValue = Account_Info["Type_ID"].ToString();

                if (Account_Info["Account_Parent_ID"] == DBNull.Value)
                {
                    cbx_parent.SelectedIndex = -1;
                    cbx_parent.SelectedValue = DBNull.Value;
                }
                else
                    cbx_parent.SelectedValue = Account_Info["Account_Parent_ID"].ToString();
                txt_in_date.Text = Account_Info["in_date"].ToString();
                txt_edit_date.Text = Account_Info["edit_date"].ToString();
                txt_edit_user.Text = Account_Info["edit_user"].ToString();
                txt_by_user.Text = Account_Info["by_user"].ToString();

                //if (Account_Info["Type_ID"].ToString() == "2")
                //{

                //}

                btn_edit.Enabled = true;

            }
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search_data();
            view_data();
        }
    }
}
