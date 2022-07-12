$(document).ready(function() {
    var arrayImage = new Array();
    for (var i = 1; i <= 10; i++)
        arrayImage.push('./images/anh' + i +'.jpg');
    
    var show;

    $('#button-play').on('click', function() {
        function setImage(){
            $('#image-view').attr("src", arrayImage[Math.floor(Math.random(1, 10) * arrayImage.length)]);
        }
        show = setInterval(setImage, 2000)
    });

    $('#button-stop').on('click', function() {
        clearInterval(show);
    });
});