define(['jquery'], function ($) {
	function makeHttpRequest(url, type, data){
		var deferred = $.Deferred(),
			sendData = data || undefined;

		$.ajax({
			url: url,
			type: type,
			"Content-Type": "application/json",
			data: sendData,
			success: function (result) {
				deferred.resolve(result);
			},
			error: function (data) {
				deferred.reject(data);
			}
		});

		return deferred.promise();
	}

	function httpGetRequest (url) {
		return makeHttpRequest(url, 'get');
	}

	function httpPostRequest (url, data) {
		return makeHttpRequest(url, 'post', data);
		// return $.post(url, data);
	}

	return {
		get: httpGetRequest,
		post: httpPostRequest
	};
});	