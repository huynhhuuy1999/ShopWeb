#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bea1ba6710bea866c47ccb9d09556fdc00e5759"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAdmin), @"mvc.1.0.view", @"/Views/Shared/_LayoutAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LayoutAdmin.cshtml", typeof(AspNetCore.Views_Shared__LayoutAdmin))]
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
#line 1 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutAdmin.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bea1ba6710bea866c47ccb9d09556fdc00e5759", @"/Views/Shared/_LayoutAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/styleLayout.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fontawesome-pro-5.12.0-web/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootrap4/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(72, 844, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c517bd88bc438c857b1d125dc87e1c", async() => {
                BeginContext(78, 132, true);
                WriteLiteral("\r\n\t<meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n\t<title>Document</title>\r\n\t");
                EndContext();
                BeginContext(210, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8af8c0f45890445bbe9e7f25ebbd2b31", async() => {
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
                BeginContext(268, 276, true);
                WriteLiteral(@"
	<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
	<script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
	<script src=""https://cdn.datatables.net/1.10.21/js/dataTables.bootstrap4.min.js""></script>
	");
                EndContext();
                BeginContext(544, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71967da4951045d2915bd6a3cb4c9854", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(619, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(625, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9644c45b6144856b3fa32c072b523f5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(690, 219, true);
                WriteLiteral("\r\n\t<link rel=\"stylesheet\" href=\"https://s3-us-west-2.amazonaws.com/s.cdpn.io/3/wtf-forms.css\">\r\n\t<link href=\"https://fonts.googleapis.com/css2?family=Playfair+Display:ital,wght@1,600&display=swap\" rel=\"stylesheet\">\r\n\t\r\n");
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
            BeginContext(916, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(918, 2544, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff70c4bae9324eb3a2c2f4a9bd2fc9c8", async() => {
                BeginContext(924, 1167, true);
                WriteLiteral(@"
	<div id=""mySidebar"" class=""sidebar"">
		<div class=""box"">
			  <a href=""/sanpham/xemdanhsachsanpham"" class=""menu""><i class=""fas fa-cheese""></i>&ensp; Sản phẩm</a>
			  <a href=""/khuyenmai/xemdanhsachkhuyenmai"" class=""menu""><i class=""fas fa-tag""></i>&ensp; Khuyến mãi</a>
			  <a href=""/nhanvien/xemdanhsachnhanvien"" class=""menu""><i class=""fad fa-users""></i>&nbsp; Nhân viên</a>
			  <a href=""/khachhang/danhsachkhachhang"" class=""menu""><i class=""fas fa-user""></i>&ensp; Khách hàng</a>
			  <button class=""dropdown-btn menu"">
			  	<i class=""far fa-file-invoice-dollar""></i>&nbsp;&nbsp;&nbsp; Hóa đơn
			  </button>
			  <div class=""dropdown-container menu"">
			    <a href=""/hoadon/Xemdanhsachhoadon"">Xem danh sách</a>
			    <a href=""/hoadon/xemdanhsachhoadonchuaxuly"">Danh sách chưa xử lý</a>
			    <a href=""/hoadon/xemdanhsachhoadonyeucauhuy"">Danh sách yêu cầu hủy</a>
			  </div>
			  <a href=""/thongke/doanhthu"" class=""menu""><i class=""fad fa-money-bill-alt""></i>&nbsp; Thống kê</a>
		</div>
		
	</div");
                WriteLiteral(">\r\n\t<div class=\"header\">\r\n\t\t<div class=\"noidung\">\r\n\t\t\t<h3>Milk Tea Store</h3>\r\n\t\t\t<ul class=\"ul1\">\r\n\t\t\t\t<li class=\"username\">\r\n\t\t\t\t\t<a href=\"\">");
                EndContext();
                BeginContext(2092, 38, false);
#line 43 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutAdmin.cshtml"
                          Write(Context.Session.GetString("username1"));

#line default
#line hidden
                EndContext();
                BeginContext(2130, 45, true);
                WriteLiteral("</a>\r\n\t\t\t\t\t<ul class=\"submenu\">\r\n\t\t\t\t\t\t<li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2175, "\"", 2251, 2);
                WriteAttributeValue("", 2182, "/nhanvien/xemthongtinnhanvien/", 2182, 30, true);
#line 45 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutAdmin.cshtml"
WriteAttributeValue("", 2212, Context.Session.GetString("username1"), 2212, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2252, 337, true);
                WriteLiteral(@""">Thông tin cá nhân</a></li>
						<li><a href=""/taikhoan/logout"">Đăng xuất</a></li>
					</ul>
				</li>
			</ul>
		</div>
		
	</div>

	<div id=""main"" style=""position: fixed;top: 0"">
	  <button class=""openbtn""><i class=""fas fa-align-left""></i></button>
	</div>
	
	<div id=""content"" style=""transition: margin-left .5s;"">
		");
                EndContext();
                BeginContext(2590, 12, false);
#line 59 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\Shared\_LayoutAdmin.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2602, 853, true);
                WriteLiteral(@"
	</div>

	<script>
		var dropdown = document.getElementsByClassName(""dropdown-btn"");
		var i;
		for (i = 0; i < dropdown.length; i++) {
		  dropdown[i].addEventListener(""click"", function() {
		    this.classList.toggle(""active"");
		    var dropdownContent = this.nextElementSibling;
		    if (dropdownContent.style.display === ""block"") {
		      dropdownContent.style.display = ""none"";
		    } else {
		      dropdownContent.style.display = ""block"";
		    }
		  });
		}
		$(document).ready(function(){
			let i =0;
			$("".openbtn"").click(function(){
				if(i===1){
					$(""#mySidebar"").css('width','250px');
					$(""#main,#content"").css('margin-left',""250px"");
					i=0;
				}
				else{
					$(""#mySidebar"").css('width','0');
					$(""#main,#content"").css('margin-left',""0"");
					i=1;
				}
			});
		});
		
	</script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3462, 11, true);
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
