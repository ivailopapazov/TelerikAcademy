require.config({
	paths: {
		"jquery": "bower_components/jquery/dist/jquery",
		"request": "http-request",
	}
});

require(['jquery', 'request'], function ($, httpRequest) {
	var url = "http://localhost:3000/students",
		headers = {
			"Content-Type": "application/json",
			"Accept": "application/json"
		};

	httpRequest.postJSON(url, headers, { name: 'Gosho'})
		.then(function (result) {
			// console.log(result);
		},
		function (msg) {
			// console.log(msg);
		});
	httpRequest.getJSON(url, headers)
		.then(function (result) {
			// console.log(result);
		}, function (msg) {
			// console.log(msg);
		});
});