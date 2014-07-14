var domModule = (function () {

    var buffer = [];

    var appendChild = function (child, selector) {

        document.querySelector(selector).appendChild(child);
    }

    var removeChild = function (parent, child) {

        var parentNode = document.querySelector(parent);
        var childNode = document.querySelector(child);
        
        parentNode.removeChild(childNode);
    }

    var addHandler = function (selector, type, handler) {

        var elements = document.querySelectorAll(selector);

        for (var i = 0; i < elements.length; i++) {
            elements[i].addEventListener(type, handler);
        }
    }

    var appendToBuffer = function (selector, child) {

        if (buffer[selector]) {
            buffer[selector].push(child);
            if (buffer[selector].length == 100) {

                var element = document.querySelector(selector);
                for (var i = 0; i < buffer[selector].length; i++) {

                    element.appendChild(buffer[selector][i]);
                }
            }
        }
        else {
            buffer[selector] = [];
            buffer[selector].push(child);
        }
    }

    var getElementsBySelector = function (selector) {

        return document.querySelectorAll(selector);
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer,
        getElementsBySelector: getElementsBySelector
    };
}());