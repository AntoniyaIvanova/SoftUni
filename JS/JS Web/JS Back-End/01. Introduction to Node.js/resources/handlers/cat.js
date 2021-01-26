const url = require('url');
const fs = require('fs');
const path = require('path');
const qs = require('querystring');
const formidable = require('formidable');
const breeds = require('../data/breeds');
const cats = require('../data/cats.json');
const { request } = require('http');
const globalPath = __dirname.toString().replace('handlers', '');

module.exports = (req, res) => {

    const pathname = url.parse(req.url).pathname;

    if (pathname === '/cats/add-cat' && req.method === 'GET') {

        const filePath = path.normalize(path.join(__dirname, '../views/addCat.html'));

        const index = fs.createReadStream(filePath);

        index.on('data', (data) => {
            const catBreedPlaceholder = breeds.map((breed) => `<option value="${breed}">${breed}</option>`);
            const modifiedData = data.toString().replace('{{catBreeds}}', catBreedPlaceholder);
            res.write(modifiedData);
        })

        index.on('end', () => {
            res.end();
        });

        index.on('error', (err) => {
            console.log(err);
        });

    } else if (pathname === '/cats/add-breed' && req.method === 'GET') {

        const filePath = path.normalize(path.join(__dirname, '../views/addBreed.html'));

        const index = fs.createReadStream(filePath);

        index.on('data', (data) => {
            res.write(data);
        })

        index.on('end', () => {
            res.end();
        });

        index.on('error', (err) => {
            console.log(err);
        });

    } else if (pathname === '/cats/add-cat' && req.method === 'POST') {

        let form = new formidable.IncomingForm();

        form.parse(req, (err, fields, files) => {

            if (err) {
                throw err;
            }

            let oldPath = files.upload.path;
            let newPath = path.normalize(path.join(globalPath, '/content/images/' + files.upload.name));

            /*   fs.rename(oldPath, newPath, (err) => {
                   if(err) throw err;
   
                   console.log(`File was uploaded successfully!`);
               });*/

            fs.readFile('./data/cats.json', 'utf8', (err, data) => {
                if (err) {
                    throw err;
                }

                let allCats = JSON.parse(data);
                allCats.push({ id: (cats.length + 1).toString(), ...fields, image: files.upload.name });
                let json = JSON.stringify(allCats);

                fs.writeFile('./data/cats.json', json, () => {
                    res.writeHead(302, { location: '/' });
                    res.end();
                })
            })
        });

    } else if (pathname === '/cats/add-breed' && req.method === 'POST') {
        let formData = '';

        req.on('data', (data) => {
            formData += data;
        });

        req.on('end', () => {
            let body = qs.parse(formData);

            fs.readFile('./data/breeds.json', (err, data) => {
                if (err) {
                    throw err;
                }

                let breeds = JSON.parse(data);
                breeds.push(body.breed);
                let json = JSON.stringify(breeds);

                fs.writeFile('./data/breeds.json', json, 'utf-8', () => console.log("The breed was uploaded successfully"));
            });

            res.writeHead(302, { location: '/' });
            res.end();
        });
    } else if (pathname.includes('/cats-edit') && req.method === 'GET') {
        const filePath = path.normalize(path.join(__dirname, '../views/editCat.html'));

        const index = fs.createReadStream(filePath);

        index.on('data', (data) => {

            const catId = pathname.split('/').pop();
            const currentCat = cats.find((cat) => cat.id === catId);

            let modifiedData = data.toString().replace('{{id}}', catId);
            modifiedData = modifiedData.replace('{{name}}', currentCat.name);
            modifiedData = modifiedData.replace('{{description}}', currentCat.description);

            const breedsAsOptions = breeds.map((b) => `<option value="${b}">${b}</option>`);
            modifiedData = modifiedData.replace('{{catBreeds}}', breedsAsOptions.join('/'));

            modifiedData = modifiedData.replace('{{breed}}', currentCat.breed);

            res.writeHead(200, { 'Content-Type': 'text/html' });
            res.write(modifiedData);
        })

        index.on('end', () => {
            res.end();
        });

        index.on('error', (err) => {
            console.log(err);
        });
    } else if (pathname.includes('/cats-edit') && req.method === 'POST') {

        let form = new formidable.IncomingForm();

        form.parse(req, (err, fields, files) => {

            if (err) {
                throw err;
            }

            let oldPath = files.upload.path;
            let newPath = path.normalize(path.join(globalPath, `content/images/${files.upload.name}`));

            /*fs.rename(oldPath, newPath, (err) => {
                if (err) throw err;

                console.log(`File was uploaded successfully!`);
            });*/

            fs.readFile('./data/cats.json', 'utf8', function readFileCallback(err, data) {
                if (err) {
                    throw err;
                } else {

                    let allCats = JSON.parse(data);
                    const catId = pathname.split('/').pop();

                    allCats.forEach(function(cat){
                        if(cat.id === catId){
                            cat.name = fields.name;
                            cat.description = fields.description;
                            cat.breed = fields.breed;
                            cat.image = files.upload.name;
                        }
                    });      

                    let json = JSON.stringify(allCats);

                    fs.writeFile('data/cats.json', json, 'utf8', () => {                        
                        res.writeHead(302, { 'location': '/' });
                       res.end();
                    })
                }
            })
        });
    } else if (pathname.includes('/cats-find-new-home') && req.method === 'GET') {
      
        const catId = pathname.split('/').pop();
        const currentCat = cats.find((cat) => cat.id === catId);
        const filePath = path.normalize(path.join(__dirname, '../views/catShelter.html'));
    
        const index = fs.createReadStream(filePath);

        index.on('data', (data) => {
            let modifiedData = data.toString().replace('{{id}}', catId);
            modifiedData = modifiedData.replace('{{name}}', currentCat.name);
            modifiedData = modifiedData.replace('{{description}}', currentCat.description);
            modifiedData = modifiedData.replace('{{image}}', currentCat.image);
            const breedsAsOptions = breeds.map((b) => `<option value="${b}">${b}</option>`);
            modifiedData = modifiedData.replace('{{catBreeds}}', breedsAsOptions.join('/'));

            modifiedData = modifiedData.replace('{{breed}}', currentCat.breed);

            res.writeHead(200, { 'Content-Type': 'text/html' });
            res.write(modifiedData);
        })
        index.on('end', () => {
            res.end();
        });

        index.on('error', (err) => {
            console.log(err);
        });
    } else if (pathname.includes('/cats-find-new-home') && req.method === 'POST') {
        fs.readFile('./data/cats.json', 'utf8', (err, data) => {
            if (err) {
                throw err;
            };

            const id = pathname.split('/').pop();
            let allCats = JSON.parse(data).filter(cat => cat.id !== id);
            const json = JSON.stringify(allCats);

            fs.writeFile('./data/cats.json', json, (err) => {
                if (err) {
                    throw err;
                };
                console.log(`Cat ID:${id} successfully adopted!`);
            })
        });
        res.writeHead(302, { 'location': '/' });
        res.end();
    }
    else {
        return true;
    }

}