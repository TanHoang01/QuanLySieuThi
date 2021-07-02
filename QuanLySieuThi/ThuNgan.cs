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
    public partial class ThuNgan : Form
    {
        public ThuNgan()
        {
            InitializeComponent();
        }

        private void txbMHtn_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0U67BQC\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True");
            connection.Open();
            if (txbMHtn.Text != null)
            {
                SqlCommand command = new SqlCommand("SELECT TenHang,DonGia From Goods WHERE MaHangHoa =@MaHangHoa", connection);
                command.Parameters.AddWithValue("@MaHangHoa", txbMHtn.Text);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    txbTHtn.Text = reader.GetValue(0).ToString();
                    txbDGtn.Text = reader.GetValue(1).ToString();
                }
                connection.Close();
            }
            txbSLtn.Text = "";
            txbTtn.Text = "";
        }

        private void txbSLtn_TextChanged(object sender, EventArgs e)
        {
            if (txbSLtn.Text.Length > 0)
            {
                txbTtn.Text = (Convert.ToInt32(txbDGtn.Text) * Convert.ToInt32(txbSLtn.Text)).ToString();
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
        private void txbThemtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbMHtn.Text) || String.IsNullOrEmpty(txbSLtn.Text))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (Check(txbMHtn.Text) == "yes")
                {
                    string[] arr = new string[4];
                    arr[0] = txbTHtn.Text;
                    arr[1] = txbDGtn.Text;
                    arr[2] = txbSLtn.Text;
                    arr[3] = txbTtn.Text;
                    ListViewItem lvi = new ListViewItem(arr);
                    thunganlistview.Items.Add(lvi);
                    txbTTtn.Text = (Convert.ToInt32(txbTTtn.Text) + Convert.ToInt32(txbTtn.Text)).ToString();
                }
                else {
                    MessageBox.Show("Mã Hàng Nhập Không Đúng!"); 
                     }
            }
        }

        private void txbGGtn_TextChanged(object sender, EventArgs e)
        {
            if(txbGGtn.Text.Length>0)
            {
                txbTT2tn.Text = (Convert.ToInt32(txbTTtn.Text) - Convert.ToInt32(txbGGtn.Text)).ToString();
            }
        }

        private void txbKTtn_TextChanged(object sender, EventArgs e)
        {
            if (txbTT2tn.Text.Length > 0 && txbKTtn.Text.Length > 0)
            {
                txbTT3tn.Text = (Convert.ToInt32(txbKTtn.Text) - Convert.ToInt32(txbTT2tn.Text)).ToString();
                int a = Convert.ToInt32(txbTT3tn.Text);
                if(a <= 0)
                {
                    txbTT3tn.Text = 0.ToString();
                }
                else
                {
                    txbTT3tn.Text = (Convert.ToInt32(txbKTtn.Text) - Convert.ToInt32(txbTT2tn.Text)).ToString();
                }
            } 
        }

        private void txbXoatn_Click(object sender, EventArgs e)
        {
            if(thunganlistview.SelectedItems.Count>0)
            {
                for(int i = 0; i<thunganlistview.Items.Count;i++)
                {
                    if(thunganlistview.Items[i].Selected)
                    {
                        txbTTtn.Text= (Convert.ToInt32(txbTTtn.Text) - Convert.ToInt32(thunganlistview.Items[i].SubItems[3].Text)).ToString();
                        thunganlistview.Items[i].Remove();
                    }
                }
            }
        }

        private void btLuutn_Click(object sender, EventArgs e)
        {
            if(thunganlistview.Items.Count > 0)
            {
                int a = Convert.ToInt32(lbsohoadon.Text);
                long b = Convert.ToInt64(txbTTtn.Text);
                long c = Convert.ToInt64(txbGGtn.Text);
                long d = Convert.ToInt64(txbTT2tn.Text);
                long g = Convert.ToInt64(txbKTtn.Text);
                long f = Convert.ToInt64(txbTT3tn.Text);
                Master master = new Master(a, lbtime.Text, b, c, d, g,f);
                BillDAO.Instance.AddMaster(master);
                foreach (ListViewItem ListItem in thunganlistview.Items)
                {
                    long a1 = Convert.ToInt64(ListItem.SubItems[1].Text);
                    int b1 = Convert.ToInt32(ListItem.SubItems[2].Text);
                    long c1 = Convert.ToInt64(ListItem.SubItems[3].Text);
                    Detail detail = new Detail(a, ListItem.SubItems[0].Text, a1, b1, c1);
                    BillDAO.Instance.AddDetail(detail);
                    
                }
            }
            else
            {
                MessageBox.Show("Hóa Đơn Trống!");
            }
        }

        private void btcleartn_Click(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToString();
            lbsohoadon.Text = (RowCount() + 1).ToString();
            thunganlistview.Items.Clear();
            txbTHtn.Text = "";
            txbMHtn.Text = "";
            txbDGtn.Text = "";
            txbSLtn.Text = "";
            txbTtn.Text = "";
            txbTTtn.Text = "0";
            txbGGtn.Text = "";
            txbTT2tn.Text = "";
            txbKTtn.Text = "";
            txbTT3tn.Text = "";
        }
        public int RowCount()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.Master";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection("Data Source=DESKTOP-0U67BQC\\XUANDINH;Initial Catalog=SupermarketManagement;Integrated Security=True"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }

        private void ThuNgan_Load(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToString();
            lbsohoadon.Text = (RowCount()+1).ToString();
        }

        private void txbin_Click(object sender, EventArgs e)
        {
            new BillReport.PrintBill().Show();
        }
    }
}
