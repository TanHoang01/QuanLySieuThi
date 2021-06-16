using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.IssueReport
{
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        private void Request_Load(object sender, EventArgs e)
        {
            string CNST = "Data Source=DESKTOP-6BKORA6;Initial Catalog=QuanLySieuThi;Integrated Security=True";
            SqlConnection connection = new SqlConnection(CNST);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FakeIssue ", connection);
            DataSetRequest bds = new DataSetRequest();
            da.Fill(bds, "DataTableRequest");
            ReportDataSource dtr = new ReportDataSource("DataSet_Request", bds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dtr);
            this.reportViewer1.RefreshReport();
        }

        private void Request_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6BKORA6;Initial Catalog=QuanLySieuThi;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM FakeIssue", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
