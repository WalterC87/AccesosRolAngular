App.service('ProductoService', function ($http, $q) {
    var uri = '/api/Producto';

    this.getProductos = function () {
        var deferred = $q.defer();

        $http.get(uri)
        .success(function (response) {
            deferred.resolve(response);
        })

        return deferred.promise;
    }

    this.getProductoById = function (id) {
        var deferred = $q.defer();

        $http.get(uri + '/GetProducto/' + id)
        .success(function (response) {
            deferred.resolve(response);
        })

        return deferred.promise;
    }

    this.getProductosByCategory = function (categoryId) {
        var deferred = $q.defer();
        $http.get(uri + '/getbycategory/' + categoryId)
        .success(function (response) {
            deferred.resolve(response);
        })

        return deferred.promise;
    }
})