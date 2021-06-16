using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySieuThi.DTO
{
    class Master
    {
        private int inID;
        private string inDate;
        private long tongTien;
        private long giamGia;
        private long thanhTien;
        private long khachHangThanhToan;
        private long tienThoi;

        public int InID { get => inID; set => inID = value; }
        public string InDate { get => inDate; set => inDate = value; }
        public long TongTien { get => tongTien; set => tongTien = value; }
        public long GiamGia { get => giamGia; set => giamGia = value; }
        public long ThanhTien { get => thanhTien; set => thanhTien = value; }
        public long KhachHangThanhToan { get => khachHangThanhToan; set => khachHangThanhToan = value; }
        public long TienThoi { get => tienThoi; set => tienThoi = value; }

        public Master()
        {

        }
        public Master(int inID, string inDate, long tongTien, long giamGia,long thanhTien, long khachHangThanhToan, long tienThoi)
        {
            this.inID = inID;
            this.inDate = inDate;
            this.tongTien = tongTien;
            this.giamGia = giamGia;
            this.thanhTien = thanhTien;
            this.khachHangThanhToan = khachHangThanhToan;
            this.tienThoi = tienThoi;
        }
        public Master(DataRow dataRow)
        {
            this.inID = Convert.ToInt32(dataRow["InID"]);
            this.inDate = dataRow["InDate"].ToString();
            this.tongTien = Convert.ToInt64(dataRow["TongTien"]);
            this.giamGia = Convert.ToInt64(dataRow["GiamGia"]);
            this.thanhTien = Convert.ToInt64(dataRow["ThanhTien"]);
            this.khachHangThanhToan = Convert.ToInt64(dataRow["KhachHangThanhToan"]);
            this.tienThoi = Convert.ToInt64(dataRow["TienThoi"]);
        }
    }
}
