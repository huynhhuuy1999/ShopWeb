#pragma checksum "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\ThongKe\DoanhThu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193acdc1ba0072633b504cc957f2ce2536891f23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongKe_DoanhThu), @"mvc.1.0.view", @"/Views/ThongKe/DoanhThu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ThongKe/DoanhThu.cshtml", typeof(AspNetCore.Views_ThongKe_DoanhThu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193acdc1ba0072633b504cc957f2ce2536891f23", @"/Views/ThongKe/DoanhThu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_ThongKe_DoanhThu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Models.Thongke>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin/ThongKe/styleDoanhThu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\ThongKe\DoanhThu.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(78, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4cb847756f32448f8b73dc3ace0cd5ff", async() => {
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
            BeginContext(148, 126, true);
            WriteLiteral("\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.5.0/Chart.min.js\"></script>\r\n<div class=\"container table1\">\r\n");
            EndContext();
            BeginContext(394, 37, true);
            WriteLiteral("    <h2>Thống kê doanh thu</h2>\r\n    ");
            EndContext();
            BeginContext(431, 792, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cecb1d7981b743e39ebf68b7f05a4d28", async() => {
                BeginContext(451, 765, true);
                WriteLiteral(@"
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""TuNgay"">Từ ngày</label>
                <input type=""date"" name=""TuNgay"" id=""TuNgay"" class=""form-control"" required>
            </div>
            <div class=""form-group col-md-6"">
                <label for=""DenNgay"">Đến ngày</label>
                <input type=""date"" name=""DenNgay"" id=""DenNgay"" class=""form-control"" required>
            </div>
        </div>
        <div class=""d-flex"">
            <input type=""button"" name=""ThongKe"" value=""Thống kê"" class=""btn btn-warning text-white m-3"" id=""thongke"">
            <input type=""button"" name=""BieuDo"" value=""Biểu đồ"" class=""btn btn-success text-white m-3"" id=""bieudo"">
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1223, 1319, true);
            WriteLiteral(@"
    <div class=""cover-chart"" style=""width:700px;height: 700px;margin-left: 200px;"">
        <canvas id=""bar-chart"" width=""500"" height=""500""></canvas>
    </div>
    <div class=""table-thongke"">
        <table class=""table table-sm table-bordered table-striped table-hover mt-3 "">
            <thead>
                <tr class=""text-center"">
                    <th>Năm</th>
                    <th>Tháng</th>
                    <th>Doanh thu</th>
                </tr>
            </thead>
            <tbody class=""content-thongke text-center"">
                
            </tbody>
        </table>
    </div>
    
</div>
<script>
    $(document).ready(function () {
        $("".table-thongke"").css(""display"",""none"");
        $("".cover-chart"").css(""display"",""none"");
		$(""#thongke"").click(()=>{
            let TuNgay = $(""#TuNgay"").val();
            let DenNgay = $(""#DenNgay"").val();
            if(TuNgay=="""" || DenNgay==""""){
                alert(""Bạn chưa chọn thời gian thống kê"");
   ");
            WriteLiteral(@"         }
            else{
                $("".cover-chart"").css(""display"",""none"");
                $("".table-thongke"").css(""display"",""block"");
                $("".content-thongke"").children().remove();
                $.ajax({
                    type:""POST"",
                    url:""");
            EndContext();
            BeginContext(2543, 21, false);
#line 61 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\ThongKe\DoanhThu.cshtml"
                    Write(Url.Action("ThongKe"));

#line default
#line hidden
            EndContext();
            BeginContext(2564, 1076, true);
            WriteLiteral(@""",
                    data:{tungay:TuNgay, denngay:DenNgay},
                    success:function(data){
                        for(let i = 0; i< data.length;i++){
                            $("".content-thongke"").append(""<tr><td>""+data[i].nam+""</td>\
                                            <td>""+data[i].thang+""</td><td>""+data[i].doanhThu+""</td></tr>"");
                        }
                    },
                    error:function(err){
                        alert(err);
                    }
                });
            };
        });
            

        $(""#bieudo"").click(()=>{
            let TuNgay = $(""#TuNgay"").val();
            let DenNgay = $(""#DenNgay"").val();
            if(TuNgay=="""" || DenNgay==""""){
                alert(""Bạn chưa chọn thời gian thống kê"");
            }
            else{
                $("".cover-chart"").css(""display"",""block"");
                $("".table-thongke"").css(""display"",""none"");
                
                $.ajax({
        ");
            WriteLiteral("            type:\"POST\",\r\n                    url: \"");
            EndContext();
            BeginContext(3641, 21, false);
#line 89 "E:\XayDungHTTPTrenFramework\New folder\Shop\Views\ThongKe\DoanhThu.cshtml"
                     Write(Url.Action("ThongKe"));

#line default
#line hidden
            EndContext();
            BeginContext(3662, 2029, true);
            WriteLiteral(@""",
                    data:{tungay:TuNgay, denngay:DenNgay},
                    success:(data)=>{
                        let thang = [];
                        let doanhThu =[];
                        for(let i =0 ;i < data.length;i++){
                            thang.push(data[i].thang);
                            doanhThu.push(data[i].doanhThu);
                        }
                        new Chart(document.getElementById(""bar-chart""), {
                                type: 'bar',
                                data: {
                                    labels: thang,
                                    datasets: [
                                        {
                                            label: ""Doanh thu"",
                                            backgroundColor: [""#e1bc10""],
                                            data: doanhThu
                                        }
                                    ]
                                },
       ");
            WriteLiteral(@"                         options: {
                                    legend: { display: false },
                                    title: {
                                        display: true,
                                        text: 'Thống kê doanh thu'
                                    },
                                    responsive:true,
                                    scales: {
                                            yAxes: [{
                                                ticks: {
                                                    beginAtZero: true
                                                }
                                            }]
                                        }
                                }
                            });
                    },
                    error:(err)=>{
                        alert(err);
                    }
                });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Models.Thongke>> Html { get; private set; }
    }
}
#pragma warning restore 1591