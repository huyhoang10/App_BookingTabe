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
        // connect with Sql
        public static SqlConnection ConnectionSql()
        {
            string str = @"Data Source=LAPTOP-LKT1NON5\HUYHOANG;Initial Catalog=appBookingTable;Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            return connection;
        }
    }
}
