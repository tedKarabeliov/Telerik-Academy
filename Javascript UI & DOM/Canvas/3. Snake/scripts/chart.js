function loadChart() {

        var sortFunction = function (a, b) {
            return b.score - a.score;
        };

        var sortedLocalStorage = [];
        for (var name in localStorage) {
            sortedLocalStorage.push({ name: name, score: localStorage[name] });
        }
        sortedLocalStorage.sort(sortFunction);

        var chart = document.getElementById('chart');

        for (var i = 0; i < sortedLocalStorage.length && i < 5; i++) {
            var tbody = document.getElementsByTagName('tbody')[0];
            var tr = document.createElement('tr');
            tbody.appendChild(tr);
            var currentPosition = tr.appendChild(document.createElement('td'));
            currentPosition.innerHTML = i + 1;
            var currentName = tr.appendChild(document.createElement('td'));
            currentName.innerHTML = sortedLocalStorage[i].name;
            var currentScore = tr.appendChild(document.createElement('td'));
            currentScore.innerHTML = sortedLocalStorage[i].score;
        }
}

loadChart();