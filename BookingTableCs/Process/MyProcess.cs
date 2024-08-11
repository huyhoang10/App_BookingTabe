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

        public static Customer customer = new Customer();
        public static Booking booking = new Booking();

        // Region: Get Data from Sql using commandText  return Datatale
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

        // end Region

        // Region Get data and change statusTable for dtgvListTable on Today
        public static DataTable LoadDtgvListTableGetDate()
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
        // end Region

        // Region Region Get data and change statusTable for dtgvListTable on the date you want to search
        public static DataTable LoadDtgvListTableSearchDate(string searchDate)
        {
            string commandText1 = "select idTable[NumTable], maxguest[MaxGuest], statusTbl[Status] from isTable";
            DataTable tblIsTable = MyProcess.GetDataWithCommand(commandText1);

            string commandText2 = "Select * from Booking where datebooking = '" + searchDate + "' ";
            DataTable tblBooking = MyProcess.GetDataWithCommand(commandText2);

            // change status of table
            for (int rowi = 0; rowi < tblBooking.Rows.Count; rowi++)
            {
                DataRow row = tblBooking.Rows[rowi];
                int positionChange = Int32.Parse(row["idTable"].ToString()) - 1; //  -1: because row table start from 0
                tblIsTable.Rows[positionChange]["Status"] = 1;
            }
            return tblIsTable;
        }
        // end Region

        // Region LoadDtgvListBooking
        public static DataTable LoadDtgvListBooking()
        {
            string commandText = "select bk.idBooking ,bk.dateBooking, ctm.nameCustomer, bk.idTable, bk.numGuest from BOOKING as bk " +
                                 " inner join Customer as ctm" +
                                 " on bk.idCustomer = ctm.idCustomer" +
                                 " where dateBooking >= GETDATE()" +
                                 " order by dateBooking";
            return MyProcess.GetDataWithCommand(commandText);
        }
        public static DataTable LoadDtgvListBookingSearchDate(string date)
        {
            string commandText = "select bk.idBooking ,bk.dateBooking, ctm.nameCustomer, bk.idTable, bk.numGuest from BOOKING as bk " +
                                 " inner join Customer as ctm" +
                                 " on bk.idCustomer = ctm.idCustomer" +
                                 " where dateBooking = '"+date+"' " +
                                 " order by dateBooking";
            return MyProcess.GetDataWithCommand(commandText);
        }
        // endRegion

        // Region Get info of Customer
        public static void GetInfoCustomer(int idCustomer, string nameCustomer, string numPhone)
        {
            customer.IdCustomer = idCustomer;
            customer.NameCustomer = nameCustomer;
            customer.NumPhone = numPhone;
        }
        //end Region

        // Region Register Customer
        public static void RegisterCustomer(string nameCustomer, string numPhone)
        {
            SqlCommand command = DTB.ConnectionSql().CreateCommand();
            command.CommandText = "insert into Customer " +
                                  "(nameCustomer, numPhone) " +
                                  "values('"+nameCustomer+"','"+numPhone+"')";
            command.ExecuteNonQuery();
        }
        //end Region
    }
}
