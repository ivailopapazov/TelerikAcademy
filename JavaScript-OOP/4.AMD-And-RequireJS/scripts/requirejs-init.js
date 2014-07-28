(function () {
	require.config({
		paths: {
			"jquery": "bower_components/jquery/dist/jquery",
			"handlebars": "bower_components/handlebars/handlebars",
			"controls": "controls/controls",
			"person": "data/person",
			"people": "data/people"
		}
	});

	require(["jquery", "people", "controls"], function ($, people, controls) {
		var comboBox = new controls.ComboBox(people);
		var template = $('#content-template').html();
		var $container = $('#container');
		$container.append(comboBox.render(template));


		$container.on('click', '.person-item', function (ev) {
			$this = $(this);

			if ($container.hasClass('collapsed')) {
				$container.find('.selected').removeClass('selected');
				$container.children().show();
			}
			else {
				$this.addClass('selected');
				$container.children().not('.selected').hide();
			}

			$container.toggleClass('collapsed');
		});
		
		$container.children().first().click();
	});
})();