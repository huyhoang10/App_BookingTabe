using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BookingTableCs.Database
{
    class DTB
    {

        public static SqlConnection ConnectionSql()
        {
            string str = @"Data Source=LAPTOP-LKT1NON5\HUYHOANG;Initial Catalog=appBookingTable;Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            return connection;
        }

        //public static DataTable GetDataFromSQL(string nameTable)
        //{
        //    SqlConnection connection = ConnectionSql();
        //    SqlCommand command = connection.CreateCommand();
        //    command.CommandText = "select * from Customer";
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    table.Clear();
        //    dataAdapter.Fill(table);
        //    return table;
        //}
    }
}
