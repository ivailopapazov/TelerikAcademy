(function () {
	'use strict';
	require.config({
		paths: {
			'jquery': 'bower_components/jquery/dist/jquery',
			'print': 'print'
		}
	});

	require(['print'], function (printObj) {
		printObj.print('test from app');
	});
})();