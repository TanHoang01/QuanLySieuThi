namespace QuanLySieuThi.IssueReport
{
    partial class Request
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetSendIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSendIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_Request";
            reportDataSource1.Value = this.DataSetRequestBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThi.IssueReport.RequestReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(733, 564);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetSendIBindingSource
            // 
            this.DataSetSendIBindingSource.DataMember = "DataTableSendI";
            this.DataSetSendIBindingSource.DataSource = typeof(QuanLySieuThi.IssueReport.DataSetSendI);
            // 
            // DataSetRequestBindingSource
            // 
            this.DataSetRequestBindingSource.DataMember = "DataTableRequest";
            this.DataSetRequestBindingSource.DataSource = typeof(QuanLySieuThi.IssueReport.DataSetRequest);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 588);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Request";
            this.Text = "Request";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Request_FormClosing);
            this.Load += new System.EventHandler(this.Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSendIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRequestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataSetSendIBindingSource;
        private System.Windows.Forms.BindingSource DataSetRequestBindingSource;
    }
}