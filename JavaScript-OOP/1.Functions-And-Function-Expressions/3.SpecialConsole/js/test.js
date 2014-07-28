(function () {
	var inputMessage = document.getElementById('message'),
		inputFormatters = document.getElementById('formatters'),
		logButton = document.getElementById('log'),
		warnButton = document.getElementById('warn'),
		errorButton = document.getElementById('error');

	logButton.addEventListener('click', onLogButtonClick);
	warnButton.addEventListener('click', onWarnButtonClick);
	errorButton.addEventListener('click', onErrorButtonClick);


	function onLogButtonClick () {
		var args = getArguments();
		specialConsole.writeLine.apply(null, args);
	}

	function onWarnButtonClick () {
		var args = getArguments();
		specialConsole.writeWarning.apply(null, args);
	}

	function onErrorButtonClick () {
		var args = getArguments();
		specialConsole.writeError.apply(null, args);
	}

	function getArguments() {
		var args = [],
			formatters = [];

		formatters = inputFormatters.value.split(',').map(function (element) {
			return element.trim();
		});
		args.push(inputMessage.value);
		
		return args.concat(formatters);
	}
})();
