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
        int order = 1;
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
            if (String.IsNullOrEmpty(txbMHX.Text) || String.IsNullOrEmpty(txbSLX.Text))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (xuathanglistview.Items.Count > 0)
                {
                    foreach (ListViewItem ListItem in xuathanglistview.Items)
                    {
                        int a = Convert.ToInt32(ListItem.SubItems[0].Text);
                        int c = Convert.ToInt32(ListItem.SubItems[4].Text);
                        int d = Convert.ToInt32(ListItem.SubItems[5].Text);
                        GoodsDAO.Instance.UpdateIssue(ListItem.SubItems[1].Text, c.ToString());
                        Issue issue = new Issue(ListItem.SubItems[1].Text, ListItem.SubItems[2].Text, ListItem.SubItems[3].Text, c, d, lbTime3.Text);
                        GoodsDAO.Instance.IssueGoods(issue);
                        FakeIssue fakeIssue = new FakeIssue(a, ListItem.SubItems[1].Text, ListItem.SubItems[2].Text, ListItem.SubItems[3].Text, c, d, ListItem.SubItems[6].Text);
                        GoodsDAO.Instance.FakeIssueGoods(fakeIssue);
                    }
                }
                else
                {
                    MessageBox.Show("Hóa Đơn Trống!");
                }
                if (xuathanglistview.Items.Count > 0)
                {
                    new IssueReport.SendI().Show();
                }
            }
        }

        private void txbMHX_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True");
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

        private void btThemXuatHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMHX.Text) || string.IsNullOrEmpty(txbSLX.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin!", "Thông Báo");
            }
            else
            {
                if (Check(txbMHX.Text) == "yes")
                {
                    string[] arr = new string[8];
                    arr[0] = (order++).ToString();
                    arr[1] = txbMHX.Text;
                    arr[2] = lbTHX.Text;
                    arr[3] = lbDVX.Text;
                    arr[4] = txbSLX.Text;
                    arr[5] = lbDGX.Text;
                    arr[6] = txbghichu.Text;
                    ListViewItem lvi = new ListViewItem(arr);
                    xuathanglistview.Items.Add(lvi);
                }
                else
                {
                    MessageBox.Show("Mã Hàng Không Đúng!", "Thông Báo");
                }
            }
        }

        private void btXoaXuatHang_Click(object sender, EventArgs e)
        {
            if (xuathanglistview.SelectedItems.Count > 0)
            {
                for (int i = 0; i < xuathanglistview.Items.Count; i++)
                {
                    if (xuathanglistview.Items[i].Selected)
                    {
                        xuathanglistview.Items[i].Remove();
                    }
                }
            }
        }
    }
}
