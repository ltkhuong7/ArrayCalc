(function () {
	'use strict';

	angular.module('llServices')
		.service('llArrayCalcService', llArrayCalcService);

	llArrayCalcService.$inject = ['$http', 'llConstants'];

	function llArrayCalcService($http, llConstants) {
		this.reverse = reverse;
		this.deletepart = deletepart;

		function reverse(paramOption) {
			return $http.get(llConstants.ARRAYCALC_SERV + 'reverse', { params: paramOption });
		}

		function deletepart(paramOption) {
			return $http.get(llConstants.ARRAYCALC_SERV + 'deletepart', { params: paramOption });
		}
	}
})();