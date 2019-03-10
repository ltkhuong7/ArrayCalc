(function () {
	'use strict';

	angular.module('ll')
		.config(['growlProvider', function (growlProvider) {
			growlProvider.globalDisableCountDown(true);
			growlProvider.onlyUniqueMessages(true);
		}]);

})();