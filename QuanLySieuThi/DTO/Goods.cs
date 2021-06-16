using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySieuThi.DTO
{
    class Goods
    {
        private string maHangHoa;
        private string tenHang;
        private string donVi;
        private int soLuong;
        private long donGia;
        private string ghiChu;

        public string MaHangHoa { get => maHangHoa; set => maHangHoa = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public long DonGia { get => donGia; set => donGia = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public Goods()
        {

        }
        public Goods(string maHangHoa, string tenHang, string donVi,int soLuong,long donGia,string ghiChu)
        {
            this.maHangHoa = maHangHoa;
            this.tenHang = tenHang;
            this.donVi = donVi;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.ghiChu = ghiChu;
        }
        public Goods(DataRow dataRow)
        {
            this.maHangHoa = dataRow["MaHangHoa"].ToString();
            this.tenHang = dataRow["TenHang"].ToString();
            this.donVi = dataRow["DonVi"].ToString();
            this.soLuong = Convert.ToInt32(dataRow["SoLuong"]);
            this.donGia = Convert.ToInt64(dataRow["DonGia"]);
            this.ghiChu = dataRow["GhiChu"].ToString();
        }
    }
}
