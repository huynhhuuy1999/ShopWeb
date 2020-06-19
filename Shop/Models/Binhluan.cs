using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Binhluan
    {
        public Binhluan()
        {
            Phanhoi = new HashSet<Phanhoi>();
        }

        public int BinhLuanId { get; set; }
        public int? TaiKhoanId { get; set; }
        public int? SanPhamId { get; set; }
        public string NoiDung { get; set; }

        public Sanpham SanPham { get; set; }
        public Taikhoan TaiKhoan { get; set; }
        public ICollection<Phanhoi> Phanhoi { get; set; }
    }
}
