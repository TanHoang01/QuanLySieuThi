namespace QuanLySieuThi
{
    partial class ThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbThemTDN = new System.Windows.Forms.TextBox();
            this.txbThemTHT = new System.Windows.Forms.TextBox();
            this.txbThemMK = new System.Windows.Forms.TextBox();
            this.cbbThemVT = new System.Windows.Forms.ComboBox();
            this.btHuyThem = new System.Windows.Forms.Button();
            this.btThemTK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Hiển Thị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vị Trí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật Khẩu";
            // 
            // txbThemTDN
            // 
            this.txbThemTDN.Location = new System.Drawing.Point(193, 42);
            this.txbThemTDN.Name = "txbThemTDN";
            this.txbThemTDN.Size = new System.Drawing.Size(461, 22);
            this.txbThemTDN.TabIndex = 4;
            // 
            // txbThemTHT
            // 
            this.txbThemTHT.Location = new System.Drawing.Point(193, 96);
            this.txbThemTHT.Name = "txbThemTHT";
            this.txbThemTHT.Size = new System.Drawing.Size(461, 22);
            this.txbThemTHT.TabIndex = 5;
            // 
            // txbThemMK
            // 
            this.txbThemMK.Location = new System.Drawing.Point(193, 210);
            this.txbThemMK.Name = "txbThemMK";
            this.txbThemMK.Size = new System.Drawing.Size(461, 22);
            this.txbThemMK.TabIndex = 6;
            // 
            // cbbThemVT
            // 
            this.cbbThemVT.FormattingEnabled = true;
            this.cbbThemVT.Items.AddRange(new object[] {
            "Thu Ngân",
            "Thủ Kho",
            "Bộ Phận Mua Hàng",
            "Kiểm Toán Viên",
            "Quản Lý Quầy"});
            this.cbbThemVT.Location = new System.Drawing.Point(193, 151);
            this.cbbThemVT.Name = "cbbThemVT";
            this.cbbThemVT.Size = new System.Drawing.Size(461, 24);
            this.cbbThemVT.TabIndex = 7;
            // 
            // btHuyThem
            // 
            this.btHuyThem.BackColor = System.Drawing.Color.Orange;
            this.btHuyThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuyThem.Location = new System.Drawing.Point(545, 322);
            this.btHuyThem.Name = "btHuyThem";
            this.btHuyThem.Size = new System.Drawing.Size(109, 48);
            this.btHuyThem.TabIndex = 8;
            this.btHuyThem.Text = "Hủy";
            this.btHuyThem.UseVisualStyleBackColor = false;
            this.btHuyThem.Click += new System.EventHandler(this.btHuyThem_Click);
            // 
            // btThemTK
            // 
            this.btThemTK.BackColor = System.Drawing.Color.Orange;
            this.btThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemTK.Location = new System.Drawing.Point(397, 322);
            this.btThemTK.Name = "btThemTK";
            this.btThemTK.Size = new System.Drawing.Size(109, 48);
            this.btThemTK.TabIndex = 9;
            this.btThemTK.Text = "Thêm ";
            this.btThemTK.UseVisualStyleBackColor = false;
            this.btThemTK.Click += new System.EventHandler(this.btThemTK_Click);
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThemTK);
            this.Controls.Add(this.btHuyThem);
            this.Controls.Add(this.cbbThemVT);
            this.Controls.Add(this.txbThemMK);
            this.Controls.Add(this.txbThemTHT);
            this.Controls.Add(this.txbThemTDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemTaiKhoan";
            this.Text = "ThemTaiKhoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbThemTDN;
        private System.Windows.Forms.TextBox txbThemTHT;
        private System.Windows.Forms.TextBox txbThemMK;
        private System.Windows.Forms.ComboBox cbbThemVT;
        private System.Windows.Forms.Button btHuyThem;
        private System.Windows.Forms.Button btThemTK;
    }
}