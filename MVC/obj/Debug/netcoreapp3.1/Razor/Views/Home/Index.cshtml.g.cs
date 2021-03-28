#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d2bec74cca31b1c60a1f52cd38a134dbeedff30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2bec74cca31b1c60a1f52cd38a134dbeedff30", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Home\Index.cshtml"
   Layout = "_Layout2";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Dashboard v3</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Dashboard v3</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->

    <main role=""main"" class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""card"">
                        ");
            WriteLiteral(@"<div class=""card-header border-0"">
                            <div class=""d-flex justify-content-between"">
                                <h3 class=""card-title"">Online Store Visitors</h3>
                                <a href=""javascript:void(0);"">View Report</a>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""d-flex"">
                                <p class=""d-flex flex-column"">
                                    <span class=""text-bold text-lg"">820</span>
                                    <span>Visitors Over Time</span>
                                </p>
                                <p class=""ml-auto d-flex flex-column text-right"">
                                    <span class=""text-success"">
                                        <i class=""fas fa-arrow-up""></i> 12.5%
                                    </span>
                                    <span class=""text-muted"">S");
            WriteLiteral(@"ince last week</span>
                                </p>
                            </div>
                            <!-- /.d-flex -->

                            <div class=""position-relative mb-4"">
                                <canvas id=""visitors-chart"" height=""200""></canvas>
                            </div>

                            <div class=""d-flex flex-row justify-content-end"">
                                <span class=""mr-2"">
                                    <i class=""fas fa-square text-primary""></i> This Week
                                </span>

                                <span>
                                    <i class=""fas fa-square text-gray""></i> Last Week
                                </span>
                            </div>
                        </div>
                    </div>
                    <!-- /.card -->

                    <div class=""card"">
                        <div class=""card-header border-0"">
                      ");
            WriteLiteral(@"      <h3 class=""card-title"">Products</h3>
                            <div class=""card-tools"">
                                <a href=""#"" class=""btn btn-tool btn-sm"">
                                    <i class=""fas fa-download""></i>
                                </a>
                                <a href=""#"" class=""btn btn-tool btn-sm"">
                                    <i class=""fas fa-bars""></i>
                                </a>
                            </div>
                        </div>
                        <div class=""card-body table-responsive p-0"">
                            <table class=""table table-striped table-valign-middle"">
                                <thead>
                                    <tr>
                                        <th>Product</th>
                                        <th>Price</th>
                                        <th>Sales</th>
                                        <th>More</th>
                                    <");
            WriteLiteral(@"/tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>
                                            <img src=""dist/img/default-150x150.png"" alt=""Product 1"" class=""img-circle img-size-32 mr-2"">
                                            Some Product
                                        </td>
                                        <td>$13 USD</td>
                                        <td>
                                            <small class=""text-success mr-1"">
                                                <i class=""fas fa-arrow-up""></i>
                                                12%
                                            </small>
                                            12,000 Sold
                                        </td>
                                        <td>
                                            <a href=""#"" class=""text-muted"">
      ");
            WriteLiteral(@"                                          <i class=""fas fa-search""></i>
                                            </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <img src=""dist/img/default-150x150.png"" alt=""Product 1"" class=""img-circle img-size-32 mr-2"">
                                            Another Product
                                        </td>
                                        <td>$29 USD</td>
                                        <td>
                                            <small class=""text-warning mr-1"">
                                                <i class=""fas fa-arrow-down""></i>
                                                0.5%
                                            </small>
                                            123,234 Sold
                                        </td>");
            WriteLiteral(@"
                                        <td>
                                            <a href=""#"" class=""text-muted"">
                                                <i class=""fas fa-search""></i>
                                            </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <img src=""dist/img/default-150x150.png"" alt=""Product 1"" class=""img-circle img-size-32 mr-2"">
                                            Amazing Product
                                        </td>
                                        <td>$1,230 USD</td>
                                        <td>
                                            <small class=""text-danger mr-1"">
                                                <i class=""fas fa-arrow-down""></i>
                                                3%
                          ");
            WriteLiteral(@"                  </small>
                                            198 Sold
                                        </td>
                                        <td>
                                            <a href=""#"" class=""text-muted"">
                                                <i class=""fas fa-search""></i>
                                            </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <img src=""dist/img/default-150x150.png"" alt=""Product 1"" class=""img-circle img-size-32 mr-2"">
                                            Perfect Item
                                            <span class=""badge bg-danger"">NEW</span>
                                        </td>
                                        <td>$199 USD</td>
                                        <td>
                               ");
            WriteLiteral(@"             <small class=""text-success mr-1"">
                                                <i class=""fas fa-arrow-up""></i>
                                                63%
                                            </small>
                                            87 Sold
                                        </td>
                                        <td>
                                            <a href=""#"" class=""text-muted"">
                                                <i class=""fas fa-search""></i>
                                            </a>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col-md-6 -->
                <div class=""col-lg-6"">
                    <div class=""card"">
                        <div");
            WriteLiteral(@" class=""card-header border-0"">
                            <div class=""d-flex justify-content-between"">
                                <h3 class=""card-title"">Sales</h3>
                                <a href=""javascript:void(0);"">View Report</a>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""d-flex"">
                                <p class=""d-flex flex-column"">
                                    <span class=""text-bold text-lg"">$18,230.00</span>
                                    <span>Sales Over Time</span>
                                </p>
                                <p class=""ml-auto d-flex flex-column text-right"">
                                    <span class=""text-success"">
                                        <i class=""fas fa-arrow-up""></i> 33.1%
                                    </span>
                                    <span class=""text-muted"">Since last month<");
            WriteLiteral(@"/span>
                                </p>
                            </div>
                            <!-- /.d-flex -->

                            <div class=""position-relative mb-4"">
                                <canvas id=""sales-chart"" height=""200""></canvas>
                            </div>

                            <div class=""d-flex flex-row justify-content-end"">
                                <span class=""mr-2"">
                                    <i class=""fas fa-square text-primary""></i> This year
                                </span>

                                <span>
                                    <i class=""fas fa-square text-gray""></i> Last year
                                </span>
                            </div>
                        </div>
                    </div>
                    <!-- /.card -->

                    <div class=""card"">
                        <div class=""card-header border-0"">
                            <h3 class=""c");
            WriteLiteral(@"ard-title"">Online Store Overview</h3>
                            <div class=""card-tools"">
                                <a href=""#"" class=""btn btn-sm btn-tool"">
                                    <i class=""fas fa-download""></i>
                                </a>
                                <a href=""#"" class=""btn btn-sm btn-tool"">
                                    <i class=""fas fa-bars""></i>
                                </a>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between align-items-center border-bottom mb-3"">
                                <p class=""text-success text-xl"">
                                    <i class=""ion ion-ios-refresh-empty""></i>
                                </p>
                                <p class=""d-flex flex-column text-right"">
                                    <span class=""font-weight-bold"">
                 ");
            WriteLiteral(@"                       <i class=""ion ion-android-arrow-up text-success""></i> 12%
                                    </span>
                                    <span class=""text-muted"">CONVERSION RATE</span>
                                </p>
                            </div>
                            <!-- /.d-flex -->
                            <div class=""d-flex justify-content-between align-items-center border-bottom mb-3"">
                                <p class=""text-warning text-xl"">
                                    <i class=""ion ion-ios-cart-outline""></i>
                                </p>
                                <p class=""d-flex flex-column text-right"">
                                    <span class=""font-weight-bold"">
                                        <i class=""ion ion-android-arrow-up text-warning""></i> 0.8%
                                    </span>
                                    <span class=""text-muted"">SALES RATE</span>
                            ");
            WriteLiteral(@"    </p>
                            </div>
                            <!-- /.d-flex -->
                            <div class=""d-flex justify-content-between align-items-center mb-0"">
                                <p class=""text-danger text-xl"">
                                    <i class=""ion ion-ios-people-outline""></i>
                                </p>
                                <p class=""d-flex flex-column text-right"">
                                    <span class=""font-weight-bold"">
                                        <i class=""ion ion-android-arrow-down text-danger""></i> 1%
                                    </span>
                                    <span class=""text-muted"">REGISTRATION RATE</span>
                                </p>
                            </div>
                            <!-- /.d-flex -->
                        </div>
                    </div>
                </div>
                <!-- /.col-md-6 -->
            </div>
            <");
            WriteLiteral("!-- /.row -->\r\n        </div>\r\n    </main>\r\n</div>\r\n<!-- /.content-wrapper -->");
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
