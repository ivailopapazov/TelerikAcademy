window.onload = function() {
	var $container = $('#slider-container');

	$container.find('.image-item').hide()
		.first()
			.addClass('current')
			.show();

	$container.find('.prev-item')
		.on('click', function(ev) {
			var $currentImage = $container.find('.image-item.current'),
				$prevImage = $currentImage.prev('.image-item');

			if ($prevImage.length > 0) {
				$currentImage.removeClass('current').hide();
				$prevImage.addClass('current').show();
			}
		});

	$container.find('.next-item')
		.on('click', function(ev) {
			var $currentImage = $container.find('.image-item.current'),
				$nextImage = $currentImage.next('.image-item');

			if ($nextImage.length > 0) {
				$currentImage.removeClass('current').hide();
				$nextImage.addClass('current').show();
			}
		});
}
