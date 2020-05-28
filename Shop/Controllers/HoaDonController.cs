using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace Shop.Controllers{
    public class HoaDonController : Controller
    {
        public IActionResult XemDanhSachHoaDon(){
            var dbContext = new shopContext();
            // lấy thông tin trong bảng hóa đơn
            var hoadon = (from hd in dbContext.Hoadon
                            join ps in dbContext.Phiship
                            on hd.PhiShipId equals ps.PhiShipId
                            join kh in dbContext.Khachhang
                            on hd.KhachHangId equals kh.KhachHangId
                            join nv in dbContext.Nhanvien
                            on hd.NhanVienId equals nv.NhanVienId into x
                            from subnv in x.DefaultIfEmpty()
                            select new{
                                hoadonid = hd.HoaDonId,
                                ngaytao = hd.NgayTao,
                                ngaygiao = hd.NgayGiao,
                                sonha = hd.SoNha,
                                quan = hd.Quan,
                                phiship = ps.ChiPhi,
                                thanhtoan = hd.TongTienThanhToan,
                                trangthai = hd.TrangThai,
                                nhanvien = subnv.HoTen,
                                khachhang = kh.HoTen,
                                tennguoinhan = hd.TenNguoiNhan,
                                sdt = hd.Sdt,
                                tienchuaship = hd.TongTienChuaShip,
                                tiengiamgia = hd.TienGiamGia
                            });
            List<Hoadon> ListHD = new List<Hoadon>();
            foreach (var item in hoadon)
            {
                Hoadon hd = new Hoadon ();
                Nhanvien nv = new Nhanvien();
                Khachhang kh = new Khachhang();
                Phiship ps = new Phiship();
                hd.HoaDonId= item.hoadonid;
                hd.NgayTao = item.ngaygiao;
                hd.NgayGiao = item.ngaygiao;
                hd.SoNha = item.sonha;
                hd.Quan = item.quan;
                ps.ChiPhi = item.phiship;
                hd.TongTienThanhToan = item.thanhtoan;
                hd.TrangThai = item.trangthai;
                nv.HoTen = item.nhanvien;
                kh.HoTen = item.khachhang;
                hd.TenNguoiNhan =item.tennguoinhan;
                hd.Sdt = item.sdt;
                hd.TongTienChuaShip = item.tienchuaship;
                hd.TienGiamGia = item.tiengiamgia;
                hd.NhanVien = nv;
                hd.KhachHang= kh;
                hd.PhiShip = ps;
                ListHD.Add(hd);
            }
            ViewBag.hoadon = ListHD;
            return View();
        }
        public IActionResult XemChiTietHoaDon(int id){
            var dbContext = new shopContext();
            var cthd =(from ct in dbContext.Chitiethoadon
                        join sp in dbContext.Sanpham
                        on ct.SanPhamId equals sp.SanPhamId
                        join kt in dbContext.Kichthuoc
                        on ct.KichThuocId equals kt.KichThuocid
                        join ha in dbContext.Hinhanh
                        on sp.HinhAnhId equals ha.HinhAnhId
                        where ct.HoaDonId == id
                        select new{
                            tensp = sp.TenSanPham,
                            soluong = ct.SoLuong,
                            Tenkichthuoc = kt.TenKichThuoc,
                            giatien = ct.TongTien,
                            tienkm = ct.TienKhuyenMai,
                            tiensaukm = ct.TongSauKm,
                            hinhanh = ha.TenFile
                        });
            List<Chitiethoadon> dsChiTiet = new List<Chitiethoadon>();
            foreach (var item in cthd)
            {
                Chitiethoadon ct = new Chitiethoadon();
                Hinhanh ha = new Hinhanh();
                Sanpham sp = new Sanpham();
                Kichthuoc kt = new Kichthuoc();
                sp.TenSanPham = item.tensp;
                ct.SoLuong = item.soluong;
                kt.TenKichThuoc = item.Tenkichthuoc;
                ct.TongTien = item.giatien;
                ct.TienKhuyenMai = item.tienkm;
                ct.TongSauKm = item.tiensaukm;
                ha.TenFile = item.hinhanh;
                sp.HinhAnh = ha;
                ct.SanPham = sp;
                ct.KichThuoc = kt;
                dsChiTiet.Add(ct);
            }
            ViewBag.chitiet = dsChiTiet;
            return View();
        }
        public IActionResult XemDanhSachHoaDonChuaXuLy(){
            var dbContext = new shopContext();
            // lấy thông tin trong bảng hóa đơn
            var hoadon = (from hd in dbContext.Hoadon
                            join ps in dbContext.Phiship
                            on hd.PhiShipId equals ps.PhiShipId
                            join kh in dbContext.Khachhang
                            on hd.KhachHangId equals kh.KhachHangId
                            join nv in dbContext.Nhanvien
                            on hd.NhanVienId equals nv.NhanVienId into x
                            from subnv in x.DefaultIfEmpty()
                            where hd.TrangThai=="Chờ xử lý"
                            select new{
                                hoadonid = hd.HoaDonId,
                                ngaytao = hd.NgayTao,
                                ngaygiao = hd.NgayGiao,
                                sonha = hd.SoNha,
                                quan = hd.Quan,
                                phiship = ps.ChiPhi,
                                thanhtoan = hd.TongTienThanhToan,
                                trangthai = hd.TrangThai,
                                nhanvien = subnv.HoTen,
                                khachhang = kh.HoTen,
                                tennguoinhan = hd.TenNguoiNhan,
                                sdt = hd.Sdt,
                                tienchuaship = hd.TongTienChuaShip,
                                tiengiamgia = hd.TienGiamGia
                            });
            List<Hoadon> ListHD = new List<Hoadon>();
            foreach (var item in hoadon)
            {
                Hoadon hd = new Hoadon ();
                Nhanvien nv = new Nhanvien();
                Khachhang kh = new Khachhang();
                Phiship ps = new Phiship();
                hd.HoaDonId= item.hoadonid;
                hd.NgayTao = item.ngaygiao;
                hd.NgayGiao = item.ngaygiao;
                hd.SoNha = item.sonha;
                hd.Quan = item.quan;
                ps.ChiPhi = item.phiship;
                hd.TongTienThanhToan = item.thanhtoan;
                hd.TrangThai = item.trangthai;
                nv.HoTen = item.nhanvien;
                kh.HoTen = item.khachhang;
                hd.TenNguoiNhan =item.tennguoinhan;
                hd.Sdt = item.sdt;
                hd.TongTienChuaShip = item.tienchuaship;
                hd.TienGiamGia = item.tiengiamgia;
                hd.NhanVien = nv;
                hd.KhachHang= kh;
                hd.PhiShip = ps;
                ListHD.Add(hd);
            }
            ViewBag.dsChuaXuLy = ListHD;
            return View();
        }

        public void XacNhanHoaDon(int key){
            var dbContext = new shopContext();
            string username=HttpContext.Session.GetString("username");
            var taikhoan = (from tk in dbContext.Taikhoan
                            where tk.Username == username
                            select tk).ToList();
            var nhanvien = (from nv in dbContext.Nhanvien
                            where nv.TaiKhoanId == taikhoan[0].TaiKhoanId
                            select nv).ToList();
            var hoadon = dbContext.Hoadon.First(a=> a.HoaDonId==key);
            hoadon.NhanVienId = nhanvien[0].NhanVienId;
            hoadon.TrangThai="Đang giao hàng";
            dbContext.SaveChanges();
        }
    }
}