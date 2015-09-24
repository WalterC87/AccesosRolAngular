App.controller('ProductsDetailsController', function ($scope, $http, $location, $window,
                                                   ProductoService, Notification, $modal,
                                                   ShareData) {
    var service = ProductoService;
    var factory = ShareData;
    var idProducto = factory.value;

    service.getProductoById(idProducto).then(
        function (data) {
            $scope.producto = {
                idProducto : data.idProducto,
                Descripcion : data.Descripcion,
                PrecioQuetzales : data.PrecioQuetzales,
                PrecioDolares : data.PrecioDolares,
                enPromocion : data.enPromocion,
                categoriaProducto: data.categoriaProducto,
                slug : data.slug
            }
        })
})