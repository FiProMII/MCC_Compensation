#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306219785bed97f62218581b247af28d4825d046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306219785bed97f62218581b247af28d4825d046", @"/Views/Employee/Index.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Employee\Index.cshtml"
   Layout = "_Layout";
    ViewBag.Title = "Employee";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" id=""employee"">
    <h2 class=""page-header"">
        Data Employee
    </h2>

    <button type=""button"" class=""mb-3 btn btn-primary text-center"" data-toggle=""modal"" data-target=""#modal"" onclick=""reset()"">
        <i class=""fas fa-user-plus""></i> Create
    </button>

    <div>
        <table id=""table_id"" class=""table table-sm table-striped table-bordered m-2"">
            <thead>
                <tr>
                    <th>No.</th>
                    <th>NIK</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Address</th>
                    <th>Birth</th>
                    <th>Join Date</th>
                    <th>Position</th>
                    <th>Manager</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
            <tfoot>
                <tr>
                    <th>No.</th>
             ");
            WriteLiteral(@"       <th>NIK</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Address</th>
                    <th>Birth</th>
                    <th>Join Date</th>
                    <th>Position</th>
                    <th>Manager</th>
                    <th>Actions</th>
                </tr>
            </tfoot>
        </table>
    </div>
</div>

<div class=""modal fade"" role=""dialog"" id=""modal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Employee</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"" onclick=""Readonly()"">&times;</span></button>
            </div>
            <div class=""modal-body"">
                <form id=""form"" name=""form"">
                    <div class=""form-row"">
                        <div class=""col-6"">
           ");
            WriteLiteral(@"                 <div class=""form-group"">
                                <label for=""nik"" class=""col-form-label"">NIK</label>
                                <input type=""text"" class=""form-control"" name=""NIK"" id=""NIK"">
                            </div>
                            <div class=""form-group"">
                                <label for=""employeeName"" class=""col-form-label"">Name</label>
                                <input type=""text"" class=""form-control"" name=""EmployeeName"" id=""EmployeeName"">
                            </div>
                            <div class=""form-group"">
                                <label for=""email"" class=""col-form-label"">Email</label>
                                <input type=""email"" class=""form-control"" name=""Email"" id=""Email"">
                            </div>
                            <div class=""form-group"">
                                <label for=""phone"" class=""col-form-label"">Phone</label>
                                <input type=""tex");
            WriteLiteral(@"t"" class=""form-control"" name=""Phone"" id=""Phone"">
                            </div>
                            <div class=""form-group"">
                                <label for=""address"" class=""col-form-label"">Address</label>
                                <input type=""text"" class=""form-control"" name=""Address"" id=""Address"">
                            </div>
                            <div class=""form-check"" id=""roleCheckbox"">
                                <label for=""role"" class=""form-check-label"">Role</label>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <label for=""birthPlace"" class=""col-form-label"">Birth Place</label>
                                <input type=""text"" class=""form-control"" name=""BirthPlace"" id=""BirthPlace"">
                            </div>
                            <div class=""form-group"">
                           ");
            WriteLiteral(@"     <label for=""birthDate"" class=""col-form-label"">Birth Date</label>
                                <input type=""date"" class=""form-control"" name=""BirthDate"" id=""BirthDate"">
                            </div>
                            <div class=""form-group"">
                                <label for=""joinDate"" class=""col-form-label"">Join Date</label>
                                <input type=""date"" class=""form-control"" name=""JoinDate"" id=""JoinDate"">
                            </div>
                            <div class=""form-group"">
                                <label for=""departmentDropdown"" class=""col-form-label"">Department</label>
                                <select class=""form-control"" id=""DepartmentDropdown"" name=""DepartmentDropdown""></select>
                            </div>
                            <div class=""form-group"">
                                <label for=""positionID"" class=""col-form-label"">Position</label>
                                <select class=""form");
            WriteLiteral(@"-control"" id=""PositionID"" name=""PositionID""></select>
                            </div>
                            <div class=""form-group"">
                                <label for=""managerNIK"" class=""col-form-label"">Manager</label>
                                <select class=""form-control"" id=""ManagerNIK"" name=""ManagerNIK""></select>
                            </div>
                        </div>
                    </div>
                </form>
            </div>
            <div class=""modal-footer"">
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
        function tes() {
            var myCheckboxes = new Array();
            $(""input:checked"").each(function () {
                myCheckboxes.push(parseInt($(this).val()));
            });

            for (var i = 0; i < myCheckboxes.length; i++) {
                var role = new Object();
                role.nik = ""108"";
                role.roleID = myCheckboxes[i]

                $.ajax({
                    type: ""POST"",
                    url: ""/AccountRole/Post"",
                    data: JSON.stringify(role),
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json""
                });
            }
            
        }
        var isUpdate = 0;
        $(document).ready(function () {
            $.ajax({
                type: ""GET"",
                url: '/role/get',
                success: function (result) {
                    var data = result['result']
                    for (var i = 0; i < data");
                WriteLiteral(@".length; i++) {
                        var roleCheckbox = '<br><input type=""checkbox"" class=""form-check-input"" name=""' + data[i].roleName + '""value=""' + data[i].roleID + '""> ' + data[i].roleName;
                        $(""#roleCheckbox"").append(roleCheckbox);
                    }
                }
            });

            var departmentDropdown = '<option value=""-1"">Please select a department</option>';
            $.ajax({
                type: ""GET"",
                url: '/department/get',
                success: function (result) {
                    var data = result['result']
                    for (var i = 0; i < data.length; i++) {
                        departmentDropdown += '<option value=""' + data[i].departmentID + '"">' + data[i].departmentName + '</option>';
                        $(""#DepartmentDropdown"").html(departmentDropdown);
                    }
                }
            });

            $(""select#DepartmentDropdown"").on('change', function () {
          ");
                WriteLiteral(@"      var selectedDepartment = $('#DepartmentDropdown option:selected').val();
                $.ajax({
                    type: ""GET"",
                    url: '/position/get',
                    success: function (result) {
                        var positionDropdown = '<option value=""-1"">Please select a position</option>';
                        var data = result['result']
                        for (var i = 0; i < data.length; i++) {
                            if (data[i].departmentID == selectedDepartment) {
                                positionDropdown += '<option value=""' + data[i].positionID + '"">' + data[i].positionName + '</option>';
                                $(""#PositionID"").html(positionDropdown);
                            }
                        }
                    }
                });


                $(""select#PositionID"").on('change', function () {
                    var selectedPosition = $('#PositionID option:selected').text();
                    $");
                WriteLiteral(@".ajax({
                        type: ""GET"",
                        url: '/employee/get',
                        success: function (result) {
                            var managerDropdown = '<option value=""-1"">Please select a manager</option>';
                            var data = result['result']
                            if (selectedPosition != ""RM"" && selectedPosition != ""RM "") {
                                managerDropdown = '<option value=""-1"">Please select a manager</option>';
                                for (var i = 0; i < data.length; i++) {
                                    if (data[i].position.departmentID == selectedDepartment) {
                                        managerDropdown += '<option value=""' + data[i].nik + '"">' + data[i].employeeName + '</option>';
                                        $(""#ManagerNIK"").html(managerDropdown);
                                    }
                                }
                            } else {
                  ");
                WriteLiteral(@"              managerDropdown = '< option value = ""-1"" > Please select a manager</option >';
                                $(""#ManagerNIK"").html(managerDropdown);
                            }
                        }
                    });
                })
            });

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
      ");
                WriteLiteral(@"                  extend: 'pdf',
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
                        ""targets"": [0, 4, 10],
                        ""orderable"": false,
                    }
                ],
                ""columns"": [
                    {
                        ""data"": null,
                        ""name"": ""no"",
                        ""autowidth"": true,
                        ""render"": function (data, type, row, meta) {
                            return ");
                WriteLiteral(@"meta.row + meta.settings._iDisplayStart + 1;
                        }
                    },
                    { ""data"": 'nik' },
                    { ""data"": 'employeeName' },
                    { ""data"": 'email' },
                    { ""data"": 'phone' },
                    { ""data"": 'address' },
                    {
                        ""data"": 'birth',
                        ""render"": function (data, type, row, meta) {
                            return row['birthPlace'] + ', ' + moment(row['birthDate']).format('DD/MM/YYYY')
                        }
                    },
                    {
                        ""data"": 'joinDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format('DD/MM/YYYY');
                        }
                    },
                    { ""data"": 'position.positionName' },
                    {
                        ""data"": 'manager',
                        ""render"": fu");
                WriteLiteral(@"nction (data) {
                            if (data!= null)
                                return data.employeeName
                            return ''
                        }
                    },
                    {
                        ""data"": 'nik',
                        ""render"": function (data, type, row, meta) {
                            return '<a class=""btn btn-success"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit""  onclick=""Get(\'' + row['nik'] + '\')""><i class =""far fa-edit""></i> Edit</a> ' +
                                '<button class=""btn btn-danger"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Delete(\'' + row['nik'] + '\')""><i class =""far fa-trash-alt""></i> Delete</button>'
                        }
                    }
                ]
            });
        });

        function Readonly() {
            $('#NIK').attr('readonly', false);
            $('#Email').attr('readonly', false);
            validator.resetForm();");
                WriteLiteral(@"
        }

        var validator = $(""#form"").validate({
            rules: {
                EmployeeName: ""required"",
                Email: {
                    required: true,
                    email: true
                },
                Phone: {
                    required: true,
                    number: true,
                    minlength: 10
                },
                Address: ""required"",
                BirthPlace: ""required"",
                BirthDate: {
                    required: true,
                    date: true
                },
                JoinDate: {
                    required: true,
                    date: true
                },
                Position: ""required""
            },
            messages: {
                EmployeeName: ""Please enter employee name""
            },
            submitHandler: function (form) {
                var form = $(form);

                var nikValue = $('#NIK').val()
                var myCh");
                WriteLiteral(@"eckboxes = new Array();
                $(""input:checked"").each(function () {
                    myCheckboxes.push(parseInt($(this).val()));
                });

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
                            icon: 'success',
                            title: 'Your data has been saved',
                            showConfirmButton: false,
                            timer: 1500
                        })

                        for (var i = 0; i < myCheckboxes.length; i++) {
                            var role = new Object(");
                WriteLiteral(@");
                            role.nik = nikValue;
                            role.roleID = myCheckboxes[i]

                            $.ajax({
                                type: ""POST"",
                                url: ""/AccountRole/PostFromBody"",
                                data: JSON.stringify(role),
                                contentType: ""application/json; charset=utf-8"",
                                dataType: ""json""
                            });
                        }
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
            ");
                WriteLiteral(@"$('#form').trigger('reset');
            $('#PositionID').empty();
        }

        function Get(id) {
            $('#NIK').attr('readonly', true);
            $('#Email').attr('readonly', true);
            $.ajax({
                url: ""GetById"",
                type: ""GET"",
                data: { 'key': id },
                success: function (result) {
                    $('#modal').modal('show');
                    var data = result[""result""];
                    $('#NIK').val(data.nik);
                    $('#EmployeeName').val(data.employeeName);
                    $('#Email').val(data.email);
                    $('#Phone').val(data.phone);
                    $('#Address').val(data.address);
                    $('#BirthPlace').val(data.birthPlace);
                    $('#BirthDate').val(moment(data.birthDate).format('YYYY-MM-DD'));
                    $('#JoinDate').val(moment(data.joinDate).format('YYYY-MM-DD'));
                    $('#DepartmentDropdown').val(data.p");
                WriteLiteral(@"osition.departmentID).change();
                    $('#PositionID').val(data.positionID).change();
                    $('#ManagerNIK').val(data.manager.nik);
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
                    $.ajax({
                        type: ""POST"",
                        url: ""/Account/Delete"",
                        data: { 'key': id },
                        success: function (data) {
                            table.ajax.reload();
                            Swal.fire(
               ");
                WriteLiteral(@"                 'Deleted!',
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
