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
    class GoodsDAO : DataProvider
    {
        private static GoodsDAO instance;
        public static GoodsDAO Instance
        {
            get { if (instance == null) instance = new GoodsDAO(); return instance; }
            private set { instance = value; }
        }
        private GoodsDAO() { }

        public DataTable LoadGoods()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Goods");
            return data;
        }
        public void AddNewGoods(Goods goods)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Goods VALUES (@MaHangHoa,@TenHang,@DonVi,@SoLuong,@DonGia)", connection);
                    command.Parameters.AddWithValue("@MaHangHoa", goods.MaHangHoa);
                    command.Parameters.AddWithValue("@TenHang", goods.TenHang);
                    command.Parameters.AddWithValue("@DonVi", goods.DonVi);
                    command.Parameters.AddWithValue("@SoLuong", goods.SoLuong);
                    command.Parameters.AddWithValue("@DonGia", goods.DonGia);
                    int a = command.ExecuteNonQuery();
                    connection.Close();
                    if (a == 0)
                    {
                        MessageBox.Show("Hàng Hóa Đã Tồn Tại!", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Hàng Hóa Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show("Hàng Hóa Đã Tồn Tại!", "Thông Báo", MessageBoxButtons.OK);
                }
            }

        }
        public void ReceiptGoods(Receipt receipt)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO ReceiptGoods VALUES (@MaHangHoa,@TenHang,@DonVi,@SoLuong,@DonGia,@ThoiGian)", connection);
                    command.Parameters.AddWithValue("@MaHangHoa", receipt.MaHangHoa);
                    command.Parameters.AddWithValue("@TenHang", receipt.TenHang);
                    command.Parameters.AddWithValue("@DonVi", receipt.DonVi);
                    command.Parameters.AddWithValue("@SoLuong", receipt.SoLuong);
                    command.Parameters.AddWithValue("@DonGia", receipt.DonGia);
                    command.Parameters.AddWithValue("@ThoiGian", receipt.ThoiGian);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi!", "Thông Báo", MessageBoxButtons.OK);
                }
            }

        }
        public void IssueGoods(Issue issue)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO IssueGoods VALUES (@MaHangHoa,@TenHang,@DonVi,@SoLuong,@DonGia,@ThoiGian)", connection);
                    command.Parameters.AddWithValue("@MaHangHoa", issue.MaHangHoa);
                    command.Parameters.AddWithValue("@TenHang", issue.TenHang);
                    command.Parameters.AddWithValue("@DonVi", issue.DonVi);
                    command.Parameters.AddWithValue("@SoLuong", issue.SoLuong);
                    command.Parameters.AddWithValue("@DonGia", issue.DonGia);
                    command.Parameters.AddWithValue("@ThoiGian", issue.ThoiGian);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi!", "Thông Báo", MessageBoxButtons.OK);
                }
            }

        }
        public void UpdateReceipt(string a, string b)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Goods SET SoLuong = SoLuong + '" + b + "' WHERE MaHangHoa =  '" + a + "'", connection);
                    int c = command.ExecuteNonQuery();
                    connection.Close();
                    if (c == 0)
                    {
                        MessageBox.Show("Mă Hàng Không Đúng!", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Hàng Hóa Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show("Mă Hàng Không Đúng!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }
        public void UpdateIssue(string a, string b)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Goods SET SoLuong = SoLuong - '" + b + "' WHERE MaHangHoa =  '" + a + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                }
                catch
                {
                    MessageBox.Show("Lỗi!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }
        public void FakeIssueGoods(FakeIssue fakeIssue)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO FakeIssue VALUES (@ID,@MaHangHoa,@TenHang,@DonVi,@SoLuong,@DonGia,@GhiChu)", connection);
                    command.Parameters.AddWithValue("@ID", fakeIssue.ID);
                    command.Parameters.AddWithValue("@MaHangHoa", fakeIssue.MaHangHoa);
                    command.Parameters.AddWithValue("@TenHang", fakeIssue.TenHang);
                    command.Parameters.AddWithValue("@DonVi", fakeIssue.DonVi);
                    command.Parameters.AddWithValue("@SoLuong", fakeIssue.SoLuong);
                    command.Parameters.AddWithValue("@DonGia", fakeIssue.DonGia);
                    command.Parameters.AddWithValue("@GhiChu", fakeIssue.GhiChu);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi!", "Thông Báo", MessageBoxButtons.OK);
                }
            }

        }
    }
}
