using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int? SanPhamId { get; set; }
        public int? Soluong { get; set; }
        public int? KichthuocId { get; set; }
        public string IdSession { get; set; }
        public float? Tongtien { get; set; }

        public Kichthuoc Kichthuoc { get; set; }
        public Sanpham SanPham { get; set; }
    }
}
