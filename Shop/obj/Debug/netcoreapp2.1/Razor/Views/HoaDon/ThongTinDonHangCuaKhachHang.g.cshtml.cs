#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13565933fa8dd2f17f2532e738576e34b526bb22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDon_ThongTinDonHangCuaKhachHang), @"mvc.1.0.view", @"/Views/HoaDon/ThongTinDonHangCuaKhachHang.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoaDon/ThongTinDonHangCuaKhachHang.cshtml", typeof(AspNetCore.Views_HoaDon_ThongTinDonHangCuaKhachHang))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#line 2 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13565933fa8dd2f17f2532e738576e34b526bb22", @"/Views/HoaDon/ThongTinDonHangCuaKhachHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDon_ThongTinDonHangCuaKhachHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Customer/styleThongTinDonHangCuaKhachHang.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b2b9d40be544bea9658b01e4e2198fd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(84, 679, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""tieude"">
        <h3>Đơn hàng của tôi</h3>
    </div>
    <div class=""thongtin"">
        <table align=""center"" id=""verticalScroll"" class=""table table-sm table-bordered table-striped table-hover w-65"">
            <thead>
                <tr>
                    <th scope=""col"">Mã đơn hàng</th>
                    <th scope=""col"">Ngày mua</th>
                    <th scope=""col"">Tiền giảm giá</th>
                    <th scope=""col"">Tổng tiền</th>
                    <th scope=""col"">Trạng thái</th>
                    <th scope=""col"">Hủy đơn hàng</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 19 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                 foreach (var item in ViewBag.hoadon as List<Hoadon>)
                {

#line default
#line hidden
            BeginContext(853, 56, true);
            WriteLiteral("                    <tr>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 909, "\"", 956, 2);
            WriteAttributeValue("", 916, "/hoadon/xemchitietdonhang/", 916, 26, true);
#line 22 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
WriteAttributeValue("", 942, item.HoaDonId, 942, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(957, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(959, 13, false);
#line 22 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                                                                          Write(item.HoaDonId);

#line default
#line hidden
            EndContext();
            BeginContext(972, 39, true);
            WriteLiteral("</a></td>\r\n                        <td>");
            EndContext();
            BeginContext(1012, 35, false);
#line 23 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                       Write(item.NgayTao.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1083, 16, false);
#line 24 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                       Write(item.TienGiamGia);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1135, 22, false);
#line 25 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                       Write(item.TongTienThanhToan);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1193, 14, false);
#line 26 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                       Write(item.TrangThai);

#line default
#line hidden
            EndContext();
            BeginContext(1207, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                         if(item.TrangThai=="Chờ xử lý"){

#line default
#line hidden
            BeginContext(1273, 46, true);
            WriteLiteral("                            <td><i class=\"huy\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1319, "\"", 1338, 1);
#line 28 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
WriteAttributeValue("", 1324, item.HoaDonId, 1324, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1339, 15, true);
            WriteLiteral(">Hủy</i></td>\r\n");
            EndContext();
#line 29 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                        }

#line default
#line hidden
            BeginContext(1381, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 30 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                         if(item.TrangThai=="Đang giao hàng"){

#line default
#line hidden
            BeginContext(1445, 51, true);
            WriteLiteral("                            <td><i class=\"nhanhang\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1496, "\"", 1515, 1);
#line 31 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
WriteAttributeValue("", 1501, item.HoaDonId, 1501, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1516, 30, true);
            WriteLiteral(">Xác nhận nhận hàng</i></td>\r\n");
            EndContext();
#line 32 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                        }

#line default
#line hidden
            BeginContext(1573, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 33 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                         if(item.TrangThai!="Chờ xử lý" && item.TrangThai!="Đang giao hàng"){

#line default
#line hidden
            BeginContext(1668, 51, true);
            WriteLiteral("                            <td><i class=\"nhanhang\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1719, "\"", 1738, 1);
#line 34 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
WriteAttributeValue("", 1724, item.HoaDonId, 1724, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1739, 24, true);
            WriteLiteral(">Đã nhận hàng</i></td>\r\n");
            EndContext();
#line 35 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                        }

#line default
#line hidden
            BeginContext(1790, 27, true);
            WriteLiteral("                    </tr>\r\n");
            EndContext();
#line 37 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                }

#line default
#line hidden
            BeginContext(1836, 246, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<script>\r\n    $(document).ready(() => {\r\n        $(\".huy\").click(() => {\r\n            let id = event.target.id;\r\n            $.ajax({\r\n                type:\"POST\",\r\n                url:\"");
            EndContext();
            BeginContext(2083, 30, false);
#line 48 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                Write(Url.Action("YeuCauHuyDonHang"));

#line default
#line hidden
            EndContext();
            BeginContext(2113, 412, true);
            WriteLiteral(@""",
                data:{mahd:id},
                success:(data)=>{
                    $(""#""+id).text(""Đã yêu cầu hủy"");
                },
                error:(err)=>{
                    alert(err);
                }
            })
        });

        $("".nhanhang"").click(() => {
            let id = event.target.id;
            $.ajax({
                type:""POST"",
                url:""");
            EndContext();
            BeginContext(2526, 29, false);
#line 63 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\ThongTinDonHangCuaKhachHang.cshtml"
                Write(Url.Action("XacNhanNhanHang"));

#line default
#line hidden
            EndContext();
            BeginContext(2555, 431, true);
            WriteLiteral(@""",
                data:{mahd:id},
                success:(data)=>{
                    $(""#""+id).text(""Đã nhận hàng"");
                },
                error:(err)=>{
                    alert(err);
                }
            })
        });

        $('#verticalScroll').DataTable({
				""scrollY"": ""380px"",
				""scrollCollapse"": true
			});
		$('.dataTables_length').addClass('bs-select');
    });
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591