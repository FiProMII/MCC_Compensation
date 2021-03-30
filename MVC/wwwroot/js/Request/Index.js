var isUpdate = 0, value, urlString, dataStatus;
$(document).ready(function () {
    defaultTable();
});

$('#View').on('change', function () {
    value = $(this).val();
    $('#table_id').DataTable().destroy();
    urlString = "/Request/RequestList";
    if (value == '0') {
        dataStatus = "Pending";
        myTable();
    } else if (value == '1') {
        dataStatus = "Approve";
        myTable();
    } else if (value == '-1') {
        dataStatus = "Rejected";
        myTable();
    } else {
        defaultTable();
    }
});

function defaultTable() {
    $('#table_id').DataTable({
        dom: 'Bfrtip',
        buttons: [
            {
                extend: 'csv',
                exportOptions: {
                    columns: [0, 2, 3, 4, 5, 6]
                }
            },
            {
                extend: 'excel',
                exportOptions: {
                    columns: [0, 2, 3, 4, 5, 6]
                }
            },
            {
                extend: 'pdf',
                exportOptions: {
                    columns: [0, 2, 3, 4, 5, 6]
                }
            }
        ],
        "order": [],
        "responsive": true,
        "filter": true,
        "orderMulti": false,
        "ajax": {
            "url": "/Request/Get",
            "type": "Get",
            "dataSrc": "result"
        },
        "columnDefs": [
            {
                "targets": [1, 3, 4],
                "visible": false,
            },
            {
                "targets": [0, 8],
                "orderable": false,
            },
            {
                "targets": [0, 1, 3, 5, 6, 7, 8],
                "className": "texUrl-center",
            },
            {
                "order": [[2, 'asc']]
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
            { "data": 'requestID' },
            { "data": 'employee.employeeName' },
            {
                "data": 'employee.joinDate',
                "render": function (data, type, row) {
                    return moment(data).format('DD/MM/YYYY');
                }
            },
            { "data": 'employee.manager.employeeName' },
            { "data": 'compensation.compensationName' },
            {
                "data": 'eventDate',
                "render": function (data, type, row) {
                    return moment(data).format('DD/MM/YYYY');
                }
            },
            {
                "data": 'requestDate',
                "render": function (data, type, row) {
                    return moment(data).format('DD/MM/YYYY');
                }
            },
            {
                "data": 'requestID',
                "render": function (data, type, row, meta) {
                    return '<button class="btn btn-outline-info waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Detail Information" onclick="GetDetail(\'' + row['requestID'] + '\')"><i class="fa fa-info-circle"></i> Details</button> ' +
                        '<button class="btn btn-outline-success waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Approval Status" onclick="GetApprovalStatus(\'' + row['requestID'] + '\')"><i class="fa fa-check-round-o"></i> Status</button>'
                }
            }
        ]
    })
}

function myTable() {
    $('#table_id').DataTable({
        dom: 'Bfrtip',
        buttons: [
            {
                extend: 'csv',
                exportOptions: {
                    columns: [0, 2, 3, 4, 5, 6]
                }
            },
            {
                extend: 'excel',
                exportOptions: {
                    columns: [0, 2, 3, 4, 5, 6]
                }
            },
            {
                extend: 'pdf',
                exportOptions: {
                    columns: [0, 2, 3, 4, 5, 6]
                }
            }
        ],
        "order": [],
        "responsive": true,
        "filter": true,
        "orderMulti": false,
        "ajax": {
            "url": urlString,
            "type": "Get",
            "data": { 'status': dataStatus },
            "dataSrc": "result"
        },
        "columnDefs": [
            {
                "targets": [1, 3, 4],
                "visible": false,
            },
            {
                "targets": [0, 8],
                "orderable": false,
            },
            {
                "targets": [0, 1, 3, 5, 6, 7, 8],
                "className": "texUrl-center",
            },
            {
                "order": [[2, 'asc']]
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
            { "data": 'requestID' },
            { "data": 'employeeName' },
            {
                "data": 'joinDate',
                "render": function (data, type, row) {
                    return moment(data).format('DD/MM/YYYY');
                }
            },
            { "data": 'manager' },
            { "data": 'compensationName' },
            {
                "data": 'eventDate',
                "render": function (data, type, row) {
                    return moment(data).format('DD/MM/YYYY');
                }
            },
            {
                "data": 'requestDate',
                "render": function (data, type, row) {
                    return moment(data).format('DD/MM/YYYY');
                }
            },
            {
                "data": 'requestID',
                "render": function (data, type, row, meta) {
                    return '<button class="btn btn-outline-info waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Detail Information" onclick="GetDetail(\'' + row['requestID'] + '\')"><i class="fa fa-info-circle"></i> Details</button> ' +
                        '<button class="btn btn-outline-success waves-effect waves-light" data-toggle="tooltip" data-placement="top" title="Approval Status" onclick="GetApprovalStatus(\'' + row['requestID'] + '\')"><i class="fa fa-check-round-o"></i> Status</button>'
                }
            }
        ]
    })
}

function GetDetail(id) {
    $.ajax({
        url: "/Request/GetById",
        type: "GET",
        data: { 'key': id },
        success: function (result) {
            $('#modal').modal('show');
            var data = result["result"];
            $('#Requester').html(data.employee.employeeName)
            $('#DepartmentName').html(data.employee.position.department.departmentName)
            $('#PositionName').html(data.employee.position.positionName)
            $('#ManagerName').html(data.employee.manager.employeeName)
            $('#JoinDate').html(moment(data.employee.joinDate).format('DD MMMM YYYY'))
            $('#RequestID').html(data.requestID)
            $('#RequestIDText').html(data.requestID)
            $('#CompensationName').html(data.compensation.compensationName)
            $('#EventDate').html(moment(data.eventDate).format('DD MMMM YYYY'))
            $('#RequestDate').html(moment(data.requestDate).format('DD MMMM YYYY'))

            for (var i = 0; i < data.documents.length; i++) {
                if (data.documents[i].link.match(/(.*?)\.(pdf|PDF)$/)) {
                    var documentList = '<a target="_blank" href="' + data.documents[i].link
                        + '"><img src="/lib/src/images/pdf.png" width="30">' + data.documents[i].documentName + '</><br/>'
                } else if (data.documents[i].link.match(/(.*?)\.(jpg|jpeg|JPG|JPEG)$/)) {
                    var documentList = '<a target="_blank" href="' + data.documents[i].link
                        + '"><img src="/lib/src/images/images.png" width="30">' + data.documents[i].documentName + '</><br/>'
                }
                $('#Document').append(documentList);
            }
        }
    });
};

$('#modal').on('hide.bs.modal', function () {
    $('#Document').empty();
});

function GetApprovalStatus(id) {
    debugger;
    $.ajax({
        url: "/Approval/ApprovalStatus",
        type: "GET",
        data: { 'RequestID': id },
        success: function (result) {
            $('#statusModal').modal('show');
            var data = result["result"];
            for (var i = 0; i < data.length; i++) {
                var statusList = '<tr><th id="Status">' + data[i].statusName + '</th>'
                    + '<th id="Approval">' + data[i].approval + '</th>'
                    + '<th id="ApprovalDate">' + moment(data[i].approvalDate).format('DD MM YYYY') + '</th></tr>'
                $('#Status').append(statusList);
            }
        }
    })
};

$("#statusModal").on("hide.bs.modal", function () {
    $("#tablestatus tbody").empty();
});