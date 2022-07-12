$(document).ready(function() {
    $('#box').on('change', function() {       
        $("input[type='radio']:checked").each(function() {
            var id = $(this).attr("id");
            alert('Bạn đang chọn cafe: ' + $("label[for='"+id+"']").text());
        });        
    });   
});