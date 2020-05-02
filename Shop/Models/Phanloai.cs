using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Phanloai
    {
        public Phanloai()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public int PhanLoaiId { get; set; }
        public string TenLoai { get; set; }

        public ICollection<Sanpham> Sanpham { get; set; }
    }
}
