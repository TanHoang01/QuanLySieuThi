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
    public partial class ThuKho : Form
    {
        public ThuKho()
        {
            InitializeComponent();
        }

        private void ThuKho_Load(object sender, EventArgs e)
        {
            ThuKhoDataGridView.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Goods");
        }
        public void SearchByKeyWord()
        {
            ThuKhoDataGridView.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Goods WHERE TenHang LIKE '%"+txbTimHang.Text+"%' ");
        }
        private void txbTimHang_TextChanged(object sender, EventArgs e)
        {
            if (txbTimHang.Text == "")
            {
                ThuKhoDataGridView.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Goods");
            }
            else
            {
                SearchByKeyWord();
            }
        }

        private void thêmHàngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemHangMoi f = new ThemHangMoi();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {
            ThuKhoDataGridView.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Goods WHERE TenHang LIKE '%" + txbTimHang.Text + "%' ");
        }

        private void thêmHàngCóSẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemHangCu f = new ThemHangCu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuatHang f = new XuatHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
