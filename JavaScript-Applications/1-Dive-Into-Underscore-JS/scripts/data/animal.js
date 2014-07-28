define(['underscore'], function(_) {
	'use strinct'

	var Animal = (function () {
		var posibleLegCount = [2, 4, 6, 8, 100];

		function Animal (species, numberOfLegs) {
			this.setSpecies(species);
			this.setNumberOfLegs(numberOfLegs);
		}

		Animal.prototype = {
			setSpecies: function (species) {
				if (typeof species !== 'string') {
					throw { message: 'Animal species must be a string!' };
				}

				this._species = species;
			},
			getSpecies: function () {
				return this._species;
			},
			setNumberOfLegs: function (number) {
				if (typeof number !== 'number') {
					throw { message: 'Animal number of legs must be a number!' };
				}

				var isValidLegCount = _.any(posibleLegCount, function(element) {
					return number === element;
				});

				if (!isValidLegCount) {
					throw { message: 'Invalid leg count!' };
				}

				this._numberOfLegs = number;
			},
			getNumberOfLegs: function () {
				return this._numberOfLegs;
			},
			toString: function () {
				return this._species + ' has ' + this._numberOfLegs + 'legs';
			}
		};

		return Animal;
	})();

	return Animal;
});