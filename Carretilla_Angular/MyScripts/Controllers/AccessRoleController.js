App.controller('AccessRoleController', function($scope, $http, $location, $window,
                                                Notification, $modal, ShareData, AccessRoleService, Notification, blockUI) {

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
                    $scope.setCaracteristicaOtroModulo($event, caracteristica, derecho);
                } else {
                    dereCar[indexDere].Status = false;
                    $scope.setCaracteristicaOtroModulo($event, caracteristica, derecho);
                }
            }
        }

    }

    $scope.setCaracteristicaOtroModulo = function ($event, caracteristica, derecho) {
        for (var i = 0; i < $scope.Modulos.length; i++) {
            var caracteristicas = $scope.Modulos[i].Caracteristicas;
            for (var j = 0; j < caracteristicas.length; j++) {
                var derechos = caracteristicas[j].Derechos;
                if(caracteristicas[j].CaracteristicaId == caracteristica.CaracteristicaId){
                    for(var d = 0; d < caracteristicas[j].Derechos.length; d++){
                        if(derechos[d].DerechoId == derecho.DerechoId){
                            if($event.target.checked == true){
                                derechos[d].Status = true;
                            }else{
                                derechos[d].Status = false;
                            }
                        }
                    }
                }

            }

        }
    }

    $scope.postPermisosRol = function () {
        $scope.permisosRol = [
            {
                RolId: $scope.roleSelect,
                Name: $scope.roleSelectName,
                Modulos: $scope.Modulos,
                Derechos: []
            }
        ]

        service.PostAccesosRol($scope.permisosRol).then(
            function (response) {
                blockUI.start("Guardando Accesos ...");
                //console.log(response);
                blockUI.done(function () {
                    if (response != null) {
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