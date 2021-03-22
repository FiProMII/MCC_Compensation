#pragma checksum "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Request\Approval.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b6e9c09421834f8a11d662c7d6fe9cbb7bc827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Approval), @"mvc.1.0.view", @"/Views/Request/Approval.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b6e9c09421834f8a11d662c7d6fe9cbb7bc827", @"/Views/Request/Approval.cshtml")]
    public class Views_Request_Approval : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Request\Approval.cshtml"
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
                <br /><h4 class=""card-title""><i class=""fas fa-clipboard-list""></i> Compensation Request</h4>
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
                        <h4>Requester Information</h4>
                        <hr />
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Requester</label>
                            <span class=""col-md-7"" id=""Requester""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Department");
            WriteLiteral(@"</label>
                            <span class=""col-md-7"" id=""DepartmentName""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Position</label>
                            <span class=""col-md-7"" id=""PositionName""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Relation Manager</label>
                            <span class=""col-md-7"" id=""ManagerName""></span>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-md-4"">Join Date</label>
                            <span class=""col-md-7"" id=""JoinDate""></span>
                        </div>
                    </div>
                </div>
                <br />
                <div class=""card m-auto"">
                    <div class=""card-header"">Compensation Request Detail</div");
            WriteLiteral(@">
                    <form id=""form"">
                        <div class=""card-body"" style=""padding-left: 100px; padding-right: 100px;"">
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Requester Number</label>
                                <div class=""col-md-7 col-form-label"">
                                    <span id=""RequestIDText""></span>
                                    <input type=""hidden"" value=""requestID"" name=""RequestID"" id=""RequestID"" />
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Compensation Type</label>
                                <div class=""col-md-5"">
                                    <span id=""CompensationName""></span>
                                </div>
                            </div>
                            <div class=");
            WriteLiteral(@"""form-group row"">
                                <label class=""col-md-4 col-form-label"">Event Data</label>
                                <div class=""col-md-5"">
                                    <span id=""EventDate""></span>
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Request Date</label>
                                <div class=""col-md-5"">
                                    <span id=""RequestDate""></span>
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-md-4 col-form-label"">Document Requirements</label>
                                <div class=""col-md-7 col-form-label"" id=""Document"">
                                </div>
                            </div>
                        </div>
            ");
            WriteLiteral(@"            <div class=""form-group row"">
                            <div class=""col-12 text-right pr-5"" id=""button"">
                                <button class=""btn btn-success"" value=""2"" type=""submit"">Approve</button>
                                <button class=""btn btn-danger"" value=""3"" type=""submit"">Reject</button>
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
        var managerNIK;
        var requestID;
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
                        managerNIK = data.employee.manager.nik
                        requestID = data.requestID
                        $('#Requester').html(data.employee.employeeName)
                        $('#DepartmentName').html(data.employee.position.dep");
                WriteLiteral(@"artment.departmentName)
                        $('#PositionName').html(data.employee.position.positionName)
                        $('#ManagerName').html(data.employee.manager.employeeName)
                        $('#JoinDate').html(moment(data.employee.joinDate).format('DD/MM/YYYY'))
                        $('#RequestID').html(data.requestID)
                        $('#RequestIDText').html(data.requestID)
                        $('#CompensationName').html(data.compensation.compensationName)
                        $('#EventDate').html(moment(data.eventDate).format('DD/MM/YYYY'))
                        $('#RequestDate').html(moment(data.requestDate).format('DD/MM/YYYY'))
                        
                        for (var i = 0; i < data.documents.length; i++) {
                            var documentList = '<a href=""' + data.documents[i].link +'"">' + data.documents[i].documentName + '</a><br>'
                            $('#Document').append(documentList)
                        }");
                WriteLiteral(@"
                    }
                })
            }
        });

        var statusID;
        $('.btn').click(function () {
            statusID = parseInt($(this).val())
        })

        $('#form').submit(function (event) {
            event.preventDefault()
            var Approval = new Object();
            Approval.statusID = statusID;
            Approval.nik = managerNIK
            Approval.requestID = requestID
            $.ajax({
                type: ""POST"",
                url: ""/Approval/Post"",
                data: JSON.stringify(Approval),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json""
            });
        })
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
