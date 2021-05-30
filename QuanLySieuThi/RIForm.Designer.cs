namespace QuanLySieuThi
{
    partial class RIForm
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
            this.components = new System.ComponentModel.Container();
            this.RIFormDataGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbmhh = new System.Windows.Forms.TextBox();
            this.txbthh = new System.Windows.Forms.TextBox();
            this.txbn = new System.Windows.Forms.TextBox();
            this.txbtdk = new System.Windows.Forms.TextBox();
            this.txbtck = new System.Windows.Forms.TextBox();
            this.txbx = new System.Windows.Forms.TextBox();
            this.txbgc = new System.Windows.Forms.TextBox();
            this.btthem = new System.Windows.Forms.Button();
            this.txbxoa = new System.Windows.Forms.Button();
            this.txbin = new System.Windows.Forms.Button();
            this.rIReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonDauKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonCuoiKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RIFormDataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rIReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RIFormDataGV
            // 
            this.RIFormDataGV.AutoGenerateColumns = false;
            this.RIFormDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RIFormDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.maHangHoaDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.tonDauKyDataGridViewTextBoxColumn,
            this.nhapDataGridViewTextBoxColumn,
            this.xuatDataGridViewTextBoxColumn,
            this.tonCuoiKyDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.RIFormDataGV.DataSource = this.rIReportBindingSource;
            this.RIFormDataGV.GridColor = System.Drawing.Color.White;
            this.RIFormDataGV.Location = new System.Drawing.Point(161, 12);
            this.RIFormDataGV.Name = "RIFormDataGV";
            this.RIFormDataGV.RowHeadersWidth = 51;
            this.RIFormDataGV.RowTemplate.Height = 24;
            this.RIFormDataGV.Size = new System.Drawing.Size(788, 260);
            this.RIFormDataGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tồn Đầu Kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tồn Cuối Kỳ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhập ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Xuất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(757, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ghi Chú";
            // 
            // txbmhh
            // 
            this.txbmhh.Location = new System.Drawing.Point(114, 298);
            this.txbmhh.Name = "txbmhh";
            this.txbmhh.Size = new System.Drawing.Size(251, 22);
            this.txbmhh.TabIndex = 8;
            // 
            // txbthh
            // 
            this.txbthh.Location = new System.Drawing.Point(114, 348);
            this.txbthh.Name = "txbthh";
            this.txbthh.Size = new System.Drawing.Size(251, 22);
            this.txbthh.TabIndex = 9;
            // 
            // txbn
            // 
            this.txbn.Location = new System.Drawing.Point(114, 398);
            this.txbn.Name = "txbn";
            this.txbn.Size = new System.Drawing.Size(251, 22);
            this.txbn.TabIndex = 10;
            // 
            // txbtdk
            // 
            this.txbtdk.Location = new System.Drawing.Point(492, 298);
            this.txbtdk.Name = "txbtdk";
            this.txbtdk.Size = new System.Drawing.Size(243, 22);
            this.txbtdk.TabIndex = 11;
            // 
            // txbtck
            // 
            this.txbtck.Location = new System.Drawing.Point(492, 348);
            this.txbtck.Name = "txbtck";
            this.txbtck.Size = new System.Drawing.Size(243, 22);
            this.txbtck.TabIndex = 12;
            // 
            // txbx
            // 
            this.txbx.Location = new System.Drawing.Point(492, 396);
            this.txbx.Name = "txbx";
            this.txbx.Size = new System.Drawing.Size(243, 22);
            this.txbx.TabIndex = 13;
            // 
            // txbgc
            // 
            this.txbgc.Location = new System.Drawing.Point(823, 278);
            this.txbgc.Multiline = true;
            this.txbgc.Name = "txbgc";
            this.txbgc.Size = new System.Drawing.Size(257, 77);
            this.txbgc.TabIndex = 14;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(760, 373);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(94, 45);
            this.btthem.TabIndex = 15;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // txbxoa
            // 
            this.txbxoa.Location = new System.Drawing.Point(877, 373);
            this.txbxoa.Name = "txbxoa";
            this.txbxoa.Size = new System.Drawing.Size(94, 45);
            this.txbxoa.TabIndex = 16;
            this.txbxoa.Text = "Xóa";
            this.txbxoa.UseVisualStyleBackColor = true;
            // 
            // txbin
            // 
            this.txbin.Location = new System.Drawing.Point(986, 373);
            this.txbin.Name = "txbin";
            this.txbin.Size = new System.Drawing.Size(94, 45);
            this.txbin.TabIndex = 17;
            this.txbin.Text = "In";
            this.txbin.UseVisualStyleBackColor = true;
            this.txbin.Click += new System.EventHandler(this.txbin_Click);
            // 
            // rIReportBindingSource
            // 
            this.rIReportBindingSource.DataSource = typeof(QuanLySieuThi.DTO.RIReport);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // maHangHoaDataGridViewTextBoxColumn
            // 
            this.maHangHoaDataGridViewTextBoxColumn.DataPropertyName = "MaHangHoa";
            this.maHangHoaDataGridViewTextBoxColumn.HeaderText = "MaHangHoa";
            this.maHangHoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHangHoaDataGridViewTextBoxColumn.Name = "maHangHoaDataGridViewTextBoxColumn";
            this.maHangHoaDataGridViewTextBoxColumn.Width = 120;
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            this.tenHangDataGridViewTextBoxColumn.Width = 120;
            // 
            // tonDauKyDataGridViewTextBoxColumn
            // 
            this.tonDauKyDataGridViewTextBoxColumn.DataPropertyName = "TonDauKy";
            this.tonDauKyDataGridViewTextBoxColumn.HeaderText = "TonDauKy";
            this.tonDauKyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tonDauKyDataGridViewTextBoxColumn.Name = "tonDauKyDataGridViewTextBoxColumn";
            this.tonDauKyDataGridViewTextBoxColumn.Width = 80;
            // 
            // nhapDataGridViewTextBoxColumn
            // 
            this.nhapDataGridViewTextBoxColumn.DataPropertyName = "Nhap";
            this.nhapDataGridViewTextBoxColumn.HeaderText = "Nhap";
            this.nhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhapDataGridViewTextBoxColumn.Name = "nhapDataGridViewTextBoxColumn";
            this.nhapDataGridViewTextBoxColumn.Width = 80;
            // 
            // xuatDataGridViewTextBoxColumn
            // 
            this.xuatDataGridViewTextBoxColumn.DataPropertyName = "Xuat";
            this.xuatDataGridViewTextBoxColumn.HeaderText = "Xuat";
            this.xuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xuatDataGridViewTextBoxColumn.Name = "xuatDataGridViewTextBoxColumn";
            this.xuatDataGridViewTextBoxColumn.Width = 80;
            // 
            // tonCuoiKyDataGridViewTextBoxColumn
            // 
            this.tonCuoiKyDataGridViewTextBoxColumn.DataPropertyName = "TonCuoiKy";
            this.tonCuoiKyDataGridViewTextBoxColumn.HeaderText = "TonCuoiKy";
            this.tonCuoiKyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tonCuoiKyDataGridViewTextBoxColumn.Name = "tonCuoiKyDataGridViewTextBoxColumn";
            this.tonCuoiKyDataGridViewTextBoxColumn.Width = 80;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.Width = 120;
            // 
            // RIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.txbin);
            this.Controls.Add(this.txbxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.txbgc);
            this.Controls.Add(this.txbx);
            this.Controls.Add(this.txbtck);
            this.Controls.Add(this.txbtdk);
            this.Controls.Add(this.txbn);
            this.Controls.Add(this.txbthh);
            this.Controls.Add(this.txbmhh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RIFormDataGV);
            this.Name = "RIForm";
            this.Text = "RIForm";
            this.Load += new System.EventHandler(this.RIForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RIFormDataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rIReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RIFormDataGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbmhh;
        private System.Windows.Forms.TextBox txbthh;
        private System.Windows.Forms.TextBox txbn;
        private System.Windows.Forms.TextBox txbtdk;
        private System.Windows.Forms.TextBox txbtck;
        private System.Windows.Forms.TextBox txbx;
        private System.Windows.Forms.TextBox txbgc;
        private System.Windows.Forms.BindingSource rIReportBindingSource;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button txbxoa;
        private System.Windows.Forms.Button txbin;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonDauKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonCuoiKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}