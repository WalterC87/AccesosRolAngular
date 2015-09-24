App.service('CategoriaProductoService', function ($http, $q) {
    var uri = '/api/CategoriaProducto';

    this.getCategorias = function () {
        var deferred = $q.defer();

        $http.get(uri)
        .success(function (response) {
            deferred.resolve(response);
        })

        return deferred.promise;
    }

    this.getCategoriaById = function (id) {
        var deferred = $q.defer();

        $http.get(uri + '/' + id)
        .success(function (response) {
            deferred.resolve(response);
        })

        return deferred.promise;
    }
})