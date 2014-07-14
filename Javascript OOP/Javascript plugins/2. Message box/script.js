/// <reference path="jquery-1.11.1.js" />
window.alert = function (message) {

    var messageBox = $('<div class="message-box">');
    var messageArea = $('<div class="message-area">').text(message).appendTo(messageBox);
    $('body').append(messageBox);

    for (var i = 0; i < 3; i++) {
        messageBox.fadeOut('slow');
        messageBox.fadeIn('slow');
    }
    console.log();
}

alert('message');