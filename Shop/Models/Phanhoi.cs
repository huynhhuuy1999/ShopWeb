using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Phanhoi
    {
        public int PhanHoiId { get; set; }
        public int? BinhLuanId { get; set; }
        public string NoiDung { get; set; }
        public int? TaiKhoanId { get; set; }

        public Binhluan BinhLuan { get; set; }
        public Taikhoan TaiKhoan { get; set; }
    }
}
