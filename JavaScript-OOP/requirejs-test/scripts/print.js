define(['jquery'], function ($) {
	var print = function (input) {
		$("#test").append(input);
	};

	return {
		print: print
	};
});