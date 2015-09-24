var App = angular.module('CarretillaApp', ['ngRoute', 'ngAnimate',
                                    'ui.bootstrap', 'smart-table', 'ui-notification',
                                    'blockUI']);

App.factory('ShareData', function () {
    return { value: 0 };
})

App.config(['$routeProvider','$locationProvider', function ($routeProvider,$locationProvider) {
    $routeProvider.when("/", {
        templateUrl: "Home/AccessRole",
        controller: "AccessRoleController"
    })

    //}).when("/newBook", {
    //    templateUrl: "Home/NewBook",
    //    controller: "AddBookController"

    //}).when("/DetalleProducto/:slug", {
    //    templateUrl: "Home/ProductDetails",
    //    controller: "ProductsDetailsController"

    //}).when("/Productos/:categoria", {
    //    templateUrl: "Home/ProductsCategory",
    //    controller: "ProductsCategoryController"
    //})

}]);