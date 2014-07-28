define(['httpRequester'], function (httpRequester) {
	var url = 'http://crowd-chat.herokuapp.com/posts';

	var post = (function () {
		function getAllPosts() {
			return httpRequester.getJson(url);
		}

		function sendPost(username, message) {
			var postData = {
				"user": username,
				"text": message
			};

			return httpRequester.postJson(url, postData);
		}

		return {
			getAll: getAllPosts,
			send: sendPost
		};
	})();

	var user = (function () {

		function setName(name) {
			sessionStorage.setItem("name", name);
		}

		function getName() {
			return sessionStorage.getItem('name');
		}

		function isLogged() {
			if (getName())
			{
				return true;
			}

			return false;
		}

		return {
			isLogged: isLogged,
			setName: setName,
			getName: getName
		};
	})();


	return {
		post: post,
		user: user
	};
});