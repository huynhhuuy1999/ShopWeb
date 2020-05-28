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

namespace Shop.Controllers{
    public class NhanVienController : Controller{
        public IActionResult XemDanhSachNhanVien(){
            var dbContext = new shopContext();
            var nhanvien = (from nv in dbContext.Nhanvien
                                select nv).ToList();
            ViewBag.nhanvien = nhanvien;
            return View();
        }
        public IActionResult ThemNhanVien(string success,string alert){
            ViewBag.success = success;
            ViewBag.alert = alert;
            return View();
        }
        
        [HttpPost]
        public IActionResult ThemNhanVien(Nhanvien model, string Username,string Password){
            var dbContext = new shopContext();
            var taikhoan1 = (from tk in dbContext.Taikhoan where tk.Username == Username select tk).ToList();
            if(taikhoan1.Count>0){
                ModelState.AddModelError("Username","Username da ton tai");
                ViewBag.errUsername = "Username da ton tai";
            }
            if(ModelState.IsValid){
                    // chuyển mật khẩu nhập vào thành mã băm
                    MD5 mh = MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Password);
                    byte[] hash = mh.ComputeHash(inputBytes);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("x2"));
                    }
                    string newPassword = sb.ToString();
                    var taikhoan =new Taikhoan(){
                        Username = Username,
                        Password = newPassword,
                        NgayTao = DateTime.Now,
                        KichHoat = 0,
                        LoaiTaiKhoanId = 1
                    };
                    //cập nhật mật khẩu mới
                    dbContext.Taikhoan.Add(taikhoan);
                    dbContext.SaveChanges();

                    var tk = (from x in dbContext.Taikhoan
                                where x.Username == Username
                                select x).ToList();
                    var nhanvien = new Nhanvien(){
                        HoTen = model.HoTen,
                        NgaySinh = model.NgaySinh,
                        Email = model.Email,
                        Sdt = model.Sdt,
                        DiaChi = model.DiaChi,
                        TaiKhoanId = tk[0].TaiKhoanId
                    } ;
                    dbContext.Nhanvien.Add(nhanvien);
                    dbContext.SaveChanges();
                string success= "Thêm nhân viên thành công";
                return RedirectToAction("ThemNhanVien","NhanVien",new{success=success});
            }
            string alert = "Thêm nhân viên không thành công";
            return RedirectToAction("ThemNhanVien","NhanVien",new{alert=alert});
        }

        public IActionResult SuaNhanVien(int id,string success, string err){
            var dbContext = new shopContext();
            var nhanvien = ( from nv in dbContext.Nhanvien
                                where nv.NhanVienId == id
                                select nv).ToList();
                                // new{
                                //     id = nv.NhanVienId,
                                //     hoten = nv.HoTen,
                                //     ngaysinh = nv.NgaySinh.ToString(),
                                //     email = nv.Email,
                                //     sdt = nv.Sdt,
                                //     diachi = nv.DiaChi,
                                //     taikhoan = nv.TaiKhoanId
                                // }).ToList();
            List<Nhanvien> ListNhanVien = new List<Nhanvien>();
            foreach (var item in nhanvien)
            {
                Nhanvien nv = new Nhanvien();
                nv.NhanVienId = item.NhanVienId;
                // var date = Convert.ToDateTime(item.NgaySinh).Date;
                nv.HoTen = item.HoTen;
                nv.NgaySinh = item.NgaySinh;
                
                nv.Email = item.Email;
                nv.Sdt = item.Sdt;
                ListNhanVien.Add(nv);
            }
            
            // if(nhanvien[0].NgaySinh!=null){
            //     string x= nhanvien[0].NgaySinh != null?
            //                 nhanvien[0].NgaySinh.ToString("yyyy-MM-dd"):
            //                 "ok";
            // }
            string newDate = nhanvien[0].NgaySinh.ToString("yyyy-MM-dd");
            ViewBag.newDate = newDate;
            ViewBag.nhanvien = ListNhanVien;
            ViewBag.err=err;
            ViewBag.success =success;
            return View();
        }

        [HttpPost]
        public IActionResult SuaNhanVien(Nhanvien model){
            var dbContext = new shopContext();
            if(ModelState.IsValid){
                var nhanvien = dbContext.Nhanvien.First(a => a.NhanVienId == model.NhanVienId);
                nhanvien.HoTen = model.HoTen;
                nhanvien.Sdt= model.Sdt;
                nhanvien.DiaChi = model.DiaChi;
                nhanvien.Email = model.Email;
                nhanvien.NgaySinh= model.NgaySinh;
                dbContext.SaveChanges();
                return RedirectToAction("suanhanvien","nhanvien",new{id=model.NhanVienId,success = "Sửa thông tin nhân viên thành công"});
            }
            return RedirectToAction("suanhanvien","nhanvien",new{id=model.NhanVienId,err = "Sửa thông tin nhân viên không thành công"});
        }
    }
}