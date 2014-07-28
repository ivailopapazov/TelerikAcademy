define(['courses/student'], function () {
	'use strict';
	var Course;

	Course = (function () {

		function getTopStudentsBy(count, comparer) {
			var students = this._students.slice(0);
			students.sort(comparer);
			return students.slice(0, count);
		}

		function Course (title, scorePatternFormula) {
			this.title = title;
			this._totalScoreFormula = scorePatternFormula;
			this._students = [];
		}

		Course.prototype = {
			addStudent: function (student) {
				this._students.push(student);
				return this;
			},
			calculateResults: function () {
				var i, currentStudent, currentStudentTotalScore;

				for (i = 0; i < this._students.length; i++) {
					currentStudent = this._students[i];
					currentStudentTotalScore = this._totalScoreFormula(currentStudent);
					currentStudent.setTotalScore(currentStudentTotalScore);
				}
			},
			getTopStudentsByExam: function (count) {
				return getTopStudentsBy.call(this, count, function (student1, student2) {
					return student2.exam - student1.exam;
				});
			},
			getTopStudentsByTotalScore: function (count) {
				return getTopStudentsBy.call(this, count, function (student1, student2) {
					return student2.getTotalScore() - student1.getTotalScore();
				});
			}
		};

		return Course;
	})();

	return Course;
});