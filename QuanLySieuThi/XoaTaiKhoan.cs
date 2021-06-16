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
    public partial class XoaTaiKhoan : Form
    {
        public XoaTaiKhoan()
        {
            InitializeComponent();
        }

        private void btHuyXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string username = "";
        static string displayname = "";
        static string password = "";

        private void XoaTaiKhoan_Load(object sender, EventArgs e)
        {
            DeleteDGV.DataSource = AccountDAO.Instance.Load();
        }

        private void DeleteDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DeleteDGV.Rows[e.RowIndex];
                username = row.Cells[0].Value.ToString();
                displayname = row.Cells[1].Value.ToString();
                password = row.Cells[2].Value.ToString();
            }
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            string message = "Bạn Có Muốn Khóa Tài Khoản?";
            string title = "Cảnh Báo!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                AccountDAO.Instance.DeleteAccount(username, displayname, password);
                this.Close();
            }
        }
    }
}
