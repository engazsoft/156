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

namespace trader_app.PL
{
 
  public   partial class add_form : Form
    {
       
        public add_form()
        {
            InitializeComponent();
            UpdateTextPosition();
        }
     public  void UpdateTextPosition()
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + this.Text.Trim();
        }
        public   string Statu;
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_edit_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = true;
            frm_View(this);
        }

        private void add_form_Load(object sender, EventArgs e)
        {
            btn_add.Enabled = btn_serch.Enabled =btn_view.Enabled= true;
            UpdateTextPosition();
            //foreach (Control control in this.Controls)
            //{
            //    //control.Controls.OfType<TextBox>().All(tb => tb.ReadOnly = true);
            //    //control.Controls.OfType<CheckBox>().All(tb => tb.Checked = false);
            //    foreach (Control control1 in control.Controls)
            //    {
            //        //control1.Controls.OfType<TextBox>().All(tb => tb.ReadOnly = true);
            //        //control1.Controls.OfType<CheckBox>().All(tb => tb.Checked = false);



            //        if (control1 is TextBox)
            //        {
            //            //control1.Controls.OfType<TextBox>().All(tb => tb.ReadOnly = true);
            //            //    (control as TextBox).ReadOnly = true;
            //            (control1 as TextBox).BackColor = Color.White;
            //            foreach (Control control2 in control1.Controls)
            //            {

            //                if (control2 is TextBox)
            //                {
            //                    //control1.Controls.OfType<TextBox>().All(tb => tb.ReadOnly = true);
            //                    //    (control as TextBox).ReadOnly = true;
            //                    (control2 as TextBox).BackColor = Color.White;
            //                }

            //            }
            //        }
            //        if (control1 is CheckBox)
            //        {
            //            //control1.Controls.OfType<TextBox>().All(tb => tb.ReadOnly = true);
            //            //    (control as TextBox).ReadOnly = true;
            //            (control1 as CheckBox).Checked = false;

            //        }

            //    }

            //}
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_edit(this);
            btn_view.Enabled = btn_serch.Enabled = btn_seve.Enabled = false;
            btn_seve.Enabled = btn_repeal.Enabled = true;
            Statu = "0";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_dele.Enabled = btn_add.Enabled = btn_dele.Enabled = btn_edit.Enabled=btn_serch.Enabled=btn_view.Enabled = false;
            btn_seve.Enabled = btn_repeal.Enabled = true;
            groupBox_Data.Controls.OfType<CheckBox>().All(tb => tb.Checked = false);
            groupBox_Data.Enabled = true;
            
            form_add(this);
            Statu="1";
            //foreach (Control controlss in groupBox_Data.Controls)
            //{

            //    if (controlss is TextBox)
            //    {

            //            (controlss as TextBox).ReadOnly = false;
            //            (controlss as TextBox).Clear();
            //        // (controlss as ComboBox).DataSource = null;
            //      //  (controlss as PictureBox).Image. ;


            //    }

            //    if (controlss is CheckBox)
            //    {
            //        //control1.Controls.OfType<TextBox>().All(tb => tb.ReadOnly = true);
            //        //    (control as TextBox).ReadOnly = true;
            //        (controlss as CheckBox).Checked = false;

            //    }

            //}
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btn_seve_Click(object sender, EventArgs e)
        {
           
                form_Add(this);
                btn_seve.Enabled = false;
            
                foreach (Control controlss in groupBox_Data.Controls)
                {
                    if (controlss is TextBox)
                    {
                        (controlss as TextBox).ReadOnly = true;
                    }



                }
                btn_dele.Enabled = btn_add.Enabled = btn_dele.Enabled = btn_edit.Enabled = btn_serch.Enabled = btn_view.Enabled = true;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            form_clear(this);
           
        }
        public void form_Add(Control c)
        {

            foreach (Control control2 in c.Controls)
            {

                if (control2 is TextBox)
                {
                    if ((control2 as TextBox).Tag == "r" && (control2 as TextBox).Text == string.Empty)
                    {
                        MessageBox.Show("يرجا تعبة الحقل ");
                        control2.BackColor = Color.Red;
                        control2.Focus();
                        break;
                    }
            
                }

                if (control2.Controls != null)
                {
                    form_Add(control2);
                }

            }

        }
        public void frm_edit(Control c)
        {

            foreach (Control control2 in c.Controls)
            {

                if (control2 is TextBox)
                {
                    if ((control2 as TextBox).Name != "txt_id" )
                    {
                        (control2 as TextBox).ReadOnly = false;
                     
                    }

                }
                if (control2 is CheckBox)
                {

                    (control2 as CheckBox).Enabled = true;


                }
                if (control2 is ComboBox)
                {
                    (control2 as ComboBox).Enabled = true;
                }
                if (control2.Controls != null)
                {
                    frm_View(control2);
                }

                if (control2.Controls != null)
                {
                    frm_edit(control2);
                }
                if (control2 is DataGridView)
                {

                    (control2 as DataGridView).ReadOnly = false;


                }
            }
           
        }
        public void frm_View(Control c)
        {

            foreach (Control control2 in c.Controls)
            {

                if (control2 is TextBox && control2.Name!="txt_id")
                {

                    (control2 as TextBox).ReadOnly=false;
                    (control2 as TextBox).BackColor = Color.White;
                }

                if (control2 is CheckBox)
                {

                    (control2 as CheckBox).Enabled=true;


                }
                if (control2 is DataGridView)
                {

                    (control2 as DataGridView).ReadOnly = false;

                }
                if (control2 is ComboBox)
                {
                    (control2 as ComboBox).Enabled = false;
                }
                if (control2.Controls != null)
                {
                    frm_View(control2);
                }

            }

            btn_add.Enabled = btn_serch.Enabled=btn_edit.Enabled=true;
            btn_seve.Enabled = btn_repeal.Enabled = false;
            
        }

        public void form_clear(Control c)
        {
          
            foreach (Control control2 in c.Controls)
            {

                if (control2 is TextBox)
                {
               
                    (control2 as TextBox).Clear();
                }

                if (control2 is CheckBox)
                {

                    (control2 as CheckBox).Checked = false;

                }
                if(control2 is ComboBox)
                {
                    (control2 as ComboBox).SelectedValue = 0;
                }
                if (control2.Controls != null)
                {
                    form_clear(control2);
                }

            }
           btn_add.Enabled  = btn_serch.Enabled=btn_view.Enabled =true;
            btn_seve.Enabled=btn_repeal.Enabled = false;
        }
        public Boolean form_sev (Control c)
        {
            Boolean b = true;
            foreach (Control control2 in c.Controls)
            {

                if (control2 is TextBox)
                {
                    if ((control2 as TextBox).Tag == "r" && (control2 as TextBox).Text == string.Empty)
                    {
                        MessageBox.Show("يرجا تعبة الحقل ");
                        control2.BackColor = Color.Red;
                        control2.Focus();
                        b = false;
                    
                       // break;
                    }
                  
                }
                return b;
          

            }
            return b;
        }
        public void form_add(Control c)
        {
            foreach (Control controlss in groupBox_Data.Controls)
            {

                if (controlss is TextBox)
                {

                    (controlss as TextBox).ReadOnly = false;
                    (controlss as TextBox).Clear();
                 
                    //  (controlss as PictureBox).Image. ;


                }
                if (controlss is ComboBox)
                {

                    (controlss as ComboBox).Enabled = true;


                }
                if (controlss is CheckBox)
                {
                    //control1.Controls.OfType<TextBox>().All(tb => tb.ReadOnly = true);
                    //    (control as TextBox).ReadOnly = true;
                    (controlss as CheckBox).Checked = false;

                }

            }
            foreach (Control control2 in c.Controls)
            {

                if (control2 is TextBox)
                {

                    (control2 as TextBox).ReadOnly = false;



                }
              


            }

        }

        private void add_form_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void add_form_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
