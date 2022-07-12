$(document).ready(function() {
    var message = '';
    $('#submit').on('click', function() {
        var item = new Array();
        $('message').text('');
        message = 'Bạn đã chọn cafe: '
        $("input[type='checkbox']:checked").each(function() {
            var idVal = $(this).attr("id");
            if (!item.includes($("label[for='"+idVal+"']").text()))
                item.push($("label[for='"+idVal+"']").text());
        });

        for (var i = 0; i < item.length - 1; i++)
            message += item[i] + ', ';
        message += item[item.length-1]
        $('#message').text(message);
    });
})