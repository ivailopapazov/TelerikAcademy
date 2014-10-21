var http = require('http');
var port = 80;

http.createServer(function (request, response) {
	if (request.method === 'GET') {
		// return index
	}
	else if (request.method === 'POST') {
		response.write('post');
	}

	response.end();
}).listen(port);

console.log("Listening on port: " + port);