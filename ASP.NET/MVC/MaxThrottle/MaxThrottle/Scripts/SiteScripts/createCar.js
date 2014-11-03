$(function () {
    $('#car-manufacturer').change(function (e) {
        var manufacturerId = $(this).val();

        $.get('/Cars/GetModels?manufacturerId=' + manufacturerId, function (carModels) {
            var carModelsSelect = $('#car-model');

            carModelsSelect.children().remove();
            carModelsSelect.append('<option>-');

            for (var i in carModels) {
                carModelsSelect.append($('<option value="' + carModels[i].Id + '" >' + carModels[i].Name + '</option>'));
            }
        })
    });

    $('#car-model').change(function (e) {
        var carModelId = $(this).val();

        $.get('/Cars/GetEngines?carModelId=' + carModelId, function (engines) {
            var enginesSelect = $('#car-engine');
            enginesSelect.children().remove();
            enginesSelect.append('<option>-');

            for (var i in engines) {
                enginesSelect.append($('<option value="' + engines[i].Id + '" >' + engines[i].Name + '</option>'));
            }
        })
    })
})