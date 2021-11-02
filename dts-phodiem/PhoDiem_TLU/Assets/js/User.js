
const btndelete = document.getElementById("btn-delete-user");
const ckbiduser = document.getElementsByClassName("ckbiduser");
const btnconfirm = document.getElementById('btn-confirm');
var selectedUsers = [];
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

