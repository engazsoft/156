using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace trader_app.BL
{
    class INV_Inventory_Class
    {
       
        public DataTable P_INV_Get_Inventory()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            dt = DAL.SelectData("P_INV_Get_Inventory", null);
            DAL.Close();
            dt.Dispose();
            return dt;

        }
        //        create proc p_INV_insert_Movmant_Line
        //@line_num int,
        //@Movmant_ID int,
        //           @Product_ID int
        //           ,@UnitCost money
        //           , @Units_ID int
        //           ,@Quantity float

        public void p_INV_insert_Product_Movmant_Line(
int line_num,
int Movmant_ID,
string Product_ID,
decimal UnitCost,
string Units_ID,
decimal Quantity,
decimal Quantity_out
)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@line_num ", SqlDbType.Int);
            param[0].Value = line_num;

            param[1] = new SqlParameter("@Movmant_ID", SqlDbType.Int);
            param[1].Value = Movmant_ID;

            param[2] = new SqlParameter("@Product_ID", SqlDbType.NVarChar,30);
            param[2].Value = Product_ID;

            param[3] = new SqlParameter("@UnitCost", SqlDbType.Money);
            param[3].Value = UnitCost;

            param[4] = new SqlParameter("@Units_ID", SqlDbType.NVarChar,10);
            param[4].Value = Units_ID;

            param[5] = new SqlParameter("@Quantity", SqlDbType.Float);
            param[5].Value = Quantity;
            param[6] = new SqlParameter("@Quantity_out", SqlDbType.Float);
            param[6].Value = Quantity_out;
            DAL.Executecommade("p_INV_insert_Product_Movmant_Line", param);
        }
     
  
        public void P_INV_insert_Peoduct_Movmant(
 int Movmant_num,
 int Invontory_ID,
 int Invontory_dis_ID,
 string MovementDate,
 int Documant_Type_ID,
 bool real,
 string Note,
 string Reason,
 bool deported,
 bool stops
            , int Cost_center 
 )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[13];
            param[0] = new SqlParameter("@Movmant_num ", SqlDbType.Int);
            param[0].Value = Movmant_num;

            param[1] = new SqlParameter("@Invontory_ID", SqlDbType.Int);
            param[1].Value = Invontory_ID;

            param[2] = new SqlParameter("@Invontory_dis_ID", SqlDbType.Int);
            param[2].Value = Invontory_dis_ID;

            param[3] = new SqlParameter("@FYear", SqlDbType.Int);
            param[3].Value = PL.main.Fyear;

            param[4] = new SqlParameter("@MovementDate", SqlDbType.Date);
            param[4].Value = MovementDate;

            param[5] = new SqlParameter("@Documant_Type_ID", SqlDbType.Int);
            param[5].Value = Documant_Type_ID;
            
            param[6] = new SqlParameter("@real", SqlDbType.Bit);
            param[6].Value = real;

            param[7] = new SqlParameter("@Note", SqlDbType.NVarChar);
            param[7].Value = Note;

            param[8] = new SqlParameter("@Reason", SqlDbType.NVarChar);
            param[8].Value = Reason;

            param[9] = new SqlParameter("@deported", SqlDbType.Bit);
            param[9].Value = deported;

            param[10] = new SqlParameter("@stops", SqlDbType.Bit);
            param[10].Value = stops;

            param[11] = new SqlParameter("@Cost_center", SqlDbType.Int);
            param[11].Value = Cost_center;

            param[12] = new SqlParameter("@by_user", SqlDbType.NVarChar);
            param[12].Value = PL.main.Use_id ;
            DAL.Executecommade("P_INV_insert_Peoduct_Movmant", param);
        }
        public void p_INV_insert_Inventorys(
int Invontory_ID,
string Inventory_A_N,
string Inventory_E_N,
string Storekeepr,
string Inventory_Location,
string phone_num,
int Sequence,
int Country_ID,
bool Primery_Store,
int Gov_id,
int Distinct_id,
int Account_ID,
int Inventory_Group_ID,
bool For_sale,
bool stop
)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[17];
            param[0] = new SqlParameter("@Invontory_ID ", SqlDbType.Int);
            param[0].Value = Invontory_ID;

            param[1] = new SqlParameter("@Inventory_A_N", SqlDbType.NVarChar);
            param[1].Value = Inventory_A_N;

            param[2] = new SqlParameter("@Inventory_E_N", SqlDbType.NVarChar);
            param[2].Value = Inventory_E_N;

            param[3] = new SqlParameter("@Storekeepr", SqlDbType.NVarChar);
            param[3].Value = Storekeepr;

            param[4] = new SqlParameter("@Inventory_Location", SqlDbType.NVarChar);
            param[4].Value = Inventory_Location;

            param[5] = new SqlParameter("@phone_num", SqlDbType.NVarChar);
            param[5].Value = phone_num;

            param[6] = new SqlParameter("@Sequence", SqlDbType.Int);
            param[6].Value = Sequence;

            param[7] = new SqlParameter("@Country_ID", SqlDbType.Int);
            param[7].Value = Country_ID;

            param[8] = new SqlParameter("@Primery_Store", SqlDbType.Bit);
            param[8].Value = Primery_Store;

            param[9] = new SqlParameter("@Gov_id", SqlDbType.Int);
            param[9].Value = Gov_id;

            param[10] = new SqlParameter("@Distinct_id", SqlDbType.Int);
            param[10].Value = Distinct_id;

            param[11] = new SqlParameter("@Btanch_ID", SqlDbType.Int);
            param[11].Value = PL.main.Btanch_ID;

            param[12] = new SqlParameter("@Account_ID", SqlDbType.Int);
            param[12].Value = Account_ID;

            param[13] = new SqlParameter("@Inventory_Group_ID", SqlDbType.Int);
            param[13].Value = Inventory_Group_ID;

            param[14] = new SqlParameter("@For_sale", SqlDbType.Bit);
            param[14].Value = For_sale;

            param[15] = new SqlParameter("@stop", SqlDbType.Bit);
            param[15].Value = stop;
      
            param[16] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[16].Value = PL.main.Use_id;

            DAL.Executecommade("p_INV_insert_Inventorys", param);
        }

        //internal void P_insert_inventory(int v1, string text1, string text2, string text3, string text4, string text5, int v2, int v3, bool checked1, int v4, int v5, object p, int v6, bool checked2, bool checked3)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
