gameObjects = gameObjects || {};
gameObjects.Snake = (function () {
	'use strict';

	var Snake = (function () {

		function Snake (pieces) {
			this._pieces = pieces;
		}

		return Snake;
	})();
	
	return Snake;
})(); 