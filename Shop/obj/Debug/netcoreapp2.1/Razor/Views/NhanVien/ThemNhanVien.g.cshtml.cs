#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\ThemNhanVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34c86c5bbefcc56201d12a3f0e594f12e77a3376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_ThemNhanVien), @"mvc.1.0.view", @"/Views/NhanVien/ThemNhanVien.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NhanVien/ThemNhanVien.cshtml", typeof(AspNetCore.Views_NhanVien_ThemNhanVien))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34c86c5bbefcc56201d12a3f0e594f12e77a3376", @"/Views/NhanVien/ThemNhanVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_ThemNhanVien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/NhanVien/styleThemNhanVien.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NhanVien", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThemNhanVien", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\ThemNhanVien.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(37, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a2172395530b44f3a18ba7930c09c398", async() => {
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
            BeginContext(110, 98, true);
            WriteLiteral("\r\n<div class=\"container parent\">\r\n    <h3 class=\"mb-4\" style=\"color:red\">Thêm nhân viên</h3>\r\n    ");
            EndContext();
            BeginContext(208, 2441, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a39163ef19b449ca03766545b16d8d3", async() => {
                BeginContext(281, 1920, true);
                WriteLiteral(@"
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""HoTen"">1. Họ tên</label>
                    <input type=""text"" class=""form-control"" id=""HoTen"" placeholder=""Nhập họ tên"" name=""HoTen"" autocomplete=""off"" required>
            </div>
            <div class=""form-group col-md-6"">
                <label for=""Email"">2. Email</label>
                <input type=""email"" class=""form-control"" id=""Email"" placeholder=""Nhập Email"" name=""Email"" autocomplete=""off"" required>
            </div>
        </div>
        <div class=""form-group"">
            <label for=""DiaChi"">3. Địa chỉ</label>
            <input type=""text"" class=""form-control w-100"" id=""DiaChi"" placeholder=""Nhập địa chỉ"" name=""DiaChi"" autocomplete=""off"" required>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""NgaySinh"">4. Ngày sinh</label>
                    <input type=""date"" class=""form-control"" id=""NgaySinh"" n");
                WriteLiteral(@"ame=""NgaySinh"" autocomplete=""off"" required>
            </div>
            <div class=""form-group col-md-6"">
                <label for=""Sdt"">5. Số điện thoại</label>
                <input type=""number"" class=""form-control"" id=""Sdt"" name=""Sdt"" autocomplete=""off"" required>
            </div>
        </div>
        <label>6. Tạo tài khoản</label>
        <div class=""d-flex form"">
            <div class=""form-group col-md-6"">
                <label for=""Username"">Username</label>
                <input type=""text"" class=""form-control w-100"" id=""Username"" placeholder=""Nhập Username"" name=""Username"" autocomplete=""off"" required>
                <label for=""Password"">Mật khẩu</label>
                <input type=""text"" class=""form-control w-100"" id=""Password"" placeholder=""Nhập mật khẩu"" name=""Password"" autocomplete=""off"" required>
            </div>
        </div>
        
");
                EndContext();
#line 42 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\ThemNhanVien.cshtml"
         if(ViewBag.success!=null){

#line default
#line hidden
                BeginContext(2238, 76, true);
                WriteLiteral("            <div class=\"alert alert-success\" role=\"alert\">\r\n                ");
                EndContext();
                BeginContext(2315, 15, false);
#line 44 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\ThemNhanVien.cshtml"
           Write(ViewBag.success);

#line default
#line hidden
                EndContext();
                BeginContext(2330, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 46 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\ThemNhanVien.cshtml"
        }

#line default
#line hidden
                BeginContext(2363, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 47 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\ThemNhanVien.cshtml"
         if(ViewBag.alert!=null){

#line default
#line hidden
                BeginContext(2398, 75, true);
                WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\">\r\n                ");
                EndContext();
                BeginContext(2474, 13, false);
#line 49 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\ThemNhanVien.cshtml"
           Write(ViewBag.alert);

#line default
#line hidden
                EndContext();
                BeginContext(2487, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 51 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\NhanVien\ThemNhanVien.cshtml"
        }

#line default
#line hidden
                BeginContext(2520, 122, true);
                WriteLiteral("        <input type=\"submit\" class=\"btn-submit\" value=\"&nbsp;Thêm\">\r\n        <i class=\"far fa-plus-circle icon\"></i>\r\n    ");
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
            BeginContext(2649, 8, true);
            WriteLiteral("\r\n</div>");
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
