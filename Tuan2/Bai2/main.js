$(document).ready(function() {
    var maSV = prompt("Mã SV: ");
    var hoTen = prompt("Họ tên: ");
    var lop = prompt("Lớp");

    $('#student-code').text(maSV);
    $('#full-name').text(hoTen);
    $('#class').text(lop);

});
