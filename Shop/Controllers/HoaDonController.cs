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
                            orderby hd.HoaDonId descending
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
                hd.NgayTao = item.ngaytao;
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
                hd.NgayTao = item.ngaytao;
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
        public IActionResult ThongTinDonHangCuaKhachHang(string id){
            var dbContext = new shopContext();
            var hoadon = (from tk in dbContext.Taikhoan
                            join kh in dbContext.Khachhang
                            on tk.TaiKhoanId equals kh.TaiKhoanId
                            join hd in dbContext.Hoadon
                            on kh.KhachHangId equals hd.KhachHangId
                            where tk.Username == id
                            orderby hd.TrangThai ascending,hd.NgayTao descending
                            select new{
                                hdId = hd.HoaDonId,
                                tienGiamGia = hd.TienGiamGia,
                                ngayMua = hd.NgayTao,
                                tongntien = hd.TongTienThanhToan,
                                trangThai = hd.TrangThai
                            });
            List<Hoadon> DSHoaDon =  new List<Hoadon>();
            foreach (var item in hoadon)
            {
                Hoadon hd = new Hoadon();
                hd.HoaDonId = item.hdId;
                hd.TienGiamGia = item.tienGiamGia;
                hd.NgayTao = item.ngayMua;
                hd.TongTienThanhToan = item.tongntien;
                hd.TrangThai = item.trangThai;
                DSHoaDon.Add(hd);
            }
            ViewBag.hoadon = DSHoaDon;
            return View();
        }
        public IActionResult XemChiTietDonHang(int id){
            var dbContext = new shopContext();
            var hoadon =(from hd in dbContext.Hoadon
                        join ps in dbContext.Phiship
                        on hd.PhiShipId equals ps.PhiShipId
                        where hd.HoaDonId == id
                        select new{
                            id = hd.HoaDonId,
                            ngaytao = hd.NgayTao,
                            TenNguoiNhan = hd.TenNguoiNhan,
                            soNha = hd.SoNha,
                            sdt = hd.Sdt,
                            phiship = ps.ChiPhi,
                            tienkhuyenmai = hd.TienGiamGia,
                            TongTienChuaShip = hd.TongTienChuaShip,
                            tongcong = hd.TongTienThanhToan
                        });
            List<Hoadon> DSHoaDon = new List<Hoadon>();
            foreach (var item in hoadon)
            {
                Hoadon hd =new Hoadon();
                hd.HoaDonId = item.id;
                hd.NgayTao = item.ngaytao;
                hd.TenNguoiNhan = item.TenNguoiNhan;
                hd.SoNha = item.soNha;
                hd.Sdt = item.sdt;
                hd.TienGiamGia= item.tienkhuyenmai;
                hd.TongTienChuaShip = item.TongTienChuaShip;
                hd.TongTienThanhToan = item.tongcong;
                Phiship ps = new Phiship();
                ps.ChiPhi =  item.phiship;
                hd.PhiShip = ps;
                DSHoaDon.Add(hd);
            }
            ViewBag.hoadon = DSHoaDon;
            var chitiet = (from ct in dbContext.Chitiethoadon
                            join hd in dbContext.Hoadon
                            on ct.HoaDonId equals hd.HoaDonId
                            join sp in dbContext.Sanpham
                            on ct.SanPhamId equals sp.SanPhamId
                            join kt in dbContext.Kichthuoc
                            on ct.KichThuocId equals kt.KichThuocid
                            join ha in dbContext.Hinhanh
                            on sp.HinhAnhId equals ha.HinhAnhId
                            join km in dbContext.Khuyenmai
                            on sp.KhuyenMaiId equals km.KhuyenMaiId into x
                            from subnv in x.DefaultIfEmpty()
                            where hd.HoaDonId == id
                            select new{
                                tensp = sp.TenSanPham,
                                hinhanh = ha.TenFile,
                                gia = ct.TongTien,
                                soluong = ct.SoLuong,
                                giam = subnv.PhanTramGiam * sp.GiaBanLe,
                                tamtinh = ct.TongSauKm,
                                tenKichThuoc = kt.TenKichThuoc
                            });
            List<Chitiethoadon> DSChiTiet = new List<Chitiethoadon>();
            foreach (var item in chitiet)
            {
                Sanpham sp = new Sanpham();
                Chitiethoadon ct = new Chitiethoadon();
                Hinhanh ha = new Hinhanh();
                Kichthuoc kt = new Kichthuoc();
                sp.TenSanPham = item.tensp;
                ha.TenFile = item.hinhanh;
                ct.TongTien = item.gia;
                ct.SoLuong = item.soluong;
                ct.TienKhuyenMai = item.giam;
                ct.TongSauKm = item.tamtinh;
                kt.TenKichThuoc = item.tenKichThuoc;
                sp.HinhAnh=ha;
                ct.SanPham= sp;
                ct.KichThuoc = kt;
                DSChiTiet.Add(ct);
            }
            ViewBag.chitiet= DSChiTiet;
            return View();
        }
        public void YeuCauHuyDonHang(int mahd){
            var dbContext = new shopContext();
            var hoadon = dbContext.Hoadon.First(a => a.HoaDonId == mahd);
            hoadon.TrangThai = "Yêu cầu hủy";
            dbContext.SaveChanges();
            dbContext.Dispose();
        }

        public IActionResult XemDanhSachHoaDonYeuCauHuy(){
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
                            where hd.TrangThai=="Yêu cầu hủy"
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
                hd.NgayTao = item.ngaytao;
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
            ViewBag.dsYeuCauHuy = ListHD;
            return View();
        }

        public void XacNhanHuyDonHang(int mahd){
            var dbContext = new shopContext();
            var hoadon = (from hd in dbContext.Hoadon
                            where hd.HoaDonId == mahd
                            select hd).ToList();
            // lay sessionid cua hoadon
            var sessionId =  hoadon[0].SessionId;

            //lay chi tiet hoa don cua hoa don xac nhan huy
            var cthd =(from ct in dbContext.Chitiethoadon
                        where ct.HoaDonId == mahd
                        select ct).ToList();
            //xoa chi tiet hoa don
            foreach (var item in cthd)
            {
                var ct = dbContext.Chitiethoadon.First(a => a.ChiTietHoaDonId == item.ChiTietHoaDonId);
                dbContext.Chitiethoadon.Remove(ct);
                dbContext.SaveChanges();
            }
            //xoa hoa don
            var hdon = dbContext.Hoadon.First(a => a.HoaDonId == hoadon[0].HoaDonId);
            dbContext.Hoadon.Remove(hdon);
            dbContext.SaveChanges();
            //xoa cart co sessionId trong hoadon
            var cart = (from c in dbContext.Cart where c.IdSession == sessionId select c).ToList();
            var cart2 = dbContext.Cart.First(a => a.CartId == cart[0].CartId);
            dbContext.Cart.Remove(cart2);
            dbContext.SaveChanges();
            dbContext.Dispose();
        }

        public void XacNhanNhanHang(int mahd){
            var dbContext = new shopContext();
            var hoadon = dbContext.Hoadon.First(a=>a.HoaDonId == mahd);
            hoadon.TrangThai ="Đã nhận hàng";
            hoadon.NgayGiao=DateTime.Now;
            dbContext.SaveChanges();
            dbContext.Dispose();
        }
    }
}