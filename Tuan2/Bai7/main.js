$(document).ready(function () {

    $('#full-name').focus();
    $('#submit').attr('disabled','disabled');
    $('#full-name').on('blur', function() {
        if ($('#full-name').val() != '')
            $('#submit').removeAttr('disabled','disabled');
    });

    $('#submit').on('click', function() {

        var fullName = $('#full-name').val();
        var password = $('#password').val();
       
        if (fullName === '') {
            $('#message-password').text('');
            $('#message-full-name').text('Nhập họ tên!');
            $('#full-name').focus();
        }
        else if (password === '') {
            $('#message-full-name').text('');
            $('#message-password').text('Nhập mật khẩu!');
            $('#password').focus();
        }
        else if (password.length < 6) {
            $('#message-full-name').text('');
            $('#message-password').text('Mật khẩu phải có nhiều hơn 6 ký tự!');
            $('#password').focus()
        }
        else {
            $('#message-full-name').text('');
            $('#message-password').text('');

            $('#sign-in-full-name').text(fullName);
            $('#sign-in-password').text(password);
        }
    });
});