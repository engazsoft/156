using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace trader_app.BL
{
    class AM_Employees_Class
    {
        //     P_AM_insert_AM_Employees]
        //@Employee_ID int
        //        ,@A_N nvarchar(50)
        //        ,@E_N nvarchar(50)
        //        ,@Management_ID int
        //        ,@Job nvarchar(50)
        //        ,@super_Employee_ID int
        //        ,@Hier_Date date
        //        , @Salary money
        //        ,@Qualified nvarchar(50)
        //        ,@Phone_num nvarchar(13)
        //        ,@Phone_num_1 nvarchar(13)
        //        ,@Out_Serves_Date date
        //        , @Email nvarchar(50)
        //        ,@Address nvarchar(50)
        //        ,@Delegate_ID int
        //        ,@Stop bit
        //        , @Reason_of_Stop nvarchar(max)
        //        ,@Stop_Date date
        //        , @Management_ID1 int
        // ,@Note nvarchar(max)
        //  ,@by_user nvarchar(50)
        public void P_AM_insert_AM_Employees(
int Employee_ID,
string A_N,
string E_N,
int Management_ID,
string Job,
int super_Employee_ID,
string Hier_Date,
string Salary,
int Qualified_ID,
string Phone_num,
string Phone_num_1,
string Out_Serves_Date,
string Email,
string Address,
int Delegate_ID,
bool Stop,
string Reason_of_Stop,
string Stop_Date,
string Note


)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[20];
            param[0] = new SqlParameter("@Employee_ID ", SqlDbType.Int);
            param[0].Value = Employee_ID;

            param[1] = new SqlParameter("@A_N", SqlDbType.NVarChar);
            param[1].Value = A_N;

            param[2] = new SqlParameter("@E_N", SqlDbType.NVarChar);
            param[2].Value = E_N;

            param[3] = new SqlParameter("@Management_ID", SqlDbType.Int);
            param[3].Value = Management_ID;

            param[4] = new SqlParameter("@Job", SqlDbType.NVarChar);
            param[4].Value = Job;

            param[5] = new SqlParameter("@super_Employee_ID", SqlDbType.Int);
            param[5].Value = super_Employee_ID;

            param[6] = new SqlParameter("@Hier_Date", SqlDbType.Date);
            param[6].Value = Hier_Date;

            param[7] = new SqlParameter("@Salary", SqlDbType.Money);
            param[7].Value = Salary;

            param[8] = new SqlParameter("@Qualified_ID", SqlDbType.Int);
            param[8].Value = Qualified_ID;

            param[9] = new SqlParameter("@Phone_num", SqlDbType.NVarChar);
            param[9].Value = Phone_num;

            param[10] = new SqlParameter("@Phone_num_1", SqlDbType.NVarChar);
            param[10].Value = Phone_num_1;

            param[11] = new SqlParameter("@Out_Serves_Date", SqlDbType.Date);
            param[11].Value = Out_Serves_Date;

            param[12] = new SqlParameter("@Email", SqlDbType.NVarChar);
            param[12].Value = Email;

            param[13] = new SqlParameter("@Address", SqlDbType.NVarChar);
            param[13].Value = Address;

            param[14] = new SqlParameter("@Delegate_ID", SqlDbType.Int);
            param[14].Value = Delegate_ID;

            param[15] = new SqlParameter("@Stop", SqlDbType.Bit);
            param[15].Value = Stop;

            param[16] = new SqlParameter("@Reason_of_Stop", SqlDbType.NVarChar);
            param[16].Value = Reason_of_Stop;

            param[17] = new SqlParameter("@Stop_Date", SqlDbType.NVarChar, 50);
            param[17].Value = Stop_Date;

            param[18] = new SqlParameter("@Note", SqlDbType.NVarChar);
            param[18].Value = Note;

            param[19] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[19].Value = PL.main.Use_id;

            DAL.Executecommade("P_AM_insert_AM_Employees", param);
        }
    }
}
