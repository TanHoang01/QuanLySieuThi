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

namespace QuanLySieuThi.GiaoCa
{
    public partial class GiaoCaReport : Form
    {
        public GiaoCaReport()
        {
            InitializeComponent();
        }

        private void GiaoCaReport_Load(object sender, EventArgs e)
        {
            string CNST = "Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(CNST);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GiaoCa ", connection);
            DataSetGiaoCa bds = new DataSetGiaoCa();
            da.Fill(bds, "DataTableGiaoCa");
            ReportDataSource dtr = new ReportDataSource("DataSet_GiaoCa", bds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dtr);
            this.reportViewer1.RefreshReport();
        }

        private void GiaoCaReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM GiaoCa", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
