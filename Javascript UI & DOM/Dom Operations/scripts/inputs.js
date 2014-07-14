/// <reference path="../lib/jquery-1.11.1.js" />
$(document).ready(function () {
    $('div > div').append($('<textarea/>'));
    $('div > div').append($('<input type="color">')).append($('<input type="color">'));
    $('div > div').append($('<button/>'));
    var textArea = $('textarea');
    var firstInput = $('textarea + input');
    var secondInput = $('input + input');
    var button = $('button').text('Go!');
    
    button.click(function () {
        textArea.css('color', firstInput.val());
        textArea.css('background', secondInput.val());
    })

    console.log();
})