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
    class Account_AN
    {


        public void P_AC_insert_ACCOUNT_AN
            (                    string Account_ID,
                                  string N_AN,
                                   string A_N
                                
                                  )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Account_ID", SqlDbType.NVarChar);
            param[0].Value = Account_ID;

            param[1] = new SqlParameter("@N_AN", SqlDbType.NVarChar);
            param[1].Value = N_AN;

            param[2] = new SqlParameter("@A_N", SqlDbType.NVarChar);
            param[2].Value = A_N;


            param[3] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[3].Value = PL.main.Use_id;


            DAL.Executecommade("P_AC_insert_ACCOUNT_AN", param);
        }


        public void P_AC_inser_ACCOUNT_AN__CURR
                          (
             
                             string currency_Key,
                               string Account_ID,
                                string N_AN,
                               bool used
                              )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@currency_Key", SqlDbType.NVarChar);
            param[0].Value = currency_Key;

            param[1] = new SqlParameter("@Account_ID", SqlDbType.NVarChar);
            param[1].Value = Account_ID;

            param[2] = new SqlParameter("@N_AN", SqlDbType.NVarChar);
            param[2].Value = N_AN;

            param[3] = new SqlParameter("@Used", SqlDbType.Bit);
            param[3].Value = used;

            DAL.Executecommade("P_AC_inser_ACCOUNT_AN__CURR", param);



        }
    }
}

