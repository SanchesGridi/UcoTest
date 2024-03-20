const http = require("http");
const fs = require("fs");

http.createServer(function (request, response) {
    let filePath = request.url.substring(1);
    if (filePath === "") filePath = "index.html";
    fs.readFile(filePath, function (error, data) {
        if (error) {
            response.statusCode = 404;
            response.end("<p style='position: absolute;top: 50%;left: 50%;transform: translate(-50%,-50%);font-size: larger;'>Resourse not found!</p>");
        } else {
            if (filePath.endsWith(".js")) response.setHeader("Content-Type", "text/javascript");
            response.end(data);
        }
    });
}).listen(3000, function () {
    console.log('server started at http://localhost:3000');
});