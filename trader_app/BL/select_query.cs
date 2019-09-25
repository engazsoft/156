using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trader_app.BL;

namespace trader_app.BL
{
    class select_query
    {

        public static string sql_account_search = "SELECT  [Account_ID],[A_N] ,[E_N] FROM [AC_Account] ac ";
        public static string where_accoun_Show = "WHERE stutas=1 AND  exists (SELECT 1 FROM Ath_Account_User aau WHERE aau.User_ID=" + settings.user_id + " AND aau.Account_ID=ac.Account_ID AND aau.Show=1 ) and Type_ID=2 and ";
        public static string weher_accoun_Adds = "WHERE stutas=1 AND  exists (SELECT 1 FROM Ath_Account_User aau WHERE aau.User_ID=" + settings.user_id + " AND aau.Account_ID=ac.Account_ID AND aau.Adds=1) and ";
        public static string ath_inv_user = "select *from Ath_Inventorys_Users join INV_Inventorys on Ath_Inventorys_Users.Inventory_ID=INV_Inventorys.Invontory_ID where User_ID = " + settings.user_id + "and adds=1";
        public static string sql_currency_search = "SELECT currency_Key, currency_name, currency_name_e FROM AM_Currency ac ";
        public static string where_currency_show(string acount_id, string acount_an_id)
        {
            if (acount_an_id == "")
                return "WHERE EXISTS (SELECT 1 FROM Ath_Account_User WHERE ac.currency_Key= currency_Key AND Account_ID = " + acount_id + "and User_ID =" + settings.user_id + " and Show=1 and Accoun_AN_ID is NULL) and  ";
            else
                return "WHERE EXISTS (SELECT 1 FROM Ath_Account_User WHERE ac.currency_Key= currency_Key AND Account_ID = " + acount_id + "and User_ID =" + settings.user_id + " and Show=1 and Accoun_AN_ID =" + acount_an_id + ") and  ";
        }
        // public static string where_currency_show = 
        public static string where_currency_Adds = "WHERE EXISTS (SELECT 1 FROM Ath_Account_User WHERE ac.currency_Key= currency_Key AND User_ID =" + settings.user_id + "AND Adds=1) and ";
        //WHERE stutas = 1 AND exists(SELECT 1 FROM Ath_Account_User aau WHERE aau.User_ID= 1 AND aca.Account_ID= 11501001 AND aau.Show= 1)
        public static string sql_account_an_search = "SELECT [N_AN],[A_N] ,isNULL(E_N,' ') E_N FROM [AC_ACCOUNT_AN] acn ";
        public static string where_accoun_an_Show(string account_id)
        {
            return "WHERE stutas = 1 AND exists(SELECT 1 FROM Ath_Account_User aau WHERE aau.User_ID= "+settings.user_id+" AND acn.Account_ID= "+account_id+" AND aau.Show= 1) and ";
        }
             
        public static string weher_accoun_an_Adds(string account_id)
        {
            return  "WHERE stutas = 1 AND exists(SELECT 1 FROM Ath_Account_User aau WHERE aau.User_ID= " + settings.user_id + " AND aca.Account_ID= " + account_id + " AND aau.Adds=1) and ";
        }
           

    }
}
