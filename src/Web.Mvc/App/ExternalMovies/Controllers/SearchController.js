externalMoviesModule.controller("searchController", function ($scope, $http, $q, $routeParams, $window, $location, controllerHelper) {
    $scope.query = "";

    var onSearchComplete = function (response) {
        $scope.isLoading = false;
        $scope.searchResults = response.data;
    }

    var onError = function (reason) {
        $scope.isLoading = false;
        $scope.error = "Unable to complete the search";
        console.log(reason);
    }

    $scope.resultTemplate = "/App/ExternalMovies/Views/Basic.html";

    $scope.searchMovies = function () {
        $scope.searchResults = null;
        $scope.error = null;
        $scope.isLoading = true;

        $http.get(MyApp.rootPath + "api/external/movies/search?query=" + $scope.query)
            .then(onSearchComplete, onError);
    }
});