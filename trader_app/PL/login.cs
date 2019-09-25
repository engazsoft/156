using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace trader_app.PL
{
    public partial class login : Form
    {
        BL.User_class user = new BL.User_class();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox_psaa.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = user.PROC_User_info(textBox_user_name.Text,textBox_psaa.Text);


            if (dt.Rows.Count > 0)
            {
    
              
                
                this.Close();
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox_user_name.Text = "";
                textBox_psaa.Text = "";
                textBox_user_name.Focus();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_shw_pass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_shw_pass.Checked == true)
            textBox_psaa.UseSystemPasswordChar = false;
            else
            textBox_psaa.UseSystemPasswordChar = true;
        }

        private void textBox_user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_psaa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
