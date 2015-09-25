App.service('AccessRoleService', function ($http, $q) {
    var uri = '/api/AccessRole';

    this.GetAccesosRol = function () {
        var deferred = $q.defer();

        $http.get(uri + '/GetAccesosRol/')
        .success(function(response){
            deferred.resolve(response);
        })

        return deferred.promise;
    }

    this.PostAccesosRol = function (AccesosRol) {
        var deferred = $q.defer();
        var res = $http.post(uri + '/PostAccesosRol/', AccesosRol)
        res.success(function (data, status, headers, config) {
            deferred.resolve(data);
        })
        res.error(function (data, status, header, config) {
            deferred.resolve(JSON.stringify({ error: data }));
        })

        return deferred.promise;
    }

})