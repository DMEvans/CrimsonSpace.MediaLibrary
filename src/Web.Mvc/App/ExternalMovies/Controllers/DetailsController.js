externalMoviesModule.controller("detailsController", function ($scope, $http, $q, $routeParams, $window, $location, controllerHelper) {
    $scope.controllerHelper = controllerHelper;

    var onLoadComplete = function (response) {
        $scope.isLoading = false;
        $scope.details = response.data;
    }

    var onError = function (reason) {
        $scope.error = "Unable to complete the search";
        console.log(reason);
    }

    var initialize = function () {
        $scope.loadDetails($routeParams.movieId);
    }

    $scope.headerTemplate = "/App/ExternalMovies/Views/DetailsHeader.html";

    $scope.loadDetails = function (movieId) {
        $scope.movieId = movieId;
        $scope.details = null;
        $scope.isLoading = true;

        $http.get(MyApp.rootPath + "api/external/movies/details/" + movieId)
            .then(onLoadComplete, onError);
    }

    $scope.showCreditsUrl = "external-movies/credits/" + $scope.movieId;

    $scope.showCastCredits = function () {
        controllerHelper.navigateTo($scope.showCreditsUrl + "/cast");
    }

    $scope.showCrewCredits = function () {
        controllerHelper.navigateTo($scope.showCreditsUrl + "/crew");
    }

    initialize();
});