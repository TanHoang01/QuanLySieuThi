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

namespace QuanLySieuThi
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbTenDangNhap.Text) || string.IsNullOrEmpty(txbMatKhau.Text))
            {
                MessageBox.Show("Bạn Chưa Điền Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                string usename = txbTenDangNhap.Text;
                string password = txbMatKhau.Text;
                if (AccountDAO.Instance.CheckLogin(usename, password) == "Admin")
                {
                    Admin f = new Admin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    txbTenDangNhap.Clear();
                    txbMatKhau.Clear();
                }
                else if (AccountDAO.Instance.CheckLogin(usename, password) == "Thu Ngân")
                {
                    ThuNgan f = new ThuNgan();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if(AccountDAO.Instance.CheckLogin(usename,password) == "Thủ Kho")
                {
                    ThuKho f = new ThuKho();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if(AccountDAO.Instance.CheckLogin(usename,password) == "Bộ Phận Mua Hàng")
                {
                    BoPhanMuaHang f = new BoPhanMuaHang();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if(AccountDAO.Instance.CheckLogin(usename, password) == "Kiểm Toán Viên")
                {
                    KiemToanVien f = new KiemToanVien();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (AccountDAO.Instance.CheckLogin(usename, password) == "Quản Lý Quầy")
                {
                    QuanLyQuay f = new QuanLyQuay();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai...");
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
