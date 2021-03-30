var isUpdate = 0;
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: '/Department/Get',
        success: function (result) {
            var data = result['result']
            var s = '<option value="-1">Please Select a Department</option>';
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].departmentID + '">' + data[i].departmentName + '</option>';
            }
            $("#DepartmentID").html(s);
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
        "responsive": true,
        "filter": true,
        "orderMulti": false,
        "ajax": {
            "url": "get",
            "type": "get",
            "dataSrc": "result"
        },
        "columnDefs": [
            {
                "targets": [1],
                "visible": false,
            },
            {
                "targets": [0, 4],
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
            { "data": 'positionID' },
            { "data": 'positionName' },
            { "data": 'department.departmentName' },
            {
                "data": 'positionID',
                "render": function (data, type, row, meta) {
                    return '<button class="btn btn-sm btn-success waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Edit"  onclick="Get(\'' + row['positionID'] + '\')"><i class ="mdi mdi-table-edit"></i> Edit</button> ' +
                        '<button class="btn btn-sm btn-danger waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Delete" onclick="Delete(\'' + row['positionID'] + '\')"><i class ="mdi mdi-delete"></i> Delete</button>'
                }
            }
        ]
    });
});

function Readonly() {
    $('#positionID').attr('readonly', false);
    validator.resetForm();
}

var validator = $("#form").validate({
    rules: {
        PositionName: "required"
    },
    messages: {
        PositionName: "<small class='text-danger'>Please enter <code>Position Name.</code></small>"
    },
    submitHandler: function (form) {
        var form = $(form);
        var urlString;
        if (isUpdate == 1)
            urlString = "/Position/Put"
        else
            urlString = "/Position/Post"
        $.ajax({
            type: "POST",
            url: urlString,
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
}

function Get(id) {
    $.ajax({
        url: "/Position/GetById",
        type: "GET",
        data: { 'key': id },
        success: function (result) {
            $('.bs-modal-sm').modal('show');
            var data = result["result"];
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
                url: "/Position/Delete",
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