#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Account\Profil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15768c62d3971f908b3dc0c73299af79e63b45ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profil), @"mvc.1.0.view", @"/Views/Account/Profil.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15768c62d3971f908b3dc0c73299af79e63b45ef", @"/Views/Account/Profil.cshtml")]
    public class Views_Account_Profil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Account\Profil.cshtml"
   Layout = "_LayoutAdmin";
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- ============================================================== -->
<!-- Container fluid  -->
<!-- ============================================================== -->
<div class=""container-fluid"">
    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class=""row page-titles"">
        <div class=""col-md-6 col-8 align-self-center"">
            <h3 class=""text-themecolor m-b-0 m-t-0"">");
#nullable restore
#line 15 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Account\Profil.cshtml"
                                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\"><a href=\"/Dashboard/Index\">Home</a></li>\r\n                <li class=\"breadcrumb-item active\">");
#nullable restore
#line 18 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Account\Profil.cshtml"
                                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Start Page Content -->
    <!-- ============================================================== -->
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card card-outline-info"">
                <div class=""card-header"">
                    <h4 class=""m-b-0 text-white"">My ");
#nullable restore
#line 32 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Account\Profil.cshtml"
                                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
                <div class=""card-body"">
                    <form class=""form-horizontal"" role=""form"">
                        <div class=""form-body"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <center class=""m-t-30"">
                                        <img src=""/lib/assets/images/users/user.png"" class=""img-circle"" width=""100"" />
                                        <h4 class=""card-title m-t-10"" id=""NIK""></h4>
                                        <h6 class=""card-subtitle"" id=""EmployeeName""></h6>
                                    </center>
                                </div>
                            </div>
                            <h3 class=""box-title"">Details ");
#nullable restore
#line 46 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Account\Profil.cshtml"
                                                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                            <hr class=""m-t-0 m-b-40"">
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-md-3 col-xs-6 b-r"">
                                        <strong>Email</strong>
                                        <br>
                                        <p class=""text-muted"" id=""Email""></p>
                                    </div>
                                    <div class=""col-md-3 col-xs-6 b-r"">
                                        <strong>Phone</strong>
                                        <br>
                                        <p class=""text-muted"" id=""Phone""></p>
                                    </div>
                                    <div class=""col-md-3 col-xs-6 b-r"">
                                        <strong>Birth</strong>
                                        <br>
                                        <p class=""text-muted"" i");
            WriteLiteral(@"d=""Birth""></p>
                                    </div>
                                    <div class=""col-md-3 col-xs-6"">
                                        <strong>Address</strong>
                                        <br>
                                        <p class=""text-muted"" id=""Address""></p>
                                    </div>
                                </div>
                            </div>
                            <!--/row-->
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Department:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""DepartmentName""></p>
                                        </div>
                                    </div>
     ");
            WriteLiteral(@"                           </div>
                                <!--/span-->
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Position:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""PositionName""></p>
                                        </div>
                                    </div>
                                </div>
                                <!--/span-->
                            </div>
                            <!--/row-->
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Join Date:</label>
                 ");
            WriteLiteral(@"                       <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""JoinDate""></p>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Manager:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""ManagerName""></p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <!-- Row -->
    <!-- ===============================");
            WriteLiteral(@"=============================== -->
    <!-- End PAge Content -->
    <!-- ============================================================== -->
</div>
<!-- ============================================================== -->
<!-- End Container fluid  -->
<!-- ============================================================== -->

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var nik = sessionStorage.getItem(""NIK"");
            $.ajax({
                url: ""/Employee/GetById/"",
                type: ""GET"",
                data: {""key"": nik},
                headers: { 'Authorization': 'Bearer ' + localStorage.token },
                success: function (result) {
                    var data = result[""result""];
                    $('#NIK').html(data.nik);
                    $('#EmployeeName').html(data.employeeName);
                    $('#Email').html(data.email);
                    $('#Phone').html(data.phone);
                    $('#Birth').html(data.birthPlace + ', <br/ > ' + moment(data.birthDate).format('DD-MM-YYYY'));
                    $('#Address').html(data.address);
                    $('#DepartmentName').html(data.position.department.departmentName);
                    $('#PositionName').html(data.position.positionName);
                    $('#ManagerName').html(data.manager.e");
                WriteLiteral("mployeeName);\r\n                    $(\'#JoinDate\').html(moment(data.joinDate).format(\'DD-MM-YYYY\'));\r\n                }\r\n            })\r\n        });\r\n    </script>\r\n");
            }
            );
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
