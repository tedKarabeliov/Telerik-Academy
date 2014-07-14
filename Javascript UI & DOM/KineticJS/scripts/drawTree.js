var drawTree = function (globalArray) {
    var layer, stage;
    stage = new Kinetic.Stage({
        container: 'canvas-container',
        width: 5000,
        height: 5000
    });
    layer = new Kinetic.Layer();

    var displayMember = function (member) {

        var rect = new Kinetic.Rect({
            x: member.position * 250,
            y: member.height * 150,
            width: 200,
            height: 100,
            cornerRadius: 10,
            stroke: 'green',
            strokeWidth: 2
        });

        var name = new Kinetic.Text({
            x: member.position * 250 + 35,
            y: member.height * 150 + 40,
            text: member.name,
            fontSize: 20,
            fontFamily: 'Calibri',
            fill: 'green'
        });

        layer.add(rect);
        layer.add(name);
    }

    var connectWithPartner = function (member) {
        if (member.partner) {
            if (member.position < member.partner.position) {
                var line = new Kinetic.Line({
                    points: [member.position * 250 + 200, member.height * 150 + 50, member.partner.position * 250, member.partner.height * 150 + 50],
                    stroke: 'red',
                    tension: 1
                });
                layer.add(line);
            }
        }
    }

    var connectWithChildren = function (member) {
        if (member.children) {
            for (var i = 0; i < member.children.length; i++) {
                var child = member.children[i];

                var line = new Kinetic.Line({
                    points: [member.position * 250 + 100, member.height * 150 + 100, child.position * 250 + 100, child.height * 150],
                    stroke: 'red',
                    tension: 1
                });
                layer.add(line);
            }
        }
    }
    
    for (var i = 0; i < globalArray.length; i++) {
        var currentMember = globalArray[i];

        displayMember(currentMember);
        connectWithPartner(currentMember);
        connectWithChildren(currentMember);
        
    }
    return stage.add(layer);
};