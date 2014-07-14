define(function () {
    'use strict';
    var Section;
    Section = (function () {

        function Section(title) {

            this.title = title;
            this.items = [];
            return {
                title: this.title,
                items: this.items,
                add: add,
                getData: getData
            }
        }

        var add = function (item) {

            this.items.push(item);
        }

        var getData = function () {

            var itemsData = [];
            for (var i = 0; i < this.items.length; i++) {
                itemsData.push(this.items[i].getData());
            }

            return {
                'title': this.title,
                'items': itemsData
            }
        }

        return Section;
    }());
    return Section;
})