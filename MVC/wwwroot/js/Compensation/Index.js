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
        "responsive": true,
        "filter": true,
        "orderMulti": false,
        "ajax": {
            "url": "/Compensation/Get",
            "type": "Get",
            "dataSrc": "result",
            "headers": { 'Authorization': 'Bearer ' + sessionStorage.token }
        },
        "columnDefs": [
            {
                "targets": [1],
                "visible": false,
            },
            {
                "targets": [2, 4],
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
            { "data": 'compensationID' },
            { "data": 'compensationName' },
            {
                "data": 'cost',
                render: $.fn.dataTable.render.number(',', '.', 2, 'Rp. ')
            },
            {
                "data": 'compensationID',
                "render": function (data, type, row, meta) {
                    return '<button class="btn btn-sm btn-success waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Edit"  onclick="Get(\'' + row['compensationID'] + '\')"><i class="mdi mdi-table-edit"></i> Edit</button> ' +
                        '<button class="btn btn-sm btn-danger waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Delete" onclick="Delete(\'' + row['compensationID'] + '\')"><i class="mdi mdi-delete"></i> Delete</button>'
                }
            }
        ]
    });
});

var validator = $("#form").validate({
    rules: {
        CompensationName: "required",
        Cost: {
            required: true,
            digits: true
        }
    },
    messages: {
        CompensationName: "<small class='text-danger'>Please enter <code>Compensation Name.</code></small>",
        Cost: {
            required: "<small class='text-danger'>Please type the<code>Cost.</code></small>",
            digits: "<small class='text-danger'>Please enter <code>Only Numbers.</code></small>"
        }
    },
    submitHandler: function (form) {
        var form = $(form);
        var urlString;
        if (isUpdate == 1)
            urlString = "/Compensation/Put"
        else
            urlString = "/Compensation/Post"
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

$('.bs-modal-sm').on('hide.bs.modal', function () {
    isUpdate = 0;
    $('#form').trigger('reset');
    validator.resetForm();
});

function Get(compensationID) {
    $.ajax({
        url: "/Compensation/GetById",
        type: "GET",
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
                url: "/Compensation/Delete",
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
                        text: 'Something went wrong!',
                        footer: '<a href>Your Work cannot be saved</a>'
                    })
                },
            });
        }
    });
}
