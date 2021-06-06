using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DTO
{
    class RIReport
    {
        public int iD;
        public string maHangHoa;
        public string tenHang;
        public int tonDauKy;
        public int nhap;
        public int xuat;
        public int tonCuoiKy;
        public string ghiChu;
        public int ID { get => iD; set => iD = value; }
        public string MaHangHoa { get => maHangHoa; set => maHangHoa = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int TonDauKy { get => tonDauKy; set => tonDauKy = value; }
        public int Nhap { get => nhap; set => nhap = value; }
        public int Xuat { get => xuat; set => xuat = value; }
        public int TonCuoiKy { get => tonCuoiKy; set => tonCuoiKy = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public RIReport()
        {

        }
        public RIReport(int id,string maHangHoa, string tenHang, int tonDauKy, int nhap,int xuat,int tonCuoiKy, string ghiChu)
        {
            this.iD = id;
            this.maHangHoa = maHangHoa;
            this.tenHang = tenHang;
            this.tonDauKy = tonDauKy;
            this.nhap = nhap;
            this.xuat = xuat;
            this.tonCuoiKy = tonCuoiKy;
            this.ghiChu = ghiChu;
        }
        public RIReport(DataRow dataRow)
        {
            this.iD = Convert.ToInt32(dataRow["ID"]);
            this.maHangHoa = dataRow["MaHangHoa"].ToString();
            this.tenHang = dataRow["TenHang"].ToString();
            this.tonDauKy = Convert.ToInt32(dataRow["TonDauKy"]);
            this.nhap = Convert.ToInt32(dataRow["Nhap"]);
            this.xuat = Convert.ToInt32(dataRow["Xuat"]);
            this.tonDauKy = Convert.ToInt32(dataRow["TonCuoiKy"]);
            this.ghiChu = dataRow["GhiChu"].ToString();
        }
    }
}
