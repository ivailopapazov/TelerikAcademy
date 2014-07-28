define(["handlebars"], function () {
	
	var ComboBox = (function () {

		function ComboBox (items) {
			this._items = items;
		}

		ComboBox.prototype = {
			render: function (source) {
				var template,
					result,
					len,
					i;
					
				template = Handlebars.compile(source);
				result = '';
				for (i = 0, len = this._items.length; i < len; i++) {
					result += template(this._items[i]);
				}

				return result;
			}
		};

		return ComboBox;
	})();

	return {
		ComboBox: ComboBox
	}
});