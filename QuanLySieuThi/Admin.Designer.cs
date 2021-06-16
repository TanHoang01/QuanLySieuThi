namespace QuanLySieuThi
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themTaiKhoanToolStripMenuItem,
            this.xoaTaiKhoanToolStripMenuItem,
            this.danhToolStripMenuItem,
            this.danhSáchHàngHóaToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themTaiKhoanToolStripMenuItem
            // 
            this.themTaiKhoanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themTaiKhoanToolStripMenuItem.Name = "themTaiKhoanToolStripMenuItem";
            this.themTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.themTaiKhoanToolStripMenuItem.Text = "Thêm Tài Khoản";
            this.themTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.themTaiKhoanToolStripMenuItem_Click);
            // 
            // xoaTaiKhoanToolStripMenuItem
            // 
            this.xoaTaiKhoanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaTaiKhoanToolStripMenuItem.Name = "xoaTaiKhoanToolStripMenuItem";
            this.xoaTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(137, 27);
            this.xoaTaiKhoanToolStripMenuItem.Text = "Xóa Tài Khoản";
            this.xoaTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.xoaTaiKhoanToolStripMenuItem_Click);
            // 
            // danhToolStripMenuItem
            // 
            this.danhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhToolStripMenuItem.Name = "danhToolStripMenuItem";
            this.danhToolStripMenuItem.Size = new System.Drawing.Size(195, 27);
            this.danhToolStripMenuItem.Text = "Danh Sách Nhân Viên";
            this.danhToolStripMenuItem.Click += new System.EventHandler(this.danhToolStripMenuItem_Click);
            // 
            // danhSáchHàngHóaToolStripMenuItem
            // 
            this.danhSáchHàngHóaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchHàngHóaToolStripMenuItem.Name = "danhSáchHàngHóaToolStripMenuItem";
            this.danhSáchHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(193, 27);
            this.danhSáchHàngHóaToolStripMenuItem.Text = "Danh Sách Hàng Hóa";
            this.danhSáchHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.danhSáchHàngHóaToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(134, 27);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AdminPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.AdminPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdminPanel.Location = new System.Drawing.Point(12, 46);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(921, 392);
            this.AdminPanel.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhToolStripMenuItem;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}