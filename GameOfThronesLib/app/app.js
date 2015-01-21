(function () {
    'use strict';

    var app = angular.module('gameofthroneslib', [
        'ngAnimate',
        'ngRoute',
    ]);

    app.run(['$route', function ($route) {
        // Include $route to kick start the router
    }]);
})();