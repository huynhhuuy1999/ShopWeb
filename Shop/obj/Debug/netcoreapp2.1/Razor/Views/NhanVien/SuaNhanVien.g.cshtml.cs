#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a522ad77bcc148add6c7b68f4420d44cd279c2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_SuaNhanVien), @"mvc.1.0.view", @"/Views/NhanVien/SuaNhanVien.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NhanVien/SuaNhanVien.cshtml", typeof(AspNetCore.Views_NhanVien_SuaNhanVien))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a522ad77bcc148add6c7b68f4420d44cd279c2c", @"/Views/NhanVien/SuaNhanVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_SuaNhanVien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Models.Nhanvien>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/NhanVien/styleSuaNhanVien.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Nhanvien", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "suanhanvien", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(67, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d442bcc44ace43bba1b49802f0f3953f", async() => {
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
            BeginContext(141, 145, true);
            WriteLiteral("\r\n<div class=\"container mb-5 parent\">\r\n    <div class=\"mb-4\">\r\n        <h2><i class=\"far fa-edit\"></i> Thông tin nhân viên</h2>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(286, 2437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac1fc1b4089a432284b9ad81e29a4349", async() => {
                BeginContext(358, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
         foreach (var item in ViewBag.nhanvien as List<Nhanvien>)
        {

#line default
#line hidden
                BeginContext(438, 36, true);
                WriteLiteral("            <input name=\"NhanVienId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 474, "\"", 528, 1);
#line 13 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
WriteAttributeValue("", 482, Html.DisplayFor(itemModel => item.NhanVienId), 482, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(529, 269, true);
                WriteLiteral(@" hidden/>
            <div class=""form-row"">
                <div class=""form-group col-md-6"">
                    <label for=""HoTen"">1. Họ tên</label>
                        <input type=""text"" class=""form-control"" id=""HoTen"" placeholder=""Nhập họ tên"" name=""HoTen""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 798, "\'", 847, 1);
#line 17 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
WriteAttributeValue("", 806, Html.DisplayFor(itemModel => item.HoTen), 806, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(848, 272, true);
                WriteLiteral(@" autocomplete=""off"" required>
                </div>
                <div class=""form-group col-md-6"">
                    <label for=""Email"">2. Email</label>
                    <input type=""email"" class=""form-control"" id=""Email"" placeholder=""Nhập Email"" name=""Email""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 1120, "\'", 1169, 1);
#line 21 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
WriteAttributeValue("", 1128, Html.DisplayFor(itemModel => item.Email), 1128, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1170, 283, true);
                WriteLiteral(@" autocomplete=""off"" required>
                </div>
            </div>
            <div class=""form-group"">
                <label for=""DiaChi"">3. Địa chỉ</label>
                <input type=""text"" class=""form-control w-100"" id=""DiaChi"" placeholder=""Nhập địa chỉ"" name=""DiaChi""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 1453, "\'", 1503, 1);
#line 26 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
WriteAttributeValue("", 1461, Html.DisplayFor(itemModel => item.DiaChi), 1461, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1504, 329, true);
                WriteLiteral(@" autocomplete=""off"" required>
            </div>
            <div class=""form-row"">
                <div class=""form-group col-md-6"">
                    <label for=""NgaySinh"">4. Ngày sinh</label>
                        <input type=""date"" class=""form-control"" id=""NgaySinh"" 
                                name=""NgaySinh""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 1833, "\'", 1857, 1);
#line 32 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
WriteAttributeValue("", 1841, ViewBag.newDate, 1841, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1858, 283, true);
                WriteLiteral(@"
                                autocomplete=""off"" required>
                </div>
                <div class=""form-group col-md-6"">
                    <label for=""Sdt"">5. Số điện thoại</label>
                    <input type=""number"" class=""form-control"" id=""Sdt"" name=""Sdt""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 2141, "\'", 2188, 1);
#line 37 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
WriteAttributeValue("", 2149, Html.DisplayFor(itemModel => item.Sdt), 2149, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2189, 75, true);
                WriteLiteral(" autocomplete=\"off\" required>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 40 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
        }

#line default
#line hidden
                BeginContext(2275, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 41 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
         if(ViewBag.success!=null){

#line default
#line hidden
                BeginContext(2312, 76, true);
                WriteLiteral("            <div class=\"alert alert-success\" role=\"alert\">\r\n                ");
                EndContext();
                BeginContext(2389, 15, false);
#line 43 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
           Write(ViewBag.success);

#line default
#line hidden
                EndContext();
                BeginContext(2404, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 45 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
        }

#line default
#line hidden
                BeginContext(2437, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 46 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
         if(ViewBag.err!=null){

#line default
#line hidden
                BeginContext(2470, 75, true);
                WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\">\r\n                ");
                EndContext();
                BeginContext(2546, 11, false);
#line 48 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
           Write(ViewBag.err);

#line default
#line hidden
                EndContext();
                BeginContext(2557, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 50 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\SuaNhanVien.cshtml"
        }

#line default
#line hidden
                BeginContext(2590, 126, true);
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
            BeginContext(2723, 14, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Models.Nhanvien> Html { get; private set; }
    }
}
#pragma warning restore 1591
