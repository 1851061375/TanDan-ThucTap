$(document).ready(function () {
    var arrayClass = ['60TH1', '60TH2', '60TH3', '60TH4', '60TH5'];
    var arraySubject = ['Cơ sở dữ liệu', 'Cấu trúc dữ liệu và giải thuật',
                        'Lập trình nâng cao', 'Thuật toán ứng dụng', 'Công nghệ web'];
    
    var optionClass = optionSubject = '';
    for (var i = 0; i < arrayClass.length; i++)
        optionClass += '<option >' + arrayClass[i] + '</option>';

    for (var i = 0; i < arraySubject.length; i++)
        optionSubject += '<option >' + arraySubject[i] + '</option>';
    
    $('#select-class').append(optionClass);
    $('#select-subject').append(optionSubject);
  
    var row = '';
    $('#submit').on('click', function() {
        row = '<tr>'
        + '<td>' + $("#input-name").val() + '</td>' 
        + '<td>' + $("#select-class option:selected").html() + '</td>' 
        + '<td>' + $("#select-subject option:selected").html() + '</td>' 
        + '<td>' + $("input[name='type']:checked").next('label').text() + '</td>' +
        '</tr>';

        $('#list-table tr:last').after(row);
    });
});