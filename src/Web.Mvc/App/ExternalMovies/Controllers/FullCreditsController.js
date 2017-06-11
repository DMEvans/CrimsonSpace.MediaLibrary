externalMoviesModule.controller("fullCreditsController", function ($scope, $http, $q, $routeParams, $window, $location, controllerHelper) {
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
        $scope.castVisible = false;
        $scope.crewVisible = false;

        if ($routeParams.list == "cast") {
            $scope.castVisible = true;
            return;
        }
        else if ($routeParams.list == "crew") {
            $scope.crewVisible = true;
            return;
        }
    }

    var department = "All";

    $scope.headerTemplate = "/App/ExternalMovies/Views/DetailsHeader.html";

    $scope.loadDetails = function (movieId) {
        $scope.details = null;
        $scope.isLoading = true;

        $http.get(MyApp.rootPath + "api/external/movies/details/" + movieId + "/credits")
            .then(onLoadComplete, onError);
    }

    $scope.filterDepartments = function (group) {
        return (department == "All" || group.Department == department);
    }

    $scope.showCastList = function () {
        $scope.castVisible = true;
        $scope.crewVisible = false;
    }

    $scope.showCrewList = function () {
        $scope.castVisible = false;
        $scope.crewVisible = true;
    }

    $scope.setDepartmentFilter = function (departmentName) {
        department = departmentName;
        $scope.showCrewList();
    }

    initialize();
});