// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function checkPasswordLength() {
    let password = document.getElementById("Password1").value;
    document.getElementById("button-submit").disabled = password.length < 8;
}

function registerMessage(message) {
    console.log('TestTest');
    let submit = document.getElementById("button-submit");
    if (submit) {
        this.alert(message);
    }
}
