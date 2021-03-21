#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Status\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be5501363b2da5fafcbd638d074d8c60d621b0b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Status_Index), @"mvc.1.0.view", @"/Views/Status/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be5501363b2da5fafcbd638d074d8c60d621b0b0", @"/Views/Status/Index.cshtml")]
    public class Views_Status_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Status\Index.cshtml"
   Layout = "_Layout";
    ViewBag.Title = "Status";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h2 class=""page-header"">
        Data Status
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
                <h4 class=""modal-title"">Status</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"" onclick=""Readonly()"">&times;</span></button>
            </div>
            <div class=""modal-body"">
                <form id=""form"" name=""form"">
                    <div class=""form-row"">
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" name=""StatusID"" id=""StatusID"" hidden>
                        </div>
                        <div class=""form-group"">
                            <label for=""firstName"" class=""col-form-label"">Status Name</label>
                            <input type=""text"" class=""form-control"" name=""StatusName"" id=""StatusName"">
                        </div>
                    </div>
                </form>
            </div>
            <div class=""modal-footer"">
          ");
            WriteLiteral(@"      <button class=""btn"" data-dismiss=""modal"" aria-hidden=""true"" onclick=""Readonly()"">Close</button>
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
                dom: '<""top""lBf>rtip<""bottom"">',
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
                    },
                    'colvis'
                ],
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"":");
                WriteLiteral(@" ""get"",
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
                    { ""data"": 'statusID' },
                    { ""data"": 'statusName' },
                    {
                        ""data"": 'statusID',
                        ""render"": function (data, type, row, m");
                WriteLiteral(@"eta) {
                            return '<a class=""btn btn-success"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit""  onclick=""Get(\'' + row['statusID'] + '\')""><i class =""far fa-edit""></i> Edit</a> ' +
                                '<button class=""btn btn-danger"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Delete(\'' + row['statusID'] + '\')""><i class =""far fa-trash-alt""></i> Delete</button>'
                        }
                    }
                ]
            });
        });

        function Readonly() {
            $('#statusID').attr('readonly', false);
            validator.resetForm();
        }

        var validator = $(""#form"").validate({
            rules: {
                StatusName: ""required""
            },
            messages: {
                FirstName: ""Please enter status name""
            },
            submitHandler: function (form) {
                var form = $(form);
                var urlString;
                if (");
                WriteLiteral(@"isUpdate == 1)
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
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Something went wrong!',
                            footer: '<a");
                WriteLiteral(@" href>Your Work cannot be saved</a>'
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
                    $('#StatusID').val(data.statusID);
                    $('#StatusName').val(data.statusName);
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
                confirmButtonColor: '#3085d6',");
                WriteLiteral(@"
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
                                title: 'Oops...',
                                text: 'Something went wrong!',
                                footer: '<a href>Your Work cannot be saved</a>'
   ");
                WriteLiteral("                         })\r\n                        },\r\n                    });\r\n                }\r\n            });\r\n        }\r\n\r\n    </script>\r\n");
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
