var movingShapes = (function () {

    function getRandomInt(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    var add = function (movement) {

        var div = document.createElement('div');

        var DIV_WIDTH = '20px';
        var DIV_HEIGHT = '20px';

        div.style.width = DIV_WIDTH;
        div.style.height = DIV_HEIGHT;
        div.style.position = 'absolute';
        div.style.top = getRandomInt(0, 200) + 'px';
        div.style.left = getRandomInt(100, 200) + 'px';
        div.style.background = 'rgb(' +
            getRandomInt(0, 255) + ', ' +
            getRandomInt(0, 255) + ', ' +
            getRandomInt(0, 255) + ')';
        div.style.fontSize = getRandomInt(5, 25) + 'px';
        div.style.borderColor = 'rgb(' +
            getRandomInt(0, 255) + ', ' +
            getRandomInt(0, 255) + ', ' +
            getRandomInt(0, 255) + ')';
        div.textContent = '!!!';

        document.body.appendChild(div);
        switch (movement) {
            case 'rect': generateRectangularMovement(div); break;
            case 'ellipse': generateCircularMovement(div); break;
            default: break;
        }
    }

    var generateRectangularMovement = function (div) {
        var i = 0;

        var updateRight = function () {
            var update = (parseInt(div.style.left) + 1) + 'px';
            div.style.left = update;
            if (i == 40) {
                clearInterval(intervalRight);
                intervalDown = setInterval(updateDown, 50);
            }
            i++;
        }
        var updateDown = function () {
            update = (parseInt(div.style.top) + 1) + 'px';
            div.style.top = update;
            if (i == 60) {
                clearInterval(intervalDown);
                intervalLeft = setInterval(updateLeft, 50);
            }
            i++;
        }
        var updateLeft = function () {
            update = (parseInt(div.style.left) - 1) + 'px';
            div.style.left = update;
            if (i == 100) {
                clearInterval(intervalLeft);
                intervalUp = setInterval(updateUp, 50);
            }
            i++;
        }
        var updateUp = function () {
            update = (parseInt(div.style.top) - 1) + 'px';
            div.style.top = update;
            if (i == 120) {
                clearInterval(intervalUp);
                i = 0;
                setInterval(updateRight, 50);
            }
            i++;
        }

        var intervalRight = setInterval(updateRight, 50);
    }

    var generateCircularMovement = function (div) {
        var RADIUS = 20;
        var CENTER_X = parseInt(div.style.left) - RADIUS;
        var CENTER_Y = CENTER_X;


        div.style.left = CENTER_X + RADIUS * Math.cos(0);
        div.style.top = CENTER_Y + RADIUS * Math.sin(0);

        var i = 0;
        setInterval(function () {
            div.style.left = CENTER_X + RADIUS * Math.cos(2 * Math.PI * (i * 72) / 360) + 'px';
            div.style.top = CENTER_Y + RADIUS * Math.sin(2 * Math.PI * (i * 72) / 360) + 'px';
            i++;
        }, 100);
    }

    return {
        add: add
    }
})()