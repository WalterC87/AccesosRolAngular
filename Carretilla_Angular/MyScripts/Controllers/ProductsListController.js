App.controller('ProductsListController', function ($scope, $http, $location, $window,
                                                   ProductoService, CategoriaProductoService, Notification, $modal,
                                                   ShareData) {
    var service = ProductoService;
    var catProd = CategoriaProductoService;
    var factory = ShareData;

    service.getProductos().then(
        function (data) {
            $scope.productos = data;
        })

    catProd.getCategorias().then(
        function (data) {
            $scope.categorias = data;
        })


    $scope.ProductoDetalle = function (producto) {
        factory.value = producto.idProducto;
        $location.path('/DetalleProducto/' + producto.slug)
    };

    $scope.getProductoByCategory = function (categoria) {
        factory.value = categoria.idCategoriaProducto;
        $location.path('/Productos/' + categoria.Descripcion);
    }

    $scope.backUrl = function () {
        $window.history.back();
    }
    
})