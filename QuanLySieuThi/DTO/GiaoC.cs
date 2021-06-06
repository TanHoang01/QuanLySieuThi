using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DTO
{
    class GiaoC
    {
        private int sTT;
        private string maHangHoa;
        private string tenHangHoa;
        private string donVi;
        private int nhap;
        private int xuatBan;
        private int mat;
        private int ton;
        private string ghiChu;

        public int STT { get => sTT; set => sTT = value; }
        public string MaHangHoa { get => maHangHoa; set => maHangHoa = value; }
        public string TenHangHoa { get => tenHangHoa; set => tenHangHoa = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int Nhap { get => nhap; set => nhap = value; }
        public int XuatBan { get => xuatBan; set => xuatBan = value; }
        public int Mat { get => mat; set => mat = value; }
        public int Ton { get => ton; set => ton = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public GiaoC()
        {

        }
        public GiaoC(int sTT, string maHangHoa, string tenHangHoa, string donVi, int nhap,int xuatBan,int mat,int ton, string ghiChu)
        {
            this.sTT = sTT;
            this.maHangHoa = maHangHoa;
            this.tenHangHoa = tenHangHoa;
            this.donVi = donVi;
            this.nhap = nhap;
            this.xuatBan = xuatBan;
            this.mat = mat;
            this.ton = ton;
            this.ghiChu = ghiChu;
        }
        public GiaoC(DataRow dataRow)
        {
            this.sTT = Convert.ToInt32(dataRow["STT"]);
            this.maHangHoa = dataRow["MaHangHoa"].ToString();
            this.tenHangHoa = dataRow["TenHangHoa"].ToString();
            this.donVi = dataRow["DonVi"].ToString();
            this.nhap = Convert.ToInt32(dataRow["Nhap"]);
            this.xuatBan = Convert.ToInt32(dataRow["XuatBan"]);
            this.mat = Convert.ToInt32(dataRow["Mat"]);
            this.ton = Convert.ToInt32(dataRow["Ton"]);
            this.ghiChu = dataRow["GhiChu"].ToString();
        }
    }
}
