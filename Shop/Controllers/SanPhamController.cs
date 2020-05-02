using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    // [Route("SanPham")]
    public class SanPhamController : Controller{

        // [Route("{id}",Name="chitiet")]
        public IActionResult ChiTietSanPham(int id){
            var dbContext=new shopContext();
            var SanPham= (from sp in dbContext.Sanpham
                            join h in dbContext.Hinhanh 
                            on sp.HinhAnhId equals h.HinhAnhId
                            where sp.SanPhamId==id
                            select new{
                                TenSanPham=sp.TenSanPham,
                                Mota = sp.Mota,
                                GiaBanLe= sp.GiaBanLe,
                                TenFile= h.TenFile
                            });
            
            List<Sanpham> List= new List<Sanpham>();
            foreach(var sp in SanPham){
                Sanpham sanPham= new Sanpham();
                Hinhanh h = new Hinhanh();
                sanPham.TenSanPham= sp.TenSanPham;
                sanPham.Mota= sp.Mota;
                sanPham.GiaBanLe= sp.GiaBanLe;
                h.TenFile=sp.TenFile;
                sanPham.HinhAnh=h;
                List.Add(sanPham);
            }
            ViewData["sanpham"]=List;
            return View();
        }

        public IActionResult ThucDon(){
            var dbContext= new shopContext();
            var PhanLoai = (from pl in dbContext.Phanloai
                                orderby pl.PhanLoaiId
                                select pl);
            
            List<Sanpham> List = new List<Sanpham>();
            var ListSP = (from sp in dbContext.Sanpham
                            join h in dbContext.Hinhanh
                            on sp.HinhAnhId equals h.HinhAnhId
                            select new{
                                PhanLoaiId = sp.PhanLoaiId,
                                SanPhamId = sp.SanPhamId,
                                TenSanPham= sp.TenSanPham,
                                GiaBanLe = sp.GiaBanLe,
                                HinhAnh = h.TenFile
                            });
            foreach(var item in ListSP){
                var sp = new Sanpham();
                var h = new Hinhanh();
                sp.PhanLoaiId=item.PhanLoaiId;
                sp.SanPhamId= item.SanPhamId;
                sp.TenSanPham= item.TenSanPham;
                sp.GiaBanLe= item.GiaBanLe;
                h.TenFile=item.HinhAnh;
                sp.HinhAnh=h;
                List.Add(sp);
            }
            ViewData["listSP"] = List;
            return View(PhanLoai);
        }
    }

}