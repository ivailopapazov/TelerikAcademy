define(['jquery'], function ($) {
	function makeHttpRequest (url, type, data) {
		var deferred = $.Deferred(),
			sendData = data || undefined;
//'Access-Control-Allow-Origin: *'

		$.ajax({
			url: url,
			type: type,
			timeout: 5000,
			"Content-Type": "application/json",
			data: sendData,
			success: function (result) {
				deferred.resolve(result);
			},
			error: function (error) {
				deferred.reject(error);
			}
		});

		return deferred.promise();
	}

	function makeHttpGetRequest (url) {
		return makeHttpRequest(url, 'get');
	}

	function makeHttpPostRequest (url, data) {
		return makeHttpRequest(url, 'post', data);
	}

	return {
		getJson: makeHttpGetRequest,
		postJson: makeHttpPostRequest
	};
});