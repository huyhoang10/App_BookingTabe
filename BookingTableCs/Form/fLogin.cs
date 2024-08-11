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
using System.Data.SqlClient;
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

        // Region Login
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
                MessageBox.Show("Account is not registered! Register now","Error");
        }

            // Check if the account exists or not
        private bool CheckLogin(string numPhone)
        {
            string commamdText = "Select * from Customer";
            DataTable table = MyProcess.GetDataWithCommand(commamdText);
            for (int rowi = 0; rowi < table.Rows.Count; rowi++)
            {
                if (table.Rows[rowi]["numPhone"].ToString() == numPhone)
                {
                    int idCustomer = Int32.Parse(table.Rows[rowi]["idCustomer"].ToString());
                    string nameCustomer = table.Rows[rowi]["nameCustomer"].ToString();
                    string NumPhone = table.Rows[rowi]["numPhone"].ToString();
                    MyProcess.GetInfoCustomer(idCustomer, nameCustomer, NumPhone);
                    return true;
                }
            }
            return false;
        }

        // end Region

        // Region Register
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txtNumPhoneLogin.Text) == true)
                MessageBox.Show("This account already exists!", "Notification");
            else if (txtNumPhoneLogin.Text.Length != 10)
                MessageBox.Show("The phone number entered is invalid! Phone number must have 10 digits.", "Error");
            else
            {
                SqlConnection connection = DTB.ConnectionSql();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "insert into Customer " +
                                      "(nameCustomer,numPhone) " +
                                      "values ('" + txtNameCustomer.Text + "' , '" + txtNumPhoneLogin.Text   + "' )";
                command.ExecuteNonQuery();
                MessageBox.Show("Thank you for registering, please log in again.", "Notification");
            }    

        }

        // end Region
    }
}
