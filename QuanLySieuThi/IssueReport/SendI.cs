using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace QuanLySieuThi.IssueReport
{
    public partial class SendI : Form
    {
        public SendI()
        {
            InitializeComponent();
        }

        private void SendI_Load(object sender, EventArgs e)
        {
            string CNST = "Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(CNST);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FakeIssue ", connection);
            DataSetSendI bds = new DataSetSendI();
            da.Fill(bds, "DataTableSendI");
            ReportDataSource dtr = new ReportDataSource("DataSet_SendI", bds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dtr);
            this.reportViewer1.RefreshReport();
        }

        private void SendI_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM FakeIssue", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
