const http = require('http');
const port = 80;
const handlers = require('./handlers/index.js');

http.createServer((req, res) => {
    for (const handler of handlers) {
        if (!handler(req, res)) {
            break;
        }
    }

}).listen(port);
