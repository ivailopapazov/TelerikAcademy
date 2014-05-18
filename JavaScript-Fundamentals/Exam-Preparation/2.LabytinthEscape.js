function Solve(input) {
	var rowsAndCols = parseNumbers(input[0]);
	var arrayRows = rowsAndCols[0];
	var arrayCols = rowsAndCols[1];

	// Create field
	var field = [];
	var counter = 1;
	var directions = [];
	for (var i = 0; i < arrayRows; i++) {
		field[i] = [];
		directions = parseLetters(input[i+2]);
		for (var j = 0; j < arrayCols; j++) {
			field[i][j] = {num: counter, dir: directions[j], visited: false};
			counter++;
		}
	}

	// get start position
	var startPosition = parseNumbers(input[1]);
	var row = startPosition[0];
	var col = startPosition[1];

	// Move 
	var sumOfNumbers = 0;
	var cellCount = 0;
	while (true) {
		if (row < 0 || row >= arrayRows || col < 0 || col >= arrayCols) {
			return 'out ' + sumOfNumbers;
		}

		if (field[row][col].visited) {
			return 'lost ' + cellCount;
		}

		field[row][col].visited = true;
		sumOfNumbers += field[row][col].num;
		cellCount++;

		switch (field[row][col].dir) {
			case 'u': row--; break;
			case 'r': col++; break;
			case 'd': row++; break;
			case 'l': col--; break;
		}

	}

	function parseNumbers(str) {
		return str.split(' ').map(Number);
	}

	function parseLetters(str) {
		return str.split('');
	}
}

var args =[
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "lurlddud",
 "urrrldud",
 "ulllllll"]



 console.log(Solve(args));
