#pragma checksum "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3976fb618ebe7145a0e9ddd5bbac14e43ef8b007"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3976fb618ebe7145a0e9ddd5bbac14e43ef8b007", @"/Views/Employee/Index.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Employee\Index.cshtml"
   Layout = "_LayoutAdmin";
    ViewData["Title"] = "Employee";

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
#line 14 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Employee\Index.cshtml"
                                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\"><a href=\"javascript:void(0)\">Home</a></li>\r\n                <li class=\"breadcrumb-item active\">");
#nullable restore
#line 17 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Employee\Index.cshtml"
                                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </div>
        <div class=""col-md-6 col-4 align-self-center"">
            <button class=""btn pull-right hidden-sm-down btn-success"" data-toggle=""modal"" data-target="".bs-modal-lg"" onclick=""reset()""><i class=""mdi mdi-plus-circle""></i> Create</button>
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
                      ");
            WriteLiteral(@"          <tr>
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
    <!-- =========================");
            WriteLiteral(@"===================================== -->
</div>
<!-- ============================================================== -->
<!-- End Container fluid  -->
<!-- ============================================================== -->

<!-- sample modal content -->
<div class=""modal fade bs-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"" style=""display: none;"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""myLargeModalLabel""><i class=""icon-user-follow""></i> ");
#nullable restore
#line 91 "C:\Users\Acer\source\repos\MCC_Compensation\MVC\Views\Employee\Index.cshtml"
                                                                                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Management</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
            </div>
            <div class=""modal-body"">
                <form id=""form"" name=""form"">
                    <div class=""form"">
                        <div class=""form-body"">
                            <div class=""row p-t-20"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""nik"" class=""control-label"">NIK <span class=""text-danger"">*</span></label>
                                        <div class=""controls"">
                                            <div class=""input-group"">
                                                <input type=""text"" class=""form-control"" name=""NIK"" id=""NIK"" placeholder=""NIK"" required data-validation-required-message=""This field is required"">
                                                <div class=""input-group-addon""><");
            WriteLiteral(@"i class=""ti-id-badge""></i></div>
                                            </div>
                                        </div>
                                        <span id=""ValidationNIK"" style=""display: none; color: red"">NIK already exist</span>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""employeeName"" class=""control-label"">Name <span class=""text-danger"">*</span></label>
                                        <div class=""controls"">
                                            <div class=""input-group"">
                                                <input type=""text"" class=""form-control"" name=""EmployeeName"" id=""EmployeeName"" placeholder=""Name"" required data-validation-required-message=""This field is required"">
                                                <div class=""input-group-addon");
            WriteLiteral(@"""><i class=""ti-user""></i></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""email"" class=""control-label"">Email <span class=""text-danger"">*</span></label>
                                        <div class=""controls"">
                                            <div class=""input-group"">
                                                <input type=""email"" class=""form-control"" name=""Email"" id=""Email"" placeholder=""Enter Email Address"" required data-validation-required-message=""This field is required"">
                                                <div class=""input-group-addon""><i class=""ti-email""></i></div>
             ");
            WriteLiteral(@"                               </div>
                                        </div>
                                    </div>
                                    <span id=""ValidationEmail"" style=""display:none; color:red"">Email already exist</span>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""phone"" class=""control-label"">Phone <span class=""text-danger"">*</span></label>
                                        <div class=""controls"">
                                            <div class=""input-group"">
                                                <span class=""input-group-addon"">(+62)</span>
                                                <input type=""number"" class=""form-control"" name=""Phone"" id=""Phone"" placeholder=""Enter Phone Number"" required data-validation-containsnumber-regex=""(\d)+"" data-validation-containsnumber-message=""No Characte");
            WriteLiteral(@"rs Allowed, Only Numbers"">
                                                <div class=""input-group-addon""><i class=""ti-mobile""></i></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""birthPlace"" class=""control-label"">Birth Place <span class=""text-danger"">*</span></label>
                                        <div class=""controls"">
                                            <div class=""input-group"">
                                                <input type=""text"" class=""form-control"" name=""BirthPlace"" id=""BirthPlace"" placeholder=""Birth Place"" required data-validation-required-message=""This field is required"">
     ");
            WriteLiteral(@"                                           <div class=""input-group-addon""><i class=""ti-location-pin""></i></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""birthPlace"" class=""control-label"">Birth Date <span class=""text-danger"">*</span></label>
                                        <div class=""controls"">
                                            <div class=""input-group"">
                                                <input type=""text"" class=""form-control"" name=""BirthDate"" id=""BirthDate"" placeholder=""dd/mm/yyyy"" required data-validation-required-message=""This field is required"">
                                                <span class=""input-group-addon""><i class=""icon-calender""></i></span>
 ");
            WriteLiteral(@"                                           </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""form-group"">
                                        <label for=""address"" class=""control-label"">Address <span class=""text-danger"">*</span></label>
                                        <div class=""controls"">
                                            <div class=""input-group"">
                                                <textarea type=""text"" class=""form-control"" name=""Address"" id=""Address"" required placeholder=""Enter Address""></textarea>
                                                <div class=""input-group-addon""><i class=""ti-map-alt""></i></div>
                                            </div>
                                   ");
            WriteLiteral(@"     </div>
                                    </div>
                                </div>
                            </div>
                            <hr class=""m-t-0 m-b-40"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""birthPlace"" class=""control-label"">Join Date <span class=""text-danger"">*</span></label>
                                        <div class=""controls"">
                                            <div class=""input-group"">
                                                <input type=""text"" class=""form-control"" name=""JoinDate"" id=""JoinDate"" placeholder=""dd/mm/yyyy"" required data-validation-required-message=""This field is required"">
                                                <span class=""input-group-addon""><i class=""icon-calender""></i></span>
                                            </div>
              ");
            WriteLiteral(@"                          </div>
                                    </div>
                                    <div class=""form-group"" id=""formCheckbox"">
                                        <label>User Role <span class=""text-danger"">*</span></label>
                                        <div class=""input-group"" id=""ulCheckbox"">
                                            <ul class=""icheck-list"" id=""roleCheckbox"">
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""departmentDropdown"" class=""control-label"">Department <span class=""text-danger"">*</span></label>
                                        <div class=""controls"">
                                            <select class=""form-control custom-s");
            WriteLiteral(@"elect"" id=""DepartmentDropdown"" name=""DepartmentDropdown"" required data-validation-required-message=""This field is required""></select>
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""positionID"" class=""control-label"">Position <span class=""text-danger"">*</span></label>
                                        <div class=""controls"">
                                            <select class=""form-control custom-select"" id=""PositionID"" name=""PositionID"" required data-validation-required-message=""This field is required""></select>
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""managerNIK"" class=""control-label"">Manager <span class=""text-blue"">(optional)</span></label>
                                  ");
            WriteLiteral(@"      <select class=""form-control custom-select"" id=""ManagerNIK"" name=""ManagerNIK""></select>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button class=""btn btn-secondary btn-rounded waves-effect waves-light"" data-dismiss=""modal"" aria-hidden=""true"" onclick=""Readonly()"">Close</button>
                        <button class=""btn btn-success btn-rounded waves-effect waves-light"" type=""submit"" form=""form"" id=""Submit"">Submit</button>
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
                WriteLiteral(@"
    <script>

        function tes() {
            var nik = ""117104""
            $.ajax({
                type: ""POST"",
                url: ""/AccountRole/Delete"",
                data: { 'key': nik }
            });
        }

        function selectCheckbox(value) {
            $(""[name="" + 'roles' + ""]"").each(function () {
                if ($(this).val() == value) {
                    $(this).attr('checked', true);
                }
            });
        }

        var isUpdate = 0;
        $(document).ready(function () {
            $.ajax({
                type: ""GET"",
                url: '/Role/Get',
                success: function (result) {
                    var data = result['result']
                    for (var i = 0; i < data.length; i++) {
                        if (i >= 8) {
                            var roleCheckbox = '<div class=""input-group"" id=""ulCheckbox""><ul class=""icheck-list"" id=""roleCheckbox""><li><input type=""checkbox"" class=""check"" data-check");
                WriteLiteral(@"box=""icheckbox_line-red"" value=""' + data[i].roleID + '""> ' + data[i].roleName + ' </li></ul ></div>';
                            $(""#formCheckbox"").append(roleCheckbox);
                        }
                        else if (i <= 3) {
                            var roleCheckbox = '<li><input type=""checkbox"" class=""check"" data-checkbox=""icheckbox_line-red"" value=""' + data[i].roleID + '""> ' + data[i].roleName + ' </li>';
                            $(""#roleCheckbox"").append(roleCheckbox);
                        }
                        else {
                            var roleCheckbox = '<ul class=""icheck-list"" id=""roleCheckbox""><li><input type=""checkbox"" class=""check"" data-checkbox=""icheckbox_line-red"" value=""' + data[i].roleID + '""> ' + data[i].roleName + ' </li></ul >';
                            $(""#ulCheckbox"").append(roleCheckbox);
                        }
                    }
                }
            });

            var departmentDropdown = '<option value=""-1"">Please sel");
                WriteLiteral(@"ect a department</option>';
            $.ajax({
                type: ""GET"",
                url: '/Department/Get',
                success: function (result) {
                    var data = result['result']
                    for (var i = 0; i < data.length; i++) {
                        departmentDropdown += '<option value=""' + data[i].departmentID + '"">' + data[i].departmentName + '</option>';
                        $(""#DepartmentDropdown"").html(departmentDropdown);
                    }
                }
            });

            $(""select#DepartmentDropdown"").on('change', function () {
                var selectedDepartment = $('#DepartmentDropdown option:selected').val();
                $.ajax({
                    type: ""GET"",
                    url: '/Position/Get',
                    success: function (result) {
                        var positionDropdown = '<option value=""-1"">Please select a position</option>';
                        var data = result['result']
   ");
                WriteLiteral(@"                     for (var i = 0; i < data.length; i++) {
                            if (data[i].departmentID == selectedDepartment) {
                                positionDropdown += '<option value=""' + data[i].positionID + '"">' + data[i].positionName + '</option>';
                                $(""#PositionID"").html(positionDropdown);
                            }
                        }
                    }
                });


                $(""select#PositionID"").on('change', function () {
                    var selectedPosition = $('#PositionID option:selected').text();
                    $.ajax({
                        type: ""GET"",
                        url: '/Employee/Get',
                        success: function (result) {
                            var managerDropdown = '<option value=""-1"">Please select a manager</option>';
                            var data = result['result']
                            if (selectedPosition != ""RM"") {
                     ");
                WriteLiteral(@"           $('#ManagerNIK').removeAttr(""disabled"");
                                managerDropdown = '<option value=""-1"">Please select a manager</option>';
                                for (var i = 0; i < data.length; i++) {
                                    if (data[i].position.departmentID == selectedDepartment) {
                                        managerDropdown += '<option value=""' + data[i].nik + '"">' + data[i].employeeName + '</option>';
                                        $(""#ManagerNIK"").html(managerDropdown);
                                    }
                                }
                            } else {
                                managerDropdown = '< option value = ""-1"" > Please select a manager</option >';
                                $(""#ManagerNIK"").html(managerDropdown);
                                $('#ManagerNIK').prop(""disabled"", true);
                            }
                        }
                    });
                })
    ");
                WriteLiteral(@"        });

            $('#table_id').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    {
                        extend: 'csv',
                        exportOptions: {
                            columns: [0, 2, 3, 4, 5, 6, 7, 8, 9]
                        }
                    },
                    {
                        extend: 'excel',
                        exportOptions: {
                            columns: [0, 2, 3, 4, 5, 6, 7, 8, 9]
                        }
                    },
                    {
                        extend: 'pdf',
                        exportOptions: {
                            columns: [0, 2, 3, 4, 5, 6, 7, 8, 9]
                        }
                    }
                ],
                ""responsive"": true,
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"": ""/Employee/Get"",
                    ""type"": ""GET"",
      ");
                WriteLiteral(@"              ""dataSrc"": ""result""
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
                            return meta.row + meta.settings._iDisplayStart + 1;
                        }
                    },
                    { ""data"": 'nik' },
                    { ""data"": 'employeeName' },
                    { ""data"": 'email' },
                    { ""data"": 'phone' },
                    { ""data"": 'address' },
                    {
                        ""data");
                WriteLiteral(@""": 'birth',
                        ""render"": function (data, type, row, meta) {
                            return row['birthPlace'] + ', ' + moment(row['birthDate']).format('DD/MM/YYYY')
                        }
                    },
                    {
                        ""data"": 'joinDate',
                        ""render"": function (data, type, row) {
                            return moment(data).format('DD-MM-YYYY');
                        }
                    },
                    { ""data"": 'position.positionName' },
                    {
                        ""data"": 'manager',
                        ""render"": function (data) {
                            if (data != null)
                                return data.employeeName
                            return ''
                        }
                    },
                    {
                        ""data"": 'nik',
                        ""render"": function (data, type, row, meta) {
                     ");
                WriteLiteral(@"       return '<button class=""btn btn-sm btn-success waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit""  onclick=""Get(\'' + row['nik'] + '\')""><i class =""mdi mdi-table-edit""></i> Edit</button> ' +
                                '<button class=""btn btn-sm btn-danger waves-effect waves-light"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Delete(\'' + row['nik'] + '\')""><i class =""mdi mdi-delete""></i> Delete</button>'
                        }
                    }
                ]
            });
        });

        function Readonly() {
            $('#NIK').attr('readonly', false);
            $('#Email').attr('readonly', false);
            $('#ValidationNIK').hide();
            $('#ValidationEmail').hide();
            validator.resetForm();
        }

        $('#NIK').change(function () {
            debugger;
            var nik = this.value;
            $.ajax({
                url: ""/Employee/GetById"",
                type: ""G");
                WriteLiteral(@"ET"",
                data: { 'key': nik },
                success: function (result) {
                    $('#ValidationEmail').show();
                    $('#NIK').focus(function () {
                        $(this).val('');
                        $('#ValidationNIK').hide();
                    });
                },
                error: function (error) {
                    $('#ValidationEmail').hide();
                }
            })
        });

        $('#Email').change(function () {
            debugger;
            var email = this.value;
            $.ajax({
                url: ""/Employee/Validation"",
                type: ""POST"",
                data: { 'Params': email },
                success: function (result) {
                    $('#ValidationEmail').show();
                    $('#NIK').focus(function () {
                        $(this).val('');
                        $('#ValidationNIK').hide();
                    });
                },
              ");
                WriteLiteral(@"  error: function (error) {
                    $('#ValidationEmail').hide();
                }
            })
        });

 
        $('#form').submit(function (event) {
            debugger;
            event.preventDefault();
            var form = $(form);

            var nikValue = $('#NIK').val()
            var myCheckboxes = new Array();
            $(""input:checked"").each(function () {
                myCheckboxes.push(parseInt($(this).val()));
            });

            var urlString;
            if (isUpdate == 1)
                urlString = ""/Employee/Put""
            else
                urlString = ""/Employee/Post""

            $.ajax({
                type: ""POST"",
                url: urlString,
                data: form.serialize(),
                success: function (data) {
                    $('.bs-modal-lg').modal('hide');
                    $('#table_id').DataTable().ajax.reload();
                    Swal.fire({
                        icon: 'success");
                WriteLiteral(@"',
                        title: 'Your data has been saved',
                        showConfirmButton: false,
                        timer: 1500
                    })

                    if (isUpdate == 1) {
                        var nik = ""117104""
                        $.ajax({
                            type: ""POST"",
                            url: ""/AccountRole/Delete"",
                            data: { 'key': nikValue }
                        });
                    }

                    for (var i = 0; i < myCheckboxes.length; i++) {
                        var role = new Object();
                        role.nik = nikValue;
                        role.roleID = myCheckboxes[i]

                        $.ajax({
                            type: ""POST"",
                            url: ""/AccountRole/Post"",
                            data: JSON.stringify(role),
                            contentType: ""application/json; charset=utf-8"",
                            d");
                WriteLiteral(@"ataType: ""json""
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
            })
        })

        function reset() {
            isUpdate = 0;
            $('#form').trigger('reset');
            $('input:checkbox').removeAttr('checked');
        }

        function Get(id) {
            $('#NIK').attr('readonly', true);
            $('#Email').attr('readonly', true);
            $.ajax({
                url: ""/AccountRole/GetById"",
                type: ""GET"",
                data: { 'key': id },
                success: function (result) {
                    var data = result[""result""];
                    $('input:checkbox').removeAttr('");
                WriteLiteral(@"checked');
                    for (var i = 0; i < data.length; i++) {
                        selectCheckbox(data[i].roleID)
                    }
                }
            });

            $.ajax({
                url: ""GetById"",
                type: ""GET"",
                data: { 'key': id },
                success: function (result) {
                    $('.bs-modal-lg').modal('show');
                    var data = result[""result""];
                    $('#NIK').val(data.nik);
                    $('#EmployeeName').val(data.employeeName);
                    $('#Email').val(data.email);
                    $('#Phone').val(data.phone);
                    $('#Address').val(data.address);
                    $('#BirthPlace').val(data.birthPlace);
                    $('#BirthDate').val(moment(data.birthDate).format('YYYY-MM-DD'));
                    $('#JoinDate').val(moment(data.joinDate).format('YYYY-MM-DD'));
                    $('#DepartmentDropdown').val(data.position.de");
                WriteLiteral(@"partmentID).trigger(""change"");
                    $('#PositionID').val(data.positionID).trigger(""change"");
                    if (data.manager != null)
                        $('#ManagerNIK').val(data.manager.nik).trigger(""change"");
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
                            ");
                WriteLiteral(@"table.ajax.reload();
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

        // Date Picker
        jQuery('#BirthDate').datepicker({
            autoclose: true,
            todayHighlight: true
        });

        // Date Picker
        jQuery('#JoinDate').datepicker({
            autoclose: true,
            todayHighlight: true
     ");
                WriteLiteral("   });\r\n    </script>\r\n");
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
