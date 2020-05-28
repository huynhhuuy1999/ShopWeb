using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Loaitaikhoan
    {
        public Loaitaikhoan()
        {
            Taikhoan = new HashSet<Taikhoan>();
        }

        public int LoaiTaiKhoanId { get; set; }
        public string TenLoaiTaiKhoan { get; set; }

        public ICollection<Taikhoan> Taikhoan { get; set; }
    }
}
