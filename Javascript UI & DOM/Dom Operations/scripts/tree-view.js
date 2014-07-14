/// <reference path="../lib/jquery-1.11.1.js" />
$(document).ready(function () {

    $('li.sub-list').click(function (event) {
        //event.stopPropagation();
        var sublist = $(this).children('ul');

        if (this == event.target) {
            if (sublist.css('display') === 'none') {
                sublist.css('display', 'block');
            }
            else {
                sublist.css('display', 'none');
            }
        }

        
    })

})