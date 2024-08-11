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
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
        }

        private void fTableManage_Load(object sender, EventArgs e)
        {
            LoadDtgvListBooking();
            LoadDtgvListTable();
            LoadComboboxListTable();
        }


        // REgion LoadForm
        private void LoadDtgvListBooking()
        {
            dtgvListBooking.DataSource = MyProcess.LoadDtgvListBooking();
        }
        private void LoadDtgvListTable()
        {
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTableGetDate();
        }
        private void LoadComboboxListTable()
        {
            string commandText = "select * from isTable ";
            DataTable table = MyProcess.GetDataWithCommand(commandText);
            for (int rowi = 0; rowi < table.Rows.Count; rowi++)
            {
                cmbTableNumber.Items.Add(table.Rows[rowi]["idTable"]);
            }
        }

        // end region

        // Region operations in the form
        private void btnManage_Click(object sender, EventArgs e)
        {
            fTableManage f = new fTableManage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTableSearchDate(dtpSearch.Text);
            dtgvListBooking.DataSource = MyProcess.LoadDtgvListBookingSearchDate(dtpSearch.Text);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string commandText = "select * from Customer ";
            DataTable table = MyProcess.GetDataWithCommand(commandText);
            bool CheckCustomer = false;
            for(int rowi=0; rowi<table.Rows.Count;rowi++)
            {
                if(txtNumPhone.Text == table.Rows[rowi]["numPhone"].ToString())
                {
                    CheckCustomer = true;
                    txtIdCustomer.Text = table.Rows[rowi]["idCustomer"].ToString();
                    txtNameCustomer.Text = table.Rows[rowi]["nameCustomer"].ToString();
                    txtNumPhone.Text = table.Rows[rowi]["numPhone"].ToString();
                }
            }
            if (CheckCustomer == false)
                MessageBox.Show("The account does not exist yet! register now.", "Notification");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNumPhone.Text.ToString().Length == 10)
                MyProcess.RegisterCustomer(txtNameCustomer.Text, txtNumPhone.Text);
            else
                MessageBox.Show("The phone number entered is invalid!", "Error");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNameCustomer.ReadOnly = false;
            LoadDtgvListBooking();
            LoadDtgvListTable();
            dtpSearch.Value = DateTime.Now;
            txtIdCustomer.Text = "";
            txtIdBooking.Text = "";
            txtNameCustomer.Text = "";
            txtNumPhone.Text = "";
            cmbTableNumber.Text = "";
            nudNumGuest.Value = 0;
        }

        private void dtgvListBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentrow = dtgvListBooking.CurrentRow.Index;
            txtIdBooking.Text = dtgvListBooking.Rows[currentrow].Cells[0].Value.ToString();
            dtpSearch.Text = dtgvListBooking.Rows[currentrow].Cells[1].Value.ToString();
            txtNameCustomer.Text = dtgvListBooking.Rows[currentrow].Cells[2].Value.ToString();
            txtNameCustomer.ReadOnly = true;
            cmbTableNumber.Text = dtgvListBooking.Rows[currentrow].Cells[3].Value.ToString();
            nudNumGuest.Text = dtgvListBooking.Rows[currentrow].Cells[4].Value.ToString();
            txtIdCustomer.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = DTB.ConnectionSql();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Delete Booking where idBooking = '" + txtIdBooking.Text + "'";
            command.ExecuteNonQuery();
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTableSearchDate(dtpSearch.Text);
            LoadDtgvListBooking();
            MessageBox.Show("Deletion operation is completed!", "Notification");
        }

        // Region Booking Table
        
            // check the validity of the information
        private bool CheckBooking()
        {
            DataTable table = MyProcess.LoadDtgvListTableSearchDate(dtpSearch.Text);
            if (dtpSearch.Value < DateTime.Now)
                return false;   
            int numTable;
            if (nudNumGuest.Value == 0)
                return false;
            if (Int32.TryParse(cmbTableNumber.Text.ToString(), out numTable) == false)
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
                                  "(idCustomer, idTable, dateBooking, numGuest) " +
                                  "values('" + txtIdCustomer.Text + "','" + cmbTableNumber.Text + "','" + dtpSearch.Text + "','" + nudNumGuest.Value.ToString() + "')";
            command.ExecuteNonQuery();
            LoadDtgvListBooking();
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTableSearchDate(dtpSearch.Text);
        }
        private void btnAdd_Click(object sender, EventArgs e)
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

        // end Region


        // Region Edit
            // check the validity of the information
        private bool CheckEdit()
        {
            DataTable table = MyProcess.LoadDtgvListTableSearchDate(dtpSearch.Text);
            int rowChangeStatus = Int32.Parse(cmbTableNumber.Text.ToString())-1;
            table.Rows[rowChangeStatus]["Status"] = "0";
            if (dtpSearch.Value < DateTime.Now) 
                return false;
            int numTable;
            if (nudNumGuest.Value == 0)
                return false;
            if (Int32.TryParse(cmbTableNumber.Text.ToString(), out numTable) == false)
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
            // Edit info Booking into SQL
        private void Edit()
        {
            SqlConnection connection = DTB.ConnectionSql();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Update BOOKING " +
                                  "set dateBooking = '" + dtpSearch.Text + "', idTable = '" + cmbTableNumber.Text + "', numGuest = '" + nudNumGuest.Value.ToString() + "' " +
                                  "where idBooking = '" + txtIdBooking.Text + "' ";
            command.ExecuteNonQuery();
            LoadDtgvListBooking();
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTableSearchDate(dtpSearch.Text);
            MessageBox.Show("The information change operation was successful.", "Notification");
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckEdit() == false)
                MessageBox.Show("The information being modified is invalid!", "Error");
            else
            {
                Edit();
            }
        }

        //end Region
    }
}
