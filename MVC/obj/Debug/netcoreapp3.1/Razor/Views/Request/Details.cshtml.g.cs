#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8afdd2f9e119075e879e411e89fcd098f752342d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Details), @"mvc.1.0.view", @"/Views/Request/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8afdd2f9e119075e879e411e89fcd098f752342d", @"/Views/Request/Details.cshtml")]
    public class Views_Request_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Details.cshtml"
   Layout = "_LayoutAdmin";
    ViewData["Title"] = "Detail Request";

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
#line 14 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Details.cshtml"
                                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""javascript:void(0)"">Home</a></li>
                <li class=""breadcrumb-item""><a href=""/Request/Index"">Compensation Request</a></li>
                <li class=""breadcrumb-item active"">");
#nullable restore
#line 18 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Details.cshtml"
                                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </div>
        <div class=""col-md-6 col-4 align-self-center"">
            <a class=""pull-right hidden-sm-down btn btn-outline-secondary"" href=""/Request/Index""><i class=""mdi mdi-keyboard-backspace""></i> Back</a>
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
                    <h4 class=""m-b-0 text-white"">");
#nullable restore
#line 35 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Details.cshtml"
                                            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
                <div class=""card-body"">
                    <form class=""form-horizontal"" role=""form"">
                        <div class=""form-body"">
                            <h3 class=""box-title"">Person Info</h3>
                            <hr class=""m-t-0 m-b-40"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Requester:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""Requester""></p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!--/row-->
                            <div class=""row"">
                      ");
            WriteLiteral(@"          <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Department:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""DepartmentName""></p>
                                        </div>
                                    </div>
                                </div>
                                <!--/span-->
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Relation Manager:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""ManagerName""></p>
                                        </div>
                       ");
            WriteLiteral(@"             </div>
                                </div>
                                <!--/span-->
                            </div>
                            <!--/row-->
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Position:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""PositionName""></p>
                                        </div>
                                    </div>
                                </div>
                                <!--/span-->
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Join Date:<");
            WriteLiteral(@"/label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""JoinDate""></p>
                                        </div>
                                    </div>
                                </div>
                                <!--/span-->
                            </div>
                            <!--/row-->
                            <h3 class=""box-title"">Compensation Request</h3>
                            <hr class=""m-t-0 m-b-40"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Number:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""RequestID""></p>
                                  ");
            WriteLiteral(@"      </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Event Date:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""EventDate""></p>
                                        </div>
                                    </div>
                                </div>
                                <!--/span-->
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Compensation Type:</label>
                                  ");
            WriteLiteral(@"      <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""CompensationName""></p>
                                        </div>
                                    </div>
                                </div>
                                <!--/span-->
                            </div>
                            <!--/row-->
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Request Date:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""RequestDate""></p>
                                        </div>
                                    </div>
                                </div>
                                <!--/span-->
               ");
            WriteLiteral(@"                 <div class=""col-md-6"">
                                    <div class=""form-group row"">
                                        <label class=""control-label text-right col-md-4"">Document:</label>
                                        <div class=""col-md-8"">
                                            <p class=""form-control-static"" id=""Document""></p>
                                        </div>
                                    </div>
                                </div>
                                <!--/span-->
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <!-- Row -->
    <!-- ============================================================== -->
    <!-- End PAge Content -->
    <!-- ============================================================== -->
</div>
<!-- ============================================================== -->
<!-- End Container ");
            WriteLiteral("fluid  -->\r\n<!-- ============================================================== -->\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $.urlParam = function (name) {
            var results = new RegExp('[\?&]' + name + '=([^&#]*)').exec(window.location.href);
            if (results == null) {
                return null;
            }
            return decodeURI(results[1]) || 0;
        }

        $(document).ready(function () {
            var id = $.urlParam('id')
            if (id != null) {
                $.ajax({
                    url: ""/Request/GetById"",
                    type: ""GET"",
                    data: { 'key': id },
                    success: function (result) {
                        $('#modal').modal('show');
                        var data = result[""result""];
                        $('#Requester').html(data.employee.employeeName)
                        $('#DepartmentName').html(data.employee.position.department.departmentName)
                        $('#PositionName').html(data.employee.position.positionName)
                        $('#ManagerName').html(data.em");
                WriteLiteral(@"ployee.manager.employeeName)
                        $('#JoinDate').html(moment(data.employee.joinDate).format('DD-MM-YYYY'))
                        $('#RequestID').html(data.requestID)
                        $('#RequestIDText').html(data.requestID)
                        $('#CompensationName').html(data.compensation.compensationName)
                        $('#EventDate').html(moment(data.eventDate).format('DD-MM-YYYY'))
                        $('#RequestDate').html(moment(data.requestDate).format('DD-MM-YYYY'))

                        for (var i = 0; i < data.documents.length; i++) {
                            if (data.documents[i].link.match(/(.*?)\.(pdf|PDF)$/)) {
                                var documentList = '<a target=""_blank"" href=""' + data.documents[i].link
                                    + '""><img src=""/lib/src/images/pdf.png"" width=""30"">' + data.documents[i].documentName + '</><br/>'
                            } else if (data.documents[i].link.match(/(.*?)\.(jpg|jpeg|JPG");
                WriteLiteral(@"|JPEG)$/)) {
                                var documentList = '<a target=""_blank"" href=""' + data.documents[i].link
                                    + '""><img src=""/lib/src/images/images.png"" width=""30"">' + data.documents[i].documentName + '</>'
                            }
                            $('#Document').append(documentList);
                        }
                    }
                })
            }
        });

    </script>
");
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
