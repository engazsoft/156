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
using System.Data;


namespace trader_app.PL.Am
{
    public partial class frm_Managements :add_form
    {
        DAL.DataAccessLayer dal ;
        DataTable dt;
        BL.process_Class proc = new BL.process_Class();
        BL.AM_Managements_Class Managements = new BL.AM_Managements_Class();
        public frm_Managements()
        {
            InitializeComponent();
        }

        private void frm_Managements_Load(object sender, EventArgs e)
        {
            txt_id.ReadOnly = false;
        }

        private void view_data()
        {
            
            dt = new DataTable();
            dal = new DAL.DataAccessLayer();
           string sql = "SELECT  * from " + this.Tag.ToString() + "  where "+txt_id.Tag.ToString()+" =" + txt_id.Text;
            if(txt_id.Text !=string.Empty)
            {
                dt = dal.FindDataSet(sql);


                if (dt != null)
                {
                    txt_A_N.Text = dt.Rows[0]["A_N"].ToString();
                    txt_E_N.Text = dt.Rows[0]["E_N"].ToString();
                    txt_in_date.Text = dt.Rows[0]["in_date"].ToString();
                    txt_edit_date.Text = dt.Rows[0]["edit_date"].ToString();
                    txt_edit_user.Text = dt.Rows[0]["edit_user"].ToString();
                    txt_by_user.Text = dt.Rows[0]["by_user"].ToString();
                    txt_location.Text = dt.Rows[0]["Location"].ToString();
                }

            }





        }
        private void search_data()
        {
            string sql = "SELECT " + txt_id.Tag.ToString() + " as الرقم ,[A_N] as الاسم ,[E_N] as الاسم_الاجنبي FROM [trader_db].[dbo]." + this.Tag.ToString();
            PL.Am.Form_Search frm = new PL.Am.Form_Search(sql);
            frm.MdiParent = this.MdiParent;
            frm.ShowDialog();
            txt_id.Text = frm.dataGridView1.CurrentRow.Cells["الرقم"].Value.ToString();
            view_data();
        }
        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            Managements.p_AM_insert_Managements(Convert.ToInt32(txt_id.Text), txt_A_N.Text, txt_E_N.Text, txt_location.Text);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text = proc.max_num_in_Column(this.Tag.ToString(), txt_id.Tag.ToString());
            if (txt_id.Text.Length == 0)
                txt_id.Text = 1.ToString();
            txt_id.ReadOnly = true;
          
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search_data();
        }
    }
}
