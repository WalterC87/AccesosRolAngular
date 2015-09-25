App.controller('AccessRoleController', function($scope, $http, $location, $window,
                                                Notification, $modal, ShareData, AccessRoleService) {

    var service = AccessRoleService;
    var factory = ShareData;

    $scope.roleSelect = null;
    $scope.roleSelectName = "";
    $scope.Modulos = [];
    $scope.Roles = [];
    $scope.message = "";

    service.GetAccesosRol().then(
        function (data) {

            for (var i = 0; i < data.length; i++) {
                $scope.Rol = {
                    IdRol: data[i].RolId,
                    Nombre: data[i].Name,
                    Modulos: data[i].Modulos,
                    Derechos: data[i].Derechos
                };
                $scope.Roles.push($scope.Rol);
            }

        }
    );
    
    $scope.AddDerechoPermiso = function ($event, modulo, caracteristica, derecho) {
        for (var i = 0; i < $scope.Modulos.length; i++) {
            if ($scope.Modulos[i].ModuloId == modulo.ModuloId) {
                var carmod = $scope.Modulos[i].Caracteristicas;
                var indexCar = carmod.map(function (e) { return e.CaracteristicaId }).indexOf(caracteristica.CaracteristicaId);

                var dereCar = carmod[indexCar].Derechos;
                var indexDere = dereCar.map(function (e) { return e.DerechoId }).indexOf(derecho.DerechoId);

                if ($event.target.checked == true) {
                    dereCar[indexDere].Status = true;
                } else {
                    dereCar[indexDere].Status = false;
                }
            }
        }

    }

    $scope.createJson = function () {
        
        $scope.permisosRol = [
            {
                RolId: $scope.roleSelect,
                Name: $scope.roleSelectName,
                Modulos: $scope.Modulos,
                Derechos: []
            }
        ]

        $scope.postPermisosRol($scope.permisosRol);
    }

    $scope.postPermisosRol = function (permisosRol) {
        service.PostAccesosRol(permisosRol).then(
            function (data) {
                blockUI.start("saving data");

                blockUI.done(function () {
                    if (response == true) {
                        $scope.textoMensaje = 'Registro Almacenado exitosamente';
                        Notification.success({ message: $scope.textoMensaje, delay: 2000 });
                        $scope.opSuccess = true;
                    } else {
                        $scope.opSuccess = false;
                        $scope.textoMensaje = 'Oops hubo un problema al guardar el registro...';
                        Notification.error({ message: $scope.textoMensaje, delay: 2000 });
                    }
                });

                setTimeout(function () {
                    blockUI.stop();
                }, 1000);
            }
        )
    }

    $scope.getModulosRol = function (role) {
        for (var i = 0; i < $scope.Roles.length; i++) {
            
            if ($scope.Roles[i].IdRol == role) {
                $scope.roleSelectName = $scope.Roles[i].Nombre;
                $scope.Modulos = $scope.Roles[i].Modulos;
            }
        }
    }

})