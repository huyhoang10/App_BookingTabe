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
        }


        // REgion LoadDtgv
        private void LoadDtgvListBooking()
        {
            dtgvListBooking.DataSource = MyProcess.LoadDtgvListBooking();
        }

        private void LoadDtgvListTable()
        {
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTableGetDate();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            this.Hide();
            f.Show();
        }

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
    }
}
