(function () {
	var canvasElement,
		rectButton,
		circleButton,
		lineButton,
		draw;
	
	rectButton = document.getElementById('rect');
	circleButton = document.getElementById('circle');
	lineButton = document.getElementById('line');

	rectButton.addEventListener('click', onRectButtonClick);
	circleButton.addEventListener('click', onCircleButtonClick);
	lineButton.addEventListener('click', onLineButtonClick);

	canvasElement = document.getElementById('the-canvas');
	draw = new Drawer(canvasElement);

	function onRectButtonClick (ev) {
		var x = getRandomNumber(0, canvasElement.width),
			y = getRandomNumber(0, canvasElement.height),
			width = getRandomNumber(10, 250),
			height = getRandomNumber(10, 250);
		
		draw.rect(x, y, width, height);
	}
	
	function onCircleButtonClick (ev) {
		var x = getRandomNumber(0, canvasElement.width),
			y = getRandomNumber(0, canvasElement.height),
			radius = getRandomNumber(10, 100);

		draw.circle(x, y, radius);
	}
	
	function onLineButtonClick (ev) {
		var x1 = getRandomNumber(0, canvasElement.width),
			y1 = getRandomNumber(0, canvasElement.height);
			x2 = getRandomNumber(0, canvasElement.width),
			y2 = getRandomNumber(0, canvasElement.height);

		draw.line(x1, y1, x2, y2);
	}

	function getRandomNumber (min, max) {
		return Math.floor((max - min) * Math.random() + min);
	}

})();