using System;
using System.Data.SqlClient;
using System.Data;

namespace TesteEngegraph_Console.Database
{
    public class BD_Connection
    {
        public string ConnectionBD;
        public SqlConnection Connection;

        public BD_Connection()
        {
            try
            {
                ConnectionBD = "Data Source=midnightserversql.ddns.net;" +
                    "Initial Catalog=DB_Engegraph;Persist Security Info=True;" +
                    "User ID=sa;Password=Beta2209";
                Connection = new SqlConnection(ConnectionBD);
                Connection.Open();
            } 
            catch (SqlException e)
            {
               Console.WriteLine("Error: " + e.Message);
            }
        }

        public DataTable SqlQuery(string Sql)
        {
            DataTable dt = new DataTable();
            try
            {
                var myCommand = new SqlCommand(Sql, Connection);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return dt;
        }

        public string SqlCommand(string Sql)
        {
            try
            {
                var myCommand = new SqlCommand(Sql, Connection);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Close()
        {
            Connection.Close();
        }

    }
}
