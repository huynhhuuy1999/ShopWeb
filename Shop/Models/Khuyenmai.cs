using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Khuyenmai
    {
        public Khuyenmai()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public int KhuyenMaiId { get; set; }
        public string TenKhuyenMai { get; set; }
        public string MoTa { get; set; }
        public float? PhanTramGiam { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? TrangThai { get; set; }

        public ICollection<Sanpham> Sanpham { get; set; }
    }
}
