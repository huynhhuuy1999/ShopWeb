using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rotativa.AspNetCore;

namespace Shop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseSession();
            app.UseAuthentication();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                // routes.MapRoute(
                //     name: "default",
                //     template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}");
                routes.MapRoute(
                    name: "ChiTietSanPham",
                    template: "{controller=SanPham}/{action=ChiTietSanPham}/{id}");
                routes.MapRoute(
                    name:"ThucDon",
                    template:"{controller=SanPham}/{action=ThucDon}");
                routes.MapRoute(
                    name:"DatHang",
                    template:"{controller=SanPham}/{action=DatHang}/{id}");
                routes.MapRoute(
                    name:"dangky",
                    template:"{controller=taikhoan}/{action=Dangky}");
                routes.MapRoute(
                    name:"dangnhap",
                    template:"{controller=taikhoan}/{action=dangnhap}");
                routes.MapRoute(
                    name:"dangxuat",
                    template:"{controller=taikhoan}/{action=logout}");
                routes.MapRoute(
                    name:"xemthongtinkhachhang",
                    template:"{controller=khachhang}/{action=XemThongTinKhachHang}/{id}");
                routes.MapRoute(
                    name:"suasanpham",
                    template:"{controller=sanpham}/{action=suasanpham}/{id}");
                routes.MapRoute(
                    name:"suakhachhang",
                    template:"{controller=khachhang}/{action=suakhachhang}/{id}");
                routes.MapRoute(
                    name:"suanhanvien",
                    template:"{controller=nhanvien}/{action=suanhanvien}/{id}");
                routes.MapRoute(
                    name:"xemchitiethoadon",
                    template:"{controller=hoadon}/{action=xemchitiethoadon}/{id}");
                routes.MapRoute(
                    name:"suakhuyenmai",
                    template:"{controller=khuyenmai}/{action=suakhuyenmai}/{id}");
                routes.MapRoute(
                    name:"thongtindonhang",
                    template:"{controller=hoadon}/{action=thongtindonhangcuakhachhang}/{id}");
                routes.MapRoute(
                    name:"xemchitietdonhang",
                    template:"{controller=hoadon}/{action=xemchitietdonhang}/{id}");
                routes.MapRoute(
                    name:"inhoadon",
                    template:"{controller=hoadon}/{action=InHoaDon}/{id}");
                routes.MapRoute(
                    name:"thembinhluan",
                    template:"{controller=binhluan}/{action=Thembinhluan}/{id}");
                routes.MapRoute(
                    name:"xoabinhluan",
                    template:"{controller=binhluan}/{action=xoabinhluan}/{id}");
            });
            RotativaConfiguration.Setup(env);
        }
    }
}
