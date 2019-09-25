using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace trader_app.BL
{
    class Account_Class
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataRow get_account(string Account_ID)
        {
            try
            {
                return dal.FindDataSet("select * from AC_Account where Account_ID=" + Account_ID).Rows[0];
            }
            catch (Exception)
            {

                return null;
            }

        }
        public DataRow get_account(TextBox Account_ID)
        {
            try
            {
                return dal.FindDataSet("select  ac.Account_ID, Account_Parent_ID, A_N, ACcount_Level, AccountType,currency_name,curr_exch_rate, Account_Group_ID, Class_ID, Operator, category_ID, stutas, Rapport_ID, aau.in_date, aau.edit_date, BRN_YEAR, an_type , Adds,Show,aau.currency_Key from AC_Account ac LEFT JOIN Ath_Account_User aau  ON aau.Account_ID=ac.Account_ID JOIN AM_Currency ac1 ON aau.currency_Key=ac1.currency_Key WHERE aau.Show=1 and User_ID=" + BL.settings.user_id+" AND aau.Account_ID="+Account_ID.Text+" ORDER BY ac1.currency_ID " ).Rows[0];
            }
            catch (Exception)
            {
                MessageBox.Show("رقم الحساب غير صحيح");
                Account_ID.Text = "";
                Account_ID.Focus();
                return null;
            }

        }
        public DataRow get_account_curr(TextBox Account_ID,TextBox acount_an_id , TextBox curr)
        {
            try
            {
                if(acount_an_id.Text=="")
                    return dal.FindDataSet("select currency_name,curr_exch_rate, Account_Group_ID, Class_ID, Operator, category_ID, stutas, Rapport_ID, aau.in_date, aau.edit_date, BRN_YEAR, an_type , Adds,Show,aau.currency_Key from AC_Account ac LEFT JOIN Ath_Account_User aau  ON aau.Account_ID=ac.Account_ID JOIN AM_Currency ac1 ON aau.currency_Key=ac1.currency_Key WHERE aau.Show=1 and User_ID=" + BL.settings.user_id + " AND aau.currency_Key=N'" + curr.Text + "' and  aau.Account_ID=N'" + Account_ID.Text + "'and Accoun_AN_ID is NULL   ORDER BY ac1.currency_ID ").Rows[0];
             
                else
           return dal.FindDataSet("select currency_name,curr_exch_rate ,aau.currency_Key from AC_Account ac LEFT JOIN Ath_Account_User aau  ON aau.Account_ID=ac.Account_ID JOIN AM_Currency ac1 ON aau.currency_Key=ac1.currency_Key WHERE aau.Show=1 and User_ID=" + BL.settings.user_id + " AND aau.currency_Key=N'" + curr.Text + "' and  aau.Account_ID=N'" + Account_ID.Text + "' and Accoun_AN_ID =" + acount_an_id.Text + " ORDER BY ac1.currency_ID ").Rows[0];
            }
            catch (Exception)
            {
                MessageBox.Show("  العملة غير موجودة او غير مصرحة للمستخدم استحدامها مع هذا الحساب ");
                curr.Text = "";
                curr.Focus();
                return null;
            }

        }
        //public DataTable get_account_curr(string Account_ID)
        public void p_AC_insert_Account_type(int Type_ID,
                                      string A_N,
                                      string E_N,
                                      bool Affected_by_operations
                                     )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Type_ID", SqlDbType.Int);
            param[0].Value = Type_ID;

            param[1] = new SqlParameter("@A_N", SqlDbType.NVarChar, (20));
            param[1].Value = A_N;

            param[2] = new SqlParameter("@E_N", SqlDbType.NVarChar, (20));
            param[2].Value = E_N;


            param[3] = new SqlParameter("@Affected_by_operations", SqlDbType.Bit);
            param[3].Value = Affected_by_operations;


            param[4] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[4].Value = PL.main.Use_id;

            DAL.Executecommade("p_AC_insert_Account_type", param);



        }


        public void P_AC_insert_Account_Currency(
                                 string currency_Key,
                                 string Account_ID,
                                 bool used
                                )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@currency_Key", SqlDbType.NVarChar);
            param[0].Value = currency_Key;

            param[1] = new SqlParameter("@Account_ID", SqlDbType.NVarChar);
            param[1].Value = Account_ID;

            param[2] = new SqlParameter("@Used", SqlDbType.Bit);
            param[2].Value = used;


            DAL.Executecommade("P_AC_insert_Account_Currency", param);



        }
        public void P_AC_insert_Account(
                                        string Account_ID,
                                      string Account_Parent_ID,
                                      string A_N,
                                      string E_N,
                                      int ACcount_Level,
                                      int Type_ID,
                                      int Account_Group_ID,
                                      int Class_ID,
                                      int stutas,
                                      int Rapport_ID,
                                      string Note)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@Account_ID", SqlDbType.NVarChar, 15);
            param[0].Value = Account_ID;

            param[1] = new SqlParameter("@Account_Parent_ID", SqlDbType.NVarChar, 10);
            param[1].Value = Account_Parent_ID;



            param[2] = new SqlParameter("@A_N", SqlDbType.NVarChar, (50));
            param[2].Value = A_N;

            param[3] = new SqlParameter("@E_N", SqlDbType.NVarChar, (50));
            param[3].Value = E_N;

            param[4] = new SqlParameter("@ACcount_Level", SqlDbType.Int);
            param[4].Value = ACcount_Level;

            param[5] = new SqlParameter("@Type_ID", SqlDbType.Int);
            param[5].Value = Type_ID;

            param[6] = new SqlParameter("@Account_Group_ID", SqlDbType.Int);
            param[6].Value = Account_Group_ID;

            param[7] = new SqlParameter("@Class_ID", SqlDbType.Int);
            param[7].Value = Class_ID;

            param[8] = new SqlParameter("@stutas", SqlDbType.Int);
            param[8].Value = stutas;

            param[9] = new SqlParameter("@Rapport_ID", SqlDbType.Int);
            param[9].Value = Rapport_ID;

            param[10] = new SqlParameter("@Note", SqlDbType.NVarChar);
            param[10].Value = Note;

            param[11] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[11].Value = PL.main.Use_id;



            DAL.Executecommade("P_AC_insert_Account", param);



        }
        //p_AC_insert_Account_group
        public void p_AC_insert_Account_group(int Group_ID,
                                      string A_N,
                                      string E_N

                                     )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Group_ID", SqlDbType.Int);
            param[0].Value = Group_ID;

            param[1] = new SqlParameter("@A_N", SqlDbType.NVarChar, (20));
            param[1].Value = A_N;

            param[2] = new SqlParameter("@E_N", SqlDbType.NVarChar, (20));
            param[2].Value = E_N;

            param[3] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[3].Value = PL.main.Use_id;

            DAL.Executecommade("p_AC_insert_Account_group", param);



        }
    //    [dbo].[P_AC_insert_Account_Request]
    //    @Account_ID nvarchar(15)
    //     ,  @Account_Parent_ID nvarchar(10)
    //       ,@A_N nvarchar(50)
    //       ,@E_N nvarchar(50)
    //      , @ACcount_Level int
    //      ,@Type_ID int
    //      , @Account_Group_ID int
    //      , @Class_ID int
		  //,@Note nvarchar(max)
		  //,@add_status bit
    //      , @by_user nvarchar(50)



        public void P_AC_insert_Account_Request
                                   (string Account_ID,
                                     string Account_Parent_ID,
                                      string A_N,
                                      string E_N,
                                      int Type_ID,
                                      int Account_Group_ID,
                                      int Class_ID, 
                                      bool add_status
                                      ,string Note
            )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@Account_ID", SqlDbType.NVarChar,15);
            param[0].Value = Account_ID;

            param[1] = new SqlParameter("@Account_Parent_ID", SqlDbType.NVarChar,10);
            param[1].Value = Account_Parent_ID;


            param[2] = new SqlParameter("@A_N", SqlDbType.NVarChar, (50));
            param[2].Value = A_N;
            param[3] = new SqlParameter("@E_N", SqlDbType.NVarChar, (50));
            param[3].Value = E_N;
            param[4] = new SqlParameter("@Type_ID", SqlDbType.Int);
            param[4].Value = Type_ID;


            param[5] = new SqlParameter("@Account_Group_ID", SqlDbType.Int);
            param[5].Value = Account_Group_ID;

            param[6] = new SqlParameter("@Class_ID", SqlDbType.Int);
            param[6].Value = Class_ID;

            param[7] = new SqlParameter("@add_status", SqlDbType.Bit);
            param[7].Value = add_status;

            param[8] = new SqlParameter("@Note", SqlDbType.NVarChar);
            param[8].Value = Note;

            param[9] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[9].Value = PL.main.Use_id;

            DAL.Executecommade("P_AC_insert_Account_Request", param);



        }


        public DataTable P_AM_Get_Account_request_dgv(string search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parma = new SqlParameter[1];
            parma[0] = new SqlParameter("@search", SqlDbType.NVarChar, 100);
            parma[0].Value = search;
            dt = DAL.SelectData("P_AM_Get_Account_request_dgv", parma);
            DAL.Close();
            return dt;


        }

        public void P_AC_insert_Account_LMT
                                   (
                                      string Account_ID,
                                      string A_N,
                                      string currency_Key,
                                      int MIN_AMT,
                                      int MAX_AMT,
                                      int MIN_TRNS_AMT,
                                     int  MAX_TRNS_AMT
                                     ,bool EXCEED_LMT
                                     ,bool DR_CR
                                     , string LMT_DESC
                                     , bool INACTIVE
            )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@Account_ID", SqlDbType.NVarChar, 15);
            param[0].Value = Account_ID;

            param[1] = new SqlParameter("@A_N", SqlDbType.NVarChar, 10);
            param[1].Value = A_N;


            param[2] = new SqlParameter("@currency_Key", SqlDbType.NVarChar, (50));
            param[2].Value = currency_Key;
      
            param[3] = new SqlParameter("@MIN_AMT", SqlDbType.Int);
            param[3].Value = MIN_AMT;


            param[4] = new SqlParameter("@MAX_AMT", SqlDbType.Int);
            param[4].Value = MAX_AMT;

            param[5] = new SqlParameter("@MIN_TRNS_AMT", SqlDbType.Int);
            param[5].Value = MIN_TRNS_AMT;

            param[6] = new SqlParameter("@MAX_TRNS_AMT", SqlDbType.Int);
            param[6].Value = MAX_TRNS_AMT;

            param[7] = new SqlParameter("@EXCEED_LMT", SqlDbType.Bit);
            param[7].Value = EXCEED_LMT;

            param[8] = new SqlParameter("@DR_CR", SqlDbType.Bit);
            param[8].Value = DR_CR;

            param[9] = new SqlParameter("@LMT_DESC", SqlDbType.NVarChar);
            param[9].Value = LMT_DESC;

            param[10] = new SqlParameter("@INACTIVE", SqlDbType.Bit);
            param[10].Value = INACTIVE;

            param[11] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[11].Value = PL.main.Use_id;

            DAL.Executecommade("P_AC_insert_Account_LMT", param);
        }


    }
    
}
