using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace trader_app.DAL
{
    class DataAccessLayer
    {

       public  SqlConnection SqlConnection;
        // this constructor inisialize the connection object
        public DataAccessLayer()
        {
           // SqlConnection = new SqlConnection(@"Server=LAPTOP-KH6HPFBT;Database=trader_db;Integrated security=true");

         SqlConnection = new SqlConnection(@"Server=192.168.137.1,1546;Database=trader_db;User id=Sadam;Password=1234");


        }

        //method to open the connection
        public void Open()
        {
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }


        }
        public void Close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        //method to read data from database
        // المتغير الاول هو اسم الاجراء المخزن 
        // المتغير الثاني هو المتغيرات 
        public DataTable SelectData(string stored_ptocedure, SqlParameter[] param)
        {

            //المر الذي يقوم لتنقيذ  الاجرات المخزنة
            SqlCommand sqlcmd = new SqlCommand();
            //نوع الاستعالم هو الجراء مخزن
            sqlcmd.CommandType = CommandType.StoredProcedure;
            //التص الذي ياتي 
            sqlcmd.CommandText = stored_ptocedure;
            sqlcmd.Connection = SqlConnection;
            Open();
            if (param != null)
            {
                /*for (int i=0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]); 
                }*/
                sqlcmd.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
           da.Fill(dt);
            Close();
            return dt;
        }

        //method to insert,update,delete,data from database
        public void Executecommade(string stored_ptocedure, SqlParameter[] param)
        {
            
           
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_ptocedure;
                sqlcmd.Connection = SqlConnection;
                Open();
                if (param != null)
                {
                    sqlcmd.Parameters.AddRange(param);
                }

                sqlcmd.ExecuteNonQuery();
                Close();
            

          
           
        }
        public void Executecommade(string sql)
        {


            SqlCommand sqlcmd = new SqlCommand();
           
          
            sqlcmd.CommandText = sql;
            sqlcmd.Connection = SqlConnection;
            Open();
            sqlcmd.ExecuteNonQuery();
            Close();




        }
        public DataTable FindDataSet(String strsql)
        {
            

            try
            {
                Open();
                SqlDataAdapter dr = new SqlDataAdapter(strsql, SqlConnection);
                DataTable objDS = new DataTable();
                dr.Fill(objDS);
               
              
                Close();
                //SqlConnection.Dispose();
                //dr.Dispose();
                return objDS;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public  SqlDataReader Find(string sql )
        {
            //using (var conn = new SqlConnection(GetConnectionString()))
            using (var cmd = SqlConnection.CreateCommand())
            {
                Open();
                cmd.CommandText = sql;
              
               // cmd.Parameters.AddWithValue("@value", RecID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader;
                    }
                    return null;
                }
            }
        }
 
        //public SqlDataReader Find(String strsql)
        //{
            
        //    SqlCommand cmd = new SqlCommand(strsql,SqlConnection);
        //    try
        //    {
                
        //        System.GC.Collect();
        //        Open();
                
        //        SqlDataReader dr = cmd.ExecuteReader();
        //      //  Close();
        //        cmd.Dispose();
        //        dr.Close();

        //        return dr;
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}

       
    }
}
