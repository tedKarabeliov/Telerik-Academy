/// <reference path="../lib/jquery-1.11.1.js" />
$(document).ready(function () {
    var DIV_ELEMENTS_COUNT = 5;
    var CENTER_X = 250;
    var CENTER_Y = 250;
    var RADIUS = 100;

    var divs = [];
    for (var i = 0; i < DIV_ELEMENTS_COUNT; i++) {
        var newDiv = $('<div/>');
        newDiv.css('width', '40px');
        newDiv.css('height', '40px');
        newDiv.css('position', 'absolute');
        newDiv.css('border', '1px solid black');
        newDiv.css('border-radius', '100px');
        divs.push(newDiv);
        $('#wrapper').append(newDiv);
    }

    divs[0].css('left', CENTER_X + RADIUS * Math.cos(0));
    divs[0].css('top', CENTER_Y + RADIUS * Math.sin(0));

    divs[1].css('left', CENTER_X + RADIUS * Math.cos(1.256637061));
    divs[1].css('top', CENTER_Y + RADIUS * Math.sin(1.256637061));

    divs[2].css('left', CENTER_X + RADIUS * Math.cos(2.513274123));
    divs[2].css('top', CENTER_Y + RADIUS * Math.sin(2.513274123));

    divs[3].css('left', CENTER_X + RADIUS * Math.cos(3.769911184));
    divs[3].css('top', CENTER_Y + RADIUS * Math.sin(3.769911184));

    divs[4].css('left', CENTER_X + RADIUS * Math.cos(5.026548246));
    divs[4].css('top', CENTER_Y + RADIUS * Math.sin(5.026548246));

    divs[0].css('left', CENTER_X + RADIUS * Math.cos(0));
    divs[0].css('top', CENTER_Y + RADIUS * Math.sin(0));

    var i = 0;
    setInterval(function () {
        for (var k = 0; k < DIV_ELEMENTS_COUNT; k++) {
            divs[k].css('left', CENTER_X + RADIUS * Math.cos(2 * Math.PI * (i + k * 72) / 360) + 'px');
            divs[k].css('top', CENTER_Y + RADIUS * Math.sin(2 * Math.PI * (i + k * 72) / 360) + 'px');
        }
        i++;
    }, 100);
});