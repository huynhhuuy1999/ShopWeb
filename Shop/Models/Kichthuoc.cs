using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Kichthuoc
    {
        public int KichThuocid { get; set; }
        public int? SanPhamId { get; set; }
        public string TenKichThuoc { get; set; }
        public float? GiaThem { get; set; }

        public Sanpham SanPham { get; set; }
    }
}
