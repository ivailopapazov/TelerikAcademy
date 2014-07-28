define(function () {
	var id = 1;

	function Person (name, age, avatarUrl) {
		this.name = name;
		this.age = age;
		this.avatarUrl = avatarUrl;
		this.id = id++;
	}

	return Person;
});