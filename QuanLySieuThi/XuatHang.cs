using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.DAO;
using QuanLySieuThi.DTO;
using System.Data.SqlClient;


namespace QuanLySieuThi
{
    public partial class XuatHang : Form
    {
        public XuatHang()
        {
            InitializeComponent();
        }

        private void btHuyXuatHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXuatHang_Click(object sender, EventArgs e)
        {
            string a = txbMHX.Text;
            string b = txbSLX.Text;
            if (String.IsNullOrEmpty(txbMHX.Text) || String.IsNullOrEmpty(txbSLX.Text))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                GoodsDAO.Instance.UpdateIssue(a, b);
                if (Check(txbMHX.Text) == "yes")
                {
                    int c = Int32.Parse(txbSLX.Text);
                    long d = Int64.Parse(lbDGX.Text);
                    Issue issue = new Issue(txbMHX.Text, lbTHX.Text, lbDVX.Text, c, d, lbTime3.Text);
                    GoodsDAO.Instance.IssueGoods(issue);
                }
                else
                {

                }
            }
        }

        private void txbMHX_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6BKORA6;Initial Catalog=QuanLySieuThi;Integrated Security=True");
            connection.Open();
            if (txbMHX.Text != null)
            {
                SqlCommand command = new SqlCommand("SELECT TenHang,DonVi,DonGia From Goods WHERE MaHangHoa =@MaHangHoa", connection);
                command.Parameters.AddWithValue("@MaHangHoa", txbMHX.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    lbTHX.Text = reader.GetValue(0).ToString();
                    lbDVX.Text = reader.GetValue(1).ToString();
                    lbDGX.Text = reader.GetValue(2).ToString();
                }
                connection.Close();
            }
        }
        public string Check(string mahang)
        {
            string query = "SELECT * FROM dbo.Goods WHERE MaHangHoa = N'" + mahang + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return "yes";
            }
            else
                return "no";
        }

        private void XuatHang_Load(object sender, EventArgs e)
        {
            lbTime3.Text = DateTime.Now.ToString();
        }
    }
}
