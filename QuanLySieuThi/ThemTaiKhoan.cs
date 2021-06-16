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
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbThemTDN.Text) || String.IsNullOrEmpty(txbThemTHT.Text) || String.IsNullOrEmpty(txbThemMK.Text) || String.IsNullOrEmpty(cbbThemVT.Text))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                Account account = new Account(txbThemTDN.Text, txbThemTHT.Text, txbThemMK.Text,cbbThemVT.Text);
                AccountDAO.Instance.AddAccount(account);
            }
        }

        private void btHuyThem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
