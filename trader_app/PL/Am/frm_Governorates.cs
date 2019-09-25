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
    public partial class frm_Governorates : PL.add_form
    {
        DAL.Databas_Class DB= new DAL.Databas_Class();
        BL.process_Class proc =new BL.process_Class();
        BL.AM_Governorate_Class Govetnorate = new BL.AM_Governorate_Class();
        public frm_Governorates()
        {
            InitializeComponent();
        }

        private void frm_Governorates_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_Country, "select Country_ID,Country_A_N from AM_Country", "Country_A_N", "Country_ID");
            txt_id.ReadOnly = false;
        }
        private void view_data()
        {

            DB = new DAL.Databas_Class();

            DataRow GOV_Info = DB.select_Row(this.Tag.ToString(),txt_id.Tag.ToString(), txt_id.Text);
            if (GOV_Info != null)
            {


                txt_A_N.Text = GOV_Info["A_N"].ToString();
                txt_E_N.Text = GOV_Info["E_N"].ToString();
                cbx_Country.SelectedValue = GOV_Info["Country_ID"].ToString();
                txt_edit_user.Text = GOV_Info["edit_user"].ToString();
                txt_by_user.Text = GOV_Info["by_user"].ToString();

    


              
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // DB.LoadCombo(Cbx_Govemotars, "select Gov_id,A_N from " + this.Tag.ToString() + " where Country_ID = " + cbx_Country.SelectedValue.ToString(), "A_N", "Gov_id");
           // view_data();
        }

        private void Cbx_Govemotars_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text=  proc.max_num_in_Column(this.Tag.ToString(), txt_id.Tag.ToString());
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            Govetnorate.P_AM_insert_Governorate(Convert.ToInt32( txt_id.Text),Convert.ToInt32( cbx_Country.SelectedValue), txt_A_N.Text, txt_A_N.Text);
        }

        private void label1_Click(object sender, EventArgs e)
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
            string sql = "SELECT  "+txt_id.Tag.ToString()+" as الرقم ,A_N as الاسم,E_N as الاسم_الاجنبي FROM [dbo]."+this.Tag.ToString()+" ";
            PL.Am.Form_Search frm = new Am.Form_Search(sql);
         
            frm.ShowDialog();
            txt_id.Text = frm.dataGridView1.CurrentRow.Cells["الرقم"].Value.ToString();
            view_data();
        }

        private void frm_Governorates_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }
    }
}
