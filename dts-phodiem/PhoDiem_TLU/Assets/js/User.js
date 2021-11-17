
const btndelete = document.getElementById("btn-delete-user");
const ckbiduser = document.getElementsByClassName("ckbiduser");
const btnconfirm = document.getElementById('btn-confirm');
const btndetail = document.getElementsByClassName('btn-detail');
const fullname = document.getElementById('fullname');
const gender = document.getElementById('gender');
const email = document.getElementById('email');
const active = document.getElementById('active');
const roles = document.getElementById('roles');
const edituser = document.getElementsByClassName('edit-user');


const getIdUsers = () => {
    btndelete.disabled = true;

    for (var i = 0; i < ckbiduser.length; i++) {
        ckbiduser[i].addEventListener('change', function () {
            let dataid = this.getAttribute('data-id');

            if (this.checked) {
                selectedUsers.push(parseInt(dataid));
                console.log(selectedUsers);
            } else {
                selectedUsers = selectedUsers.filter(item => item != dataid);
                console.log(selectedUsers);
            }
            if (selectedUsers.length > 0) {
                btndelete.disabled = false;
            }
            else {
                btndelete.disabled = true;
            }
        })
    }

}

const getDetailUser = () => {
    for (var i = 0; i < btndetail.length; i++) {
        btndetail[i].addEventListener('click', function () {
            let dataid = this.getAttribute('data-id');
            if (parseInt(dataid)) {
                $.ajax({
                    url: '/User/Detail',
                    type: 'get',
                    dataType: 'application/json',
                    data: {
                        id: parseInt(dataid)
                    },
                    error: function (err) {
                        let json = JSON.parse(err.responseText);
                        console.log(json);
                        fullname.value = json.displayName;
                        gender.value = json.person.gender;
                        email.value = json.email;
                        active.checked = json.active == 1 ? true : false;
                        loadRoloes(json.roles);
                    },
                    success: function (result) {
                        console.log(result)
                    }
                })
            }
        });
    }
}

const editUser = () => {
    for (var i = 0; i < edituser.length; i++) {
        edituser[i].addEventListener('click', function (){
            let dataid = this.getAttribute('data-id');
            var url = "/User/DetailAndEditUser?id=" + parseInt(dataid);

            $("#myModalBodyDiv1").load(url, function () {
                $("#myModal1").modal("show");

            })
        })
    }
}

const loadRoloes = (userRoles) => {
    roles.innerHTML = "";
    let html = userRoles.map(function (u) {
        console.log(u);
        return `<li class="" value="${u.id}">
                <span style="border-radius:5px;border: solid 0.5px;width:150px !impotant">${u.name}</span>
            </li>`;
    });
    roles.innerHTML += html.join('');
    console.log(roles.innerHTML)
}


btnconfirm.onclick = () => {
    if (selectedUsers.length > 0) {
        $.ajax({
            url: '/User/Delete',
            type: 'post',
            dataType: 'application/json',
            data: {
                selectedUsers: selectedUsers
            },
            success: function (result) {
                console.log(result);
            },
            error: function (err) {
                console.log(err)
            }
        })
    }

}

getIdUsers();
getDetailUser();
editUser();

