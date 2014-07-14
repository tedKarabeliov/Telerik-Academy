/// <reference path="../lib/jquery-1.11.1.min.js" />
/// <reference path="../lib/handlebars.min.js" />
$(document).ready(function () {

    jQuery.prototype.listview = function (items) {

        function getFirstKeyOfAnArray(arr) {
            for (var prop in arr) {
                return prop;
            }
        }

        var templateName = $(this).data('template');
        if (!templateName) {
            templateName = this.attr('id');
        }
        var templateHTML = $('#' + templateName).html();
        var itemsName = getFirstKeyOfAnArray(items);
        templateHTML = '{{#' + itemsName + '}}' + templateHTML + '{{/' + itemsName + '}}';
        var resultHTML = Handlebars.compile(templateHTML);
        $(this).html('');
        $(this).append(resultHTML(items));
    }

    var students = {
        students: [
            {
                number: 1,
                name: 'Peter Petrov',
                mark: '5.5'
            },
            {
                number: 2,
                name: 'Stamat Georgiev',
                mark: '5.5'
            },
            {
                number: 3,
                name: 'Maria Todorova',
                mark: '6'
            },
            {
                number: 4,
                name: 'Georgi Geshov',
                mark: '3.7'
            },
        ]
    };

    $('#students-table').listview(students);
})