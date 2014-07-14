/// <reference path="jquery-1.11.1.js" />
jQuery.prototype.dropdown = function () {

    var $selectNode = $(this);
    $selectNode.removeAttr('id').addClass('dropdown');

    //$selectNode.css('display', 'none');

    //Create the div and ul
    var dropdownContainer = $('<div/>');
    dropdownContainer.attr('class', 'dropdown-list-container');
    var dropdownOptions = $('<ul/>');
    dropdownOptions.attr('class', 'dropdown-list-options');
    dropdownContainer.append(dropdownOptions);

    //Create the li elements
    $($selectNode.children()).each(function () {

        var $this = $(this);
        var dropdownOption = $('<li />');
        dropdownOption.addClass('dropdown-list-option');
        if ($this.attr('selected')) {
            dropdownOption.addClass('selected');
        }
        dropdownOption.attr('data-value', $this.attr('value') - 1);
        dropdownOption.text($this.text());
        dropdownOptions.append(dropdownOption);
    });

    //Insert div, ul and li's after #dropdown
    dropdownContainer.insertAfter($selectNode);

    $('li.dropdown-list-option').on('click', function (event) {

        $('li.dropdown-list-option').removeClass('selected');
        $(this).toggleClass('selected');
        var childNumber = $(this).index() + 1;
        $('.dropdown > option').removeAttr('selected');
        $('.dropdown > option:nth-child(' + childNumber + ')').attr('selected', 'selected');
        console.log();
    })
}