/// <reference path="../lib/handlebars.min.js" />
window.onload = function () {

    function selectTemplate(items) {

        var data = { items: items };

        var template = document.getElementById('template').innerHTML;
        var resultTemplate = Handlebars.compile(template);
        document.getElementById('wrapper').innerHTML = resultTemplate(data);
    }

    var items = [{
        value: 1,
        text: 'One'
    }, {
        value: 2,
        text: 'Two'
    }, {
        value: 3,
        text: 'Three'
    }, {
        value: 4,
        text: 'Four'
    }, {
        value: 5,
        text: 'Five'
    }, {
        value: 6,
        text: 'Six'
    }, {
        value: 7,
        text: 'Seven'
    }];

    var selectHTML = selectTemplate(items);
}