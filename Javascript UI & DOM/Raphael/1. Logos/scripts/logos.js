/// <reference path="raphael-min.js" />
window.onload = function () {

    var paper = Raphael(0, 0, 2200, 2200);

    var telerikText = paper.text(200, 86, 'Telerik');
    telerikText.attr({
        'font-size': 50,
        'font-weight': 'bold'
    });
    var registeredSign = paper.text(285, 83, '®');
    registeredSign.attr({
        'font-size': 12,
        'font-weight': 'bold'
    });

    var developText = paper.text(225, 116, 'Develop experiences');
    developText.attr({
        'font-size': 20
    });

    var logo = paper.path('M90 90 L60 60 L30 90 L60 120 L90 90');
    logo.attr({
        fill: '#5CE600',
        stroke: 'none'
    });

    var wing1 = paper.path('M60 60 L86 34 L112 60 L103 69 L86 52 L66 70');
    wing1.attr({
        fill: '#5CE600',
        stroke: 'none'
    });
    var wing2 = paper.path('M60 60 L35 35 L15 55 L25 63 L35 50 L55 70')

    wing2.attr({
        fill: '#5CE600',
        stroke: 'none'
    });

    var you = paper.text(600, 100, 'You');

    you.attr({
        'font-size': 50
    });

    var rect = paper.rect(650, 70, 125, 70);

    rect.attr({
        fill: '#EC2828',
        r: 15
    });

    var tube = paper.text(710, 100, 'Tube');

    tube.attr({
        'font-size': 50,
        'fill': '#FFFFFF'
    });
}