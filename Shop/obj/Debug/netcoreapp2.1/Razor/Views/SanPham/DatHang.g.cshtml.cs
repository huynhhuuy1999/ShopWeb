#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e30ceacffa92781704a3e92ab135a625a63ae9f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_DatHang), @"mvc.1.0.view", @"/Views/SanPham/DatHang.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPham/DatHang.cshtml", typeof(AspNetCore.Views_SanPham_DatHang))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30ceacffa92781704a3e92ab135a625a63ae9f8", @"/Views/SanPham/DatHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_DatHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Models.Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Customer/SanPham/styleDatHang.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1301325c9f6147148d0b2bcd9c9e7602", async() => {
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
            BeginContext(113, 67, true);
            WriteLiteral("\r\n<div class=\"ml-5 mr-5\">\r\n  <div class=\"listCategory\">\r\n    <ul>\r\n");
            EndContext();
#line 6 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
       foreach(var item in ViewData["listPL"] as List<Phanloai>){

#line default
#line hidden
            BeginContext(247, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 261, "\"", 320, 2);
            WriteAttributeValue("", 268, "#loai+", 268, 6, true);
#line 7 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
WriteAttributeValue("", 274, Html.DisplayFor(modelItem => item.PhanLoaiId), 274, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(321, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(323, 42, false);
#line 7 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(365, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 8 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
        }

#line default
#line hidden
            BeginContext(387, 259, true);
            WriteLiteral(@"    </ul>
  </div>
  <div class=""order bg-white p-3"">
    <div class=""div-cart"">
      <a href=""/sanpham/XacNhanDatHang/""><button class=""w-100 btn-cart"">ĐẶT HÀNG</button></a>
    </div>
    <div class=""cart""><hr>
      <div class=""list-product-cart"">
");
            EndContext();
#line 17 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
         foreach(var item in ViewBag.listCart as List<Cart>){

#line default
#line hidden
            BeginContext(709, 42, true);
            WriteLiteral("                <div class=\'d-flex div-sp\'");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 751, "\"", 809, 1);
#line 18 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
WriteAttributeValue("", 756, Html.DisplayFor(itemModel => item.SanPham.SanPhamId), 756, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(810, 54, true);
            WriteLiteral(">\r\n                    <div class=\'sl rounded-circle\'>");
            EndContext();
            BeginContext(865, 42, false);
#line 19 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                                              Write(Html.DisplayFor(itemModel => item.Soluong));

#line default
#line hidden
            EndContext();
            BeginContext(907, 91, true);
            WriteLiteral("</div>\r\n                    <div class=\'inf ml-3\'>\r\n                    <span class=\'name\'>");
            EndContext();
            BeginContext(999, 53, false);
#line 21 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                                  Write(Html.DisplayFor(itemModel => item.SanPham.TenSanPham));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 57, true);
            WriteLiteral("</span><br>\r\n                    <span class=\'kichthuoc\'>");
            EndContext();
            BeginContext(1110, 57, false);
#line 22 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                                       Write(Html.DisplayFor(itemModel => item.Kichthuoc.TenKichThuoc));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 50, true);
            WriteLiteral("<span></div>\r\n                    <div class=\'gia\'");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1217, "\"", 1274, 1);
#line 23 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
WriteAttributeValue("", 1222, Html.DisplayFor(itemModel => item.SanPham.GiaBanLe), 1222, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1275, 33, true);
            WriteLiteral(">\r\n                        <span>");
            EndContext();
            BeginContext(1309, 43, false);
#line 24 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                         Write(Html.DisplayFor(itemModel => item.Tongtien));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 63, true);
            WriteLiteral(" ₫</span>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 27 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                }

#line default
#line hidden
            BeginContext(1434, 127, true);
            WriteLiteral("      </div>\r\n    </div><hr>\r\n    <div class=\"super-sum d-flex\">\r\n        <span>Tổng cộng</span>\r\n        <p class=\"final-sum\">");
            EndContext();
            BeginContext(1562, 16, false);
#line 32 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                        Write(ViewBag.tongtien);

#line default
#line hidden
            EndContext();
            BeginContext(1578, 56, true);
            WriteLiteral(" ₫</p>\r\n    </div>\r\n  </div>\r\n  <div class=\"main\">\r\n    ");
            EndContext();
            BeginContext(1634, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c997fe1ca2b40938a42c6af186e5269", async() => {
                BeginContext(1650, 135, true);
                WriteLiteral("\r\n      <i class=\"fal fa-search\"></i>\r\n      <input class=\"pl-5 w-100\" type=\"text\" name=\"search\" placeholder=\"Tìm kiếm sản phẩm\">\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1792, 31, true);
            WriteLiteral("\r\n    <div class=\"main-item\">\r\n");
            EndContext();
#line 41 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
       foreach (var item in ViewData["listPL"] as List<Phanloai>)
      {

#line default
#line hidden
            BeginContext(1899, 35, true);
            WriteLiteral("          <br><span class=\"tenloai\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1934, "\"", 1990, 2);
            WriteAttributeValue("", 1939, "loai+", 1939, 5, true);
#line 43 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
WriteAttributeValue("", 1944, Html.DisplayFor(itemModel => item.PhanLoaiId), 1944, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1991, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1993, 42, false);
#line 43 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                                                                                        Write(Html.DisplayFor(ModelItem => item.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(2035, 13, true);
            WriteLiteral("</span><br>\r\n");
            EndContext();
#line 44 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
          foreach(var item2 in ViewData["listSP"] as List<Sanpham>){
            if(item.PhanLoaiId==item2.PhanLoaiId){

#line default
#line hidden
            BeginContext(2170, 153, true);
            WriteLiteral("              <div class=\"sanpham p-1 bg-white\">\r\n                <div class=\"row\">\r\n                  <div class=\"col-md-2 img\">\r\n                      ");
            EndContext();
            BeginContext(2323, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1633585e895041d0b25be09fa692097b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2333, "~/images/", 2333, 9, true);
#line 49 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
AddHtmlAttributeValue("", 2342, Html.DisplayFor(modelItem => item2.HinhAnh.TenFile), 2342, 52, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2403, 135, true);
            WriteLiteral("\r\n                  </div>\r\n                  <div class=\"col-md-10\">\r\n                    <span class=\"tensp\">\r\n                      ");
            EndContext();
            BeginContext(2539, 45, false);
#line 53 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                 Write(Html.DisplayFor(itemdata => item2.TenSanPham));

#line default
#line hidden
            EndContext();
            BeginContext(2584, 35, true);
            WriteLiteral("\r\n                    </span><br>\r\n");
            EndContext();
#line 55 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                     if(item2.KhuyenMaiId!=null){

#line default
#line hidden
            BeginContext(2670, 33, true);
            WriteLiteral("                      <span><del>");
            EndContext();
            BeginContext(2704, 43, false);
#line 56 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                            Write(Html.DisplayFor(itemData => item2.GiaBanLe));

#line default
#line hidden
            EndContext();
            BeginContext(2747, 17, true);
            WriteLiteral(" ₫</del> &ensp; -");
            EndContext();
            BeginContext(2765, 57, false);
#line 56 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                                                                                         Write(Html.DisplayFor(itemData => item2.KhuyenMai.PhanTramGiam));

#line default
#line hidden
            EndContext();
            BeginContext(2822, 42, true);
            WriteLiteral("%</span><br>\r\n                      <span>");
            EndContext();
            BeginContext(2865, 41, false);
#line 57 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                       Write(Html.DisplayFor(itemData => item2.GiaGoc));

#line default
#line hidden
            EndContext();
            BeginContext(2906, 11, true);
            WriteLiteral(" ₫</span>\r\n");
            EndContext();
#line 58 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                    }
                    else{

#line default
#line hidden
            BeginContext(2967, 28, true);
            WriteLiteral("                      <span>");
            EndContext();
            BeginContext(2996, 43, false);
#line 60 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                       Write(Html.DisplayFor(itemData => item2.GiaBanLe));

#line default
#line hidden
            EndContext();
            BeginContext(3039, 15, true);
            WriteLiteral(" ₫</span><br>\r\n");
            EndContext();
#line 61 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
                    }

#line default
#line hidden
            BeginContext(3077, 80, true);
            WriteLiteral("                    \r\n                    <i class=\"fal fa-plus-circle add-cart\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3157, "\"", 3212, 2);
            WriteAttributeValue("", 3162, "icon+", 3162, 5, true);
#line 63 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
WriteAttributeValue("", 3167, Html.DisplayFor(itemData => item2.SanPhamId), 3167, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3213, 79, true);
            WriteLiteral("></i>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n");
            EndContext();
#line 67 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
            }
          }
      }

#line default
#line hidden
            BeginContext(3329, 703, true);
            WriteLiteral(@"    </div>
  </div>
</div>

<div class=""dialog"">
  <div class=""sanpham"">
    <div class=""img"">
      
    </div>
    <div class=""mota"">

    </div>
  </div>
  <div class=""size"">
    <p>Size</p>
  </div>
  <div class=""more"">
    <span>Số lượng</span><br>
    <div class=""footerr d-flex"">
      <div class=""quanlity d-flex"">
        
      </div>
      <div class=""btn-add-cart"">

      </div>
    </div>
  </div>
</div>
<script>
  $(document).on('click','.add-cart, .list-product-cart .div-sp',function(){
    let masp= $(this).attr(""id"");
    let bien=masp;
    if(masp.indexOf(""icon"")!==-1)
      bien = masp.slice(5);
    $.ajax({
        type:""POST"",
        url:""");
            EndContext();
            BeginContext(4033, 25, false);
#line 106 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
        Write(Url.Action("ThemGioHang"));

#line default
#line hidden
            EndContext();
            BeginContext(4058, 868, true);
            WriteLiteral(@""",
        data:{maspp:bien},
        success:function(data){
          for(let i=0;i<data.length;i++){
            $("".dialog .sanpham .img"").append(""<img src='/images/""+ data[i].hinhAnh.tenFile +""' alt=''>"");
            $('.dialog .sanpham .mota').append(""<span>""+data[i].tenSanPham+""</span>"");
          }
            $('.xxx').append(""<div id='over' style='display:none;width:100%;height:300%;background:#342e2e;position:absolute;top:0;left:0;opacity:0.6;z-index:999999' onclick=clickCloseDialog()></div>"");
            $('#over').fadeIn(300);
            $('.dialog').fadeIn(300,function(){
              $('.dialog').css('visibility','visible');
            });
            $('body').css('overflow','hidden');
        },
        error:function(err){
          alert(err);
        }
    });

      $.ajax({
        type:""POST"",
        url:""");
            EndContext();
            BeginContext(4927, 26, false);
#line 127 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
        Write(Url.Action("LayKichThuoc"));

#line default
#line hidden
            EndContext();
            BeginContext(4953, 3198, true);
            WriteLiteral(@""",
        data:{maspp:bien},
        success:function(data){
          for(let j=0;j<data.length;j++){
            let giaBanLe= data[j].sanPham.giaBanLe;
            let giaThem= data[j].giaThem;
            let tong=giaBanLe+giaThem;
            if(giaThem!==0){
              $("".dialog .size"").append(""<div><input type='radio' id=""+data[j].kichThuocid+"" value=""+tong+"" name='size' onclick=clickAddCart()>\
                <label id='label""+data[j].kichThuocid+""'>""+data[j].tenKichThuoc+"" (+""+giaThem+"" ₫)</label><div>"");
            }
            else{
              $("".dialog .size"").append(""<div><input type='radio' id=""+data[j].kichThuocid+"" value=""+tong+"" name='size' checked onclick=clickAddCart()>\
                <label id='label""+data[j].kichThuocid+""'>""+data[j].tenKichThuoc+""</label><div>"");
            }
          }
          let radioValue = $(""input[name='size']:checked"").val();
          $("".more .footerr .btn-add-cart"").append(""<button id=""+data[0].sanPham.sanPhamId+"" class='btn-ad");
            WriteLiteral(@"d'><span>THÊM VÀO GIỎ</span><span class='ml-4 price'>""+radioValue+"" ₫</span></button>"");
          $("".more .footerr .quanlity"").append(""\
            <i class='fal fa-minus-circle' onclick=clickSubtractQuanlity()></i>\
            <input type='number' name='soluong' value=1 min=0 readonly>\
            <i class='fal fa-plus-circle' onclick=clickPlusQuanlity()></i>"");
        },
        error:function(err){
          alert(err);
        }
      });
    });
  function clickCloseDialog(){
	  $('#over, .dialog').fadeOut(300 , function() {
      $('.dialog').css('visibility','hidden');
      $('body').css('overflow','visible');
	  });
     $('#over, .dialog .sanpham .img img, .dialog .sanpham .mota span').remove();
     $('.dialog .sanpham .mota br').remove();
     $("".dialog .size div"").remove();
     $("".more .footerr .btn-add-cart button"").remove();
     $("".more .footerr .quanlity i,.more .footerr .quanlity input"").remove();
  }
  function clickAddCart(){
      let radioValue = $(""input");
            WriteLiteral(@"[name='size']:checked"").val();
      let soluong= $(""input[name='soluong']"").val();
      let gia = radioValue*soluong;
      $("".price"").text(gia+"" Đ"");
  }
  function clickPlusQuanlity(){
    let radioValue = $(""input[name='size']:checked"").val();
    let soluong= $(""input[name='soluong']"").val();
    let changeSoluong=Number(soluong)+1;
    $(""input[name='soluong']"").val(changeSoluong);
    let gia = radioValue*changeSoluong;
    $("".price"").text(gia+"" Đ"");
  }
  function clickSubtractQuanlity(){
    let radioValue = $(""input[name='size']:checked"").val();
    let soluong= $(""input[name='soluong']"").val();
    let changeSoluong = Number(soluong);
    if(Number(soluong)!==0)
      changeSoluong=Number(soluong)-1;
    $(""input[name='soluong']"").val(changeSoluong);
    let gia = radioValue*changeSoluong;
    $("".price"").text(gia+"" Đ"");
  }
  $(document).on('click','.btn-add',function(){
    let idSP= Number($(this).attr(""id""));
    let soluong= $(""input[name='soluong']"").val();
    le");
            WriteLiteral("t idRadioValue=$(\"input[name=\'size\']:checked\").attr(\"id\");\r\n    let TongTien=0;\r\n    $.ajax({\r\n      type:\"POST\",\r\n      url:\"");
            EndContext();
            BeginContext(8152, 24, false);
#line 197 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
      Write(Url.Action("LuuGioHang"));

#line default
#line hidden
            EndContext();
            BeginContext(8176, 1527, true);
            WriteLiteral(@""",
      data:{maspp:idSP,soluong:soluong,kichthuocId:idRadioValue},
      success:function(data){
        $("".list-product-cart"").empty();
        $("".super-sum p"").remove();
          for(let i=0;i<data.length;i++){
            $("".list-product-cart"").append(""<div class='d-flex div-sp' id=""+data[i].sanPham.sanPhamId+""><div class='sl rounded-circle'>""+data[i].soluong+""</div>\
            <div class='inf ml-3'><span class='name'>""+data[i].sanPham.tenSanPham+""</span><br>\
            <span class='kichthuoc'>""+data[i].kichthuoc.tenKichThuoc+""<span></div>\
            <div class='gia' id=""+data[i].tongtien+""><span>""+data[i].tongtien+"" ₫</span></div></div>"");
            TongTien=TongTien+data[i].tongtien;
          }
        $("".super-sum"").append(""<p class='final-sum'>""+TongTien+"" ₫<p>"");
      },
      error:function(err){
        alert(err);
      }
    });
    
    $('#over, .dialog').fadeOut(300 , function() {
      $('.dialog').css('visibility','hidden');
      $('body').css('overflow'");
            WriteLiteral(@",'visible');
	  });
     $('#over, .dialog .sanpham .img img, .dialog .sanpham .mota span').remove();
     $('.dialog .sanpham .mota br').remove();
     $("".dialog .size div"").remove();
     $("".more .footerr .btn-add-cart button"").remove();
     $("".more .footerr .quanlity i,.more .footerr .quanlity input"").remove();
  });
  $(""input[name='search']"").change(function(){
    let char= $(this).val();
    if(char===""""){
      char=""xxx"";
    }
    $.ajax({
      type:""POST"",
      url:""");
            EndContext();
            BeginContext(9704, 28, false);
#line 233 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\SanPham\DatHang.cshtml"
      Write(Url.Action("TimKiemSanPham"));

#line default
#line hidden
            EndContext();
            BeginContext(9732, 820, true);
            WriteLiteral(@""",
      data:{key:char},
      success:function(data){
        $("".main-item"").empty();
        for(let i=0;i<data.length;i++){
          $("".main-item"").append(""<div class='sanpham p-1 bg-white'>\
            <div class='row'>\
              <div class='col-md-2 img'>\
                <img src='/images/""+data[i].hinhAnh.tenFile+""' alt=''>\
              </div>\
              <div class='col-md-10'>\
                <span class='tensp'>""+data[i].tenSanPham+""</span><br>\
                <span>""+data[i].giaBanLe+"" đ </span><br>\
                <i class='fal fa-plus-circle add-cart' id='icon+""+data[i].sanPhamId+""'></i>\
              </div>\
            </div>\
          </div>"");
        }
        
      },
      error:function(err){
        alert(err);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
