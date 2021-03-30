#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b871c20198402c8fa54b043ba49187649ad752bf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b871c20198402c8fa54b043ba49187649ad752bf", @"/Views/Request/Index.cshtml")]
    public class Views_Request_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Index.cshtml"
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
#line 14 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Index.cshtml"
                                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\"><a href=\"/Dashboard/Index\">Home</a></li>\r\n                <li class=\"breadcrumb-item active\">");
#nullable restore
#line 17 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Index.cshtml"
                                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </div>
        <div class=""col-md-6 col-4 align-self-center"">
            <a href=""/Request/Requester"" class=""btn pull-right hidden-sm-down btn-success""><i class=""mdi mdi-plus-circle""></i> Create</a>
            <div class=""dropdown pull-right m-r-10 hidden-sm-down"">
                <select class=""selectpicker m-b-20 m-r-10"" data-style=""btn-secondary"" id=""View"">
                    <option data-tokens=""All"" value=""All"">All Request</option>
                    <option data-tokens=""Pending"" value=""0"">Pending</option>
                    <option data-tokens=""Approved"" value=""1"">Approved</option>
                    <option data-tokens=""Rejected"" value=""-1"">Rejected</option>
                </select>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ========");
            WriteLiteral(@"====================================================== -->
    <!-- Start Page Content -->
    <!-- ============================================================== -->
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Data Export</h4>
                    <h6 class=""card-subtitle"">Export data CSV, Excel, PDF</h6>
                    <div class=""table-responsive m-t-40"">
                        <table id=""table_id"" class=""display nowrap table table-hover table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>No.</th>
                                    <th>Request ID</th>
                                    <th>Applicants Name</th>
                                    <th>Join Date</th>
                                    <th>Manager</th>
                            ");
            WriteLiteral(@"        <th>Submission</th>
                                    <th>Event Date</th>
                                    <th>Request Date</th>
                                    <th>Status</th>
                                    <th>Details</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <th>No.</th>
                                    <th>Request ID</th>
                                    <th>Applicants Name</th>
                                    <th>Join Date</th>
                                    <th>Manager</th>
                                    <th>Submission</th>
                                    <th>Event Date</th>
                                    <th>Request Date</th>
                                    <th>Status</th>
                                    <th>");
            WriteLiteral(@"Details</th>
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
<!-- ============================================================== -->
<!-- sample modal content -->
<div id=""modal"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"" style=""display: none;"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""myLargeModalLabel""");
            WriteLiteral(@">Detail Request</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"" onclick=""reset()"">×</button>
            </div>
            <div class=""modal-body"">
                <form class=""form-horizontal"" role=""form"">
                    <div class=""form-body"">
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
                            <div class=""col-md-6"">
                   ");
            WriteLiteral(@"             <div class=""form-group row"">
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
                                </div>
                            </div>
                            <!--/span-->
              ");
            WriteLiteral(@"          </div>
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
                                    <label class=""control-label text-right col-md-4"">Join Date:</label>
                                    <div class=""col-md-8"">
                                        <p class=""form-control-static"" id=""JoinDate""></p>
                     ");
            WriteLiteral(@"               </div>
                                </div>
                            </div>
                            <!--/span-->
                        </div>
                        <!--/row-->
                        <h4 class=""box-title"">Compensation Request</h4>
                        <hr class=""m-t-0 m-b-40"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group row"">
                                    <label class=""control-label text-right col-md-4"">Number:</label>
                                    <div class=""col-md-8"">
                                        <p class=""form-control-static"" id=""RequestID""></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                ");
            WriteLiteral(@"<div class=""form-group row"">
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
                                    <div class=""col-md-8"">
                                        <p class=""form-control-static"" id=""CompensationName""></p>
                                    </div>
                                </div>
                            </div>
                            <!--/span-->
                        </");
            WriteLiteral(@"div>
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
                            <div class=""col-md-6"">
                                <div class=""form-group row"">
                                    <label class=""control-label text-right col-md-4"">Document:</label>
                                    <div class=""col-md-8"">
                                        <p class=""form-control-static"" id=""Document""></p>
                               ");
            WriteLiteral(@"     </div>
                                </div>
                            </div>
                            <!--/span-->
                        </div>
                        <div class=""table-responsive m-t-40"">
                            <h4 class=""box-title"">Approval Status</h4>
                            <hr class=""m-t-0 m-b-40"">
                            <table id=""tablestatus"" class=""display nowrap table table-hover table-striped"" cellspacing=""0"" width=""100%"">
                                <thead>
                                    <tr>
                                        <th>Current Status</th>
                                        <th>Position</th>
                                        <th>Date</th>
                                    </tr>
                                </thead>
                                <tbody id=""Status"">
                                </tbody>
                            </table>
                        </div>
                    <");
            WriteLiteral(@"/div>
                </form>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-secondary btn-rounded waves-effect text-left"" data-dismiss=""modal"" id=""close"" onclick=""reset()"">Close</button>
                <button type=""submit"" class=""btn btn-danger btn-rounded waves-effect text-left"" data-dismiss=""modal"" id=""reject"">Reject</button>
                <button type=""submit"" class=""btn btn-success btn-rounded waves-effect text-left"" data-dismiss=""modal"" id=""approve"">Approve</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script>
        var isUpdate = 0, value, urlString, dataStatus;
        $(document).ready(function () {
            defaultTable();
        });

        $('#View').on('change', function () {
            value = $(this).val();
            $('#table_id').DataTable().destroy();
            urlString = ""/Request/RequestList"";
            if (value == '0') {
                dataStatus = ""Pending"";
                myTable();
            } else if (value == '1') {
                dataStatus = ""Approve"";
                myTable();
            } else if (value == '-1') {
                dataStatus = ""Rejected"";
                myTable();
            } else {
                defaultTable();
            }
        });

        function defaultTable() {
            $('#table_id').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    {
                        extend: 'csv',
                        exportOptions: {
                            columns: [");
                WriteLiteral(@"0, 2, 3, 4, 5, 6]
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
                ""order"": [],
                ""responsive"": true,
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"": ""/Request/Get"",
                    ""type"": ""Get"",
                    ""dataSrc"": ""result""
                },
                ""columnDefs"": [
                    {
                        ""targets"": [1, 3, 4],
                        ""visible"": false,
                    },
                    {
        ");
                WriteLiteral(@"                ""targets"": [0, 8],
                        ""orderable"": false,
                    },
                    {
                        ""targets"": [0, 1, 3, 5, 6, 7, 8],
                        ""className"": ""texUrl-center"",
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
                    { ""data"": 'requestID' },
                    { ""data"": 'employee.employeeName' },
                    {
                        ""data"": 'employee.joinDate',
                        ""render"": function (data, type, row) {
                       ");
                WriteLiteral(@"     return moment(data).format('DD/MM/YYYY');
                        }
                    },
                    { ""data"": 'employee.manager.employeeName' },
                    { ""data"": 'compensation.compensationName' },
                    {
                        ""data"": 'eventDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format('DD/MM/YYYY');
                        }
                    },
                    {
                        ""data"": 'requestDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format('DD/MM/YYYY');
                        }
                    },
                    {
                        ""data"": 'approval.status.statusName'
                    },
                    {
                        ""data"": 'requestID',
                        ""render"": function (data, type, row, meta) {
                            retur");
                WriteLiteral(@"n '<button class=""btn btn-outline-info waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Detail Information"" onclick=""GetDetail(\'' + row['requestID'] + '\')""><i class=""fa fa-info-circle""></i> Details</button>'
                        }
                    }
                ]
            })
        }

        function myTable() {
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
                         ");
                WriteLiteral(@"   columns: [0, 2, 3, 4, 5, 6]
                        }
                    }
                ],
                ""order"": [],
                ""responsive"": true,
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"": urlString,
                    ""type"": ""Get"",
                    ""data"": { 'status': dataStatus },
                    ""dataSrc"": ""result""
                },
                ""columnDefs"": [
                    {
                        ""targets"": [1, 3, 4],
                        ""visible"": false,
                    },
                    {
                        ""targets"": [0, 8],
                        ""orderable"": false,
                    },
                    {
                        ""targets"": [0, 1, 3, 5, 6, 7, 8],
                        ""className"": ""texUrl-center"",
                    },
                    {
                        ""order"": [[2, 'asc']]
                    }
      ");
                WriteLiteral(@"          ],
                ""columns"": [
                    {
                        ""data"": null,
                        ""name"": ""no"",
                        ""autowidth"": true,
                        ""render"": function (data, type, row, meta) {
                            return meta.row + meta.settings._iDisplayStart + 1;
                        }
                    },
                    { ""data"": 'requestID' },
                    { ""data"": 'employeeName' },
                    {
                        ""data"": 'joinDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format('DD/MM/YYYY');
                        }
                    },
                    { ""data"": 'manager' },
                    { ""data"": 'compensationName' },
                    {
                        ""data"": 'eventDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format");
                WriteLiteral(@"('DD/MM/YYYY');
                        }
                    },
                    {
                        ""data"": 'requestDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format('DD/MM/YYYY');
                        }
                    },
                    {
                        ""data"": 'requestID',
                        ""render"": function (data, type, row, meta) {
                            return '<button class=""btn btn-outline-info waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Detail Information"" onclick=""GetDetail(\'' + row['requestID'] + '\')""><i class=""fa fa-info-circle""></i> Details</button>'  
                        }
                    }
                ]
            })
        }

        function GetDetail(id) {
            $.ajax({
                url: ""/Request/GetById"",
                type: ""GET"",
                data: { 'key': id },
                success");
                WriteLiteral(@": function (result) {
                    $('#modal').modal('show');
                    var data = result[""result""];
                    $('#Requester').html(data.employee.employeeName)
                    $('#DepartmentName').html(data.employee.position.department.departmentName)
                    $('#PositionName').html(data.employee.position.positionName)
                    $('#ManagerName').html(data.employee.manager.employeeName)
                    $('#JoinDate').html(moment(data.employee.joinDate).format('DD MMMM YYYY'))
                    $('#RequestID').html(data.requestID)
                    $('#RequestIDText').html(data.requestID)
                    $('#CompensationName').html(data.compensation.compensationName)
                    $('#EventDate').html(moment(data.eventDate).format('DD MMMM YYYY'))
                    $('#RequestDate').html(moment(data.requestDate).format('DD MMMM YYYY'))

                    for (var i = 0; i < data.documents.length; i++) {
                  ");
                WriteLiteral(@"      if (data.documents[i].link.match(/(.*?)\.(pdf|PDF)$/)) {
                            var documentList = '<a target=""_blank"" href=""' + data.documents[i].link
                                + '""><img src=""/lib/src/images/pdf.png"" width=""30"">' + data.documents[i].documentName + '</><br/>'
                        } else if (data.documents[i].link.match(/(.*?)\.(jpg|jpeg|JPG|JPEG)$/)) {
                            var documentList = '<a target=""_blank"" href=""' + data.documents[i].link
                                + '""><img src=""/lib/src/images/images.png"" width=""30"">' + data.documents[i].documentName + '</><br/>'
                        }
                        $('#Document').append(documentList);
                    }
                }
            });

            $.ajax({
                url: ""/Approval/ApprovalStatus"",
                type: ""GET"",
                data: { 'RequestID': id },
                success: function (result) {
                    var data = result[""result""];
");
                WriteLiteral(@"                    for (var i = 0; i < data.length; i++) {
                        var statusList = '<tr><th id=""Status"">' + data[i].statusName + '</th>'
                            + '<th id=""Approval"">' + data[i].approval + '</th>'
                            + '<th id=""ApprovalDate"">' + moment(data[i].approvalDate).format('DD MM YYYY') + '</th></tr>'
                        $('#Status').append(statusList);
                    }
                }
            })
        };

        function reset() {
            $('#Document').empty();
            $(""#tablestatus tbody"").empty();
        }
    </script>
");
            }
            );
            WriteLiteral(@"
<!--
--------------------- Notes -----------------------
ini yang perlu ditampilin lewat role
1. Employee >> bisa semua yg ada di index.cshtml, jadi gak ada yg disembunyiin 
2. Manager, HR, Finance >> tombol detail yg di table diganti sama approval.cshtml, 
    tombol create di ilangin, status masih tetep ada
3. Superadmin >> tombol create aja di ilangin
-->
");
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
