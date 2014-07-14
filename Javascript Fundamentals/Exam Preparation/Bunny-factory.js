function Solve(args) {

    String.prototype.replaceAll = function (searchValue, replaceValue) {
        return this.split(searchValue).join(replaceValue);
    }

    function takeSum(index) {
        var sum = 0;
        for (var i = 0; i <= index; i++) {
            sum += arr[i];
        }
        return sum;
    }

    function calculateNextCages(sum, index) {

        if (arr.length - (index + 1) < sum) {
            // STOP!!
            return;
        }

        var cagesSum = 0;
        var cagesProduct = 1;

        var i = index + 1
        for (var count = 0; count < sum; i++, count++) {
            cagesSum += arr[i];
            cagesProduct *= arr[i];
        }
        return [cagesSum, cagesProduct, i];
    }

    function appendCages(sumProduct) {
        var str = sumProduct[0].toString() + sumProduct[1].toString();
        for (var i = sumProduct[2]; i < arr.length; i++) {
            str += arr[i].toString();
        }
        return str;
    }

    function RemoveZerosOnes(newArrStr) {
        newArrStr = newArrStr.replaceAll('0', '');
        newArrStr = newArrStr.replaceAll('1', '');
        return newArrStr.split('');
    }

    var arr = args.map(Number);
    for (var i = 0; ; i++) {
        if (arr.length < i) {
            return arr;
        }
        var sum = takeSum(i);
        var sumProduct = calculateNextCages(sum, i);
        if (!sumProduct) {
            return arr;
        }
        var newArrStr = appendCages(sumProduct);
        var arr = RemoveZerosOnes(newArrStr);
        arr = arr.map(Number);
    }
}

//var args = ['4', '1', '2', '5', '6', '7', '9'];
var args = [72, 7, 28, 21, 3, 92, 20, 45, 77, 42, 39, 85, 81, 80, 20, 66, 19, 31, 40, 6, 53, 97, 85, 76, 17, 38, 32, 48, 43, 84, 40, 11, 59, 4, 60, 69, 68, 7, 82, 75, 82, 37, 70, 22, 65, 33, 64, 31, 83, 71, 42, 71, 12, 5, 19, 75, 22, 52, 6, 64, 62, 72, 4, 92, 4, 30, 27, 78, 22, 51, 97, 13, 49, 64, 23, 17, 29, 65, 12, 84, 74, 2, 65, 71, 44, 68, 99, 55, 85, 84, 49, 18, 3, 19, 14, 12, 35, 77, 19, 36];
args = args.map(String);
console.log(Solve(args));

