var arrDepart = [];

function myLogin() {
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
    var confirm = $("#confirmPassword").val();
    var pw = $("#password").val();
    if (confirm == pw) {
        var b = document.getElementById("deptName");
        var id1 = b.options[b.selectedIndex].id;
        var myData = {
            id: id1
        };
        var dataRegister = {
            fullName: $("#fullName").val(),
            gender: $("#gender").val(),
            address: $("#address").val(),
            username: $("#username").val(),
            email: $("#email").val(),
            password: $("#password").val(),
            phone: $("#phone").val(),
            confirmPassword: $("#confirmPassword").val(),
            departmentId: myData.id
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
var selopDepartment = {
    getAllDepartment: function (idAja) {
        $.ajax({
            url: '/select2/',
            method: 'get',
            contentType: 'application/json',
            success: function (res, status, xhr) {
                if (xhr.status == 200 || xhr.status == 201) {
                    $("#deptName").select2();
                    var dynamicSelect = document.getElementById("deptName");
                    Array.from(res).forEach(element => {
                        var newOption = document.createElement("option")
                        newOption.setAttribute("id", element.id);
                        newOption.setAttribute("value", element.name);
                        newOption.setAttribute("name", "Name");
                        newOption.text = element.name;
                        dynamicSelect.add(newOption);
                    });
                    //console.log(res);
                    if (idAja != 0) {
                        $("#deptName option[id='" + idAja + "']").attr("selected", "selected");
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

$(document).ready(function () {
    selopDepartment.getAllDepartment();
    $(".select2").select2();
});