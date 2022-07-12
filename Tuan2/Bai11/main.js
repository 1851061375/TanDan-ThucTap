$(document).ready(function() {
    var name = ['Toyota', 'KIA', 'Ford', 'Civi', 'Ferrari', 'Mecrcedes']
    var option = '';

    $('#image-show').attr('src', './images/car1.jpg')

    for (var i = 1; i <= 6; i++) 
        option += '<option value=./images/car' + i + '.jpg >' + name[i-1] + '</option>';

    $('#select-menu').append(option);

    $('#select-menu').on('change', function() {
        $('#image-show').attr('src', $('#select-menu').val())
    })
});