var formBookingEmp = {
    saveForm: function () {
        var b = document.getElementById("team");
        var id1 = b.options[b.selectedIndex].id;
        var myData = {
            id: id1
        };
        var bookings = new Object();
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
                    toastr.success('Data has been saved. Please check your profile (max 1 day).');
                    tableRoom.create();
                    //$('#exampleModalCenter').modal('hide');
                    //MydataTable.ajax.reload(null, false);
                } else {
                    toastr.warning(status.msg);
                }
            },
            erorrr: function (err) {
                console.log(err);
            }
        });
    }, saveFormRoom: function () {
        //debugger;
        var teamrooms = new Object();
        teamrooms.Room = $('#room').val();
        teamrooms.Name = $('#book').val();
        console.log(teamrooms);
        $.ajax({
            url: '/TeamRoomWeb/InsertorupdateRoom/',
            type: 'post',
            dataType: 'json',
            data: teamrooms,
            success: function (res, status, xhr) {
                if (xhr.status == 200 || xhr.status == 201) {
                    toastr.success('Data has been saved. Please check your profile (max 1 day).');
                    tableRoom.create();
                    //$('#exampleModalCenter').modal('hide');
                    //MydataTable.ajax.reload(null, false);
                } else {
                    toastr.warning(status.msg);
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
                    toastr.success('Data has been saved. Please check your profile (max 1 day).');
                } else {
                    resolve("Please check confirmation button")
                }
            })
        }
    }).then(function (result) {
        $('#form-booking').submit();

    });
});


$(document).on('click', '#btn-save-room', function (e) {
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
                    formBookingEmp.saveFormRoom();
                    toastr.success('Data has been saved. Please check your profile (max 1 day).');
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
//dropdown data employee
var selopEmployeeRoom = {
    getAllEmployeeRoom: function (idAja) {
        //debugger;
        $.ajax({
            url: '/BookingWeb/LoadBook/',
            method: 'get',
            contentType: 'application/json',
            success: function (res, status, xhr) {
                //debugger;
                if (xhr.status == 200 || xhr.status == 201) {
                    $("#book").select2();
                    var dynamicSelect = document.getElementById("book");
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
                        $("#book option[id='" + idAja + "']").attr("selected", "selected");
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
//dropdown data room
var selopRoom = {
    getAllRoom: function (idAja) {
        //debugger;
        $.ajax({
            url: '/RoomWeb/LoadRoom/',
            method: 'get',
            contentType: 'application/json',
            success: function (res, status, xhr) {
                //debugger;
                if (xhr.status == 200 || xhr.status == 201) {
                    $("#room").select2();
                    var dynamicSelect = document.getElementById("room");
                    Array.from(res).forEach(element => {
                        var newOption = document.createElement("option")
                        newOption.setAttribute("id", element.Id);
                        newOption.setAttribute("value", element.RoomName);
                        newOption.setAttribute("name", "RoomName");
                        newOption.text = element.RoomName;
                        dynamicSelect.add(newOption);
                    });
                    //console.log(res);
                    if (idAja != 0) {
                        $("#room option[id='" + idAja + "']").attr("selected", "selected");
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