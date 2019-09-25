using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace trader_app.BL
{
    class INV_inventory_group
    {
        public DataTable p_INV_Get_inventory_group()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            dt = DAL.SelectData("p_INV_Get_inventory_group", null);
            DAL.Close();
            return dt;

        }
        public void p_INV_Insert_inventory_group(
            int Inventory_Group_ID ,
            string @Group_A_N,
            string @Group_A_E,
            int @Account_ID,
            string @py_user )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Inventory_Group_ID ", SqlDbType.Int);
            param[0].Value = Inventory_Group_ID;

            param[1] = new SqlParameter("@Group_A_N", SqlDbType.NVarChar);
            param[1].Value = Group_A_N;

            param[2] = new SqlParameter("@Group_A_E", SqlDbType.NVarChar);
            param[2].Value = Group_A_E;

            param[3] = new SqlParameter("@Account_ID", SqlDbType.NVarChar);
            param[3].Value = Account_ID;

            param[4] = new SqlParameter("@py_user", SqlDbType.NVarChar, 50);
            param[4].Value = py_user;

            DAL.Executecommade("p_INV_Insert_inventory_group", param);
        }



    }
}
