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
            if (string.IsNullOrEmpty(txbThemHangCu.Text) || string.IsNullOrEmpty(txbSoLuongThem.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin!", "Thông Báo");
            }
            else
            {
                if (Check(txbThemHangCu.Text) == "yes")
                {
                    string[] arr = new string[5];
                    arr[0] = txbThemHangCu.Text;
                    arr[1] = lbTH.Text;
                    arr[2] = lbDV.Text;
                    arr[3] = txbSoLuongThem.Text;
                    arr[4] = lbDG.Text;
                    ListViewItem lvi = new ListViewItem(arr);
                    themhangculistview.Items.Add(lvi);
                }
                else
                {
                    MessageBox.Show("Mã Hàng Không Đúng!", "Thông Báo");
                }
            }
        }

        private void btHuyThemHangCu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True
        private void txbThemHangCu_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True");
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

        private void btXoaCu_Click(object sender, EventArgs e)
        {
            if (themhangculistview.SelectedItems.Count > 0)
            {
                for (int i = 0; i < themhangculistview.Items.Count; i++)
                {
                    if (themhangculistview.Items[i].Selected)
                    {
                        themhangculistview.Items[i].Remove();
                    }
                }
            }
        }

        private void btXuatKho_Click(object sender, EventArgs e)
        {
            if (themhangculistview.Items.Count > 0)
            {
                foreach (ListViewItem ListItem in themhangculistview.Items)
                {
                    int a = Convert.ToInt32(ListItem.SubItems[3].Text);
                    int b = Convert.ToInt32(ListItem.SubItems[4].Text);
                    GoodsDAO.Instance.UpdateReceipt(ListItem.SubItems[0].Text, ListItem.SubItems[3].Text);
                    Receipt receipt = new Receipt(ListItem.SubItems[0].Text, ListItem.SubItems[1].Text, ListItem.SubItems[2].Text, a, b, lbTime2.Text);
                    GoodsDAO.Instance.ReceiptGoods(receipt);
                }
                MessageBox.Show("Bảng Nhập Kho Đã Được Cập Nhật", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Hóa Đơn Trống!");
            }
        }
    }
}
