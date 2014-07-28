var movingShapes = (function () {
	var center,
		ellipseTrajectory,
		rectTrajectory,
		divElement,
		Rect,
		Ellipse,
		shapes = [];

	center = {
		x: window.innerWidth / 2,
		y: window.innerHeight / 2,	
	};

	ellipseTrajectory = {
		cx: center.x,
		cy: center.y,
		radius: window.innerHeight / 4,
	};

	rectTrajectory = {
		x: center.x - ellipseTrajectory.radius,
		y: center.y - ellipseTrajectory.radius,
		width: ellipseTrajectory.radius * 2,
		height: ellipseTrajectory.radius * 2,
	};

	divElement = document.createElement('div');
	divElement.innerHTML = 'DIV';
	divElement.className = 'rotate';

	function Shape (startX, startY) {
		var div = divElement.cloneNode(true);

		div.style.backgroundColor = getRandomColor();
		div.style.color = getRandomColor();
		div.style.borderColor = getRandomColor();

		this.node = div;
		this.x = startX;
		this.y = startY;

		this.setPosition();
	}

	Shape.prototype.setPosition = function (x, y) {
		this.x = x || this.x;
		this.y = y || this.y;

		this.node.style.top = this.y + 'px';
		this.node.style.left = this.x + 'px';
	}

	Shape.prototype.remove = function () {
		this.node.parentNode.removeChild(this.node);
		delete this;
	}


	function Rect () {
		this.dir = 'right';

		Shape.call(this, rectTrajectory.x, rectTrajectory.y);
		document.body.appendChild(this.node);
	}

	Rect.prototype = new Shape();
	Rect.prototype.move = function () {
		var step = 6,
			rightLimit = rectTrajectory.x + rectTrajectory.width,
			bottomLimit = rectTrajectory.y + rectTrajectory.height,
			leftLimit = rectTrajectory.x,
			topLimit = rectTrajectory.y;

		switch (this.dir) {
			case 'right':
				if (this.x < rightLimit) {
					this.setPosition(this.x + step, this.y);
				}
				else {
					this.setPosition(rightLimit, this.y);
					this.dir = 'down';
				}

				break;
			case 'down':
				if (this.y < bottomLimit) {
					this.setPosition(this.x, this.y + step);
				}
				else {
					this.setPosition(this.x, bottomLimit);
					this.dir = 'left';
				}

				break;
			case 'left':
				if (this.x > leftLimit) {
					this.setPosition(this.x - step, this.y);
				}
				else {
					this.setPosition(leftLimit, this.y);
					this.dir = 'up';
				}

				break;
			case 'up':
				if (this.y > topLimit) {
					this.setPosition(this.x, this.y - step);
				}
				else {
					this.setPosition(this.x, topLimit);
					this.dir = 'right';
				}

				break;
		}

	}

	function Ellipse () {
		this.angle = 0;
		Shape.call(this, ellipseTrajectory.cx + ellipseTrajectory.radius, ellipseTrajectory.cy);
		document.body.appendChild(this.node);
	}

	Ellipse.prototype = new Shape();
	Ellipse.prototype.move = function () {
		this.angle += 0.02;
		this.x = ellipseTrajectory.cx + Math.cos(this.angle) * ellipseTrajectory.radius;
		this.y = ellipseTrajectory.cy + Math.sin(this.angle) * ellipseTrajectory.radius;
		this.setPosition();
	} 


	function getRandomColor() {
		return 'rgb(' + Math.floor(Math.random() * 256) + ', ' + 
						Math.floor(Math.random() * 256) + ', ' + 
						Math.floor(Math.random() * 256) + ')';
	}



	function addShape (trajectory) {
		var newShape;

		switch (trajectory) {
			case 'rect':
				newShape = new Rect();
				break;
			case 'ellipse':
				newShape = new Ellipse();
				break;
			default: 
				return;
		}

		shapes.push(newShape);
	}

	function clearShapes () {
		while (shapes.length > 0) {
			shapes.pop().remove();
		}
	}

	(function frame() {
		for (var i = 0; i < shapes.length; i++) {
			shapes[i].move();
		}

		requestAnimationFrame(frame);
	})();

	return {
		add: addShape,
		clear: clearShapes,
	}
})();