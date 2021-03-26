#pragma checksum "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Request\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c5b11d69e8666b887a324aeba067cf61d9ff71d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Index), @"mvc.1.0.view", @"/Views/Request/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c5b11d69e8666b887a324aeba067cf61d9ff71d", @"/Views/Request/Index.cshtml")]
    public class Views_Request_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Request\Index.cshtml"
   Layout = "_LayoutAdmin";
    ViewData["Title"] = "Compensation Request";

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
#line 14 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Request\Index.cshtml"
                                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\"><a href=\"javascript:void(0)\">Home</a></li>\r\n                <li class=\"breadcrumb-item active\">");
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Request\Index.cshtml"
                                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </div>
        <div class=""col-md-6 col-4 align-self-center"">
            <a href=""#"" class=""btn pull-right hidden-sm-down btn-success"" data-toggle=""modal"" data-target=""#modal"" id=""create""><i class=""mdi mdi-plus-circle""></i>Create</a>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Start Page Content -->
    <!-- ============================================================== -->
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Data Export</h4>
                    <h6 class=""card-subtitle"">Export data CSV, Excel, PDF</h6>
                    <div class=""table-responsive m-t-40"">
  ");
            WriteLiteral(@"                      <table id=""table_id"" class=""display nowrap table table-hover table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>No.</th>
                                    <th>Request ID</th>
                                    <th>Applicants Name</th>
                                    <th>Join Date</th>
                                    <th>Manager</th>
                                    <th>Submission</th>
                                    <th>Event Date</th>
                                    <th>Request Date</th>
                                    <th>Details</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <th>No.</th>
                      ");
            WriteLiteral(@"              <th>Request ID</th>
                                    <th>Applicants Name</th>
                                    <th>Join Date</th>
                                    <th>Manager</th>
                                    <th>Submission</th>
                                    <th>Event Date</th>
                                    <th>Request Date</th>
                                    <th>Details</th>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End PAge Content -->
    <!-- ============================================================== -->
</div>
<!-- ============================================================== -->
<!-- End Container fluid  -->
<!-- ==");
            WriteLiteral(@"============================================================ -->

<!-- sample modal content -->
<div id=""modal"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""myModalLabel"">New Request</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
            </div>
            <div class=""modal-body"">
                <form id=""form"">
                    <div class=""form-group row"">
                        <label class=""col-md-4 col-form-label"">Compensation Type</label>
                        <div class=""col-md-3"">
                            <select class=""form-control"" id=""CompensationID"" name=""CompensationID""></select>
                        </div>
                    </div>
                    <div class=""form-group row"" id=""compensationDetail""");
            WriteLiteral(@">
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-md-4 col-form-label"">Event Date</label>
                        <div class=""col-md-3"">
                            <input type=""date"" class=""form-control"" name=""EventDate"" id=""EventDate"">
                        </div>
                    </div>
                </form>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-info waves-effect"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var currentNIK = ""12345""
        var compensationID

        let compensationValue = new Map()
        let compensationRequirement = new Map()

        var isUpdate;
        $(document).ready(function () {
            $('#table_id').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    {
                        extend: 'csv',
                        exportOptions: {
                            columns: [0, 2, 3, 4, 5, 6]
                        }
                    },
                    {
                        extend: 'excel',
                        exportOptions: {
                            columns: [0, 2, 3, 4, 5, 6]
                        }
                    },
                    {
                        extend: 'pdf',
                        exportOptions: {
                            columns: [0, 2, 3, 4, 5, 6]
                        }
                    }
                ],
                ""responsiv");
                WriteLiteral(@"e"": true,
                ""filter"": true,
                ""ajax"": {
                    ""url"": ""/Request/Get"",
                    ""type"": ""Get"",
                    ""dataSrc"": ""result""
                },
                ""columnDefs"": [
                    {
                        ""targets"": [1],
                        ""visible"": false,
                    },
                    {
                        ""targets"": [0, 8],
                        ""orderable"": false,
                    },
                    {
                        ""order"": [[2, 'asc']]
                    }
                ],
                ""columns"": [
                    {
                        ""data"": null,
                        ""name"": ""no"",
                        ""autowidth"": true,
                        ""render"": function (data, type, row, meta) {
                            return meta.row + meta.settings._iDisplayStart + 1;
                        }
                    },
                    { ");
                WriteLiteral(@"""data"": 'requestID' },
                    { ""data"": 'employee.employeeName' },
                    {
                        ""data"": 'employee.joinDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format('DD-MM-YYYY');
                        }
                    },
                    { ""data"": 'employee.manager.employeeName' },
                    { ""data"": 'compensation.compensationName' },
                    {
                        ""data"": 'eventDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format('DD-MM-YYYY');
                        }
                    },
                    {
                        ""data"": 'requestDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format('DD-MM-YYYY');
                        }
                    },
                    {
            ");
                WriteLiteral(@"            ""data"": 'requestID',
                        ""render"": function (data, type, row, meta) {
                            return '<a class=""btn btn-sm btn-info waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Detail Information""  href=""/Request/Details/?id=' + row['requestID'] + '""><i class=""mdi mdi-information""></i> Details</a> '
                        }
                    }
                ]
            })
        });

        $('#create').on('click', function () {
            $.ajax({
                type: ""GET"",
                url: '/Compensation/Get',
                success: function (result) {
                    var data = result['result']
                    for (var i = 0; i < data.length; i++) {
                        compensationDropdown += '<option value=""' + data[i].compensationID + '"">' + data[i].compensationName + '</option>';
                        $(""#CompensationID"").html(compensationDropdown);
                        compensationVal");
                WriteLiteral(@"ue.set(data[i].compensationName, data[i].cost)
                    }
                }
            });

            compensationRequirement.set(""Wedding"", ""KK & KTP"")
            compensationRequirement.set(""Baby Gift"", ""KK"")
            compensationRequirement.set(""Grief"", ""KK"")
        })

        $(""select#CompensationID"").on('change', function () {
            var selectedCompensationText = $('#CompensationID option:selected').text();
            compensationID = parseInt($('#CompensationID option:selected').val());
            var compensationDetail = '<label class=""col-md-4 col-form-label"">Document Details</label>' +
                '<div class=""col-md-7 col-form-label"" >' +
                '<span>Requirement: ' + compensationRequirement.get(selectedCompensationText) + '</span><br />' +
                '<span>Value: ' + compensationValue.get(selectedCompensationText) + '</span></div>'
            $('#compensationDetail').html(compensationDetail)
        })

        $('#form').submit(");
                WriteLiteral(@"function (event) {
            event.preventDefault()
            var CompensationRequest = new Object();
            CompensationRequest.nik = currentNIK;
            CompensationRequest.compensationID = compensationID
            CompensationRequest.eventDate = $('#EventDate').val();
            console.log(CompensationRequest)
            $.ajax({
                type: ""POST"",
                url: ""/Request/Post"",
                data: JSON.stringify(CompensationRequest),
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
