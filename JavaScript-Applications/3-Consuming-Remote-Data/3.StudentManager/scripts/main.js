require.config({
	paths: {
		"jquery": "bower_components/jquery/dist/jquery",
		"httpRequester": "http-requester",
		"students": "students"
	}
});

require(['jquery', 'students'], function ($, studentManager) {
	var $mainContainer = $('#main-container'),
		$studentNameInputElement = $mainContainer.find('#student-name'),
		$addStudentButton = $mainContainer.find('#add-student'),
		$studentListSelectElement = $mainContainer.find('#student-list'),
		$deleteStudentButton = $mainContainer.find('#remove-student');

	$addStudentButton.on('click', function () {
		var studentName = $studentNameInputElement.val(),
			studentObject = { name: studentName };

		studentManager.add(studentObject)
			.done(function (result) {
				updateStudentList();
			})
			.fail();

		return false;
	});

	$deleteStudentButton.on('click', function () {
		var studentId = $studentListSelectElement.val();

		studentManager.remove(studentId)
			.done(function (result) {
				updateStudentList();
			});

		return false;
	});

	function updateStudentList () {
		$studentListSelectElement.empty();

		studentManager.getAll()
			.done(populateStudentList)
			.fail(function (result) {
				studentNotifier(result.statusText);
			});
	}

	function populateStudentList(studentsObject) {
		var students = [],
			$studentListFragment;

		students = studentsObject.students;
		if (students.length < 1) {
			studentNotifier('No Students!');
			return;
		}

		$studentListFragment = $(document.createDocumentFragment())
		for (var i = 0; i < students.length; i++) {
			$('<option />')
				.attr('value', students[i].id)
				.html(students[i].name)
				.appendTo($studentListFragment);
		}

		$studentListSelectElement.append($studentListFragment);
	}

	function studentNotifier(text) {
		// TODO: Some UI notifier
		console.log(text);
	}

	updateStudentList();
});