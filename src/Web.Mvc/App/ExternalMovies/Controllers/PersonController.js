externalMoviesModule.controller("personController", function ($scope, $http, $q, $routeParams, $window, $location, controllerHelper) {
    $scope.controllerHelper = controllerHelper;

    var onLoadComplete = function (response) {
        $scope.isLoading = false;
        $scope.person = response.data;
    }

    var onError = function (reason) {
        $scope.error = "Unable to complete the search";
        console.log(reason);
    }

    var initialize = function () {
        $scope.loadPerson($routeParams.personId);
    }

    $scope.showTabs = function () {
        var count = 0;
        count += $scope.person.HasImages ? 1 : 0;
        count += $scope.person.HasCastCredits ? 1 : 0;
        count += $scope.person.HasCrewCredits ? 1 : 0;

        return count > 1;
    };

    $scope.loadPerson = function (personId) {
        $scope.movieId = personId;
        $scope.person = null;
        $scope.isLoading = true;

        $http.get(MyApp.rootPath + "api/external/movies/person/" + personId)
            .then(onLoadComplete, onError);
    }

    $scope.creditYear = function (credit) {
        if (credit.FirstAirYear) {
            return credit.FirstAirYear;
        }
        else if (credit.ReleaseYear) {
            return credit.ReleaseYear;
        }

        return 0;
    }

    initialize();
});