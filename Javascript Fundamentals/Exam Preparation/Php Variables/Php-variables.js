function Solve(args) {
    Array.prototype.contains = function (obj) {
        var i = this.length;
        while (i--) {
            if (this[i] === obj) {
                return true;
            }
        }
        return false;
    }

    function addToResult(variable) {
        if (!result.contains(variable)) {
            result.push(variable);
        }
    }

    function parseVariable(i) {

        function isLetter(str) {
            return str.length === 1 && str.match(/[a-zA-z]/i);
        }

        var k = i + 1;
        var variable = '';
        if (!(currentLine[k] == '_' || isLetter(currentLine[k]))) {
            return;
        }
        variable += currentLine[k];
        for (k++ ; k < currentLine.length; k++) {
            if (currentLine[k] == currentLine[k].match(/[a-zA-Z0-9_]/i)) {
                variable += currentLine[k];
            }
            else {
                break;
            }
        }
        addToResult(variable);
        return k;
    }

    function parseString() {
        var endString = currentLetter;
        var k = i + 1;
        for (; currentLine[k] != endString; k++) {
            if (currentLine[k] == '$' && currentLine[k - 1] != '\\') {
                parseVariable(k);
            }
        }
        i = k;
    }

    function parseLineComment() {
        var k = i + 1;
        if (currentLine[k] == '*' && currentLine[k - 1] == '/') {
            isInMultiLineComment = true;
            i++;
        }
        else {
            if (currentLine[k] == '/' || currentLine[k - 1] == '#') {
                while (i < currentLine.length) {
                    i++;
                }
            }
        }

    }

    var result = [];
    var isInMultiLineComment = false;

    for (var line = 1; line < args.length - 1; line++) {

        var currentLine = args[line];
        for (var i = 0; i < currentLine.length; i++) {

            var currentLetter = currentLine[i];

            if (isInMultiLineComment) {
                if (currentLetter == '*' && currentLine[i + 1] == '/') {
                    isInMultiLineComment = false;
                    i++;
                }
                continue;
            }

            switch (currentLetter) {
                case '$': i = parseVariable(i); break;
                case '\'':
                case '\"': parseString(); break;
                case '/':
                case '#': parseLineComment(); break;
                case '*': isInMultiLineComment = false; break;
                default: break;
            }
        }
    }
    result.sort();
    var answer = '';
    answer += result.length += '\n';
    for (var i = 0; i < result.length; i++) {
        answer += result[i] + '\n';
    }
    return answer.trim();
}

//<?php
///* This is $var1 in comments */
//$var3 = "Some string \$var4 with var escaped.";
//echo $var5; echo("$foo,$bar");
//// Another comment with variable $var2
//?>


var args = ['<?php',
    '/* This is $var1 in comments */',
    '$var3 = \"Some string \\$var4 with var escaped.\"',
    'echo $var5; echo("$foo,$bar");',
    '//  Another comment with variable $var2',
    '?>'];
console.log(Solve(args));