using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Hinhanh
    {
        public Hinhanh()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public int HinhAnhId { get; set; }
        public string TenFile { get; set; }

        public ICollection<Sanpham> Sanpham { get; set; }
    }
}
