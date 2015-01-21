(function () {
    'use strict';

    var controllerId = 'pagemetadata'
    angular.module('gameofthroneslib').controller(controllerId, ['datacontext', pagemetadata]);

    function pagemetadata(datacontext) {
        var vm = this;

        vm.pageheader = datacontext.getPageHeader();
        vm.pagefooter = datacontext.getPageFooter();
    };
})();