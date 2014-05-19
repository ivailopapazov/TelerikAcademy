function Solve(input) {
	var varCount = parseInt(input[0]);
	var keyValuePair = "";
	var variables = {};
	var list = [];

	for (var i = 1; i < varCount + 1; i++) {
		keyValuePair = input[i].split(':')
		if (keyValuePair[1].indexOf(',') != -1) {
			list = keyValuePair[1].split(',').map(function(x) {
				var num = parseInt(x);
				if (x == num) {
					return num;
				}
				else {
					return x;
				}
			});
			variables[keyValuePair[0]] = list;
		}
		else {
			variables[keyValuePair[0]] = keyValuePair[1];
		}
	}

	input = input.slice(varCount + 2);

	var inSection = false;
	var sections = [];
	var sectionName = '';
	var result = [];
	var currentIndex = 0;
	var currentString = '';
	var currentSection = '';
	var currentProp = '';

	for (var i = 0; i < input.length; i++) {
		if (input[i].indexOf('@section') != -1) {
			inSection = true;
			sectionName = input[i].split(' ')[1];
			sections[sectionName] = [];
			continue;
		}

		if (inSection) {
			if (input[i] === '}') {
				inSection = false;
			}
			else {
				sections[sectionName].push(input[i]);
			}

			continue;
		}

		// Render Section
		currentString = '@renderSection("';
		currentIndex = input[i].indexOf(currentString);
		var padding = '';
		if (currentIndex !== -1) {
			currentSection = input[i].substr(currentIndex + currentString.length).split('"')[0];
			padding = generateCharacters(' ', currentIndex);
			for (var j = 0; j < sections[currentSection].length; j++) {
				result.push(padding + sections[currentSection][j]);
			}

			continue;
		}
		// If statement
		currentString = '@if (';
		currentIndex = input[i].indexOf(currentString);
		padding = '';
		var currentBool = '';
		if (currentIndex !== -1) {
			currentBool = input[i].substr(currentIndex + currentString.length).split(')')[0];
			console.log(currentBool);
			// padding = generateCharacters(' ', currentIndex);
			// for (var j = 0; j < sections[currentSection].length; j++) {
			// 	result.push(padding + sections[currentSection][j]);
			// }

			continue;
		}

		currentIndex = input[i].indexOf('@');
		var currentChar = '';
		var currentRow = '';
		var inProp = false;

		// TODO: case @@asdsad @prop
		if (currentIndex != -1 && input[i][currentIndex + 1] != '@') {
			for (var j = 0; j < input[i].length; j++) {
				currentChar = input[i][j];
				if (inProp) {
					if (currentChar === ' ' || currentChar === '<') {
						inProp = false;
						currentRow +=  variables[currentProp];
						currentProp = '';
					}
					else {
						currentProp += currentChar;
						continue;
					}

				}

				if (currentChar === '@') {
					inProp = true;
					continue;
				}

				currentRow += input[i][j];
			}
			result.push(currentRow);
			currentRow = '';
		}
		else {
			result.push(input[i]);
		}

	}
	// return result.join('\n');

	function generateCharacters(char, count) {
		return new Array(count).join(char);
	}
}

var input1 = [
'6',
'title:Telerik Academy',
'showSubtitle:true',
'subTitle:Free training',
'showMarks:false',
'marks:3,4,5,6',
'students:Pesho,Gosho,Ivan',
'42',
'@section menu {',
'<ul id="menu">',
'    <li>Home</li>',
'    <li>About us</li>',
'</ul>',
'}',
'@section footer {',
'<footer>',
'    Copyright Telerik Academy 2014',
'</footer>',
'}',
'<!DOCTYPE html>',
'<html>',
'<head>',
'    <title>Telerik Academy</title>',
'</head>',
'<body>',
'    @renderSection("menu")',
'    <h1>@title</h1>',
'    @if (showSubtitle) {',
'        <h2>@subTitle</h2>',
'        <div>@@JustNormalTextWithDoubleKliomba ;)</div>',
'    }',
'',
'    <ul>',
'        @foreach (var student in students) {',
'            <li>',
'                @student ',
'            </li>',
'            <li>Multiline @title</li>',
'        }',
'    </ul>',
'    @if (showMarks) {',
'        <div>',
'            @marks ',
'        </div>',
'    }',
'',
'    @renderSection("footer")',
'</body>',
'</html>',
];

var input2 = [

];

var input3 = [

];

var input4 = [

];

console.log(Solve(input1));
// console.log(Solve(input2));
// console.log(Solve(input3));
// console.log(Solve(input4));