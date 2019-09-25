using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace trader_app.BL
{
//    ALTER proc[dbo].[P_AM_insert_Governorate]

//    @Gov_id int,
//@Country_ID int,
//@A_N varchar(32),
//@E_N nvarchar(50),
//@short_name nvarchar(50),
//@gov_type int,
//@by_user nvarchar(50)
    class AM_Governorate_Class
    {
        public void P_AM_insert_Governorate(
int Gov_id,
int Country_ID,
string A_N,
string E_N

)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Gov_id", SqlDbType.Int);
            param[0].Value = Gov_id;

            param[1] = new SqlParameter("@Country_ID", SqlDbType.Int);
            param[1].Value = Country_ID;

            param[2] = new SqlParameter("@A_N", SqlDbType.NVarChar);
            param[2].Value = A_N;

            param[3] = new SqlParameter("@E_N", SqlDbType.NVarChar);
            param[3].Value = E_N;

            param[4] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[4].Value = PL.main.Use_id ;

            DAL.Executecommade("P_AM_insert_Governorate", param);



        }
    }
}
