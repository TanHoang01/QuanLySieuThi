namespace QuanLySieuThi
{
    partial class QuanLyQuay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyQuay));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đềNghịXuấtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuGiaoCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đềNghịXuấtHàngToolStripMenuItem,
            this.phiếuGiaoCaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đềNghịXuấtHàngToolStripMenuItem
            // 
            this.đềNghịXuấtHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đềNghịXuấtHàngToolStripMenuItem.Name = "đềNghịXuấtHàngToolStripMenuItem";
            this.đềNghịXuấtHàngToolStripMenuItem.Size = new System.Drawing.Size(180, 27);
            this.đềNghịXuấtHàngToolStripMenuItem.Text = "Đề Nghị Xuất Hàng";
            this.đềNghịXuấtHàngToolStripMenuItem.Click += new System.EventHandler(this.đềNghịXuấtHàngToolStripMenuItem_Click);
            // 
            // phiếuGiaoCaToolStripMenuItem
            // 
            this.phiếuGiaoCaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phiếuGiaoCaToolStripMenuItem.Name = "phiếuGiaoCaToolStripMenuItem";
            this.phiếuGiaoCaToolStripMenuItem.Size = new System.Drawing.Size(134, 27);
            this.phiếuGiaoCaToolStripMenuItem.Text = "Phiếu Giao Ca";
            this.phiếuGiaoCaToolStripMenuItem.Click += new System.EventHandler(this.phiếuGiaoCaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // QuanLyQuay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyQuay";
            this.Text = "QuanLyQuay";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đềNghịXuấtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuGiaoCaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}