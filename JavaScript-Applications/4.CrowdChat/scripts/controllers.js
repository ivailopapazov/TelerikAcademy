define(['jquery', 'data', 'view'], function ($, data, view) {

	var MainController = (function () {
		function MainController (containerSelector) {
			this.containerSelector = containerSelector;
			this.container = $(containerSelector);
		}

		MainController.prototype = {
			execute: function () {
				var that = this;

				// Clear container
				this.clearContainer();

				// Get data
				data.post.getAll()
					.then(function (result) {
						// Pass to view		
						view.loadChatWindow(that.containerSelector, result);
					},
					function (errorData) {
						console.log('error');
					});
			},
			clearContainer: function () {
				this.container.empty();
			}

		};

		return MainController;
	})();

	var AccessController = (function (containerSelector) {
		function AccessController () {
			this.container = $(containerSelector);
		}

		AccessController.prototype = {
			execute: function () {

			}
		};

		return AccessController;
	})();

	return {
		getMainController: function (containerSelector) { return new MainController(containerSelector); },
		getAccessController: function (containerSelector) { return new AccessController(containerSelector); }
	};
});