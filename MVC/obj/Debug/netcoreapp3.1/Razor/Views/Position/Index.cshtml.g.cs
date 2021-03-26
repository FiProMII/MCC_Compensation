#pragma checksum "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Position\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd650576eb6f4a7a81d13b6dc1726e098ff602b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Position_Index), @"mvc.1.0.view", @"/Views/Position/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd650576eb6f4a7a81d13b6dc1726e098ff602b1", @"/Views/Position/Index.cshtml")]
    public class Views_Position_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Position\Index.cshtml"
   Layout = "_LayoutAdmin";
    ViewData["Title"] = "Position";

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
#line 14 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Position\Index.cshtml"
                                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\"><a href=\"javascript:void(0)\">Home</a></li>\r\n                <li class=\"breadcrumb-item active\">");
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Position\Index.cshtml"
                                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </div>
        <div class=""col-md-6 col-4 align-self-center"">
            <button class=""btn pull-right hidden-sm-down btn-success"" data-toggle=""modal"" data-target="".bs-modal-sm"" onclick=""reset()""><i class=""mdi mdi-plus-circle""></i> Create</button>
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
                    <div class=""table-responsiv");
            WriteLiteral(@"e m-t-40"">
                        <table id=""table_id"" class=""display nowrap table table-hover table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>No.</th>
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Department</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <th>No.</th>
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Department</th>
                                    <th>Actions</th>
                                </tr>
   ");
            WriteLiteral(@"                         </tfoot>
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

<div class=""modal fade bs-modal-sm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""mySmallModalLabel"" aria-hidden=""true"" style=""display: none;"">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""mySmallModalLabel""><i class=""icon-people""></i> ");
#nullable restore
#line 78 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Position\Index.cshtml"
                                                                                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Management</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"" onclick=""reset()"">×</button>
            </div>
            <div class=""modal-body"">
                <form id=""form"" name=""form"">
                    <div class=""form-row"">
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" name=""PositionID"" id=""PositionID"" hidden>
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group"">
                            <label for=""departmentID"" class=""col-form-label"">Department <span class=""text-danger"">*</span></label>
                            <select class=""form-control"" id=""DepartmentID"" name=""DepartmentID""></select>
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group"">
                            <");
            WriteLiteral(@"label for=""firstName"" class=""col-form-label"">Position Name <span class=""text-danger"">*</span></label>
                            <input type=""text"" class=""form-control"" name=""PositionName"" id=""PositionName"">
                        </div>
                    </div>
                </form>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary waves-effect waves-ligh"" data-dismiss=""modal"" aria-hidden=""true"" onclick=""Readonly()"">Close</button>
                <button class=""btn btn-primary waves-effect waves-ligh"" type=""submit"" form=""form"" id=""Submit"">Submit</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var isUpdate = 0;
        $(document).ready(function () {
            $.ajax({
                type: ""GET"",
                url: '/Department/Get',
                success: function (result) {
                    var data = result['result']
                    var s = '<option value=""-1"">Please Select a Department</option>';
                    for (var i = 0; i < data.length; i++) {
                        s += '<option value=""' + data[i].departmentID + '"">' + data[i].departmentName + '</option>';
                    }
                    $(""#DepartmentID"").html(s);
                }
            });

            $('#table_id').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    {
                        extend: 'csv',
                        exportOptions: {
                            columns: [0, 2, 3]
                        }
                    },
                    {
                        extend: 'excel',
       ");
                WriteLiteral(@"                 exportOptions: {
                            columns: [0, 2, 3]
                        }
                    },
                    {
                        extend: 'pdf',
                        exportOptions: {
                            columns: [0, 2, 3]
                        }
                    }
                ],
                ""responsive"": true,
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"": ""get"",
                    ""type"": ""get"",
                    ""dataSrc"": ""result""
                },
                ""columnDefs"": [
                    {
                        ""targets"": [1],
                        ""visible"": false,
                    },
                    {
                        ""targets"": [0, 4],
                        ""orderable"": false,
                    }
                ],
                ""columns"": [
                    {
                        ""dat");
                WriteLiteral(@"a"": null,
                        ""name"": ""no"",
                        ""autowidth"": true,
                        ""render"": function (data, type, row, meta) {
                            return meta.row + meta.settings._iDisplayStart + 1;
                        }
                    },
                    { ""data"": 'positionID' },
                    { ""data"": 'positionName' },
                    { ""data"": 'department.departmentName' },
                    {
                        ""data"": 'positionID',
                        ""render"": function (data, type, row, meta) {
                            return '<button class=""btn btn-sm btn-success waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit""  onclick=""Get(\'' + row['positionID'] + '\')""><i class =""mdi mdi-table-edit""></i> Edit</button> ' +
                                '<button class=""btn btn-sm btn-danger waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Delete(\''");
                WriteLiteral(@" + row['positionID'] + '\')""><i class =""mdi mdi-delete""></i> Delete</button>'
                        }
                    }
                ]
            });
        });

        function Readonly() {
            $('#positionID').attr('readonly', false);
            validator.resetForm();
        }

        var validator = $(""#form"").validate({
            rules: {
                PositionName: ""required""
            },
            messages: {
                PositionName: ""<small class='text-danger'>Please enter <code>Position Name.</code></small>""
            },
            submitHandler: function (form) {
                var form = $(form);
                var urlString;
                if (isUpdate == 1)
                    urlString = ""/Position/Put""
                else
                    urlString = ""/Position/Post""
                $.ajax({
                    type: ""POST"",
                    url: urlString,
                    data: form.serialize(),
                 ");
                WriteLiteral(@"   success: function (data) {
                        $('.bs-modal-sm').modal('hide');
                        $('#table_id').DataTable().ajax.reload();
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Your data has been saved',
                            showConfirmButton: false,
                            timer: 1500
                        })
                    },
                    error: function (error) {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Something went wrong!',
                            footer: '<a href>Your Work cannot be saved</a>'
                        })
                    }
                });
            }
        });

        function reset() {
            isUpdate = 0;
            $('#form').trigger('reset');
        }

");
                WriteLiteral(@"        function Get(id) {
            $.ajax({
                url: ""/Position/GetById"",
                type: ""GET"",
                data: { 'key': id },
                success: function (result) {
                    $('.bs-modal-sm').modal('show');
                    var data = result[""result""];
                    $('#PositionID').val(data.positionID);
                    $('#PositionName').val(data.positionName);
                    $('#DepartmentID').val(data.department.departmentID)
                    isUpdate = 1;
                }
            });
        }

        function Delete(id) {
            swal.fire({
                title: 'Are you sure?',
                text: ""You won't be able to revert this!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                if");
                WriteLiteral(@" (result.isConfirmed) {
                    $.ajax({
                        type: ""POST"",
                        url: ""/Position/Delete"",
                        data: { 'key': id },
                        success: function (data) {
                            $('#table_id').DataTable().ajax.reload();
                            Swal.fire(
                                'Deleted!',
                                'Your data has been deleted.',
                                'success'
                            )
                        },
                        error: function (error) {
                            Swal.fire({
                                icon: 'error',
                                title: 'Oops...',
                                text: 'Something went wrong!',
                                footer: '<a href>Your Work cannot be saved</a>'
                            })
                        },
                    });
                }
            });
        }

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
