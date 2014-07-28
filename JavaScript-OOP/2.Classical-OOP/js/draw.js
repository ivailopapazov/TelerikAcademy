var Drawer = (function () {
	var context;

	function Drawer(canvas) {
		context = canvas.getContext('2d');
	}

	Drawer.prototype.rect = function (x, y, width, height) {
		context.fillStyle = getRandomColor();
		context.fillRect(x, y, width, height);
	}

	Drawer.prototype.circle = function (x, y, radius) {
		context.beginPath();
		context.arc(x, y, radius, 0, 2 * Math.PI);
		context.fillStyle = getRandomColor();
		context.fill();
	}

	Drawer.prototype.line = function (x1, y1, x2, y2) {
		context.beginPath();
		context.moveTo(x1, y1);
		context.lineTo(x2, y2);
		context.stroke();
	}

	function getRandomColor() {
		return 'rgb(' + Math.floor(Math.random() * 256) + ', ' + 
						Math.floor(Math.random() * 256) + ', ' + 
						Math.floor(Math.random() * 256) + ')';
	}

	return Drawer;
})();