using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookingTableCs
{
    
    public partial class fbooking : Form
    {
        SqlCommand command;
        string str = @"Data Source=LAPTOP-LKT1NON5\HUYHOANG;Initial Catalog=BookingTable;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select  lbktbl.stt ,lbktbl.datebooking as N'Ngày đặt', lbktbl.namecustomer as N'Tên khách hàng', lbktbl.numguest as N'số lượng khách' ,lbktbl.numtable as 'số bàn'from Listbookingtable as lbktbl where datebooking > GETDATE() order by datebooking";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvListbooking.DataSource = table;
        }


        public fbooking()
        {
            InitializeComponent();
        }

        
        private void btnBooking_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert listbookingtable values('" + dtpBooking.Text + "','" + txbnameCustomer.Text + "','" + txbNumguest.Text + "','" + cmbNumtable.Text + "','1')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void fbooking_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        

        private void dtgvListbooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentrow;
            currentrow = dtgvListbooking.CurrentRow.Index;
            txtIdTable.Text = dtgvListbooking.Rows[currentrow].Cells[0].Value.ToString();
            dtpBooking.Text = dtgvListbooking.Rows[currentrow].Cells[1].Value.ToString();
            txbnameCustomer.Text = dtgvListbooking.Rows[currentrow].Cells[2].Value.ToString();
            txbNumguest.Text = dtgvListbooking.Rows[currentrow].Cells[3].Value.ToString();
            cmbNumtable.Text = dtgvListbooking.Rows[currentrow].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Delete listbookingtable where stt = '" + txtIdTable.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Update listbookingtable set datebooking = '" + dtpBooking.Text + "', namecustomer ='" + txbnameCustomer.Text + "', numguest = '" + txbNumguest.Text + "', numtable = '" + cmbNumtable.Text + "' where stt = '"+txtIdTable.Text+"' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            
            txbnameCustomer.Text = "";
            txbNumguest.Text = "";
            cmbNumtable.Text = "";
            loaddata();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select lbktbl.stt as N'Mã order',lbktbl.datebooking as N'Ngày đặt', lbktbl.namecustomer as N'Tên khách hàng', lbktbl.numguest as N'số lượng khách' ,lbktbl.numtable as 'số bàn' from Listbookingtable as lbktbl where datebooking = '"+dtpSearch.Text+"' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvListbooking.DataSource = table;
        }

        private void btnStatustable_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2 = null;
            this.Show();

        }
    }
    


}
