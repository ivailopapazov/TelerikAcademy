var specialConsole = (function () {

	function writeLine() {
		writeConsole(arguments, 'log');
	}

	function writeError() {
		writeConsole(arguments, 'error');
	}

	function writeWarning() {
		writeConsole(arguments, 'warn');
	}

	function writeConsole(argsObj, logFunction) {
		var args = Array.prototype.slice.apply(argsObj).map(String),
			text = '';

		if (args[0]) {
			text = args[0];
		}

		if (args.length > 1) {
			text = formatString(text, args.slice(1));
		}

		switch (logFunction) {
			case 'log':
				console.log(text);
				break;
			case 'error':
				console.error(text);
				break;
			case 'warn':
				console.warn(text);
				break;
		}
	}

	function formatString(string, formatters) {
		var result = string;

		for (var i = 0; i < formatters.length; i++) {
			result = parseString(result, '{' + i +'}', formatters[i]);
		}

		return result;
	}

	function parseString(string, placeholder, formatter) {
		var result = string,
			index = string.indexOf(placeholder);

		while (index > -1) {
			result = result.replace(placeholder, formatter, index++);
			index = string.indexOf(placeholder, index);
		}

		return result;
	}

	return {
		writeLine: writeLine,
		writeError: writeError,
		writeWarning: writeWarning,
	}
})();
