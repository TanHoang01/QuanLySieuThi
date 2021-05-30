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
            if (String.IsNullOrEmpty(txbMaHangThem.Text) || String.IsNullOrEmpty(txbTenHangThem.Text) || String.IsNullOrEmpty(txbDonViThem.Text) || String.IsNullOrEmpty(txbSoLuongThem.Text) || String.IsNullOrEmpty(txbDonGiaThem.Text))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                lbTime.Text = DateTime.Now.ToString();
                int x = Int32.Parse(txbSoLuongThem.Text);
                long y = Int64.Parse(txbDonGiaThem.Text);
                Goods goods = new Goods(txbMaHangThem.Text, txbTenHangThem.Text, txbDonViThem.Text, x, y);
                GoodsDAO.Instance.AddNewGoods(goods);
                Receipt receipt = new Receipt(txbMaHangThem.Text, txbTenHangThem.Text,txbDonViThem.Text, x, y, lbTime.Text);
                GoodsDAO.Instance.ReceiptGoods(receipt);
            }
        }

        private void ThemHangMoi_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }
    }
}
