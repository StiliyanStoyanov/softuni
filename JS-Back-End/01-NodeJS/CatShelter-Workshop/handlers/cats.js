const url = require('url');
const fs = require('fs');
const path = require('path');
const qs = require('querystring');
const formidable = require('formidable');
const breeds = require('../data/breeds')
const cats = require('../data/cats');
let filePath = path.normalize(path.join(__dirname, '../views/'));

// function requireUncached(module){
//     delete require.cache[require.resolve(module)]
//     return require(module)
// }


module.exports = (req, res) => {
    const { pathname } = url.parse(req.url);
    function streamGetPage(stream) {
        stream.on('data', (chunk) => {
            if (pathname === '/cats/add-cat') {
                let catBreedPlaceholder = breeds.map((breed) => `<option value="${breed.toString()}">${breed.toString()}</option>`);
                let modifiedData = chunk.toString().replace('{{catBreeds}}', catBreedPlaceholder.join('\n\t\t\t\t'));
                res.write(modifiedData);
            } else {
                res.write(chunk);
            }
        });
        stream.on('end', () => {
            res.end();
        });
        stream.on('error', (err) => {
            console.error(err);
        });
    }
    if (pathname === '/cats/add-cat' && req.method === 'GET') {
        const stream = fs.createReadStream(filePath + 'addCat.html');
        streamGetPage(stream);
    }
    else if (pathname === '/cats/add-cat' && req.method ==='POST') {
        let form = new formidable.IncomingForm();
        form.parse(req, (err, fields, files) => {
            if (err) {
                throw err;
            }
            let oldPath = files.upload.path;
        });
        let formData = '';
        res.end();
    }
    else if (pathname === '/cats/add-breed' && req.method === 'GET') {
        const stream = fs.createReadStream(filePath + 'addBreed.html');
        streamGetPage(stream);
    }
    else if (pathname === '/cats/add-breed' && req.method === 'POST') {
        let formData = '';
        req.on('data', (data) => {
            formData += data;
        });
        req.on('end', () => {
            let body = qs.parse(formData);
            fs.readFile('./data/breeds.json', (err, data) => {
                if (err) {
                    console.error(err);
                }
                let breeds = JSON.parse(data);
                breeds.push(body.breed);
                let json = JSON.stringify(breeds);
                fs.writeFile('./data/breeds.json', json, 'utf-8',
                    () => console.log('breed uploaded!'));
            });
            res.writeHead(302, {Location: '/'});
            res.end();
        });

    }
    else {
        return true;
    }
};