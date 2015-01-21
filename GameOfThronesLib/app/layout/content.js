(function () {
    'use strict';

    var controllerId = 'content'
    angular.module('gameofthroneslib').controller(controllerId, ['datacontext', content]);

    function content(datacontext) {
        var vm = this;
        vm.families = [];

        datacontext.getFamilies()
            .then(function (data) {
                vm.families = data;
                console.log(vm.families)

            }, function (error) {
                console.log(error);
            });
    };
})();