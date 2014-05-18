function Solve(input) {
	var rowsColsAndJumps = parseNumbers(input[0]);
	var rows = rowsColsAndJumps[0];
	var cols = rowsColsAndJumps[1];
	var jumpCount = rowsColsAndJumps[2];

	var field = [];
	var counter = 1;

	// Initialize field
	for (var i = 0; i < rows; i++) {
		field[i] = [];
		for (var j = 0; j < cols; j++) {
			field[i][j] = counter++;
		}
	}

	// Get jumps
	var jumps = getJumps(input);

	// Visited array
	var visited = [];

	// get start position
	var startPosition = parseNumbers(input[1]);
	var currentRow = startPosition[0];
	var currentCol = startPosition[1];
	visited[field[currentRow][currentCol]] = true;

	// Start jumping
	var jumpCount = 0;
	var jumpSum = field[currentRow][currentCol];
	while (true) {
		for (var i = 0; i < jumps.length; i++) {
			currentRow += jumps[i].row;
			currentCol += jumps[i].col;
			jumpCount++;

			if (currentRow >= rows || currentRow < 0 || currentCol >= cols || currentCol < 0) {
				return 'escaped ' + jumpSum;
			}

			if (visited[field[currentRow][currentCol]]) {
				return 'caught ' + jumpCount;
			}

			jumpSum += field[currentRow][currentCol];
			visited[field[currentRow][currentCol]] = true;
		}
	}

	function parseNumbers(input) {
		return input.split(' ').map(Number);
	}

	function getJumps(input) {
		var jumps = [];
		var currentJump = [];

		for (var i = 2; i < jumpCount + 2; i++) {
			currentJump = parseNumbers(input[i])
			jumps.push({ row: currentJump[0], col: currentJump[1] });
		}

		return jumps;
	}
}

var input = [
'500 500 1',
'0 0',
'1 1',
]

console.log(Solve(input));