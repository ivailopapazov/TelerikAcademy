define(['jquery', 'httpRequester', 'handlebars'], function ($, httpRequester) {
	function loadChatWindow(selector, data) {
		var $container = $(selector);

		httpRequester.getJson('templates/chat-window.html')
			.then(function (resultHtml) {
				var template = Handlebars.compile(resultHtml),
					compiledHtml = template(data);
				$container.html(compiledHtml);
			});

	}

	return {
		loadChatWindow: loadChatWindow
	};
});