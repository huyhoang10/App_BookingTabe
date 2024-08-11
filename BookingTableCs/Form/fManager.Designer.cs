namespace TableBooking
{
    partial class fManager
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
            this.lblBooking = new System.Windows.Forms.Label();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIdBooking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudNumGuest = new System.Windows.Forms.NumericUpDown();
            this.lblGNum = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbTableNumber = new System.Windows.Forms.ComboBox();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlTableList = new System.Windows.Forms.Panel();
            this.dtgvListTable = new System.Windows.Forms.DataGridView();
            this.dtgvListBooking = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlBooking.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumGuest)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTableList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBooking
            // 
            this.lblBooking.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(742, 5);
            this.lblBooking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(133, 59);
            this.lblBooking.TabIndex = 0;
            this.lblBooking.Text = "Booking";
            this.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBooking
            // 
            this.pnlBooking.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBooking.Controls.Add(this.btnRegister);
            this.pnlBooking.Controls.Add(this.btnCheck);
            this.pnlBooking.Controls.Add(this.panel6);
            this.pnlBooking.Controls.Add(this.panel3);
            this.pnlBooking.Controls.Add(this.btnManage);
            this.pnlBooking.Controls.Add(this.btnReset);
            this.pnlBooking.Controls.Add(this.btnDelete);
            this.pnlBooking.Controls.Add(this.btnEdit);
            this.pnlBooking.Controls.Add(this.btnAdd);
            this.pnlBooking.Controls.Add(this.btnSearch);
            this.pnlBooking.Controls.Add(this.panel4);
            this.pnlBooking.Controls.Add(this.panel5);
            this.pnlBooking.Controls.Add(this.panel2);
            this.pnlBooking.Controls.Add(this.panel1);
            this.pnlBooking.Location = new System.Drawing.Point(569, 53);
            this.pnlBooking.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(481, 432);
            this.pnlBooking.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(372, 132);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(99, 77);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(372, 72);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 31);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtIdBooking);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtIdCustomer);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(25, 172);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(339, 43);
            this.panel6.TabIndex = 2;
            // 
            // txtIdBooking
            // 
            this.txtIdBooking.Location = new System.Drawing.Point(277, 13);
            this.txtIdBooking.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdBooking.Name = "txtIdBooking";
            this.txtIdBooking.ReadOnly = true;
            this.txtIdBooking.Size = new System.Drawing.Size(58, 22);
            this.txtIdBooking.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "idBooking:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(117, 15);
            this.txtIdCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.ReadOnly = true;
            this.txtIdCustomer.Size = new System.Drawing.Size(58, 22);
            this.txtIdCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "idCustomer: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNameCustomer);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Location = new System.Drawing.Point(26, 118);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 49);
            this.panel3.TabIndex = 1;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCustomer.Location = new System.Drawing.Point(87, 14);
            this.txtNameCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(243, 24);
            this.txtNameCustomer.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 14);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(152, 379);
            this.btnManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(208, 28);
            this.btnManage.TabIndex = 9;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(368, 343);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 343);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(152, 343);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(44, 343);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(371, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudNumGuest);
            this.panel4.Controls.Add(this.lblGNum);
            this.panel4.Location = new System.Drawing.Point(25, 218);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 49);
            this.panel4.TabIndex = 3;
            // 
            // nudNumGuest
            // 
            this.nudNumGuest.Location = new System.Drawing.Point(169, 15);
            this.nudNumGuest.Name = "nudNumGuest";
            this.nudNumGuest.Size = new System.Drawing.Size(160, 22);
            this.nudNumGuest.TabIndex = 1;
            // 
            // lblGNum
            // 
            this.lblGNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGNum.Location = new System.Drawing.Point(-1, 11);
            this.lblGNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGNum.Name = "lblGNum";
            this.lblGNum.Size = new System.Drawing.Size(185, 28);
            this.lblGNum.TabIndex = 0;
            this.lblGNum.Text = "Number of guest:";
            this.lblGNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmbTableNumber);
            this.panel5.Controls.Add(this.lblTableNum);
            this.panel5.Location = new System.Drawing.Point(25, 274);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 49);
            this.panel5.TabIndex = 4;
            // 
            // cmbTableNumber
            // 
            this.cmbTableNumber.FormattingEnabled = true;
            this.cmbTableNumber.Location = new System.Drawing.Point(169, 10);
            this.cmbTableNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTableNumber.Name = "cmbTableNumber";
            this.cmbTableNumber.Size = new System.Drawing.Size(160, 24);
            this.cmbTableNumber.TabIndex = 1;
            // 
            // lblTableNum
            // 
            this.lblTableNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNum.Location = new System.Drawing.Point(5, 10);
            this.lblTableNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(151, 28);
            this.lblTableNum.TabIndex = 0;
            this.lblTableNum.Text = "Table Number:";
            this.lblTableNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNumPhone);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(27, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 49);
            this.panel2.TabIndex = 2;
            // 
            // txtNumPhone
            // 
            this.txtNumPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPhone.Location = new System.Drawing.Point(151, 14);
            this.txtNumPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumPhone.Name = "txtNumPhone";
            this.txtNumPhone.Size = new System.Drawing.Size(179, 24);
            this.txtNumPhone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpSearch);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(25, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 49);
            this.panel1.TabIndex = 0;
            // 
            // dtpSearch
            // 
            this.dtpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch.Location = new System.Drawing.Point(84, 11);
            this.dtpSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(245, 24);
            this.dtpSearch.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(-5, 11);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 28);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTableList
            // 
            this.pnlTableList.Controls.Add(this.label7);
            this.pnlTableList.Controls.Add(this.dtgvListTable);
            this.pnlTableList.Controls.Add(this.dtgvListBooking);
            this.pnlTableList.Location = new System.Drawing.Point(24, 53);
            this.pnlTableList.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTableList.Name = "pnlTableList";
            this.pnlTableList.Size = new System.Drawing.Size(537, 488);
            this.pnlTableList.TabIndex = 2;
            // 
            // dtgvListTable
            // 
            this.dtgvListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListTable.Location = new System.Drawing.Point(3, 9);
            this.dtgvListTable.Name = "dtgvListTable";
            this.dtgvListTable.RowHeadersWidth = 51;
            this.dtgvListTable.RowTemplate.Height = 24;
            this.dtgvListTable.Size = new System.Drawing.Size(531, 246);
            this.dtgvListTable.TabIndex = 1;
            // 
            // dtgvListBooking
            // 
            this.dtgvListBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBooking.Location = new System.Drawing.Point(3, 309);
            this.dtgvListBooking.Name = "dtgvListBooking";
            this.dtgvListBooking.RowHeadersWidth = 51;
            this.dtgvListBooking.RowTemplate.Height = 24;
            this.dtgvListBooking.Size = new System.Drawing.Size(531, 176);
            this.dtgvListBooking.TabIndex = 0;
            this.dtgvListBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListBooking_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "StatusTable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "0: Empty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "1: Booked";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Table reservation history:";
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.pnlTableList);
            this.Controls.Add(this.pnlBooking);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.fTableManage_Load);
            this.pnlBooking.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumGuest)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlTableList.ResumeLayout(false);
            this.pnlTableList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblGNum;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbTableNumber;
        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNumPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlTableList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvListBooking;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIdBooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvListTable;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.NumericUpDown nudNumGuest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}