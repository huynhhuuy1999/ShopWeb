#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df8b6f04bdc16980f13b7a80394dc67c6dbb5d2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDon_XemChiTietHoaDon), @"mvc.1.0.view", @"/Views/HoaDon/XemChiTietHoaDon.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoaDon/XemChiTietHoaDon.cshtml", typeof(AspNetCore.Views_HoaDon_XemChiTietHoaDon))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df8b6f04bdc16980f13b7a80394dc67c6dbb5d2c", @"/Views/HoaDon/XemChiTietHoaDon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDon_XemChiTietHoaDon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/HoaDon/styleXemChiTietHoaDon.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(37, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "05ce0f276f2c4cfeac718ede6d7ac37c", async() => {
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
            BeginContext(112, 91, true);
            WriteLiteral("\r\n\r\n<div class=\"table1 container\">\r\n    <h3 style=\"color:red\">Chi tiết hóa đơn</h3>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 203, "\"", 244, 2);
            WriteAttributeValue("", 210, "/hoadon/inhoadon/", 210, 17, true);
#line 8 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
WriteAttributeValue("", 227, ViewBag.idHoaDon, 227, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(245, 611, true);
            WriteLiteral(@"><button class =""btn btn-warning inHoaDon"">In hóa đơn</button></a>
    <table id=""verticalScroll"" class=""table table-sm table-bordered table-striped table-hover"">
        <thead>
            <tr>
                <th scope=""col"">Tên sản phẩm</th>
                <th scope=""col"">Ảnh sản phẩm</th>
                <th scope=""col"">Số lượng</th>
                <th scope=""col"">Kích thước</th>
                <th scope=""col"">Giá tiền</th>
                <th scope=""col"">Tiền khuyến mãi</th>
                <th scope=""col"">Tiền sau khuyến mãi</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
             foreach (var item in ViewBag.chitiet as List<Chitiethoadon>)
            {

#line default
#line hidden
            BeginContext(946, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(993, 53, false);
#line 25 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SanPham.TenSanPham));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 62, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <div>");
            EndContext();
            BeginContext(1108, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d98e2fd30654149a969c13be1c83116", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1118, "~/images/", 1118, 9, true);
#line 27 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
AddHtmlAttributeValue("", 1127, Html.DisplayFor(modelItem => item.SanPham.HinhAnh.TenFile), 1127, 59, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1195, 59, true);
            WriteLiteral("</div>\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(1255, 42, false);
#line 29 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1329, 57, false);
#line 30 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.KichThuoc.TenKichThuoc));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1418, 43, false);
#line 31 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TongTien));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1493, 48, false);
#line 32 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TienKhuyenMai));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1573, 44, false);
#line 33 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TongSauKm));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
            }

#line default
#line hidden
            BeginContext(1662, 258, true);
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
