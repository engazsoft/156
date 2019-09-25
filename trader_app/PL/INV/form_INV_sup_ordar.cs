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
    public partial class form_INV_sup_ordar : PL.order_frm
    {
        DAL.DataAccessLayer dal;
        BL.process_Class proc = new BL.process_Class();
        DAL.Databas_Class DB = new DAL.Databas_Class();
        BL.INV_Inventory_Class Inventory = new BL.INV_Inventory_Class();
        BL.Product_Class Product = new BL.Product_Class();
        BL.Account_Class Account = new BL.Account_Class();
        BL.AC_instrument instrumrnt = new BL.AC_instrument();
        DataRow from_inv;
        DataRow to_inv;

        public form_INV_sup_ordar()
        {
            InitializeComponent();
            //txt_id.Focus();
        }
        AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
        private void form_INV_sup_ordar_Load(object sender, EventArgs e)
        {
            txt_id.Text = "<جديد>";
            txt_id.ReadOnly = false;
            DB.LoadCombo(cbx_Inv_from, "select Invontory_ID,convert(nvarchar,Invontory_ID)+'-'+Inventory_A_N A_N from [INV_Inventorys]", "A_N", "Invontory_ID");
            DB.LoadCombo(cbx_cost_canter, "select Cost_Center_ID,convert(nvarchar,Cost_Center_ID)+'-'+A_N A_N from AC_Cost_Center", "A_N", "Cost_Center_ID");
            DB.LoadCombo(cbx_insrt_form, "SELECT  [ID],CONVERT(nvarchar, [Type_num]) +'-'+[A_N] A_N FROM [trader_db].[dbo].[AM_Documant_Type] where Type='Product_Mov' or Type='0'", "A_N", "ID");
            //txt_Accout_ID.ControlAdded 


        }



        private void btn_add_Click(object sender, EventArgs e)
        {

            txt_id.Text = "<جديد>";
            txt_id.ReadOnly = true;
            dgv_mov_line.Rows.Clear();


        }



        private void txt_Accout_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 && txt_Accout_ID.ReadOnly == false)
            {

                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رقم الحساب");
                list_C_N.Add(150, "اسم الحساب ");
                list_C_N.Add(151, "الاسم الاجنبي");
                string wherestr = BL.select_query.where_accoun_Show;
                string sql = BL.select_query.sql_account_search;
                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                txt_Accout_ID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_Account_A_N.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                if (txt_Accout_ID.Text != string.Empty)
                {

                    DataRow dr = Account.get_account(txt_Accout_ID);
                    if (dr != null)
                    {
                        txt_Account_A_N.Text = dr["A_N"].ToString();
                        txt_Currency_key.Text = dr["Currency_key"].ToString();
                        txt_curr_exch_rate.Text = 1.ToString();
                        txt_curr_exch_rate_inv.Text = 1.ToString();
                        lb_curr_name.Text = dr["currency_name"].ToString();
                        txt_curr_exch_rate.Text = Convert.ToInt32(dr["curr_exch_rate"]).ToString();
                    }
                }
            }
        }

        private void txt_Accout_ID_Leave(object sender, EventArgs e)
        {
            if (DB.isselect_Row("AC_ACCOUNT_AN", "Account_ID", txt_Accout_ID.Text))
            {
                txt_num.Visible = true;

                txt_name.Visible = true;
                label_nem.Visible = true;

                label_num.Visible = true;
            }
            else
            {
                txt_num.Visible = false;
                txt_name.Visible = false;
                label_nem.Visible = false;

                label_num.Visible = false;
                txt_num.Text = "";
                txt_name.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Currency_key_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                list_C_N.Add(50, "رمز العملة");
                list_C_N.Add(150, "اسم العملة");

                string wherestr = BL.select_query.where_currency_show(txt_Accout_ID.Text, txt_num.Text);
                string sql = BL.select_query.sql_currency_search;

                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                if (frm.dataGridView1.CurrentRow != null)
                {
                    if (frm.dataGridView1.CurrentRow.Cells[0].Value.ToString() != null)
                        txt_Currency_key.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    lb_curr_name.Text = frm.dataGridView1.CurrentRow.Cells[1].ToString();
                }

            }



        }











        private void view_data()
        {

            DB = new DAL.Databas_Class();

            DataRow inst_infO = instrumrnt.selec_inst_Row(this.Tag.ToString(), txt_id.Text, "3");


            if (inst_infO != null)
            {
                DataRow mov_info = instrumrnt.selec_inst_Row("INV_Product_Movmant", txt_id.Text, "3");
                if (mov_info != null)
                {


                    cbx_Inv_from.SelectedValue = mov_info["Invontory_ID"].ToString();
                    dtb_mov_date.Value = Convert.ToDateTime(inst_infO["Instrument_Date"]);
                    cbx_cost_canter.SelectedValue = inst_infO["Cost_center"].ToString();
                    txt_Accout_ID.Text = inst_infO["Account_ID"].ToString();
                    txt_Account_A_N.Text = Account.get_account(txt_Accout_ID.Text)["A_N"].ToString();
                    txt_Currency_key.Text = inst_infO["Currency_Key"].ToString();
                    txt_edit_user.Text = inst_infO["edit_user"].ToString();
                    txt_by_user.Text = inst_infO["by_user"].ToString();
                    txt_edit_date.Text = inst_infO["edit_date"].ToString();
                    txt_in_date.Text = inst_infO["in_date"].ToString();

                    DataTable dt = new DataTable();
                    dal = new DAL.DataAccessLayer();
                    dgv_mov_line.Rows.Clear();
                    dt = dal.FindDataSet("select *from v_product_mov where Fyear=" + PL.main.Fyear + " and Inst_num=" + txt_id.Text + "and inst_type =3");
                    // dgv_mov_line.DataSource = null;
                    foreach (DataRow row in dt.Rows)
                    {
                        dal = new DAL.DataAccessLayer();

                        dgv_mov_line.Rows.Add(row["line_num"], row["product_ID"], row["A_N"], row["disc"], row["Units_ID"], row["UnitCost"], row["Quantitys"], Convert.ToDecimal(row["UnitCost"]) * Convert.ToDecimal(row["Quantitys"]));


                    }

                }
            }

        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            if (Statu == "1")
            {

                txt_id.Text = instrumrnt.instr_num("3");

                if (form_sev(this) == true)
                {
                    instrumrnt.P_AC_insert_instrument(Convert.ToInt32(txt_id.Text), 3, dtb_mov_date.Value.ToString("yyyy-MM-dd"), true,
                        txt_Note.Text, chbx_deported.Checked, chbx_stope.Checked, Convert.ToInt32(cbx_cost_canter.SelectedValue.ToString()),
                        txt_refer_num.Text, txt_tran_Num.Text, txt_Currency_key.Text, txt_Accout_ID.Text, true);
                    instrumrnt.P_INV_insert_Sup_order(Convert.ToInt32(txt_id.Text), Convert.ToInt32(cbx_Inv_from.SelectedValue.ToString()), 0, 0, txt_Car_num.Text, txt_Driver_A_N.Text);
                    foreach (DataGridViewRow row in dgv_mov_line.Rows)
                    {
                        if (row.Cells["product_ID"].Value != null)
                        {
                            instrumrnt.p_INV_insert_Product_Movmant_Line(Convert.ToInt32(txt_id.Text), 3, row.Index + 1, row.Cells["product_ID"].Value.ToString(), Convert.ToDecimal(row.Cells["cost"].Value), row.Cells["Unit"].Value.ToString(), Convert.ToDecimal(row.Cells["Quantity"].Value), 0);
                        }

                    }
                }


            }

            else
            {


                if (form_sev(this) == true)
                {
                    instrumrnt.P_AC_insert_instrument(Convert.ToInt32(txt_id.Text), 3, dtb_mov_date.Value.ToString("yyyy-MM-dd"), true,
                        txt_Note.Text, chbx_deported.Checked, chbx_stope.Checked, Convert.ToInt32(cbx_cost_canter.SelectedValue.ToString()),
                        txt_refer_num.Text, txt_tran_Num.Text, txt_Currency_key.Text, txt_Accout_ID.Text, false);
                }
                foreach (DataGridViewRow row in dgv_mov_line.Rows)
                {
                    if (row.Cells["product_ID"].Value != null)
                    {
                        instrumrnt.p_INV_insert_Product_Movmant_Line(Convert.ToInt32(txt_id.Text), 3, row.Index + 1, row.Cells["product_ID"].Value.ToString(), Convert.ToDecimal(row.Cells["cost"].Value), row.Cells["Unit"].Value.ToString(), Convert.ToDecimal(row.Cells["Quantity"].Value), 0);
                    }

                }
            }



        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Statu = "0";
            txt_Note.Text = Statu;
        }

        private void txt_Car_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_mov_line_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgv_mov_line.CurrentRow.Cells["Product_ID"].Selected = true;
            }
            if (dgv_mov_line.CurrentCell == dgv_mov_line.CurrentRow.Cells["product_ID"] || dgv_mov_line.CurrentCell == dgv_mov_line.CurrentRow.Cells["A_N"] || dgv_mov_line.CurrentCell == dgv_mov_line.CurrentRow.Cells[0])
            {


                if (e.KeyCode == Keys.F9)
                {
                    Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                    list_C_N.Add(50, "رقم المنتج");
                    list_C_N.Add(100, "اسم المنتج");



                    PL.Am.Form_Search frm = new Am.Form_Search("SELECT Product_ID ,A_N +'-'+Units_ID as A_N FROM INV_Products ", list_C_N);


                    frm.ShowDialog();
                    DataRow product_rows = DB.select_Row("INV_Products", "Product_ID", "'" + frm.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");


                    if (product_rows != null)
                    {

                        dgv_mov_line.CurrentRow.Cells["product_ID"].Value = product_rows["Product_ID"];
                        dgv_mov_line.CurrentRow.Cells["A_N"].Value = product_rows["A_N"];
                        dgv_mov_line.CurrentRow.Cells["Product_disc"].Value = product_rows["Disc"];
                        dgv_mov_line.CurrentRow.Cells["Unit"].Value = product_rows["Units_ID"];

                        dgv_mov_line.CurrentRow.Cells["Quantity"].Selected = true;



                    }
                }
            }
        }

        private void search_data()
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            // list_C_N.Add(50, "رقم امر التوريد");
            list_C_N.Add(49, "رقم الفرع");
            list_C_N.Add(100, "تارخ امر التوريد");
            list_C_N.Add(101, "المرجع");
            list_C_N.Add(48, "معلق");


            string sql = "SELECT inst_num, [Branch_ID],[Instrument_Date],[refer_num],[stops] FROM AC_instrument ";
            string wherestr = " where inst_type = '3' and FYear=YEAR(getdate()) and ";
            string order_by = " order by Instrument_Date Desc ";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
            //    frm.Size= new Size(140, 480);
            frm.ShowDialog();
            if (frm.dataGridView1.CurrentRow != null)
            {
                txt_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                view_data();
                frm_View(this);
            }
        }
        private void dgv_mov_line_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

                DB = new DAL.Databas_Class();
                DataRow product_rows = DB.select_Row("INV_Products", "Product_ID", "'" + dgv_mov_line.CurrentRow.Cells[1].Value.ToString() + "'");
                if (product_rows != null)
                {
                    dgv_mov_line.CurrentRow.Cells["Product_disc"].Value = product_rows["Disc"];
                    dgv_mov_line.CurrentRow.Cells["Unit"].Value = product_rows["Units_ID"];
                    dgv_mov_line.CurrentRow.Cells["A_N"].Value = product_rows["A_N"];

                }



            }
            if (e.ColumnIndex == 6)
            {


                dgv_mov_line.CurrentRow.Cells["sumcost"].Value = Convert.ToDecimal(dgv_mov_line.CurrentRow.Cells["Quantity"].Value) * Convert.ToDecimal(dgv_mov_line.CurrentRow.Cells["cost"].Value);
                Double sum = 0;
                foreach (DataGridViewRow row in dgv_mov_line.Rows)
                {
                    sum += Convert.ToDouble(row.Cells["sumcost"].Value);
                }

                txt_cost.Text = sum.ToString();


            }
        }

        private void dgv_mov_line_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cbx_Inv_from.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("اختار رقم المخزن");
                cbx_Inv_from.Focus();
                return;
            }
            if (txt_Account_A_N.Text == string.Empty)
            {
                MessageBox.Show("اختار الحساب");
                txt_Accout_ID.Focus();
                return;
            }
        }

        private void btn_insert_to_dg_Click(object sender, EventArgs e)
        {
            dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.FindDataSet("SELECT * FROM [trader_db].[dbo].[v_product_mov] where Inst_num =" + txt_tran_Num.Text + " and inst_type= " + cbx_insrt_form.SelectedValue.ToString() + " and FYear =" + PL.main.Fyear);
            if (dt.Rows.Count > 0)
            {
                dgv_mov_line.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dal = new DAL.DataAccessLayer();
                    // if (row["Invontory_dis_ID"].ToString() == cbx_Inv_from.SelectedValue.ToString())

                    dgv_mov_line.Rows.Add(row["line_num"], row["product_ID"], row["A_N"], row["disc"], row["Units_ID"], row["out_or_in"]);


                }
            }
        }

        private void dgv_mov_line_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //   dgv_mov_line.CurrentRow.Cells["M"].Value = dgv_mov_line.CurrentRow.Index+1;
        }

        private void txt_Currency_key_Enter(object sender, EventArgs e)
        {
            if (txt_Accout_ID.Text == string.Empty)
            {

                MessageBox.Show("اختار رقم الحساب");
                txt_Accout_ID.Focus();
            }
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                search_data();
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_serch_Click(object sender, EventArgs e)
        {

        }

        private void txt_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_mov_line_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void txt_Currency_key_Leave(object sender, EventArgs e)
        {
            DataRow dr = Account.get_account_curr(txt_Accout_ID, txt_num, txt_Currency_key);
            if (dr != null)
            {
                txt_curr_exch_rate.Text = dr["curr_exch_rate"].ToString();
            }
                
            //  DataRow dr=dal.FindDataSet(select  ac.Account_ID, Account_Parent_ID, A_N, ACcount_Level, AccountType, currency_name, curr_exch_rate, Account_Group_ID, Class_ID, Operator, category_ID, stutas, Rapport_ID, aau.in_date, aau.edit_date, BRN_YEAR, have_child, Adds, Show, aau.currency_Key from AC_Account ac LEFT JOIN Ath_Account_User aau  ON aau.Account_ID = ac.Account_ID JOIN AM_Currency ac1 ON aau.currency_Key = ac1.currency_Key WHERE aau.Show = 1 and User_ID = " + BL.settings.user_id+" AND aau.Account_ID = "+Account_ID.Text+" ORDER BY ac1.currency_ID)
        }

        private void txt_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                Dictionary<int, string> list_C_N = new Dictionary<int, string>();
                DataRow dr = Account.get_account(txt_Accout_ID);
                list_C_N.Add(50, "رقم ال" + dr["an_type"].ToString());
                list_C_N.Add(150, "اسم ال" + dr["an_type"].ToString());

                string wherestr = BL.select_query.where_accoun_an_Show(txt_Accout_ID.Text);
                string sql = BL.select_query.sql_account_an_search;

                PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
                frm.ShowDialog();
                if (frm.dataGridView1.CurrentRow != null)
                {
                    if (frm.dataGridView1.CurrentRow.Cells[0].Value.ToString() != null)
                    {
                        txt_num.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_name.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    }

                }

            }
        }
    }
}
