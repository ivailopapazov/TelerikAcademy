(function() {
	var addRectButton = document.getElementById('add-rect'),
		addEllipseButton = document.getElementById('add-ellipse'),
		clearButton = document.getElementById('clear-shapes');

	addRectButton.addEventListener('click', function(ev) {
		movingShapes.add('rect');
	});

	addEllipseButton.addEventListener('click', function(ev) {
		movingShapes.add('ellipse');
	});

	clearButton.addEventListener('click', function(ev) {
		movingShapes.clear();
	});
})();