using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace trader_app.BL
{
    class AM_Distinct_Class
    {
      
            public void P_AM_insert_Distinct(
    int Distinct_id,
    int Gov_ID,
    string A_N,
    string E_N

    )
            {

                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@Distinct_id", SqlDbType.Int);
                param[0].Value = Distinct_id;

                param[1] = new SqlParameter("@Gov_ID", SqlDbType.Int);
                param[1].Value = Gov_ID;

                param[2] = new SqlParameter("@A_N", SqlDbType.NVarChar,32);
                param[2].Value = A_N;

                param[3] = new SqlParameter("@E_N", SqlDbType.NVarChar,50);
                param[3].Value = E_N;

                param[4] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
                param[4].Value = PL.main.Use_id;

                DAL.Executecommade("P_AM_insert_Distinct", param);



            }
        }
}
