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
    class AC_instrument
    {
        BL.process_Class proc = new process_Class();
        public DataRow selec_inst_Row(string Tabel_Nema,string ID,string type)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            try
            {
                return dal.FindDataSet("select * from " + Tabel_Nema + " where Fyear=" + PL.main.Fyear + " and Inst_num=" + ID + "and inst_type =" + type).Rows[0];


            }
            catch (Exception)
            {
                MessageBox.Show("ارجاء التاكد من رقم السجل قد ");
                return null;
            }

        }
        public string instr_num(string type_ID)
        {
            string t = proc.max_num_in_Column("AC_instrument where FYear =" + PL.main.Fyear + " and inst_type="+type_ID, "Inst_num");
            if (t.Length == 0)
            {
                return "1";

            }
            else
                return t;
        }
       
        public void P_AC_insert_instrument(
    int Inst_ID,
    int inst_type,
    string Instrument_Date,
    bool real,
    string Note,
    bool deported,
    bool stops
   , int Cost_center
, string refer_num
, string attach_num
, string currency_Key
, string Account_ID
            ,bool insert
            

    )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@Inst_num ", SqlDbType.SmallInt);
            param[0].Value = Inst_ID;

            param[1] = new SqlParameter("@inst_type", SqlDbType.SmallInt);
            param[1].Value = inst_type;


            param[2] = new SqlParameter("@FYear", SqlDbType.SmallInt);
            param[2].Value = PL.main.Fyear;

            param[3] = new SqlParameter("@Branch_ID", SqlDbType.SmallInt);
            param[3].Value = PL.main.Btanch_ID;

            param[4] = new SqlParameter("@Instrument_Date", SqlDbType.Date);
            param[4].Value = Instrument_Date;

            param[5] = new SqlParameter("@real", SqlDbType.Bit);
            param[5].Value = real;

            param[6] = new SqlParameter("@Note", SqlDbType.NVarChar);
            param[6].Value = Note;

           
            param[7] = new SqlParameter("@deported", SqlDbType.Bit);
            param[7].Value = deported;

            param[8] = new SqlParameter("@stops", SqlDbType.Bit);
            param[8].Value = stops;

            param[9] = new SqlParameter("@Cost_center", SqlDbType.SmallInt);
            param[9].Value = Cost_center;

            param[10] = new SqlParameter("@refer_num", SqlDbType.NVarChar);
            param[10].Value = refer_num;

            param[11] = new SqlParameter("@attach_num", SqlDbType.NVarChar);
            param[11].Value = attach_num;

            param[12] = new SqlParameter("@Account_ID", SqlDbType.NVarChar);
            param[12].Value = Account_ID;

            param[13] = new SqlParameter("@currency_Key", SqlDbType.NVarChar);
            param[13].Value = currency_Key;

            param[14] = new SqlParameter("@insert", SqlDbType.Bit);
            param[14].Value = insert;

            param[15] = new SqlParameter("@by_user", SqlDbType.NVarChar);
            param[15].Value = PL.main.Use_id;

            DAL.Executecommade("P_AC_insert_instrument", param);
        }
        //@FYear int 
        //   ,@Inst_num int 
        //   ,@inst_type int 
        //   ,@line_num int 
        //   ,@Product_ID nvarchar(30) 
        //   ,@UnitCost money 
        //   ,@Units_ID nvarchar(10) 
        //   ,@Quantity float 
        //   ,@Quantity_out float 
        public void p_INV_insert_Product_Movmant_Line(
int Inst_num,
int inst_type,
int line_num,
string Product_ID,
decimal UnitCost,
string Units_ID,
decimal Quantity,
decimal Quantity_out
)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@FYear ", SqlDbType.Int);
            param[0].Value = PL.main.Fyear;

            param[1] = new SqlParameter("@Inst_num", SqlDbType.Int);
            param[1].Value = Inst_num;

            param[2] = new SqlParameter("@inst_type", SqlDbType.Int);
            param[2].Value = inst_type;

            param[3] = new SqlParameter("@line_num", SqlDbType.Int);
            param[3].Value = line_num;

            param[4] = new SqlParameter("@Product_ID", SqlDbType.NVarChar);
            param[4].Value = Product_ID;

            param[5] = new SqlParameter("@UnitCost", SqlDbType.Money);
            param[5].Value = UnitCost;

            param[6] = new SqlParameter("@Units_ID", SqlDbType.NVarChar);
            param[6].Value = Units_ID;

            param[7] = new SqlParameter("@Quantity", SqlDbType.Float);
            param[7].Value = Quantity;

            param[8] = new SqlParameter("@Quantity_out", SqlDbType.Float);
            param[8].Value = Quantity_out;

            DAL.Executecommade("p_INV_insert_Product_Movmant_Line", param);
        }
        public void P_INV_insert_Sup_order(
           int Inst_num    
           ,int Invontory_ID  
            ,int  S_C_Num  
           ,int S_C_type  
           ,string Car_num  
           ,string Driver_A_N 
 )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Inst_num ", SqlDbType.Int);
            param[0].Value = Inst_num;

            param[1] = new SqlParameter("@Invontory_ID", SqlDbType.Int);
            param[1].Value = Invontory_ID;


            param[2] = new SqlParameter("@FYear", SqlDbType.Int);
            param[2].Value = PL.main.Fyear;

        
            param[3] = new SqlParameter("@S_C_Num", SqlDbType.Int);
            param[3].Value = S_C_Num;

            param[4] = new SqlParameter("@S_C_type", SqlDbType.Int);
            param[4].Value = S_C_type;

            param[5] = new SqlParameter("@Car_num", SqlDbType.NVarChar);
            param[5].Value = Car_num;

            param[6] = new SqlParameter("@Driver_A_N", SqlDbType.NVarChar);
            param[6].Value = Driver_A_N;

            DAL.Executecommade("P_INV_insert_Sup_order", param);
        }
        public void P_INV_insert_tr_inv(
         int Inst_num
            , int inst_type
         , int Invontory_ID
            ,int Invontory_dis_ID
          , int S_C_Num
         , int S_C_type

)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Inst_num ", SqlDbType.Int);
            param[0].Value = Inst_num;

            param[1] = new SqlParameter("@inst_type ", SqlDbType.Int);
            param[1].Value = inst_type;

            param[2] = new SqlParameter("@Invontory_ID", SqlDbType.Int);
            param[2].Value = Invontory_ID;


            param[3] = new SqlParameter("@Invontory_dis_ID", SqlDbType.Int);
            param[3].Value = Invontory_dis_ID;


            param[4] = new SqlParameter("@S_C_Num", SqlDbType.Int);
            param[4].Value = S_C_Num;

            param[5] = new SqlParameter("@S_C_type", SqlDbType.Int);
            param[5].Value = S_C_type;


            DAL.Executecommade("P_INV_insert_tr_inv", param);
        }
    }
}
