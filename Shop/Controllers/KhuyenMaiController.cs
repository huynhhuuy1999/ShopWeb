using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Text;

namespace Shop.Controllers
{
    public class KhuyenMaiController : Controller{
         public IActionResult XemDanhSachKhuyenMai(){
            var dbContext = new shopContext();
            var khuyenmai = (from km in dbContext.Khuyenmai
                                select new{
                                    khuyenmaiId = km.KhuyenMaiId,
                                    Tenkhuyenmai = km.TenKhuyenMai,
                                    mota = km.MoTa,
                                    ngBD = km.NgayBatDau,
                                    ngKT = km.NgayKetThuc,
                                    PhanTramGiam = km.PhanTramGiam,
                                    TrangThai = km.TrangThai
                                });
            List<Khuyenmai> ListKM = new List<Khuyenmai>();
            foreach (var item in khuyenmai)
            {
                Khuyenmai km = new Khuyenmai();
                km.TenKhuyenMai = item.Tenkhuyenmai;
                km.KhuyenMaiId = item.khuyenmaiId;
                km.MoTa = item.mota;
                km.NgayBatDau= item.ngBD;
                km.NgayKetThuc = item.ngKT;
                km.TrangThai = item.TrangThai;
                km.PhanTramGiam = item.PhanTramGiam*100;
                ListKM.Add(km);
            }
            ViewBag.khuyenmai = ListKM;
            return View();
         }

         public IActionResult ThemKhuyenMai(string success){
            ViewBag.success = success;
            return View();
         }

         [HttpPost]
         public IActionResult ThemKhuyenMai(Khuyenmai model){
            var dbContext = new shopContext();
            double? changePhanTramGiam = (double) model.PhanTramGiam/100;
            if(ModelState.IsValid){
                var Khuyenmai = new Khuyenmai(){
                    TenKhuyenMai = model.TenKhuyenMai,
                    MoTa = model.MoTa,
                    NgayBatDau = model.NgayBatDau,
                    NgayKetThuc = model.NgayKetThuc,
                    PhanTramGiam = (float)changePhanTramGiam,
                    TrangThai = model.TrangThai
                };
                dbContext.Khuyenmai.Add(Khuyenmai);
                dbContext.SaveChanges();
            }
            return RedirectToAction("ThemKhuyenMai","Khuyenmai",new{success="Thêm thành công"});
         }
        
        public IActionResult SuaKhuyenMai(int id,string success,string err){
            var dbContext = new shopContext();
            if(ModelState.IsValid){
                var khuyenmai = (from km in dbContext.Khuyenmai
                                where km.KhuyenMaiId == id
                                select new{
                                    khuyenmaiid = km.KhuyenMaiId,
                                    tenKM = km.TenKhuyenMai,
                                    mota = km.MoTa,
                                    phantramgiam = km.PhanTramGiam,
                                    ngBD = km.NgayBatDau,
                                    ngKT = km.NgayKetThuc,
                                    trangThai = km.TrangThai
                                }).ToList();
                List<Khuyenmai> listKM = new List<Khuyenmai>();
                foreach (var item in khuyenmai)
                {
                    Khuyenmai km = new Khuyenmai();
                    km.KhuyenMaiId = item.khuyenmaiid;
                    km.TenKhuyenMai = item.tenKM;
                    km.MoTa = item.mota;
                    km.NgayBatDau = item.ngBD;
                    km.NgayKetThuc = item.ngKT;
                    km.PhanTramGiam = item.phantramgiam*100;
                    km.TrangThai = item.trangThai;
                    listKM.Add(km);
                }
                string ngBD = khuyenmai[0].ngBD.ToString("yyyy-MM-dd");
                string ngKT = khuyenmai[0].ngKT.ToString("yyyy-MM-dd");
                ViewBag.ngBD = ngBD;
                ViewBag.ngKT = ngKT;
                ViewBag.khuyenmai = listKM;
                ViewBag.success = success;
            }
            ViewBag.err= err;
            return View();
         }
        [HttpPost]
         public IActionResult SuaKhuyenMai(Khuyenmai model){
            var dbContext = new shopContext();
            double? changePhanTramGiam = (double) model.PhanTramGiam/100;
            if(ModelState.IsValid){
                var khuyenmai = dbContext.Khuyenmai.First(a => a.KhuyenMaiId == model.KhuyenMaiId);
                khuyenmai.TenKhuyenMai = model.TenKhuyenMai;
                khuyenmai.MoTa = model.MoTa;
                khuyenmai.PhanTramGiam = (float?)changePhanTramGiam;
                khuyenmai.NgayBatDau = model.NgayBatDau;
                khuyenmai.NgayKetThuc = model.NgayKetThuc;
                khuyenmai.TrangThai = model.TrangThai;
                dbContext.SaveChanges();
                return RedirectToAction("SuaKhuyenMai","Khuyenmai",new{id=model.KhuyenMaiId,success="Cập nhật khuyến mãi thành công"});
            }
            return RedirectToAction("SuaKhuyenMai","Khuyenmai",new{id=model.KhuyenMaiId,err="Cập nhật khuyến mãi không thành công"});
         }
    }
}