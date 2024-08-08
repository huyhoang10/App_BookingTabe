using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookingTableCs;

namespace TableBooking
{
    public partial class fNotification : Form
    {
        public fNotification()
        {
            InitializeComponent();
        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Form f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            fManager f = new fManager();
            this.Hide();
            f.ShowDialog(); 
            this.Show();
        }
    }
}
