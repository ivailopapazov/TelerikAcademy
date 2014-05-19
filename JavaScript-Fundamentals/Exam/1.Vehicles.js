function Solve(num) {
	var trikesWheels = 3;
	var carWheels = 4;
	var truckWheels = 10;

	var num = parseInt(num);
	var combinationCount = 0;
	var wheelsCount = 0;

	var maxTrikes = num / trikesWheels;
	var maxCars = num / carWheels;
	var maxTrucks = num / truckWheels;

	for (var i = 0; i <= maxTrucks; i++) {
		for (var j = 0; j <= maxCars; j++) {
			for (var k = 0; k <= maxTrikes; k++) {
				wheelsCount = i * truckWheels + j * carWheels + k * trikesWheels;
				if (wheelsCount === num) {
					combinationCount++;
				}
			}
		}
	}

	return combinationCount;
}

var input1 = 10;

console.log(Solve(input1));
