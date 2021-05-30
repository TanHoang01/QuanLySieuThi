namespace QuanLySieuThi
{
    partial class ThuKho
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
            this.ThuKhoDataGridView = new System.Windows.Forms.DataGridView();
            this.txbTimHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngCóSẵnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btTaiLai = new System.Windows.Forms.Button();
            this.xuấtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ThuKhoDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThuKhoDataGridView
            // 
            this.ThuKhoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThuKhoDataGridView.Location = new System.Drawing.Point(12, 70);
            this.ThuKhoDataGridView.Name = "ThuKhoDataGridView";
            this.ThuKhoDataGridView.RowHeadersWidth = 51;
            this.ThuKhoDataGridView.RowTemplate.Height = 24;
            this.ThuKhoDataGridView.Size = new System.Drawing.Size(776, 368);
            this.ThuKhoDataGridView.TabIndex = 0;
            // 
            // txbTimHang
            // 
            this.txbTimHang.Location = new System.Drawing.Point(420, 12);
            this.txbTimHang.Name = "txbTimHang";
            this.txbTimHang.Size = new System.Drawing.Size(368, 22);
            this.txbTimHang.TabIndex = 1;
            this.txbTimHang.TextChanged += new System.EventHandler(this.txbTimHang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Kiếm Tên Hàng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHàngToolStripMenuItem,
            this.xuấtHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmHàngToolStripMenuItem
            // 
            this.thêmHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHàngMớiToolStripMenuItem,
            this.thêmHàngCóSẵnToolStripMenuItem});
            this.thêmHàngToolStripMenuItem.Name = "thêmHàngToolStripMenuItem";
            this.thêmHàngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.thêmHàngToolStripMenuItem.Text = "Thêm Hàng";
            // 
            // thêmHàngMớiToolStripMenuItem
            // 
            this.thêmHàngMớiToolStripMenuItem.Name = "thêmHàngMớiToolStripMenuItem";
            this.thêmHàngMớiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmHàngMớiToolStripMenuItem.Text = "Thêm Hàng Mới";
            this.thêmHàngMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmHàngMớiToolStripMenuItem_Click);
            // 
            // thêmHàngCóSẵnToolStripMenuItem
            // 
            this.thêmHàngCóSẵnToolStripMenuItem.Name = "thêmHàngCóSẵnToolStripMenuItem";
            this.thêmHàngCóSẵnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmHàngCóSẵnToolStripMenuItem.Text = "Thêm Hàng Có Sẵn";
            this.thêmHàngCóSẵnToolStripMenuItem.Click += new System.EventHandler(this.thêmHàngCóSẵnToolStripMenuItem_Click);
            // 
            // btTaiLai
            // 
            this.btTaiLai.Location = new System.Drawing.Point(13, 31);
            this.btTaiLai.Name = "btTaiLai";
            this.btTaiLai.Size = new System.Drawing.Size(87, 33);
            this.btTaiLai.TabIndex = 4;
            this.btTaiLai.Text = "Tải Lại";
            this.btTaiLai.UseVisualStyleBackColor = true;
            this.btTaiLai.Click += new System.EventHandler(this.btTaiLai_Click);
            // 
            // xuấtHàngToolStripMenuItem
            // 
            this.xuấtHàngToolStripMenuItem.Name = "xuấtHàngToolStripMenuItem";
            this.xuấtHàngToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.xuấtHàngToolStripMenuItem.Text = "Xuất hàng";
            this.xuấtHàngToolStripMenuItem.Click += new System.EventHandler(this.xuấtHàngToolStripMenuItem_Click);
            // 
            // ThuKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTaiLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTimHang);
            this.Controls.Add(this.ThuKhoDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThuKho";
            this.Text = "ThuKho";
            this.Load += new System.EventHandler(this.ThuKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThuKhoDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ThuKhoDataGridView;
        private System.Windows.Forms.TextBox txbTimHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngCóSẵnToolStripMenuItem;
        private System.Windows.Forms.Button btTaiLai;
        private System.Windows.Forms.ToolStripMenuItem xuấtHàngToolStripMenuItem;
    }
}