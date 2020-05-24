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
            if(HttpContext.Session.GetString("idSession")==null){
                HttpContext.Session.SetString("idSession",RandomString(9,true));
            }
            var dbContext=new shopContext();
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
