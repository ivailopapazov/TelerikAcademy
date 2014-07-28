define(['jquery', 'httpRequester'], function ($, httpRequester) {
	var url = 'http://localhost:3000/students/';

	function getAllStudents () {
		return httpRequester.get(url);
	}

	function createStudent (student) {
		return httpRequester.post(url, student);
	}

	function removeStudent(id) {
		var sendData = {
			'_method': 'delete'
		},
			studentUrl = url + id;

		return httpRequester.post(studentUrl, sendData);
	}

	return {
		getAll: getAllStudents,
		add: createStudent,
		remove:  removeStudent
	};
});	