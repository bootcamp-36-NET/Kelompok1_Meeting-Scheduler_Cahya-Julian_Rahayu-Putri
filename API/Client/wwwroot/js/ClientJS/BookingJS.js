var tableRoom = {
    create: function () {
        // jika table tersebut datatable, maka clear and dostroy
        if ($.fn.DataTable.isDataTable('#MydataTable')) {
            // table yg sudah dibentuk menjadi datatable harus d rebuild lagi
            // untuk di instantiasi ulang
            $('#MydataTable').DataTable().clear();
            $('#MydataTable').DataTable().destroy();
        }
        $.ajax({
            url: '/BookingWeb/LoadBook',
            method: 'get',
            contentType: 'application/json',
            success: function (res, status, xhr) {
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
                            { title: "Booking Name", data: "Name" },
                            { title: "Time", data: "Time" },
                            { title: "Team", data: "Employee.FullName" },
                            { title: "Filed Date", data: "CreateDate" },
                            { title: "End Date", data: "EndDate" },
                            {
                                title: "Action", data: null, "sortable": false, render: function (data, type, row) {
                                    return "<button class='btn btn-outline-warning' title='Edit' onclick=formBooking.setEditData('" + data.Id + "')><i class='fa fa-lg fa-edit'></i></button>" +
                                        "<button class='btn btn-outline-danger' title='Delete' onclick=formBooking.setDeleteData('" + data.Id + "')><i class='fa fa-lg fa-trash'></i></button>"
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
var editBookings;
$("#btn-edit").click(function () {
    formBookingEmp.editSaveRoom(editBookings)
});
tableRoom.create();

var formBookingEmp = {
    saveForm: function () {
        //debugger;
        //var a = $("#time").val()
        var b = document.getElementById("team");
        var id1 = b.options[b.selectedIndex].id;
        var myData = {
            id: id1
        };
        //console.log(a[0])
        //for (var x = 0; x < a.length; x++) {
        //    var id2 = a[x]
        //    var id = {
        //        id2
        //    };
        //    teamEmp.push(id)
        //}
        var bookings = new Object();
        //bookings.Id = 0;
        bookings.Name = $('#name').val();
        bookings.Time = $('#time').val();
        bookings.EmployeeId = myData.id;
        bookings.EndDate = $("#endDate").val();
        console.log(bookings);
        $.ajax({
            url: '/BookingWeb/InsertorupdateBooking/',
            type: 'post',
            dataType: 'json',
            data: bookings,
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
                    url: '/BookingWeb/Delete/' + id,
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
    }, editSaveBooking: function (editD) {
        debugger;
        editBooking = editbook;
        var b = document.getElementById("team2");
        var id1 = b.options[b.selectedIndex].id;
        var myData = {
            id: id1
        };
        var bookings = new Object();
        bookings.Name = $('#name2').val();
        bookings.Time = $('#time2').val();
        bookings.EndDate = $('#endDate2').val();
        bookings.EmployeeId = myData.id;
        console.log(bookings);
        $.ajax({
            url: '/BookingWeb/InsertorupdateBooking/' + editD,
            type: 'post',
            dataType: 'json',
            data: bookings,
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
        editBooking = editBookings, //supaya id bisa dibawa ke fungsi editForm
        console.log(editD);
        $.ajax({
            url: '/BookingWeb/GetById/' + editD,
            method: 'get',
            contentType: 'application/json',
            dataType: 'json',
            success: function (res, status, xhr) {
                //debugger;
                if (xhr.status == 200 || xhr.status == 201) {
                    $('#name2').val(res.Name);
                    selopBookingEdit.getAllEmployee(res.FullName);
                    $('#time2').val(res.Time);
                    $('#endDate2').val(res.EndDate);

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
                    //teamEmp = [];
                } else {
                    resolve("Please check confirmation button")
                }
            })
        }
    }).then(function (result) {
        $('#form-booking').submit();

    });
});

//dropdown data employee
var selopEmployee = {
    getAllEmployee: function (idAja) {
        //debugger;
        $.ajax({
            url: '/BookingWeb/LoadEmployee/',
            method: 'get',
            contentType: 'application/json',
            success: function (res, status, xhr) {
                //debugger;
                if (xhr.status == 200 || xhr.status == 201) {
                    $("#team").select2();
                    //$("#team").select2({
                    //    //res: [],
                    //    multiple: true,
                    //    placeholder: "Choose Team",
                    //    allowClear: true,
                    //    tokenSeparators: ";"
                    //});
                    var dynamicSelect = document.getElementById("team");
                    Array.from(res).forEach(element => {
                        var newOption = document.createElement("option")
                        newOption.setAttribute("id", element.id);
                        newOption.setAttribute("value", element.fullName);
                        newOption.setAttribute("name", "fullName");
                        newOption.text = element.fullName;
                        dynamicSelect.add(newOption);
                    });
                    //console.log(res);
                    if (idAja != 0) {
                        $("#team option[id='" + idAja + "']").attr("selected", "selected");
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

var selopBookingEdit = {
    getAllEmployee: function (idAja) {
        //debugger;
        $.ajax({
            url: '/BookingWeb/LoadEmployee/',
            method: 'get',
            contentType: 'application/json',
            success: function (res, status, xhr) {
                //debugger;
                if (xhr.status == 200 || xhr.status == 201) {
                    $("#team2").select2();
                    //$("#team").select2({
                    //    //res: [],
                    //    multiple: true,
                    //    placeholder: "Choose Team",
                    //    allowClear: true,
                    //    tokenSeparators: ";"
                    //});
                    var dynamicSelect = document.getElementById("team2");
                    Array.from(res).forEach(element => {
                        var newOption = document.createElement("option")
                        newOption.setAttribute("id", element.id);
                        newOption.setAttribute("value", element.fullName);
                        newOption.setAttribute("name", "fullName");
                        newOption.text = element.fullName;
                        dynamicSelect.add(newOption);
                    });
                    //console.log(res);
                    if (idAja != 0) {
                        $("#team2 option[id='" + idAja + "']").attr("selected", "selected");
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