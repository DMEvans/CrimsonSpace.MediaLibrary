var commonModule = angular.module('common', ['ngRoute']);
var mainModule = angular.module('main', ['common']);

commonModule.factory('controllerHelper',
    function ($location, $window) {
        return MyApp.controllerHelper($location);
    }
);

(function (myApp) {
    var controllerHelper = function ($location, $window) {
        var self = this;

        self.navigateTo = function (path, params) {
            if (params == null)
                $location.path(MyApp.rootPath + path);
            else
                $location.path(MyApp.rootPath + path).search(params);
        }

        return this;
    };

    myApp.controllerHelper = controllerHelper;
}(window.MyApp));