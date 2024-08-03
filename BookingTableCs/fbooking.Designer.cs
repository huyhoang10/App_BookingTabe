
namespace BookingTableCs
{
    partial class fbooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvListbooking = new System.Windows.Forms.DataGridView();
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.txtIdTable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnStatustable = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.cmbNumtable = new System.Windows.Forms.ComboBox();
            this.txbNumguest = new System.Windows.Forms.TextBox();
            this.txbnameCustomer = new System.Windows.Forms.TextBox();
            this.dtpBooking = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingTableDataSet1 = new BookingTableCs.BookingTableDataSet();
            this.bookingTableDataSet2 = new BookingTableCs.BookingTableDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListbooking)).BeginInit();
            this.grpBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTableDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách đặt bàn ăn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvListbooking);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 508);
            this.panel1.TabIndex = 1;
            // 
            // dtgvListbooking
            // 
            this.dtgvListbooking.BackgroundColor = System.Drawing.Color.Azure;
            this.dtgvListbooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListbooking.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvListbooking.Location = new System.Drawing.Point(3, 3);
            this.dtgvListbooking.Name = "dtgvListbooking";
            this.dtgvListbooking.RowHeadersWidth = 51;
            this.dtgvListbooking.RowTemplate.Height = 24;
            this.dtgvListbooking.Size = new System.Drawing.Size(548, 502);
            this.dtgvListbooking.TabIndex = 0;
            this.dtgvListbooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListbooking_CellClick);
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.btnSearch);
            this.grpBooking.Controls.Add(this.dtpSearch);
            this.grpBooking.Controls.Add(this.txtIdTable);
            this.grpBooking.Controls.Add(this.label6);
            this.grpBooking.Controls.Add(this.btnEdit);
            this.grpBooking.Controls.Add(this.btnDelete);
            this.grpBooking.Controls.Add(this.btnCancle);
            this.grpBooking.Controls.Add(this.btnStatustable);
            this.grpBooking.Controls.Add(this.btnBooking);
            this.grpBooking.Controls.Add(this.cmbNumtable);
            this.grpBooking.Controls.Add(this.txbNumguest);
            this.grpBooking.Controls.Add(this.txbnameCustomer);
            this.grpBooking.Controls.Add(this.dtpBooking);
            this.grpBooking.Controls.Add(this.label5);
            this.grpBooking.Controls.Add(this.label4);
            this.grpBooking.Controls.Add(this.label3);
            this.grpBooking.Controls.Add(this.label2);
            this.grpBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBooking.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.grpBooking.Location = new System.Drawing.Point(635, 63);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Size = new System.Drawing.Size(345, 515);
            this.grpBooking.TabIndex = 2;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Đặt bàn";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(241, 458);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpSearch
            // 
            this.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearch.Location = new System.Drawing.Point(25, 458);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(193, 30);
            this.dtpSearch.TabIndex = 13;
            // 
            // txtIdTable
            // 
            this.txtIdTable.Location = new System.Drawing.Point(156, 237);
            this.txtIdTable.Name = "txtIdTable";
            this.txtIdTable.ReadOnly = true;
            this.txtIdTable.Size = new System.Drawing.Size(160, 30);
            this.txtIdTable.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã số bàn: ";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(168, 359);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 36);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 36);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(24, 275);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(138, 36);
            this.btnCancle.TabIndex = 9;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnStatustable
            // 
            this.btnStatustable.Location = new System.Drawing.Point(24, 395);
            this.btnStatustable.Name = "btnStatustable";
            this.btnStatustable.Size = new System.Drawing.Size(293, 36);
            this.btnStatustable.TabIndex = 8;
            this.btnStatustable.Text = "Quản lý bàn";
            this.btnStatustable.UseVisualStyleBackColor = true;
            this.btnStatustable.Click += new System.EventHandler(this.btnStatustable_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(168, 275);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(149, 36);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "Đặt";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // cmbNumtable
            // 
            this.cmbNumtable.DisplayMember = "1,2,3,4,5,6";
            this.cmbNumtable.FormattingEnabled = true;
            this.cmbNumtable.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbNumtable.Location = new System.Drawing.Point(153, 184);
            this.cmbNumtable.Name = "cmbNumtable";
            this.cmbNumtable.Size = new System.Drawing.Size(164, 33);
            this.cmbNumtable.TabIndex = 7;
            // 
            // txbNumguest
            // 
            this.txbNumguest.Location = new System.Drawing.Point(153, 138);
            this.txbNumguest.Name = "txbNumguest";
            this.txbNumguest.Size = new System.Drawing.Size(164, 30);
            this.txbNumguest.TabIndex = 6;
            // 
            // txbnameCustomer
            // 
            this.txbnameCustomer.Location = new System.Drawing.Point(154, 97);
            this.txbnameCustomer.Name = "txbnameCustomer";
            this.txbnameCustomer.Size = new System.Drawing.Size(164, 30);
            this.txbnameCustomer.TabIndex = 5;
            // 
            // dtpBooking
            // 
            this.dtpBooking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBooking.Location = new System.Drawing.Point(153, 54);
            this.dtpBooking.Name = "dtpBooking";
            this.dtpBooking.Size = new System.Drawing.Size(165, 30);
            this.dtpBooking.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bàn số: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng khách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày đặt: ";
            // 
            // bookingTableDataSet1
            // 
            this.bookingTableDataSet1.DataSetName = "BookingTableDataSet";
            this.bookingTableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingTableDataSet2
            // 
            this.bookingTableDataSet2.DataSetName = "BookingTableDataSet";
            this.bookingTableDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fbooking
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(992, 593);
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fbooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingTable";
            this.Load += new System.EventHandler(this.fbooking_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListbooking)).EndInit();
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTableDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvListbooking;
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.ComboBox cmbNumtable;
        private System.Windows.Forms.TextBox txbNumguest;
        private System.Windows.Forms.TextBox txbnameCustomer;
        private System.Windows.Forms.DateTimePicker dtpBooking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnStatustable;
        private BookingTableDataSet bookingTableDataSet1;
        private BookingTableDataSet bookingTableDataSet2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIdTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpSearch;
    }
}

