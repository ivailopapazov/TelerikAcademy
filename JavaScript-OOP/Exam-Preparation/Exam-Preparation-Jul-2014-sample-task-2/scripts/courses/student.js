define(function () {
	'use strict';
	var Student;

	Student = (function () {
		function Student (studentInfo) {
			this.name = studentInfo.name;
			this.exam = studentInfo.exam;
			this.homework = studentInfo.homework;
			this.attendance = studentInfo.attendance;
			this.teamwork = studentInfo.teamwork;
			this.bonus = studentInfo.bonus;
			this._totalScore = 0;
		}

		Student.prototype = {
			setTotalScore: function (score) {
				this._totalScore = score;
			},
			getTotalScore: function () {
				return this._totalScore;
			}
		};

		return Student;
	})();

	return Student;
});