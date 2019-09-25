using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace trader_app.BL
{

    class AM_Country_Class
    {
        public DataTable P_AM_Get_Country()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            dt = DAL.SelectData("P_AM_Get_Country", null);
            DAL.Close();
            return dt;

        }

        public void P_AM_insert_Country(
       int Country_ID,
       string Country_A_N,
       string Country_E_N,
       int status,
       int currency_ID
       

       )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Country_ID", SqlDbType.Int);
            param[0].Value = Country_ID;

            param[1] = new SqlParameter("@Country_A_N", SqlDbType.NVarChar);
            param[1].Value = Country_A_N;

            param[2] = new SqlParameter("@Country_E_N", SqlDbType.NVarChar);
            param[2].Value = Country_E_N;

            param[3] = new SqlParameter("@status", SqlDbType.Int);
            param[3].Value = status;

            param[4] = new SqlParameter("@currency_ID", SqlDbType.Int);
            param[4].Value = currency_ID;

            param[5] = new SqlParameter("@py_user", SqlDbType.NVarChar,50);
            param[5].Value = PL.main.Use_id;

            DAL.Executecommade("P_AM_insert_Country", param);



        }
    }
}
