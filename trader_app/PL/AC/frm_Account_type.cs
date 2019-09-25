using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trader_app.PL.AC
{

    public partial class frm_Account_type :PL.add_form
    {
        BL.Account_Class account = new BL.Account_Class();
        BL.process_Class proc = new BL.process_Class();
        DataTable dt;
        DAL.DataAccessLayer dal;
        public frm_Account_type()
        {
            InitializeComponent();
        }

        private void frm_Account_type_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            account.p_AC_insert_Account_type(Convert.ToInt32(txt_id.Text), txt_A_N.Text, txt_E_N.Text, chbx_Affected_by_operations.Checked);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          txt_id.Text=  proc.max_num_in_Column("AC_Account_type", "Type_ID");
            if (txt_id.Text.Length == 0)
                txt_id.Text = 1.ToString();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
        }

        private void txt_type_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                search_data();
            }
        }
        private void search_data()
        {
            
            string sql = "SELECT  [Type_ID] as الرقم ,[A_N] as الاسم,[E_N] as الاسم_الاجنبي FROM [trader_db].[dbo].[AC_Account_type]";
            
            PL.Am.Form_Search frm = new PL.Am.Form_Search(sql);
            frm.MdiParent = this.MdiParent;
            frm.ShowDialog();

            txt_id.Text = frm.dataGridView1.CurrentRow.Cells["الرقم"].Value.ToString();
            view_data();
        }
        private void view_data()
        {
            dt = new DataTable();
            dal = new DAL.DataAccessLayer();
            dt = dal.FindDataSet("SELECT  [Type_ID] ,[A_N] ,[E_N] ,[Affected_by_operations],[edit_date] ,[edit_user]  ,[in_date],[by_user] FROM [trader_db].[dbo].[AC_Account_type] where Type_ID="+txt_id.Text);

            if (dt.Rows.Count > 0)
            {

                txt_A_N.Text = dt.Rows[0]["A_N"].ToString();
                txt_E_N.Text = dt.Rows[0]["E_N"].ToString();

                txt_in_date.Text = dt.Rows[0]["in_date"].ToString();
                txt_edit_date.Text = dt.Rows[0]["edit_date"].ToString();
                txt_edit_user.Text = dt.Rows[0]["edit_user"].ToString();
                txt_by_user.Text = dt.Rows[0]["by_user"].ToString();
                if (dt.Rows[0]["Affected_by_operations"] != DBNull.Value)
                    chbx_Affected_by_operations.Checked = Convert.ToBoolean(dt.Rows[0]["Affected_by_operations"]);
              
            }
        }
        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search_data();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
