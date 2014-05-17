function Solve(numbers) {
	var size = parseInt(numbers[0]);
	var result = 1;
	var previousNum = parseInt(numbers[1]);
	var currentNum;

	for (var i = 2; i < numbers.length; i++) {
		currentNum = parseInt(numbers[i]);
		if (previousNum > currentNum) {
			result++;
		}

		previousNum = currentNum;
	}

	return result;
}
