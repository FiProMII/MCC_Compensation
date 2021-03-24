#pragma checksum "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Position\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bf726e3aa72181bb4028ace047b3b6d08126ae0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bf726e3aa72181bb4028ace047b3b6d08126ae0", @"/Views/Position/Index.cshtml")]
    public class Views_Position_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Position\Index.cshtml"
   Layout = "_Layout";
    ViewBag.Title = "Position";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <br />
    <div class=""col-sm-12 text-right"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Position</li>
        </ol>
    </div>
    <h2 class=""page-header"">
        <i class=""fas fa-user-friends""></i> Position
    </h2>
    <br />
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
                    <th>Department</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
            <tfoot>
           ");
            WriteLiteral(@"     <tr>
                    <th>No.</th>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Department</th>
                    <th>Actions</th>
                </tr>
            </tfoot>
        </table>
    </div>
</div>

<div class=""modal fade"" role=""dialog"" id=""modal"">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Position</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"" onclick=""Readonly()"">&times;</span></button>
            </div>
            <div class=""modal-body"">
                <form id=""form"" name=""form"">
                    <div class=""form-row"">
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" name=""PositionID"" id=""PositionID"" hidden>
                        </div>
                   ");
            WriteLiteral(@" </div>
                    <div class=""form-row"">
                        <div class=""form-group"">
                            <label for=""departmentID"" class=""col-form-label"">Department</label>
                            <select class=""form-control"" id=""DepartmentID"" name=""DepartmentID""></select>
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group"">
                            <label for=""firstName"" class=""col-form-label"">Position Name</label>
                            <input type=""text"" class=""form-control"" name=""PositionName"" id=""PositionName"">
                        </div>
                    </div>
                </form>
            </div>
            <div class=""modal-footer"">
                <button class=""btn"" data-dismiss=""modal"" aria-hidden=""true"" onclick=""Readonly()"">Close</button>
                <button class=""btn btn-primary"" type=""submit"" form=""form"" id=""Submit"">Submit</button>");
            WriteLiteral("\r\n            </div>\r\n        </div><!-- /.modal-content -->\r\n    </div><!-- /.modal-dialog -->\r\n</div><!-- /.modal -->\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var isUpdate = 0;
        $(document).ready(function () {
            $.ajax({
                type: ""GET"",
                url: '/department/get',
                success: function (result) {
                    var data = result['result']
                    var s = '<option value=""-1"">Please Select a Department</option>';
                    for (var i = 0; i < data.length; i++) {
                        s += '<option value=""' + data[i].departmentID + '"">' + data[i].departmentName + '</option>';
                    }
                    $(""#DepartmentID"").html(s);
                }
            });

            table = $('#table_id').DataTable({
                responsive: true,
                dom: ""<'row'<'col-sm-5'l><'col-sm-4 text-center'B><'col-sm-3'f>>"" +
                    ""<'row'<'col-sm-12'tr>>"" +
                    ""<'row'<'col-sm-6'i><'col-sm-6'p>>"",
                buttons: [
                    {
                        extend: 'csv',
           ");
                WriteLiteral(@"             exportOptions: {
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
             ");
                WriteLiteral(@"           ""orderable"": false,
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
                    { ""data"": 'positionID' },
                    { ""data"": 'positionName' },
                    { ""data"": 'department.departmentName' },
                    {
                        ""data"": 'positionID',
                        ""render"": function (data, type, row, meta) {
                            return '<a class=""btn btn-success"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit""  onclick=""Get(\'' + row['positionID'] + '\')""><i class =""far fa-edit""></i> Edit</a> ' +
                                '<button class=""btn btn-danger"" da");
                WriteLiteral(@"ta-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Delete(\'' + row['positionID'] + '\')""><i class =""far fa-trash-alt""></i> Delete</button>'
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
                PositionName: ""Please enter position name""
            },
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
         ");
                WriteLiteral(@"           success: function (data) {
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

        function Ge");
                WriteLiteral(@"t(id) {
            $.ajax({
                url: ""GetById"",
                type: ""GET"",
                data: { 'key': id },
                success: function (result) {
                    $('#modal').modal('show');
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
                if (result.isConfirmed) {
          ");
                WriteLiteral(@"          $.ajax({
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
