using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Chitiethoadon
    {
        public int ChiTietHoaDonId { get; set; }
        public int? HoaDonId { get; set; }
        public int? SanPhamId { get; set; }
        public int? SoLuong { get; set; }
        public float? TienKhuyenMai { get; set; }
        public float? TongTien { get; set; }
        public float? TongSauKm { get; set; }
        public int? KichThuocId { get; set; }

        public Hoadon HoaDon { get; set; }
        public Kichthuoc KichThuoc { get; set; }
        public Sanpham SanPham { get; set; }
    }
}
