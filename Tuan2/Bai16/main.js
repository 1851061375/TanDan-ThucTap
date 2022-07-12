$(document).ready(function() {

    function Car(carName, image, priceBuyGold, priceSoldGold, priceBuyUSD, priceSoldUSD, desciption) 
    {
        this.carName = carName;
        this.image = image;
        this.priceBuyGold = priceBuyGold;
        this.priceSoldGold = priceSoldGold;
        this.priceBuyUSD = priceBuyUSD;
        this.priceSoldUSD = priceSoldUSD;
        this.desciption = desciption;
    }
    var car1 = new Car('Toyota', './images/car1.jpg', 0, 0, 0, 0, 'Kiểu dáng thể thao');
    var car2 = new Car('KIA', './images/car2.jpg', 0, 0, 0, 0, 'Nổi bật ít tốn nhiên liệu');
    var car3 = new Car('Ford', './images/car3.jpg', 0, 0, 0, 0, 'Thiết kế sang trọng');
    var car4 = new Car('Civic', './images/car4.jpg', 0, 0, 0, 0, 'Mạnh mẽ năng động');
    var car5 = new Car('Ferrari', './images/car5.jpg', 0, 0, 0, 0, 'Tốc độ ');
    var car6 = new Car('Mecrcedes', './images/car6.jpg', 0, 0, 0, 0, 'Thiết kế sang trọng');

    var arrayObject = new Array();
    arrayObject.push(car1);
    arrayObject.push(car2);
    arrayObject.push(car3);
    arrayObject.push(car4);
    arrayObject.push(car5);
    arrayObject.push(car6);


    var option = '';
    for (var i = 0; i < arrayObject.length; i++)
        option += '<option value=' + arrayObject[i]['image'] + '>' + arrayObject[i]['carName'] + '</option>';
    $('#select-menu').append(option);
    // Tim object khi biet dung dan anh.
    function findObject(array, value) {
        var result = array.find(obj => {
            return obj.image === value
        });
        return result;
    }
    
    function setAttrHTML(object) {
        $('#gold td:nth-child(1)').text(object['priceBuyGold']);
        $('#gold td:nth-child(2)').text(object['priceSoldGold']);

        $('#usd td:nth-child(1)').text(object['priceBuyUSD']);
        $('#usd td:nth-child(2)').text(object['priceSoldUSD']);

        $('.desciption td:nth-child(1)').text(object['desciption']);
        $('#image').attr('src', object['image']);

        $('#price td:nth-child(1)').text('Giá: ' + object['priceSoldUSD'] + ' USD');

    }

    var imageCar = './images/car1.jpg';
    setAttrHTML(arrayObject[0]);

    $('#select-menu').on('change', function () {
        imageCar = this.value;      
        setAttrHTML(findObject(arrayObject, imageCar));
    });

    function setValueObject(object) {
        if (type === 1) {
            object['priceBuyGold'] = priceBuy;
            object['priceSoldGold'] = priceSold;
        }
        else if (type === 0) {
            object['priceBuyUSD'] = priceBuy;
            object['priceSoldUSD'] = priceSold;
        }
        setAttrHTML(object);
    }

    


    $('#input-buy').focus();
    $('#button-update').attr('disabled', 'disabled');

    var priceBuy, priceSold, type;

    $('#box').on('change', function() {       
        $("input[name='type']:checked").each(function() {
            type = parseInt(this.value);
        });

        if (Number.isInteger(priceBuy) && Number.isInteger(type))
            $('#button-update').removeAttr('disabled', 'disabled');
        else 
            $('#button-update').attr('disabled', 'disabled');
    });       

    $('#input-buy').on('blur', function () {
        priceBuy = parseInt($('#input-buy').val());
    
        if (Number.isInteger(priceBuy) && Number.isInteger(type))
            $('#button-update').removeAttr('disabled', 'disabled');
        else 
            $('#button-update').attr('disabled', 'disabled');
    });

    $('#input-sold').on('blur', function () {
        priceSold = parseInt($('#input-sold').val());
        if (!Number.isInteger(priceSold))
            priceSold = 0;
    });
    

    $('#button-update').on('click', function() {
        var object = findObject(arrayObject, imageCar);
        setValueObject(object);
    });


});