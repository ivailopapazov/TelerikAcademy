define(function () {
	'use strict';
	var Container;

	Container = (function () {
		function Container () {
			this._sections = [];
		}

		Container.prototype = {
			add: function (section) {
				this._sections.push(section);
			},
			getData: function () {
				var dataSections,
					i;

				dataSections = [];
				for (var i = 0; i < this._sections.length; i++) {
					dataSections.push(this._sections[i].getData());
				}

				return dataSections;
			}
		};

		return Container;
	})();

	return Container;
})
