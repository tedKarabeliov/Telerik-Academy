define(function () {
    'use strict';
    var Item;
    Item = (function () {

        var content;

        function Item(contentInput) {

            content = contentInput;

            return {
                content: content,
                getData: getData
            }
        }

        var getData = function () {
            return {
                'content': this.content
            }
        }

        return Item;
    })();
    return Item;
});