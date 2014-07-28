define(['student'], function(Student) {
	'use strinct'

	var students = [
		new Student('Petur', 'Georgiev', 18, [ 2, 2, 3, 4, 2 ]),
		new Student('Georgi', 'Petrov', 20, [ 3, 5, 3, 4, 2 ]),
		new Student('Aleksandra', 'Nikolova', 27, [ 6, 3, 4, 5, 3 ]),
		new Student('Eleonora', 'Mihailova', 17, [ 6, 5, 6, 5, 4 ]),
		new Student('Nikolai', 'Ivanov', 24, [ 3, 2, 4, 6, 2 ]),
		new Student('Plamen', 'Iliev', 30, [ 6, 2, 5, 3, 5 ]),
	];

	return students
});