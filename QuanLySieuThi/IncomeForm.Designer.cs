namespace QuanLySieuThi
{
    partial class IncomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbmhh = new System.Windows.Forms.TextBox();
            this.txbthh = new System.Windows.Forms.TextBox();
            this.txbtt = new System.Windows.Forms.TextBox();
            this.kiemtoanlistview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thành Tiền";
            // 
            // txbmhh
            // 
            this.txbmhh.Location = new System.Drawing.Point(219, 23);
            this.txbmhh.Name = "txbmhh";
            this.txbmhh.Size = new System.Drawing.Size(409, 22);
            this.txbmhh.TabIndex = 3;
            this.txbmhh.TextChanged += new System.EventHandler(this.txbmhh_TextChanged);
            // 
            // txbthh
            // 
            this.txbthh.Location = new System.Drawing.Point(219, 65);
            this.txbthh.Name = "txbthh";
            this.txbthh.Size = new System.Drawing.Size(409, 22);
            this.txbthh.TabIndex = 4;
            // 
            // txbtt
            // 
            this.txbtt.Location = new System.Drawing.Point(219, 114);
            this.txbtt.Name = "txbtt";
            this.txbtt.Size = new System.Drawing.Size(409, 22);
            this.txbtt.TabIndex = 5;
            // 
            // kiemtoanlistview
            // 
            this.kiemtoanlistview.BackColor = System.Drawing.Color.LemonChiffon;
            this.kiemtoanlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.kiemtoanlistview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiemtoanlistview.HideSelection = false;
            this.kiemtoanlistview.Location = new System.Drawing.Point(73, 153);
            this.kiemtoanlistview.Name = "kiemtoanlistview";
            this.kiemtoanlistview.Size = new System.Drawing.Size(668, 233);
            this.kiemtoanlistview.TabIndex = 6;
            this.kiemtoanlistview.UseCompatibleStateImageBehavior = false;
            this.kiemtoanlistview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Hàng Hóa";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Hàng Hóa";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 200;
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.Color.Orange;
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(27, 401);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(92, 37);
            this.btthem.TabIndex = 7;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.Color.Orange;
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(172, 401);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(92, 37);
            this.btxoa.TabIndex = 8;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // bthuy
            // 
            this.bthuy.BackColor = System.Drawing.Color.Orange;
            this.bthuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.Location = new System.Drawing.Point(687, 401);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(92, 37);
            this.bthuy.TabIndex = 9;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = false;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btin
            // 
            this.btin.BackColor = System.Drawing.Color.Orange;
            this.btin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btin.Location = new System.Drawing.Point(536, 401);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(92, 37);
            this.btin.TabIndex = 10;
            this.btin.Text = "In";
            this.btin.UseVisualStyleBackColor = false;
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btin);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.kiemtoanlistview);
            this.Controls.Add(this.txbtt);
            this.Controls.Add(this.txbthh);
            this.Controls.Add(this.txbmhh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbmhh;
        private System.Windows.Forms.TextBox txbthh;
        private System.Windows.Forms.TextBox txbtt;
        private System.Windows.Forms.ListView kiemtoanlistview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btin;
    }
}