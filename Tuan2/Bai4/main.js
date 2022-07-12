$(document).ready(function() {

    var optionDate = optionMonth = optionYear = "";

    for (var i = 1; i <= 31; i++)
        optionDate += '<option value='+ i + '>' + i + '</option>';

    for (var i = 1; i <= 12; i++)
        optionMonth += '<option value='+ i + '>' + i + '</option>';

    for (var i = 1900; i <= 2100; i++)
        if (i === 2000)
            optionYear += '<option selected="selected" value='+ i + '>' + i + '</option>';
        else
            optionYear += '<option value='+ i + '>' + i + '</option>';

    var date = new Date();
    var currentDate = date.getDate();
    var currentMonth = date.getMonth();
    var currentYear = date.getFullYear();
    var current = new Date(currentMonth + '/' + currentDate + '/' + currentYear);

    var selectedDate = 1;
    $('.container #date').on('change', function() {
        selectedDate = this.value;
      });

    var selectedMonth = 1;
    $('.container #month').on('change', function() {
        selectedMonth = this.value;
    });

    var selectedYear = 2000;
    $('.container #year').on('change', function() {
        selectedYear = this.value;
        var selected = new Date(selectedMonth + '/' + selectedDate + '/' + selectedYear);

        var result = (selected - current) / (24 * 60 * 60 * 1000) - 30;
        if (result == 0) 
            alert('Happy birthday!');
        else if (result > 0)
            alert('Còn ' + result + ' ngày nữa đến sinh nhật bạn!')
        else
            alert('Sinh nhật bạn qua rồi!')
    });

    

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