#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Request\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a17418581f81482fd8f586cfe5adec311668933"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a17418581f81482fd8f586cfe5adec311668933", @"/Views/Request/Index.cshtml")]
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
            <a href=""/Request/Requester"" class=""btn pull-right hidden-sm-down btn-success"" id=""CreateRequest""><i class=""mdi mdi-plus-circle""></i> Create</a>
            <div class=""dropdown pull-right m-r-10 hidden-sm-down"">
                <select class=""selectpicker m-b-20 m-r-10"" data-style=""btn-secondary"" id=""View"">
                    <option data-tokens=""Pending"" value=""0"">Pending</option>
                    <option data-tokens=""Approved"" value=""1"">Approved</option>
                    <option data-tokens=""Rejected"" value=""-1"">Rejected</option>
                    <option data-tokens=""All"" value=""All"">All Request</option>
                </select>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->");
            WriteLiteral(@"
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
                        <table id=""table_id"" class=""display nowrap table table-hover table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>No.</th>
                                    <th>Request ID</th>
                                    <th>Applicants Name</th>
                                    <th>Join Date</th>
                                    <th>Manager</th>
         ");
            WriteLiteral(@"                           <th>Submission</th>
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
                                    <th>Request ID</th>
                                    <th>Applicants Name</th>
                                    <th>Join Date</th>
                                    <th>Manager</th>
                                    <th>Submission</th>
                                    <th>Event Date</th>
                                    <th>Request Date</th>
                                    <th>Details</th>
                                </tr>
                            </tfoo");
            WriteLiteral(@"t>
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
                <h4 class=""modal-title"" id=""myLargeModalLabel"">Detail Request</h4>
                <button type=""button"" class=""close"" data-dismiss=");
            WriteLiteral(@"""modal"" aria-hidden=""true"" onclick=""reset()"">×</button>
            </div>
            <div class=""modal-body"">
                <form class=""form-horizontal"" role=""form"" id=""formApproval"">
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
                                <div class=""form-group row"">
                          ");
            WriteLiteral(@"          <label class=""control-label text-right col-md-4"">Department:</label>
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
                        </div>
                        <!--/row-->
              ");
            WriteLiteral(@"          <div class=""row"">
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
                                    </div>
                                </div>
      ");
            WriteLiteral(@"                      </div>
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
                                <div class=""form-group row"">
                                    <la");
            WriteLiteral(@"bel class=""control-label text-right col-md-4"">Event Date:</label>
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
                        </div>
                        <!--/row-->
                        <d");
            WriteLiteral(@"iv class=""row"">
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
                                    </div>
                                </div>
                ");
            WriteLiteral(@"            </div>
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
                    </div>
                    <div class=""modal-footer form-actions"">
 ");
            WriteLiteral(@"                       <button type=""button"" class=""btn btn-outline-secondary btn-rounded"" data-dismiss=""modal"" id=""close"" onclick=""reset()"">Close</button>
                        <button type=""submit"" class=""btn btn-danger btn-rounded"" id=""reject"" value=""3"">Reject</button>
                        <button type=""submit"" class=""btn btn-success btn-rounded"" id=""approve"" value=""2"">Approve</button>
                    </div>
                </form>
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
                WriteLiteral(@"<script>
    var isUpdate = 0, value, urlString, dataStatus, NIK;
    $(document).ready(function () {
        urlString = ""/Request/RequestList""
        dataStatus = ""Pending""
        NIK = sessionStorage.getItem(""NIK"")
        myTable()
        $('#reject').show()
        $('#approve').show()
        $('#close').hide()

        var data = JSON.parse(localStorage.getItem(""Role""));
        if (data.includes(""Super Admin"") || data.includes(""RM"") || data.includes(""HR"") || data.includes(""Finance"")) {
            $('#CreateRequest').hide()
        } else {
            $('#CreateRequest').show()
            $('#reject').hide()
            $('#approve').hide()
            $('#close').show()
        }
    });

        $('#View').on('change', function () {
            value = $(this).val()
            $('#table_id').DataTable().destroy()
            urlString = ""/Request/RequestList""
            if (value == '0') {
                dataStatus = ""Pending""
                myTable()
          ");
                WriteLiteral(@"      $('#reject').show()
                $('#approve').show()
                $('#close').hide()
            } else if (value == '1') {
                dataStatus = ""Approve""
                myTable()
                $('#reject').hide()
                $('#approve').hide()
                $('#close').show()
            } else if (value == '-1') {
                dataStatus = ""Rejected""
                myTable()
                $('#reject').hide()
                $('#approve').hide()
                $('#close').show()
            } else {
                defaultTable()
                $('#close').show()
                $('#reject').hide()
                $('#approve').hide()
            }
        });

        function defaultTable() {
            $('#table_id').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    {
                        extend: 'csv',
                        exportOptions: {
                            columns: [0, 2, 3, 4, ");
                WriteLiteral(@"5, 6]
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
                    ""url"": ""/Request/RequestByDepartmentList"",
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
                WriteLiteral(@"                        ""targets"": [0, 8],
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
                WriteLiteral(@"             return moment(data).format('DD/MM/YYYY');
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
                        ""data"": 'requestID',
                        ""render"": function (data, type, row, meta) {
                            return '<button class=""btn btn-outline-info waves-effect waves-light"" data-toggle=""tooltip"" data-placement");
                WriteLiteral(@"=""top"" title=""Detail Information"" onclick=""GetDetail(\'' + row['requestID'] + '\')""><i class=""fa fa-info-circle""></i> Details</button>'
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
                            columns: [0, 2, 3, 4, 5, 6]
                        }
                    }
                ],");
                WriteLiteral(@"
                ""order"": [],
                ""responsive"": true,
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"": urlString,
                    ""type"": ""Get"",
                    ""data"": { 'status': dataStatus, 'nik': NIK },
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
                ],
                ""columns"": [
                    {
                      ");
                WriteLiteral(@"  ""data"": null,
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
                            return moment(data).format('DD/MM/YYYY');
                        }
                    },
                    {");
                WriteLiteral(@"
                        ""data"": 'requestDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format('DD/MM/YYYY');
                        }
                    },
                    {
                        ""data"": 'requestID',
                        ""render"": function (data, type, row, meta) {
                            if (dataStatus == 'Pending') {
                                return '<button class=""btn btn-outline-danger waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Approval Needed"" onclick=""GetDetail(\'' + row['requestID'] + '\')""><i class=""fa fa-info-circle""></i> Approval</button>'
                            } else {
                                return '<button class=""btn btn-outline-info waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Detail Information"" onclick=""GetDetail(\'' + row['requestID'] + '\')""><i class=""fa fa-info-circle""></i> Details</button>'
 ");
                WriteLiteral(@"                           }
                        }
                    }
                ]
            })
        }

    function GetDetail(id) {
            reset();
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
                    $('#ManagerName').html(data.employee.manager.employeeName)
                    $('#JoinDate').html(moment(data.employee.joinDate).format('DD MMMM YYYY'))
                    $('#RequestID').html(data.requestID)
                    $('#RequestIDText').html(data.requestID)
                    $('");
                WriteLiteral(@"#CompensationName').html(data.compensation.compensationName)
                    $('#EventDate').html(moment(data.eventDate).format('DD MMMM YYYY'))
                    $('#RequestDate').html(moment(data.requestDate).format('DD MMMM YYYY'))

                    for (var i = 0; i < data.documents.length; i++) {
                        if (data.documents[i].link.match(/(.*?)\.(pdf|PDF)$/)) {
                            var documentList = '<a target=""_blank"" href=""' + data.documents[i].link
                                + '""><img src=""/lib/src/images/pdf.png"" width=""30"">' + data.documents[i].documentName + '</><br/>'
                        } else if (data.documents[i].link.match(/(.*?)\.(jpg|jpeg|JPG|JPEG)$/)) {
                            var documentList = '<a target=""_blank"" href=""' + data.documents[i].link
                                + '""><img src=""/lib/src/images/images.png"" width=""30"">' + data.documents[i].documentName + '</><br/>'
                        }
                        $('#Do");
                WriteLiteral("cument\').append(documentList);\r\n                    }\r\n                }\r\n            });\r\n        $(\'#modal\').modal(\'show\');\r\n\r\n");
                WriteLiteral(@"        };

        function reset() {
            $('#Document').empty();
            $(""#tablestatus tbody"").empty();
        }

        var statusID;
        $('.btn').on('click', function () {
            debugger;
            statusID = parseInt($(this).val())
        })

        $('#formApproval').submit(function (event) {
            debugger;
            event.preventDefault()
            var requestID = parseInt(document.getElementById(""RequestID"").innerHTML);
            var UpdateStatusVM = new Object();
            UpdateStatusVM.newStatusID = statusID;
            UpdateStatusVM.requestID = requestID;
            debugger;
            $.ajax({
                type: ""POST"",
                url: ""/Approval/UpdateStatus"",
                data: JSON.stringify(UpdateStatusVM),
                headers: { 'Authorization': 'Bearer ' + localStorage.token },
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success:");
                WriteLiteral(@" function (result) {
                    debugger;
                    Swal.fire({
                        title: '<strong>Thank You</strong>',
                        icon: 'info',
                        html:
                            'you succeeded in <b>giving approval</b> ',
                        showCloseButton: true,
                        focusConfirm: false,
                        confirmButtonText:
                            '<i class=""fa fa-thumbs-up""></i> Great!',
                        confirmButtonAriaLabel: 'Thumbs up, great!',
                    }).then((result) => {
                        debugger;
                        if (result.isConfirmed) {
                            reset();
                            $('#modal').modal('hide');
                            urlString = ""/Request/RequestList"";
                            dataStatus = ""Pending"";
                            $('#table_id').DataTable().destroy();
                            myTable();
      ");
                WriteLiteral("                  }\r\n                    })\r\n                }\r\n            })\r\n        })\r\n\r\n</script>\r\n");
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
