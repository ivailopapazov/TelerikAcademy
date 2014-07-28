require.config({
	paths: {
		'underscore': 'bower_components/underscore/underscore',
		'jquery': 'bower_components/jquery/dist/jquery.min',
		'student': 'data/student',
		'students': 'data/students',
		'animal': 'data/animal',
		'animals': 'data/animals',
	}
});


require(['jquery', 'underscore', 'students', 'animals'], function ($, _, students, animals) {
	var $container = $('#solutions-container'),
		$studentsList = $('<ul />');

	for (var i = 0, length = students.length; i < length; i++) {
		$('<li />')
			.html(students[i].toString())
			.appendTo($studentsList);
	}

	$container.find('#student-list').append($studentsList);

	// Exercise 1:
	var orderedStudents = _.chain(students)
		.filter(function (student) {
			return student.getFirstName().toLowerCase() < student.getLastName().toLowerCase();
		})
		.sortBy(function (student) {
			return student.getFullName();
		})
		.reverse()
		.value();
	appendCollectionToDom(orderedStudents, '#exercise-one');

	// Exercise 2:
	var orderedStudents = _.chain(students)
		.filter(function (student) {
			return 18 <= student.getAge() && student.getAge() <= 24;
		})
		.map(function (student) {
			return {
				firstName: student.getFirstName(),
				lastName: student.getLastName(),
				toString: function () {
					return this.firstName + ' ' + this.lastName;
				}
			};
		})
		.value();
	appendCollectionToDom(orderedStudents, '#exercise-two');

	// Exercise 3:
	var studentWithHighestMarks = _.chain(students)
		.sortBy(function (student) {
			var marks = student.getMarks(),
				markSum = 0,
				averageMark = 0;

			for (var i = 0, marksCount = marks.length; i < marksCount; i++) {
				markSum += marks[i];
			}

			averageMark = markSum / marksCount;
			return averageMark;
		})
		.last()
		.value();
	appendCollectionToDom([studentWithHighestMarks], '#exercise-three');
	
	// Exercise 4
	var orderedAnimals = _.chain(animals)
		.groupBy(function (animal) {
			return animal.getSpecies();
		})
		.sortBy(function (group) {
			var animalFromGroup = _.first(group);
			return animalFromGroup.getNumberOfLegs();
		})
		.value();

	var $orderedList = $('<ol />');
	_.each(orderedAnimals, function (group) {
		var $unorderedList = $('<ul />');
		_.each(group, function (animal) {
			$unorderedList.append($('<li />').html(animal.toString()));
		});

		$orderedList.append($('<li />').append($unorderedList));
	});

	$container.find('#exercise-four').append($orderedList);

	// Exercise 5
	var totalNumberOfLegs = 0
	_.chain(animals)
		.each(function (animal) {
			totalNumberOfLegs += animal.getNumberOfLegs();
		});

	appendCollectionToDom([totalNumberOfLegs], '#exercise-five');

	function appendCollectionToDom(collection, selector) {
		var $orderedList = $('<ol />');

		_.each(collection, function (item) {
			$('<li />').html(item.toString()).appendTo($orderedList);
		});

		$container.find(selector).append($orderedList);
	}
});