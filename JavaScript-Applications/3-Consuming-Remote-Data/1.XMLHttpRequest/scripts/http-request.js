define(['jquery'], function ($) {


	function createHttpRequest(method, url, options) {
		var httpRequest,
			header;

		httpRequest = new XMLHttpRequest();
		httpRequest.open(method, url, true);

		for (header in options) {
			httpRequest.setRequestHeader(header, options[header]);
		}

		return httpRequest;
	}

	function getJSON (url, options) {
		var deferred,
			httpGetRequest;

		httpGetRequest = createHttpRequest('GET', url, options);
		httpGetRequest.send(null);

		deferred = $.Deferred();
		
		httpGetRequest.addEventListener('readystatechange', function () {
			var statusGroup,
				jsonResponse;

			if (this.readyState !== 4) {
				return;
			}

			statusGroup = Math.floor(this.status / 100);
			if (statusGroup === 2) {
				jsonResponse = JSON.parse(this.responseText);
				deferred.resolve(jsonResponse);
			}
			else {
				deferred.reject('Unsuccessful HTTP GET Request! Error: ' + this.statusText);
			}
		});

		return deferred.promise()
	}

	function postJSON (url, options, postJsonData) {
		var deferred,
			httpPostRequest,
			postStringData;

		postStringData = JSON.stringify(postJsonData);
		httpPostRequest = createHttpRequest('POST', url, options);
		httpPostRequest.send(postStringData);

		deferred = $.Deferred();
		httpPostRequest.addEventListener('readystatechange', function () {
			var statusGroup;

			if (this.readyState !== 4) {
				return;
			}

			statusGroup = Math.floor(this.status / 100);
			if (statusGroup === 2) {
				deferred.resolve('Successfuly posted JSON data.');
			}
			else {
				deferred.reject('Unsuccessful HTTP POST Request! Error: ' + this.statusText);
			}
		});

		return deferred.promise();
	}

	return {
		getJSON: getJSON,
		postJSON: postJSON
	};
});