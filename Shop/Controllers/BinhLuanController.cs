using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Microsoft.AspNetCore.Http;

namespace Shop.Controllers{
    public class BinhLuanController : Controller
    {
        [HttpPost]
        public IActionResult ThemBinhLuan(Binhluan model){
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("chitietsanpham","sanpham",new {id=model.SanPhamId});
            }
            else{
                if (ModelState.IsValid)
                {
                    var dbContext = new shopContext();
                    var userName = HttpContext.Session.GetString("username");
                    var taiKhoan = (from tk in dbContext.Taikhoan where tk.Username == userName select tk).ToList();
                    var binhLuan = new Binhluan(){
                        SanPhamId = model.SanPhamId,
                        TaiKhoanId = taiKhoan[0].TaiKhoanId,
                        NoiDung = model.NoiDung
                    };
                    dbContext.Binhluan.Add(binhLuan);
                    dbContext.SaveChanges();
                }
                return RedirectToAction("chitietsanpham","sanpham",new{id = model.SanPhamId});
            }
        }
        public IActionResult XoaBinhLuan(int id){
            var dbContext = new shopContext();
            // mục đích: lấy mã sản phẩm từ bình luận cần xóa
            var binhluan =( from bl in dbContext.Binhluan
                            where bl.BinhLuanId == id
                            select bl).ToList();
            // xóa bình luận
            var removeBinhLuan = dbContext.Binhluan.First(a => a.BinhLuanId == id);
            dbContext.Binhluan.Remove(removeBinhLuan);
            dbContext.SaveChanges();
            return RedirectToAction("chitietsanpham","sanpham",new{id = binhluan[0].SanPhamId});
        }
    }
}