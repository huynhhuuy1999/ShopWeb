using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Kichthuoc
    {
        public Kichthuoc()
        {
            Cart = new HashSet<Cart>();
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }

        public int KichThuocid { get; set; }
        public int? SanPhamId { get; set; }
        public string TenKichThuoc { get; set; }
        public float? GiaThem { get; set; }

        public Sanpham SanPham { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
