(function (app) {
    app.filter('StatusFilter', function () {
        return function (input) {
            if (input == true)
                return 'Kích hoạt';
            else
                return 'Khóa';
        }
    });
})(angular.module('tedushop.common'));