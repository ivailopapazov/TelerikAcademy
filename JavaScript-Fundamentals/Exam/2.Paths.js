function Solve(input) {
	var rowsAndCols = input[0].split(' ').map(Number);
	var rows = rowsAndCols[0];
	var cols = rowsAndCols[1];

	var field = [];
	var rowStart = 0;

	for (var i = 0; i < rows; i++) {
		field[i] = [];
		rowStart = Math.pow(2, i);

		for (var j = 0; j < cols; j++) {
			field[i][j] = rowStart++;
		}
	}

	input = input.slice(1).map(function(x) { return x.split(' ')});

	var row = 0;
	var col = 0;

	var sum = 0;
	while (true) {
		if (row >= rows || row < 0 || col >= cols || col < 0) {
			// escaped
			return 'successed with ' + sum;
		}

		if (field[row][col] === 0) {
			// visited
			return 'failed at (' + row + ', ' + col + ')';
		}

		sum += field[row][col];
		field[row][col] = 0;

		switch (input[row][col]) {
			case 'dr': row++; col++; break; 
			case 'dl': row++; col--; break;
			case 'ur': row--; col++; break;
			case 'ul': row--; col--; break;
		}
	}

}

var args =[
  '3 5',
  'dr dl dr ur ul',
  'dr dr ul ur ur',
  'dl dr ur dl ur'   
];

var args2 = [
  '3 5',
  'dr dl dl ur ul',
  'dr dr ul ul ur',
  'dl dr ur dl ur'   
]


var input3 = [

];

var input4 = [

];

// console.log(Solve(args));
console.log(Solve(args2));
// console.log(Solve(input3));
// console.log(Solve(input4));