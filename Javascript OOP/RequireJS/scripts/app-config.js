require.config({
    paths: {
        jquery: 'libs/jquery-1.11.1',
        mustache: 'libs/mustache',
        controls: 'app/controls'
    }
});

require(['controls', 'jquery'], function (controls, $) {

    var people = [
        { id: 1, name: "Doncho Minkov", age: 18, avatarUrl: "images/minkov.jpg" },
        { id: 2, name: "Georgi Georgiev", age: 19, avatarUrl: "images/joreto.jpg" }
    ];
    var comboBox = controls.getComboBox(people);

    var template = $("#person-template").html();

    var comboBoxHtml = comboBox.render(template);

    $('#combo-box-container').html(comboBoxHtml);

    $('#combo-box-container div.person-item:first').addClass('selected');

    $('#combo-box-container div.person-item').on('click', function (e) {

        if ($(this).hasClass('selected')) {

            $('#combo-box-container div.person-item').removeClass('selected');
            $('#combo-box-container div.person-item').show();
        }
        else {
            $('#combo-box-container div.person-item').hide();
            $(this).addClass('selected');
            $(this).show();
        }

        
    })
});