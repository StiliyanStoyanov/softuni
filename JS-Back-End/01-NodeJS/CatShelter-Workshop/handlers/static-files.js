const url = require('url');
const fs = require('fs');
const path = require('path');

function getContentType(url) {

    if (url.endsWith('css')) {
        return 'text/css';
    } else if (url.endsWith('ico')) {
        return  'image/x-icon';
    } else if (url.endsWith('jpg')) {
        return  'image/jpg';
    } else if (url.endsWith('jpeg')) {
        return 'image/jpeg';
    } else if (url.endsWith('png')) {
        return 'image/png';
    } else if (url.endsWith('html')) {
        return 'text/html';
    } else if (url.endsWith('js')) {
        return 'application/javascript';
    } else {
        return 'text/plain';
    }

}

module.exports = (req, res) => {
    const { pathname } = url.parse(req.url);
    if (pathname.startsWith('/content') && req.method === 'GET') {
        fs.readFile(`./${pathname}`, 'utf-8', (err, data) => {
            if (err) {
                console.log(err);
                res.writeHead('404', {
                    'Content-Type': 'text/plain'
                });
                // Missing something
                res.write('Error was found');
                res.end();
                return;
            }
            res.writeHead('200', {
                'Content-Type': getContentType(pathname)
            });
            res.write(data);
            res.end();
        });
    } else {
        return true;
    }
};