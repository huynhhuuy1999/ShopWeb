#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "881b8d83adc5d8388e023cdddc09ac6908c348d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDon_InHoaDon), @"mvc.1.0.view", @"/Views/HoaDon/InHoaDon.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoaDon/InHoaDon.cshtml", typeof(AspNetCore.Views_HoaDon_InHoaDon))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881b8d83adc5d8388e023cdddc09ac6908c348d2", @"/Views/HoaDon/InHoaDon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDon_InHoaDon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Hoadon>, List<Chitiethoadon>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootrap4/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/HoaDon/styleInHoaDon.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(79, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(114, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcb4c58708b74b3a9922c7d53d65ba92", async() => {
                BeginContext(120, 110, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                EndContext();
                BeginContext(230, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e68b9aa589f40e1bd38f87dfcab5da6", async() => {
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
                BeginContext(293, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(299, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0775cfb06cf145d0b801db828a8601b8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(368, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(377, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(379, 3464, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d836b93d9ac244258deed5954bee028a", async() => {
                BeginContext(385, 149, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"content\">\r\n            <div class=\"title\">\r\n                <h3>HÓA ĐƠN</h3>\r\n            </div>\r\n");
                EndContext();
#line 20 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
             foreach(var item in Model.Item1){

#line default
#line hidden
                BeginContext(582, 67, true);
                WriteLiteral("                <div class=\"date\">\r\n                    <span>Ngày ");
                EndContext();
                BeginContext(650, 16, false);
#line 22 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                          Write(item.NgayTao.Day);

#line default
#line hidden
                EndContext();
                BeginContext(666, 8, true);
                WriteLiteral(", tháng ");
                EndContext();
                BeginContext(675, 18, false);
#line 22 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                                                   Write(item.NgayTao.Month);

#line default
#line hidden
                EndContext();
                BeginContext(693, 6, true);
                WriteLiteral(", năm ");
                EndContext();
                BeginContext(700, 17, false);
#line 22 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                                                                            Write(item.NgayTao.Year);

#line default
#line hidden
                EndContext();
                BeginContext(717, 132, true);
                WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"info\">\r\n                    <span>Họ tên người mua: <span class=\"name\">");
                EndContext();
                BeginContext(850, 20, false);
#line 25 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                                                          Write(item.KhachHang.HoTen);

#line default
#line hidden
                EndContext();
                BeginContext(870, 85, true);
                WriteLiteral("</span> </span><br>\r\n                    <span>Họ tên người nhận: <span class=\"name\">");
                EndContext();
                BeginContext(956, 17, false);
#line 26 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                                                           Write(item.TenNguoiNhan);

#line default
#line hidden
                EndContext();
                BeginContext(973, 61, true);
                WriteLiteral("</span></span><br>\r\n                    <span>Số điện thoại: ");
                EndContext();
                BeginContext(1035, 8, false);
#line 27 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                                    Write(item.Sdt);

#line default
#line hidden
                EndContext();
                BeginContext(1043, 48, true);
                WriteLiteral("</span><br>\r\n                    <span>Địa chỉ: ");
                EndContext();
                BeginContext(1092, 10, false);
#line 28 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                              Write(item.SoNha);

#line default
#line hidden
                EndContext();
                BeginContext(1102, 3, true);
                WriteLiteral(" , ");
                EndContext();
                BeginContext(1106, 9, false);
#line 28 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                                            Write(item.Quan);

#line default
#line hidden
                EndContext();
                BeginContext(1115, 37, true);
                WriteLiteral("</span><br>\r\n                </div>\r\n");
                EndContext();
#line 30 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
            }

#line default
#line hidden
                BeginContext(1167, 612, true);
                WriteLiteral(@"            <div class=""cover-table mt-4"">
                <span class=""dvt"">Đơn vị tính (đ)</span>
                <table class=""table table-sm table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th>Tên sản phẩm</th>
                            <th>Số lượng</th>
                            <th>Kích thước</th>
                            <th>Giá</th>
                            <th>Tiền giảm</th>
                            <th>Tạm tính</th>
                        </tr>
                    </thead>
                    <tbody>
");
                EndContext();
#line 45 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                         foreach(var item in Model.Item2){

#line default
#line hidden
                BeginContext(1839, 70, true);
                WriteLiteral("                            <tr>\r\n                                <td>");
                EndContext();
                BeginContext(1910, 23, false);
#line 47 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                               Write(item.SanPham.TenSanPham);

#line default
#line hidden
                EndContext();
                BeginContext(1933, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(1977, 12, false);
#line 48 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                               Write(item.SoLuong);

#line default
#line hidden
                EndContext();
                BeginContext(1989, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(2033, 27, false);
#line 49 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                               Write(item.KichThuoc.TenKichThuoc);

#line default
#line hidden
                EndContext();
                BeginContext(2060, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(2104, 13, false);
#line 50 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                               Write(item.TongTien);

#line default
#line hidden
                EndContext();
                BeginContext(2117, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(2161, 18, false);
#line 51 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                               Write(item.TienKhuyenMai);

#line default
#line hidden
                EndContext();
                BeginContext(2179, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(2223, 14, false);
#line 52 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                               Write(item.TongSauKm);

#line default
#line hidden
                EndContext();
                BeginContext(2237, 42, true);
                WriteLiteral("</td>\r\n                            </tr>\r\n");
                EndContext();
#line 54 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                        }

#line default
#line hidden
                BeginContext(2306, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 55 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                         foreach(var item in Model.Item1){

#line default
#line hidden
                BeginContext(2366, 155, true);
                WriteLiteral("                            <tr>\r\n                                <td colspan=\"5\" class=\"sum\">Tổng tiền tạm tính</td>\r\n                                <td>");
                EndContext();
                BeginContext(2522, 21, false);
#line 58 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                               Write(item.TongTienChuaShip);

#line default
#line hidden
                EndContext();
                BeginContext(2543, 193, true);
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td colspan=\"5\" class=\"sum\">Phí vận chuyển</td>\r\n                                <td>");
                EndContext();
                BeginContext(2737, 19, false);
#line 62 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                               Write(item.PhiShip.ChiPhi);

#line default
#line hidden
                EndContext();
                BeginContext(2756, 196, true);
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td colspan=\"5\" class=\"sum\">Tiền giảm voucher</td>\r\n                                <td>");
                EndContext();
                BeginContext(2953, 16, false);
#line 66 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                               Write(item.TienGiamGia);

#line default
#line hidden
                EndContext();
                BeginContext(2969, 199, true);
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td colspan=\"5\" class=\"sum\">Tổng tiền thanh toán</td>\r\n                                <td>");
                EndContext();
                BeginContext(3169, 22, false);
#line 70 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                               Write(item.TongTienThanhToan);

#line default
#line hidden
                EndContext();
                BeginContext(3191, 42, true);
                WriteLiteral("</td>\r\n                            </tr>\r\n");
                EndContext();
#line 72 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\InHoaDon.cshtml"
                        }

#line default
#line hidden
                BeginContext(3260, 576, true);
                WriteLiteral(@"                        
                    </tbody>
                </table>
            </div>
            <div class=""signed"">
                <div class=""nguoiMua ml-5"">
                    <span>Người mua hàng</span><br>
                    <span class=""note"">(Ký ghi rõ họ tên)</span>
                </div>
                <div class=""nguoiBan mr-5"">
                    <span>Người bán hàng</span><br>
                    <span class=""note"">(Ký ghi rõ họ tên)</span>
                </div>
            </div>
        </div>
        
    </div>
    
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3843, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Hoadon>, List<Chitiethoadon>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
