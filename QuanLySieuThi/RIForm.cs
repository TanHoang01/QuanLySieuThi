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
using QuanLySieuThi.DAO;
using QuanLySieuThi.DTO;


namespace QuanLySieuThi
{
    public partial class RIForm : Form
    {
        int order = 1;
        public RIForm()
        {
            InitializeComponent();
        }

        private void RIForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbmhh.Text) || string.IsNullOrEmpty(txbthh.Text) || string.IsNullOrEmpty(txbn.Text) || string.IsNullOrEmpty(txbx.Text) || string.IsNullOrEmpty(txbtdk.Text) || string.IsNullOrEmpty(txbtck.Text))
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
                    arr[2] = txbthh.Text;
                    arr[3] = txbtdk.Text;
                    arr[4] = txbn.Text;
                    arr[5] = txbx.Text;
                    arr[6] = txbtck.Text;
                    arr[7] = txbgc.Text;
                    ListViewItem lvi = new ListViewItem(arr);
                    muahanglistview.Items.Add(lvi);
                }
                else
                {
                    MessageBox.Show("Mã Hàng Không Đúng!", "Thông Báo");
                }
            }
        }

        private void txbin_Click(object sender, EventArgs e)
        {
            if (muahanglistview.Items.Count > 0)
            {
                foreach (ListViewItem ListItem in muahanglistview.Items)
                {
                    int a = Convert.ToInt32(ListItem.SubItems[0].Text);
                    int b = Convert.ToInt32(ListItem.SubItems[3].Text);
                    int c = Convert.ToInt32(ListItem.SubItems[4].Text);
                    int d = Convert.ToInt32(ListItem.SubItems[5].Text);
                    int f = Convert.ToInt32(ListItem.SubItems[6].Text);
                    RIReport ri = new RIReport(a, ListItem.SubItems[1].Text, ListItem.SubItems[2].Text, b, c, d,f, ListItem.SubItems[7].Text);
                    RIReportDAO.Instance.AddRI(ri);

                }
            }
            else
            {
                MessageBox.Show("Hóa Đơn Trống!");
            }
            new RI.RIPrint().Show();
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

        private void txbxoa_Click(object sender, EventArgs e)
        {
            if (muahanglistview.SelectedItems.Count > 0)
            {
                for (int i = 0; i < muahanglistview.Items.Count; i++)
                {
                    if (muahanglistview.Items[i].Selected)
                    {
                        muahanglistview.Items[i].Remove();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
