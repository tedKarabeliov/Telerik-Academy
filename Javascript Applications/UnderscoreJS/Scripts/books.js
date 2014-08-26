/// <reference path="libs/underscore.js" />
/// <reference path="book.js" />
(function () {

    function findMostPopularAuthor(books) {
        var grouped = _.groupBy(books, 'author');
        grouped = _.max(grouped, function (group) {
            return group.length;
        });

        return grouped[0].author;
    }

    var books = [];
    books.push(new Book('pesho'));
    books.push(new Book('misho'));
    books.push(new Book('gosho'));
    books.push(new Book('pesho'));
    books.push(new Book('pesho'));
    books.push(new Book('misho'));
    books.push(new Book('pesho'));

    var booksWithMostPopularAuthor = findMostPopularAuthor(books);
    console.log(booksWithMostPopularAuthor);
}())