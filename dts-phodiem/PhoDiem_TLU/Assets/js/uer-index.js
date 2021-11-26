$(document).ready(function () {
    let hvten = $("#displayName");
    let username = $("#username");
    let ho = $("#firstName");
    let ten = $("#lastName");
    let email = $("#email");
    let pass = $("#password");
    let confpass = $("#confirmPassword");
    let gen = $("#gender");
    let active = $("#active");
    let role = $("#multiDropdown_chosen");

    hvten.blur(() => {
        check(hvten);
    }).change(() => {
        check(hvten);
    });
    username.blur(() => {
        check(username);
    }).change(() => {
        check(username);
    });
    ho.blur(() => {
        check(ho);
    }).change(() => {
        check(ho);
    });
    ten.blur(() => {
        check(ten);
    }).change(() => {
        check(ten);
    });
    email.blur(() => {
        check(email);
    }).change(() => {
        check(email);
    });
    pass.blur(() => {
        check(pass);
    }).change(() => {
        check(pass);
    });
    confpass.blur(() => {
        check(confpass);
    }).change(() => {
        check(confpass);
    });
    gen.blur(() => {
        check(gen);
    }).change(() => {
        check(gen);
    });

    function check(res) {
        if (res.val() == null || res.val() == "" || res.val() == " ") {
            res.css("border-color", "red");
        }
        else {
            res.css("border-color", "#ccc");
        }
    }
})
