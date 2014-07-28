var domModule = (function () {
	var buffer = {};

	function appendNodeToParent(parentSelector, node) {
		var parentElement = document.querySelector(parentSelector);
		parentElement.appendChild(node);
	}

	function removeChildFromParent(parentSelector, childSelector) {
		var parentElement = document.querySelector(parentSelector),
			childElement = parentElement.querySelector(childSelector);

		parentElement.removeChild(childElement);
	}

	function addEventHandlerToElement(elementSelector, eventType, callback) {
		var nodes = document.querySelectorAll(elementSelector);

		for (var i = 0, count = nodes.length; i < count; i++) {
			nodes[i].addEventListener(eventType, callback);			
		}
	}

	function addElementToBuffer(containerSelector, node) {
		var containerElement;

		if (!buffer[containerSelector]) {
			buffer[containerSelector] = document.createDocumentFragment();
		}

		buffer[containerSelector].appendChild(node);

		if (buffer[containerSelector].childNodes.length >= 100) {
			containerElement = document.querySelector(containerSelector);
			containerElement.appendChild(buffer[containerSelector]);
			delete buffer[containerSelector];
		}
	}

	return {
		appendChild: appendNodeToParent,
		removeChild: removeChildFromParent,
		addHandler: addEventHandlerToElement,
		appendToBuffer: addElementToBuffer,
	};
})();