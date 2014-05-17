function Solve(input) {
	input = input.map(Number);
	var size = input[0];

	var currentSum = 0;
	var maxSum = -Number.MAX_VALUE;

	for (var i = 1; i < size + 1; i++) {
		for (var k = i; k < size + 1; k++) {
			currentSum += input[k];

			if (currentSum > maxSum) {
				maxSum = currentSum;
			}
		}

		currentSum = 0;
	}

	return maxSum;
}

var input = [
'9',
'-9',
'-8',
'-8',
'-7',
'-6',
'-5',
'-1',
'-7',
'-6',
] 

console.log(Solve(input));