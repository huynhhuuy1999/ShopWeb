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
    public class TaiKhoanController : Controller{
        public IActionResult DangNhap(){
            return View();
        }

        [HttpPost]
        public IActionResult DangNhap(Taikhoan model)
        {
            if(model.Username==null && model.Password==null){
                    ViewBag.error = "Đăng nhập không thành công";
                    return View("dangnhap");
                }
            if(ModelState.IsValid){
                //xu ly password
                MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(model.Password);
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                string pass = sb.ToString();
                var dbContext= new shopContext();
                var taikhoan = (from tk in dbContext.Taikhoan
                                    where tk.Username==model.Username && tk.Password == pass
                                    select tk);
                foreach(var item in taikhoan){
                    if(item.Username == model.Username && item.Password== pass){
                        HttpContext.Session.SetString("username", model.Username);
                        // return RedirectToAction("Index","Home");
                        return RedirectToAction("xacnhandathang","sanpham");
                    }
                }
                
                ViewBag.error = "Đăng nhập không thành công";
                return View("dangnhap");
            }
            return View("dangnhap");
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("index","home");
        }

        public IActionResult DangKy(){
            return View();
        }

        // [HttpPost]
        // public IActionResult DangKy(string user, string password,Khachhang model)
        // {
        //     if(ModelState.IsValid){
        //         var dbContext = new shopContext();
        //     //Tạo MD5 
        //         MD5 mh = MD5.Create();
        //         //Chuyển kiểu chuổi thành kiểu byte
        //         byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
        //         //mã hóa chuỗi đã chuyển
        //         byte[] hash = mh.ComputeHash(inputBytes);
        //         //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
        //         StringBuilder sb = new StringBuilder();

        //         for (int i = 0; i < hash.Length; i++)
        //         {
        //             sb.Append(hash[i].ToString("x2"));
        //         }

        //         var taikhoan = new Taikhoan()
        //         {
        //             Username = user,
        //             Password = sb.ToString(),
        //             NgayTao = DateTime.Now,
        //             KichHoat = 0
        //         };
        //         dbContext.Taikhoan.Add(taikhoan);
        //         dbContext.SaveChanges();
        //         //xử lý tài khoản id
        //         var idTK = (from tk in dbContext.Taikhoan where tk.Username == user select tk.TaiKhoanId);
        //         Taikhoan x= new Taikhoan();
        //         foreach(var item in idTK){
        //             x.TaiKhoanId= item;
        //         }

        //         var khachhang= new Khachhang(){
        //             HoTen = model.HoTen,
        //             Email = model.Email,
        //             Sdt = model.Sdt,
        //             NgaySinh = model.NgaySinh,
        //             TaiKhoanId = x.TaiKhoanId
        //         };
        //         dbContext.Khachhang.Add(khachhang);
        //         dbContext.SaveChanges();
        //     }
        //     else{
        //         return RedirectToAction("index","home");
        //     }
        //     return View("DangNhap");
        // }

        [HttpPost]
        public IActionResult DangKy(Taikhoan model,string HoTen,string Email,DateTime NgaySinh,string Sdt)
        {
            var dbContext = new shopContext();
            var taikhoan1 = (from tk in dbContext.Taikhoan where tk.Username == model.Username select tk).ToList();
            if(taikhoan1.Count>0){
                ModelState.AddModelError("Username","Username da ton tai");
                ViewBag.errUsername = "Username da ton tai";
            }
            if(ModelState.IsValid){
               
            //Tạo MD5 
                MD5 mh = MD5.Create();
                //Chuyển kiểu chuổi thành kiểu byte
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(model.Password);
                //mã hóa chuỗi đã chuyển
                byte[] hash = mh.ComputeHash(inputBytes);
                //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }

                var taikhoan = new Taikhoan()
                {
                    Username = model.Username,
                    Password = sb.ToString(),
                    NgayTao = DateTime.Now,
                    KichHoat = 0
                };
                dbContext.Taikhoan.Add(taikhoan);
                dbContext.SaveChanges();
                //xử lý tài khoản id
                var idTK = (from tk in dbContext.Taikhoan where tk.Username == model.Username select tk.TaiKhoanId);
                Taikhoan x= new Taikhoan();
                foreach(var item in idTK){
                    x.TaiKhoanId= item;
                }

                var khachhang= new Khachhang(){
                    HoTen = HoTen,
                    Email = Email,
                    Sdt = Sdt,
                    NgaySinh =NgaySinh,
                    TaiKhoanId = x.TaiKhoanId
                };
                dbContext.Khachhang.Add(khachhang);
                dbContext.SaveChanges();
            }
            else{
                return View("dangky");
            }
            return View("DangNhap");
        }

        public  IActionResult ThanhCong(){
            return View();
        }
    }
}