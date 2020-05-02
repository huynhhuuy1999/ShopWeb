using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Taikhoan
    {
        public Taikhoan()
        {
            Admin = new HashSet<Admin>();
            Khachhang = new HashSet<Khachhang>();
            Nhanvien = new HashSet<Nhanvien>();
        }

        public int TaiKhoanId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? NgayTao { get; set; }
        public sbyte? KichHoat { get; set; }

        public ICollection<Admin> Admin { get; set; }
        public ICollection<Khachhang> Khachhang { get; set; }
        public ICollection<Nhanvien> Nhanvien { get; set; }
    }
}
