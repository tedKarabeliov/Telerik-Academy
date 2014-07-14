/// <reference path="../lib/jquery-1.11.1.js" />
function generateTable(students) {
    var body = $(document.body).append('<table><thead><tr><th>First name<th>Last name<th>Grade');
    var tbody = $('<tbody>');
    $('table').append(tbody);
    for (var i = 0; i < students.length; i++) {
        tbody.append('<tr><td>' + students[i].fname + '<td>' + students[i].lname + '<td>' + students[i].grade);
    }
    
}
