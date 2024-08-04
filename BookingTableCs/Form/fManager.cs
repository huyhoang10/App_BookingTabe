using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            this.Hide();
            f.Show();
        }

        private void lblBooking_Click(object sender, EventArgs e)
        {

        }

        private void lblTableInfo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            fTableManage f = new fTableManage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
