#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451e394e5a594b64601cb0aa710f10f8a291ccbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_XemDanhSachSanPham), @"mvc.1.0.view", @"/Views/SanPham/XemDanhSachSanPham.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPham/XemDanhSachSanPham.cshtml", typeof(AspNetCore.Views_SanPham_XemDanhSachSanPham))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451e394e5a594b64601cb0aa710f10f8a291ccbb", @"/Views/SanPham/XemDanhSachSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_XemDanhSachSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/SanPham/styleXemDanhSachSanPham.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(37, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b416ec38ebd42c7a12e4761b116a8be", async() => {
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
            BeginContext(115, 738, true);
            WriteLiteral(@"

<div class=""table1 container"">
    <a href=""/sanpham/themsanpham""><button type=""button"" class=""btn btn-primary btn-add"">Thêm sản phẩm</button></a>
    <table id=""verticalScroll"" class=""table table-sm table-bordered table-striped table-hover w-100"">
        <thead>
            <tr>
                <th scope=""col"">Tên sản phẩm</th>
                <th scope=""col"">Mô tả</th>
                <th scope=""col"">Giá bán lẻ</th>
                <th scope=""col"">Trạng thái</th>
                <th scope=""col"">Tên loại</th>
                <th scope=""col"">Khuyến mãi</th>
                <th scope=""col"">Hình ảnh</th>
                <th scope=""col""><a href="""">Sửa</a></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
             foreach (var item in ViewBag.sanpham as List<Sanpham>)
            {

#line default
#line hidden
            BeginContext(937, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(984, 45, false);
#line 25 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenSanPham));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1061, 39, false);
#line 26 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Mota));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"giabanle\">");
            EndContext();
            BeginContext(1149, 43, false);
#line 27 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.GiaBanLe));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 49, true);
            WriteLiteral("</td>\r\n                    <td class=\"trangthai\">");
            EndContext();
            BeginContext(1242, 44, false);
#line 28 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1318, 51, false);
#line 29 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PhanLoai.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1401, 57, false);
#line 30 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
                   Write(Html.DisplayFor(modelItem => item.KhuyenMai.PhanTramGiam));

#line default
#line hidden
            EndContext();
            BeginContext(1458, 55, true);
            WriteLiteral("</td>\r\n                    <td><div class=\"containImg\">");
            EndContext();
            BeginContext(1513, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7259f75c10104d47807d59ff3c35a926", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1523, "~/images/", 1523, 9, true);
#line 31 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
AddHtmlAttributeValue("", 1532, Html.DisplayFor(modelItem => item.HinhAnh.TenFile), 1532, 51, false);

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
            BeginContext(1592, 59, true);
            WriteLiteral("</div></td>\r\n                    <td class=\"text-center\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1651, "\"", 1723, 2);
            WriteAttributeValue("", 1658, "/sanpham/suasanpham/", 1658, 20, true);
#line 32 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
WriteAttributeValue("", 1678, Html.DisplayFor(modelItem => item.SanPhamId), 1678, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1724, 62, true);
            WriteLiteral("><i class=\"fad fa-edit\"></i></a></td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\XemDanhSachSanPham.cshtml"
            }

#line default
#line hidden
            BeginContext(1801, 406, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>
<script>
    $(document).ready(function () {
			$('#verticalScroll').DataTable({
				""scrollY"": ""430px"",
				""scrollCollapse"": true,
                ""columnDefs"": [
                    {""width"":""15%"",""targets"": 0},
                    {""width"":""30%"",""targets"": 1}
                ]
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
