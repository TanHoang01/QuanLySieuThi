using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLySieuThi.DTO;
using System.Windows.Forms;

namespace QuanLySieuThi.DAO
{
    class BillDAO : DataProvider
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        private BillDAO() { }

        public void AddDetail (Detail detail)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Detail VALUES (@DID,@SanPham,@DonGia,@SoLuong,@Tong)", connection);
                    command.Parameters.AddWithValue("@DID", detail.DID);
                    command.Parameters.AddWithValue("@SanPham", detail.SanPham);
                    command.Parameters.AddWithValue("@DonGia", detail.DonGia);
                    command.Parameters.AddWithValue("@SoLuong", detail.SoLuong);
                    command.Parameters.AddWithValue("@Tong", detail.Tong);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Hóa Đơn Đã Tồn Tại!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }
        public void AddMaster(Master master)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Master VALUES (@InID,@InDate,@TongTien,@GiamGia,@ThanhTien,@KhachHangThanhToan,@TienThoi)", connection);
                    command.Parameters.AddWithValue("@InID", master.InID);
                    command.Parameters.AddWithValue("@InDate", master.InDate);
                    command.Parameters.AddWithValue("@TongTien", master.TongTien);
                    command.Parameters.AddWithValue("@GiamGia", master.GiamGia);
                    command.Parameters.AddWithValue("@ThanhTien", master.ThanhTien);
                    command.Parameters.AddWithValue("@KhachHangThanhToan", master.KhachHangThanhToan);
                    command.Parameters.AddWithValue("@TienThoi", master.TienThoi);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm Hóa Đơn Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Hóa Đơn Đã Tồn Tại!", "Thông Báo", MessageBoxButtons.OK);
                }
            }

        }
        public void AddIncome(Income income)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Income VALUES (@STT,@MaHangHoa,@TenHangHoa,@ThanhTien)", connection);
                    command.Parameters.AddWithValue("@STT", income.STT);
                    command.Parameters.AddWithValue("@MaHangHoa", income.MaHangHoa);
                    command.Parameters.AddWithValue("@TenHangHoa", income.TenHangHoa);
                    command.Parameters.AddWithValue("@ThanhTien", income.ThanhTien);
                    command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Hóa Đơn Đã Tồn Tại!", "Thông Báo", MessageBoxButtons.OK);
                }
            }

        }
    }
}

