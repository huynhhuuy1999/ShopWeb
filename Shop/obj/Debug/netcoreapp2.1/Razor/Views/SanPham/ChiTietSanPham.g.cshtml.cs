#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\ChiTietSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7bfe4cfca8559bc03ade3e101ce2508ced5a496"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_ChiTietSanPham), @"mvc.1.0.view", @"/Views/SanPham/ChiTietSanPham.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPham/ChiTietSanPham.cshtml", typeof(AspNetCore.Views_SanPham_ChiTietSanPham))]
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
#line 2 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\ChiTietSanPham.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7bfe4cfca8559bc03ade3e101ce2508ced5a496", @"/Views/SanPham/ChiTietSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_ChiTietSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Customer/SanPham/styleChitiet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("anhsanpham"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2719830cc0c9487a8c367d80b20a8182", async() => {
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
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(109, 32, true);
            WriteLiteral("\r\n<div class=\"container mb-5\">\r\n");
            EndContext();
#line 5 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\ChiTietSanPham.cshtml"
     foreach (var item in ViewData["sanpham"] as List<Sanpham>)
    {

#line default
#line hidden
            BeginContext(213, 138, true);
            WriteLiteral("        <div class=\"list pt-4 pb-4\">\r\n            <a href=\"/sanpham/thucdon\">menu </a><span class=\"pl-2 pr-2\">/</span>\r\n            <span>");
            EndContext();
            BeginContext(352, 45, false);
#line 9 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\ChiTietSanPham.cshtml"
             Write(Html.DisplayFor(modelItem => item.TenSanPham));

#line default
#line hidden
            EndContext();
            BeginContext(397, 104, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                ");
            EndContext();
            BeginContext(501, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "53ba672a6dfc41faa6171fa25d998e6e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 511, "~/images/", 511, 9, true);
#line 13 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\ChiTietSanPham.cshtml"
AddHtmlAttributeValue("", 520, Html.DisplayFor(modelItem => item.HinhAnh.TenFile), 520, 51, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(613, 132, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"detail\">\r\n                    <p class=\"name\">");
            EndContext();
            BeginContext(746, 45, false);
#line 17 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\ChiTietSanPham.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TenSanPham));

#line default
#line hidden
            EndContext();
            BeginContext(791, 41, true);
            WriteLiteral("</p>\r\n                    <p class=\"gia\">");
            EndContext();
            BeginContext(833, 43, false);
#line 18 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\ChiTietSanPham.cshtml"
                              Write(Html.DisplayFor(modelItem => item.GiaBanLe));

#line default
#line hidden
            EndContext();
            BeginContext(876, 52, true);
            WriteLiteral(" Đ</p><br>\r\n                    <p class=\"mota m-2\">");
            EndContext();
            BeginContext(929, 39, false);
#line 19 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\ChiTietSanPham.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Mota));

#line default
#line hidden
            EndContext();
            BeginContext(968, 28, true);
            WriteLiteral("</p>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 996, "\"", 1065, 2);
            WriteAttributeValue("", 1003, "/sanpham/dathang/", 1003, 17, true);
#line 20 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\ChiTietSanPham.cshtml"
WriteAttributeValue("", 1020, Html.DisplayFor(modelItem => item.SanPhamId), 1020, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1066, 174, true);
            WriteLiteral("><button>Mua ngay</button></a>\r\n                    <p class=\"mt-5\">Giao hàng tận nơi <span>1800 9061</span></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 25 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\ChiTietSanPham.cshtml"
    }

#line default
#line hidden
            BeginContext(1247, 12, true);
            WriteLiteral("    \r\n</div>");
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
