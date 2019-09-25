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

    class AC_Cash_in_hand
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

        public void P_AC_insert_CASH_IN_HAND(
            int CASH_NO
           , string CASH_NAME_A
           , string CASH_E_NAME
           , string A_CODE
           , string CASH_SR
           , string Account_NAME
           , int CASH_TYPE_id
           , bool POS_SYS
           , int CONN_BRN_NO
           , bool INACTIVE
           , string INACTIVE_DATE
           , string INACTIVE_RES
          

                                       )
        {
            

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[13];
            param[0] = new SqlParameter("@CASH_NO", SqlDbType.Int);
            param[0].Value = CASH_NO;

            param[1] = new SqlParameter("@CASH_NAME", SqlDbType.NVarChar, 60);
            param[1].Value = CASH_NAME_A;

            param[2] = new SqlParameter("@CASH_E_NAME", SqlDbType.NVarChar, 60);
            param[2].Value = CASH_E_NAME;


            param[3] = new SqlParameter("@A_CODE", SqlDbType.NVarChar, 30);
            param[3].Value = A_CODE;

            param[4] = new SqlParameter("@CASH_SR", SqlDbType.NVarChar,30);
            param[4].Value = CASH_SR;

            param[5] = new SqlParameter("@Account_NAME", SqlDbType.NVarChar,50);
            param[5].Value = Account_NAME;

            param[6] = new SqlParameter("@CASH_TYPE_id", SqlDbType.Int);
            param[6].Value = CASH_TYPE_id;

            param[7] = new SqlParameter("@POS_SYS", SqlDbType.Bit);
            param[7].Value = POS_SYS;

            param[8] = new SqlParameter("@CONN_BRN_NO", SqlDbType.Int);
            param[8].Value = CONN_BRN_NO;

            param[9] = new SqlParameter("@INACTIVE", SqlDbType.Bit);
            param[9].Value = INACTIVE;

            param[10] = new SqlParameter("@INACTIVE_DATE", SqlDbType.Date);
            param[10].Value = INACTIVE_DATE;

            param[11] = new SqlParameter("@INACTIVE_RES", SqlDbType.NVarChar,250);
            param[11].Value = INACTIVE_RES;

            param[12] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[12].Value = PL.main.Use_id;



            DAL.Executecommade("P_AC_insert_CASH_IN_HAND", param);
        }
        
      
    }
}
