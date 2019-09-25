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

    public partial class Form_Inventory_group : PL.add_form
    {
        BL.INV_inventory_group inv_group = new BL.INV_inventory_group();
        DataTable dt;
        public Form_Inventory_group()
        {
            InitializeComponent();

        }

        private void Form_Inventory_group_Load(object sender, EventArgs e)
        {
            Color c = new Color();
         //   this.groupBox1.Controls.OfType<TextBox>().All(tb => tb.ReadOnly = true);
            // this.groupBox1.Controls.OfType<TextBox>().All(tb => tb.BackColor=Color.White) ;
            foreach (Control control in this.Controls)
            {
                foreach (Control control1 in control.Controls)
                {
                    if (control1 is TextBox)
                        (control1 as TextBox).BackColor = Color.White;
                }
               
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbx_inventory_group_DropDown(object sender, EventArgs e)
        {
            cbx_inventory_group.DataSource = inv_group.p_INV_Get_inventory_group();
            cbx_inventory_group.DisplayMember = "Inventory_Group_ID";
            cbx_inventory_group.ValueMember = "Inventory_Group_ID";
            cbx_inventory_group.SelectedIndex = -1;
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            inv_group.p_INV_Insert_inventory_group(Convert.ToInt32(cbx_inventory_group.Text), txt_A_N.Text, txt_E_N.Text, 0, "null");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //if(cbx_inventory_group.SelectedItem is true)
            //txt_A_N.ReadOnly = txt_E_N.ReadOnly = false;

        }

        private void btn_view_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = inv_group.p_INV_Get_inventory_group();
            if (cbx_inventory_group.SelectedValue != null)
            {

                DataRow[] r = dt.Select("Inventory_Group_ID= " + cbx_inventory_group.SelectedValue.ToString()+"");

                txt_A_N.Text = r[0]["Group_A_N"].ToString();
                txt_E_N.Text = r[0]["Group_A_E"].ToString();
                txt_by_user.Text = r[0]["py_user"].ToString();
                txt_in_date.Text = r[0]["in_date"].ToString();
                txt_edit_user.Text = r[0]["py_user"].ToString();
                txt_edit_date.Text = r[0]["edit_date"].ToString();
            }
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            Dictionary<int,string> list_C_N=new Dictionary<int,string>();
            list_C_N.Add(50,"الرقم");
            list_C_N.Add(150,"الاسم ");
            list_C_N.Add(151,"الاسم الاجنبي");
            string sql = " SELECT top 20 date,A_ND ,E_ND FROM [dbo].AM_Date ";
            PL.Am.Form_Search frm = new Am.Form_Search(sql,list_C_N) ;
           
            frm.ShowDialog();

           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_A_N.Clear();
            txt_edit_date.Clear();
            txt_edit_user.Clear();
            txt_E_N.Clear();
            txt_in_date.Clear();
            txt_by_user.Clear();
            cbx_inventory_group.Text = null;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_inventory_group_DropDown_1(object sender, EventArgs e)
        {
            cbx_inventory_group.DataSource = inv_group.p_INV_Get_inventory_group();
            cbx_inventory_group.DisplayMember = "Inventory_Group_ID";
            cbx_inventory_group.ValueMember = "Inventory_Group_ID";
            cbx_inventory_group.SelectedIndex = -1;
        }
    }
    }



