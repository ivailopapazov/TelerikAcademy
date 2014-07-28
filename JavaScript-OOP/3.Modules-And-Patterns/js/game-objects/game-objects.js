var gameObjects = (function () {
	'use strict';

	var SnakePiece = (function () {
		function SnakePiece (x, y) {
			this.x = x;
			this.y = y;
		}

		return SnakePiece;
	})();

	var Snake = (function () {

		function Snake (pieces) {
			this._pieces = pieces;
		}

		return Snake;
	})();

	return {
		snakePiece: SnakePiece,
		snake: Snake,
	};
})();