using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace trader_app.BL
{
    
    class AM_Product_type
    {
        public DataTable P_AM_Get_Product_type(string search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Search", SqlDbType.NVarChar);
            param[0].Value = search;
            dt = DAL.SelectData("P_AM_Get_Product_type", param);
            DAL.Close();
            return dt;

        }

        public void p_AM_insert_Product_type(
            int Type_ID,
            string A_N,
            string E_N
            )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Type_ID", SqlDbType.Int);
            param[0].Value = Type_ID;

            param[1] = new SqlParameter("@A_N", SqlDbType.NVarChar);
            param[1].Value = A_N;

            param[2] = new SqlParameter("@E_N", SqlDbType.NVarChar);
            param[2].Value = E_N;

            param[3] = new SqlParameter("@py_user", SqlDbType.NVarChar, 50);
            param[3].Value =PL.main.Use_id;

            DAL.Executecommade("p_AM_insert_Product_type", param);



        }
    }
}
