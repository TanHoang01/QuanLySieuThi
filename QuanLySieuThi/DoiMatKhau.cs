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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btHuyDoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btThayDoi_Click(object sender, EventArgs e)
        {
            string a = txbDNCu.Text;
            string b = txbMKCu.Text;
            string c = txbDNMoi.Text; 
            string d = txbMKMoi.Text;
            if (String.IsNullOrEmpty(txbDNCu.Text) || String.IsNullOrEmpty(txbDNMoi.Text) || String.IsNullOrEmpty(txbMKCu.Text) || String.IsNullOrEmpty(txbMKMoi.Text))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                AccountDAO.Instance.UpdateAccount(a, b, c, d);
            }
        }
    }
}
