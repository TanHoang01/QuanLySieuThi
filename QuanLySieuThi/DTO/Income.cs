using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DTO
{
    class Income
    {
        private int sTT;
        private string maHangHoa;
        private string tenHangHoa;
        private long thanhTien;

        public int STT { get => sTT; set => sTT = value; }
        public string MaHangHoa { get => maHangHoa; set => maHangHoa = value; }
        public string TenHangHoa { get => tenHangHoa; set => tenHangHoa = value; }
        public long ThanhTien { get => thanhTien; set => thanhTien = value; }

        public Income()
        {

        }
        public Income(int sTT ,string maHangHoa, string tenHangHoa, long thanhTien)
        {
            this.sTT = sTT;
            this.maHangHoa = maHangHoa;
            this.tenHangHoa = tenHangHoa;
            this.thanhTien = thanhTien;
        }
        public Income(DataRow dataRow)
        {
            this.sTT = Convert.ToInt32(dataRow["STT"]);
            this.maHangHoa = dataRow["MaHangHoa"].ToString();
            this.tenHangHoa = dataRow["TenHangHoa"].ToString();
            this.thanhTien = Convert.ToInt64(dataRow["ThanhTien"]);
        }
    }
}
