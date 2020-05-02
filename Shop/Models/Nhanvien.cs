using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Hoadon = new HashSet<Hoadon>();
        }

        public int NhanVienId { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public int? TaiKhoanId { get; set; }

        public Taikhoan TaiKhoan { get; set; }
        public ICollection<Hoadon> Hoadon { get; set; }
    }
}
