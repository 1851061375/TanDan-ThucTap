$(document).ready(function () {
    $('#submit').on('click', function() {
        var fullName = $('#full-name').val();
        var password = $('#password').val();

        $('#sign-in-full-name').text(fullName);
        $('#sign-in-password').text(password);
    });
});