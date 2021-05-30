namespace QuanLySieuThi
{
    partial class DoiMatKhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDNCu = new System.Windows.Forms.TextBox();
            this.txbMKCu = new System.Windows.Forms.TextBox();
            this.txbDNMoi = new System.Windows.Forms.TextBox();
            this.txbMKMoi = new System.Windows.Forms.TextBox();
            this.btHuyDoi = new System.Windows.Forms.Button();
            this.btThayDoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập Cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Đăng Nhập Mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật Khẩu Mới";
            // 
            // txbDNCu
            // 
            this.txbDNCu.Location = new System.Drawing.Point(182, 44);
            this.txbDNCu.Name = "txbDNCu";
            this.txbDNCu.Size = new System.Drawing.Size(469, 22);
            this.txbDNCu.TabIndex = 4;
            // 
            // txbMKCu
            // 
            this.txbMKCu.Location = new System.Drawing.Point(182, 105);
            this.txbMKCu.Name = "txbMKCu";
            this.txbMKCu.Size = new System.Drawing.Size(469, 22);
            this.txbMKCu.TabIndex = 5;
            // 
            // txbDNMoi
            // 
            this.txbDNMoi.Location = new System.Drawing.Point(182, 175);
            this.txbDNMoi.Name = "txbDNMoi";
            this.txbDNMoi.Size = new System.Drawing.Size(469, 22);
            this.txbDNMoi.TabIndex = 6;
            // 
            // txbMKMoi
            // 
            this.txbMKMoi.Location = new System.Drawing.Point(182, 249);
            this.txbMKMoi.Name = "txbMKMoi";
            this.txbMKMoi.Size = new System.Drawing.Size(469, 22);
            this.txbMKMoi.TabIndex = 7;
            // 
            // btHuyDoi
            // 
            this.btHuyDoi.Location = new System.Drawing.Point(524, 321);
            this.btHuyDoi.Name = "btHuyDoi";
            this.btHuyDoi.Size = new System.Drawing.Size(127, 50);
            this.btHuyDoi.TabIndex = 8;
            this.btHuyDoi.Text = "Hủy";
            this.btHuyDoi.UseVisualStyleBackColor = true;
            this.btHuyDoi.Click += new System.EventHandler(this.btHuyDoi_Click);
            // 
            // btThayDoi
            // 
            this.btThayDoi.Location = new System.Drawing.Point(357, 321);
            this.btThayDoi.Name = "btThayDoi";
            this.btThayDoi.Size = new System.Drawing.Size(127, 50);
            this.btThayDoi.TabIndex = 9;
            this.btThayDoi.Text = "Thay Đổi";
            this.btThayDoi.UseVisualStyleBackColor = true;
            this.btThayDoi.Click += new System.EventHandler(this.btThayDoi_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThayDoi);
            this.Controls.Add(this.btHuyDoi);
            this.Controls.Add(this.txbMKMoi);
            this.Controls.Add(this.txbDNMoi);
            this.Controls.Add(this.txbMKCu);
            this.Controls.Add(this.txbDNCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDNCu;
        private System.Windows.Forms.TextBox txbMKCu;
        private System.Windows.Forms.TextBox txbDNMoi;
        private System.Windows.Forms.TextBox txbMKMoi;
        private System.Windows.Forms.Button btHuyDoi;
        private System.Windows.Forms.Button btThayDoi;
    }
}