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

using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;
using Syncfusion.Pdf.Grid;
using System.Data;

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

        public IActionResult DanhSachKhachHang(){
            var dbContext = new shopContext();
            var khachhang = (from kh in dbContext.Khachhang
                                select kh).ToList();
            ViewBag.khachhang = khachhang;
            return View();
        }

        public IActionResult SuaKhachHang(int id,string err,string success){
            var dbContext = new shopContext();
            var khachhang = ( from kh in dbContext.Khachhang
                                where kh.KhachHangId == id
                                select kh).ToList();
            string newDate = khachhang[0].NgaySinh.ToString("yyyy-MM-dd");
            ViewBag.newDate = newDate;
            ViewBag.kh = khachhang;
            ViewBag.err=err;
            ViewBag.success =success;
            return View();
        }

        [HttpPost]
        public IActionResult SuaKhachHang(Khachhang model){
            var dbContext = new shopContext();
            if(ModelState.IsValid){
                var khachhang = dbContext.Khachhang.First(a => a.KhachHangId == model.KhachHangId);
                khachhang.HoTen = model.HoTen;
                khachhang.Sdt= model.Sdt;
                khachhang.DiaChi = model.DiaChi;
                khachhang.Email = model.Email;
                khachhang.NgaySinh= model.NgaySinh;
                dbContext.SaveChanges();
                return RedirectToAction("suakhachhang","khachhang",new{id=model.KhachHangId,success = "Sửa thông tin khách hàng thành công"});
            }
            return RedirectToAction("suakhachhang","khachhang",new{id=model.KhachHangId,err = "Sửa thông tin khách hàng không thành công"});
        }

        public IActionResult xuatpdf(){
            var dbContext = new shopContext();
            //Create a new PDF document
            PdfDocument doc = new PdfDocument();
//Add a page.
            PdfPage page = doc.Pages.Add();
            //Create a PdfGrid.
            PdfGrid pdfGrid = new PdfGrid();

            // create a graphics
            PdfGraphics graphics = page.Graphics;
            //Add values to list

            // List<object> data = new List<object>();
            // Object row1 = new { ID = "E01", Name = "Clay" };
            // Object row2 = new { ID = "E02", Name = "Thomas" };
            // Object row3 = new { ID = "E03", Name = "Andrew" };
            // Object row4 = new { ID = "E04", Name = "Paul" };
            // Object row5 = new { ID = "E05", Name = "Gray" };
            // data.Add(row1);
            // data.Add(row2);
            // data.Add(row3);
            // data.Add(row4);
            // data.Add(row5);

            //Add list to IEnumerable

            var data = (from d in dbContext.Sanpham select d).ToList();
            IEnumerable<object> dataTable = data;
            //Assign data source.
            pdfGrid.DataSource = dataTable;
            //Draw grid to the page of PDF document.
            pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 10));


            RectangleF bounds = new RectangleF(176, 0, 390, 130);
            PdfBrush solidBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
            bounds = new RectangleF(0,bounds.Bottom + 90, graphics.ClientSize.Width, 30);
            //Draws a rectangle to place the heading in that region.
            graphics.DrawRectangle(solidBrush, bounds);
            //Creates a font for adding the heading in the page
            PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);
            //Creates a text element to add the invoice number
            PdfTextElement element = new PdfTextElement("INVOICE " + "ok baby", subHeadingFont);
            element.Brush = PdfBrushes.White;

            PdfLayoutResult result = element.Draw(page, new PointF(10, bounds.Top + 8));
            string currentDate = "DATE " + DateTime.Now.ToString("MM/dd/yyyy");
            //Measures the width of the text to place it in the correct location
            SizeF textSize = subHeadingFont.MeasureString(currentDate);
            PointF textPosition = new PointF(graphics.ClientSize.Width - textSize.Width - 10, result.Bounds.Y);
            //Draws the date by using DrawString method
            graphics.DrawString(currentDate, subHeadingFont, element.Brush, textPosition);
            PdfFont timesRoman = new PdfStandardFont(PdfFontFamily.TimesRoman, 10);
            //Creates text elements to add the address and draw it to the page.
            element = new PdfTextElement("BILL TO ", timesRoman);
            element.Brush = new PdfSolidBrush(new PdfColor(126, 155, 203));
            result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 25));
            PdfPen linePen = new PdfPen(new PdfColor(126, 151, 173), 0.70f);
            PointF startPoint = new PointF(0, result.Bounds.Bottom + 3);
            PointF endPoint = new PointF(graphics.ClientSize.Width, result.Bounds.Bottom + 3);
            //Draws a line at the bottom of the address
            graphics.DrawLine(linePen, startPoint, endPoint);

          
            //Save the PDF document to stream
            MemoryStream stream = new MemoryStream();
            doc.Save(stream);
            //If the position is not set to '0' then the PDF will be empty.
            stream.Position = 0;
            //Close the document.
            doc.Close(true);
            //Defining the ContentType for pdf file.
            string contentType = "application/pdf";
            //Define the file name.
            string fileName = "Output.pdf";
            //Creates a FileContentResult object by using the file contents, content type, and file name.
            return File(stream, contentType, fileName);
        }
    }
}