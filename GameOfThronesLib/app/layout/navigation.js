(function () {
    'use strict';

    var controllerId = 'content'
    angular.module('gameofthroneslib').controller(controllerId, ['$scope', '$location', function ($scope, $location) {
        $scope.navClass = function (page) {
            console.log("navClass");
        };
    }]);
})();