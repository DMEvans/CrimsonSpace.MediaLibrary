var externalMoviesModule = angular.module('externalMovies', ['common']);

externalMoviesModule.config(function ($routeProvider, $locationProvider) {
    $routeProvider.when("/external-movies/search", {
        templateUrl: "/App/ExternalMovies/Views/Search.html",
        controller: "searchController"
    });
    $routeProvider.when("/external-movies/movie/:movieId", {
        templateUrl: "/App/ExternalMovies/Views/Details.html",
        controller: "detailsController"
    });
    $routeProvider.when("/external-movies/credits/:movieId/:list", {
        templateUrl: "/App/ExternalMovies/Views/FullCredits.html",
        controller: "detailsController"
    });
    $routeProvider.when("/external-movies/collection/:collectionId", {
        templateUrl: "/App/ExternalMovies/Views/Collection.html",
        controller: "collectionController"
    });
    $routeProvider.when("/external-movies/person/:personId", {
        templateUrl: "/App/ExternalMovies/Views/Person.html",
        controller: "personController"
    });
    $routeProvider.when("/external-movies/import/:movieId", {
        templateUrl: "/App/ExternalMovies/Views/Import.html",
        controller: "importController"
    });
    $routeProvider.otherwise({
        redirectTo: "/external-movies/search"
    });
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
});