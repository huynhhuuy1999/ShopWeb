#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78247bb5ecb055c11d23ec146b8ac4fed9371ed1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHang_SuaKhachHang), @"mvc.1.0.view", @"/Views/KhachHang/SuaKhachHang.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KhachHang/SuaKhachHang.cshtml", typeof(AspNetCore.Views_KhachHang_SuaKhachHang))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78247bb5ecb055c11d23ec146b8ac4fed9371ed1", @"/Views/KhachHang/SuaKhachHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_KhachHang_SuaKhachHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Models.Khachhang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/KhachHang/styleSuaKhachHang.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "KhachHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "suakhachhang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(68, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88084d31062642eca2f19cc05590f2cc", async() => {
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
            BeginContext(144, 146, true);
            WriteLiteral("\r\n<div class=\"container mb-5 parent\">\r\n    <div class=\"mb-4\">\r\n        <h2><i class=\"far fa-edit\"></i> Thông tin khách hàng</h2>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(290, 2369, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b528a84c9ad74d22bc9a717effbdbeb8", async() => {
                BeginContext(364, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
         foreach (var item in ViewBag.kh as List<Khachhang>)
        {

#line default
#line hidden
                BeginContext(439, 37, true);
                WriteLiteral("            <input name=\"KhachHangId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 476, "\"", 531, 1);
#line 13 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
WriteAttributeValue("", 484, Html.DisplayFor(itemModel => item.KhachHangId), 484, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(532, 269, true);
                WriteLiteral(@" hidden/>
            <div class=""form-row"">
                <div class=""form-group col-md-6"">
                    <label for=""HoTen"">1. Họ tên</label>
                        <input type=""text"" class=""form-control"" id=""HoTen"" placeholder=""Nhập họ tên"" name=""HoTen""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 801, "\'", 850, 1);
#line 17 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
WriteAttributeValue("", 809, Html.DisplayFor(itemModel => item.HoTen), 809, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(851, 272, true);
                WriteLiteral(@" autocomplete=""off"" required>
                </div>
                <div class=""form-group col-md-6"">
                    <label for=""Email"">2. Email</label>
                    <input type=""email"" class=""form-control"" id=""Email"" placeholder=""Nhập Email"" name=""Email""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 1123, "\'", 1172, 1);
#line 21 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
WriteAttributeValue("", 1131, Html.DisplayFor(itemModel => item.Email), 1131, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1173, 283, true);
                WriteLiteral(@" autocomplete=""off"" required>
                </div>
            </div>
            <div class=""form-group"">
                <label for=""DiaChi"">3. Địa chỉ</label>
                <input type=""text"" class=""form-control w-100"" id=""DiaChi"" placeholder=""Nhập địa chỉ"" name=""DiaChi""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 1456, "\'", 1506, 1);
#line 26 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
WriteAttributeValue("", 1464, Html.DisplayFor(itemModel => item.DiaChi), 1464, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1507, 295, true);
                WriteLiteral(@" autocomplete=""off"" required>
            </div>
            <div class=""form-row"">
                <div class=""form-group col-md-6"">
                    <label for=""NgaySinh"">4. Ngày sinh</label>
                        <input type=""date"" class=""form-control"" id=""NgaySinh"" name=""NgaySinh""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 1802, "\'", 1826, 1);
#line 31 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
WriteAttributeValue("", 1810, ViewBag.newDate, 1810, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1827, 250, true);
                WriteLiteral(" autocomplete=\"off\" required>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label for=\"Sdt\">5. Số điện thoại</label>\r\n                    <input type=\"number\" class=\"form-control\" id=\"Sdt\" name=\"Sdt\"");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 2077, "\'", 2124, 1);
#line 35 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
WriteAttributeValue("", 2085, Html.DisplayFor(itemModel => item.Sdt), 2085, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2125, 75, true);
                WriteLiteral(" autocomplete=\"off\" required>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 38 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
        }

#line default
#line hidden
                BeginContext(2211, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 39 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
         if(ViewBag.success!=null){

#line default
#line hidden
                BeginContext(2248, 76, true);
                WriteLiteral("            <div class=\"alert alert-success\" role=\"alert\">\r\n                ");
                EndContext();
                BeginContext(2325, 15, false);
#line 41 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
           Write(ViewBag.success);

#line default
#line hidden
                EndContext();
                BeginContext(2340, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 43 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
        }

#line default
#line hidden
                BeginContext(2373, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 44 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
         if(ViewBag.err!=null){

#line default
#line hidden
                BeginContext(2406, 75, true);
                WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\">\r\n                ");
                EndContext();
                BeginContext(2482, 11, false);
#line 46 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
           Write(ViewBag.err);

#line default
#line hidden
                EndContext();
                BeginContext(2493, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 48 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\SuaKhachHang.cshtml"
        }

#line default
#line hidden
                BeginContext(2526, 126, true);
                WriteLiteral("        <input type=\"submit\" class=\"btn-submit\" value=\"&nbsp; Cập nhật\">\r\n        <i class=\"far fa-pencil-alt icon\"></i>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2659, 14, true);
            WriteLiteral("\r\n    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Models.Khachhang> Html { get; private set; }
    }
}
#pragma warning restore 1591
