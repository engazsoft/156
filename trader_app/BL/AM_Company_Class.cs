using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace trader_app.BL
{
    class AM_Company_Class
    {
     
             public void p_AM_insert_Company(
       int Company_ID,
       string Company_A_N,
       string Company_E_N,
       string A_N
       , string E_N
       , string Note
      , int Group_ID
      , int Country_ID
     , byte[] Image
    

       )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@Company_ID", SqlDbType.Int);
            param[0].Value = Company_ID;

            param[1] = new SqlParameter("@Company_A_N", SqlDbType.NVarChar,30);
            param[1].Value = Company_A_N;

            param[2] = new SqlParameter("@Company_E_N", SqlDbType.NVarChar,30);
            param[2].Value = Company_E_N;

            param[3] = new SqlParameter("@A_N", SqlDbType.NVarChar,5);
            param[3].Value = A_N;

            param[4] = new SqlParameter("@E_N", SqlDbType.NVarChar,5);
            param[4].Value = E_N;

            param[5] = new SqlParameter("@Note", SqlDbType.NVarChar, 50);
            param[5].Value = Note;

            param[6] = new SqlParameter("@Group_ID", SqlDbType.Int);
            param[6].Value = Group_ID;

            param[7] = new SqlParameter("@Country_ID", SqlDbType.Int);
            param[7].Value = Country_ID;

            param[8] = new SqlParameter("@Image", SqlDbType.Image);
            param[8].Value = @Image;


            param[9] = new SqlParameter("@py_user", SqlDbType.NVarChar,50);
            param[9].Value =PL.main.Use_id;

            DAL.Executecommade("p_AM_insert_Company", param);



        }
    }


}
