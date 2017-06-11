externalMoviesModule.controller("rootController", function ($scope, $http, $q, $routeParams, $window, $location, controllerHelper) {
    $scope.importMovie = function (id) {
        controllerHelper.navigateTo("external-movies/import/" + id);
    }

    $scope.showCollection = function (id) {
        controllerHelper.navigateTo("external-movies/collection/" + id);
    }

    $scope.showMovie = function (id) {
        controllerHelper.navigateTo("external-movies/movie/" + id);
    }

    $scope.showPerson = function (id) {
        controllerHelper.navigateTo("external-movies/person/" + id);
    }

    $scope.showTvShow = function (id) {
        alert("This feature is currently in development. Check back soon! :)");
    }
});