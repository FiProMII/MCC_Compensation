#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81359502496c8a51e9fb25cf1f546f787233a35e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81359502496c8a51e9fb25cf1f546f787233a35e", @"/Views/Department/Index.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Department\Index.cshtml"
   Layout = "_Layout";
    ViewBag.Title = "Department";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h2 class=""page-header"">
        Departments
    </h2>

    <button type=""button"" class=""mb-3 btn btn-primary text-center"" data-toggle=""modal"" data-target=""#modal"" onclick=""reset()"">
        <i class=""fas fa-user-plus""></i> Create
    </button>

    <div>
        <table id=""table_id"" class=""table table-sm table-striped table-bordered m-2"">
            <thead>
                <tr>
                    <th>No.</th>
                    <th>ID</th>
                    <th>Name</th>
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
                    <th>Actions</th>
                </tr>
            </tfoot>
        </table>
    </div>
</div>

<div class=""modal fade"" role=""dialog"" id=""modal"">
    <div class=""modal-dialog modal-sm"">
        <d");
            WriteLiteral(@"iv class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Department</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"" onclick=""Readonly()"">&times;</span></button>
            </div>
            <div class=""modal-body"">
                <form id=""form"" name=""form"">
                    <div class=""form-row"">
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" name=""DepartmentID"" id=""DepartmentID"" hidden>
                        </div>
                        <div class=""form-group"">
                            <label for=""firstName"" class=""col-form-label"">Department Name</label>
                            <input type=""text"" class=""form-control"" name=""DepartmentName"" id=""DepartmentName"">
                        </div>
                    </div>
                </form>
            </div>
            <div class=""mo");
            WriteLiteral(@"dal-footer"">
                <button class=""btn"" data-dismiss=""modal"" aria-hidden=""true"" onclick=""Readonly()"">Close</button>
                <button class=""btn btn-primary"" type=""submit"" form=""form"" id=""Submit"">Submit</button>
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
            table = $('#table_id').DataTable({
                responsive: true,
                dom: ""<'row'<'col-sm-5'l><'col-sm-4 text-center'B><'col-sm-3'f>>"" +
                    ""<'row'<'col-sm-12'tr>>"" +
                    ""<'row'<'col-sm-6'i><'col-sm-6'p>>"",
                buttons: [
                    {
                        extend: 'csv',
                        exportOptions: {
                            columns: [0, 2]
                        }
                    },
                    {
                        extend: 'excel',
                        exportOptions: {
                            columns: [0, 2]
                        }
                    },
                    {
                        extend: 'pdf',
                        exportOptions: {
                            columns: [0, 2]
                        }
                    }
                ],
              ");
                WriteLiteral(@"  ""filter"": true,
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
                        ""targets"": [0, 3],
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
                    { ""data"": 'departmentID' },
                    { ""data"": 'departmentName' },
            ");
                WriteLiteral(@"        {
                        ""data"": 'departmentID',
                        ""render"": function (data, type, row, meta) {
                            return '<a class=""btn btn-success"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit""  onclick=""Get(\'' + row['departmentID'] + '\')""><i class =""far fa-edit""></i> Edit</a> ' +
                                '<button class=""btn btn-danger"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Delete(\'' + row['departmentID'] + '\')""><i class =""far fa-trash-alt""></i> Delete</button>'
                        }
                    }
                ]
            });
        });

        function Readonly() {
            $('#departmentID').attr('readonly', false);
            validator.resetForm();
        }

        var validator = $(""#form"").validate({
            rules: {
                DepartmentName: ""required""
            },
            messages: {
                DepartmentName: ""Please enter department name""
    ");
                WriteLiteral(@"        },
            submitHandler: function (form) {
                var form = $(form);
                var urlString;
                if (isUpdate == 1)
                    urlString = ""put""
                else
                    urlString = ""post""
                $.ajax({
                    type: ""POST"",
                    url: urlString,
                    data: form.serialize(),
                    success: function (data) {
                        $('#modal').modal('hide');
                        table.ajax.reload();
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
                            icon: 'error',");
                WriteLiteral(@"
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

        function Get(id) {
            $.ajax({
                url: ""GetById"",
                type: ""GET"",
                data: { 'key': id },
                success: function (result) {
                    $('#modal').modal('show');
                    var data = result[""result""];
                    $('#DepartmentID').val(data.departmentID);
                    $('#DepartmentName').val(data.departmentName);
                    isUpdate = 1;
                }
            });
        }

        function Delete(id) {
            swal.fire({
                title: 'Are you sure?',
                tex");
                WriteLiteral(@"t: ""You won't be able to revert this!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: ""POST"",
                        url: ""delete"",
                        data: { 'key': id },
                        success: function (data) {
                            table.ajax.reload();
                            Swal.fire(
                                'Deleted!',
                                'Your data has been deleted.',
                                'success'
                            )
                        },
                        error: function (error) {
                            Swal.fire({
                                icon: 'error',
                                titl");
                WriteLiteral(@"e: 'Oops...',
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
