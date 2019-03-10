(function () {
	'use strict';

	angular
		.module('ll', [
			'llArrayCalc',
			'llConstants',
			'llServices',
			'angular-growl'
		]);

	angular.module('llServices', []);
	angular.module('llConstants', []);
	angular.module('llDirectives', []);
	angular.module('llArrayCalc', []);

})();