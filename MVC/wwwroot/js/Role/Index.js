var isUpdate;
$(document).ready(function () {
    $('#table_id').DataTable({
        "responsive": true,
        "filter": true,
        "orderMulti": false,
        "ajax": {
            "url": "/Role/Get",
            "type": "Get",
            "dataSrc": "result",
            "beforeSend": function (xhr) {
                xhr.setRequestHeader('Authorization', sessionStorage.token);
            },
        },
        "columnDefs": [
            {
                "targets": [1],
                "visible": false,
            },
            {
                "targets": [3],
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
            { "data": 'roleID' },
            { "data": 'roleName' },
            {
                "data": 'roleID',
                "render": function (data, type, row, meta) {
                    return '<button class="btn btn-sm btn-success waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Edit"  onclick="Get(\'' + row['roleID'] + '\')"><i class ="mdi mdi-table-edit"></i> Edit</button> ' +
                        '<button class="btn btn-sm btn-danger waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Delete" onclick="Delete(\'' + row['roleID'] + '\')"><i class ="mdi mdi-delete"></i> Delete</button>'
                }
            }
        ]
    });
});

var validator = $("#form").validate({
    rules: {
        roleName: "required",
    },
    messages: {
        roleName: "<small class='text-danger'>Please enter <code>Role Name.</code></small>",
    },
    submitHandler: function (form) {
        var form = $(form);
        var urlString;
        if (isUpdate == 1)
            urlString = "/Role/Put"
        else
            urlString = "/Role/Post"
        $.ajax({
            type: "POST",
            url: urlString,
            headers: {
                Authorization: sessionStorage.token
            },
            data: form.serialize(),
            success: function (data) {
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
    validator.resetForm();
}

function Get(roleID) {
    debugger;
    $.ajax({
        url: "/Role/GetById",
        type: "GET",
        data: { 'key': roleID },
        headers: {
            Authorization: sessionStorage.token
        },
        success: function (result) {
            $('.bs-modal-sm').modal('show');
            var data = result['result'];
            $('#RoleID').val(data.roleID);
            $('#RoleName').val(data.roleName);
            isUpdate = 1;
        }
    });
}

function Delete(roleID) {
    debugger;
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
                url: "/Role/Delete",
                data: { 'key': roleID },
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
                        text: 'Something went wrong!',
                        footer: '<a href>Your Work cannot be saved</a>'
                    })
                },
            });
        }
    });
}