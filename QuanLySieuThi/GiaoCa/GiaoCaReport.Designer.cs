namespace QuanLySieuThi.GiaoCa
{
    partial class GiaoCaReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetGiaoCaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGiaoCaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet_GiaoCa";
            reportDataSource2.Value = this.DataSetGiaoCaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThi.GiaoCa.ReportGiaoCa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(775, 525);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetGiaoCaBindingSource
            // 
            this.DataSetGiaoCaBindingSource.DataMember = "DataTableGiaoCa";
            this.DataSetGiaoCaBindingSource.DataSource = typeof(QuanLySieuThi.GiaoCa.DataSetGiaoCa);
            // 
            // GiaoCaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GiaoCaReport";
            this.Text = "GiaoCaReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GiaoCaReport_FormClosing);
            this.Load += new System.EventHandler(this.GiaoCaReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGiaoCaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataSetGiaoCaBindingSource;
    }
}