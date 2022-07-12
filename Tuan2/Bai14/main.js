$(document).ready(function() {
    var color = ['pink', 'blue', 'brown', 'coral', 'crimson', 'cyan'];
    var random = Math.floor(Math.random() * color.length);

    $(window).on('load', function() {
        $('#body').css('background', color[random]);
    });

    $('#change-text-color').on('click', function() {
        var color = prompt('Nhập màu: ');
        $('#body').css('color', color)
    })
});