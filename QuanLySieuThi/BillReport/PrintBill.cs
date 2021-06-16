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

namespace QuanLySieuThi.BillReport
{
    public partial class PrintBill : Form
    {
        public PrintBill()
        {
            InitializeComponent();
        }

        private void PrintBill_Load(object sender, EventArgs e)
        {
            lbhds.Text = RowCount().ToString();
            string CNST = "Data Source=DESKTOP-6BKORA6;Initial Catalog=QuanLySieuThi;Integrated Security=True";
            SqlConnection connection = new SqlConnection(CNST);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM VIEWALLBILL WHERE InID = '" + lbhds.Text + "' ", connection);
            DataSetBill bds = new DataSetBill();
            da.Fill(bds, "DataTableBill");
            ReportDataSource dtr = new ReportDataSource("DataSet_Bill", bds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dtr);
            this.reportViewer1.RefreshReport();
        }

        public int RowCount()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.Master";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection("Data Source=DESKTOP-6BKORA6;Initial Catalog=QuanLySieuThi;Integrated Security=True"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }
    }
}
