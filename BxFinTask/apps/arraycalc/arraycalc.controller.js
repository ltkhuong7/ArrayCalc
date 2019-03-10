(function () {
	'use strict';

	angular.module('llArrayCalc')
		.controller('llArrayCalcController', llArrayCalcController);

	llArrayCalcController.$inject = ['$rootScope', '$scope', 'growl', 'llArrayCalcService', 'llConstants'];

	function llArrayCalcController($rootScope, $scope, growl, llArrayCalcService, llConstants) {
		var vm = this;
		//public methods
		vm.reverse = reverse;
		vm.deletepart = deletepart;
		vm.reset = reset;
		vm.add = add;
		//variables
		vm.loading = false;
		vm.actionType = {
			reverse: true
		};
		vm.arrayInput = [];
		vm.arrayCalcResult = [];
		vm.value = null;

		function reverse() {
			vm.loading = true;
			var paramOption = {
				ProductIds: vm.arrayInput
			};
			llArrayCalcService.reverse(paramOption).then(function (result) {
				vm.arrayCalcResult = result.data;
				vm.loading = false;
			}).catch(function (result) {
				vm.loading = false;
				var message = "Error occur!";
				if (result.status === 404) {
					message = llConstants.NOTFOUND_ERROR;
				}
				else if (result.status === 500) {
					message = result.data.ExceptionMessage;
				}
				else if (result.status > 500 && result.status < 600) {
					message = llConstants.REQUEST_ERROR;
				}
				growl.error(message, { title: 'Error', ttl: llConstants.growlTTL });
			});
		}

		function deletepart() {
			vm.loading = true;
			var paramOption = {
				ProductIds: vm.arrayInput,
				Position: vm.position
			};
			llArrayCalcService.deletepart(paramOption).then(function (result) {
				vm.arrayCalcResult = result.data;
				vm.loading = false;
			}).catch(function (result) {
				vm.loading = false;
				var message = "Error occur!";
				if (result.status === 404) {
					message = llConstants.NOTFOUND_ERROR;
				}
				else if (result.status === 500) {
					message = result.data.ExceptionMessage;
				}
				else if (result.status >= 500 && result.status < 600) {
					message = llConstants.REQUEST_ERROR;
				}
				growl.error(message, { title: 'Error', ttl: llConstants.growlTTL });
			});
		}

		function add(value) {
			vm.arrayInput.push(value);
			vm.value = null;
		}

		function reset() {
			vm.arrayInput = [];
			vm.arrayCalcResult = [];
			vm.value = null;
			vm.position = null;
			vm.actionType.reverse = true;
		}
	}

})();