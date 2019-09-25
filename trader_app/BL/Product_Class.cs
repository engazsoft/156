using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace trader_app.BL
{
    class Product_Class
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        DAL.Databas_Class DB = new DAL.Databas_Class();

               public string Available_Punch(string Invintory_num,string product_num,string Amount)
        {
         
                try
                {
                    dal = new DAL.DataAccessLayer();
                    return dal.FindDataSet("select  COALESCE(sum(Available_Punch), 0 )/" + Amount + "  as Available_Punch from v_product_Available where Product_Parent_ID='" + product_num + "' and Invontory_ID =" + Invintory_num).Rows[0][0].ToString();


                }
                catch (Exception)
                {

                    return "0";
                }
          


        }
        public string Available_Punch(string product_num)
        {
           
                dal = new DAL.DataAccessLayer();

            return dal.FindDataSet("select COALESCE(sum(Available_Punch), 0 ) as Available_Punch from v_product_Available where Product_Parent_ID='" + product_num + "'").Rows[0][0].ToString();

      


         }
        public string conv_Cur_to_l(string Currency_key,TextBox exch_rate)
        {
        // DataRow dr_loc=   DB.select_Row("AM_Currency", "locally", "1");
            DataRow dr = DB.select_Row("AM_Currency", "Currency_key", "Currency_key");
            double exch_rates = Convert.ToDouble( exch_rate.Text);
            double from_exch_rate = Convert.ToDouble(dr["from_exch_rate"]);
            double to_exch_rate = Convert.ToDouble(dr["to_exch_rate"]);
            double curr_exch_rate = Convert.ToDouble(dr["curr_exch_rate"]);
            if(exch_rates< from_exch_rate)
            {
                exch_rate.Text = dr["from_exch_rate"].ToString();

                return "سعر التحويل اقل من الحد الادنا لهذة العملة";
            }
            if (exch_rates < from_exch_rate)
            {
                exch_rate.Text = dr["from_exch_rate"].ToString();
                return "سعر التحويل اعلاء من الحد  لهذة العملة";
            }
            return null;
        }
public DataTable select_Movment_peoduc(string product_ID, string from, string end,string Amount)
        {
            dal = new DAL.DataAccessLayer();
            //try
            //{
            return dal.FindDataSet("select Inst_num as 'رقم المستند',D_A_N 'نوع السند',Instrument_Date as 'التاريخ',Invontory_ID as 'المخزن',A_N as 'اسم المنتج',Quantitys/" + Amount + " as 'الوارد',Quantitys_out/" + Amount + " as 'المنصرف' ,Note as 'البيات' from v_product_mov where Product_Parent_ID ='" + product_ID + "' and Instrument_Date between '" + from + "' and '" + end + "'");


            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("التوجد بيانات في الفترة الحددة ");
            //    return null;
            //}

        }

//       reate proc P_Insert_into_Product_Category
//@Category_ID nvarchar(10)
//           ,@Category_A_N nvarchar(15)=NULL
//           ,@Category_E_N nvarchar(15)=NULL
//         
//           ,@cost_of_sales_Account nvarchar(15)=NULL
//           ,@cost_return_sales_Account nvarchar(15)=NULL
//           ,@rerurn_sales_Account nvarchar(15)=NULL
//           ,@Discount_Alloewed_Account nvarchar(15)=NULL
//           ,@cost_return_sales_year_Account nvarchar(15)=NULL
//           ,@rerurn_sales_year_Account nvarchar(15)=NULL
//           ,@Earned_Discount_Account nvarchar(15)=NULL
//           ,@free_sales_cost_Account nvarchar(15)=NULL
//           ,@rerurn_free_sales_Account nvarchar(15)=NULL
//           ,@cost_of_free_purchases nvarchar(15)=NULL
//           ,@by_user nvarchar(50)
public void P_Insert_into_Product_Category(
string Category_ID,
string A_N,
string E_N,
int INV_Account,
string salse_Account,
string cost_of_sales_Account,
string cost_return_sales_Account,
string rerurn_sales_Account,
string Discount_Alloewed_Account,
string cost_return_sales_year_Account,
string rerurn_sales_year_Account,
string Earned_Discount_Account,
string free_sales_cost_Account,
string rerurn_free_sales_Account,
string cost_of_free_purchases
)
{

    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

    SqlParameter[] param = new SqlParameter[16];
    param[0] = new SqlParameter("@Category_ID ", SqlDbType.Int,15);
    param[0].Value =Category_ID;

    param[1] = new SqlParameter("@A_N", SqlDbType.NVarChar, 50);
    param[1].Value = A_N;

    param[2] = new SqlParameter("@E_N", SqlDbType.NVarChar);
    param[2].Value = E_N;

    param[3] = new SqlParameter("@INV_Account", SqlDbType.Int, 15, "NULL");
    param[3].Value = INV_Account;

    param[4] = new SqlParameter("@salse_Account", SqlDbType.NVarChar);
    param[4].Value = salse_Account;

    param[5] = new SqlParameter("@cost_of_sales_Account", SqlDbType.NVarChar);
    param[5].Value = cost_of_sales_Account;

    param[6] = new SqlParameter("@cost_return_sales_Account", SqlDbType.NVarChar, 10);
    param[6].Value = cost_return_sales_Account;

    param[7] = new SqlParameter("@rerurn_sales_Account", SqlDbType.NVarChar);
    param[7].Value = rerurn_sales_Account;

    param[8] = new SqlParameter("@Discount_Alloewed_Account", SqlDbType.NVarChar);
    param[8].Value = Discount_Alloewed_Account;

    param[9] = new SqlParameter("@cost_return_sales_year_Account", SqlDbType.NVarChar);
    param[9].Value = cost_return_sales_year_Account;

    param[10] = new SqlParameter("@rerurn_sales_year_Account", SqlDbType.NVarChar);
    param[10].Value = rerurn_sales_year_Account;



    param[11] = new SqlParameter("@Earned_Discount_Account", SqlDbType.NVarChar);
    param[11].Value = Earned_Discount_Account;

    param[12] = new SqlParameter("@free_sales_cost_Account", SqlDbType.NVarChar);
    param[12].Value = free_sales_cost_Account;
    param[13] = new SqlParameter("@rerurn_free_sales_Account", SqlDbType.NVarChar);
    param[13].Value = rerurn_free_sales_Account;


    param[14] = new SqlParameter("@cost_of_free_purchases", SqlDbType.NVarChar);
    param[14].Value = cost_of_free_purchases;

    param[15] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
    param[15].Value = PL.main.Use_id;

    DAL.Executecommade("P_Insert_into_Product_Category", param);
}	  
        public void P_INV_Insert_Products(
    string Product_ID,
    string Product_Parent_ID,
    string Bracod_num,
    string Amount,
    string A_N,
    string E_N,
    string Units_ID,
    string Disc,
    string Opening_stock,
    string cost,
    string default_price,
    int request,
    int Up_request,
    int down_request,
    string Category_ID,
    int Type_ID,
    string Manufacturing_number,
    bool booked,
    bool Service_category,
    bool stop,
    Byte[] Image
    )
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[22];
            param[0] = new SqlParameter("@Product_ID ", SqlDbType.NVarChar ,30);
            param[0].Value = Product_ID;

            param[1] = new SqlParameter("@Product_Parent_ID", SqlDbType.NVarChar,30);
            param[1].Value = Product_Parent_ID;

            param[2] = new SqlParameter("@Bracod_num", SqlDbType.NVarChar);
            param[2].Value = Bracod_num;

            param[3] = new SqlParameter("@Amount", SqlDbType.Int);
            param[3].Value = Amount;

            param[4] = new SqlParameter("@A_N", SqlDbType.NVarChar);
            param[4].Value = A_N;

            param[5] = new SqlParameter("@E_N", SqlDbType.NVarChar);
            param[5].Value = E_N;

            param[6] = new SqlParameter("@Units_ID", SqlDbType.NVarChar,10);
            param[6].Value = Units_ID;

            param[7] = new SqlParameter("@Disc", SqlDbType.NVarChar);
            param[7].Value = Disc;

            param[8] = new SqlParameter("@Opening_stock", SqlDbType.Float);
            param[8].Value = Opening_stock;

            param[9] = new SqlParameter("@cost", SqlDbType.Money);
            param[9].Value = cost;

            param[10] = new SqlParameter("@default_price", SqlDbType.Money);
            param[10].Value = default_price;

       

            param[11] = new SqlParameter("@request", SqlDbType.Int);
            param[11].Value = request;

            param[12] = new SqlParameter("@Up_request", SqlDbType.Int);
            param[12].Value = Up_request;
            param[13] = new SqlParameter("@down_request", SqlDbType.Int);
            param[13].Value = down_request;

            param[14] = new SqlParameter("@Category_ID", SqlDbType.NVarChar,10);
            param[14].Value = Category_ID;

            param[15] = new SqlParameter("@Type_ID", SqlDbType.Int);
            param[15].Value = Type_ID;


            param[16] = new SqlParameter("@Manufacturing_number", SqlDbType.NVarChar);
            param[16].Value = Manufacturing_number;

            param[17] = new SqlParameter("@booked", SqlDbType.Bit);
            param[17].Value = booked;

            param[18] = new SqlParameter("@Service_category", SqlDbType.Bit);
            param[18].Value = Service_category;

            param[19] = new SqlParameter("@stop", SqlDbType.Bit);
            param[19].Value = stop;

            param[20] = new SqlParameter("@Image", SqlDbType.Image);
            param[20].Value = Image;

            param[21] = new SqlParameter("@by_user", SqlDbType.NVarChar, 50);
            param[21].Value = PL.main.Use_id;

            DAL.Executecommade("P_INV_Insert_Products", param);
        }
        public DataTable select_Movment_peoduc(string product_ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            try
            {
                return dal.FindDataSet("select Movmant_ID as 'رقم المستند',A_N 'نوع السند',MovementDate as 'التاريخ',from_inv as 'المخزن',Product_A_N as 'اسم المنتج',Quantity as 'الوارد',Quantity_out as 'المنصرف' ,Note as 'البيات' from v_product_mov where Product_ID=" + product_ID );


            }
            catch (Exception)
            {
                MessageBox.Show("التوجد بيانات للعرض ");
                return null;
            }

        }
    }
}
