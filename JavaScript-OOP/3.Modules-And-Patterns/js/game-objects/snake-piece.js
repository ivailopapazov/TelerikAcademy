gameObjects = gameObjects || {};
gameObjects.SnakePiece = (function () {
	'use strict';

	var SnakePiece = (function () {
		function SnakePiece (x, y) {
			this.x = x;
			this.y = y;
		}

		return SnakePiece;
	})();
	
	return SnakePiece;
})(); 