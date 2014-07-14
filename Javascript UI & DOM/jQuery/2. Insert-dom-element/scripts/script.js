/// <reference path="../lib/jquery-1.11.1.js" />
$(document).ready(function () {

    jQuery.prototype.appendAfter = function (elementToAppend) {
        $('<' + elementToAppend + '>').insertAfter(this);
        return this;
    }

    jQuery.prototype.appendBefore = function (elementToAppend) {
        $('<' + elementToAppend + '>').insertBefore(this);
        return this;
    }

    var element = $('#the-element');
    element.appendAfter('div');
    element.appendBefore('div');
    console.log();
})