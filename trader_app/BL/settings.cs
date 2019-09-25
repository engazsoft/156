using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trader_app.BL
{
    
  public static class settings
    {
     // DAL.Databas_Class  DB=new DAL.Databas_Class();
    //  public static string ath_inv_user="select *from Ath_Inventorys_Users join INV_Inventorys on Ath_Inventorys_Users.Inventory_ID=INV_Inventorys.Invontory_ID where User_ID = "+1+"and adds=1";
        public static string user_id = "1";
        // public static string Locel_Currency = DB.select_Row("AM_Currency", "locally", 1)["currency_Key"].ToString();
    }
    
}
