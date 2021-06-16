namespace QuanLySieuThi.BillReport
{
    partial class PrintBill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataSetBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbhds = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSetBillBindingSource
            // 
            this.DataSetBillBindingSource.DataMember = "DataTableBill";
            this.DataSetBillBindingSource.DataSource = typeof(QuanLySieuThi.BillReport.DataSetBill);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa Đơn Số: ";
            // 
            // lbhds
            // 
            this.lbhds.AutoSize = true;
            this.lbhds.Location = new System.Drawing.Point(112, 13);
            this.lbhds.Name = "lbhds";
            this.lbhds.Size = new System.Drawing.Size(20, 17);
            this.lbhds.TabIndex = 2;
            this.lbhds.Text = "...";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_Bill";
            reportDataSource1.Value = this.DataSetBillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThi.BillReport.BillReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(736, 513);
            this.reportViewer1.TabIndex = 4;
            // 
            // PrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 581);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lbhds);
            this.Controls.Add(this.label1);
            this.Name = "PrintBill";
            this.Text = "PrintBill";
            this.Load += new System.EventHandler(this.PrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbhds;
        private System.Windows.Forms.BindingSource DataSetBillBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}