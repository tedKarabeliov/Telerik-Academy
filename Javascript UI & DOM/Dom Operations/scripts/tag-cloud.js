/// <reference path="../lib/jquery-1.11.1.js" />
$(document).ready(function () {

    function generateTagCloud(tags, fontMin, fontMax) {

        function findMax(arr) {
            var max = 0;

            for (var prop in arr) {
                if (arr[prop] > max) {
                    max = arr[prop];
                }
            }
            return max;
        }

        function countTags(tags) {
            var result = {};

            for (var i = 0; i < tags.length; i++) {

                if (result.hasOwnProperty(tags[i])) {
                    result[tags[i]]++;
                }
                else {
                    result[tags[i]] = 1;
                }
            }

            return result;
        }

        function setFontSize(arr, fontMax) {
            var result = {};

            for (var i = 0; i < arr.length; i++) {
                result[arr[i]] = fontMax;
            }


            return result;
        }

        tags = countTags(tags);

        var result = [];
        var maxOccurences = findMax(tags);
        while (maxOccurences != 0) {
            var groupedByOccurence = [];

            for (var index in tags) {

                if (tags[index] == maxOccurences) {
                    groupedByOccurence.push(index);
                    tags[index] = 0;
                }
            }
            result.push(setFontSize(groupedByOccurence, fontMax));
            fontMax = Math.round((fontMax + fontMin) / 2);
            maxOccurences = findMax(tags);
        }

        var tagCloud = $('<div/>').attr('id', 'tagCloud').appendTo('#wrapper');

        for (var i = 0; i < result.length; i++) {
            var currentGroup = result[i];

            for (var index in currentGroup) {
                var newSpan = $('<span/>').css('font-size', currentGroup[index]).text(index + ' ');
                $('#tagCloud').append(newSpan);
            }
        }
    }

    var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"];
    var tagCloud = generateTagCloud(tags, 17, 42);
})