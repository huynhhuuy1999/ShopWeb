#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8a739ae6e115e78bb9035482feb470067686447"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHang_XemThongTinKhachHang), @"mvc.1.0.view", @"/Views/KhachHang/XemThongTinKhachHang.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KhachHang/XemThongTinKhachHang.cshtml", typeof(AspNetCore.Views_KhachHang_XemThongTinKhachHang))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8a739ae6e115e78bb9035482feb470067686447", @"/Views/KhachHang/XemThongTinKhachHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_KhachHang_XemThongTinKhachHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Models.Khachhang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Customer/KhachHang/styleXemThongTinKhachHang.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "KhachHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LuuThongTinKhachHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "700c7ec48b854cef9c1c30321518ebbc", async() => {
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
            BeginContext(118, 97, true);
            WriteLiteral("\r\n<div class=\"container mb-5\">\r\n    <div>\r\n        <h2>Thông tin tài khoản</h2>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(215, 2982, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7115a8d31e47e1bd628e4fad839236", async() => {
                BeginContext(297, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
         foreach (var item in ViewBag.kh as List<Khachhang>)
        {

#line default
#line hidden
                BeginContext(372, 255, true);
                WriteLiteral("            <div class=\"form-row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label for=\"HoTen\">Họ tên</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"HoTen\" placeholder=\"Nhập họ tên\" name=\"HoTen\"");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 627, "\'", 676, 1);
#line 13 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
WriteAttributeValue("", 635, Html.DisplayFor(itemModel => item.HoTen), 635, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(677, 269, true);
                WriteLiteral(@" autocomplete=""off"" required>
                </div>
                <div class=""form-group col-md-6"">
                    <label for=""Email"">Email</label>
                    <input type=""email"" class=""form-control"" id=""Email"" placeholder=""Nhập Email"" name=""Email""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 946, "\'", 995, 1);
#line 17 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
WriteAttributeValue("", 954, Html.DisplayFor(itemModel => item.Email), 954, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(996, 281, true);
                WriteLiteral(@" autocomplete=""off"" required> 
                </div>
            </div>
            <div class=""form-group"">
                <label for=""DiaChi"">Địa chỉ</label>
                <input type=""text"" class=""form-control w-100"" id=""DiaChi"" placeholder=""Nhập địa chỉ"" name=""DiaChi""");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 1277, "\'", 1327, 1);
#line 22 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
WriteAttributeValue("", 1285, Html.DisplayFor(itemModel => item.DiaChi), 1285, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1328, 292, true);
                WriteLiteral(@" autocomplete=""off"" required>
            </div>
            <div class=""form-row"">
                <div class=""form-group col-md-6"">
                    <label for=""NgaySinh"">Ngày sinh</label>
                        <input type=""date"" class=""form-control"" id=""NgaySinh"" name=""NgaySinh""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1620, "\"", 1665, 1);
#line 27 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
WriteAttributeValue("", 1628, item.NgaySinh.ToString("yyyy-MM-dd"), 1628, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1666, 247, true);
                WriteLiteral(" autocomplete=\"off\" required>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label for=\"Sdt\">Số điện thoại</label>\r\n                    <input type=\"number\" class=\"form-control\" id=\"Sdt\" name=\"Sdt\"");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 1913, "\'", 1960, 1);
#line 31 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
WriteAttributeValue("", 1921, Html.DisplayFor(itemModel => item.Sdt), 1921, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1961, 486, true);
                WriteLiteral(@" autocomplete=""off"" required>
                </div>
            </div>
            <label for=""changePass"">Đổi mật khẩu: </label><input type=""checkbox"" class=""ml-2"" value=""check"" name=""changePassword""><br>
            <div class=""form-group"">
                <label for=""oldpassword"">Mật khẩu cũ</label>
                <input type=""password"" class=""form-control w-100"" id=""oldpassword"" placeholder=""Nhập mật khẩu cũ"" name=""oldpassword"" autocomplete=""off"" disabled="""" required>
");
                EndContext();
#line 38 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
                 if(ViewBag.err!=null){

#line default
#line hidden
                BeginContext(2488, 96, true);
                WriteLiteral("                    <div class=\"alert alert-danger mt-2\" role=\"alert\">\r\n                        ");
                EndContext();
                BeginContext(2585, 11, false);
#line 40 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
                   Write(ViewBag.err);

#line default
#line hidden
                EndContext();
                BeginContext(2596, 30, true);
                WriteLiteral("\r\n                    </div>\r\n");
                EndContext();
#line 42 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
                }

#line default
#line hidden
                BeginContext(2645, 309, true);
                WriteLiteral(@"            </div>
            <div class=""form-group"">
                <label for=""newPass"">Mật khẩu mới</label>
                <input type=""password"" class=""form-control w-100"" id=""newPass"" placeholder=""Nhập mật khẩu mới"" name=""newPassword"" autocomplete=""off"" disabled="""" required>
            </div>
");
                EndContext();
#line 48 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
        }

#line default
#line hidden
                BeginContext(2965, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 49 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
         if(ViewBag.success!=null){

#line default
#line hidden
                BeginContext(3002, 76, true);
                WriteLiteral("            <div class=\"alert alert-success\" role=\"alert\">\r\n                ");
                EndContext();
                BeginContext(3079, 15, false);
#line 51 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
           Write(ViewBag.success);

#line default
#line hidden
                EndContext();
                BeginContext(3094, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 53 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\KhachHang\XemThongTinKhachHang.cshtml"
        }

#line default
#line hidden
                BeginContext(3127, 63, true);
                WriteLiteral("        <input type=\"submit\" class=\"btn-luu\" value=\"Lưu\">\r\n    ");
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
            BeginContext(3197, 372, true);
            WriteLiteral(@"
    
</div>
<script>
    $(document).ready(function(){
			$('input[type=checkbox]').change(function(){
				if ($(this).is("":checked"")) {
					$('#oldpassword').removeAttr('disabled');
					$('#newPass').removeAttr('disabled');
				}
				else{
					$('#oldpassword').attr('disabled','');
					$('#newPass').attr('disabled','');
				}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Models.Khachhang> Html { get; private set; }
    }
}
#pragma warning restore 1591
