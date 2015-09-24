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

})