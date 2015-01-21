(function () {
    'use strict';

    var serviceId = 'datacontext';
    angular.module('gameofthroneslib').factory(serviceId, ['$http', function ($http) {
        var service = {
            getPageHeader: getPageHeader,
            getPageFooter: getPageFooter,
            getFamilies: getFamilies
        };

        return service;

        function getPageHeader() {
            return {
                header: 'GoT - Library',
                subheader: 'Een angularJS bibliotheek van de tv-hitserie Game Of Thrones'
            };
        }

        function getPageFooter() {
            return { footer: '© Copyright 2014 MarkSchreijer' };
        };

        function getFamilies() {
            return $http.get('/api/Family/FindFamilies')
                .then(function (response) {
                    return response.data;
                }, function (response) {
                    return "error";
                });
        }
    }]);
})();