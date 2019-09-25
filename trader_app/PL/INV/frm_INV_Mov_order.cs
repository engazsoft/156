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
    public partial class frm_INV_Mov_order : order_frm
    {
        DAL.DataAccessLayer dal; 
        BL.process_Class proc = new BL.process_Class();
        DAL.Databas_Class DB = new DAL.Databas_Class();
        BL.INV_Inventory_Class Inventory = new BL.INV_Inventory_Class();
        BL.Product_Class Product = new BL.Product_Class();
        BL.AC_instrument instrumrnt = new BL.AC_instrument();
        DataRow from_inv;
        DataRow to_inv;
        
        string type_id,F_Name;
        public frm_INV_Mov_order()
        {
            type_id = "1";
            InitializeComponent();
        }
        public frm_INV_Mov_order(string type_id,string F_Name)
        {
            this.type_id = type_id;
            this.F_Name = F_Name.ToString();
           InitializeComponent();
        }
        private void frm_INV_order_Load(object sender, EventArgs e)
        {
            DB.LoadCombo(cbx_Inv_from, "select Invontory_ID,convert(nvarchar,Invontory_ID)+'-'+Inventory_A_N A_N from [INV_Inventorys]", "A_N", "Invontory_ID");
            DB.LoadCombo(cbx_cost_canter, "select Cost_Center_ID,convert(nvarchar,Cost_Center_ID)+'-'+A_N A_N from AC_Cost_Center", "A_N", "Cost_Center_ID");
            txt_id.ReadOnly = false;
            this.Text = F_Name;
            txt_tran_Num.ReadOnly = false;
            if(type_id==2.ToString())
            {
                cbx_inv_to.Enabled = false;
                label_to.Text = "رقم المخزن";
                label_from.Text = "المخزن المحول منة";
                dgv_mov_line.ReadOnly = true;
            }



        }

      

        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
        }
        private void view_data()
        {

            DB = new DAL.Databas_Class();

            DataRow Mov_ord = DB.select_Row(this.Tag.ToString(), txt_id.Tag.ToString(), txt_id.Text, "Documant_Type_ID",type_id);
            if (Mov_ord != null)
            {


                cbx_Inv_from.SelectedValue = Mov_ord["Invontory_ID"].ToString();
                cbx_inv_to.SelectedValue = Mov_ord["Invontory_dis_ID"].ToString();
                cbx_cost_canter.SelectedValue = Mov_ord["Cost_center"].ToString();
                

                txt_edit_user.Text = Mov_ord["edit_user"].ToString();
                txt_by_user.Text = Mov_ord["by_user"].ToString();
                txt_edit_date.Text = Mov_ord["edit_date"].ToString();
                txt_in_date.Text = Mov_ord["in_date"].ToString();
                txt_tran_Num.Text = Mov_ord["Invontory_dis_ID"].ToString();
                DataTable dt = new DataTable();
                dal = new DAL.DataAccessLayer();
              dgv_mov_line.Rows.Clear();
                dt = dal.FindDataSet("select *from v_product_mov where type_ID="+type_id+" and Movmant_ID=" + DB.select_Row(this.Tag.ToString(), "Movmant_num", txt_id.Text, "Documant_Type_ID", type_id + " and FYear=" + PL.main.Fyear)["ID"]);
               // dgv_mov_line.DataSource = null;
                foreach (DataRow row in dt.Rows)
                {
                    dal = new DAL.DataAccessLayer();
                  
                    if (type_id == 1.ToString())
                    {
                        dgv_mov_line.Rows.Add(row["line_num"], row["product_ID"], row["A_N"], row["disc"], row["Units_ID"], row["Quantity_out"]);
                    }
                    else
                        dgv_mov_line.Rows.Add(row["line_num"], row["product_ID"], row["A_N"], row["disc"], row["Units_ID"], row["Quantity"]);


                }

            }
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "<جديد>")
            txt_id.Text = instrumrnt.instr_num(type_id);
            instrumrnt.P_AC_insert_instrument(Convert.ToInt32(txt_id.Text),Convert.ToInt32( type_id), dtb_mov_date.Value.ToString("yyyy-MM-dd"), true,
                       txt_Note.Text, chbx_deported.Checked, chbx_stope.Checked, Convert.ToInt32(cbx_cost_canter.SelectedValue.ToString()),
                       txt_refer_num.Text, txt_tran_Num.Text,"YER",from_inv["Account_ID"].ToString(), true);
            instrumrnt.P_INV_insert_tr_inv(Convert.ToInt32(txt_id.Text), Convert.ToInt32(type_id), Convert.ToInt32(cbx_Inv_from.SelectedValue.ToString()), Convert.ToInt32(cbx_inv_to.SelectedValue.ToString()), 0, 0);
            
            if(type_id==1.ToString())
            {
                foreach (DataGridViewRow row in dgv_mov_line.Rows)
                {
                    if (row.Cells["product_ID"].Value != null)
                    {
                        instrumrnt.p_INV_insert_Product_Movmant_Line(Convert.ToInt32(txt_id.Text), Convert.ToInt32(type_id), row.Index + 1, row.Cells["product_ID"].Value.ToString(), 0, row.Cells["Unit"].Value.ToString(), 0, Convert.ToDecimal(row.Cells["Quantity"].Value));
                    }

                }
            }
            if (type_id == 2.ToString())
            {
                foreach (DataGridViewRow row in dgv_mov_line.Rows)
                {
                    if (row.Cells["product_ID"].Value != null)
                    {
                        instrumrnt.p_INV_insert_Product_Movmant_Line(Convert.ToInt32(txt_id.Text), 2, row.Index + 1, row.Cells["product_ID"].Value.ToString(), Convert.ToDecimal(row.Cells["cost"].Value), row.Cells["Unit"].Value.ToString(), Convert.ToDecimal(row.Cells["Quantity"].Value), 0);
       
                    }

                }
                if(txt_tran_Num.Text!=string.Empty)
                dal.Executecommade("Update INV_Product_Movmant set receved=1 where ID=" + DB.select_Row(this.Tag.ToString(), "Movmant_num", txt_tran_Num.Text, "Documant_Type_ID", 1.ToString() + " and FYear=" + PL.main.Fyear)["ID"]);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text = "<جديد>";
            txt_id.ReadOnly = true;
            dgv_mov_line.Rows.Clear();
        }

       

        private void dgv_mov_line_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
          
                if (e.ColumnIndex == 1)
                {
             //   dgv_mov_line.CurrentRow.Cells.Clear();
                DataRow product_rows = DB.select_Row("INV_Products", "Product_ID", "'" + dgv_mov_line.CurrentRow.Cells["product_ID"].Value.ToString() + "'");
               //try
               // {
                    if (product_rows!=null)
                    {
                        string s = Product.Available_Punch(cbx_Inv_from.SelectedValue.ToString(), product_rows["Product_Parent_ID"].ToString() ,product_rows["Amount"].ToString());
                        if (Convert.ToDecimal(s) > 0)
                        {
                            dgv_mov_line.CurrentRow.Cells["product_ID"].Value = product_rows["Product_ID"];
                            dgv_mov_line.CurrentRow.Cells["A_N"].Value = product_rows["A_N"];
                            dgv_mov_line.CurrentRow.Cells["Product_disc"].Value = product_rows["Disc"];
                            dgv_mov_line.CurrentRow.Cells["Unit"].Value = product_rows["Units_ID"];
                            dgv_mov_line.ClearSelection();

                            dgv_mov_line.CurrentRow.Cells["Quantityin"].Value = s;
                            dgv_mov_line.CurrentRow.Cells["Quantityin"].Selected = true;

                        }
                        else
                        {
                            MessageBox.Show("الصنف غير موجود في هذا الخزن");
                            dgv_mov_line.CurrentRow.Cells["product_ID"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["A_N"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["Product_disc"].Value ="";
                            dgv_mov_line.CurrentRow.Cells["Unit"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["Quantityin"].Value = "";
                           
                        }
                            
                    }

                  
              
     
            

            }
        
        }

        private void dgv_mov_line_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (e.ColumnIndex == 1)
                //{
                //    DataGridViewComboBoxCell c = new DataGridViewComboBoxCell();

                //    c.DataSource = dal.FindDataSet("select * from v_product_unit where Product_ID=" + dgv_mov_line.CurrentRow.Cells["product_ID"].Value.ToString());
                //    c.DisplayMember = "Unts_A_N";
                //    c.ValueMember = "Unts_ID";
                //    dgv_mov_line.CurrentRow.Cells["Unit"] = c;
                //}
            }
            catch (Exception)
            {

                return;
            }
           
        }

    

        private void frm_INV_Mov_order_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void dgv_mov_line_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbx_Inv_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            from_inv = DB.select_Row("INV_Inventorys", "Invontory_ID",cbx_Inv_from.SelectedValue.ToString());
            DB.LoadCombo(cbx_inv_to, "select Invontory_ID,Inventory_A_N from [INV_Inventorys] where Invontory_ID <> " + cbx_Inv_from.SelectedValue.ToString(), "Inventory_A_N", "Invontory_ID");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbx_Inv_from.SelectedValue.ToString() != 0.ToString())
            {
                DataTable dt = new DataTable();
                dal = new DAL.DataAccessLayer();
                dgv_mov_line.Rows.Clear();
                // dt = dal.FindDataSet("select *from v_product_mov where type_ID=" + type_id + " and Movmant_ID=" + DB.select_Row(this.Tag.ToString(), "Movmant_num", txt_id.Text, "Documant_Type_ID", type_id + " and FYear=" + PL.main.Fyear)["ID"]);

                dt = dal.FindDataSet("select *from v_product_mov where" +
                    " type_ID=" + 1.ToString() +
                    " and receved =0" +
                    " and  to_inv =" + cbx_Inv_from.SelectedValue.ToString() + " " +
                    "and Movmant_ID=" + DB.select_Row(this.Tag.ToString(), "Movmant_num", txt_tran_Num.Text, "Documant_Type_ID", 1.ToString() + " and FYear=" + PL.main.Fyear)["ID"]);
       
                if (dt.Rows.Count > 0)
                {
                    cbx_inv_to.SelectedValue = dt.Rows[0]["from_inv"].ToString();
                    foreach (DataRow row in dt.Rows)
                    {
                        dal = new DAL.DataAccessLayer();
                        // if (row["Invontory_dis_ID"].ToString() == cbx_Inv_from.SelectedValue.ToString())

                        dgv_mov_line.Rows.Add(row["line_num"], row["product_ID"], row["A_N"], row["disc"], row["Units_ID"], row["Quantity_out"]);


                    }
                }
            }
       else
            {
                MessageBox.Show("اختار رقم الخزن").ToString();
               
            }
            // dgv_mov_line.DataSource = null;
           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
             Statu="0";
        }

        private void dgv_mov_line_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgv_mov_line.CurrentCell == dgv_mov_line.CurrentRow.Cells["product_ID"])
            {
                if (e.KeyCode == Keys.Tab)
                {
                    try
                    {
                        DB = new DAL.Databas_Class();
                        DataRow product_rows = DB.select_Row("INV_Products", "Product_ID", "'" + dgv_mov_line.CurrentRow.Cells["product_ID"].Value.ToString() + "'");
                        dgv_mov_line.CurrentRow.Cells["A_N"].Value = product_rows["product_A_N"];
                        dgv_mov_line.CurrentRow.Cells["Product_disc"].Value = product_rows["Disc"];
                        dgv_mov_line.CurrentRow.Cells["Unit"].Value = product_rows["Units_ID"];


                    }
                    catch (Exception)
                    {
                       
                       
                        Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                        list_C_N.Add(50, "رقم المنتج");
                        list_C_N.Add(100, "اسم المنتج");

                        string sql = "SELECT Product_ID ,A_N +'-'+Units_ID as A_N FROM [dbo].INV_Products ";
                        PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);
               

                        frm.ShowDialog();
                        DataRow product_rows = DB.select_Row("INV_Products", "Product_ID", "'" + frm.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
                        string s = Product.Available_Punch(cbx_Inv_from.SelectedValue.ToString(), product_rows["Product_Parent_ID"].ToString(), product_rows["Amount"].ToString());
                        if (Convert.ToDecimal(s) > 0)
                        {
                            dgv_mov_line.CurrentRow.Cells["product_ID"].Value = product_rows["Product_ID"];
                            dgv_mov_line.CurrentRow.Cells["A_N"].Value = product_rows["A_N"];
                            dgv_mov_line.CurrentRow.Cells["Product_disc"].Value = product_rows["Disc"];
                            dgv_mov_line.CurrentRow.Cells["Unit"].Value = product_rows["Units_ID"];
                            dgv_mov_line.ClearSelection();

                            dgv_mov_line.CurrentRow.Cells["Quantityin"].Value = s;

                        }
                        else
                        {
                            MessageBox.Show("الصنف غير موجود في هذا الخزن");
                            dgv_mov_line.CurrentRow.Cells["product_ID"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["A_N"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["Product_disc"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["Unit"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["Quantityin"].Value = "";

                        }

                    }
                    MessageBox.Show("Ok");
                }
                if (e.KeyCode == Keys.F9    )
                {
                    try
                    {
                        DB = new DAL.Databas_Class();
                        DataRow product_rows = DB.select_Row("INV_Products", "Product_ID", "'" + dgv_mov_line.CurrentRow.Cells["product_ID"].Value.ToString() + "'");
                        dgv_mov_line.CurrentRow.Cells["A_N"].Value = product_rows["product_A_N"];
                        dgv_mov_line.CurrentRow.Cells["Product_disc"].Value = product_rows["Disc"];
                        dgv_mov_line.CurrentRow.Cells["Unit"].Value = product_rows["Units_ID"];


                    }
                    catch (Exception)
                    {


                        Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                        list_C_N.Add(50, "رقم المنتج");
                        list_C_N.Add(100, "اسم المنتج");

                        string sql = "SELECT Product_ID ,A_N +'-'+Units_ID as A_N FROM [dbo].INV_Products ";
                        PL.Am.Form_Search frm = new Am.Form_Search(sql, list_C_N);


                        frm.ShowDialog();
                        DataRow product_rows = DB.select_Row("INV_Products", "Product_ID", "'" + frm.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
                        string s = Product.Available_Punch(cbx_Inv_from.SelectedValue.ToString(), product_rows["Product_Parent_ID"].ToString(), product_rows["Amount"].ToString());
                        if (Convert.ToDecimal(s) > 0)
                        {
                            dgv_mov_line.CurrentRow.Cells["product_ID"].Value = product_rows["Product_ID"];
                            dgv_mov_line.CurrentRow.Cells["A_N"].Value = product_rows["A_N"];
                            dgv_mov_line.CurrentRow.Cells["Product_disc"].Value = product_rows["Disc"];
                            dgv_mov_line.CurrentRow.Cells["Unit"].Value = product_rows["Units_ID"];
                            dgv_mov_line.ClearSelection();

                            dgv_mov_line.CurrentRow.Cells["Quantityin"].Value = s;

                        }
                        else
                        {
                            MessageBox.Show("الصنف غير موجود في هذا الخزن");
                            dgv_mov_line.CurrentRow.Cells["product_ID"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["A_N"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["Product_disc"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["Unit"].Value = "";
                            dgv_mov_line.CurrentRow.Cells["Quantityin"].Value = "";

                        }

                    }
                    
                }
            }
        }

        private void dgv_mov_line_Enter(object sender, EventArgs e)
        {
            if (cbx_Inv_from.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("اختار رقم المخزن");
                cbx_Inv_from.Focus();
                return;
            }
            if (cbx_inv_to.SelectedValue  == "0")
            {
                MessageBox.Show("اختار الحساب");
                cbx_inv_to.Focus();
                return;
            }
        }

    }
}
