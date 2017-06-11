var importMovieSearchController = function ($scope, $http) {
    $scope.query = "";

    var onSearchComplete = function (response) {
        $scope.isLoading = false;
        $scope.searchResults = response.data;
    }

    var onError = function (reason) {
        $scope.error = "Unable to complete the search";
        console.log(reason);
    }

    $scope.searchMovies = function () {
        $scope.searchResults = null;
        $scope.isLoading = true;

        $http.get("http://localhost:59628/api/import/movies?query=" + $scope.query)
            .then(onSearchComplete, onError);
    }
}