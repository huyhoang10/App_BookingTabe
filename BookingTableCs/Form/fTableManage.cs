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
    public partial class fTableManage : Form
    {
        public fTableManage()
        {
            InitializeComponent();
        }

        private void fTableManage_Load(object sender, EventArgs e)
        {
            LoadDtgvListTable();
        }

        void LoadDtgvListTable()
        {
            dtgvListTable.DataSource = MyProcess.LoadDtgvListTableGetDate();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            
            DataTable table = MyProcess.LoadDtgvListTableGetDate();
            bool checkInsertTable = true;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if(nudNumTable.Value == 0 || nudMaxGuest.Value == 0 )
                {
                    MessageBox.Show("Error! Invalid input table.", "Error");
                    checkInsertTable = false;
                    break;
                }    
                    
                else
                {
                    DataRow row = table.Rows[i];
                    if (row["NumTable"].ToString() == nudNumTable.Value.ToString())
                    {
                        checkInsertTable = false;
                        MessageBox.Show("Lỗi! Bàn đã tồn tại.", "Thông Báo");
                        break;
                    }
                }
            }
            if (checkInsertTable == true)
            {
                SqlConnection connection = DTB.ConnectionSql();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "Insert into isTable (idTable,maxguest) values('"+nudNumTable.Value+"','"+nudMaxGuest.Value+"') ";
                command.ExecuteNonQuery();
                LoadDtgvListTable();
            }


        }

    }
}
