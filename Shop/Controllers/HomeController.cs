using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var dbContext=new shopContext();
            var SanPhamm= (from sp in dbContext.Sanpham
                            join h in dbContext.Hinhanh
                            on sp.HinhAnhId equals h.HinhAnhId
                            where sp.TrangThai == 1
                            select new{
                                SanPhamId= sp.SanPhamId,
                                TenSanPham = sp.TenSanPham,
                                Mota = sp.Mota,
                                GiaBanLe = sp.GiaBanLe,
                                Hinhanh= h.TenFile,
                                Kho = sp.Kho
                            });
            
            List<Sanpham> List = new List<Sanpham>();
            foreach(var sp in SanPhamm){
                Sanpham s= new Sanpham();
                Hinhanh h = new Hinhanh();
                s.SanPhamId= sp.SanPhamId;
                s.TenSanPham=sp.TenSanPham;
                s.Mota=sp.Mota;
                s.GiaBanLe=sp.GiaBanLe;
                s.Kho=sp.Kho;
                h.TenFile=sp.Hinhanh;
                s.HinhAnh=h;
                List.Add(s);
            }
            ViewData["x"]=List;
            return View();
        }
    }
}
