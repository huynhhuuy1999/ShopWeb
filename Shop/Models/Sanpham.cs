using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Cart = new HashSet<Cart>();
            Chitiethoadon = new HashSet<Chitiethoadon>();
            Kichthuoc = new HashSet<Kichthuoc>();
        }

        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; }
        public string Mota { get; set; }
        public float? GiaGoc { get; set; }
        public float? GiaBanLe { get; set; }
        public int? Kho { get; set; }
        public int? TrangThai { get; set; }
        public int? PhanLoaiId { get; set; }
        public int? KhuyenMaiId { get; set; }
        public int? HinhAnhId { get; set; }

        public Hinhanh HinhAnh { get; set; }
        public Khuyenmai KhuyenMai { get; set; }
        public Phanloai PhanLoai { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Chitiethoadon> Chitiethoadon { get; set; }
        public ICollection<Kichthuoc> Kichthuoc { get; set; }
    }
}
