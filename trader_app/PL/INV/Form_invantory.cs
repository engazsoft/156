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

namespace trader_app.PL.INV
{
    public partial class Form_invantory : PL.add_form
    {
        INV_inventory_group inv_g = new BL.INV_inventory_group();
        INV_Inventory_Class inventorys = new BL.INV_Inventory_Class();
        process_Class proc = new process_Class();
        Account_Class Account = new Account_Class();
        DAL.Databas_Class DB=new DAL.Databas_Class();
        DataTable dt;
        DAL.DataAccessLayer dal;
        User_class User = new User_class();
     
        string INV_Account_ID=113.ToString();
        public Form_invantory()
        {
            InitializeComponent();
        }

        private void Form_products_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_country, "select Country_ID,Country_A_N from AM_Country", "Country_A_N", "Country_ID");
            DB.LoadCombo(cbx_inv_group, "select Inventory_Group_ID,Group_A_N from INV_Inventory_groups", "Group_A_N", "Inventory_Group_ID");
            DB.LoadCombo(cbx_Btanch_ID, "select [Branch_ID] ,[Branch_A_N] from [AM_Branches]", "Branch_A_N", "Branch_ID");
            txt_Sequence.Text = "0";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_INV_InfoopDown(object sender, EventArgs e)
        {
            //cbx_inv_group.DataSource = inv_g.p_INV_Get_inventory_group();
            //cbx_inv_group.DisplayMember = "Group_A_N";
            //cbx_inv_group.ValueMember = "Inventory_Group_ID";


        }

        private void cbx_inv_group_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void txt_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                search_data();
            }
            if (e.KeyCode == Keys.Enter)
            {
                view_data();
            }
           
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text = proc.max_num_in_Column("INV_Inventorys", "Invontory_ID");
            if (txt_id.Text.Length == 0)
            {
                txt_id.Text = 1.ToString();

                txt_id.ReadOnly = true;
                txt_Account_ID.ReadOnly = false;
            }
            btn_genrator_acount_num.Visible = true;

        }

        private void cbx_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                DB.LoadCombo(cbx_gvr, "select Gov_id,A_N from AM_Governorates  where Gov_id=0 or Country_ID=" + cbx_country.SelectedValue.ToString(), "A_N", "Gov_id");
         
        }

        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }

        private void cbx_gvr_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                DB.LoadCombo(cbx_dist, "select Distinct_id,A_N from AM_Districts  where Distinct_id=0 or Gov_ID=" + cbx_gvr.SelectedValue.ToString(), "A_N", "Distinct_id");
      
        
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            
            inventorys.p_INV_insert_Inventorys(Convert.ToInt32(txt_id.Text),
                txt_A_N.Text,
                txt_E_N.Text, 
                txt_Storekeepr.Text,
                txt_Inventory_Location.Text,
                txt_phone.Text,
                Convert.ToInt32(proc.Insert_txt_to_db(txt_Sequence.Text)),
                Convert.ToInt32(proc.Insert_com_to_db(cbx_country)),
                chbx_is_priemry.Checked,
                Convert.ToInt32(cbx_gvr.SelectedValue),
                Convert.ToInt32(cbx_dist.SelectedValue),
               Convert.ToInt32(txt_Account_ID.Text),
                Convert.ToInt32(cbx_inv_group.SelectedValue),
                checkBox_for_sale.Checked, 
                checkBox_stop.Checked);
            btn_seve.Enabled = false;
            txt_id.ReadOnly = false;
           
          }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_id.ReadOnly = true;
            txt_Account_ID.ReadOnly = true;
                groupBox_Data.Controls.OfType<TextBox>().All(tb => tb.ReadOnly = false);
              

           
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_dist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search_data();
        }
        private void search_data()
        {
            string sql = " SELECT [Invontory_ID] as الرقم ,[Inventory_A_N] as الاسم,[Inventory_E_N] as الاسم_الاجنبي FROM [dbo].[INV_Inventorys] ";
            //dt.Columns.RemoveAt(6);
            //dt.Columns.RemoveAt(5);
            //dt.Columns.RemoveAt(4);
            //dt.Columns.RemoveAt(3);

            PL.Am.Form_Search frm = new PL.Am.Form_Search(sql);
         


            frm.ShowDialog();

            txt_id.Text = frm.dataGridView1.CurrentRow.Cells["الرقم"].Value.ToString();
            view_data();
        }
        private void view_data()
        {
           
            DB = new DAL.Databas_Class();

            DataRow INV_Info = DB.select_Row(this.Tag.ToString(), txt_id.Tag.ToString(), txt_id.Text);
            if (INV_Info!=null)
            {
              
   
                txt_A_N.Text = INV_Info["Inventory_A_N"].ToString();
                txt_E_N.Text = INV_Info["Inventory_E_N"].ToString();
                txt_Storekeepr.Text = INV_Info["Storekeepr"].ToString();
                txt_Inventory_Location.Text = INV_Info["Inventory_Location"].ToString();
                txt_phone.Text= INV_Info["phone_num"].ToString();
                txt_Sequence.Text = INV_Info["Sequence"].ToString();
                cbx_country.SelectedValue = INV_Info["Country_ID"].ToString();
                if (INV_Info["Primery_Store"] != DBNull.Value)
                {
                    chbx_is_priemry.Checked = Convert.ToBoolean(INV_Info["Primery_Store"]);
                }
                cbx_inv_group.SelectedValue = INV_Info["Inventory_Group_ID"].ToString();
                cbx_gvr.SelectedValue = INV_Info["Gov_id"].ToString();
                cbx_dist.SelectedValue = INV_Info["Distinct_id"].ToString();
                cbx_Btanch_ID.SelectedValue = INV_Info["Btanch_ID"].ToString();
                
                txt_edit_user.Text = INV_Info["edit_user"].ToString();
                txt_by_user.Text = INV_Info["by_user"].ToString();
              
                if (INV_Info["Account_ID"]!=DBNull.Value)
                {
                    DataRow dr =DB.select_Row("AC_Account", "Account_ID", INV_Info["Account_ID"].ToString());
                    txt_Account_ID.Text = dr["Account_ID"].ToString();
                    txt_Account_Nema.Text = dr["A_N"].ToString();

                }
                else 
                    txt_Account_ID.Text="غير محدد";
                txt_by_user.Text = INV_Info["by_user"].ToString();
                txt_edit_date.Text = INV_Info["edit_date"].ToString();
                txt_edit_user.Text = INV_Info["edit_user"].ToString();
                txt_in_date.Text = INV_Info["in_date"].ToString();

                // if (INV_Info["Type_ID"].ToString() == "2")
                // {
                //     dal = new DAL.DataAccessLayer();
                //     dgv_Account_curr.DataSource = dal.FindDataSet("select AM.currency_ID as الرمز,currency_name as الاسم,Ac.Used as استخدام from AC_Account_currency  AC right join AM_Currency AM  on ac.currency_ID=Am.currency_ID and Account_ID=" + Account_ID + " where  AM.Used='1' ");
                //     dgv_Account_curr.Columns[0].Width = 30;
                //     dgv_Account_curr.Columns[0].Name = "الرمز";
                //     dgv_Account_curr.Columns[1].Width = 70;
                //     dgv_Account_curr.Columns[1].Name = "الاسم";
                //     dgv_Account_curr.Columns[2].Width = 60;
                //     dgv_Account_curr.Columns[2].Name = "استخدام";
                // }

                // //   if (INV_Info["Affected_by_operations"] != DBNull.Value)
                // //    chbx_Affected_by_operations.Checked = Convert.ToBoolean(INV_Info["Affected_by_operations"]);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT  Account_ID as الرقم ,A_N as الاسم,E_N as الاسم_الاجنبي FROM [dbo].AC_Account where Type_id=1";
            PL.Am.Form_Search frm = new Am.Form_Search(sql);
            frm.MdiParent = this.MdiParent;


            frm.ShowDialog();
            txt_Account_ID.Text = frm.dataGridView1.CurrentRow.Cells["الرقم"].Value.ToString() ;
           txt_Account_Nema.Text = frm.dataGridView1.CurrentRow.Cells["الاسم"].Value.ToString();




        }

        private void btn_show_user_branch_Click(object sender, EventArgs e)
        {

            dal = new trader_app.DAL.DataAccessLayer();
            dgv_invantory_user.DataSource = null;
            dgv_invantory_user.DataSource = dal.FindDataSet("select A_U.User_ID as'رقم_المستخدم',A_U.User_Nema as 'اسم_المستخدم',I_U.Adds as 'تعديل_و_اضافة',I_U.Show as'عرض' from Ath_Users A_U left join [dbo].[Ath_Inventorys_Users] I_U  on A_U.User_ID=I_U.User_ID and I_U.Inventory_ID=" + txt_invantory_id2.Text);
            dal = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in dgv_invantory_user .Rows)
            {

                if (row.Cells["تعديل_و_اضافة"].Value == DBNull.Value || row.Cells["عرض"].Value == DBNull.Value)
                {
                    row.Cells["تعديل_و_اضافة"].Value = false;
                    row.Cells["عرض"].Value = false;

                }
                User.P_Ath_insert_invantory_User(Convert.ToInt32(txt_invantory_id2.Text), Convert.ToInt32(row.Cells["رقم_المستخدم"].Value), Convert.ToBoolean(row.Cells["عرض"].Value), Convert.ToBoolean(row.Cells["تعديل_و_اضافة"].Value));
            }
        }

        private void txt_Sequence_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form_invantory_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
    }
}
