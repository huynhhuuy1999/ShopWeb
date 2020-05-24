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
                                select km).ToList();
            ViewBag.khuyenmai = khuyenmai;
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
    }
}