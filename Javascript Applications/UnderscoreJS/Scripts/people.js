/// <reference path="libs/underscore.js" />
/// <reference path="person.js" />
(function () {

    var people = [];

    people.push(new Person('pesho', 'peshov'));
    people.push(new Person('misho', 'mishov'));
    people.push(new Person('pesho', 'peshov'));
    people.push(new Person('pesho', 'peshov'));
    people.push(new Person('gosho', 'goshov'));
    people.push(new Person('gosho', 'goshov'));

    var peopleGroupedByFullName = _.groupBy(people, function (person) {
        return person.firstName + " " + person.lastName;
    })

    var peopleWithMostCommonFullName = _.max(peopleGroupedByFullName, function (peopleWithFullName) {
        return peopleWithFullName.length;
    })

    console.log(peopleWithMostCommonFullName);

}())