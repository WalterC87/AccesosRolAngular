App.controller("ProductsCategoryController",function ($scope, $http, $location, $window,
                                                   ProductoService, CategoriaProductoService, Notification, $modal,
                                                   ShareData, $routeParams) {
    var service = ProductoService;
    var factory = ShareData;
    var idCategoria = factory.value;
    $scope.tituloCategoria = $routeParams.categoria;

    //console.log($routeParams);

    service.getProductosByCategory(idCategoria).then(
            function (data) {
                //console.log(data);
                $scope.productos = data;
            })
})