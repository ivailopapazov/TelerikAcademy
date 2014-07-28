define(['output'], function (output) {
	'use strict'
	var Game = (function () {
		var gameId = 1;

		function Game () {
			this._id = gameId++;
			this._gameNumber = [];
			this._guessCount = 0;
		}

		Game.prototype = {
			start: function () {
				this._gameNumber = this._generateGameNumber(); // Im lazy
				console.log(this._gameNumber);
				output.writeLine('New game has started, enter your first number!');
			},
			checkNumber: function (input) {
				var result = { rams: 0, sheeps: 0 },
					gameNumber = this._parseGameNumber(input);

				this._guessCount++;

				for (var i = 0; i < gameNumber.length; i++) {
					if (gameNumber[i] === this._gameNumber[i]) {
						result.rams++;
						continue;
					}

					for (var j = 0; j < this._gameNumber.length; j++) {
						if (gameNumber[i] === this._gameNumber[j]) {
							result.sheeps++;
							continue;
						}
					}
				}

				return result;
			},
			getGuessCount: function () {
				return this._guessCount;
			},
			_parseGameNumber: function (input) {
				if (typeof input !== 'string') {
					throw { message: 'Invalid game number!' };
				}

				if (input.length !== 4) {
					throw { message: 'Invalid game number!' };
				}

				var result = input.split('').map(function (char) {
					return parseInt(char);
				});

				return result;
			},
			_getRandomNumber: function (lowerBound, upperBound) {
				var min = lowerBound || 0,
				max = upperBound || 10,
				randomNumber;

				randomNumber = Math.floor((max - min) * Math.random() + min);

				return randomNumber;
			},
			_generateGameNumber: function () {
				var gameNumber = [],
					nextDigit,
					isDistinct = false;

				gameNumber.push(this._getRandomNumber(1, 10));

				while (gameNumber.length < 4) {
					nextDigit = this._getRandomNumber();
					isDistinct = true;
					for (var i = 0; i < gameNumber.length; i++) {
						if (gameNumber[i] === nextDigit) {
							isDistinct = false;
							break;
						}
					}

					if (isDistinct) {
						gameNumber.push(nextDigit);
					}
				}

				return gameNumber;
			}
		};

		return Game;
	})();

	return Game;
});