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
    public partial class Frm_Employees : PL.add_form
    {
        DAL.DataAccessLayer dal;
        DataTable dt;
        BL.Account_Class account = new BL.Account_Class();
        BL.process_Class proc = new BL.process_Class();
        BL.AM_Employees_Class Employee = new BL.AM_Employees_Class();
        DAL.Databas_Class DB = new DAL.Databas_Class();
        public Frm_Employees()
        {
            InitializeComponent();
        }

        private void Frm_Employees_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_mangment, "select Management_ID,A_N from AM_Managements", "A_N", "Management_ID");

            DB.LoadCombo(cbx_Qualified, "SELECT  [Code_ID]  ,[A_N] FROM [trader_db].[dbo].[AM_Codes] where type='qualification'", "A_N", "Code_ID");
            DB.LoadCombo(cbx_super_emp_id, "SELECT  Employee_ID  ,[A_N] FROM [trader_db].[dbo].[AM_Employees] ", "A_N", "Employee_ID");
            DB.LoadCombo(cbx_deleget, "SELECT  [Delegate_ID]  ,[A_N] FROM [trader_db].[dbo].[AM_Delegates] ", "A_N", "Delegate_ID");
            txt_id.ReadOnly = false;
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search_data();
        }
        private void search_data()
        {

            string sql = "SELECT " + txt_id.Tag.ToString() +" as الرقم ,[A_N] as الاسم ,[E_N] as الاسم_الاجنبي FROM [trader_db].[dbo]."+this.Tag.ToString();
            PL.Am.Form_Search frm = new PL.Am.Form_Search(sql);
           
            frm.ShowDialog();
            txt_id.Text = frm.dataGridView1.CurrentRow.Cells["الرقم"].Value.ToString();
            view_data();

        }
        private void view_data()
        {
            dt = new DataTable();
            dal = new DAL.DataAccessLayer();   
            dt = dal.FindDataSet("select * from AM_Employees where  Employee_ID=" + txt_id.Text);
           // "[Employee_ID],[A_N] ,[E_N] ,[Management_ID] ,[Job]   ,[super_Employee_ID] ,[Hier_Date]  ,[Salary]   ,[Qualified_ID]  ,[Phone_num] ,[Phone_num_1]     ,[Out_Serves_Date]   ,[Email]  ,[Address] ,[Delegate_ID] ,[Stop] 
            if (dt.Rows.Count > 0)
            {
               // ,[Reason_of_Stop]  ,[Stop_Date] ,[Note]  ,[edit_date]  ,[in_date] ,[by_user] ,[edit_user]"
                txt_A_N.Text = dt.Rows[0]["A_N"].ToString();
                txt_E_N.Text = dt.Rows[0]["E_N"].ToString();
                cbx_mangment.SelectedValue = dt.Rows[0]["Management_ID"].ToString();
                txt_Job.Text=dt.Rows[0]["Job"].ToString();
                cbx_super_emp_id.SelectedValue = dt.Rows[0]["super_Employee_ID"].ToString();
                dtb_hier_data.Value=Convert.ToDateTime( dt.Rows[0]["Hier_Date"]) ;
                txt_Salary.Text = dt.Rows[0]["Salary"].ToString();
                cbx_Qualified.SelectedValue = dt.Rows[0]["Qualified_ID"].ToString();
                txt_phone.Text = dt.Rows[0]["Phone_num"].ToString();
                txt_phone.Text = dt.Rows[0]["Phone_num_1"].ToString();
                txt_Reason_of_Stop.Text = dt.Rows[0]["Out_Serves_Date"].ToString();
                txt_Email.Text = dt.Rows[0]["Email"].ToString();
                txt_address.Text = dt.Rows[0]["Address"].ToString();
                cbx_deleget.Text = dt.Rows[0]["Delegate_ID"].ToString();
                chbx_stop.Checked =Convert.ToBoolean( dt.Rows[0]["Stop"]);
                txt_Reason_of_Stop.Text = dt.Rows[0]["Reason_of_Stop"].ToString();
                dtb_stop_date.Value = Convert.ToDateTime(dt.Rows[0]["Stop_Date"]);
                txt_note.Text = dt.Rows[0]["Note"].ToString();

                txt_in_date.Text = dt.Rows[0]["in_date"].ToString();
                txt_edit_date.Text = dt.Rows[0]["edit_date"].ToString();
                txt_edit_user.Text = dt.Rows[0]["edit_user"].ToString();
                txt_by_user.Text = dt.Rows[0]["by_user"].ToString();
                //if (dt.Rows[0]["Affected_by_operations"] != DBNull.Value)
                //    chbx_Affected_by_operations.Checked = Convert.ToBoolean(dt.Rows[0]["Affected_by_operations"]);

            }
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            Employee.P_AM_insert_AM_Employees(
                Convert.ToInt32(txt_id.Text),
                txt_A_N.Text, txt_E_N.Text
                ,Convert.ToInt32(proc.Insert_com_to_db(cbx_mangment)),
                txt_Job.Text,
               Convert.ToInt32(proc.Insert_com_to_db(cbx_super_emp_id)),
                proc.Insert_DTB_to_db(dtb_hier_data),
                txt_Salary.Text,
               Convert.ToInt32( proc.Insert_com_to_db(cbx_Qualified)),
                txt_phone.Text,
                txt_phone_2.Text,
                proc.Insert_DTB_to_db(dtb_out_s_date),
                txt_Email.Text,
                txt_address.Text,
             Convert.ToInt32(proc.Insert_com_to_db(cbx_deleget)),
                chbx_stop.Checked,
                txt_Reason_of_Stop.Text,
                proc.Insert_DTB_to_db(dtb_stop_date),
                txt_note.Text
                );
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text = proc.max_num_in_Column("AM_Employees", "Employee_ID");
            if (txt_id.Text.Length == 0)
                txt_id.Text = 1.ToString();
            txt_id.ReadOnly = true;
            txt_Salary.Text = 0.ToString();
            
        }

        private void txt_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                search_data();
            }
            if(e.KeyCode==Keys.Enter)
            {
                view_data();
            }
        }
    }
}
