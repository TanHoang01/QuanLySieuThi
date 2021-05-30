using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using QuanLySieuThi.DTO;

namespace QuanLySieuThi
{
    public partial class RIForm : Form
    {
        int order = 1;
        public RIForm()
        {
            InitializeComponent();
        }

        private void RIForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbmhh.Text) || string.IsNullOrEmpty(txbthh.Text) || string.IsNullOrEmpty(txbn.Text) || string.IsNullOrEmpty(txbx.Text) || string.IsNullOrEmpty(txbtdk.Text) || string.IsNullOrEmpty(txbtck.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin!", "Thông Báo");
            }
            else
            {
                int a = Convert.ToInt32(txbtdk.Text);
                int b = Convert.ToInt32(txbn.Text);
                int c = Convert.ToInt32(txbx.Text);
                int d = Convert.ToInt32(txbtck.Text);
                RIReport rIReport = new RIReport() { ID = order++,MaHangHoa = txbmhh.Text,TenHang = txbthh.Text,TonDauKy = a,Nhap = b,Xuat = c,TonCuoiKy = d,GhiChu = txbgc.Text };
                rIReportBindingSource.Add(rIReport);
                rIReportBindingSource.MoveLast();
            }
        }

        private void txbin_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Báo Cáo Nhập Xuất Tồn";
            printer.SubTitle = "Từ ngày...Đến Ngày...";
            printer.PrintPreviewDataGridView(RIFormDataGV);
            printer.PrintDataGridView(RIFormDataGV);
            
        }
    }
}
