#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b135ba809fcb5edb2f8ab3cbdafcb5a57c8c572"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutCustomer), @"mvc.1.0.view", @"/Views/Shared/_LayoutCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LayoutCustomer.cshtml", typeof(AspNetCore.Views_Shared__LayoutCustomer))]
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
#line 1 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b135ba809fcb5edb2f8ab3cbdafcb5a57c8c572", @"/Views/Shared/_LayoutCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Customer/styleLayout.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootrap4/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fontawesome-pro-5.12.0-web/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("xxx"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(60, 794, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d75a13e76c24eae9d860f3c2d9cb33a", async() => {
                BeginContext(66, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(188, 17, false);
#line 7 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(205, 21, true);
                WriteLiteral(" - Shop</title>\r\n    ");
                EndContext();
                BeginContext(226, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9e38370e441422980ea2627150fbd8a", async() => {
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
                BeginContext(289, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(295, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e4d7821d50a4aac8a3da8e303f0c175", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(360, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(366, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bcf351f13b904340a19a986858433e58", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(443, 404, true);
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
	<script src=""https://cdn.datatables.net/1.10.21/js/dataTables.bootstrap4.min.js""></script>
    <link href=""https://fonts.googleapis.com/css2?family=Playfair+Display:ital,wght@1,600&display=swap"" rel=""stylesheet"">
");
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
            BeginContext(854, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(856, 3219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0856d9ccebb44bb4b09912d9ffb21d5e", async() => {
                BeginContext(874, 230, true);
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <ul class=\"menu\">\r\n            <li><a href=\"/\">Milk Tea Store</a></li>\r\n            <li><a href=\"/home/index\">Trang chủ</a></li>\r\n            <li><a href=\"/sanpham/thucdon\">Thực đơn</a></li>\r\n\r\n");
                EndContext();
#line 23 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
             if (Context.Session.GetString("username")!=null)
            {

#line default
#line hidden
                BeginContext(1182, 44, true);
                WriteLiteral("                <li>\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1226, "\"", 1303, 2);
                WriteAttributeValue("", 1233, "/khachhang/xemthongtinkhachhang/", 1233, 32, true);
#line 26 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
WriteAttributeValue("", 1265, Context.Session.GetString("username"), 1265, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1304, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1306, 37, false);
#line 26 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
                                                                                                Write(Context.Session.GetString("username"));

#line default
#line hidden
                EndContext();
                BeginContext(1343, 78, true);
                WriteLiteral("</a>\r\n                    <ul class=\"submenu\">\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1421, "\"", 1498, 2);
                WriteAttributeValue("", 1428, "/khachhang/xemthongtinkhachhang/", 1428, 32, true);
#line 28 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
WriteAttributeValue("", 1460, Context.Session.GetString("username"), 1460, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1499, 59, true);
                WriteLiteral(">Thông tin cá nhân</a></li>\r\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1558, "\"", 1639, 2);
                WriteAttributeValue("", 1565, "/hoadon/thongtindonhangcuakhachhang/", 1565, 36, true);
#line 29 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
WriteAttributeValue("", 1601, Context.Session.GetString("username"), 1601, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1640, 155, true);
                WriteLiteral(">Thông tin đơn hàng</a></li>\r\n                        <li><a href=\"/taikhoan/logout\">Đăng xuất</a></li>\r\n                    </ul>\r\n                </li>\r\n");
                EndContext();
#line 33 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
            }
            else{

#line default
#line hidden
                BeginContext(1829, 69, true);
                WriteLiteral("                <li><a href=\"/taikhoan/dangnhap\">Đăng nhập</a></li>\r\n");
                EndContext();
#line 36 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
            }

#line default
#line hidden
                BeginContext(1913, 72, true);
                WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"abc bg-light pb-3\">\r\n        ");
                EndContext();
                BeginContext(1986, 12, false);
#line 40 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1998, 2026, true);
                WriteLiteral(@"
    </div>
    <div class=""footer"">
        <div class=""container pb-2"">
            <div class=""row w-100"">
                <div class=""col-md-3"">
                    <h2>Milk Tea Store</h2>
                </div>
                <div class=""col-md-3"">
                    <h3>About</h3>
                    <div class=""mt-2"">
                        <p>Về chúng tôi</p>
                        <p>Hạt cà phê..</p>
                        <p>Blog</p>
                        <p>Cơ hội nghề nghiệp</p>
                        <p>Cửa hàng</p>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <h3>ALWAYS-ON SUPPORT</h3>
                    <div class=""mt-2"">
                        <p>Delivery 1800 6936 (07:00-21:00)</p>
                        <p>Support 02871 087 088 (07:00-21:00)</p>
                    </div>
                    <h3 class=""mt-2"">ADDRESS</h3>
                    <div class=""mt-2"">
                        <p>62 Tra");
                WriteLiteral(@"n Quang Khai, Tan Dinh, Quan 1 Ho Chi Minh, Vietnam</p>
                        <p>02871 087 088</p>
                        <p>hi@abcshop.vn</p>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <h3>DELIVERY</h3>
                    <div class=""mt-2"">
                        <p>Shipping methods</p>
                        <p>Payment</p>
                        <p>Cash voucher</p>
                        <p>Return</p>
                        <p>Exchange</p>
                    </div>
                </div>
            </div>
            <div style=""border-bottom:1px solid white;width:100%"" class=""mt-3""></div>
            <div class=""row pt-2"">
                <div class=""col-md-6"">Copyright &copy 2020 The MilkTea House. All rights reserved.</div>
                <div class=""col-md-6"">
                    Privacy Policy | Terms of Use
                </div>
            </div>
        </div>
    </div>
    ");
                EndContext();
                BeginContext(4025, 41, false);
#line 91 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutCustomer.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(4066, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4075, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
