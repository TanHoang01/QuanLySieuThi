using QuanLySieuThi.DAO;
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
using QuanLySieuThi.DTO;

namespace QuanLySieuThi
{
    public partial class IncomeForm : Form
    {
        int order = 1;
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbmhh.Text) || String.IsNullOrEmpty(txbthh.Text) || String.IsNullOrEmpty(txbtt.Text))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (Check(txbmhh.Text) == "yes")
                {
                    string[] arr = new string[4];
                    arr[0] = order++.ToString();
                    arr[1] = txbmhh.Text;
                    arr[2] = txbthh.Text;
                    arr[3] = txbtt.Text;
                    ListViewItem lvi = new ListViewItem(arr);
                    kiemtoanlistview.Items.Add(lvi);
                }
                else
                {
                    MessageBox.Show("Mã Hàng Nhập Không Đúng!");
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
            if (kiemtoanlistview.SelectedItems.Count > 0)
            {
                for (int i = 0; i < kiemtoanlistview.Items.Count; i++)
                {
                    if (kiemtoanlistview.Items[i].Selected)
                    { 
                       kiemtoanlistview.Items[i].Remove();
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
                SqlCommand command = new SqlCommand("SELECT TenHang From Goods WHERE MaHangHoa =@MaHangHoa", connection);
                command.Parameters.AddWithValue("@MaHangHoa", txbmhh.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txbthh.Text = reader.GetValue(0).ToString();
                }
                connection.Close();
            }
        }

        private void btin_Click(object sender, EventArgs e)
        {
            if (kiemtoanlistview.Items.Count > 0)
            {
                foreach (ListViewItem ListItem in kiemtoanlistview.Items)
                {
                    int a = Convert.ToInt32(ListItem.SubItems[0].Text);
                    long b = Convert.ToInt64(ListItem.SubItems[3].Text);
                    Income income = new Income(a,ListItem.SubItems[1].Text, ListItem.SubItems[2].Text,b);
                    BillDAO.Instance.AddIncome(income);
                }
            }
            else
            {
                MessageBox.Show("Hóa Đơn Trống!");
            }
            if (kiemtoanlistview.Items.Count > 0)
            {
                new IncomeReport.PrintIncome().Show();
            }
        }
    }
}
