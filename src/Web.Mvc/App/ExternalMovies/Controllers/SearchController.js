externalMoviesModule.controller("searchController", function ($scope, $http, $q, $routeParams, $window, $location, controllerHelper) {
    var numberOfPagesInView = 5;

    var configurePagination = function () {
        $scope.pages = []

        var totalPages = $scope.searchResults.TotalPages;
        var pageIndex = $scope.pageIndex;
        var pagesToDraw = Math.min(totalPages, numberOfPagesInView);
        var midPoint = Math.floor(numberOfPagesInView / 2);
        var startPage = 1;
        var endPage = pagesToDraw;

        if (pageIndex > midPoint) {
            startPage = (pageIndex - midPoint + 1);
            endPage = (startPage + pagesToDraw - 1) > totalPages ? totalPages : (startPage + pagesToDraw - 1);
        }

        for (var i = startPage; i <= endPage; i++) {
            $scope.pages.push(i);
        }

        $scope.showFirstPageButton = startPage != 1;
        $scope.showLastPageButton = totalPages > numberOfPagesInView;
        $scope.showPreviousSetPageButton = startPage !== 1;
        $scope.showNextSetPageButton = endPage !== totalPages;

        $scope.lastPage = totalPages;
        $scope.previousPageSetIndex = startPage + numberOfPagesInView;
        $scope.nextPageSetIndex = startPage + numberOfPagesInView;

        if ($scope.previousPageSetIndex < 1) {
            $scope.previousPageSetIndex = 1;
        }

        if ($scope.nextPageSetIndex > totalPages) {
            $scope.nextPageSetIndex = totalPages;
        }
    }

    var onSearchComplete = function (response) {
        $scope.isLoading = false;
        $scope.searchResults = response.data;
        $scope.totalResults = $scope.searchResults.TotalResults;

        configurePagination();
    }

    var onError = function (reason) {
        $scope.isLoading = false;
        $scope.error = "Unable to complete the search";
        console.log(reason);
    }

    $scope.query = "";
    $scope.pageIndex = 1;
    $scope.pages = [];
    $scope.resultTemplate = "/App/ExternalMovies/Views/Basic.html";
    $scope.queryUrl = "";

    $scope.goToPage = function (pageIndex) {
        $scope.pageIndex = pageIndex;
        $scope.searchMovies();
    }

    $scope.newMovieSearch = function () {
        $scope.pageIndex = 1;
        $scope.queryUrl = MyApp.rootPath + "api/external/movies/search?query=" + $scope.query;

        $scope.searchMovies();
    }

    $scope.searchMovies = function () {
        $scope.searchResults = null;
        $scope.error = null;
        $scope.isLoading = true;

        $http.get($scope.queryUrl + "&page=" + $scope.pageIndex)
            .then(onSearchComplete, onError);
    }
});