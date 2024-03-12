using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace jewelery_store
{
    internal class Jewelery_DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=WIN-H3NVTFKL2H6\SANYASQL; Initial Catalog=jewelery_store; Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            { 
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
