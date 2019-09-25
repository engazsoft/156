using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace trader_app.BL
{
   class process_Class
    {
     
        DAL.DataAccessLayer dal;
    
            //else
            //    cb.DataSource = null;

        //}
        //public bool Convert_to_bool(object value)
        //{
        //    if (value != DBNull.Value)
        //    {
        //        re Convert.ToBoolean(dt.Rows[0]["stor_currency"]);
        //    }
        //}
        public string max_num_in_Column(string Table_Name, string Column_Name)
        {
            dal = new DAL.DataAccessLayer();
            return  dal.FindDataSet("select max("+ Column_Name +")+1 from " + Table_Name).Rows[0][0].ToString();
            
        }
        public void MessageBox_add_T()
        {
            MessageBox.Show("تمت الاضافة بنجاح","تم الاضافة",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        public void MessageBox_add_F()
        {
            MessageBox.Show("عملية الاضافة غير ناجحة الرجاء التاكد من صحة البيانات واكتمالها", "فشل الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public DataTable select_data_row(string T_N,string C_N,int ID)
        {

            dal = new DAL.DataAccessLayer();

            string sql = "select * from " + T_N + " where " + C_N + "=" + ID.ToString();
          
            return dal.FindDataSet(sql);
         
        }
        public DataTable select_data_row(string T_N, string C_N, string ID)
        {

            dal = new DAL.DataAccessLayer();

            string sql = "select * from " + T_N + " where " + C_N + "=N'" + ID+"'";

            return dal.FindDataSet(sql);

        }
        public DialogResult MessageBox_delete()
        {
            DialogResult result = new DialogResult();
          result=  MessageBox.Show("هل انت متاكد من خذف السجل المحدد لايمكن استعادة بعد التاكيد", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            return result;
        }
        public void MessageBox_delete_T()
        {

            MessageBox.Show("تمت عملية الحذف بنداح", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void MessageBox_delete_f()
        {
            MessageBox.Show("لم تتمكن من احذف", "فشل الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void MessageBox_upd_T()
        {
            MessageBox.Show("تمت التعديل بنجاح", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void MessageBox_upd_F()
        {
            MessageBox.Show("عملية التعديل غير ناجحة الرجاء التاكد من صحة البيانات واكتمالها", "فشل التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public string Into_txt_from_db(DataTable dt, int x, int y)
        {
            if (dt.Rows.Count > 0 && dt.Rows[x][y].ToString().Length > 0)
            {
                return dt.Rows[x][y].ToString();
            }
            else
            {
                return "لايوجد قيمة";
            }

        }
        public string Insert_txt_to_db(string d)
        {
            if (d.Length > 0 && d!= "لايوجد قيمة")
            {
                return d;
            }
            else
            {
                return "";
            }

        }
        public byte[] Insert_image_to_db(PictureBox pb)
        {
            if (pb.Image==null)
            {
                return null;
            }
            else
            {
                Bitmap bmb = new Bitmap(pb.Image, new Size(Convert.ToInt32(200), Convert.ToInt32(200)));
             
                MemoryStream ms = new MemoryStream();
                bmb.Save(ms, pb.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                return byteimage;
            }

        }
        public void select_image_frim_db(PictureBox pb, DataTable dt, int x, int y)
        {
           try
            {
                byte[] image = (byte[])dt.Rows[x][y];
                MemoryStream ms = new MemoryStream(image);
                pb.Image = Image.FromStream(ms);
            }
            catch
            {

                pb.Image = pb.ErrorImage;
            }
                
            

        }

        public void select_image_frim_db(PictureBox pb, DataRow dt, string C_name)
        {
            try
            {
                byte[] image = (byte[])dt[C_name];
                MemoryStream ms = new MemoryStream(image);
                pb.Image = Image.FromStream(ms);
            }
            catch
            {
               
                pb.Image =null;
            }



        }
        public string Insert_DTB_to_db(DateTimePicker DT)
        {

            if (DT.Format == DateTimePickerFormat.Custom)
            {
                return "";
            }
            else
            {
                return DT.Value.ToString();
            }

        }
        public string Insert_com_to_db(ComboBox com)
        {
            
            if(com.SelectedIndex==-1||com.Text.Length<1||com.Text== "NO SELECT VALUE")
            {
                return null;
            }
            else
            {
             return com.SelectedValue.ToString();
            }

        }
        public string Insert_com_indx(ComboBox com)
        {

            if (com.SelectedIndex == -1)
            {
                return null;
            }
            else
            {
                return com.SelectedIndex.ToString();
            }

        }

      
     
        public void selec_value_com_from_db(ComboBox com,string dt)
        {
            if ( dt.Length>0)
            {
                com.SelectedValue = dt;
            }
            else
            {
                com.Text = "NO SELECT VALUE";
            }

        }
    
        public void selec_index_com_from_db(ComboBox com, DataTable dt, int x, int y)
        {
            if (dt.Rows.Count > 0 && dt.Rows[x][y].ToString().Length > 0)
            {
                com.SelectedIndex=Convert.ToInt32(dt.Rows[x][y].ToString());
            }
            else
            {
                com.Text = "NO SELECT VALUE";
            }

        }
        public void insert_CheckBox(CheckBox chbx)
        {
          
        }
        public void Into_DTP_from(DateTimePicker DTP, DataTable dt, int x, int y)
        {
            if (dt.Rows.Count > 0 && dt.Rows[x][y].ToString().Length > 0)
            {
                DTP.Format = DateTimePickerFormat.Short;
                DTP.Value= Convert.ToDateTime(dt.Rows[x][y].ToString());

            }
            else
            {
                DTP.Format = DateTimePickerFormat.Custom;
                DTP.CustomFormat = " ";
            }

        }
        public static ErrorProvider ep = new ErrorProvider();
        public static bool ValidateEmail(TextBox email)
        {
            string patternLenient = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            System.Text.RegularExpressions.Regex reLenient = new System.Text.RegularExpressions.Regex(patternLenient);
            if (!reLenient.IsMatch(email.Text) && !email.Text.Equals(""))
            {

                ep.SetError(email, "Please Enter a Valid email address");
                return false;
            }
            ep.SetError(email, "");

            return true;
        }

        public static bool ValidatePhone(TextBox number)
        {
            string patternLenient = @"^\d{8}\d*$";

            System.Text.RegularExpressions.Regex reLenient = new System.Text.RegularExpressions.Regex(patternLenient);
            if (!reLenient.IsMatch(number.Text) && !number.Text.Equals(""))
            {

                ep.SetError(number, "Please Enter a Valid Phone Number");
                return false;
            }
            ep.SetError(number, "");

            return true;
        }
    }
}
