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
    public partial class GiaoCaForm : Form
    {
        int order = 1;
        public GiaoCaForm()
        {
            InitializeComponent();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbmhh.Text) || string.IsNullOrEmpty(txbn.Text)|| string.IsNullOrEmpty(txbx.Text) || string.IsNullOrEmpty(txbm.Text) || string.IsNullOrEmpty(txbt.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin!", "Thông Báo");
            }
            else
            {
                if (Check(txbmhh.Text) == "yes")
                {
                    string[] arr = new string[9];
                    arr[0] = (order++).ToString();
                    arr[1] = txbmhh.Text;
                    arr[2] = lbthh.Text;
                    arr[3] = lbdv.Text;
                    arr[4] = txbn.Text;
                    arr[5] = txbx.Text;
                    arr[6] = txbm.Text;
                    arr[7] = txbt.Text;
                    arr[8] = txbgc.Text;
                    ListViewItem lvi = new ListViewItem(arr);
                    giaocalistview.Items.Add(lvi);
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

        private void txbmhh_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6BKORA6;Initial Catalog=QuanLySieuThi;Integrated Security=True");
            connection.Open();
            if (txbmhh.Text != null)
            {
                SqlCommand command = new SqlCommand("SELECT TenHang,DonVi From Goods WHERE MaHangHoa =@MaHangHoa", connection);
                command.Parameters.AddWithValue("@MaHangHoa", txbmhh.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    lbthh.Text = reader.GetValue(0).ToString();
                    lbdv.Text = reader.GetValue(1).ToString();
 
                }
                connection.Close();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (giaocalistview.SelectedItems.Count > 0)
            {
                for (int i = 0; i < giaocalistview.Items.Count; i++)
                {
                    if (giaocalistview.Items[i].Selected)
                    {
                        giaocalistview.Items[i].Remove();
                    }
                }
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btin_Click(object sender, EventArgs e)
        {
            if (giaocalistview.Items.Count > 0)
            {
                foreach (ListViewItem ListItem in giaocalistview.Items)
                {
                    int a = Convert.ToInt32(ListItem.SubItems[0].Text);
                    int b = Convert.ToInt32(ListItem.SubItems[4].Text);
                    int c = Convert.ToInt32(ListItem.SubItems[5].Text);
                    int d = Convert.ToInt32(ListItem.SubItems[6].Text);
                    int f = Convert.ToInt32(ListItem.SubItems[7].Text);
                    GiaoC giaoC = new GiaoC(a, ListItem.SubItems[1].Text, ListItem.SubItems[2].Text, ListItem.SubItems[3].Text,b,c,d,f, ListItem.SubItems[8].Text);
                    GCDAO.Instance.AddGiaoCa(giaoC);
                }
            }
            else
            {
                MessageBox.Show("Hóa Đơn Trống!");
            }
            if (giaocalistview.Items.Count > 0)
            {
                new GiaoCa.GiaoCaReport().Show();
            }
        }
    }
}
