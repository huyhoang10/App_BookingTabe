
namespace BookingTableCs
{
    partial class fLogin
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
            this.txtNumPhoneLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dtgvtest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtest)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumPhoneLogin
            // 
            this.txtNumPhoneLogin.Location = new System.Drawing.Point(234, 53);
            this.txtNumPhoneLogin.Name = "txtNumPhoneLogin";
            this.txtNumPhoneLogin.Size = new System.Drawing.Size(308, 22);
            this.txtNumPhoneLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(317, 95);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 46);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // dtgvtest
            // 
            this.dtgvtest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvtest.Location = new System.Drawing.Point(389, 159);
            this.dtgvtest.Name = "dtgvtest";
            this.dtgvtest.RowHeadersWidth = 51;
            this.dtgvtest.RowTemplate.Height = 24;
            this.dtgvtest.Size = new System.Drawing.Size(366, 217);
            this.dtgvtest.TabIndex = 2;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 477);
            this.Controls.Add(this.dtgvtest);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtNumPhoneLogin);
            this.Name = "fLogin";
            this.Text = "fLogin";
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumPhoneLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridView dtgvtest;
    }
}