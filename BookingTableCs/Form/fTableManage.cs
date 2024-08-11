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
            string commandText = "select idTable[NumTable], maxGuest[MaxGuest] from isTable ";
            dtgvListTable.DataSource = MyProcess.GetDataWithCommand(commandText);
        }

        // Region operations in the form
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
                        MessageBox.Show("Table already exists!", "Error");
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

        private void dtgvListTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentrow;
            currentrow = dtgvListTable.CurrentCell.RowIndex;
            nudNumTable.Value = Int32.Parse(dtgvListTable.Rows[currentrow].Cells[0].Value.ToString());
            nudMaxGuest.Value = Int32.Parse(dtgvListTable.Rows[currentrow].Cells[1].Value.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = DTB.ConnectionSql();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Update isTable set maxguest = '" + nudMaxGuest.Value + "' where idTable = '" + nudNumTable.Value + "' ";
            command.ExecuteNonQuery();
            LoadDtgvListTable();
        }

        // end Region
    }
}
