$(document).ready(function() {
    var m = parseInt(prompt("Nhập số dòng: "));3
    
    var n = parseInt(prompt("Nhập số cột "));
    var table = '<table id="table1" border="1">';

    for (var i = 1; i <= m; i++) {
        table += '<tr>';
        for (var  j = 1; j <= n; j++) 
            table += '<td>' + (i*10 + j) + '</td>';
        table += '</tr>';
    }
    table += '</table>';
    
    $('.container').html(table);
    $('.container #table1').css({"borderCollapse": "collapse"});
});




/*var table = document.createElement('table');
table.setAttribute('border', 1);
table.style.borderCollapse = 'collapse';

for (var i = 1; i <= m; i++){
    var tr = document.createElement('tr');   
    for (var j = 1; j <= n; j++) {
        var td = document.createElement('td');
        var text = document.createTextNode(j + i*10);
        td.appendChild(text);
        tr.appendChild(td);
    }   
    table.appendChild(tr);
}
document.body.appendChild(table);*/
    