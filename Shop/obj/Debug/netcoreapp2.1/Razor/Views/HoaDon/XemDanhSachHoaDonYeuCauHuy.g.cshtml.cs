#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104c1127a0c16a00884088cc1c3ef9e49cfcb7a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDon_XemDanhSachHoaDonYeuCauHuy), @"mvc.1.0.view", @"/Views/HoaDon/XemDanhSachHoaDonYeuCauHuy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoaDon/XemDanhSachHoaDonYeuCauHuy.cshtml", typeof(AspNetCore.Views_HoaDon_XemDanhSachHoaDonYeuCauHuy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104c1127a0c16a00884088cc1c3ef9e49cfcb7a5", @"/Views/HoaDon/XemDanhSachHoaDonYeuCauHuy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDon_XemDanhSachHoaDonYeuCauHuy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/HoaDon/styleXemDanhSachHoaDonYeuCauHuy.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(37, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e2f527ed90004117b53d0366b7ea346f", async() => {
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
            BeginContext(122, 923, true);
            WriteLiteral(@"

<div class=""table1 container"">
    <h3 style=""color:red"">Danh sách yêu cầu hủy</h3>
    <table id=""verticalScroll"" class=""table table-sm table-bordered table-striped table-hover"">
        <thead>
            <tr>
                <th scope=""col"">Tên khách hàng</th>
                <th scope=""col"">Địa chỉ</th>
                <th scope=""col"">Ngày đặt</th>
                <th scope=""col"">Ngày giao</th>
                <th scope=""col"">Tên người nhận</th>
                <th scope=""col"">Số điện thoại</th>
                <th scope=""col"">Tiền gói hàng</th>
                <th scope=""col"">Phí ship</th>
                <th scope=""col"">Tiền giảm giá</th>
                <th scope=""col"">Tổng thanh toán</th>
                <th scope=""col"">Trạng thái</th>
                <th scope=""col"">Chi tiết</th>
                <th scope=""col"">Xác nhận</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 27 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
             foreach (var item in ViewBag.dsYeuCauHuy as List<Hoadon>)
            {

#line default
#line hidden
            BeginContext(1132, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1179, 50, false);
#line 30 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.KhachHang.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1261, 40, false);
#line 31 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SoNha));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1304, 39, false);
#line 31 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                                                              Write(Html.DisplayFor(modelItem => item.Quan));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1375, 35, false);
#line 32 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(item.NgayTao.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1442, 43, false);
#line 33 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NgayGiao));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1517, 47, false);
#line 34 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenNguoiNhan));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1596, 38, false);
#line 35 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Sdt));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1666, 51, false);
#line 36 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TongTienChuaShip));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1749, 49, false);
#line 37 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PhiShip.ChiPhi));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1830, 46, false);
#line 38 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TienGiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1908, 52, false);
#line 39 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TongTienThanhToan));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1992, 44, false);
#line 40 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 33, true);
            WriteLiteral("</td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2069, "\"", 2145, 2);
            WriteAttributeValue("", 2076, "/hoadon/xemchitiethoadon/", 2076, 25, true);
#line 41 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
WriteAttributeValue("", 2101, Html.DisplayFor(modelItem => item.HoaDonId), 2101, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2146, 65, true);
            WriteLiteral("><i>Chi tiết</i></a></td>\r\n                    <td><i class=\"huy\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2211, "\"", 2230, 1);
#line 42 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
WriteAttributeValue("", 2216, item.HoaDonId, 2216, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2231, 47, true);
            WriteLiteral(">Xác nhận hủy</i></td>\r\n                </tr>\r\n");
            EndContext();
#line 44 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
            }

#line default
#line hidden
            BeginContext(2293, 401, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>
<script>
    $(document).ready(function () {
			$('#verticalScroll').DataTable({
				""scrollY"": ""380px"",
				""scrollCollapse"": true
			});
			$('.dataTables_length').addClass('bs-select');

            $("".huy"").click(()=>{
                let id = event.target.id;
                $.ajax({
                    type:""POST"",
                    url:""");
            EndContext();
            BeginContext(2695, 31, false);
#line 60 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemDanhSachHoaDonYeuCauHuy.cshtml"
                    Write(Url.Action("XacNhanHuyDonHang"));

#line default
#line hidden
            EndContext();
            BeginContext(2726, 310, true);
            WriteLiteral(@""",
                    data:{mahd:id},
                    success:(data)=>{
                        $(""#""+id).text(""Đã xác nhận"");
                    },
                    error:(err)=>{
                        alert(err);
                    }
                });
            });
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
