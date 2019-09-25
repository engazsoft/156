using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace trader_app.DAL
{
    
    class Databas_Class
    {
        DataAccessLayer dal = new DataAccessLayer();
        public DataRow select_Row(string Tabel_Nema, string Column_Name, TextBox ID)
        {
            DataAccessLayer dal = new DataAccessLayer();
            try
            {
                return dal.FindDataSet("select * from " + Tabel_Nema + " where " + Column_Name + "='" + ID.Text + "'").Rows[0];


            }
            catch (Exception)
            {
                MessageBox.Show("ارجاء التاكد من رقم السجل قد ");
                ID.SelectAll();
                ID.Focus();
                return null;
            }

        }
        public DataRow select_Row(string Tabel_Nema ,string Column_Name ,string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            try
            {
                return dal.FindDataSet("select * from "+Tabel_Nema+" where "+Column_Name+"="+ ID).Rows[0];
               
                
            }
            catch (Exception)
            {
                MessageBox.Show("ارجاء التاكد من رقم السجل قد ");
                return null;
            }

        }
        public Boolean isselect_Row(string Tabel_Nema, string Column_Name, string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            try
            {
                
                    return (dal.FindDataSet("select * from " + Tabel_Nema + " where " + Column_Name + "=" + ID).Rows[0] != null);


            }
            catch (Exception)
            {
                
                return false;
            }

        }
        public DataRow select_Tabel_between_Date(string Tabel_Nema, string Column_Name, string from ,string end)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            try
            {
                return dal.FindDataSet("select * from " + Tabel_Nema + " where " + Column_Name + " between " + from +" and "+end).Rows[0];


            }
            catch (Exception)
            {
                MessageBox.Show("التوجد بيانات في الفترة الحددة ");
                return null;
            }

        }
        public DataRow select_Row(string Tabel_Nema, string Column_Name, string ID, string Column_Name1,string ID1)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            try
            {
                return dal.FindDataSet("select * from " + Tabel_Nema + " where " + Column_Name + " = " + ID+" and "+ Column_Name1+" = "+ID1).Rows[0];


            }
            catch (Exception)
            {
                MessageBox.Show("ارجاء التاكد من رقم السجل قد ");
                return null;
            }

        }
        public void LoadCombo(ComboBox cb, string strsql, string DisplayMember, string ValueMember,int i)
        {
            try
            {
                dal = new DAL.DataAccessLayer();
             
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;

             
                cb.DataSource = dal.FindDataSet(strsql);
           
                cb.DropDownHeight = 100;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        public void LoadCombo(ComboBox cb, string strsql, string DisplayMember, string ValueMember)
        {
            try
            {
                dal = new DAL.DataAccessLayer();
                //  SqlDataReader dr = dal.Find(strsql);
                //if (dr.Read())
                //{
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;

                // cb.SelectedIndex = -1;
                //  strsql = strsql + "  order by upper(" + DisplayMember + ")";
                cb.DataSource = dal.FindDataSet(strsql);
              cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
              cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
                //  cb.SelectedIndex = -1;
                cb.DropDownHeight = 100;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        
        }
    }
}
