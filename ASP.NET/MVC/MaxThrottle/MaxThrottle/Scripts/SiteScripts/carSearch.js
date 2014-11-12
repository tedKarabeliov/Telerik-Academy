$(function () {
    $('#car-manufacturer').change(function (e) {
        var manufacturerId = $(this).val();

        httpRequester.get('/Cars/GetModels?manufacturerId=' + manufacturerId, function (carModels) {
            var carModelsSelect = $('#car-model');
            carModelsSelect.children().remove();
            var emptyOption = $("<option>-</option>").attr('value', '');
            carModelsSelect.append(emptyOption);

            for (var i in carModels) {
                carModelsSelect.append($('<option value="' + carModels[i].Id + '" >' + carModels[i].Name + '</option>'));
            }
        })
    });

    $('#car-model').change(function (e) {
        var carModelId = $(this).val();

        httpRequester.get('/Cars/GetEngines?carModelId=' + carModelId, function (engines) {
            var enginesSelect = $('#car-engine');
            enginesSelect.children().remove();
            var emptyOption = $("<option>-</option>").attr('value', '');
            enginesSelect.append(emptyOption);

            for (var i in engines) {
                enginesSelect.append($('<option value="' + engines[i].Id + '" >' + engines[i].Name + '</option>'));
            }
        })
    })
})