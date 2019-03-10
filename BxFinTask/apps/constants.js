(function () {
	'use strict';

	angular.module('ll')
		.constant('llConstants', {
			'ARRAYCALC_SERV': '/api/arraycalc/',
			'growlTTL': 10000,
			'NOTFOUND_ERROR': 'Your requested resource could not be found or invalid! please try again later.',
			'REQUEST_ERROR': 'Unable to complete request at this time! please try again later. If problem persist contact administrator!'
		});

})();