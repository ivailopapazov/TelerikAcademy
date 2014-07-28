define([], function() {
	'use strinct'

	var Student = (function () {
		function Student (firstName, lastName, age, marks) {
			this.setFirstName(firstName);
			this.setLastName(lastName);
			this.setAge(age);
			this.setMarks(marks);
		}

		Student.prototype = {
			getFullName: function () {
				return this._firstName + ' ' + this._lastName;
			},
			setFirstName: function (firstName) {
				if (typeof firstName !== 'string') {
					throw { message: 'Student\' first name must be string!' };
				}

				this._firstName = firstName;
			},
			getFirstName: function () {
				return this._firstName;
			},
			setLastName: function (lastName) {
				if (typeof lastName !== 'string') {
					throw { message: 'Student\'s last name must be string!' };
				}

				this._lastName = lastName;
			},
			getLastName: function () {
				return this._lastName;
			},
			setAge: function (age) {
				if (typeof age !== 'number') {
					throw { message: 'Student\'s age must be a number!' };
				}

				if (age < 1) {
					throw { message: 'Student\'s age must be positive number!' };
				}

				this._age = age;
			},
			getAge: function () {
				return this._age;
			},
			setMarks: function (marks) {
				if (!(marks instanceof Array)) {
					throw { message: 'Student\'s marks must be an array' };
				}

				if (marks.length < 1) {
					throw { message: 'Student\'s marks must be positive number'}
				}

				this._marks = marks;
			},
			getMarks: function () {
				return this._marks;
			},
			toString: function () {
				// return JSON.stringify(this);
				return 'FirstName: ' + this._firstName + ', ' +
						'LastName: ' + this._lastName + ', ' +
						'Age: ' + this._age + ', ' +
						'Marks: ' + this._marks;
			}
		};

		return Student;
	})();

	return Student;
});