using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BookingTableCs.Process;
using BookingTableCs.Database;
using TableBooking;
using BookingTableCs.Model;
namespace BookingTableCs
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
        }


        public bool CheckLogin(string numPhone)
        {
            string commamdText = "Select * from Customer";
            DataTable table = MyProcess.GetDataWithCommand(commamdText);
            for(int rowi=0;rowi<table.Rows.Count;rowi++)
            {
                if (table.Rows[rowi]["numPhone"].ToString() == numPhone)
                {
                    Customer customer1 = new Customer();
                    customer1.IdCustomer = Int32.Parse(table.Rows[rowi]["idCustomer"].ToString());
                    customer1.NameCustomer = table.Rows[rowi]["nameCustomer"].ToString();
                    customer1.NumPhone = table.Rows[rowi]["numPhone"].ToString();
                    return true;
                }
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form f = new fCustomer();
            if (CheckLogin(txtNumPhoneLogin.Text.ToString()) == true)
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Account is not registered!","Error");
        }
    }
}
