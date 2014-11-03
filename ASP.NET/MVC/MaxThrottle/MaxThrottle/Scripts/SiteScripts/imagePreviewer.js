function readURL(input) {

    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#preview-car-picture').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

$("#car-picture").change(function(){
    readURL(this);
});