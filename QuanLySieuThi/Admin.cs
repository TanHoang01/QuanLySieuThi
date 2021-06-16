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

namespace QuanLySieuThi
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void themTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan f = new ThemTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void xoaTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaTaiKhoan f = new XoaTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void danhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel.Controls.Clear();
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.LemonChiffon;
            AdminPanel.Controls.Add(dataGridView);
            dataGridView.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account");
        }

        private void danhSáchHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel.Controls.Clear();
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.LemonChiffon;
            AdminPanel.Controls.Add(dataGridView);
            dataGridView.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Goods");
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
