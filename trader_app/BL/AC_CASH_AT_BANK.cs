using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace trader_app.BL
{
    class AC_CASH_AT_BANK
    {

        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

        public void P_AC_insert_CASH_AT_BANK
        (

           int BANK_NO
           , string BANK_NAME_A
           , string BANK_NAME_E
           , string A_CODE
           , string BANK_SR
           , string AC_Bank_Name
           , string BANK_ACC
           , int CONN_BRN_NO
           , string B_TEL
           , string B_FAX
           , string B_BOX
           , string B_ADDRESS
           , string B_E_MAIL
           , string B_WEB_SITE
           , bool MEDIATOR
           , bool INACTIVE
           , string INACTIVE_DATE
           , string INACTIVE_RES
           , byte[] BANK_IMG
           , string REC_LETTER
           , string PAY_LETTER

           )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[22];
            param[0] = new SqlParameter("@BANK_NO", SqlDbType.Int);
            param[0].Value = @BANK_NO;

            param[1] = new SqlParameter("@BANK_NAME_A", SqlDbType.NVarChar, 60);
            param[1].Value = BANK_NAME_A;

            param[2] = new SqlParameter("@BANK_NAME_E", SqlDbType.NVarChar, 60);
            param[2].Value = BANK_NAME_E;

            param[3] = new SqlParameter("@A_CODE", SqlDbType.NVarChar, 30);
            param[3].Value = A_CODE;

            param[4] = new SqlParameter("@BANK_SR", SqlDbType.NVarChar);
            param[4].Value = BANK_SR;

            param[5] = new SqlParameter("@AC_Bank_Name", SqlDbType.NVarChar, 30);
            param[5].Value = AC_Bank_Name;

            param[6] = new SqlParameter("@BANK_ACC", SqlDbType.NVarChar, 30);
            param[6].Value = BANK_ACC;

            param[7] = new SqlParameter("@CONN_BRN_NO", SqlDbType.Int);
            param[7].Value = CONN_BRN_NO;

            param[8] = new SqlParameter("@B_TEL", SqlDbType.NVarChar, 30);
            param[8].Value = B_TEL;

            param[9] = new SqlParameter("@B_FAX", SqlDbType.NVarChar, 30);
            param[9].Value = B_FAX;

            param[10] = new SqlParameter("@B_BOX", SqlDbType.NVarChar, 10);
            param[10].Value = B_BOX;

            param[11] = new SqlParameter("@B_ADDRESS", SqlDbType.NVarChar, 60);
            param[11].Value = B_ADDRESS;

            param[12] = new SqlParameter("@B_E_MAIL", SqlDbType.NVarChar,50);
            param[12].Value = B_E_MAIL;

            param[13] = new SqlParameter("@B_WEB_SITE", SqlDbType.NVarChar,50);
            param[13].Value = B_WEB_SITE;

            param[14] = new SqlParameter("@MEDIATOR", SqlDbType.Bit);
            param[14].Value = MEDIATOR;

            param[15] = new SqlParameter("@INACTIVE", SqlDbType.Bit);
            param[15].Value = INACTIVE;

            param[16] = new SqlParameter("@INACTIVE_DATE", SqlDbType.Date);
            param[16].Value = INACTIVE_DATE;

            param[17] = new SqlParameter("@INACTIVE_RES", SqlDbType.NVarChar, 250);
            param[17].Value = INACTIVE_RES;

            param[18] = new SqlParameter("@BANK_IMG", SqlDbType.Image);
            param[18].Value = BANK_IMG;

            param[19] = new SqlParameter("@REC_LETTER", SqlDbType.NVarChar,30);
            param[19].Value = REC_LETTER;

            param[20] = new SqlParameter("@PAY_LETTER", SqlDbType.NVarChar,30);
            param[20].Value = PAY_LETTER;

            param[21] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[21].Value = PL.main.Use_id;



            DAL.Executecommade("P_AC_insert_CASH_AT_BANK", param);
        }


    }
}
