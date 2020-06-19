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
            // lay danh sach phan hoi
            var phanhoi = (from ph in dbContext.Phanhoi
                            where ph.BinhLuanId == id
                            select ph).ToList();
            // xoa phan hoi
            for(int i =0 ;i<phanhoi.Count;i++){
                var removePhanHoi = dbContext.Phanhoi.First(a => a.PhanHoiId == phanhoi[i].PhanHoiId);
                dbContext.Phanhoi.Remove(removePhanHoi);
                dbContext.SaveChanges();
            }
            // xóa bình luận
            var removeBinhLuan = dbContext.Binhluan.First(a => a.BinhLuanId == id);
            dbContext.Binhluan.Remove(removeBinhLuan);
            dbContext.SaveChanges();
            return RedirectToAction("chitietsanpham","sanpham",new{id = binhluan[0].SanPhamId});
        }

        public List<Phanhoi> ThemPhanHoi(int BinhLuanId,string NoiDung){
            var dbContext = new shopContext();
            var userName = HttpContext.Session.GetString("username");
            var taiKhoan = (from tk in dbContext.Taikhoan where tk.Username == userName select tk).ToList();
            var phanHoi = new Phanhoi(){
                BinhLuanId = BinhLuanId,
                TaiKhoanId = taiKhoan[0].TaiKhoanId,
                NoiDung = NoiDung
            };
            dbContext.Phanhoi.Add(phanHoi);
            dbContext.SaveChanges();
            var DSPhanHoi = (from ph in dbContext.Phanhoi
                                join tk in dbContext.Taikhoan
                                on ph.TaiKhoanId equals tk.TaiKhoanId
                                where ph.BinhLuanId == BinhLuanId
                                orderby ph.PhanHoiId descending
                                select new {
                                    NoiDung = ph.NoiDung,
                                    userName = tk.Username
                                }).ToList();
            List<Phanhoi> ListPhanHoi = new List<Phanhoi>();
            foreach (var item in DSPhanHoi)
            {
                Phanhoi ph = new Phanhoi();
                ph.BinhLuanId = BinhLuanId;
                ph.NoiDung = item.NoiDung;
                Taikhoan tk = new Taikhoan();
                tk.Username = item.userName;
                ph.TaiKhoan = tk;
                ListPhanHoi.Add(ph);
            }
            dbContext.SaveChanges();
            return ListPhanHoi;
        }
        public IActionResult XoaPhanHoi(int id){
            var dbContext = new shopContext();
            // lay danh sach phan hoi
            var phanhoi = (from ph in dbContext.Phanhoi
                            join bl in dbContext.Binhluan
                            on ph.BinhLuanId equals bl.BinhLuanId
                            where ph.PhanHoiId == id
                            select new{
                                phanHoiId = ph.PhanHoiId,
                                sanphamId = bl.SanPhamId
                            }).ToList();
            // xoa phan hoi
            var removePhanHoi = dbContext.Phanhoi.First(a => a.PhanHoiId == phanhoi[0].phanHoiId);
            dbContext.Phanhoi.Remove(removePhanHoi);
            dbContext.SaveChanges();
            return RedirectToAction("chitietsanpham","sanpham",new{id = phanhoi[0].sanphamId});
        }
    }
}