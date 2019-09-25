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
    public partial class Form_Search : Form
    {
        
        string sql;
        Dictionary<int, string> list_C_N;
        string wherestr="0";
     DataTable   dt = new DataTable();
    DAL.DataAccessLayer   dal = new DAL.DataAccessLayer();
           
        public Form_Search(string sql,Dictionary<int,string> list_C_N)
        {
           
            InitializeComponent();
            this.sql = sql;
            this.list_C_N = list_C_N; 
            
        }
        public Form_Search(string sql,string wherestr, Dictionary<int, string> list_C_N)
        {

            InitializeComponent();
            this.sql = sql;
            this.list_C_N = list_C_N;
            this.wherestr = wherestr;

        }

        
        public Form_Search(string sql)
        {
       
            InitializeComponent();
            this.sql = sql;


        }
        public Form_Search(string sql,string ID)
        {
            this.textBox1.Text = ID;
            InitializeComponent();
            this.sql = sql;
           

        }
        private void Form_Search_Load(object sender, EventArgs e)
        {
            dt = dal.FindDataSet(sql);
            search();
            textBox1.Focus();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


           //search();


        }
        public void search()
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            string ss = sql ;
            int i = 0;
            foreach (var s in dt.Columns)
            {
                if (i == 0 )
                {
                    if ( wherestr =="0")
                     ss += "where convert(nvarchar," + s.ToString() + ")";
                      else
                        ss += wherestr + " convert(nvarchar," + s.ToString() + ")";
                }

                else
                    ss += "+ convert(nvarchar," + s.ToString() + ")";
                i++;
            }

           string sss = ss + " like N'%" + textBox1.Text + "%'";
            dataGridView1.DataSource = dal.FindDataSet(sss);
            int y=0;
            foreach (var C_N in list_C_N)
            {
                dataGridView1.Columns[y].HeaderText = C_N.Value;
                dataGridView1.Columns[y].Width = C_N.Key;
                y++;
            }

        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
      
        }

        private void Form_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Close();
           
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    this.Close();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
                e.Handled = true;
                return;
            }
           
         
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
           
               
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { search(); }
        }

        private void Form_Search_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
