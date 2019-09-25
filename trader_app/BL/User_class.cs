using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace trader_app.BL
{
    
 
    class User_class
    {
        
        public DataTable proc_Add_User()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("proc_Add_User", null);
            DAL.Close();
            return dt;

        }

        public DataTable PROC_User_previllege_all_user()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("PROC_User_previllege_all_user", null);
            DAL.Close();
            return dt;

        }
        DAL.Databas_Class DB = new DAL.Databas_Class();
        public DataRow get_User(string User_id)
        {
            DB = new DAL.Databas_Class();
            DataRow User_info = DB.select_Row("V_user_sam", "U_ID", User_id);
            if (User_info != null)
            {
                return User_info;
            }
            else
                return null;

        }
        public DataTable proc_Search_User()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("proc_Search_User", null);
            DAL.Close();
            return dt;

        }

        public DataTable PROC_User_info(string user_name, string password)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            param[0].Value = user_name;
            param[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            param[1].Value = password;

            dt = DAL.SelectData("PROC_User_info", param);
            DAL.Close();
            return dt;

        }
        public DataTable PROC_User_previllege(string Employee_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar);
            param[0].Value = Employee_ID;

            dt = DAL.SelectData("PROC_User_previllege", param);
            DAL.Close();
            return dt;

        }
        public DataTable proc_Search_User(string search)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
            param[0].Value = search;

            dt = DAL.SelectData("proc_Search_User", param);
            DAL.Close();
            return dt;

        }

        public DataTable proc_searech_user_emp_name(string Employee_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = Employee_ID;

            dt = DAL.SelectData("proc_searech_user_emp_name", param);
            DAL.Close();
            return dt;

        }



        public DataTable proc_usr_privileges(string Username)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            param[0].Value = Username;

            dt = DAL.SelectData("proc_usr_privileges",param);
            DAL.Close();
            return dt;

        }
        public void proc_Add_User(string Username, string Password, string Employee_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            param[0].Value = Username;

            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            param[1].Value = Password;

            param[2] = new SqlParameter("@id", SqlDbType.NChar, 10);
            param[2].Value = Employee_ID;


            DAL.Executecommade("proc_Add_User", param);
            DAL.Close();

        }
        public void proc_Edit_User(string Username, string Password, string Employee_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            param[0].Value = Username;

            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            param[1].Value = Password;

            param[2] = new SqlParameter("@id", SqlDbType.NChar, 10);
            param[2].Value = Employee_ID;


            DAL.Executecommade("proc_Edit_User", param);
            DAL.Close();

        }
        public void proc_Delete_User(string username)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@username", SqlDbType.NChar, 10);
            param[0].Value = username;


            DAL.Executecommade("proc_Delete_User", param);
            DAL.Close();

        }

        public void proc_privileges(
           string Username
           , string Password
           , string Employee_ID
           , string Add_emp
           , string Edit_emp
           , string Record_att
           , string Process_att
           , string summarize
           , string Add_task
           , string Rating_emp
           , string Issue_payroll
           , string process_Payroll
           , string Issue_dues
           , string Issue_sancation
           , string Issue_att_report
           , string Issue_alerts_report
           , string Issue_ins_report
            , string Add_User
            )
         
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[18];
         
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            param[0].Value = Username;

            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar,50);
            param[1].Value = Password;

            param[2] = new SqlParameter("@Employee_ID", SqlDbType.NVarChar,5);
            param[2].Value = Employee_ID;

            param[3] = new SqlParameter("@Add_emp", SqlDbType.NVarChar,5);
            param[3].Value = Add_emp;

            param[4] = new SqlParameter("@Edit_emp", SqlDbType.NVarChar,5);
            param[4].Value = Edit_emp;

            param[5] = new SqlParameter("@Record_att", SqlDbType.NVarChar,5);
            param[5].Value = Record_att;

            param[6] = new SqlParameter("@Process_att", SqlDbType.NVarChar,5);
            param[6].Value = Process_att;

            param[7] = new SqlParameter("@summarize", SqlDbType.NVarChar,5);
            param[7].Value = summarize;

            param[8] = new SqlParameter("@Add_task", SqlDbType.NVarChar,5);
            param[8].Value = Add_task;

            param[9] = new SqlParameter("@Rating_emp", SqlDbType.NVarChar,5);
            param[9].Value = Rating_emp;

            param[10] = new SqlParameter("@Issue_payroll", SqlDbType.NVarChar,5);
            param[10].Value = Issue_payroll;


            param[11] = new SqlParameter("@process_Payroll", SqlDbType.NVarChar,5);
            param[11].Value = process_Payroll;

            param[12] = new SqlParameter("@Issue_dues", SqlDbType.NVarChar,5);
            param[12].Value = Issue_dues;

            param[13] = new SqlParameter("@Issue_sancation", SqlDbType.NVarChar,5);
            param[13].Value = Issue_sancation;


            param[14] = new SqlParameter("@Issue_att_report", SqlDbType.NVarChar,5);
            param[14].Value = Issue_att_report;

            param[15] = new SqlParameter("@Issue_alerts_report", SqlDbType.NVarChar,5);
            param[15].Value = Issue_alerts_report;

            param[16] = new SqlParameter("@Issue_ins_report", SqlDbType.NVarChar,5);
            param[16].Value = Issue_ins_report;

            param[17] = new SqlParameter("@Add_User", SqlDbType.NVarChar,5);
            param[17].Value = Add_User;


        

            DAL.Executecommade("proc_privileges", param);



        }

        //        create proc Ath_insert_branch_User
        //@branch_ID int
        //,@User_ID int
        //,@Show bit
        //, @Add bit
        //,@by_user nvarchar(50)
        //as

        public void P_Ath_insert_branch_User(int branch_id,int user_id, bool Show, bool Add)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[0].Value = branch_id;

            param[1] = new SqlParameter("@user_id", SqlDbType.Int);
            param[1].Value =user_id;

            param[2] = new SqlParameter("@Show", SqlDbType.Bit);
            param[2].Value = Show;

            param[3] = new SqlParameter("@Add", SqlDbType.Bit);
            param[3].Value = Add;

            param[4] = new SqlParameter("@by_user", SqlDbType.NVarChar);
            param[4].Value = PL.main.Use_id;

            DAL.Executecommade("P_Ath_insert_branch_User", param);
            DAL.Close();

        }
//        create proc[dbo].[P_Ath_insert_invantory_User]
//        @Inventory_ID int
//,@User_ID int
//,@Show bit
//, @Add bit
//,@by_user nvarchar(50)
        public void P_Ath_insert_invantory_User(int Inventory_ID, int user_id, bool Show, bool Add)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Inventory_ID", SqlDbType.Int);
            param[0].Value = Inventory_ID;

            param[1] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[1].Value = user_id;

            param[2] = new SqlParameter("@Show", SqlDbType.Bit);
            param[2].Value = Show;

            param[3] = new SqlParameter("@Add", SqlDbType.Bit);
            param[3].Value = Add;

            param[4] = new SqlParameter("@by_user", SqlDbType.NVarChar);
            param[4].Value = PL.main.Use_id;

            DAL.Executecommade("P_Ath_insert_invantory_User", param);
            DAL.Close();

        }


        public void P_Ath_insert_Cash_In_Hand_User
            (
            int User_ID
           ,string A_CODE
           ,bool Show,
            bool Add)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[0].Value = User_ID;

            param[1] = new SqlParameter("@A_CODE", SqlDbType.NVarChar,30);
            param[1].Value = A_CODE;

            param[2] = new SqlParameter("@Show", SqlDbType.Bit);
            param[2].Value = Show;

            param[3] = new SqlParameter("@Add", SqlDbType.Bit);
            param[3].Value = Add;

            param[4] = new SqlParameter("@by_user", SqlDbType.NVarChar);
            param[4].Value = PL.main.Use_id;

            DAL.Executecommade("P_Ath_insert_Cash_In_Hand_User", param);
            DAL.Close();

        }

        public void P_Ath_insert_Cash_Bank_User
           (
           int User_ID
          , string A_CODE
          , bool Show,
           bool Add)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[0].Value = User_ID;

            param[1] = new SqlParameter("@A_CODE", SqlDbType.NVarChar, 30);
            param[1].Value = A_CODE;

            param[2] = new SqlParameter("@Show", SqlDbType.Bit);
            param[2].Value = Show;

            param[3] = new SqlParameter("@Add", SqlDbType.Bit);
            param[3].Value = Add;

            param[4] = new SqlParameter("@by_user", SqlDbType.NVarChar);
            param[4].Value = PL.main.Use_id;

            DAL.Executecommade("P_Ath_insert_Cash_Bank_User", param);
            DAL.Close();

        }

    }
}
