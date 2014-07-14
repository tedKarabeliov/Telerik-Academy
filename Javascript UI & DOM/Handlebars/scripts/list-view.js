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
        var templateNode = $('#' + templateName);
        if (!templateNode) {
            templateNode = this;
        }
        var templateHTML = $('#' + templateName).html();
        var itemsName = getFirstKeyOfAnArray(items);
        templateHTML = '{{#' + itemsName + '}}' + templateHTML + '{{/' + itemsName + '}}';
        var resultHTML = Handlebars.compile(templateHTML);
        $(this).append(resultHTML(items));
    }

    var books = {
        books: [
            {
                id: 'http://it-ebooks.info/book/274/',
                title: 'Javascript The Good parts'
            },
            {
                id: 'http://jsninja.com/',
                title: 'Secrets of the Javascript Ninja'
            },
            {
                id: 'http://corehtml5canvas.com/',
                title: 'Core HTML5 Canvas'
            },
            {
                id: 'http://addyosmani.com/resources/essentialjsdesignpatterns/book/',
                title: 'Javascript Patterns'
            }]
    };

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

    $('#books-list').listview(books);
    $('#students-table').listview(students);
})