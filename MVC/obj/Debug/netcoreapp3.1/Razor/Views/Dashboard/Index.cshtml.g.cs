#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57bc2be3b32aa6b211cb9f26dcb0d26048e9fd52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57bc2be3b32aa6b211cb9f26dcb0d26048e9fd52", @"/Views/Dashboard/Index.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Dashboard\Index.cshtml"
   Layout = "_LayoutAdmin";
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Container fluid  -->
<!-- ============================================================== -->
<div class=""container-fluid"">
    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class=""row page-titles"">
        <div class=""col-md-6 col-8 align-self-center"">
            <h3 class=""text-themecolor m-b-0 m-t-0"">Dashboard</h3>
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item active"">Dashboard</li>
            </ol>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Start Page Content -->
    <!-- ================================================");
            WriteLiteral(@"============== -->
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""m-t-40"" style=""height:200px;"" id=""chartBar""></div>
                </div>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End PAge Content -->
    <!-- ============================================================== -->
</div>
<!-- ============================================================== -->
<!-- End Container fluid  -->

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $.toast({
            heading: 'Welcome to Compensation Applications',
            text: 'Please fill out the request form, or view previous requests.',
            position: 'top-right',
            loaderBg:'#ff6849',
            icon: 'info',
            hideAfter: 10000,
            stack: 6
        });

        var options = {
            chart: {
                type: 'line'
            },
            series: [{
                name: 'Requester',
                data: []
            }],
            xaxis: {
                categories: []
            }
        }

        var chart = new ApexCharts(document.querySelector(""#chartBar""), options);

        chart.render();

        $.ajax({
            type: ""Get"",
            url: ""https://localhost:44317/API/Dashboard/Chart"",
            headers: { 'Authorization': 'Bearer ' + localStorage.token },
            success: function (result) {
                var data = [];
                var categories =");
                WriteLiteral(@" [];
                result.result.map(x => { data.push(x.request); });
                result.result.map(x => { categories.push(x.year); });
                chart.updateSeries([
                    {
                        name: 'Year',
                        data: data,
                        categories: categories
                    }
                ])
            }
        })
    </script>
");
            }
            );
            WriteLiteral(" ");
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
