using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace trader_app.PL.INV
{
    public partial class frm_product_Category : PL.add_form
    {
        BL.Product_Class Prodtct = new BL.Product_Class();
        DAL.Databas_Class db = new DAL.Databas_Class();
        public frm_product_Category()
        {
            InitializeComponent();
        }

        private void frm_product_Category_Load(object sender, EventArgs e)
        {

        }

        private void txt_INV_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_INV_Account.ReadOnly == false && txt_A_N.Text != string.Empty)
            {
                
                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = "where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account] ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql,wherestr,list_C_N);
                frm.ShowDialog();
                txt_INV_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_INV_Account_A_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }

        }

        private void txt_salse_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_salse_Account.ReadOnly == false&& txt_A_N.Text!=string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account] ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_salse_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_salse_Account_A_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_cost_of_sales_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_salse_Account.ReadOnly == false && txt_A_N.Text != string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_cost_of_sales_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_cost_of_sales_Account_A_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {

        }

        private void txt_INV_Account_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cost_return_sales_Account_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_salse_Account.ReadOnly == false && txt_A_N.Text != string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_rerurn_sales_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_rerurn_sales_Account_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }
        private void view_data()
        {
           
            DataRow Cat_inf= db.select_Row(this.Tag.ToString(), txt_id.Tag.ToString(), txt_id.Text);
            //dt = new DataTable();
            //dal = new DAL.DataAccessLayer();
            //dt = dal.FindDataSet("SELECT  [Type_ID] ,[A_N] ,[E_N] ,[Affected_by_operations],[edit_date] ,[edit_user]  ,[in_date],[by_user] FROM [trader_db].[dbo].[AC_Account_type] where Type_ID=" + txt_id.Text);

            if (Cat_inf!=null)
            {

            txt_A_N.Text = Cat_inf["A_N"].ToString();


            txt_E_N.Text = Cat_inf["E_N"].ToString();


            txt_INV_Account.Text = Cat_inf["INV_Account"].ToString();
            BL.Account_Class Account = new BL.Account_Class();
            txt_INV_Account_A_N.Text = Account.get_account(txt_INV_Account.Text)["A_N"].ToString();


            txt_salse_Account.Text = Cat_inf["salse_Account"].ToString();
            Account = new BL.Account_Class();
            txt_salse_Account_A_N.Text = Account.get_account(txt_salse_Account.Text)["A_N"].ToString();


            txt_cost_of_sales_Account.Text = Cat_inf["cost_of_sales_Account"].ToString();
            Account = new BL.Account_Class();
            txt_cost_of_sales_Account_A_N.Text = Account.get_account(txt_cost_of_sales_Account.Text)["A_N"].ToString();


            txt_rerurn_sales_Account.Text = Cat_inf["rerurn_sales_Account"].ToString();
            Account = new BL.Account_Class();
            txt_rerurn_sales_Account_N.Text = Account.get_account(txt_rerurn_sales_Account.Text)["A_N"].ToString();


            txt_cost_return_sales_Account.Text = Cat_inf["cost_return_sales_Account"].ToString();
            Account = new BL.Account_Class();
            txt_cost_return_sales_Account_N.Text = Account.get_account(txt_cost_return_sales_Account.Text)["A_N"].ToString();


            txt_Discount_Alloewed_Account.Text = Cat_inf["Discount_Alloewed_Account"].ToString();
            Account = new BL.Account_Class();
            txt_Discount_Alloewed_Account_A_N.Text = Account.get_account(txt_Discount_Alloewed_Account.Text)["A_N"].ToString();


            txt_cost_return_sales_year_Account.Text = Cat_inf["cost_return_sales_year_Account"].ToString();
            Account = new BL.Account_Class();
            txt_cost_return_sales_year_Account_N.Text = Account.get_account(txt_cost_return_sales_year_Account.Text)["A_N"].ToString();


            txt_rerurn_sales_year_Account.Text = Cat_inf["rerurn_sales_year_Account"].ToString();
            Account = new BL.Account_Class();
            txt_rerurn_sales_year_Account_N.Text = Account.get_account(txt_rerurn_sales_year_Account.Text)["A_N"].ToString();


            txt_Earned_Discount_Account.Text = Cat_inf["Earned_Discount_Account"].ToString();
            Account = new BL.Account_Class();
            txt_Earned_Discount_Account_N.Text = Account.get_account(txt_Earned_Discount_Account.Text)["A_N"].ToString();


            txt_free_sales_cost_Account.Text = Cat_inf["free_sales_cost_Account"].ToString();
            Account = new BL.Account_Class();
            txt_free_sales_cost_Account_N.Text = Account.get_account(txt_free_sales_cost_Account.Text)["A_N"].ToString();


            txt_rerurn_free_sales_Account.Text = Cat_inf["rerurn_free_sales_Account"].ToString();
            Account = new BL.Account_Class();
            txt_rerurn_free_sales_Account_N.Text = Account.get_account(txt_rerurn_free_sales_Account.Text)["A_N"].ToString();


            txt_cost_of_free_purchases.Text = Cat_inf["cost_of_free_purchases"].ToString();
            Account = new BL.Account_Class();
            txt_cost_of_free_purchases_N.Text = Account.get_account(txt_cost_of_free_purchases.Text)["A_N"].ToString();


            txt_in_date.Text = Cat_inf["in_date"].ToString();
            txt_edit_date.Text = Cat_inf["edit_date"].ToString();
            txt_edit_user.Text = Cat_inf["edit_user"].ToString();
            txt_by_user.Text = Cat_inf["by_user"].ToString();
            txt_free_sales_cost_Account.Text = Cat_inf["free_sales_cost_Account"].ToString();
            //    if (Cat_inf["Affected_by_operations"] != DBNull.Value)
            //    chbx_Affected_by_operations.Checked = Convert.ToBoolean(Cat_inf["Affected_by_operations"]);
            btn_dele.Enabled = btn_edit.Enabled = btn_add.Enabled = true;
            frm_View(this);
            txt_id.ReadOnly = false;
            }
        }
        private void search_data()
        {
          

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم المجموعة");
                list_C_N.Add(150, "اسم المجموعة ");
               
           
                string sql = " SELECT top 20 [Category_ID],[A_N] FROM [dbo].[INV_Product_Category]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
              
                frm.ShowDialog();
                txt_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                view_data();
          

        }
        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_id.ReadOnly == false )
            {
                search_data();
           
            }

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
        }

        private void txt_cost_return_sales_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_rerurn_sales_Account.ReadOnly == false && txt_A_N.Text != string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_rerurn_sales_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_rerurn_sales_Account_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_Discount_Alloewed_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_Discount_Alloewed_Account.ReadOnly == false && txt_A_N.Text != string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_Discount_Alloewed_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_Discount_Alloewed_Account_A_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_cost_return_sales_year_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_cost_return_sales_year_Account.ReadOnly == false && txt_A_N.Text != string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_cost_return_sales_year_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_cost_return_sales_year_Account_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_rerurn_sales_year_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_rerurn_sales_year_Account.ReadOnly == false && txt_A_N.Text != string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_rerurn_sales_year_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_rerurn_sales_year_Account_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_Earned_Discount_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_Earned_Discount_Account.ReadOnly == false && txt_A_N.Text != string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_Earned_Discount_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_Earned_Discount_Account_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_free_sales_cost_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_free_sales_cost_Account.ReadOnly == false && txt_A_N.Text != string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_free_sales_cost_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_free_sales_cost_Account_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_rerurn_free_sales_Account_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_rerurn_free_sales_Account.ReadOnly == false && txt_A_N.Text != string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_rerurn_free_sales_Account.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_rerurn_free_sales_Account_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txt_cost_of_free_purchases_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_cost_of_free_purchases.ReadOnly == false && txt_A_N.Text != string.Empty)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = " where Type_ID=2 and ";
                string sql = " SELECT top 20 Account_ID,A_N ,E_N FROM [dbo].[AC_Account]  ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_cost_of_free_purchases.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_cost_of_free_purchases.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void textBox1_Validating(object sender,
                  System.ComponentModel.CancelEventArgs e)
        {
           
        }
        ErrorProvider errorProvider = new System.Windows.Forms.ErrorProvider();

        private void textBox1_Validated(object sender, System.EventArgs e)
        {
          
        }
        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "email address must be valid email address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }

        private void txt_INV_Account_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_salse_Account_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            if (form_sev(this) == false)
            {
                Prodtct.P_Insert_into_Product_Category(
                                  txt_id.Text
                                   , txt_A_N.Text,
                               txt_E_N.Text, Convert.ToInt32(txt_INV_Account.Text),
                                 txt_salse_Account.Text,
                                   txt_cost_of_sales_Account.Text,
                                   txt_rerurn_sales_Account.Text, txt_rerurn_sales_Account.Text,
                                   txt_Discount_Alloewed_Account.Text,
                                   txt_cost_return_sales_year_Account.Text,
                                   txt_rerurn_sales_year_Account.Text,
                                   txt_Earned_Discount_Account.Text,
                                   txt_free_sales_cost_Account.Text,
                                   txt_rerurn_free_sales_Account.Text,
                                   txt_cost_of_free_purchases.Text
                                   );
            }
           
               
            
        }

        private void txt_INV_Account_Leave(object sender, EventArgs e)
        { 
            BL.Account_Class Account=new BL.Account_Class();
            txt_INV_Account_A_N.Text = Account.get_account(txt_INV_Account.Text)["A_N"].ToString();
        }

    }
}
