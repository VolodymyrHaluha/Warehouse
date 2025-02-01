using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Warehouse
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPG15\SQLEXPRESS;Initial Catalog=Warehouse; Integrated Security=True");
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {


                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {


                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection() { 
            return sqlConnection;
        }


    }
}
