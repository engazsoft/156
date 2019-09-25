using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace trader_app.BL
{
    class SUP_vendor
    {

        public void P_SUP_insert_VENDOR_CLASS
                                 (
                                                int V_CLASS,
                                                string V_CLASS_NAME,
                                                string V_CLASS_E_NAME
   

                               )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@V_CLASS", SqlDbType.Int);
            param[0].Value = V_CLASS;

            param[1] = new SqlParameter("@V_CLASS_NAME", SqlDbType.NVarChar);
            param[1].Value = V_CLASS_NAME;

            param[2] = new SqlParameter("@V_CLASS_E_NAME", SqlDbType.NVarChar);
            param[2].Value = V_CLASS_E_NAME;

            param[3] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[3].Value = PL.main.Use_id;

            DAL.Executecommade("P_SUP_insert_VENDOR_CLASS", param);
        }
     

              public void P_IAS_insert_VENDOR_DEGREE
                                 (
                                                int V_DEGREE,
                                                string V_DEGREE_A_NAME,
                                                string V_DEGREE_E_NAME
                               )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@V_DEGREE", SqlDbType.Int);
            param[0].Value = V_DEGREE;

            param[1] = new SqlParameter("@V_DEGREE_A_NAME", SqlDbType.NVarChar);
            param[1].Value = V_DEGREE_A_NAME;

            param[2] = new SqlParameter("@V_DEGREE_E_NAME", SqlDbType.NVarChar);
            param[2].Value = V_DEGREE_E_NAME;

            param[3] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[3].Value = PL.main.Use_id;

            DAL.Executecommade("P_IAS_insert_VENDOR_DEGREE", param);
        }

        public void P_IAS_insert_PORDER_TYPES
                                (
                                               int    PO_TYPE,
                                               string PO_A_NAME,
                                               string PO_E_NAME
                               )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@PO_TYPE", SqlDbType.Int);
            param[0].Value = PO_TYPE;

            param[1] = new SqlParameter("@PO_A_NAME", SqlDbType.NVarChar);
            param[1].Value = PO_A_NAME;

            param[2] = new SqlParameter("@PO_E_NAME", SqlDbType.NVarChar);
            param[2].Value = PO_E_NAME;

            param[3] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[3].Value = PL.main.Use_id;

            DAL.Executecommade("P_IAS_insert_PORDER_TYPES", param);
        }

    
        public void P_IAS_insert_PREQ_TYPES

                                (
                                               int PR_TYPE,
                                               string PR_A_NAME,
                                               string PR_E_NAME
                               )
                      {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@PR_TYPE", SqlDbType.Int);
            param[0].Value = PR_TYPE;

            param[1] = new SqlParameter("@PR_A_NAME", SqlDbType.NVarChar);
            param[1].Value = PR_A_NAME;

            param[2] = new SqlParameter("@PR_E_NAME", SqlDbType.NVarChar);
            param[2].Value = PR_E_NAME;

            param[3] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[3].Value = PL.main.Use_id;

            DAL.Executecommade("P_IAS_insert_PREQ_TYPES", param);
        }

  public void P_SUP_insert_VENDOR_GROUP

                                (
                                               int V_GROUP_CODE,
                                               string V_GROUP_A_NAME,
                                               string V_GROUP_E_NAME,
                                                string V_ACCOUNT_ID
                               )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@V_GROUP_CODE", SqlDbType.Int);
            param[0].Value = V_GROUP_CODE;

            param[1] = new SqlParameter("@V_GROUP_A_NAME", SqlDbType.NVarChar);
            param[1].Value = V_GROUP_A_NAME;

            param[2] = new SqlParameter("@V_GROUP_E_NAME", SqlDbType.NVarChar);
            param[2].Value = V_GROUP_E_NAME;

            param[3] = new SqlParameter("@V_ACCOUNT_ID", SqlDbType.NVarChar);
            param[3].Value = V_ACCOUNT_ID;

            param[4]= new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[4].Value = PL.main.Use_id;

            DAL.Executecommade("P_SUP_insert_VENDOR_GROUP", param);
        }
        public void P_Sup_insert_V_DETAILS

                                (
                                                 string V_CODE,
                                                 string V_A_NAME,
                                                 string V_E_NAME,
                                                 string Account_ID,
                                                 int V_GROUP_CODE,
                                                 int V_CLASS,
                                                 int V_DEGREE,
                                                 string V_TAX_CODE,
                                                 string V_ADDRESS,
                                                 int Country_ID,
                                                 int Gov_id,
                                                 int Cost_Center_ID,
                                                 string V_PHONE,
                                                 string V_FAX,
                                                 string V_BOX,
                                                 string V_E_MAIL,
                                                 string V_WEB_SITE,
                                                 string V_MOBILE,
                                                 string V_SINCE,
                                                 bool INACTIVE,
                                                 string V_NOTE,
                                                 bool BLK_LST,
                                                 string BLK_LST_RES,
                                                 int CREDIT_PERIOD,
                                                 int AC_OP_NO,
                                                 string V_Last_Pyment

                               )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[27];
            param[0] = new SqlParameter("@V_CODE", SqlDbType.NVarChar);
            param[0].Value = V_CODE;

            param[1] = new SqlParameter("@V_A_NAME", SqlDbType.NVarChar);
            param[1].Value = V_A_NAME;

            param[2] = new SqlParameter("@V_E_NAME", SqlDbType.NVarChar);
            param[2].Value = V_E_NAME;

            param[3] = new SqlParameter("@Account_ID", SqlDbType.NVarChar);
            param[3].Value = Account_ID;

            param[4] = new SqlParameter("@V_GROUP_CODE", SqlDbType.Int);
            param[4].Value = V_GROUP_CODE;

            param[5] = new SqlParameter("@V_CLASS", SqlDbType.Int);
            param[5].Value = V_CLASS;

            param[6] = new SqlParameter("@V_DEGREE", SqlDbType.Int);
            param[6].Value = V_DEGREE;


            param[7] = new SqlParameter("@V_TAX_CODE", SqlDbType.NVarChar);
            param[7].Value = V_TAX_CODE;


            param[8] = new SqlParameter("@V_ADDRESS", SqlDbType.NVarChar);
            param[8].Value = V_ADDRESS;
           
            param[9] = new SqlParameter("@V_BOX", SqlDbType.NVarChar);
            param[9].Value = V_BOX;

            param[10] = new SqlParameter("@Country_ID", SqlDbType.Int);
            param[10].Value = Country_ID;

            param[11] = new SqlParameter("@Gov_id", SqlDbType.Int);
            param[11].Value = Gov_id;

            param[12] = new SqlParameter("@Cost_Center_ID", SqlDbType.Int);
            param[12].Value = Cost_Center_ID;

            param[13] = new SqlParameter("@V_PHONE", SqlDbType.NVarChar);
            param[13].Value = V_PHONE;

            param[14] = new SqlParameter("@V_FAX", SqlDbType.NVarChar);
            param[14].Value = V_FAX;

            param[15] = new SqlParameter("@V_E_MAIL", SqlDbType.NVarChar);
            param[15].Value = V_E_MAIL;

            param[16] = new SqlParameter("@V_WEB_SITE", SqlDbType.NVarChar);
            param[16].Value = V_WEB_SITE;

            param[17] = new SqlParameter("@V_MOBILE", SqlDbType.NVarChar);
            param[17].Value = V_MOBILE;

            param[18] = new SqlParameter("@V_SINCE", SqlDbType.Date);
            param[18].Value = V_SINCE;

            param[19] = new SqlParameter("@INACTIVE", SqlDbType.Bit);
            param[19].Value = INACTIVE;

            param[20] = new SqlParameter("@V_NOTE", SqlDbType.NVarChar);
            param[20].Value = V_NOTE;

            param[21] = new SqlParameter("@BLK_LST", SqlDbType.Bit);
            param[21].Value = BLK_LST;

            param[22] = new SqlParameter("@BLK_LST_RES", SqlDbType.NVarChar);
            param[22].Value = BLK_LST_RES;

            param[23] = new SqlParameter("@CREDIT_PERIOD", SqlDbType.Int);
            param[23].Value = CREDIT_PERIOD;

            param[24] = new SqlParameter("@AC_OP_NO", SqlDbType.Int);
            param[24].Value = AC_OP_NO;

            param[25] = new SqlParameter("@V_Last_Pyment", SqlDbType.Date);
            param[25].Value =V_Last_Pyment;

            param[26] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[26].Value = PL.main.Use_id;

            DAL.Executecommade("P_Sup_insert_V_DETAILS", param);
        }
    }
}
