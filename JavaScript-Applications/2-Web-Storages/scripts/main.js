require.config({
	paths: {
		'jquery': 'bower_components/jquery/dist/jquery',
		'game': 'game',
		'output': 'output',
	}
});

require(['jquery', 'game', 'output'], function ($, Game, output) {
	var $userInputButton = $('#send-input'),
		$userInputField = $('#user-input'),
		$newGameButton = $('#new-game'),
		$highScoreButton = $('#high-score'),
		newGame;

		newGame = new Game();
		newGame.start();

	$userInputButton.on('click', function () {
		var userInputValue = $userInputField.val(),
			result;

		try {
			result = newGame.checkNumber(userInputValue);		
		}
		catch (ex) {
			output.writeLine('Invalid user input!');
		}

		if (result.rams === 4) {
			var userName = prompt('You Win! Enter your name:')
			localStorage.setItem(userName, newGame.getGuessCount());
			return;
		}

		output.writeLine('Result: Rams = ' + result.rams + ' Sheeps = ' + result.sheeps);
		output.writeLine('Enter your next number!');
	});

	$newGameButton.on('click', function () {
		output.clear();
		newGame = new Game();
		newGame.start();

	});

	$highScoreButton.on('click', function () {
		output.writeLine('Winners:');
		for (name in localStorage) {
			output.writeLine(name + ' - ' + localStorage[name]);
		}
	});
});