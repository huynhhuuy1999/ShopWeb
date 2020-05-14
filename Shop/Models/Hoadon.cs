using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }

        public int HoaDonId { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string SoNha { get; set; }
        public string Quan { get; set; }
        public int? PhiShipId { get; set; }
        public float? TongTienThanhToan { get; set; }
        public string TrangThai { get; set; }
        public int? NhanVienId { get; set; }
        public int? KhachHangId { get; set; }
        public string TenNguoiNhan { get; set; }
        public string Sdt { get; set; }
        public float? TongTienChuaShip { get; set; }
        public float? TienGiamGia { get; set; }
        public string SessionId { get; set; }

        public Khachhang KhachHang { get; set; }
        public Nhanvien NhanVien { get; set; }
        public Phiship PhiShip { get; set; }
        public ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
