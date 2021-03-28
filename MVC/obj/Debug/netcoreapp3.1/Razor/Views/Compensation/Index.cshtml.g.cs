#pragma checksum "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Compensation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea4bf4f1cac31790e95b51278ab55cb8a7d5ac01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compensation_Index), @"mvc.1.0.view", @"/Views/Compensation/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea4bf4f1cac31790e95b51278ab55cb8a7d5ac01", @"/Views/Compensation/Index.cshtml")]
    public class Views_Compensation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Compensation\Index.cshtml"
   Layout = "_LayoutAdmin";
    ViewData["Title"] = "Compensation";

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
#line 14 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Compensation\Index.cshtml"
                                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\"><a href=\"javascript:void(0)\">Home</a></li>\r\n                <li class=\"breadcrumb-item active\">");
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Compensation\Index.cshtml"
                                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </div>
        <div class=""col-md-6 col-4 align-self-center"">
            <button class=""btn pull-right hidden-sm-down btn-success"" data-toggle=""modal"" data-target="".bs-modal-sm""><i class=""mdi mdi-plus-circle""></i> Create</button>
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
            WriteLiteral(@"                  <table id=""table_id"" class=""display nowrap table table-hover table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>No</th>
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Cost</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <th>No</th>
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Cost</th>
                                    <th>Actions</th>
                                </tr>
                            </tfoot");
            WriteLiteral(@">
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
                <h4 class=""modal-title"" id=""mySmallModalLabel""><i class=""icon-heart""></i> ");
#nullable restore
#line 78 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Compensation\Index.cshtml"
                                                                                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Management</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"" onclick=""reset()"">×</button>
            </div>
            <div class=""modal-body"">
                <form id=""form"" name=""form"">
                    <input type=""hidden"" class=""form-control"" name=""CompensationID"" id=""CompensationID"">
                    <div class=""form-group"">
                        <label for=""compensationName"" class=""col-form-label"">Compensation Name <span class=""text-danger"">*</span></label>
                        <input type=""text"" class=""form-control"" name=""CompensationName"" id=""CompensationName"">
                    </div>
                    <div class=""form-group"">
                        <label for=""cost"" class=""col-form-label"">Cost <span class=""text-danger"">*</span></label>
                        <input type=""text"" class=""form-control"" name=""Cost"" id=""Cost"">
                    </div>
                </form>
            </div>
            <div class=""moda");
            WriteLiteral(@"l-footer"">
                <button class=""btn btn-secondary waves-effect waves-light"" data-dismiss=""modal"" aria-hidden=""true"" onclick=""reset()"">Close</button>
                <button class=""btn btn-primary waves-effect waves-light"" type=""submit"" form=""form"" id=""Sumbit"">Submit</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var isUpdate;
        $(document).ready(function () {
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
                        exportOptions: {
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
                    ""url"": ""/Compensation/Get"",
                    ""type"":");
                WriteLiteral(@" ""Get"",
                    ""dataSrc"": ""result"",
                },
                ""columnDefs"": [
                    {
                        ""targets"": [1],
                        ""visible"": false,
                    },
                    {
                        ""targets"": [2, 4],
                        ""orderable"": false,
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
                    { ""data"": 'compensationID' },
                    { ""data"": 'compensationName' },
                    {
                        ""data"": 'cost',
                        render: $.fn.dataTable.render.number(',', '.', 2, 'Rp. ')
      ");
                WriteLiteral(@"              },
                    {
                        ""data"": 'compensationID',
                        ""render"": function (data, type, row, meta) {
                            return '<button class=""btn btn-sm btn-success waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit""  onclick=""Get(\'' + row['compensationID'] + '\')""><i class=""mdi mdi-table-edit""></i> Edit</button> ' +
                                '<button class=""btn btn-sm btn-danger waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Delete(\'' + row['compensationID'] + '\')""><i class=""mdi mdi-delete""></i> Delete</button>'
                        }
                    }
                ]
            });
        });

        var validator = $(""#form"").validate({
            rules: {
                CompensationName: ""required"",
                Cost: {
                    required: true,
                    digits: true
                }
            },");
                WriteLiteral(@"
            messages: {
                CompensationName: ""<small class='text-danger'>Please enter <code>Compensation Name.</code></small>"",
                Cost: {
                    required: ""<small class='text-danger'>Please type the<code>Cost.</code></small>"",
                    digits: ""<small class='text-danger'>Please enter <code>Only Numbers.</code></small>""
                }
            },
            submitHandler: function (form) {
                var form = $(form);
                var urlString;
                if (isUpdate == 1)
                    urlString = ""/Compensation/Put""
                else
                    urlString = ""/Compensation/Post""
                $.ajax({
                    type: ""POST"",
                    url: urlString,
                    headers: {
                        Authorization: sessionStorage.token
                    },
                    data: form.serialize(),
                    success: function (data) {
                       ");
                WriteLiteral(@" $('.bs-modal-sm').modal('hide');
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

        function Get(compensationID) {
            $.");
                WriteLiteral(@"ajax({
                url: ""/Compensation/GetById"",
                type: ""GET"",
                data: { 'key': compensationID },
                headers: {
                    Authorization: sessionStorage.token
                },
                success: function (result) {
                    $('.bs-modal-sm').modal('show');
                    var data = result['result'];
                    $('#CompensationID').val(data.compensationID);
                    $('#CompensationName').val(data.compensationName);
                    $('#Cost').val(data.cost);
                    isUpdate = 1;
                }
            });
        }

        function Delete(compensationID) {
            debugger;
            swal.fire({
                title: 'Are you sure?',
                text: ""You won't be able to revert this!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
   ");
                WriteLiteral(@"             confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: ""POST"",
                        url: ""/Compensation/Delete"",
                        data: { 'key': compensationID },
                        headers: {
                            Authorization: sessionStorage.token
                        },
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
                    ");
                WriteLiteral(@"            text: 'Something went wrong!',
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
