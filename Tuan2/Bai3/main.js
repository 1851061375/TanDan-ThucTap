$(document).ready(function() {
    var optionDate = optionMonth = optionYear = "";
    for (var i = 1; i <= 31; i++)
        optionDate += '<option value='+ i + '>' + i + '</option>';

    for (var i = 1; i <= 12; i++)
        optionMonth += '<option value='+ i + '>' + i + '</option>';


    for (var i = 1900; i <= 2100; i++)
        optionYear += '<option value='+ i + '>' + i + '</option>';

    
    $('.container #text-first').append('Mời bạn chọn ngày sinh: ');
    $('.container #text-second').append(' tháng: ');
    $('.container #text-third').append(' năm: ');

    $('.container #date').append(optionDate);
    $('.container #month').append(optionMonth);
    $('.container #year').append(optionYear);


    $('.container #date').css({"height":  "30px", "margin-left": "5px"});
    $('.container #month').css({"height":  "30px", "margin-left": "5px"});
    $('.container #year').css({"height":  "30px", "margin-left": "5px"});
    $('.container').css({"display": "flex", "align-items": "center"});
});