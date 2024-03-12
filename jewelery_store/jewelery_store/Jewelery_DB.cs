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
        // Вместо your_own_pc_name вписываете имя своего ПК (можно посмотреть в окне "Система" в Параметрах Windows), а вместо sql_server_name - имя своего созданного сервера MS SQL (можно посмотреть в SSMS).
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=your_own_pc_name\sql_server_name; Initial Catalog=jewelery_store; Integrated Security=True");

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
