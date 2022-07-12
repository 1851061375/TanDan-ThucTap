$(document).ready(function() {
    var arrayImage = new Array();
    for (var i = 1; i <= 10; i++)
        arrayImage.push('../Bai9/images/anh' + i +'.jpg');
    
    var show;

    $('#image-view').on('mouseover', function() {
        function setImage(){
            $('#image-view').attr("src", arrayImage[Math.floor(Math.random(1, 10) * arrayImage.length)]);
        }
        show = setInterval(setImage, 2000)
    });

    $('#image-view').on('mouseout', function() {
        clearInterval(show);
    });
});