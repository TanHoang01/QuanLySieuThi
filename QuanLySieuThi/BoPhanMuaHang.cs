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
    public partial class BoPhanMuaHang : Form
    {
        public BoPhanMuaHang()
        {
            InitializeComponent();
        }

        private void thôngTinNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuaHangPanel.Controls.Clear();
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.LemonChiffon;
            MuaHangPanel.Controls.Add(dataGridView);
            dataGridView.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM ReceiptGoods");
        }

        private void thôngTinXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuaHangPanel.Controls.Clear();
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.LemonChiffon;
            MuaHangPanel.Controls.Add(dataGridView);
            dataGridView.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM IssueGoods");
        }

        private void báoCáoNhậpXuấtTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RIForm f = new RIForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinHàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuaHangPanel.Controls.Clear();
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.LemonChiffon;
            MuaHangPanel.Controls.Add(dataGridView);
            dataGridView.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Goods");
        }
    }
}
