var canvasModule = (function () {

    var ctx = document.getElementById('canvas').getContext('2d');

    var drawRect = function (x, y, width, height) {
        ctx.rect(x, y, width, height);
        ctx.fill();
    }

    var drawCircle = function (cx, cy, radius) {
        ctx.beginPath();
        ctx.arc(cx, cy, radius, 0, 2 * Math.PI);
        ctx.fill();
    }

    var drawLine = function (x1, y1, x2, y2) {

        ctx.moveTo(x1, y1);
        ctx.lineTo(x2, y2);
        ctx.stroke();
    }

    return {
        drawRect: drawRect,
        drawCircle: drawCircle,
        drawLine: drawLine
    }
}());