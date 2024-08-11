using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookingTableCs.Process;
using System.Data.SqlClient;
using BookingTableCs.Database;
namespace TableBooking
{
    public partial class fCustomer : Form
    {
        public fCustomer()
        {
            InitializeComponent();
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

            LoadTextBoxInfoCustomer();

            LoadDtgvListTable();

            LoadDtgvCustomer();

            LoadDataCombobox();
        }

        // Region LoadForm
        private void LoadTextBoxInfoCustomer()
        {
            txtNameCustomer.Text = MyProcess.customer.NameCustomer;
            txtnumPhone.Text = MyProcess.customer.NumPhone;
            txtIdCustomer.Text = MyProcess.customer.IdCustomer.ToString();
        }
        private void LoadDataCombobox()
        {
            string commandText = "select * from isTable ";
            DataTable table = MyProcess.GetDataWithCommand(commandText);
            for (int rowi = 0; rowi < table.Rows.Count; rowi++)
            {
                cmbTableNumber.Items.Add(table.Rows[rowi]["idTable"]);
            }
        }
        private void LoadDtgvListTable()
        {
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTableGetDate();
        }
        private void LoadDtgvCustomer()
        {
            string commandText = "Select idBooking, datebooking, idtable, numguest from Booking "+ 
                                 "where idCustomer = '"+txtIdCustomer.Text+"' "+
                                 " order by datebooking DESC";
            dtgvCustomer.DataSource = MyProcess.GetDataWithCommand(commandText);
        }

        // end Region

        // Region Form operations
        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();   
        }
        // end Region


        // Region Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTableSearchDate(dtpCustomerBook.Text);
        }

        // end Region

        // Region Book
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (CheckBooking() == false)
                MessageBox.Show("Table reservation error, Please check the information again.", "Error");
            else
            {
                BookingTable();
                MessageBox.Show(
                "Thank you for choosing our restaurant.\n",
                //"Note: You are only able to change or cancel the table information 1 hour before the arrangement",
                "Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

            // check the validity of the information
        private bool CheckBooking()
        {
            if (dtpCustomerBook.Value < DateTime.Now)
                return false;
            DataTable table = MyProcess.LoadDtgvListTableSearchDate(dtpCustomerBook.Text);
            int numTable;
            if (nudNumGuest.Value == 0)
                return false;
            if (Int32.TryParse(cmbTableNumber.Text.ToString(),out numTable) == false)
                return false;
            if (numTable <= 0 || numTable > table.Rows.Count)
                return false;
            if (table.Rows[numTable - 1]["Status"].ToString() == "1")   // -1: because row of table start from 0, "1": status Booked
                return false;
            int numGuestCustomerBooking = Int32.Parse(nudNumGuest.Value.ToString());
            int numMaxGuest = Int32.Parse(table.Rows[numTable - 1]["MaxGuest"].ToString());
            if (numGuestCustomerBooking > numMaxGuest)
                return false;
            return true;
        }

            // Insert info Booking into SQL
        private void BookingTable()
        {
            SqlConnection connection = DTB.ConnectionSql();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into BOOKING " +
                                  "(idCustomer, idTable, dateBooking, numGuest) "+
                                  "values('" + txtIdCustomer.Text + "','" + cmbTableNumber.Text + "','" + dtpCustomerBook.Text + "','" + nudNumGuest.Value.ToString() + "')";
            command.ExecuteNonQuery();
            LoadDtgvCustomer();
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTableSearchDate(dtpCustomerBook.Text);
        }

        // end Region
    }
}
