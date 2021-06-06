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
    public partial class KiemToanVien : Form
    {
        public KiemToanVien()
        {
            InitializeComponent();
        }

        private void thôngTinNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiemToanpanel.Controls.Clear();
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.LemonChiffon;
            KiemToanpanel.Controls.Add(dataGridView);
            dataGridView.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM ReceiptGoods");
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiemToanpanel.Controls.Clear();
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.LemonChiffon;
            KiemToanpanel.Controls.Add(dataGridView);
            dataGridView.DataSource = DataProvider.Instance.ExecuteQuery("Select * From [ViewALLBILL] ORDER BY InID DESC");
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeForm f = new IncomeForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
