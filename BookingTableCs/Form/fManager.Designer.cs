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
            this.lblTableInfo = new System.Windows.Forms.Label();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GNum = new System.Windows.Forms.NumericUpDown();
            this.lblGNum = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbTableNumber = new System.Windows.Forms.ComboBox();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlTableList = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.pnlBooking.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GNum)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBooking
            // 
            this.lblBooking.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(562, 9);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(100, 48);
            this.lblBooking.TabIndex = 0;
            this.lblBooking.Text = "Booking";
            this.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBooking.Click += new System.EventHandler(this.lblBooking_Click);
            // 
            // lblTableInfo
            // 
            this.lblTableInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableInfo.Location = new System.Drawing.Point(127, 11);
            this.lblTableInfo.Name = "lblTableInfo";
            this.lblTableInfo.Size = new System.Drawing.Size(129, 49);
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
            this.pnlBooking.Location = new System.Drawing.Point(427, 43);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(361, 351);
            this.pnlBooking.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GNum);
            this.panel4.Controls.Add(this.lblGNum);
            this.panel4.Location = new System.Drawing.Point(19, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 40);
            this.panel4.TabIndex = 3;
            // 
            // GNum
            // 
            this.GNum.Location = new System.Drawing.Point(128, 12);
            this.GNum.Name = "GNum";
            this.GNum.Size = new System.Drawing.Size(120, 20);
            this.GNum.TabIndex = 1;
            // 
            // lblGNum
            // 
            this.lblGNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGNum.Location = new System.Drawing.Point(-1, 9);
            this.lblGNum.Name = "lblGNum";
            this.lblGNum.Size = new System.Drawing.Size(139, 23);
            this.lblGNum.TabIndex = 0;
            this.lblGNum.Text = "Number of guest:";
            this.lblGNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmbTableNumber);
            this.panel5.Controls.Add(this.lblTableNum);
            this.panel5.Location = new System.Drawing.Point(19, 223);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(254, 40);
            this.panel5.TabIndex = 4;
            // 
            // cmbTableNumber
            // 
            this.cmbTableNumber.FormattingEnabled = true;
            this.cmbTableNumber.Location = new System.Drawing.Point(127, 8);
            this.cmbTableNumber.Name = "cmbTableNumber";
            this.cmbTableNumber.Size = new System.Drawing.Size(121, 21);
            this.cmbTableNumber.TabIndex = 1;
            // 
            // lblTableNum
            // 
            this.lblTableNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNum.Location = new System.Drawing.Point(4, 8);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(113, 23);
            this.lblTableNum.TabIndex = 0;
            this.lblTableNum.Text = "Table Number:";
            this.lblTableNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 40);
            this.panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Location = new System.Drawing.Point(20, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 40);
            this.panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(19, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 40);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(-4, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTableList
            // 
            this.pnlTableList.Location = new System.Drawing.Point(12, 43);
            this.pnlTableList.Name = "pnlTableList";
            this.pnlTableList.Size = new System.Drawing.Size(403, 351);
            this.pnlTableList.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(279, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(107, 279);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(269, 279);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(107, 308);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(156, 23);
            this.btnManage.TabIndex = 9;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTableInfo);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.pnlTableList);
            this.Controls.Add(this.pnlBooking);
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.fTableManage_Load);
            this.pnlBooking.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GNum)).EndInit();
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
        private System.Windows.Forms.NumericUpDown GNum;
        private System.Windows.Forms.Label lblGNum;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbTableNumber;
        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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