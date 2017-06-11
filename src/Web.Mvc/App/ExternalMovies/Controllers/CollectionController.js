externalMoviesModule.controller("collectionController", function ($scope, $http, $q, $routeParams, $window, $location, controllerHelper) {
    $scope.controllerHelper = controllerHelper;

    var onLoadComplete = function (response) {
        $scope.isLoading = false;
        $scope.collection = response.data;
    }

    var onError = function (reason) {
        $scope.error = "Unable to complete the search";
        console.log(reason);
    }

    var initialize = function () {
        $scope.loadCollection($routeParams.collectionId);
    }

    $scope.partsTemplate = "/App/ExternalMovies/Views/Basic.html";

    $scope.loadCollection = function (collectionId) {
        $scope.collection = null;
        $scope.isLoading = true;

        $http.get(MyApp.rootPath + "api/external/movies/collections/" + collectionId)
            .then(onLoadComplete, onError);
    }

    initialize();
});