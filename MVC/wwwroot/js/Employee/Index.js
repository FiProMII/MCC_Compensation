function selectCheckbox(value) {
    $("[name=" + 'roles' + "]").each(function () {
        if ($(this).val() == value) {
            $(this).attr('checked', true);
        }
    });
}

var positionDropdown = '<option value="-1">Please select a position</option>';
var managerDropdown = '<option value="-1">Please select a manager</option>';
function GetPositionDropdown(selectedDepartment) {
    $.ajax({
        type: "GET",
        url: '/Position/Get',
        success: function (result) {
            var data = result['result']
            for (var i = 0; i < data.length; i++) {
                if (data[i].departmentID == selectedDepartment) {
                    positionDropdown += '<option value="' + data[i].positionID + '">' + data[i].positionName + '</option>';
                    $("#PositionID").html(positionDropdown);
                }
            }
        }
    });
}

function GetManagerDropdown(selectedPosition, selectedDepartment) {
    $.ajax({
        type: "GET",
        url: '/Employee/Get',
        success: function (result) {

            var data = result['result']
            if (selectedPosition != "RM") {
                $('#ManagerNIK').removeAttr("disabled");
                managerDropdown = '<option value="-1">Please select a manager</option>';
                for (var i = 0; i < data.length; i++) {
                    if (data[i].position.departmentID == selectedDepartment) {
                        managerDropdown += '<option value="' + data[i].nik + '">' + data[i].employeeName + '</option>';
                        $("#ManagerNIK").html(managerDropdown);
                    }
                }
            } else {
                managerDropdown = '< option value = "-1" > Please select a manager</option >';
                $("#ManagerNIK").html(managerDropdown);
                $('#ManagerNIK').prop("disabled", true);
            }
        }
    });
}

var isUpdate = 0;
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: '/Role/Get',
        headers: { "Authorization": sessionStorage.token },
        success: function (result) {
            var data = result['result']
            for (var i = 0; i < data.length; i++) {
                if (i >= 8) {
                    var roleCheckbox = '<div class="input-group" id="ulCheckbox"><ul class="icheck-list" id="roleCheckbox"><li><input type="checkbox" class="check" data-checkbox="icheckbox_line-red" value="' + data[i].roleID + '"> ' + data[i].roleName + ' </li></ul ></div>';
                    $("#formCheckbox").append(roleCheckbox);
                }
                else if (i <= 3) {
                    var roleCheckbox = '<li><input type="checkbox" class="check" data-checkbox="icheckbox_line-red" value="' + data[i].roleID + '"> ' + data[i].roleName + ' </li>';
                    $("#roleCheckbox").append(roleCheckbox);
                }
                else {
                    var roleCheckbox = '<ul class="icheck-list" id="roleCheckbox"><li><input type="checkbox" class="check" data-checkbox="icheckbox_line-red" value="' + data[i].roleID + '"> ' + data[i].roleName + ' </li></ul >';
                    $("#ulCheckbox").append(roleCheckbox);
                }
            }
        }
    });

    var departmentDropdown = '<option value="-1">Please select a department</option>';
    $.ajax({
        type: "GET",
        url: '/Department/Get',
        headers: { "Authorization": sessionStorage.token },
        success: function (result) {
            var data = result['result']
            for (var i = 0; i < data.length; i++) {
                departmentDropdown += '<option value="' + data[i].departmentID + '">' + data[i].departmentName + '</option>';
                $("#DepartmentDropdown").html(departmentDropdown);
            }
        }
    });

    $("select#DepartmentDropdown").on('change', function () {
        var selectedDepartment = $('#DepartmentDropdown option:selected').val();
        GetPositionDropdown(selectedDepartment);
    })

    $("select#PositionID").on('change', function () {
        var selectedPosition = $('#PositionID option:selected').text();
        var selectedDepartment = $('#DepartmentDropdown option:selected').val();
        GetManagerDropdown(selectedPosition, selectedDepartment)
    })

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
        "responsive": true,
        "filter": true,
        "orderMulti": false,
        "ajax": {
            "url": "/Employee/Get",
            "type": "GET",
            "dataSrc": "result",
            "headers": "{ 'Authorization': 'Bearer '" + sessionStorage.token + "}",
        },
        "columnDefs": [
            {
                "targets": [1],
                "visible": false,
            },
            {
                "targets": [0, 4, 10],
                "orderable": false,
            }
        ],
        "columns": [
            {
                "data": null,
                "name": "no",
                "autowidth": true,
                "render": function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            { "data": 'nik' },
            { "data": 'employeeName' },
            { "data": 'email' },
            { "data": 'phone' },
            { "data": 'address' },
            {
                "data": 'birth',
                "render": function (data, type, row, meta) {
                    return row['birthPlace'] + ', ' + moment(row['birthDate']).format('DD/MM/YYYY')
                }
            },
            {
                "data": 'joinDate',
                "render": function (data, type, row) {
                    return moment(data).format('DD-MM-YYYY');
                }
            },
            { "data": 'position.positionName' },
            {
                "data": 'manager',
                "render": function (data) {
                    if (data != null)
                        return data.employeeName
                    return ''
                }
            },
            {
                "data": 'nik',
                "render": function (data, type, row, meta) {
                    return '<button class="btn btn-sm btn-success waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Edit"  onclick="Get(\'' + row['nik'] + '\')"><i class ="mdi mdi-table-edit"></i> Edit</button> ' +
                        '<button class="btn btn-sm btn-danger waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Delete" onclick="Delete(\'' + row['nik'] + '\')"><i class ="mdi mdi-delete"></i> Delete</button>'
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
    var nik = this.value;
    $.ajax({
        url: "/Employee/GetById",
        type: "GET",
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
    var email = $(this).val();
    if (email == "") {
        $('#ValidationEmail').css('visibility', 'hidden');
    }
    else {
        $.ajax({
            url: "/Employee/Validation",
            type: "Post",
            data: { 'Params': email },
            success: function (result) {
                if (result.message == "FOUND") {
                    try {
                        $('#ValidationEmail').css('visibility', 'visible');
                    } catch (e) {
                        return false;
                    }
                } else {
                    $('#ValidationEmail').css('visibility', 'hidden');
                }
            }
        })
    }
});

$('#Phone').change(function () {
    var phone = $(this).val();
    if (phone == "") {
        $('#ValidationPhone').css('visibility', 'hidden');
    }
    else {
        $.ajax({
            url: "/Employee/Validation",
            type: "Post",
            data: { 'Params': phone },
            success: function (result) {
                if (result.message == "FOUND") {
                    try {
                        $('#ValidationPhone').css('visibility', 'visible');
                    } catch (e) {
                        return false;
                    }
                } else {
                    $('#ValidationPhone').css('visibility', 'hidden');
                }
            }
        })
    }
});

$('#form').submit(function (event) {
    debugger;
    event.preventDefault();
    var form = $(this);
    var nikValue = $('#NIK').val()
    var myCheckboxes = new Array();
    $("input:checked").each(function () {
        myCheckboxes.push(parseInt($(this).val()));
    });
    var urlString;
    if (isUpdate == 1)
        urlString = "/Employee/Put"
    else
        urlString = "/Employee/Post"
    $.ajax({
        type: "POST",
        url: urlString,
        data: form.serialize(),
        success: function (data) {
            $('.bs-modal-lg').modal('hide');
            $('#table_id').DataTable().ajax.reload();
            Swal.fire({
                icon: 'success',
                title: 'Your data has been saved',
                showConfirmButton: false,
                timer: 1500
            })
            if (isUpdate == 1) {
                var nik = "117104"
                $.ajax({
                    type: "POST",
                    url: "/AccountRole/Delete",
                    data: { 'key': nikValue }
                });
            }
            for (var i = 0; i < myCheckboxes.length; i++) {
                var role = new Object();
                role.nik = nikValue;
                role.roleID = myCheckboxes[i]
                $.ajax({
                    type: "POST",
                    url: "/AccountRole/Post",
                    data: JSON.stringify(role),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json"
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
        url: "/AccountRole/GetById",
        type: "GET",
        data: { 'key': id },
        success: function (result) {
            var data = result["result"];
            $('input:checkbox').removeAttr('checked');
            for (var i = 0; i < data.length; i++) {
                selectCheckbox(data[i].roleID)
            }
        }
    });
    $.ajax({
        url: "/Employee/GetById",
        type: "GET",
        data: { 'key': id },
        success: function (result) {
            $('.bs-modal-lg').modal('show');
            var data = result["result"];
            $('#NIK').val(data.nik);
            $('#EmployeeName').val(data.employeeName);
            $('#Email').val(data.email);
            $('#Phone').val(data.phone);
            $('#Address').val(data.address);
            $('#BirthPlace').val(data.birthPlace);
            $('#BirthDate').val(moment(data.birthDate).format('YYYY-MM-DD'));
            $('#JoinDate').val(moment(data.joinDate).format('YYYY-MM-DD'));
            $('#DepartmentDropdown').val(data.position.departmentID);
            GetManagerDropdown(data.positionID, data.position.departmentID);
            if (data.manager != null)
                $('#ManagerNIK').val(data.manager.nik).change();
            GetPositionDropdown(data.position.departmentID);
            $('#PositionID').val(data.positionID);
            isUpdate = 1;
        }
    });
}

function Delete(id) {
    swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "/Account/Delete",
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