externalMoviesModule.controller("importController", function ($scope, $http, $q, $routeParams, $window, $location, controllerHelper) {
    $scope.controllerHelper = controllerHelper;

    var onImportComplete = function (response) {
        alert("tada!");
        $scope.isLoading = true;
    }

    var onImportError = function (response) {
        $scope.error = "Unable to import the movie";
        console.log(reason);
    }

    var onLoadComplete = function (response) {
        $scope.isLoading = false;
        $scope.importDetails = response.data;
    }

    var onLoadError = function (reason) {
        $scope.error = "Unable to load the data";
        console.log(reason);
    }

    var initialize = function () {
        $scope.loadDetails($routeParams.movieId);
    }

    $scope.loadDetails = function (movieId) {
        $scope.movieId = movieId;
        $scope.details = null;
        $scope.isLoading = true;

        $http.get(MyApp.rootPath + "api/external/movies/import/" + movieId)
            .then(onLoadComplete, onLoadError);
    }

    $scope.import = function () {
        $scope.isLoading = true;

        var details = {};
        details.IncludeBackdropImage = $scope.includeBackdropImage;
        details.IncludePosterImage = $scope.includePosterImage;
        details.TmdbId = $scope.importDetails.Id;

        $http.post(MyApp.rootPath + "api/external/movies/import/", details).then(onImportComplete, onImportError);
    }

    $scope.removeGenre = function (genreId) {
        var indexToRemove = null;

        for (var i = 0; i < $scope.importDetails.Genres.length; i++) {
            if ($scope.importDetails.Genres[i].Id === genreId) {
                indexToRemove = i;
            }
        }

        if (indexToRemove) {
            return;
        }

        $scope.importDetails.Genres.splice(indexToRemove, 1);
    }

    initialize();
});