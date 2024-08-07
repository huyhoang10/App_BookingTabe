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
            System.Windows.Forms.NumericUpDown nudNumGuest;
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblTableInfo = new System.Windows.Forms.Label();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblGNum = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbTableNumber = new System.Windows.Forms.ComboBox();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpkManagerBooking = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlTableList = new System.Windows.Forms.Panel();
            nudNumGuest = new System.Windows.Forms.NumericUpDown();
            this.pnlBooking.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(nudNumGuest)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBooking
            // 
            this.lblBooking.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(749, 11);
            this.lblBooking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(133, 59);
            this.lblBooking.TabIndex = 0;
            this.lblBooking.Text = "Booking";
            this.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBooking.Click += new System.EventHandler(this.lblBooking_Click);
            // 
            // lblTableInfo
            // 
            this.lblTableInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableInfo.Location = new System.Drawing.Point(169, 14);
            this.lblTableInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableInfo.Name = "lblTableInfo";
            this.lblTableInfo.Size = new System.Drawing.Size(172, 60);
            this.lblTableInfo.TabIndex = 1;
            this.lblTableInfo.Text = "Table List";
            this.lblTableInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTableInfo.Click += new System.EventHandler(this.lblTableInfo_Click);
            // 
            // pnlBooking
            // 
            this.pnlBooking.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBooking.Controls.Add(this.btnManage);
            this.pnlBooking.Controls.Add(this.btnReset);
            this.pnlBooking.Controls.Add(this.btnDelete);
            this.pnlBooking.Controls.Add(this.btnEdit);
            this.pnlBooking.Controls.Add(this.btnAdd);
            this.pnlBooking.Controls.Add(this.btnSearch);
            this.pnlBooking.Controls.Add(this.panel4);
            this.pnlBooking.Controls.Add(this.panel5);
            this.pnlBooking.Controls.Add(this.panel2);
            this.pnlBooking.Controls.Add(this.panel3);
            this.pnlBooking.Controls.Add(this.panel1);
            this.pnlBooking.Location = new System.Drawing.Point(569, 53);
            this.pnlBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(481, 432);
            this.pnlBooking.TabIndex = 3;
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(143, 379);
            this.btnManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(208, 28);
            this.btnManage.TabIndex = 9;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(359, 343);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(251, 343);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(143, 343);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 343);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(372, 55);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(nudNumGuest);
            this.panel4.Controls.Add(this.lblGNum);
            this.panel4.Location = new System.Drawing.Point(25, 218);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 49);
            this.panel4.TabIndex = 3;
            // 
            // nudNumGuest
            // 
            nudNumGuest.Location = new System.Drawing.Point(171, 15);
            nudNumGuest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            nudNumGuest.Name = "nudNumGuest";
            nudNumGuest.Size = new System.Drawing.Size(160, 22);
            nudNumGuest.TabIndex = 1;
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
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 49);
            this.panel5.TabIndex = 4;
            // 
            // cmbTableNumber
            // 
            this.cmbTableNumber.FormattingEnabled = true;
            this.cmbTableNumber.Location = new System.Drawing.Point(169, 10);
            this.cmbTableNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel2.Location = new System.Drawing.Point(27, 161);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 49);
            this.panel2.TabIndex = 2;
            // 
            // txtNumPhone
            // 
            this.txtNumPhone.Location = new System.Drawing.Point(151, 14);
            this.txtNumPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumPhone.Name = "txtNumPhone";
            this.txtNumPhone.Size = new System.Drawing.Size(179, 22);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNameCustomer);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Location = new System.Drawing.Point(27, 105);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 49);
            this.panel3.TabIndex = 1;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(87, 14);
            this.txtNameCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(243, 22);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpkManagerBooking);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(25, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 49);
            this.panel1.TabIndex = 0;
            // 
            // dtpkManagerBooking
            // 
            this.dtpkManagerBooking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkManagerBooking.Location = new System.Drawing.Point(87, 11);
            this.dtpkManagerBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkManagerBooking.Name = "dtpkManagerBooking";
            this.dtpkManagerBooking.Size = new System.Drawing.Size(243, 22);
            this.dtpkManagerBooking.TabIndex = 1;
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
            this.pnlTableList.Location = new System.Drawing.Point(16, 53);
            this.pnlTableList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTableList.Name = "pnlTableList";
            this.pnlTableList.Size = new System.Drawing.Size(537, 432);
            this.pnlTableList.TabIndex = 2;
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblTableInfo);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.pnlTableList);
            this.Controls.Add(this.pnlBooking);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.fTableManage_Load);
            this.pnlBooking.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(nudNumGuest)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblTableInfo;
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
        private System.Windows.Forms.DateTimePicker dtpkManagerBooking;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlTableList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}