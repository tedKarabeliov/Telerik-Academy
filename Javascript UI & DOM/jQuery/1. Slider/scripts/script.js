/// <reference path="../lib/jquery-1.11.1.js" />
$(document).ready(function () {
    var contentLength = $('.content > div').length;
    var currentIndex = 0;

    $('input[type="image"]').on('click', function () {
        if ($(this).attr('id') == 'left') {
            if (currentIndex >= 1) {
                $('.content > div.selected').removeClass('selected').css('display', 'none').prev().slideDown('slow').addClass('selected');
                currentIndex--;
            }
        }
        else {
            if (currentIndex < contentLength - 1) {
                $('.content > div.selected').removeClass('selected').css('display', 'none').next().slideDown('slow').addClass('selected');
                currentIndex++;
            }
        }
    })
})