App.controller('AccessRoleController', function($scope, $http, $location, $window,
                                                Notification, $modal, ShareData, AccessRoleService) {

    var service = AccessRoleService;
    var factory = ShareData;

    $scope.roleSelect = null;
    $scope.moduleSelect = null;
    $scope.permisosAsignados = []; /*Arreglo que guarda los permisos al hacer click en el checkbox*/
    $scope.permisosModulo = [];

    /*Array de Caracteristicas por Rol*/
    $scope.ArrayCaracteristicas = [];

    //Array de Derecho por Caracteristica
    $scope.ArrayDerechos = [];

    /*Arreglo que se enviara a guardar en la Base de Datos*/
    $scope.permisosRol = {
        RoleId: null,
        Permisos: []
    };

    $scope.Roles = [];
    
    $scope.AddDerechoPermiso = function ($event, caracteristica, derecho) {

        $scope.ArrayDerechos = [];

        for (var i = 0; i < $scope.Derechos.length; i++) {
            //debugger;
            $scope.objDerecho = {
                DerechoId: null,
                Status: false
            }

            $scope.objDerecho.DerechoId = $scope.Derechos[i].IdDerecho;

            var indOf = $scope.ArrayDerechos.map(function (e) { return e.DerechoId }).indexOf($scope.Derechos[i].IdDerecho);

            if (indOf == -1) {
                $scope.ArrayDerechos.push($scope.objDerecho);
                $scope.AddCaracteristica(caracteristica, derecho, $scope.ArrayDerechos, $event);
            } else {
                $scope.AddCaracteristica(caracteristica, derecho, $scope.ArrayDerechos, $event);
            }
        }
        
        //console.log($scope.ArrayDerechos);
        console.log("Caracteristicas --> ");
        console.log($scope.ArrayCaracteristicas);
    }

    $scope.AddCaracteristica = function (car, derecho, ArrayDerechos, $event) {
        var indOf = $scope.ArrayCaracteristicas.map(function (e) { return e.CaracteristicaId }).indexOf(car.IdCaracteristica);
        //debugger;
        if (indOf == -1) {
            $scope.permisosCaracteristica = {
                CaracteristicaId: null,
                Derechos: []
            };

            for (var i = 0; i < ArrayDerechos.length; i++) {
                
                if ($event.target.checked == true) {
                    if (ArrayDerechos[i].DerechoId == derecho.IdDerecho) {
                        ArrayDerechos[i].Status = true;
                    }
                } else {
                    if (ArrayDerechos[i].DerechoId == derecho.IdDerecho) {
                        ArrayDerechos[i].Status = false;
                    }
                }
            }

            $scope.permisosCaracteristica.CaracteristicaId = car.IdCaracteristica;
            $scope.permisosCaracteristica.Derechos.push(ArrayDerechos)
            $scope.ArrayCaracteristicas.push($scope.permisosCaracteristica);

        } else {
            var indOfDerecho = $scope.ArrayCaracteristicas[indOf].Derechos.map(function (e) { return e.DerechoId }).indexOf(derecho.IdDerecho);

            if (indOfDerecho == -1) {
                for (var i = 0; i < ArrayDerechos.length; i++) {
                    if ($event.target.checked == true) {
                        if (ArrayDerechos[i].DerechoId == derecho.IdDerecho) {
                            ArrayDerechos[i].Status = true;
                        }
                    } else {
                        if (ArrayDerechos[i].DerechoId == derecho.IdDerecho) {
                            ArrayDerechos[i].Status = false;
                        }
                    }
                }
            } else {
                //debugger;
                var objDerecho = $scope.ArrayCaracteristicas[indOf].Derechos[indOfDerecho];

                if($event.target.checked == true){
                    objDerecho.Status = true;
                }else if($event.target.checked == true && objDerecho.Status != true){
                    objDerecho.Status = false;
                }
            }

            $scope.ArrayCaracteristicas[indOf].Derechos = ArrayDerechos;
        }

        //console.log($scope.ArrayCaracteristicas);
    }

    $scope.createJson = function () {
        $scope.permisosRol = [
            {
                RoleId: $scope.roleSelect,
                Permisos: $scope.ArrayCaracteristicas
            }
        ]

        console.log($scope.permisosRol);
    }

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

        })

    

    $scope.getModulosRol = function (role) {
        for (var i = 0; i < $scope.Roles.length; i++) {
            
            if ($scope.Roles[i].IdRol == role) {
                $scope.Modulos = $scope.Roles[i].Modulos;
            }
        }

        for (var j = 0; j < $scope.Modulos.length ; j++) {
            $scope.getCaracteristicas($scope.Modulos[j].ModuloId);
        }
    }

    $scope.RoleAccesos = [];

    $scope.getCaracteristicas = function (moduleSelect) {
        for (var i = 0; i < $scope.Modulos.length ; i++) {
            if ($scope.Modulos[i].ModuloId == moduleSelect) {
                $scope.CaracteristicasModulo = $scope.Modulos[i].Caracteristicas;
            }
        }
    }

    //$scope.Caracteristicas = $scope.Modulos.Caracteristicas;

    //$scope.Derechos = $scope.Caracteristicas.Derechos;

    $scope.Caracteristicas = [
        { IdCaracteristica: 1, Nombre: "Caracteristica 1" },
        { IdCaracteristica: 2, Nombre: "Caracteristica 2" },
        { IdCaracteristica: 3, Nombre: "Caracteristica 3" },
        { IdCaracteristica: 4, Nombre: "Caracteristica 4" },
        { IdCaracteristica: 5, Nombre: "Caracteristica 5" },
        { IdCaracteristica: 6, Nombre: "Caracteristica 6" },
    ];

    
    
})