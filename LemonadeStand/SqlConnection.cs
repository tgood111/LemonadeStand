using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    //the class name had to be chnaged because SqlConnection is the main Microsoft database 
    class SqlConnection2
    {
        //first the connection string
        //use @ symbol to get all the special characters

        string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db1.mdf;Initial Catalog=aspnet-WebApplication1-20171026012010;Integrated Security=True";

        // the constructor
        public SqlConnection2()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //do SQL queries here

                connection.Close();
            }
        }
    }
}
