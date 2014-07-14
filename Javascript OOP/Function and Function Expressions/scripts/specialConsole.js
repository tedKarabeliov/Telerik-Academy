var specialConsole = (function () {

    var console = document.getElementById('special-console');

    var writeLine = function (inputString) {

        var newLine = document.createElement('div');
        var text = inputString;
        text = formatText(text, arguments);
        newLine.textContent = text;
        console.appendChild(newLine);
    }

    var writeError = function (inputString) {
        var newLine = document.createElement('div');
        var text = inputString;
        text = formatText(text, arguments);
        newLine.textContent = text;
        newLine.style.color = 'red';
        console.appendChild(newLine);
    }

    var writeWarning = function (inputString) {
        var newLine = document.createElement('div');
        var text = inputString;
        text = formatText(text, arguments);
        newLine.textContent = text;
        newLine.style.color = 'yellow';
        console.appendChild(newLine);
    }

    var formatText = function (text, arguments) {
        for (var i = 1; i < arguments.length; i++) {
            var currentReplacementWord = arguments[i];
            text = text.split('{' + (i - 1) + '}').join(currentReplacementWord);
        }
        return text;
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    }
})()