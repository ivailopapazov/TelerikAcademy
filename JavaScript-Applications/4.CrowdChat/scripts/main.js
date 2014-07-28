require.config({
	paths: {
		"jquery": "bower_components/jquery/dist/jquery",
		"sammy": "bower_components/sammy/lib/sammy",
		"handlebars": "bower_components/handlebars/handlebars",
		"httpRequester": "http-requester",
		"data": "data",
		"controllers": "controllers",
		"view": "view"
	}
});

require(["jquery", "sammy", "controllers", "data", "httpRequester"], function ($, sammy, controllers, data, httpRequester) {
	var mainController = controllers.getMainController('#content'),
		$messageInputElement = $('#message'),
		$sendMessageButton = $('#send-message');
	// var accessController = controllers.getAccessController('#content');
	
	var app = sammy('#content', function () {
		this.get("#/", function () {
			mainController.execute();
		});

		this.get("#/login", function () {
			// accessController.execute();
		});
	});

	app.run("#/");

	$sendMessageButton.on('click', function () {
		var message = $messageInputElement.val(),
			username;

		if (!data.user.isLogged()) {
			username = prompt('Enter your name!');
			data.user.setName(username);
		}
		else {
			username = data.user.getName();
		}

		data.post.send(username, message)
			.done(function () {
				mainController.execute();
			});
	});
});