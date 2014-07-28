(function () {
	var container = document.getElementById('container'),
		generateBtn = document.getElementById('generate'),
		removeBtn = document.getElementById('remove'),
		bufferBtn = document.getElementById('buffer'),
		divElement = document.createElement('div');

		
	generateBtn.addEventListener('click', onGenerateButtonClick);
	removeBtn.addEventListener('click', onRemoveButtonClick);
	bufferBtn.addEventListener('click', onBufferButtonClick);

	generateBtn.click();

	function onGenerateButtonClick() {
		var div = generateRandomDiv();
		domModule.appendChild('#container', div);
		domModule.addHandler('#container div:last-child', 'click', onDivClick);
	}

	function onRemoveButtonClick() {
		domModule.removeChild('#container', 'div:first-of-type');
	}

	function onBufferButtonClick() {
		for (var i = 0; i < 100; i++) {
			domModule.appendToBuffer('#container', generateRandomDiv());
		}

		domModule.addHandler('#container div', 'click', onDivClick);
	}

	function onDivClick() {
		this.style.backgroundColor = getRandomColor();
	}

	function generateRandomDiv() {
		divElement.innerHTML = 'DIV';
		divElement.style.backgroundColor = getRandomColor();
		return divElement.cloneNode(true);
	}

	function getRandomColor() {
		return 'rgb(' + Math.floor(Math.random() * 256) + ', ' + Math.floor(Math.random() * 256) + ', ' + Math.floor(Math.random() * 256) + ')';
	}
})();