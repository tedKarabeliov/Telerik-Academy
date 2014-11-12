var httpRequester = (function () {
    var get = function (url, callback) {
        $.get(url, callback)
    }

    return {
        get: get
    }
}());