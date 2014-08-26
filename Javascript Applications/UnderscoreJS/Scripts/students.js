/// <reference path="libs/underscore.js" />
(function () {

    function findStudentsWhoseFirstNameIsBeforeLastName(students) {
        var result = _.filter(students, function (student) {
            return student.firstName < student.lastName;
        });

        var sortedResult = _.sortBy(result, function (student) {
            return student.firstName + student.lastName;
        })

        return sortedResult;
    }

    function findStudentsByAgeInterval(students) {
        return _.filter(students, function (student) {
            return student.age >= 18 && student.age <= 24;
        });
    }

    function findStudentsByMaxGrade(students) {
        return _.max(students, function (student) {
            return student.grade;
        });
    }

    var students = [];
    students.push(new Student('pesho', 'b', 15, 2));
    students.push(new Student('c', 'misho', 18, 3));
    students.push(new Student('a', 'pesho', 20, 4));
    students.push(new Student('d', 'gosho', 26, 5));
    students.push(new Student('gosho', 'd', 19, 6));
    students.push(new Student('b', 'misho', 28, 5));

    var foundStudentsByNames = findStudentsWhoseFirstNameIsBeforeLastName(students);
    console.log(foundStudentsByNames);

    var foundStudentsByAge = findStudentsByAgeInterval(students);
    console.log(foundStudentsByAge);

    var foundStudentsByMaxGrade = findStudentsByMaxGrade(students);
    console.log(foundStudentsByMaxGrade);
}());