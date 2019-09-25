using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace trader_app.PL.INV
{
    public partial class frm_Product : PL.add_form
    {
        BL.Product_Class Product = new BL.Product_Class();
        DAL.Databas_Class DB = new DAL.Databas_Class();
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        BL.process_Class proc = new BL.process_Class();
        public frm_Product()
        {
            InitializeComponent();
        }

        private void frm_Product_Load(object sender, EventArgs e)
        {
            txt_id.ReadOnly = false;

            DB.LoadCombo(cbx_Product_Category, "select [Category_ID] , [Category_ID] + '-' +A_N as A_N  from INV_Product_Category ", "A_N", "Category_ID");
            
            DB.LoadCombo(cbx_Product_Type, "select [Type_ID] ,convert(nvarchar,[Type_ID]) +'-'+ [A_N] as A_N from [AM_Product_Type] ", "A_N", "Type_ID");
            DB.LoadCombo(cbx_Units, "select Units_ID , A_N from [AM_Units]", "A_N", "Units_ID");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_view_mov_Click(object sender, EventArgs e)
        {
            dgv1.View.DataSource = Product.select_Movment_peoduc(txt_Product_Parent_ID.Text, dtb_frm.Value.ToString("yyyy-MM-dd"), dtb_to.Value.ToString("yyyy-MM-dd"),txt_Amount.Text);
        }

        private void frm_Product_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            if (txt_Product_Parent_ID.Text == string.Empty)
                txt_Product_Parent_ID.Text = txt_id.Text;

            Product.P_INV_Insert_Products(
                txt_id.Text
                ,txt_Product_Parent_ID.Text,
                txt_Bracod_num.Text,
                txt_Amount.Text,
                txt_A_N.Text,
                txt_E_N.Text, cbx_Units.SelectedValue.ToString(),
                txt_Disc.Text
                , txt_Opening_stock.Text
                , txt_cost.Text
                , txt_default_price.Text
                , Convert.ToInt32(txt_request.Text)
                , Convert.ToInt32(txt_Up_request.Text)
                , Convert.ToInt32(txt_down_request.Text)
                , cbx_Product_Category.SelectedValue.ToString()
                , Convert.ToInt32(cbx_Product_Type.SelectedValue.ToString())
                , txt_Disc.Text
                , chbx_booked.Checked
                , chbx_Service_category.Checked
                , chbx_stop.Checked
                , proc.Insert_image_to_db(pic_product)

                );

            foreach (DataGridViewRow row in dgv_Units.Rows)
            {

                
                if (row.Cells["off"].Value == DBNull.Value)
                {
                    row.Cells["off"].Value =false;
                }
                if (row.Cells["P_ID"].Value != null)
                {
                    Product.P_INV_Insert_Products(
                 row.Cells["P_ID"].Value.ToString(),
                 txt_id.Text,
                 row.Cells["P_barcod"].Value.ToString(),
                row.Cells["Amount"].Value.ToString(),
                 txt_A_N.Text,
                 txt_E_N.Text, row.Cells["Units"].Value.ToString(),
                 txt_Disc.Text
                 , txt_Opening_stock.Text
                 , txt_cost.Text
                 , txt_default_price.Text
                 , Convert.ToInt32(txt_request.Text)
                 , Convert.ToInt32(txt_Up_request.Text)
                 , Convert.ToInt32(txt_down_request.Text)
                 , cbx_Product_Category.SelectedValue.ToString()
                 , Convert.ToInt32(cbx_Product_Type.SelectedValue.ToString())
                 , txt_Disc.Text
                 , chbx_booked.Checked
                 , chbx_Service_category.Checked
                 , Convert.ToBoolean( row.Cells["off"].Value)
                 , null

                 );
                }

            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_E_N.ReadOnly = txt_A_N.ReadOnly = false;

        }

        private void cbx_Product_Category_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_id.Text = cbx_Product_Category.SelectedValue.ToString();
            }
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم المنتج");
            list_C_N.Add(100, "اسم المنتج");

            string sql = "SELECT Product_ID ,A_N +'-'+Units_ID as A_N FROM [dbo].INV_Products ";
            PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
            //frm.textBox1.Text ="001-001";
           
            frm.ShowDialog();
            txt_id.Text = frm.dataGridView1.CurrentRow.Cells["Product_ID"].Value.ToString();
            view_data();
        }
        private void view_data()
        {

            DB = new DAL.Databas_Class();

            DataRow INV_Info = DB.select_Row(this.Tag.ToString(), txt_id.Tag.ToString(), "'"+txt_id.Text+"'");
            if (INV_Info != null)
            {


                txt_A_N.Text = INV_Info["A_N"].ToString();
                txt_E_N.Text = INV_Info["E_N"].ToString();
                txt_Product_Parent_ID.Text = INV_Info["Product_Parent_ID"].ToString();
                txt_Bracod_num.Text = INV_Info["Bracod_num"].ToString();
                txt_Amount.Text = INV_Info["Amount"].ToString();
                txt_A_N.Text = INV_Info["A_N"].ToString();
                txt_E_N.Text = INV_Info["E_N"].ToString();
                txt_Disc.Text = INV_Info["Disc"].ToString();
                txt_Opening_stock.Text = INV_Info["Opening_stock"].ToString();
                cbx_Units.SelectedValue = INV_Info["Units_ID"].ToString();
                txt_cost.Text = INV_Info["cost"].ToString(); 
                txt_default_price.Text = INV_Info["default_price"].ToString();
                txt_request.Text = INV_Info["request"].ToString();
                txt_Up_request.Text = INV_Info["Up_request"].ToString(); 
                txt_down_request.Text = INV_Info["down_request"].ToString();
              cbx_Product_Category.SelectedValue= INV_Info["Category_ID"].ToString();
                cbx_Product_Type.SelectedValue = INV_Info["Type_ID"].ToString(); 
                txt_Manufacturing_number.Text = INV_Info["Manufacturing_number"].ToString();
                if (INV_Info["booked"] != DBNull.Value)
                {
                    chbx_booked.Checked = Convert.ToBoolean(INV_Info["booked"]);
                }
                
                if (INV_Info["Service_category"] != DBNull.Value)
                {
                    chbx_Service_category.Checked = Convert.ToBoolean(INV_Info["Service_category"]);
                }
                if (INV_Info["stop"] != DBNull.Value)
                {
                    chbx_stop.Checked = Convert.ToBoolean(INV_Info["stop"]);
                }
                proc.select_image_frim_db(pic_product, INV_Info,"Image");

                dgv_Units.Rows.Clear();
                dgv_Units.Visible = true;
                dgv_Units.Columns["P_ID"].ReadOnly = true;
                dgv_Units.Columns["Amount"].ReadOnly = true;
                dgv_Units.Columns["Units"].ReadOnly = true;
                dgv_Units.Columns["P_barcod"].ReadOnly = false;
               dgv_Units.Columns["off"].ReadOnly = false;
                if(txt_Product_Parent_ID.Text==txt_id.Text)
                {
                    DataTable dt = new DataTable();
                    dt = dal.FindDataSet("select Product_ID , Bracod_num ,Units_ID,Amount, stop from " + this.Tag + " where Product_ID <> '" + txt_id.Text + "' and Product_Parent_ID = '" + txt_id.Text+"'");
                    foreach (DataRow row in dt.Rows)
                    {
                        dal = new DAL.DataAccessLayer();
            
                      dgv_Units.Rows.Add(row["Product_ID"], row["Bracod_num"], row["Units_ID"], row["Amount"], row["stop"]);


                    }
                }
              
                    txt_Available.Text = (Convert.ToInt32(Product.Available_Punch(txt_Product_Parent_ID.Text)) / Convert.ToInt32(txt_Amount.Text)).ToString() + INV_Info["Units_ID"].ToString();
                    int s = (Convert.ToInt32(Product.Available_Punch(txt_Product_Parent_ID.Text)) % Convert.ToInt32(txt_Amount.Text));
                    if (s != 0)
                    {
                        txt_Available.Text += " و " + s.ToString() + DB.select_Row(this.Tag.ToString(), txt_id.Tag.ToString(), "'" + txt_Product_Parent_ID.Text + "'")["Units_ID"].ToString();
                    }

  
            }
        }

        private void txt_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                view_data();
            }
            if (e.KeyCode == Keys.F9)
            {
                search();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files|*.jpg;*.png";
            if (of.ShowDialog() == DialogResult.OK)
            {

                pic_product.Image = Image.FromFile(of.FileName);

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_Units_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_Units_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.F9 )
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رمز الوحدة");
                list_C_N.Add(150, "اسم الوحدة ");
              
                string wherestr = "where Units_ID <> N'"+cbx_Units.SelectedValue.ToString()+"' and ";
                string sql = " SELECT top 20 Units_ID ,A_N  FROM  [dbo].AM_Units ";
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                dgv_Units.CurrentRow.Cells["Units"].Value = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void dgv_Units_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {


                    dgv_Units.CurrentRow.Cells["P_ID"].Value = txt_id.Text + "-" +( (int)dgv_Units.CurrentRow.Index + 1).ToString();
                }
            }
            catch (Exception)
            {

                return;
            }
          
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbx_Units_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Units_Leave(object sender, EventArgs e)
        {
            
        }

        private void dgv_Units_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {


                dgv_Units.CurrentRow.Cells["P_ID"].Value = txt_id.Text + "-" + ((int)dgv_Units.CurrentRow.Index + 1).ToString();
            }

        }

        private void btn_view_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            view_data();
        }
    }
}