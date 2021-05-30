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
    public partial class ThemHangCu : Form
    {
        public ThemHangCu()
        {
            InitializeComponent();
        }

        private void btThemHangCu_Click(object sender, EventArgs e)
        {
            string a = txbThemHangCu.Text;
            string b = txbSoLuongThem.Text;
            if (String.IsNullOrEmpty(txbThemHangCu.Text) || String.IsNullOrEmpty(txbSoLuongThem.Text))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                GoodsDAO.Instance.UpdateReceipt(a, b);
                if (Check(txbThemHangCu.Text) == "yes")
                {
                    int c = Int32.Parse(txbSoLuongThem.Text);
                    long d = Int64.Parse(lbDG.Text);
                    Receipt receipt = new Receipt(txbThemHangCu.Text, lbTH.Text, lbDV.Text, c, d, lbTime2.Text);
                    GoodsDAO.Instance.ReceiptGoods(receipt);
                }
                else
                {

                }
            }
        }

        private void btHuyThemHangCu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbThemHangCu_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6BKORA6;Initial Catalog=QuanLySieuThi;Integrated Security=True");
            connection.Open();
            if (txbThemHangCu.Text != null)
            {
                SqlCommand command = new SqlCommand("SELECT TenHang,DonVi,DonGia From Goods WHERE MaHangHoa =@MaHangHoa", connection);
                command.Parameters.AddWithValue("@MaHangHoa", txbThemHangCu.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    lbTH.Text = reader.GetValue(0).ToString();
                    lbDV.Text = reader.GetValue(1).ToString();
                    lbDG.Text = reader.GetValue(2).ToString();
                }
                connection.Close();
            }
        }

        private void ThemHangCu_Load(object sender, EventArgs e)
        {
            lbTime2.Text = DateTime.Now.ToString();
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
    }
}
