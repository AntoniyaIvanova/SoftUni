const uniqueId = require('uniqId');
const Cube = require('../models/Cube');
const fs = require('fs');
const path = require('path');

let productsData = require('../config/products.json');

function getAll(query){
    let result = productsData;

    if(query.search){
        result = result.filter(x=>x.name.toLowerCase().includes(query.search));
    }

    if(query.from){
        result = result.filter(x=>Number(x.level) >= query.from);
    }

    if(query.to){
        result = result.filter(x=>Number(x.level) >= query.to);
    }

    return result;
}

function getById(id){
   return productsData.find(x=>x.id == id);
}

function create(data, callback) {

    let cube = new Cube(uniqueId(), data.name, data.description, data.imageUrl, data.difficultyLevel);

    productsData.push(cube);

    fs.writeFile(path.join(__dirname, '/../config/products.json'), JSON.stringify(productsData), callback);
}

module.exports = { create, getAll, getById }