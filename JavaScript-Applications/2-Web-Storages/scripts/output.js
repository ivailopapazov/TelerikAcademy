define(['jquery'], function ($) {
	var $outputContainer = $('#solution-container');

	function writeLine (line) {
		var newParagraph = $('<p />');
		newParagraph.html(line);
		$outputContainer.append(newParagraph);
	}

	function clear () {
		$outputContainer.html('');
	}

	return {
		writeLine: writeLine,
		clear: clear
	};
});