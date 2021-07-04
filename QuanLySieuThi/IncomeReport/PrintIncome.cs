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

namespace QuanLySieuThi.IncomeReport
{
    public partial class PrintIncome : Form
    {
        public PrintIncome()
        {
            InitializeComponent();
        }

        private void PrintIncome_Load(object sender, EventArgs e)
        {
            string CNST = "Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(CNST);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Income ", connection);
            DataSetIncome bds = new DataSetIncome();
            da.Fill(bds, "DataTableIncome");
            ReportDataSource dtr = new ReportDataSource("DataSet_Income", bds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dtr);
            this.reportViewer1.RefreshReport();
        }

        private void PrintIncome_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Income", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
