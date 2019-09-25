using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace trader_app.BL
{
    class AM_Currency_Class
    {
       
            public DataTable P_AM_get_Currency()
            {
                DataTable dt = new DataTable();
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                dt = DAL.SelectData("P_AM_get_Currency", null);
                DAL.Close();
                return dt;
            
            }
        //        ALTER proc[dbo].[p_AM_insert_Currency]
        //        @currency_ID int
        //,@currency_Key varchar(4)
        //           ,@currency_name nvarchar(50)
        //           ,@currency_name_e varchar(50)
        //           ,@CURR_SNAME nvarchar(50)
        //           ,@part_name nvarchar(50)
        //           ,@locally bit
        //           , @stor_currency bit
        //           ,@price_tans money
        //           , @by_user nvarchar(50)
        public void p_AM_insert_Currency( int currency_ID,
                                         string currency_Key,
                                         string currency_name,
                                         string currency_name_e,
                                         string CURR_SNAME,
                                         string part_name,
                                         bool locally,
                                         bool stor_currency,
                                         bool Used,
                                         string price_tans  )
                                       {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@currency_ID", SqlDbType.Int);
            param[0].Value = currency_ID;

            param[1] = new SqlParameter("@currency_Key", SqlDbType.NVarChar, (4));
            param[1].Value = currency_Key;

            param[2] = new SqlParameter("@currency_name", SqlDbType.NVarChar,(20));
            param[2].Value = currency_name;


            param[3] = new SqlParameter("@currency_name_e", SqlDbType.NVarChar,20);
            param[3].Value = currency_name_e;

            param[4] = new SqlParameter("@CURR_SNAME", SqlDbType.NVarChar, 20);
            param[4].Value = CURR_SNAME;


            param[5] = new SqlParameter("@part_name", SqlDbType.NVarChar, 50);
            param[5].Value = part_name;

            param[6] = new SqlParameter("@locally", SqlDbType.Bit);
            param[6].Value = locally;

            param[7] = new SqlParameter("@stor_currency", SqlDbType.NVarChar, 50);
            param[7].Value = stor_currency;

            param[8] = new SqlParameter("@Used", SqlDbType.Bit);
            param[8].Value = Used;

            param[9] = new SqlParameter("@price_tans", SqlDbType.Money);
            param[9].Value = price_tans;

            param[10] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[10].Value = PL.main.Use_id;

            DAL.Executecommade("p_AM_insert_Currency", param);



        }
    }

}
