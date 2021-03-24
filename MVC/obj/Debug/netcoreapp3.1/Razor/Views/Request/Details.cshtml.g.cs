#pragma checksum "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Request\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd66882538841bc1c95c9c3e2e9fbdfa56e0e2c9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd66882538841bc1c95c9c3e2e9fbdfa56e0e2c9", @"/Views/Request/Details.cshtml")]
    public class Views_Request_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Request\Details.cshtml"
   Layout = "_Layout";
    ViewBag.Title = "Compensation Request";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card-title"">
                <div class=""col-sm-12 text-right"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item""><a href=""/Request/Index"">Request</a></li>
                        <li class=""breadcrumb-item active"">Details</li>
                    </ol>
                </div>
                <br />
                <h4 class=""card-title""><i class=""fas fa-clipboard-list""></i> Compensation Request</h4>
            </div>
        </div>
    </div>
</div>
<div class=""flex-md-wrap"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card m-auto"">
                    <div class=""card-body"" style=""padding-left: 100px; padding-right: 100px;"">
                        <br />
        ");
            WriteLiteral(@"                <h4>Requester Information</h4>
                        <hr />
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Requester</label>
                            <span class=""col-md-7"" id=""Requester""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Department</label>
                            <span class=""col-md-7"" id=""DepartmentName""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Position</label>
                            <span class=""col-md-7"" id=""PositionName""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Relation Manager</label>
                            <span class=""col-md-7"" id=""ManagerName""></span>
                        </div>");
            WriteLiteral(@"
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Join Date</label>
                            <span class=""col-md-7"" id=""JoinDate""></span>
                        </div>
                    </div>
                </div>
                <br />
                <div class=""card m-auto"">
                    <div class=""card-header"">Compensation Request Detail</div>
                    <form id=""form"">
                        <div class=""card-body"" style=""padding-left: 100px; padding-right: 100px;"">
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Request Number</label>
                                <div class=""col-md-7 col-form-label"">
                                    <span id=""RequestIDText""></span>
                                    <input type=""hidden"" value=""requestID"" name=""RequestID"" id=""RequestID"" />
                                </div>
          ");
            WriteLiteral(@"                  </div>
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Compensation Type</label>
                                <div class=""col-md-5"">
                                    <span id=""CompensationName""></span>
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Event Data</label>
                                <div class=""col-md-5"">
                                    <span id=""EventDate""></span>
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Request Date</label>
                                <div class=""col-md-5"">
                                    <span id=""RequestDate""></span>
               ");
            WriteLiteral(@"                 </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Document Requirements</label>
                                <div class=""col-md-7 col-form-label"" id=""Document"">
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
                                    + '""><img src=""/src/images/pdf.png"" width=""50"">' + data.documents[i].documentName + '</><br/>'
                            } else if (data.documents[i].link.match(/(.*?)\.(jpg|jpeg|JPG|JPE");
                WriteLiteral(@"G)$/)) {
                                var documentList = '<a target=""_blank"" href=""' + data.documents[i].link
                                    + '""><img src=""/src/images/pdf.png"" width=""50"">' + data.documents[i].documentName + '</>'
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
