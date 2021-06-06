using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySieuThi.DTO
{
    class Detail
    {
        private int dID;
        private string sanPham;
        private long donGia;
        private int soLuong;
        private long tong;

        public int DID { get => dID; set => dID = value; }
        public string SanPham { get => sanPham; set => sanPham = value; }
        public long DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public long Tong { get => tong; set => tong = value; }

        public Detail()
        {

        }
        public Detail(int dID, string sanPham, long donGia, int soLuong, long tong)
        {
            this.dID = dID;
            this.sanPham = sanPham;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.tong = tong;
        }
        public Detail(DataRow dataRow)
        {
            this.dID = Convert.ToInt32(dataRow["DID"]);
            this.sanPham = dataRow["SanPham"].ToString();
            this.donGia = Convert.ToInt64(dataRow["DonGia"]);
            this.soLuong = Convert.ToInt32(dataRow["SoLuong"]);
            this.tong = Convert.ToInt64(dataRow["Tong"]);
        }
    }
}
