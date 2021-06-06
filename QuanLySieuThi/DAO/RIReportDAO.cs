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
    class RIReportDAO : DataProvider
    {
        private static RIReportDAO instance;
        public static RIReportDAO Instance
        {
            get { if (instance == null) instance = new RIReportDAO(); return instance; }
            private set { instance = value; }
        }
        private RIReportDAO() { }
        public void AddRI(RIReport ri)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO RIReport VALUES (@ID,@MaHangHoa,@TenHang,@TonDauKy,@Nhap,@Xuat,@TonCuoiKy,@GhiChu)", connection);
                    command.Parameters.AddWithValue("@ID", ri.ID);
                    command.Parameters.AddWithValue("@MaHangHoa", ri.MaHangHoa);
                    command.Parameters.AddWithValue("@TenHang", ri.TenHang);
                    command.Parameters.AddWithValue("@TonDauKy", ri.TonDauKy);
                    command.Parameters.AddWithValue("@Nhap", ri.Nhap);
                    command.Parameters.AddWithValue("@Xuat", ri.Xuat);
                    command.Parameters.AddWithValue("@TonCuoiKy", ri.TonCuoiKy);
                    command.Parameters.AddWithValue("@GhiChu", ri.GhiChu);
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
