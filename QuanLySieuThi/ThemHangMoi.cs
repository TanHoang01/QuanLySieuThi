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

namespace QuanLySieuThi
{
    public partial class ThemHangMoi : Form
    {
        public ThemHangMoi()
        {
            InitializeComponent();
        }

        private void btHuyThemHangMoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThemHangMoi_Click(object sender, EventArgs e)
        {
            if (themhangmoilistview.Items.Count > 0)
            {
                foreach (ListViewItem ListItem in themhangmoilistview.Items)
                {
                    int a = Convert.ToInt32(ListItem.SubItems[3].Text);
                    long b = Convert.ToInt64(ListItem.SubItems[4].Text);
                    Goods goods = new Goods(ListItem.SubItems[0].Text, ListItem.SubItems[1].Text, ListItem.SubItems[2].Text,a , b, ListItem.SubItems[5].Text);
                    GoodsDAO.Instance.AddNewGoods(goods);
                    Receipt receipt = new Receipt(ListItem.SubItems[0].Text, ListItem.SubItems[1].Text, ListItem.SubItems[2].Text, a, b, lbTime.Text);
                    GoodsDAO.Instance.ReceiptGoods(receipt);
                }
                MessageBox.Show("Bảng Nhập Kho Đã Được Cập Nhật", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Hóa Đơn Trống!");
            }
           
            
        }

        private void ThemHangMoi_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMaHangThem.Text) || string.IsNullOrEmpty(txbTenHangThem.Text) || string.IsNullOrEmpty(txbDonViThem.Text) || string.IsNullOrEmpty(txbSoLuongThem.Text) || string.IsNullOrEmpty(txbDonGiaThem.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin!", "Thông Báo");
            }
            else
            {
                    string[] arr = new string[6];
                    arr[0] = txbMaHangThem.Text;
                    arr[1] = txbTenHangThem.Text;
                    arr[2] = txbDonViThem.Text;
                    arr[3] = txbSoLuongThem.Text;
                    arr[4] = txbDonGiaThem.Text;
                    arr[5] = txbGhiChuThem.Text;
                    ListViewItem lvi = new ListViewItem(arr);
                    themhangmoilistview.Items.Add(lvi);
            }
        }

        private void btXoaThem_Click(object sender, EventArgs e)
        {

            if (themhangmoilistview.SelectedItems.Count > 0)
            {
                for (int i = 0; i < themhangmoilistview.Items.Count; i++)
                {
                    if (themhangmoilistview.Items[i].Selected)
                    {
                        themhangmoilistview.Items[i].Remove();
                    }
                }
            }
        }
    }
}
