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
    public class KhachHangController : Controller{
        public IActionResult XemThongTinKhachHang(string id,string err,string success){
            var dbContext = new shopContext();
            var taikhoan = (from tk in dbContext.Taikhoan
                                where tk.Username == id
                                select tk).ToList();
            var khachhang = ( from kh in dbContext.Khachhang
                                where kh.TaiKhoanId == taikhoan[0].TaiKhoanId
                                select kh).ToList();
            ViewBag.kh = khachhang;
            ViewBag.err=err;
            ViewBag.success =success;
            return View();
        }

        [HttpPost]
        public IActionResult LuuThongTinKhachHang(Khachhang model,string changePassword,string oldpassword,string newPassword)
        {
            string idSession = HttpContext.Session.GetString("username");
            // if(oldpassword=="123"){
            //     ModelState.AddModelError("oldpassword","oldpassword da ton tai");
            //     ViewBag.errOldPass = "oldpassword da ton tai";
            //     // return Redirect("xemthongtinkhachhang/"+idSession);
            //     return RedirectToAction("xemthongtinkhachhang","khachhang",new{id=idSession,x="ok baby"});
            // }
            if(ModelState.IsValid){
                
                var dbContext= new shopContext();
                var taikhoan = (from tk in dbContext.Taikhoan
                                    where tk.Username == idSession
                                    select tk).ToList();
                System.Console.WriteLine("taikhoan:"+idSession);
                //xu ly password
                ;
                if(changePassword == "check"){
                    
                    // chuyển mật khẩu cũ nhập vào thành mã băm
                    MD5 mh = MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(oldpassword);
                    byte[] hash = mh.ComputeHash(inputBytes);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("x2"));
                    }
                    string newOldpassword = sb.ToString();
                    //kiểm tra mật khẩu cũ nhập vào đúng hay không
                    if(newOldpassword != taikhoan[0].Password){
                        string err ="Mật khẩu không đúng";
                        return RedirectToAction("xemthongtinkhachhang","khachhang",new{id=idSession,err=err});
                    }
                    // lấy tài khoản để cập nhạt mật khẩu
                    var account = dbContext.Taikhoan.First(a => a.TaiKhoanId == taikhoan[0].TaiKhoanId);
                    //chuyển mật khẩu mới nhập vào thành mã băm
                    byte[] inputBytes2 = System.Text.Encoding.ASCII.GetBytes(newPassword);
                    byte[] hash2 = mh.ComputeHash(inputBytes2);
                    StringBuilder sb2 = new StringBuilder();
                    for (int i = 0; i < hash2.Length; i++)
                    {
                        sb2.Append(hash2[i].ToString("x2"));
                    }
                    string newpass = sb2.ToString();
                    //cập nhật mật khẩu mới
                    account.Password = newpass;
                    dbContext.SaveChanges();
                }
                
               

                var kh = (from k in dbContext.Khachhang
                            where k.TaiKhoanId == taikhoan[0].TaiKhoanId
                            select k).ToList();
                var khachhang = dbContext.Khachhang.First(a => a.KhachHangId == kh[0].KhachHangId);
                khachhang.HoTen = model.HoTen;
                khachhang.Email = model.Email;
                khachhang.Sdt = model.Sdt;
                khachhang.NgaySinh = model.NgaySinh;
                khachhang.DiaChi = model.DiaChi;
                dbContext.SaveChanges();

                string success= "Cập nhật thông tin thành công";
                return RedirectToAction("xemthongtinkhachhang","khachhang",new{id=idSession,success=success});
            }
            return RedirectToAction("xemthongtinkhachhang","khachhang",new{id=idSession});
        }
    }
}