/// <reference path="raphael-min.js" />
window.onload = function () {

    var paper = Raphael(10, 10, 1000, 1000);

    var path = ['M200,140'];

    for (i = 0; i < 360; i++) {
        angle = 0.1 * i;
        x = (1 + 4 * angle) * Math.cos(angle) + 200;
        y = (1 + 4 * angle) * Math.sin(angle) + 140;
        path.push('L' + x + ',' + y);
    }
    path = path.join(' ');
    paper.path(path);
    
}