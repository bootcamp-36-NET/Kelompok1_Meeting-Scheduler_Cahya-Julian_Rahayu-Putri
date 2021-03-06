﻿var table = null;
var arrDepart = [];
$(document).ready(function () {
    //debugger
    table = $("#division").DataTable({
        "processing": true,
        "responsive": true,
        "pagination": true,
        "stateSave": true,
        "ajax": {
            url: "/division/LoadDivision",
            type: "GET",
            dataType: "json",
            dataSrc: "",
        },
        "columns": [
            {
                "data": "id",
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                    //return meta.row + 1;
                }
            },
            { "data": "Name" },
            {
                "sortable": false,
                "data": "DepartmentId"
            },
            {
                "data": "CreateDate",
                'render': function (jsonDate) {
                    var date = new Date(jsonDate);
                    return moment(date).format('DD MMMM YYYY, hh:mm');
                }
            },
            {
                "data": "UpdateDate",
                'render': function (jsonDate) {
                    var date = new Date(jsonDate);
                    if (date.getFullYear() != 0001) {
                        return moment(date).format('DD MMMM YYYY, hh:mm');
                    }
                    return "Not updated yet";
                }
            },
            {
                "sortable": false,
                "data": "id",
                "render": function (data, type, row, meta) {
                    console.log(row);
                    console.log(data);
                    $('[data-toggle="tooltip"]').tooltip();
                    return '<button class="btn btn-outline-warning btn-circle" data-placement="left" data-toggle="tooltip" data-animation="false" title="Edit" onclick="return GetById(' + meta.row + ')" ><i class="fa fa-lg fa-edit"></i></button>'
                        + '&nbsp;'
                        + '<button class="btn btn-outline-danger btn-circle" data-placement="right" data-toggle="tooltip" data-animation="false" title="Delete" onclick="return Delete(' + meta.row + ')" ><i class="fa fa-lg fa-times"></i></button>'
                }
            }
        ],
        "dom": "Bfrtip",
        "buttons": [
            {
                extend: 'excel',
                text: '<i class="fas fa-file-excel"></i> Excel',
                className: 'btn btn-success',
                title: 'Division Table',
                search: 'applied',
                order: 'applied',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4]
                },
            },
            {
                extend: 'csv',
                text: '<i class="fas fa-file-csv"></i> CSV',
                className: 'btn btn-info',
                title: 'Division Table',
                search: 'applied',
                order: 'applied',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4]
                },
            },
            {
                extend: 'pdf',
                text: '<i class="fas fa-file-pdf"></i> PDF',
                className: 'btn btn-danger',
                title: 'Division Table',
                search: 'applied',
                order: 'applied',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4]
                },
            },
            {
                extend: 'print',
                text: '<i class="fas fa-print"></i> Print',
                className: 'btn btn-primary',
                title: 'Division Table',
                search: 'applied',
                order: 'applied',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4]
                },
            },
        ],
        initComplete: function () {
            this.api().columns(2).every(function () {
                var column = this;
                var select = $('<select><option value="">Default</option></select>')
                    .appendTo($(column.header()).empty())
                    .on('change', function () {
                        var val = $.fn.dataTable.util.escapeRegex(
                            $(this).val()
                        );
                        column
                            .search(val ? '^' + val + '$' : '', true, false)
                            .draw();
                    });
                column.data().unique().sort().each(function (d, j) {
                    select.append('<option value ="' + d + '">' + d + '<option>')
                });
            });
        },
    });
});

function ClearScreen() {
    $('#Id').val('');
    $('#Name').val('');
    $('#update').hide();
    $('#add').show();
}

function LoadDepart(element) {
    //debugger;
    if (arrDepart.length === 0) {
        $.ajax({
            type: "Get",
            url: "/Department/LoadDepart",
            success: function (data) {
                arrDepart = data;
                renderDepart(element);
            }
        });
    }
    else {
        renderDepart(element);
    }
}

function renderDepart(element) {
    var $option = $(element);
    $option.empty();
    $option.append($('<option/>').val('0').text('Select Department').hide());
    $.each(arrDepart, function (i, val) {
        $option.append($('<option/>').val(val.id).text(val.name))
    });
}

LoadDepart($('#DepartOption'))

function GetById(idrow) {
    debugger;
    var getId = table.row(idrow).data().Id;
    $.ajax({
        url: "/division/GetById/",
        data: { id: getId } //id pertama dicontroller getbyid, yg kedua dari parameter/ var
    }).then((result) => {
        debugger;
        $('#Id').val(result.id);
        $('#Name').val(result.name);
        $('#DepartOption').val(result.departmentId);
        $('#add').hide();
        $('#update').show();
        $('#myModal').modal('show');
    });
}

function Save() {
    debugger;
    var Div = new Object();
    Div.Id = null;
    Div.Name = $('#Name').val();
    Div.DepartmentID = $('#DepartOption').val();
    $.ajax({
        type: 'POST',
        url: "/division/InsertOrUpdate/",
        cache: false,
        dataType: "JSON",
        data: Div
    }).then((result) => {
        if (result.statusCode === 200) {
            Swal.fire({
                position: 'center',
                icon: 'success',
                title: 'Data inserted Successfully',
                showConfirmButton: false,
                timer: 1500,
            })
            table.ajax.reload(null, false);
        } else {
            Swal.fire('Error', 'Failed to Input', 'error');
            ClearScreen();
        }
    })
}

function Update() {
    debugger;
    var Div = new Object();
    Div.Id = $('#Id').val();
    Div.Name = $('#Name').val();
    Div.DepartmentID = $('#DepartOption').val();
    $.ajax({
        type: 'POST',
        url: "/division/InsertOrUpdate/",
        cache: false,
        dataType: "JSON",
        data: Div
    }).then((result) => {
        debugger;
        if (result.statusCode === 200) {
            Swal.fire({
                position: 'center',
                icon: 'success',
                title: 'Data Updated Successfully',
                showConfirmButton: false,
                timer: 1500,
            });
            table.ajax.reload(null, false);
        } else {
            Swal.fire('Error', 'Failed to Input', 'error');
            ClearScreen();
        }
    })
}

function Delete(id) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!',
    }).then((resultSwal) => {
        if (resultSwal.value) {
            debugger;
            var getId = table.row(id).data().Id;
            $.ajax({
                url: "/division/Delete/",
                data: { id: getId }
            }).then((result) => {
                debugger;
                if (result.statusCode === 200) {
                    debugger;
                    Swal.fire({
                        position: 'center',
                        icon: 'success',
                        title: 'Delete Successfully',
                        showConfirmButton: false,
                        timer: 1500,
                    });
                    table.ajax.reload(null, false);
                } else {
                    Swal.fire('Error', 'Failed to Delete', 'error');
                    ClearScreen();
                }
            })
        };
    });
}