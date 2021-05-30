namespace QuanLySieuThi
{
    partial class XoaTaiKhoan
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
            this.DeleteDGV = new System.Windows.Forms.DataGridView();
            this.btXoaTK = new System.Windows.Forms.Button();
            this.btHuyXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteDGV
            // 
            this.DeleteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteDGV.Location = new System.Drawing.Point(12, 12);
            this.DeleteDGV.Name = "DeleteDGV";
            this.DeleteDGV.RowHeadersWidth = 51;
            this.DeleteDGV.RowTemplate.Height = 24;
            this.DeleteDGV.Size = new System.Drawing.Size(776, 367);
            this.DeleteDGV.TabIndex = 0;
            this.DeleteDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DeleteDGV_CellMouseClick);
            // 
            // btXoaTK
            // 
            this.btXoaTK.Location = new System.Drawing.Point(479, 385);
            this.btXoaTK.Name = "btXoaTK";
            this.btXoaTK.Size = new System.Drawing.Size(134, 53);
            this.btXoaTK.TabIndex = 1;
            this.btXoaTK.Text = "Xóa";
            this.btXoaTK.UseVisualStyleBackColor = true;
            this.btXoaTK.Click += new System.EventHandler(this.btXoaTK_Click);
            // 
            // btHuyXoa
            // 
            this.btHuyXoa.Location = new System.Drawing.Point(654, 385);
            this.btHuyXoa.Name = "btHuyXoa";
            this.btHuyXoa.Size = new System.Drawing.Size(134, 53);
            this.btHuyXoa.TabIndex = 2;
            this.btHuyXoa.Text = "Hủy";
            this.btHuyXoa.UseVisualStyleBackColor = true;
            this.btHuyXoa.Click += new System.EventHandler(this.btHuyXoa_Click);
            // 
            // XoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btHuyXoa);
            this.Controls.Add(this.btXoaTK);
            this.Controls.Add(this.DeleteDGV);
            this.Name = "XoaTaiKhoan";
            this.Text = "XoaTaiKhoan";
            this.Load += new System.EventHandler(this.XoaTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DeleteDGV;
        private System.Windows.Forms.Button btXoaTK;
        private System.Windows.Forms.Button btHuyXoa;
    }
}