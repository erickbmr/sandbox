import http from "http";

http.createServer((req, res) => {
  if (req.url === "/") {
    res.writeHead(200);
    res.end(process.env.HOSTNAME);
  } else {
    res.writeHead(404);
    res.end();
  }
}).listen(3000);
