define(["person"], function (Person) {
	var people = [
		new Person("Doncho Minkov", 18, "images/minkov.jpg"),
		new Person("Ivaylo Kenov", 25, "images/ivo.jpg"),
		new Person("Nikolay Kostov", 25, "images/niki.jpg"),
		new Person("Todor Stoyanov", 25, "images/todor.jpg")
	];

	return people;
});