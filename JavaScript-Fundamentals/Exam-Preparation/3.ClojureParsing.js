function Solve(input) {
	var operands = {};
	input = input.map(getExpressionArray);

	var expression = '';
	var result;
	for (var i = 0; i < input.length - 1; i++) {
		expression = input[i][0];
		if (input[i].length == 2) {
			var innerExp = evaluateExpression(input[i][1]);  
			if (innerExp === 'zero') {
				return 'Division by zero! At Line:' + (i + 1);
			}
			expression += ' ' + innerExp;
		}

		result = evaluateExpression(expression);
		if (result === 'zero') {
			return 'Division by zero! At Line:' + (i + 1);
		}
	}

	result = evaluateExpression(input[input.length - 1][0]);
	if (result === 'zero') {
		return 'Division by zero! At Line:' + input.length;
	}
	return result;

	
	function evaluateExpression(expression) {
		var arguments = expression.split(' ');
		var result = 0;
		switch (arguments[0]) {
			case 'def':
				operands[arguments[1]] = getValue(arguments[2]);
				return;
			case '+':
				for (var i = 1; i < arguments.length; i++) {
					result += getValue(arguments[i]);
				}
				return result;
			case '-':
				result = getValue(arguments[1]);
				for (var i = 2; i < arguments.length; i++) {
					result -= getValue(arguments[i]);
				}
				return result;
			case '*':
				result = getValue(arguments[1]);
				for (var i = 2; i < arguments.length; i++) {
					result *= getValue(arguments[i]);
				}
				return result;
			case '/':
				result = getValue(arguments[1]);
				for (var i = 2; i < arguments.length; i++) {
					if (arguments[i] === '0') {
						return 'zero';
					}
					result /= getValue(arguments[i]);
				}
				return Math.floor(result);
		}
	}

	function getValue(arg) {
		var value = parseInt(arg);
		if (isFinite(value)) {
			return value;
		}
		return operands[arg];
	}

	function getExpressionArray(str) {
		str = replaceAll(str, ')', '|');		
		str = replaceAll(str, '(', '|');
		var normalizedString = str.split(' ').filter(function(x) { return x != ''; }).join(' ');
		var arr = normalizedString.split('|').filter(function(x) { return x !== '' && x !== ' '; });
		arr = arr.map(function(x) { return x.trim() });

		if (arr.length == 3) {
			arr[0] = arr[0] + arr.pop();
		}

		return arr;
	}

	function replaceAll(str, find, replace) {
		var newStr = str.replace(find, replace);
		while (newStr !== str) {
			str = newStr;
			newStr = str.replace(find, replace);
		}

		return	newStr;
	}
}

var args = [
'(def kir4o 100)',
'(def cafeFunc (+ kir4o kir4o 3))',
'(def tabFunc (* cafeFunc 7))',
'(def tabfunc (- kir4o 5 4 3 2 1))',
'(/ tabFunc  tabfunc)',
]

console.log(Solve(args));