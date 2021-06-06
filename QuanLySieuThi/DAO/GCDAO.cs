using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.DTO;


namespace QuanLySieuThi.DAO
{
    class GCDAO : DataProvider
    {
        private static GCDAO instance;
        public static GCDAO Instance
        {
            get { if (instance == null) instance = new GCDAO(); return instance; }
            private set { instance = value; }
        }
        private GCDAO() { }
        public void AddGiaoCa(GiaoC giao)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO GiaoCa VALUES (@STT,@MaHangHoa,@TenHangHoa,@DonVi,@Nhap,@XuatBan,@Mat,@Ton,@GhiChu)", connection);
                    command.Parameters.AddWithValue("@STT", giao.STT);
                    command.Parameters.AddWithValue("@MaHangHoa", giao.MaHangHoa);
                    command.Parameters.AddWithValue("@TenHangHoa", giao.TenHangHoa);
                    command.Parameters.AddWithValue("@DonVi", giao.DonVi);
                    command.Parameters.AddWithValue("@Nhap", giao.Nhap);
                    command.Parameters.AddWithValue("@XuatBan", giao.XuatBan);
                    command.Parameters.AddWithValue("@Mat", giao.Mat);
                    command.Parameters.AddWithValue("@Ton", giao.Ton);
                    command.Parameters.AddWithValue("@GhiChu", giao.GhiChu);
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
