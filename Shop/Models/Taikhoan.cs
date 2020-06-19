using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public partial class Taikhoan
    {
        public Taikhoan()
        {
            Admin = new HashSet<Admin>();
            Binhluan = new HashSet<Binhluan>();
            Khachhang = new HashSet<Khachhang>();
            Nhanvien = new HashSet<Nhanvien>();
            Phanhoi = new HashSet<Phanhoi>();
        }

        public int TaiKhoanId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? NgayTao { get; set; }
        public sbyte? KichHoat { get; set; }
        public int? LoaiTaiKhoanId { get; set; }

        public Loaitaikhoan LoaiTaiKhoan { get; set; }
        public ICollection<Admin> Admin { get; set; }
        public ICollection<Binhluan> Binhluan { get; set; }
        public ICollection<Khachhang> Khachhang { get; set; }
        public ICollection<Nhanvien> Nhanvien { get; set; }
        public ICollection<Phanhoi> Phanhoi { get; set; }
    }
}
