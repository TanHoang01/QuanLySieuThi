namespace QuanLySieuThi
{
    partial class LoginScreen
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
            this.btUserName = new System.Windows.Forms.Label();
            this.btPassWord = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUserName
            // 
            this.btUserName.AutoSize = true;
            this.btUserName.Location = new System.Drawing.Point(74, 90);
            this.btUserName.Name = "btUserName";
            this.btUserName.Size = new System.Drawing.Size(109, 17);
            this.btUserName.TabIndex = 0;
            this.btUserName.Text = "Ten Dang Nhap";
            // 
            // btPassWord
            // 
            this.btPassWord.AutoSize = true;
            this.btPassWord.Location = new System.Drawing.Point(74, 194);
            this.btPassWord.Name = "btPassWord";
            this.btPassWord.Size = new System.Drawing.Size(68, 17);
            this.btPassWord.TabIndex = 1;
            this.btPassWord.Text = "Mat Khau";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(203, 85);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(516, 22);
            this.txbTenDangNhap.TabIndex = 2;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(203, 189);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(516, 22);
            this.txbMatKhau.TabIndex = 3;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(409, 310);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(135, 55);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(584, 310);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(135, 55);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.btPassWord);
            this.Controls.Add(this.btUserName);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btUserName;
        private System.Windows.Forms.Label btPassWord;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btThoat;
    }
}

