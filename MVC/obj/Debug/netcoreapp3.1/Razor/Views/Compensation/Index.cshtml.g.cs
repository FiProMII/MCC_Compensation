#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Compensation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dd544d9534a4a144a33d981dce28d10423650c3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd544d9534a4a144a33d981dce28d10423650c3", @"/Views/Compensation/Index.cshtml")]
    public class Views_Compensation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\MCC_Compensation\MVC\Views\Compensation\Index.cshtml"
   Layout = "_Layout";
    ViewBag.Title = "Compensation";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h2 class=""page-header"">
        Compensations
    </h2>
    <button type=""button"" class=""mb-3 btn btn-primary text-center"" data-toggle=""modal"" data-target=""#modal"" onclick=""reset()"">
        <i class=""fas fa-user-plus""></i> Create
    </button>
    <div>
        <table id=""table_id"" class=""table table-sm table-striped table-bordered m-2"">
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
            </tfoot>
        </table>
    </div>
    <div id=""chart""></div>
    <div id=""chart");
            WriteLiteral(@"2""></div>
</div>

<div class=""modal fade"" role=""dialog"" id=""modal"">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Compensation</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            </div>
            <div class=""modal-body"">
                <form id=""form"" name=""form"">
                    <input type=""hidden"" class=""form-control"" name=""CompensationID"" id=""CompensationID"">
                    <div class=""form-group"">
                        <label for=""compensationName"" class=""col-form-label"">Compensation Name</label>
                        <input type=""text"" class=""form-control"" name=""CompensationName"" id=""CompensationName"">
                    </div>
                    <div class=""form-group"">
                        <label for=""cost"" class=""col-form-label"">Cost</label>
        ");
            WriteLiteral(@"                <input type=""text"" class=""form-control"" name=""Cost"" id=""Cost"">
                    </div>
                </form>
            </div>
            <div class=""modal-footer"">
                <button class=""btn"" data-dismiss=""modal"" aria-hidden=""true"">Close</button>
                <button class=""btn btn-primary"" type=""submit"" form=""form"" id=""Sumbit"">Submit</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var isUpdate;
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
                            columns: [0, 2, 4, 5, 6, 7]
                        }
                    },
                    {
                        extend: 'excel',
                        exportOptions: {
                            columns: [0, 2, 4, 5, 6, 7]
                        }
                    },
                    {
                        extend: 'pdf',
                        exportOptions: {
                            columns: [0, 2, 4, 5, 6, 7]
                        }
                    }
  ");
                WriteLiteral(@"              ],
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"": ""Get"",
                    ""type"": ""Get"",
                    ""dataSrc"": ""result"",
                    ""beforeSend"": function (xhr) {
                        xhr.setRequestHeader('Authorization', sessionStorage.token);
                    },
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
                            return meta.row + met");
                WriteLiteral(@"a.settings._iDisplayStart + 1;
                        }
                    },
                    { ""data"": 'compensationID' },
                    { ""data"": 'compensationName' },
                    {
                        ""data"": 'cost',
                        render: $.fn.dataTable.render.number(',', '.', 2, 'Rp. ')
                    },
                    {
                        ""data"": 'compensationID',
                        ""render"": function (data, type, row, meta) {
                            return '<a class=""btn btn-success"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit""  onclick=""Get(\'' + row['compensationID'] + '\')""><i class =""far fa-edit""></i> Edit</a> ' +
                                '<button class=""btn btn-danger"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Delete(\'' + row['compensationID'] + '\')""><i class =""far fa-trash-alt""></i> Delete</button>'
                        }
                    }
                ]
            });");
                WriteLiteral(@"
        });

        var validator = $(""#form"").validate({
            rules: {
                CompensationName: ""required"",
                Cost: {
                    required: true,
                    digits: true
                }
            },
            messages: {
                CompensationName: ""Please enter Compensation Name"",
                Cost: {
                    required: ""Please type the Cost"",
                    number: ""Please type only numbers""
                }
            },
            submitHandler: function (form) {
                var form = $(form);
                var urlString;
                if (isUpdate == 1)
                    urlString = ""Put""
                else
                    urlString = ""Post""
                $.ajax({
                    type: ""POST"",
                    url: urlString,
                    headers: {
                        Authorization: sessionStorage.token
                    },
                    data: fo");
                WriteLiteral(@"rm.serialize(),
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
                            footer: '<a href>Your Work cannot be saved</a>'
                        })
                    }
                });
            }
        });

        function reset() {
            isUpdate = 0;
            $('#form').trigger('reset');
      ");
                WriteLiteral(@"  }

        function Get(compensationID) {
            debugger;
            $.ajax({
                url: ""GetById"",
                type: ""GET"",
                data: { 'key': compensationID },
                headers: {
                    Authorization: sessionStorage.token
                },
                success: function (result) {
                    $('#modal').modal('show');
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
                confirmButtonCo");
                WriteLiteral(@"lor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: ""POST"",
                        url: ""Delete"",
                        data: { 'key': compensationID },
                        headers: {
                            Authorization: sessionStorage.token
                        },
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
                                title: 'Oo");
                WriteLiteral(@"ps...',
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
