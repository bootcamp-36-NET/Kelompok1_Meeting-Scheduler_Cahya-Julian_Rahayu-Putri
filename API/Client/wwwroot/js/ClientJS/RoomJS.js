var tableRoom = {
    create: function () {
        //debugger;
        // jika table tersebut datatable, maka clear and dostroy
        if ($.fn.DataTable.isDataTable('#MydataTable')) {
            // table yg sudah dibentuk menjadi datatable harus d rebuild lagi
            // untuk di instantiasi ulang
            $('#MydataTable').DataTable().clear();
            $('#MydataTable').DataTable().destroy();
        }
        $.ajax({
            url: '/RoomWeb/LoadRoom',
            method: 'get',
            contentType: 'application/json',
            success: function (res, status, xhr) {
                //debugger;
                if (xhr.status == 200 || xhr.status == 201) {
                    $('#MydataTable').DataTable({
                        data: res,
                        "columnDefs": [
                            { "orderable": false, "targets": 2 }
                        ],
                        columns: [
                            {
                                title: "No.", data: "", render: function (data, type, row, meta) {
                                    return meta.row + meta.settings._iDisplayStart + 1;
                                }
                            },
                            { title: "Room Name", data: "RoomName" },
                            { title: "Booking Name", data: "BookingName" },
                            { title: "Approval", data: "isBook" },
                            {
                                title: "Action", data: null, "sortable": false, render: function (data, type, row) {
                                    return "<button class='btn btn-outline-warning' title='Edit' onclick=formRoom.setEditData('" + data.Id + "')><i class='fa fa-lg fa-edit'></i></button>" +
                                        "<button class='btn btn-outline-danger' title='Delete' onclick=formRoom.setDeleteData('" + data.Id + "')><i class='fa fa-lg fa-trash'></i></button>"
                                }
                            }
                        ]
                    });
                } else {
                }
            },
            erorrr: function (err) {
                console.log(err);
            }
        });
    }
};
var editbook;
$("#btn-edit").click(function () {
    formBookingEmp.editSaveRoom(editbook);
});
tableRoom.create();

var formBookingEmp = {
    saveForm: function () {
        debugger;
        var rooms = new Object();
        rooms.Name = $('#name').val();
        console.log(rooms);
        $.ajax({
            url: '/RoomWeb/InsertorupdateRoom/',
            type: 'post',
            dataType: 'json',
            data: rooms,
            success: function (res, status, xhr) {
                if (xhr.status == 200 || xhr.status == 201) {
                    tableRoom.create();
                    toastr.success('Data has been saved');
                    $('#exampleModalCenter').modal('hide');
                    //MydataTable.ajax.reload(null, false);
                } else {
                    toastr.warning(status.msg);
                }
            },
            erorrr: function (err) {
                console.log(err);
            }
        });
    }, setDeleteData: function (id) {
        Swal.fire({
            title: 'Confirmation',
            text: "Do you want to delete this data?",
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, I do!',
        }).then((result) => {
            //debugger;
            if (result.value) {
                $.ajax({
                    url: '/RoomWeb/Delete/' + id,
                    //data: { id: id }
                    type: 'post'
                }).then((result) => {
                    //debugger;
                    if (result.statusCode == 200 || result.statusCode == 201) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Delete Successfully',
                            showConfirmButton: false,
                            timer: 1500,
                        });
                        tableRoom.create();
                    } else {
                        Swal.fire('Error', 'Failed', 'error');
                    }

                })
            };
        });
    }, editSaveRoom: function (editD) {
        //debugger;
        var b = document.getElementById("bookingId2");
        var id1 = b.options[b.selectedIndex].id;
        var myData = {
            Id: id1
        };
        editbook = editD;
        var rooms = new Object();
        rooms.Name = $('#name2').val();
        rooms.BookingId = myData.Id;
        rooms.isBook = $('#isBook').val();
        console.log(rooms);
        $.ajax({
            url: '/RoomWeb/InsertorupdateRoom/' + editD,
            type: 'post',
            dataType: 'json',
            data: rooms,
            success: function (res, status, xhr) {
                if (xhr.status == 200 || xhr.status == 201) {
                    tableRoom.create();
                    $('#exampleModalCenter').modal('hide');
                    toastr.success('Data has been modified.');
                    location.reload();
                } else {
                }
            },
            erorrr: function (err) {
                console.log(err);
            }
        });
    }, setEditData: function (editD) {
        editbook = editD; // new, supaya id bisa dibawa ke fungsi editForm
        console.log(editD);
        $.ajax({
            url: '/RoomWeb/GetById/' + editD,
            method: 'get',
            contentType: 'application/json',
            dataType: 'json',
            success: function (res, status, xhr) {
                //debugger;
                if (xhr.status == 200 || xhr.status == 201) {
                    $('#name2').val(res.Name);
                    selopBookingEdit.getAllBooking(res.Name);
                    $('#exampleModalCenterEdit').modal('show');
                    //console.log(name);

                } else {

                }
            },
            erorrr: function (err) {
                console.log(err);
            }
        });


    }
};

$(document).on('click', '#btn-save', function (e) {
    e.preventDefault();
    swal({
        title: 'Confirmation',
        input: 'checkbox',
        inputValue: 0,
        inputPlaceholder: 'Do you want to save this data?',
        showCancelButton: true,
        cancelButtonText: 'Cancel',
        confirmButtonText: 'Yes, I do',
        inputValidator: function (result) {
            return new Promise(function (resolve) {
                if (result) {
                    resolve();
                    formBookingEmp.saveForm();
                } else {
                    resolve("Please check confirmation button")
                }
            })
        }
    }).then(function (result) {
        $('#form-room').submit();

    });
});

var selopBookingEdit = {
    getAllBooking: function (idAja) {
        //debugger;
        $.ajax({
            url: '/BookingWeb/LoadBook/',
            method: 'get',
            contentType: 'application/json',
            success: function (res, status, xhr) {
                //debugger;
                if (xhr.status == 200 || xhr.status == 201) {
                    $("#bookingId2").select2();
                    var dynamicSelect = document.getElementById("bookingId2");
                    Array.from(res).forEach(element => {
                        var newOption = document.createElement("option")
                        newOption.setAttribute("id", element.Id);
                        newOption.setAttribute("value", element.Name);
                        newOption.setAttribute("name", "Name");
                        newOption.text = element.Name;
                        dynamicSelect.add(newOption);
                    });
                    //console.log(res);
                    if (idAja != 0) {
                        $("#bookinId2 option[id='" + idAja + "']").attr("selected", "selected");
                    }
                } else {
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    }
};
var tableSub = {
    create: function () {
        debugger;
        // jika table tersebut datatable, maka clear and dostroy
        if ($.fn.DataTable.isDataTable('#MydataSubmission')) {
            // table yg sudah dibentuk menjadi datatable harus d rebuild lagi
            // untuk di instantiasi ulang
            $('#MydataSubmission').DataTable().clear();
            $('#MydataSubmission').DataTable().destroy();
        }
        $.ajax({
            url: '/TeamRoomWeb/LoadRoom',
            method: 'get',
            contentType: 'application/json',
            success: function (res, status, xhr) {
                debugger;
                if (xhr.status == 200 || xhr.status == 201) {
                    $('#MydataSubmission').DataTable({
                        data: res,
                        "columnDefs": [
                            { "orderable": false, "targets": 2 }
                        ],
                        columns: [
                            {
                                title: "No.", data: "", render: function (data, type, row, meta) {
                                    return meta.row + meta.settings._iDisplayStart + 1;
                                }
                            },
                            { title: "Team Leader", data: "Name" },
                            { title: "Room Request", data: "Room" },
                            //{
                            //    title: "Action", data: null, "sortable": false, render: function (data, type, row) {
                            //        return "<button class='btn btn-outline-warning' title='Edit' onclick=formBooking.setEditData('" + data.Id + "')><i class='fa fa-lg fa-edit'></i></button>" +
                            //            "<button class='btn btn-outline-danger' title='Delete' onclick=formBooking.setDeleteData('" + data.Id + "')><i class='fa fa-lg fa-trash'></i></button>"
                            //    }
                            //}
                        ]
                    });
                } else {
                }
            },
            erorrr: function (err) {
                console.log(err);
            }
        });
    }
};
tableSub.create();