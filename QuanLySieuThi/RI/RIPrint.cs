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

namespace QuanLySieuThi.RI
{
    public partial class RIPrint : Form
    {
        public RIPrint()
        {
            InitializeComponent();
        }

        private void RIPrint_Load(object sender, EventArgs e)
        {
            string CNST = "Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(CNST);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RIReport ", connection);
            DataSetRI bds = new DataSetRI();
            da.Fill(bds, "DataTableRI");
            ReportDataSource dtr = new ReportDataSource("DataSet_RI", bds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dtr);
            this.reportViewer1.RefreshReport();
        }

        private void RIPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM RIReport",connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
