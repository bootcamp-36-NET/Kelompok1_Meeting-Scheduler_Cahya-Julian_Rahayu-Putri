var arrDepart = [];

function myLogin() {
    debugger;
	var validate = new Object();
	validate.Email = $('#Username').val();
	validate.Password = $('#password').val();
	$.ajax({
		type: 'POST',
        url: "/validate/",
		cache: false,
		dataType: "JSON",
		data: validate
    }).then((result) => {
        if (result.status == true) {
			window.location.href = "/profile";
		} else {
			toastr.warning(result.msg)
		}
	})
};

function Register() {
    debugger;
    var confirm = $("#confirmPassword").val();
    var pw = $("#password").val();
    if (confirm == pw) {
        var dataRegister = {
            fullName: $("#fullName").val(),
            gender: $("#gender").val(),
            address: $("#address").val(),
            username: $("#username").val(),
            email: $("#email").val(),
            password: $("#password").val(),
            phone: $("#phone").val(),
            confirmPassword: $("#confirmPassword").val(),
            departmentId: $("#departmentId").val()
        };
        console.log(dataRegister);
        $.ajax({
            type: 'POST',
            url: "/regisvalidate/",
            cache: false,
            dataType: "JSON",
            data: dataRegister
        }).then((result) => {
            if (result.status == true) {
                toastr.success("Please check your email to continue your registration proccess.")
                window.location.href = "/verify";
            } else {
                toastr.warning(result.msg)
            }
            console.log(result);
        })
    } else {
        toastr.warning(result.msg)
    }
};

function Verify() {
    debugger;
    var validate = {
        SecurityStamp : $('#verifyId').val(),
        Email: $('#email').val()
    };
    console.log(validate);
    $.ajax({
        type: 'POST',
        url: "/verif/",
        cache: false,
        dataType: "JSON",
        data: validate
    }).then((result) => {
        if (result.status == true) {
            window.location.href = "/profile";
        } else {
            toastr.warning(result.msg)
        }
        console.log(result);
    });
};

//dropdown data dept
//var selopDepartment = {
//    getAllDepartment: function (idAja) {

//        $.ajax({
//            url: '/DepartmentWeb/LoadDepartments',
//            method: 'get',
//            contentType: 'application/json',
//            success: function (res, status, xhr) {
//                if (xhr.status == 200 || xhr.status == 201) {
//                    $("#divName").select2();
//                    var dynamicSelect = document.getElementById("divName");
//                    Array.from(res).forEach(element => {
//                        var newOption = document.createElement("option")
//                        newOption.setAttribute("id", element.Id);
//                        newOption.setAttribute("value", element.Name);
//                        newOption.setAttribute("name", "Name");
//                        newOption.text = element.Name;
//                        dynamicSelect.add(newOption);
//                    });
//                    //console.log(res);
//                    if (idAja != 0) {
//                        $("#divName option[id='" + idAja + "']").attr("selected", "selected");
//                    }
//                } else {
//                }
//            },
//            error: function (err) {
//                console.log(err);
//            }
//        });
//    }
//};


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