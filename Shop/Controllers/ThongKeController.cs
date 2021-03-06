using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Microsoft.AspNetCore.Http;
using System.Text;
using Rotativa.AspNetCore;

namespace Shop.Controllers
{
    public class ThongKeController : Controller
    {
        public IActionResult DoanhThu(){
            return View();
        }
        public List<Thongke> ThongKe(DateTime tungay, DateTime denngay){
            var dbContext = new shopContext();
            var doanhthu = dbContext.Hoadon
                            .Where(x => x.NgayTao>=tungay && x.NgayTao<=denngay)
                            .GroupBy(x=> new {
                                x.NgayTao.Month,
                                x.NgayTao.Year})
                            .OrderBy(x=>x.Key.Year)
                            .OrderBy(x=>x.Key.Month)
                            .Select(g => new {
                                thang = g.Key.Month,
                                nam = g.Key.Year,
                                tong = g.Sum(x=>x.TongTienThanhToan).ToString()
                            }).ToList();
            List<Thongke> DSThongKe = new List<Thongke>();
            foreach (var item in doanhthu)
            {
                Thongke tk = new Thongke();
                tk.Nam = item.nam;
                tk.Thang = item.thang;
                tk.DoanhThu =item.tong;
                DSThongKe.Add(tk);
            }
            return DSThongKe;
        }
        // public List<Thongke> BieuDo(DateTime tungay, DateTime denngay){

        // }
    }
}