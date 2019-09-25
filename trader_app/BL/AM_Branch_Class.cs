using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace trader_app.BL
{
    class AM_Branch_Class
    {
        //   ALTER proc[dbo].[P_AM_insert_Branches]
        //   @Branch_ID int,
        //      @Branch_A_N nvarchar(30),
        //      @Branch_E_N nvarchar(30),
        //      @Phone_num nvarchar(15),
        //@location nvarchar(50),
        //      @Fax_num nvarchar(15),
        //      @Mail_box nvarchar(15),
        //      @B_F_Tele nvarchar(15),
        //      @B_F_Box nvarchar(15),
        //      @B_F_Fax nvarchar(15),
        //      @A_note nvarchar(max),
        //      @E_note nvarchar(50),
        //      @Tax_num nvarchar(30),
        //@year_id nvarchar(5),
        //      @Company_ID int,
        //@Branch_Image image,
        //      @Country_ID int,
        //@Gov_id int,
        //@Distinct_id int,
        //      @by_user nvarchar(50)
        public void P_AM_insert_Branches(
   int Branch_ID,
   string Branch_A_N,
   string Branch_E_N,
   string Phone_num,
   string location,
   string Fax_num,
   string Mail_box,
   string B_F_Tele,
   string  B_F_Box,
   string B_F_Fax,
   string A_note,
   string E_note,
   string Tax_num,
   string year_id,
   int Company_ID,
   Byte[] Branch_Image,
   int Country_ID,
   int Gov_id,
   int Distinct_id
  
   )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[20];
            param[0] = new SqlParameter("@Branch_ID ", SqlDbType.Int);
            param[0].Value = Branch_ID;

            param[1] = new SqlParameter("@Branch_A_N", SqlDbType.NVarChar);
            param[1].Value = Branch_A_N;

            param[2] = new SqlParameter("@Branch_E_N", SqlDbType.NVarChar);
            param[2].Value = Branch_E_N;

            param[3] = new SqlParameter("@Phone_num", SqlDbType.NVarChar);
            param[3].Value = Phone_num;

            param[4] = new SqlParameter("@location", SqlDbType.NVarChar);
            param[4].Value = location;

            param[5] = new SqlParameter("@Mail_box", SqlDbType.NVarChar);
            param[5].Value = Mail_box;

            param[6] = new SqlParameter("@Fax_num", SqlDbType.NVarChar);
            param[6].Value = Fax_num;

            param[7] = new SqlParameter("@B_F_Tele", SqlDbType.NVarChar);
            param[7].Value = B_F_Tele;

            
            param[8] = new SqlParameter("@B_F_Box", SqlDbType.NVarChar);
            param[8].Value = B_F_Box;

            param[9] = new SqlParameter("@B_F_Fax", SqlDbType.NVarChar);
            param[9].Value = B_F_Fax;


            param[10] = new SqlParameter("@A_note", SqlDbType.NVarChar);
            param[10].Value = A_note;

            param[11] = new SqlParameter("@E_note", SqlDbType.NVarChar);
            param[11].Value = E_note;

            param[12] = new SqlParameter("@Tax_num", SqlDbType.NVarChar);
            param[12].Value = Tax_num;

            param[13] = new SqlParameter("@year_id", SqlDbType.NVarChar);
            param[13].Value = year_id;

            param[14] = new SqlParameter("@Company_ID", SqlDbType.Int);
            param[14].Value = Company_ID;

            param[15] = new SqlParameter("@Branch_Image", SqlDbType.Image);
            param[15].Value = Branch_Image;

            param[16] = new SqlParameter("@Country_ID", SqlDbType.Int);
            param[16].Value = Country_ID;

            param[17] = new SqlParameter("@Gov_id", SqlDbType.Int);
            param[17].Value = Gov_id;

            param[18] = new SqlParameter("@Distinct_id", SqlDbType.Bit);
            param[18].Value = Distinct_id;

            param[19] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[19].Value = PL.main.Use_id;

            DAL.Executecommade("P_AM_insert_Branches", param);
        }

    }
}
