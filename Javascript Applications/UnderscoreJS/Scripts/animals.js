/// <reference path="libs/underscore.js" />
/// <reference path="animal.js" />
(function () {

    function groupAnimalsBySpecie(animals) {
        var grouped = _.groupBy(animals, 'specie');
        var sorted = _.sortBy(grouped, function (group) {
            return group[0].numberOfLegs;
        })
        return sorted;
    }

    function calculateTotalLegs(animals) {
        var totalLegs = 0;
        _.each(animals, function (animal) {
            totalLegs += animal.numberOfLegs;
        })

        return totalLegs;
    }

    var animals = [];
    animals.push(new Animal('dog', 4));
    animals.push(new Animal('bug', 50));
    animals.push(new Animal('dog', 4));
    animals.push(new Animal('dog', 4));
    animals.push(new Animal('bird', 2));
    animals.push(new Animal('bird', 2));
    animals.push(new Animal('bug', 50));
    animals.push(new Animal('bug', 50));
    animals.push(new Animal('bug', 50));

    var groupedAnimalsBySpecie = groupAnimalsBySpecie(animals);
    console.log(groupedAnimalsBySpecie);

    var totalLegs = calculateTotalLegs(animals);
    console.log(totalLegs);
}())