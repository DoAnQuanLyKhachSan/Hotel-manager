using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class DataProvide
    {
        private DataProvide() { }
        private static DataProvide instance;
        public static DataProvide Instance
        {
            get
            {
                if (instance == null) instance = new DataProvide();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private string connectionStr = @"Data Source=MEREDITH;Initial Catalog=HOTEL_MANAGER;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
