#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b683244d9ce5dfaf7b631d01a5ebe1b8b44eb37"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b683244d9ce5dfaf7b631d01a5ebe1b8b44eb37", @"/Views/HoaDon/XemChiTietHoaDon.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c6648cc07854fceb59444a7a1a7a44a", async() => {
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
            BeginContext(112, 610, true);
            WriteLiteral(@"

<div class=""table1 container"">
    <h3>Chi tiết hóa đơn</h3>
    <table id=""verticalScroll"" class=""table table-sm table-bordered table-striped table-hover"">
        <thead>
            <tr>
                <th scope=""col"">Tên sản phẩm</th>
                <th scope=""col"">Ảnh sản phẩm</th>
                <th scope=""col"">Số lựong</th>
                <th scope=""col"">Kích thước</th>
                <th scope=""col"">Giá tiền</th>
                <th scope=""col"">Tiền khuyến mãi</th>
                <th scope=""col"">Tiền sau khuyến mãi</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
             foreach (var item in ViewBag.chitiet as List<Chitiethoadon>)
            {

#line default
#line hidden
            BeginContext(812, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(859, 53, false);
#line 24 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SanPham.TenSanPham));

#line default
#line hidden
            EndContext();
            BeginContext(912, 62, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <div>");
            EndContext();
            BeginContext(974, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "14cbca26869048a7bc9a24d04f7fa2b3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 984, "~/images/", 984, 9, true);
#line 26 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
AddHtmlAttributeValue("", 993, Html.DisplayFor(modelItem => item.SanPham.HinhAnh.TenFile), 993, 59, false);

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
            BeginContext(1061, 59, true);
            WriteLiteral("</div>\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(1121, 42, false);
#line 28 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1195, 57, false);
#line 29 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.KichThuoc.TenKichThuoc));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1284, 43, false);
#line 30 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TongTien));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1359, 48, false);
#line 31 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TienKhuyenMai));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1439, 44, false);
#line 32 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TongSauKm));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\HoaDon\XemChiTietHoaDon.cshtml"
            }

#line default
#line hidden
            BeginContext(1528, 252, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<script>\r\n    $(document).ready(function () {\r\n\t\t\t$(\'#verticalScroll\').DataTable({\r\n\t\t\t\t\"scrollY\": \"380px\",\r\n\t\t\t\t\"scrollCollapse\": true\r\n\t\t\t});\r\n\t\t\t$(\'.dataTables_length\').addClass(\'bs-select\');\r\n\t\t});\r\n</script>");
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
