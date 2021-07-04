using QuanLySieuThi.DAO;
using QuanLySieuThi.DTO;
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

namespace QuanLySieuThi
{
    public partial class DeNghiXuatHang : Form
    {
        int order = 1;
        public DeNghiXuatHang()
        {
            InitializeComponent();
        }

        private void txbthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbmhh.Text) || string.IsNullOrEmpty(txbsl.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin!", "Thông Báo");
            }
            else
            {
                if (Check(txbmhh.Text) == "yes")
                {
                    string[] arr = new string[8];
                    arr[0] = (order++).ToString();
                    arr[1] = txbmhh.Text;
                    arr[2] = lbth.Text;
                    arr[3] = lbdv.Text;
                    arr[4] = txbsl.Text;
                    arr[5] = lbdg.Text;
                    arr[6] = txbgc.Text;
                    ListViewItem lvi = new ListViewItem(arr);
                    yeucaulistview.Items.Add(lvi);
                }
                else
                {
                    MessageBox.Show("Mã Hàng Không Đúng!", "Thông Báo");
                }
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

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (yeucaulistview.SelectedItems.Count > 0)
            {
                for (int i = 0; i < yeucaulistview.Items.Count; i++)
                {
                    if (yeucaulistview.Items[i].Selected)
                    {
                        yeucaulistview.Items[i].Remove();
                    }
                }
            }
        }

        private void txbmhh_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True");
            connection.Open();
            if (txbmhh.Text != null)
            {
                SqlCommand command = new SqlCommand("SELECT TenHang,DonVi,DonGia From Goods WHERE MaHangHoa =@MaHangHoa", connection);
                command.Parameters.AddWithValue("@MaHangHoa", txbmhh.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    lbth.Text = reader.GetValue(0).ToString();
                    lbdv.Text = reader.GetValue(1).ToString();
                    lbdg.Text = reader.GetValue(2).ToString();
                }
                connection.Close();
            }
        }

        private void btin_Click(object sender, EventArgs e)
        {
            if (yeucaulistview.Items.Count > 0)
            {
                foreach (ListViewItem ListItem in yeucaulistview.Items)
                {
                    int a = Convert.ToInt32(ListItem.SubItems[0].Text);
                    int c = Convert.ToInt32(ListItem.SubItems[4].Text);
                    int d = Convert.ToInt32(ListItem.SubItems[5].Text);
                    FakeIssue fakeIssue = new FakeIssue(a, ListItem.SubItems[1].Text, ListItem.SubItems[2].Text, ListItem.SubItems[3].Text, c, d, ListItem.SubItems[6].Text);
                    GoodsDAO.Instance.FakeIssueGoods(fakeIssue);
                }
            }
            else
            {
                MessageBox.Show("Hóa Đơn Trống!");
            }
            if (yeucaulistview.Items.Count > 0)
            {
                new IssueReport.Request().Show();
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
