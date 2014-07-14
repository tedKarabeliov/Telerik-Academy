define(['jquery', 'mustache'], function ($, mustache) {

    var controls = (function () {

        var ComboBox = (function () {

            function ComboBox(people) {
                this._people = people;
            }

            ComboBox.prototype.render = function (template) {
                var renderedHTML = '';
                var compiledTemplate = mustache.compile(template);

                for (var i = 0; i < this._people.length; i++) {
                    var currentPerson = compiledTemplate(this._people[i]);
                    renderedHTML += currentPerson;
                }
                return renderedHTML;
            }

            return ComboBox;
        }());

        return {
            getComboBox: function (people) {
                return new ComboBox(people);
            }
        };

    }());

    return controls;
});