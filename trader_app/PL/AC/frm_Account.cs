using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using trader_app.BL;
using System.Runtime.InteropServices;

namespace trader_app.PL.AC
{
    public partial class frm_Account : PL.add_form
    {
        Am.frm_Account_request_dgv frm = new Am.frm_Account_request_dgv();
        process_Class proc = new process_Class();
        Account_Class Account = new Account_Class();
        DAL.DataAccessLayer dal;
        DAL.Databas_Class DB = new DAL.Databas_Class();
        public int check;
        DataTable dt;
        string Account_ID;
        public frm_Account()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //PopupNotifier popup = new PopupNotifier();
            //popup.Image = Properties.Resources.info1;

            //popup.TitleText = "welcom";
            //popup.ContentText = "يوجد طلبيات لفتح حساب";
            //popup.AnimationDuration = 15;
            //popup.BodyColor = Color.Purple;
            //popup.TitleColor = Color.Thistle;
            //popup.ContentColor = Color.Silver;
            
            
            //popup.Popup();
            tree_refresh();
            //  this.PopulateTreeView(dt, 0, treeView1.Nodes[""]);

            DB.LoadCombo(cbx_Account_group, "select Group_ID,A_N from AC_Account_Group ", "A_N", "Group_ID");

            DB.LoadCombo(cbx_Account_type, "select Type_ID,A_N from AC_Account_Type ", "A_N", "Type_ID");
            DB.LoadCombo(cbx_Account_Calss, "select Class_ID,A_N from AC_Account_Class ", "A_N", "Class_ID");
            DB.LoadCombo(cbx_parent, "SELECT  Account_ID ,A_N ,E_N  FROM [dbo].AC_Account where Type_id=1", "A_N", "Account_ID");
            cbx_parent.SelectedIndex = -1;
           
        }


        private void tree_refresh()
        {
            //  tv_Account.Nodes.Clear();
            dal = new DAL.DataAccessLayer();
            string sql = "SELECT   [Account_ID] ,[Account_Parent_ID] ,[A_N],[E_N] FROM [trader_db].[dbo].[AC_Account] where Account_ID<>0";

            // treeView1.Nodes.Add("taha");
            dt = dal.FindDataSet(sql);
            PopulateTreeView(0, tv_Account1.Nodes.Add("الدليل المحاسبي"));
        }
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            TreeNode childNode;
            if (parentId == 0)
            {
                foreach (DataRow dr in dt.Select("[Account_Parent_ID] is NULL"))
                {
                    TreeNode t = new TreeNode();
                    t.Text = dr["Account_ID"].ToString() + " - " + dr["A_N"].ToString();
                    t.Name = dr["Account_ID"].ToString();
                    t.Tag = dt.Rows.IndexOf(dr);
                    if (parentNode == null)
                    {
                        tv_Account1.Nodes.Add(t);
                        childNode = t;

                    }
                    else
                    {
                        parentNode.Nodes.Add(t);
                        childNode = t;



                    }

                    PopulateTreeView(Convert.ToInt32(dr["Account_ID"].ToString()), childNode);
                }
            }
            else
            {
                foreach (DataRow dr in dt.Select("Account_Parent_ID ='" + Convert.ToInt64(parentId) + "'"))
                {
                    TreeNode t = new TreeNode();
                    t.Text = dr["Account_ID"].ToString() + " - " + dr["A_N"].ToString();
                    t.Name = dr["Account_ID"].ToString();
                    t.Tag = dt.Rows.IndexOf(dr);
                    if (parentNode == null)
                    {
                        tv_Account1.Nodes.Add(t);

                        childNode = t;

                    }
                    else
                    {
                        parentNode.Nodes.Add(t);

                        childNode = t;


                    }

                    PopulateTreeView(Convert.ToInt32(dr["Account_ID"].ToString()), childNode);
                }
            }

        }

        private void groupBox_Data_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void search_data()
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الحساب");
            list_C_N.Add(100, "اسم الحساب ");
            list_C_N.Add(101, "الاسم الاجنبي ");

            string wherestr = " where Type_id=1 and ";
            string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
            frm.ShowDialog();

            txt_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            view_data();
        }
        private void view_data()
        {
            DB = new DAL.Databas_Class();
            DataRow Account_Info = DB.select_Row("AC_Account", "Account_ID", txt_id.Text);
            // "[Employee_ID],[A_N] ,[E_N] ,[Management_ID] ,[Job]   ,[super_Employee_ID] ,[Hier_Date]  ,[Salary]   ,[Qualified_ID]  ,[Phone_num] ,[Phone_num_1]     ,[Out_Serves_Date]   ,[Email]  ,[Address] ,[Delegate_ID] ,[Stop] 
            if (Account_Info != null)
            {

                txt_id.Text = Account_Info["Account_ID"].ToString();
                txt_A_N.Text = Account_Info["A_N"].ToString();
                txt_E_N.Text = Account_Info["E_N"].ToString();
                txt_Note.Text = Account_Info["Note"].ToString();
                if (Account_Info["Class_ID"].ToString() != string.Empty)
                    cbx_Account_Calss.SelectedValue = Account_Info["Class_ID"].ToString();
                    cbx_Account_group.SelectedValue = Account_Info["Account_Group_ID"].ToString();
                    cbx_Account_type.SelectedValue = Account_Info["Type_ID"].ToString();
                    Cbx_Account_status.SelectedValue = Account_Info["stutas"].ToString();
                if (Account_Info["Account_Parent_ID"] == DBNull.Value)
                {
                    cbx_parent.SelectedIndex = -1;
                    cbx_parent.SelectedValue = DBNull.Value;
                }
                else
                    cbx_parent.SelectedValue = Account_Info["Account_Parent_ID"].ToString();
                txt_in_date.Text = Account_Info["in_date"].ToString();
                txt_edit_date.Text = Account_Info["edit_date"].ToString();
                txt_edit_user.Text = Account_Info["edit_user"].ToString();
                txt_by_user.Text = Account_Info["by_user"].ToString();
                dgv_Account_curr.DataSource = null;

                if (Account_Info["Type_ID"].ToString() == "2")
                {
                    dal = new DAL.DataAccessLayer();
                    dgv_Account_curr.DataSource = dal.FindDataSet("select AM.currency_Key as الرمز,currency_name as الاسم,Ac.Used as استخدام from AC_Account_currency  AC right join AM_Currency AM  on ac.currency_Key=Am.currency_Key and Account_ID=N'" + txt_id.Text + "' where  AM.Used='1' ");
                    dgv_Account_curr.Columns[0].Width = 30;
                    dgv_Account_curr.Columns[0].Name = "الرمز";
                    dgv_Account_curr.Columns[1].Width = 70;
                    dgv_Account_curr.Columns[1].Name = "الاسم";
                    dgv_Account_curr.Columns[2].Width = 60;
                    dgv_Account_curr.Columns[2].Name = "استخدام";
                }

                btn_edit.Enabled = true;
            }
        }
        private void btn_view_Click(object sender, EventArgs e)
        {
            view_data();
        }

        private void cbx_Account_Parent_DropDown(object sender, EventArgs e)
        {

        }
        string s;
        private void cbx_Account_Parent_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void txt_Account_Key_TextChanged(object sender, EventArgs e)
        {


            //lb_full_accout_num.Text = s + txt_Account_Key.Text;
        }

        private void cbx_Account_Parent_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(cbx_Account_Parent.Text))
            //    lb_full_accout_num.Text = "";
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            search_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> list_C_N = new Dictionary<int, string>();
            list_C_N.Add(50, "رقم الحساب");
            list_C_N.Add(100, "اسم الحساب ");
            list_C_N.Add(101, "الاسم الاجنبي ");

            string wherestr = " where Type_id=1 and ";
            string sql = " SELECT  Account_ID ,A_N ,E_N  FROM   AC_Account";

            PL.Am.Form_Search frm = new Am.Form_Search(sql, wherestr, list_C_N);
            frm.ShowDialog();



            //  s = lb_full_accout_num.Text;
            frm.Dispose();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            view_data();

        }

        private void btn_add_Click(object sender, EventArgs e)
        { try
            {
                if (string.IsNullOrWhiteSpace(cbx_parent.SelectedValue.ToString()))
                {
                    MessageBox.Show("يرجا تحدد الحساب الرئسي ");
                    btn_seve.Enabled = false;
                }
                else
                {

                    txt_A_N.Text = "";
                    txt_E_N.Text = "";

                    //Account_ID = proc.max_num_in_Column("AC_Account", "Account_ID");
                    txt_id.Text = proc.max_num_in_Column("AC_Account where Account_Parent_ID  = " + cbx_parent.SelectedValue.ToString(), "Account_ID");

                    if (txt_id.Text.Length == 0)
                    {
                        txt_id.Text = cbx_parent.SelectedValue + "1";
                        txt_id.ReadOnly = false;
                    }
                }
            }
            catch
            {

                MessageBox.Show("يرجا تحدد الحساب الرئسي ");
                btn_seve.Enabled = false;
                cbx_parent.Focus();
            }
        
       

        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
            txt_id.ReadOnly = true;

            Account.P_AC_insert_Account(txt_id.Text, proc.Insert_com_to_db(cbx_parent),
                txt_A_N.Text, txt_E_N.Text, Convert.ToInt32(proc.Insert_com_to_db(cbx_Account_Calss)), Convert.ToInt32(proc.Insert_com_to_db(cbx_Account_type)),
                Convert.ToInt32(proc.Insert_com_to_db(cbx_Account_group)), Convert.ToInt32(proc.Insert_com_to_db(cbx_Account_Calss)),
                Convert.ToInt32(proc.Insert_com_to_db(Cbx_Account_status)),
                Convert.ToInt32(proc.Insert_com_to_db(cbx_Rapport)), txt_Note.Text);
            if (check==1)
            {
            Account.P_AC_insert_Account_Request(txt_id.Text, proc.Insert_com_to_db(cbx_parent), txt_A_N.Text, txt_E_N.Text
               , Convert.ToInt32(proc.Insert_com_to_db(cbx_Account_type)), Convert.ToInt32(proc.Insert_com_to_db(cbx_Account_group)),
               Convert.ToInt32(proc.Insert_com_to_db(cbx_Account_Calss)), checkBox1.Checked, txt_Note.Text);
            }
            foreach (DataGridViewRow row in dgv_Account_curr.Rows)
            {

                if (row.Cells["استخدام"].Value == DBNull.Value)
                {
                    row.Cells["استخدام"].Value = false;


                }
                Account.P_AC_insert_Account_Currency(row.Cells["الرمز"].Value.ToString(), txt_id.Text, Convert.ToBoolean(row.Cells["استخدام"].Value));
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_curr_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tree_refresh();
            tv_Account1.SelectedNode.ExpandAll();
        }

        private void treeView1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dgv_Account_curr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbx_Account_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_Account_type.SelectedValue.ToString() != "1")
                {
                    dal = new DAL.DataAccessLayer();
                    dgv_Account_curr.DataSource = dal.FindDataSet("select AM.currency_Key as الرمز,currency_name as الاسم,Ac.Used as استخدام from AC_Account_currency  AC right join AM_Currency AM  on ac.currency_Key=Am.currency_Key and Account_ID=N'" + txt_id.Text + "' where  AM.Used='1' ");
                    dgv_Account_curr.Columns[0].Width = 30;
                    dgv_Account_curr.Columns[0].Name = "الرمز";
                    dgv_Account_curr.Columns[1].Width = 70;
                    dgv_Account_curr.Columns[1].Name = "الاسم";
                    dgv_Account_curr.Columns[2].Width = 60;
                    dgv_Account_curr.Columns[2].Name = "استخدام";
                   
                }
                else
                    dgv_Account_curr.DataSource = null;
            }
            catch (Exception)
            {

                return;
            }

        }

        private void cbx_parent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                search_data();
            }
        }

        private void cbx_Acount_group_Click(object sender, EventArgs e)
        {

        }

        private void tv_Account1_AfterExpand(object sender, TreeViewEventArgs e)
        {

            foreach (TreeNode Node in tv_Account1.Nodes)
            {

                if (Node.Nodes.Count > 0)
                {
                    tv_Account1.ImageList = imageList1;

                    Node.ImageIndex = 0;
                    Node.SelectedImageIndex = 0;
                    checkchild(Node);
                }


            }

        }
        private void checkchild(TreeNode nod)
        {
            foreach (TreeNode node in nod.Nodes)
            {
                if (node.Nodes.Count > 0)
                {
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                    checkchild(node);
                }
                else
                    //  nod.SelectedImageKey = imageList1.Images.Empty.ToString();
                    node.ImageIndex = 1;
                node.SelectedImageIndex = 1;

            }
        }

        private void tv_Account1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //if(txt_id.Text==string.Empty)
            //{
            //    txt_id.Text = tv_Account1.SelectedNode.Name;
            //    view_data();
            //}
            //else
            //{
            //    TreeView tv_Account1 = new TreeView();
            //    txt_id.Text = tv_Account1.SelectedNode.TreeView.SelectedNode.Name;
            //    view_data();
            //}


        }

        private void cbx_parent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Account_request_Click(object sender, EventArgs e)
        {
            Am.frm_Account_request_dgv frm = new Am.frm_Account_request_dgv();
            frm.ShowDialog();
            if(frm.dgv_Account_request.CurrentRow!=null)
            {
                cbx_parent.SelectedValue = frm.dgv_Account_request.CurrentRow.Cells[1].Value.ToString();
                txt_id.Text = frm.dgv_Account_request.CurrentRow.Cells[0].Value.ToString();
                txt_A_N.Text = frm.dgv_Account_request.CurrentRow.Cells[2].Value.ToString();
                txt_E_N.Text = frm.dgv_Account_request.CurrentRow.Cells[3].Value.ToString();
                cbx_Account_type.SelectedValue = frm.dgv_Account_request.CurrentRow.Cells[4].Value.ToString();
                cbx_Account_group.SelectedValue = frm.dgv_Account_request.CurrentRow.Cells[5].Value.ToString();
                cbx_Account_Calss.SelectedValue = frm.dgv_Account_request.CurrentRow.Cells[6].Value.ToString();
                txt_Note.Text = frm.dgv_Account_request.CurrentRow.Cells[7].Value.ToString();
                checkBox1.Checked = Convert.ToBoolean(frm.dgv_Account_request.CurrentRow.Cells["الموافقه"].Value);
                btn_seve.Enabled = true;
                check = 1;
            }
          
            //foreach (DataGridViewRow  row  in frm.dgv_Account_request.Rows)
            //{
            //    if (row.Cells["الموافقه"].Value == DBNull.Value)
            //    {
               
            
            //        row.Cells["الموافقه"].Value = true;
                    
            //    }

           // }
            //    {
            //        dal = new DAL.DataAccessLayer();
            //       frm.dgv_Account_request.DataSource = dal.FindDataSet("select Account_ID as رقم الحساب, Account_Parent_ID as رقم الحساب الرئيسي , A_N as الاسم  , E_N as الاسم الاجنبي , Type_ID as النوع, Account_Group_ID as نوع المجموعه , Class_ID as نوع الصنف, Note as الملاحظة , by_user as المستخدم from AC_Account_Request where add_status='0'");
            //        dgv_Account_curr.Columns[0].Width = 30;
            //        dgv_Account_curr.Columns[0].Name = "الرمز";
            //        dgv_Account_curr.Columns[1].Width = 70;
            //        dgv_Account_curr.Columns[1].Name = "الاسم";
            //        dgv_Account_curr.Columns[2].Width = 60;
            //        dgv_Account_curr.Columns[2].Name = "استخدام";

            //    }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
