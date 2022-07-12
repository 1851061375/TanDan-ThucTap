$(document).ready(function() {
    var firstNumber, secondNumber;

    $('#first-number').on('blur', function() {
        firstNumber = $('#first-number').val();
        firstNumber = parseInt(firstNumber);         
    });

    $('#second-number').on('blur', function() {
        secondNumber = $('#second-number').val();
        secondNumber = parseInt(secondNumber);         
    });

    $('#sum').on('click', function() {
        if (!Number.isInteger(firstNumber) || !Number.isInteger(secondNumber))
            alert('Nhập số!');
        else {
            $('#result').val(firstNumber + secondNumber);
        }
    });

    $('#sub').on('click', function() {
        if (!Number.isInteger(firstNumber) || !Number.isInteger(secondNumber))
            alert('Nhập số!');
        else {
            $('#result').val(firstNumber - secondNumber);
        }
    });
    
    $('#mul').on('click', function() {
        if (!Number.isInteger(firstNumber) || !Number.isInteger(secondNumber))
            alert('Nhập số!');
        else {
            $('#result').val(firstNumber * secondNumber);
        }
    });

    $('#div').on('click', function() {
        if (!Number.isInteger(firstNumber) || !Number.isInteger(secondNumber))
            alert('Nhập số!');
        else {
            $('#result').val((firstNumber / secondNumber).toFixed(2));
        }
    });

    $('#remain-div').on('click', function() {
        if (!Number.isInteger(firstNumber) || !Number.isInteger(secondNumber))
            alert('Nhập số!');
        else {
            $('#result').val((firstNumber % secondNumber));
        }
    });
});