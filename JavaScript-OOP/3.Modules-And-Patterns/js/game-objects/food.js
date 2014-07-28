gameObjects = gameObjects || {};
gameObjects.Food = (function () {
	'use strict';

	var Food = (function () {

		function Food (x, y) {
			this.x = x;
			this.y = y;
		}

		return Food;
	})();
	
	return Food;
})(); 