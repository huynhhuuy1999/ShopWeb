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
    public class HomeController : Controller
    {
        // private readonly ISession session;
        // public HomeController(IHttpContextAccessor httpContextAccessor)
        // {
        //     this.session = httpContextAccessor.HttpContext.Session;
        // }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch ;
            for(int i=0; i<size; i++)
            {
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))) ;
            builder.Append(ch); 
            }
            if(lowerCase)
            return builder.ToString().ToLower();
            return builder.ToString();
        }
        public IActionResult Index()
        {   
            var dbContext = new shopContext();
            if(HttpContext.Session.GetString("idSession")==null){
                HttpContext.Session.SetString("idSession",RandomString(9,true));
            }
            var khuyenmai = (from km in dbContext.Khuyenmai select km).ToList();
            foreach (var item in khuyenmai)
            {
                if(item.NgayBatDau<=DateTime.Now&&item.NgayKetThuc>=DateTime.Now){
                    //update khuyến mãi kích hoạt đã đến ngày khuyến mãi
                    var km = dbContext.Khuyenmai.First(a=>a.KhuyenMaiId == item.KhuyenMaiId);
                    km.TrangThai=1;
                    dbContext.SaveChanges();
                    dbContext.Dispose();
                }
                else{
                    var km = dbContext.Khuyenmai.First(a=>a.KhuyenMaiId == item.KhuyenMaiId);
                    km.TrangThai=0;
                    dbContext.SaveChanges();
                    //lấy danh sách sản phẩm có khuyến mãi id = item.khuyenmaiId;
                    var sanpham = (from sp in dbContext.Sanpham
                                    where sp.KhuyenMaiId == item.KhuyenMaiId
                                    select sp).ToList();
                    //update sản phẩm đã hết hạn khuyến mãi
                    foreach (var sp in sanpham)
                    {
                        var ItemSanPham = dbContext.Sanpham.First(a => a.SanPhamId == sp.SanPhamId);
                        ItemSanPham.KhuyenMaiId = null;
                        dbContext.SaveChanges();
                        dbContext.Dispose();
                    }
                    // var sanpham = dbContext.Sanpham.First(a => a.KhuyenMaiId == item.KhuyenMaiId);
                    // sanpham.KhuyenMaiId = null;
                    // dbContext.SaveChanges();
                    // dbContext.Dispose();
                }
            }
            var SanPhamm= (from sp in dbContext.Sanpham
                            join h in dbContext.Hinhanh
                            on sp.HinhAnhId equals h.HinhAnhId
                            join km in dbContext.Khuyenmai
                            on sp.KhuyenMaiId equals km.KhuyenMaiId into x
                            from subkm in x.DefaultIfEmpty()
                            where sp.TrangThai == 1
                            select new{
                                SanPhamId= sp.SanPhamId,
                                TenSanPham = sp.TenSanPham,
                                Mota = sp.Mota,
                                GiaBanLe = sp.GiaBanLe,
                                Hinhanh= h.TenFile,
                                KhuyenMaiId = sp.KhuyenMaiId,
                                PhanTramGiam = subkm.PhanTramGiam
                            }).Take(7);
            
            List<Sanpham> List = new List<Sanpham>();
            foreach(var sp in SanPhamm){
                Sanpham s= new Sanpham();
                Hinhanh h = new Hinhanh();
                Khuyenmai k = new Khuyenmai();
                s.SanPhamId= sp.SanPhamId;
                s.TenSanPham=sp.TenSanPham;
                s.Mota=sp.Mota;
                s.GiaGoc = sp.GiaBanLe-sp.GiaBanLe*sp.PhanTramGiam;
                s.GiaBanLe=sp.GiaBanLe;
                s.KhuyenMaiId = sp.KhuyenMaiId;
                h.TenFile=sp.Hinhanh;
                //xử lý chuyển phần trăm giảm sang %
                
                k.PhanTramGiam= sp.PhanTramGiam*100;
                s.KhuyenMai = k;
                s.HinhAnh=h;
                List.Add(s);
            }
            ViewData["x"]=List;
            return View();
        }
    }
}
