$(document).ready(function() {
    alert('Welcome To Shopping Flower');
  
    var arrayPrice = [0, 0, 0, 0, 0];

    function updatePrice(idInput, stt) {
        $(idInput).on('blur', function() {
            var totalPrice = 0;
            var count = parseInt($(idInput).val());
            if (!Number.isInteger(count))
                alert('Nhập số lượng ở hàng ' + stt);
            else {
                var price = parseInt($(idInput).parent().prev('td').text());
                arrayPrice[stt] = price * count;
                for (var i = 1; i <= 4; i++)
                    totalPrice += arrayPrice[i];
                $('#totalPrice').text(totalPrice + ' VNĐ');
            }

        })
    }

    updatePrice('#input1', 1);
    updatePrice('#input2', 2);
    updatePrice('#input3', 3);
    updatePrice('#input4', 4);

});




 