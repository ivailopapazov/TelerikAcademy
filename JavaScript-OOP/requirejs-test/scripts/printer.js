var controls = (function () {
	var Printer = (function () {
		this._priv = '';

		function Printer(value) {
			this.prop = value;
			this._priv = value;
		}

		Printer.prototype = {
			getPriv: function () {
				return this._priv;
			},
			serPriv: function (value) {
				this._priv = value;
			}
		}

		return Printer;
	})();

	return {
		key: 'value',
		Printer: Printer,
	};
})();