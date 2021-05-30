using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DTO
{
    class RIReport
    {
            public int ID { get; set; }
            public string MaHangHoa { get; set; }
            public string TenHang { get; set; }
            public int TonDauKy { get; set; }
            public int Nhap { get; set; }
            public int Xuat { get; set; }
            public int TonCuoiKy { get; set; }
            public string GhiChu { get; set; }   
    }
}
