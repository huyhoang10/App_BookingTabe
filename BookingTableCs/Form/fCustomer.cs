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
namespace TableBooking
{
    public partial class fCustomer : Form
    {
        public fCustomer()
        {
            InitializeComponent();
        }

        private void thToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTable();
            string commandText = "Select * from Booking ";
            dtgvCustomer.DataSource = MyProcess.GetDataWithCommand(commandText);
            //txtNameCustomer.Text = cus
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fManager f = new fManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Thank you for choosing our restaurant\n" +
                "Note: You are only able to change or cancel the table information 1 hour before the arrangement",
                "Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void lblBooking_Click(object sender, EventArgs e)
        {

        }

        private void lblTableInfo_Click(object sender, EventArgs e)
        {

        }

        private void pnlBooking_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTableList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
