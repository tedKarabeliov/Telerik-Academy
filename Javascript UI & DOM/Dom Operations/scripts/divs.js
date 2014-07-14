/// <reference path="../lib/jquery-1.11.1.js" />
$('document').ready(function () {

    function getRandomInt(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    function getRandomColor() {
        return 'rgb(' + getRandomInt(0, 255) + ', ' + getRandomInt(0, 255) + ', ' + getRandomInt(0, 255) + ')';
    }

    var DIV_ELEMENTS_COUNT = 5;

    for (var i = 0; i < DIV_ELEMENTS_COUNT; i++) {
        var newElement = $('<div/>', {
            style: function () {
                var str = 'width: ' + getRandomInt(20, 100) + 'px; ' +
                    'height:' + getRandomInt(20, 100) + 'px; ' +
                    'background:' + getRandomColor() + '; ' +
                    'color:' + getRandomColor() + '; ' +
                    'position: absolute; ' +
                    'left: ' + getRandomInt(0, 500) + 'px; ' +
                    'top: ' + getRandomInt(0, 500) + 'px; ' +
                    'border: ' + getRandomInt(0, 20) + 'px solid; ' +
                    'border-radius: ' + getRandomInt(0, 20) + 'px; ' +
                    'border-color: ' + getRandomColor();

                return str;
            }
        }).html('<strong>div</strong>').appendTo('#wrapper');
    }
});