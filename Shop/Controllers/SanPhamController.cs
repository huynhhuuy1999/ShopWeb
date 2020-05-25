using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace Shop.Controllers
{
    // [Route("SanPham")]
    public class SanPhamController : Controller
    {

        // [Route("{id}",Name="chitiet")]
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public IActionResult ChiTietSanPham(int id)
        {
            var dbContext = new shopContext();
            var SanPham = (from sp in dbContext.Sanpham
                           join h in dbContext.Hinhanh
                           on sp.HinhAnhId equals h.HinhAnhId
                           where sp.SanPhamId == id
                           select new
                           {
                               SanPhamId = sp.SanPhamId,
                               TenSanPham = sp.TenSanPham,
                               Mota = sp.Mota,
                               GiaBanLe = sp.GiaBanLe,
                               TenFile = h.TenFile
                           });

            List<Sanpham> List = new List<Sanpham>();
            foreach (var sp in SanPham)
            {
                Sanpham sanPham = new Sanpham();
                Hinhanh h = new Hinhanh();
                sanPham.SanPhamId = sp.SanPhamId;
                sanPham.TenSanPham = sp.TenSanPham;
                sanPham.Mota = sp.Mota;
                sanPham.GiaBanLe = sp.GiaBanLe;
                h.TenFile = sp.TenFile;
                sanPham.HinhAnh = h;
                List.Add(sanPham);
            }
            ViewData["sanpham"] = List;
            return View();
        }

        public IActionResult ThucDon()
        {
            var dbContext = new shopContext();
            var PhanLoai = (from pl in dbContext.Phanloai
                            orderby pl.PhanLoaiId
                            select pl);

            List<Sanpham> List = new List<Sanpham>();
            var ListSP = (from sp in dbContext.Sanpham
                          join h in dbContext.Hinhanh
                          on sp.HinhAnhId equals h.HinhAnhId
                          join km in dbContext.Khuyenmai
                            on sp.KhuyenMaiId equals km.KhuyenMaiId into x
                            from subkm in x.DefaultIfEmpty()
                        where sp.TrangThai ==1
                          select new
                          {
                              PhanLoaiId = sp.PhanLoaiId,
                              SanPhamId = sp.SanPhamId,
                              TenSanPham = sp.TenSanPham,
                              GiaBanLe = sp.GiaBanLe,
                              HinhAnh = h.TenFile,
                              KhuyenMaiId = sp.KhuyenMaiId,
                                PhanTramGiam = subkm.PhanTramGiam
                          });
            foreach (var item in ListSP)
            {
                var sp = new Sanpham();
                var h = new Hinhanh();
                var k = new Khuyenmai();
                sp.PhanLoaiId = item.PhanLoaiId;
                sp.SanPhamId = item.SanPhamId;
                sp.TenSanPham = item.TenSanPham;
                sp.GiaBanLe = item.GiaBanLe;
                h.TenFile = item.HinhAnh;
                sp.KhuyenMaiId=item.KhuyenMaiId;
                 k.PhanTramGiam= item.PhanTramGiam*100;
                 sp.KhuyenMai=k;
                 sp.GiaGoc = item.GiaBanLe-item.GiaBanLe*item.PhanTramGiam;
                sp.HinhAnh = h;
                List.Add(sp);
            }
            ViewData["listSP"] = List;
            return View(PhanLoai);
        }

        public IActionResult DatHang(int id)
        {
            var dbContext = new shopContext();
            var sanpham = (from sp in dbContext.Sanpham
                           where sp.SanPhamId == id
                           select sp).ToList();
            var ListSP = (from sp in dbContext.Sanpham
                          join h in dbContext.Hinhanh
                          on sp.HinhAnhId equals h.HinhAnhId
                          join km in dbContext.Khuyenmai
                            on sp.KhuyenMaiId equals km.KhuyenMaiId into x
                            from subkm in x.DefaultIfEmpty()
                          select new
                          {
                              PhanLoaiId = sp.PhanLoaiId,
                              SanPhamId = sp.SanPhamId,
                              TenSanPham = sp.TenSanPham,
                              GiaBanLe = sp.GiaBanLe,
                              HinhAnh = h.TenFile,
                              
                              PhanTramGiam = subkm.PhanTramGiam,
                              KhuyenmaiId = sp.KhuyenMaiId
                          });
            List<Sanpham> List = new List<Sanpham>();
            foreach (var item in ListSP)
            {
                var sp = new Sanpham();
                var h = new Hinhanh();
                var k = new Khuyenmai();
                float? giaSauGiam = item.GiaBanLe-item.GiaBanLe*item.PhanTramGiam;
                sp.PhanLoaiId = item.PhanLoaiId;
                sp.SanPhamId = item.SanPhamId;
                sp.TenSanPham = item.TenSanPham;
                sp.GiaBanLe = item.GiaBanLe;
                h.TenFile = item.HinhAnh;
                k.PhanTramGiam = item.PhanTramGiam*100;
                sp.KhuyenMaiId = item.KhuyenmaiId;
                sp.GiaGoc = giaSauGiam;
                sp.HinhAnh = h;
                sp.KhuyenMai=k;
                List.Add(sp);
            }
            ViewData["listSP"] = List;

            var PhanLoai = (from pl in dbContext.Phanloai
                            orderby pl.PhanLoaiId
                            select pl);
            List<Phanloai> ListPL = new List<Phanloai>();
            foreach (var item in PhanLoai)
            {
                Phanloai phanloai = new Phanloai();
                phanloai.PhanLoaiId = item.PhanLoaiId;
                phanloai.TenLoai = item.TenLoai;
                ListPL.Add(phanloai);
            }
            ViewData["listPL"] = ListPL;
            //lay ma khuyen mai cua san pham
            float? phantramKM = 0;
            if (sanpham[0].KhuyenMaiId != null)
            {
                var km = (from khuyenmai in dbContext.Khuyenmai
                          where khuyenmai.KhuyenMaiId == sanpham[0].KhuyenMaiId
                          select khuyenmai).ToList();
                phantramKM = km[0].PhanTramGiam;
            }

            // if(sanpham[0].KhuyenMai.PhanTramGiam == null){phantramKM=0;}
            // else{phantramKM = (int)sanpham[0].KhuyenMai.PhanTramGiam;}

            // lay phan tram khuyen mai

            //lưu thông tin sản phẩm mới click vào giỏ hàng
            string idSession = HttpContext.Session.GetString("idSession");

            var spham = (from spp in dbContext.Kichthuoc
                         where spp.SanPhamId == id
                         select spp).ToList();
            var giohang = (from x in dbContext.Cart
                           where x.SanPhamId == id && x.IdSession == idSession
                           select x).ToList();
            if (giohang.Count == 0)
            {
                int maKichThuoc = 0;
                foreach (var item in spham)
                {
                    if (item.TenKichThuoc == "Nhỏ")
                    {
                        maKichThuoc = item.KichThuocid;
                    }
                }
                var Cart = new Cart()
                {
                    IdSession = idSession,
                    SanPhamId = id,
                    KichthuocId = maKichThuoc,
                    Soluong = 1,
                    Tongtien = sanpham[0].GiaBanLe * 1 - sanpham[0].GiaBanLe * phantramKM
                };
                dbContext.Cart.Add(Cart);
                dbContext.SaveChanges();
            }
            //hiển thị giỏ hàng
            var gh = (from sp in dbContext.Sanpham
                      join c in dbContext.Cart
                      on sp.SanPhamId equals c.SanPhamId
                      join kt in dbContext.Kichthuoc
                      on c.KichthuocId equals kt.KichThuocid
                      where c.IdSession == idSession
                      select new
                      {
                          masp = sp.SanPhamId,
                          tensp = sp.TenSanPham,
                          GiaBanLe = sp.GiaBanLe,
                          kichThuocId = kt.KichThuocid,
                          TenKichThuoc = kt.TenKichThuoc,
                          GiaThem = kt.GiaThem,
                          soluong = c.Soluong,
                          tongtien = c.Tongtien
                      });
            List<Cart> cart = new List<Cart>();
            float? tongtien = 0;// bién lấy giá trị tổng tiền của giỏ hàng
            foreach (var item in gh)
            {
                Kichthuoc kt = new Kichthuoc();
                Sanpham sp = new Sanpham();
                Cart c = new Cart();
                kt.KichThuocid = item.kichThuocId;
                kt.TenKichThuoc = item.TenKichThuoc;
                kt.GiaThem = item.GiaThem;
                sp.SanPhamId = item.masp;
                sp.TenSanPham = item.tensp;
                sp.GiaBanLe = item.GiaBanLe;
                c.Soluong = item.soluong;
                c.SanPham = sp;
                // c.Tongtien = item.GiaBanLe * item.soluong + item.soluong * item.GiaThem;
                c.Tongtien = item.tongtien;
                c.Kichthuoc = kt;
                tongtien = tongtien + c.Tongtien;
                cart.Add(c);
            }
            ViewBag.listCart = cart;
            ViewBag.tongtien = tongtien;
            return View(sanpham);
        }
        public List<Sanpham> ThemGioHang(int maspp)
        {
            var dbContext = new shopContext();
            var sanpham = (from sp in dbContext.Sanpham
                           join h in dbContext.Hinhanh
                           on sp.HinhAnhId equals h.HinhAnhId
                           where sp.SanPhamId == maspp
                           select new
                           {
                               SanPhamId = sp.SanPhamId,
                               TenSp = sp.TenSanPham,
                               HinhAnh = h.TenFile,
                               GiaBanLe = sp.GiaBanLe,
                           });
            List<Sanpham> ListSP = new List<Sanpham>();
            foreach (var item in sanpham)
            {
                Sanpham sp = new Sanpham();
                sp.SanPhamId = item.SanPhamId;
                sp.TenSanPham = item.TenSp;
                sp.GiaBanLe = item.GiaBanLe;
                Hinhanh h = new Hinhanh();
                h.TenFile = item.HinhAnh;
                sp.HinhAnh = h;
                ListSP.Add(sp);
            }
            return ListSP;
        }
        public List<Kichthuoc> LayKichThuoc(int maspp)
        {
            var dbContext = new shopContext();
            var kichthuoc = (from kt in dbContext.Kichthuoc
                             join sp in dbContext.Sanpham
                             on kt.SanPhamId equals sp.SanPhamId
                             where kt.SanPhamId == maspp
                             select new
                             {
                                 SanPhamId = sp.SanPhamId,
                                 TenSanPham = sp.TenSanPham,
                                 KichThuocId = kt.KichThuocid,
                                 TenKichThuoc = kt.TenKichThuoc,
                                 GiaBanLe = sp.GiaBanLe,
                                 GiaThem = kt.GiaThem,
                             });
            List<Kichthuoc> ListKT = new List<Kichthuoc>();
            foreach (var item in kichthuoc)
            {
                Sanpham sp = new Sanpham();
                sp.SanPhamId = item.SanPhamId;
                sp.GiaBanLe = item.GiaBanLe;
                sp.TenSanPham = item.TenSanPham;
                Kichthuoc kt = new Kichthuoc();
                kt.TenKichThuoc = item.TenKichThuoc;
                kt.KichThuocid = item.KichThuocId;
                kt.GiaThem = item.GiaThem;
                kt.SanPham = sp;
                ListKT.Add(kt);
            }

            return ListKT;
        }
        public List<Sanpham> TimKiemSanPham(string key)
        {
            List<Sanpham> List = new List<Sanpham>();
            var dbContext = new shopContext();
            if (key == "xxx")
            {
                var sanpham = (from sp in dbContext.Sanpham
                               join h in dbContext.Hinhanh
                               on sp.HinhAnhId equals h.HinhAnhId
                               select new
                               {
                                   SanPhamId = sp.SanPhamId,
                                   TenSanPham = sp.TenSanPham,
                                   GiaBanLe = sp.GiaBanLe,
                                   HinhAnh = h.TenFile,
                                   PhanLoaiId = sp.PhanLoaiId
                               });
                foreach (var item in sanpham)
                {
                    Sanpham sp = new Sanpham();
                    sp.SanPhamId = item.SanPhamId;
                    sp.TenSanPham = item.TenSanPham;
                    sp.GiaBanLe = item.GiaBanLe;
                    sp.PhanLoaiId = item.PhanLoaiId;
                    Hinhanh h = new Hinhanh();
                    h.TenFile = item.HinhAnh;
                    sp.HinhAnh = h;
                    List.Add(sp);
                }
            }
            else
            {
                var sanpham = (from sp in dbContext.Sanpham
                               join h in dbContext.Hinhanh
                               on sp.HinhAnhId equals h.HinhAnhId
                               where sp.TenSanPham.StartsWith(key)
                               select new
                               {
                                   SanPhamId = sp.SanPhamId,
                                   TenSanPham = sp.TenSanPham,
                                   GiaBanLe = sp.GiaBanLe,
                                   HinhAnh = h.TenFile,
                                   PhanLoaiId = sp.PhanLoaiId
                               });
                foreach (var item in sanpham)
                {
                    Sanpham sp = new Sanpham();
                    sp.SanPhamId = item.SanPhamId;
                    sp.TenSanPham = item.TenSanPham;
                    sp.GiaBanLe = item.GiaBanLe;
                    sp.PhanLoaiId = item.PhanLoaiId;
                    Hinhanh h = new Hinhanh();
                    h.TenFile = item.HinhAnh;
                    sp.HinhAnh = h;
                    List.Add(sp);
                }
            }
            return List;
        }

        public List<Cart> LuuGioHang(int maspp, int soluong, int kichthuocId)
        {
            var dbContext = new shopContext();
            string idSession = HttpContext.Session.GetString("idSession");
            var sanPham = (from sp in dbContext.Sanpham
                           where sp.SanPhamId == maspp
                           select sp).ToList();
            var giohang = (from sp in dbContext.Cart
                           where sp.IdSession == idSession && sp.SanPhamId == maspp
                           select sp).ToList();
            if (soluong == 0)
            {
                foreach (var item in giohang)
                {
                    var cart = dbContext.Cart.First(a => a.CartId == item.CartId);
                    dbContext.Cart.Remove(cart);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                // lay gia them khi thay doi kich thuoc
                var kichthuoc = (from kt in dbContext.Kichthuoc where kt.KichThuocid == kichthuocId select kt).ToList();
                //neu gio hang chua co san pham nay
                if (giohang.Count == 0)
                {
                    float? phanTramGiam = 0;
                    if (sanPham[0].KhuyenMaiId != null)
                    {
                        var km = (from x in dbContext.Khuyenmai
                                    where x.KhuyenMaiId == sanPham[0].KhuyenMaiId
                                    select x).ToList();
                        phanTramGiam = km[0].PhanTramGiam;
                        // phanTramGiam = sanPham[0].KhuyenMai.PhanTramGiam;
                    }
                    var Cart = new Cart()
                    {
                        IdSession = idSession,
                        SanPhamId = maspp,
                        KichthuocId = kichthuocId,
                        Soluong = soluong,
                        Tongtien = sanPham[0].GiaBanLe * soluong - soluong * phanTramGiam * sanPham[0].GiaBanLe + soluong * kichthuoc[0].GiaThem
                    };
                    dbContext.Cart.Add(Cart);
                    dbContext.SaveChanges();
                }
                // neu gio hang da ton tai san pham nay
                else
                {
                    foreach (var item in giohang)
                    {
                        var cart = dbContext.Cart.First(a => a.CartId == item.CartId);
                        float? phanTramGiam = 0;
                        if (sanPham[0].KhuyenMaiId != null)
                        {
                            // phanTramGiam = sanPham[0].KhuyenMai.PhanTramGiam;
                            var km = (from x in dbContext.Khuyenmai
                                        where x.KhuyenMaiId == sanPham[0].KhuyenMaiId
                                        select x).ToList();
                            phanTramGiam = km[0].PhanTramGiam;
                        }
                        cart.KichthuocId = kichthuocId;
                        cart.Soluong = soluong;
                        cart.Tongtien = soluong * sanPham[0].GiaBanLe - soluong * phanTramGiam * sanPham[0].GiaBanLe + soluong * kichthuoc[0].GiaThem;
                        dbContext.SaveChanges();
                    }
                }
            }
            var gh = (from sp in dbContext.Sanpham
                      join c in dbContext.Cart
                      on sp.SanPhamId equals c.SanPhamId
                      join kt in dbContext.Kichthuoc
                      on c.KichthuocId equals kt.KichThuocid
                      where c.IdSession == idSession
                      select new
                      {
                          masp = sp.SanPhamId,
                          tensp = sp.TenSanPham,
                          GiaBanLe = sp.GiaBanLe,
                          kichThuocId = kt.KichThuocid,
                          TenKichThuoc = kt.TenKichThuoc,
                          GiaThem = kt.GiaThem,
                          soluong = c.Soluong,
                          tongtien = c.Tongtien
                      });
            List<Cart> Listcart = new List<Cart>();
            float? tongtien = 0;// bién lấy giá trị tổng tiền của giỏ hàng
            foreach (var item in gh)
            {
                Kichthuoc kt = new Kichthuoc();
                Sanpham sp = new Sanpham();
                Cart c = new Cart();
                kt.KichThuocid = item.kichThuocId;
                kt.TenKichThuoc = item.TenKichThuoc;
                kt.GiaThem = item.GiaThem;
                sp.TenSanPham = item.tensp;
                sp.GiaBanLe = item.GiaBanLe;
                sp.SanPhamId = item.masp;
                c.Soluong = item.soluong;
                c.SanPham = sp;
                // c.Tongtien = item.GiaBanLe * item.soluong + item.soluong * item.GiaThem;
                c.Tongtien = item.tongtien;
                c.Kichthuoc = kt;
                tongtien = tongtien + c.Tongtien;
                Listcart.Add(c);
            }

            return Listcart;
        }

        public IActionResult XacNhanDatHang()
        {
            var dbContext = new shopContext();
            if (HttpContext.Session.GetString("username") == null)
            {
                ViewBag.error = "Bạn chưa đăng nhập";
            }
            else
            {

                string ss = HttpContext.Session.GetString("username");
                var user = (from tk in dbContext.Taikhoan
                            join kh in dbContext.Khachhang
                            on tk.TaiKhoanId equals kh.TaiKhoanId
                            select kh).ToList();
                ViewBag.ten = user[0].HoTen;
                ViewBag.sdt = user[0].Sdt;
            }



            string idSession = HttpContext.Session.GetString("idSession");
            var sanpham = (from sp in dbContext.Sanpham
                           join c in dbContext.Cart
                           on sp.SanPhamId equals c.SanPhamId
                           join kt in dbContext.Kichthuoc
                           on c.KichthuocId equals kt.KichThuocid
                           where c.IdSession == idSession
                           select new
                           {
                               masp = sp.SanPhamId,
                               tensp = sp.TenSanPham,
                               GiaBanLe = sp.GiaBanLe,
                               kichThuocId = kt.KichThuocid,
                               TenKichThuoc = kt.TenKichThuoc,
                               GiaThem = kt.GiaThem,
                               soluong = c.Soluong,
                               tongtien = c.Tongtien
                           }).ToList();
            //kiem tra gio hang co san pham hay khong
            if (sanpham.Count == 0)
            {
                ViewBag.errorCart = "Giỏ hàng của bạn chưa có sản phẩm";
            }

            List<Cart> cart = new List<Cart>();
            float? tongtien = 0;// bién lấy giá trị tổng tiền của giỏ hàng
            foreach (var item in sanpham)
            {
                Kichthuoc kt = new Kichthuoc();
                Sanpham sp = new Sanpham();
                Cart c = new Cart();
                kt.KichThuocid = item.kichThuocId;
                kt.TenKichThuoc = item.TenKichThuoc;
                kt.GiaThem = item.GiaThem;
                sp.TenSanPham = item.tensp;
                sp.GiaBanLe = item.GiaBanLe;
                c.Soluong = item.soluong;
                c.SanPham = sp;
                // c.Tongtien = item.GiaBanLe * item.soluong + item.soluong * item.GiaThem;
                c.Tongtien = item.tongtien;
                c.Kichthuoc = kt;
                tongtien = tongtien + c.Tongtien;
                cart.Add(c);
            }
            ViewBag.listCart = cart;
            ViewBag.tongtien = tongtien;
            return View();
        }

        [HttpPost]
        public IActionResult XacNhanDatHang(Hoadon model, string GiamGia)
        {
            var dbContext = new shopContext();
            var sessionId = HttpContext.Session.GetString("idSession");
            var cart = (from c in dbContext.Cart
                        where c.IdSession == sessionId
                        select c).ToList();
            if (HttpContext.Session.GetString("username") == null || cart.Count == 0)
            {
                return RedirectToAction("XacNhanDatHang", "sanpham");
            }
            else
            {
                //lay khachhangid
                var username = HttpContext.Session.GetString("username");
                var TKId = (from tk in dbContext.Taikhoan
                            join kh in dbContext.Khachhang
                            on tk.TaiKhoanId equals kh.KhachHangId
                            where tk.Username == username
                            select kh).ToList();
                int khId = TKId[0].KhachHangId;
                //lay ngay tao
                DateTime ngayTao = DateTime.Now;
                //lay quan 
                var quan = (from q in dbContext.Phiship
                            where q.PhiShipId == model.PhiShipId
                            select q).ToList();
                var TenQuan = quan[0].Quan;
                // lay tien ship
                var tienShip = quan[0].ChiPhi;
                //lay tong tien chua ship
                // var cart = (from c in dbContext.Cart
                //             where c.IdSession == sessionId
                //             select c).ToList();
                float? tongTienChuaShip = 0;
                foreach (var item in cart)
                {
                    tongTienChuaShip = tongTienChuaShip + item.Tongtien;
                }
                //lay tien giam gia
                float? TienGiamGia = 0;

                if (GiamGia != null)
                {
                    var magiamgia = (from gg in dbContext.Magiamgia
                                     where gg.MaGiamGia1 == GiamGia
                                     select gg).ToList();
                    if (magiamgia.Count == 0)
                    {
                        TienGiamGia = 0;
                    }
                    else
                    {
                        TienGiamGia = tongTienChuaShip * magiamgia[0].PhanTram;
                        //xóa mã giảm giá khi đã được sử dụng
                        var discount = dbContext.Magiamgia.First(a => a.MaGiamGiaId == magiamgia[0].MaGiamGiaId);
                        dbContext.Magiamgia.Remove(discount);
                        dbContext.SaveChanges();
                    }
                }
                //lay tong tien thanh toan
                float? TongTienThanhToan = tongTienChuaShip - TienGiamGia + tienShip;
                //insert hoa don
                var HoaDon = new Hoadon()
                {
                    NgayTao = ngayTao,
                    SoNha = model.SoNha,
                    Quan = TenQuan,
                    PhiShipId = model.PhiShipId,
                    TongTienThanhToan = TongTienThanhToan,
                    TrangThai = "Chờ xử lý",
                    KhachHangId = khId,
                    TenNguoiNhan = model.TenNguoiNhan,
                    Sdt = model.Sdt,
                    TongTienChuaShip = tongTienChuaShip,
                    TienGiamGia = TienGiamGia,
                    SessionId = sessionId
                };
                dbContext.Hoadon.Add(HoaDon);
                dbContext.SaveChanges();

                // lay mahoadon 
                var hd = (from h in dbContext.Hoadon
                          where h.SessionId == sessionId
                          select h).ToList();
                var hoadonId = hd[0].HoaDonId;
                //insert chitiethoadon
                foreach (var item in cart)
                {
                    //lay phan tram giam gia cua san pham
                    float? phanTramGiam = 0;
                    var sp = (from x in dbContext.Sanpham
                              where x.SanPhamId == item.SanPhamId
                              select x).ToList();
                    if (sp[0].KhuyenMaiId != null)
                    {
                        phanTramGiam = sp[0].KhuyenMai.PhanTramGiam;
                    }
                    // lay gia them cua moi kich thuoc san pham
                    var kt = (from k in dbContext.Kichthuoc
                              where k.KichThuocid == item.KichthuocId
                              select k).ToList();
                    float? GiaThem = kt[0].GiaThem;
                    var cthd = new Chitiethoadon()
                    {
                        HoaDonId = hoadonId,
                        SanPhamId = item.SanPhamId,
                        SoLuong = item.Soluong,
                        TienKhuyenMai = phanTramGiam * item.SanPham.GiaBanLe * item.Soluong,
                        TongTien = item.SanPham.GiaBanLe * item.Soluong + item.Soluong * GiaThem,
                        TongSauKm = item.Tongtien,
                        KichThuocId = item.KichthuocId
                    };
                    dbContext.Chitiethoadon.Add(cthd);
                    dbContext.SaveChanges();
                }
                // tạo mã giảm giá sau khi mua hàng
                string randomMaGiamGia = RandomString(6, true);
                var MaGiamGia = new Magiamgia()
                {
                    MaGiamGia1 = randomMaGiamGia,
                    PhanTram = (float?)0.05
                };
                dbContext.Magiamgia.Add(MaGiamGia);
                dbContext.SaveChanges();

                HttpContext.Session.Remove("idSession");
                HttpContext.Session.SetString("idSession", RandomString(9, true));
                // return RedirectToAction("DatHangThanhCong","sanpham");
                ViewBag.maGiamGia = randomMaGiamGia;
                return RedirectToAction("DatHangThanhCong", "sanpham", new { discountId = randomMaGiamGia });
            }
        }

        public float CapNhatTongTienHoaDon(float phiship, float tong)
        {
            var dbContext = new shopContext();
            var ps = (from x in dbContext.Phiship
                      where x.PhiShipId == phiship
                      select x).ToList();

            return (float)ps[0].ChiPhi;
        }

        public float? KiemTraMaGiamGia(string magiamgia)
        {
            var dbContext = new shopContext();
            string idSession = HttpContext.Session.GetString("idSession");
            var cart = (from c in dbContext.Cart
                        where c.IdSession == idSession
                        select c).ToList();
            float? tong = 0;
            foreach (var item in cart)
            {
                tong = tong + item.Tongtien;
            }
            var giamgia = (from gg in dbContext.Magiamgia
                           where gg.MaGiamGia1 == magiamgia
                           select gg).ToList();
            if (giamgia.Count > 0)
            {
                return giamgia[0].PhanTram * tong;
            }
            else
            {
                return 0;
            }
        }

        public IActionResult DatHangThanhCong(string discountId)
        {
            ViewBag.maGiamGia = discountId;
            return View();
        }

        public IActionResult XemDanhSachSanPham()
        {
            var dbContext = new shopContext();
            var sanpham = (from sp in dbContext.Sanpham
                           join pl in dbContext.Phanloai
                           on sp.PhanLoaiId equals pl.PhanLoaiId
                           join ha in dbContext.Hinhanh
                           on sp.HinhAnhId equals ha.HinhAnhId
                           join km in dbContext.Khuyenmai
                           on sp.KhuyenMaiId equals km.KhuyenMaiId into x
                           from subpet in x.DefaultIfEmpty()
                           select new
                           {
                               tensp = sp.TenSanPham,
                               mota = sp.Mota,
                               giabanle = sp.GiaBanLe,
                               trangThai = sp.TrangThai,
                               TenLoai = pl.TenLoai,
                               phantramgiam = subpet.PhanTramGiam,
                               hinhanh = ha.TenFile
                           });
            List<Sanpham> List = new List<Sanpham>();
            foreach (var item in sanpham)
            {
                Sanpham sp = new Sanpham();
                Hinhanh ha = new Hinhanh();
                Khuyenmai km = new Khuyenmai();
                Phanloai pl = new Phanloai();
                sp.TenSanPham = item.tensp;
                sp.Mota = item.mota;
                sp.GiaBanLe = item.giabanle;
                sp.TrangThai = item.trangThai;
                pl.TenLoai = item.TenLoai;
                km.PhanTramGiam = item.phantramgiam * 100;
                ha.TenFile = item.hinhanh;
                sp.PhanLoai = pl;
                sp.HinhAnh = ha;
                sp.KhuyenMai = km;
                List.Add(sp);
            }
            ViewBag.sanpham = List;

            return View();
        }
        public IActionResult ThemSanPham(string success,string error)
        {
            var dbContext = new shopContext();
            var khuyenmai = (from km in dbContext.Khuyenmai
                             where km.TrangThai == 1
                             select km).ToList();
            var phanloai = (from pl in dbContext.Phanloai
                            select pl).ToList();
            ViewBag.khuyenmai = khuyenmai;
            ViewBag.phanloai = phanloai;
            ViewBag.success = success;
            ViewBag.error = error;
            return View();
        }

        [HttpPost]
        public IActionResult ThemSanPham(Sanpham model, string TenAnh,string[] tenKichThuoc,float[] giaThem)
        {
            var dbContext = new shopContext();
            if (ModelState.IsValid)
            {
                
                // thêm ảnh vào table hinhanh
                var hinhanh = new Hinhanh(){
                    TenFile = TenAnh
                };
                dbContext.Hinhanh.Add(hinhanh);
                dbContext.SaveChanges();
                //lấy id của ảnh
                var anh = (from ha in dbContext.Hinhanh
                           where ha.TenFile == TenAnh
                           select ha).ToList();
                //thêm sản phẩm
                var sanpham = new Sanpham()
                {
                    TenSanPham = model.TenSanPham,
                    Mota = model.Mota,
                    GiaBanLe = model.GiaBanLe,
                    TrangThai = model.TrangThai,
                    PhanLoaiId = model.PhanLoaiId,
                    KhuyenMaiId = model.KhuyenMaiId,
                    HinhAnhId = anh[0].HinhAnhId
                };
                dbContext.Sanpham.Add(sanpham);
                dbContext.SaveChanges();
                //thêm kích thước vào bảng kichthuoc
                var x = (from sp in dbContext.Sanpham
                            where sp.TenSanPham==model.TenSanPham
                            select sp).ToList();
                for(int i=0;i<tenKichThuoc.Length;i++){
                    var kichthuoc = new Kichthuoc(){
                        SanPhamId = x[0].SanPhamId,
                        TenKichThuoc = tenKichThuoc[i],
                        GiaThem = giaThem[i]
                    };
                    dbContext.Kichthuoc.Add(kichthuoc);
                    dbContext.SaveChanges();
                }
                return RedirectToAction("Themsanpham", "sanpham", new { success = "Thêm sản phẩm thành công" });
            }
            return RedirectToAction("Themsanpham", "sanpham", new { error = "Thêm sản phẩm không thành công" });

        }
    }
}