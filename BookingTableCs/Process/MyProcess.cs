using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BookingTableCs.Model;
using TableBooking;
using BookingTableCs.Database;

namespace BookingTableCs.Process
{
    class MyProcess
    {

        
        public static DataTable GetDataWithCommand(string commandText)
        {
            SqlConnection connection = DTB.ConnectionSql();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            return table;
        }

        public static DataTable LoadDtgvListTable()
        {
            string commandText1 = "select idTable[NumTable], maxguest[MaxGuest], statusTbl[Status] from isTable";
            DataTable tblIsTable = GetDataWithCommand(commandText1);

            string commandText2 = "Select * from Booking where datebooking = GETDATE() ";
            DataTable tblBooking = GetDataWithCommand(commandText2);

            // change status of table
            for (int rowi = 0; rowi < tblBooking.Rows.Count; rowi++)
            {
                DataRow row = tblBooking.Rows[rowi] ;     
                int positionChange = Int32.Parse(row["idTable"].ToString()) - 1; //  -1: because row table start from 0
                tblIsTable.Rows[positionChange]["Status"] = 1;
            }

            return tblIsTable;
        }
    }
}
