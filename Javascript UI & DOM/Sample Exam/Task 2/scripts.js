/// <reference path="jquery.min.js" />
$.fn.tabs = function () {
    $('#tabs-container').addClass('tabs-container');

    function applyStyles() {
        $('div.tab-item-content').css('display', 'none');
        $('strong.tab-item-title').css('background', '#fff')
        $('strong.tab-item-title').css('borderBottom', '1px solid black')
        $('strong.selected').next().css('display', 'block');
        $('strong.selected').css('background', '#ccc');
        $('strong.selected').css('borderBottom', 'none');
    }

    $('strong.tab-item-title:first').addClass('selected');
    
    applyStyles();

    $('strong.tab-item-title').click(function (e) {
        if (this == e.target) {
            $('strong').removeClass('selected');
            $(this).addClass('selected');
            applyStyles();
        }
    })
    console.log();
};