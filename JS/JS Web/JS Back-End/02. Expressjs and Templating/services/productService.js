const uniqueId = require('uniqId');
const Cube = require('../models/Cube');
const fs = require('fs');
const path = require('path');

let productsData = require('../config/products.json');

function getAll(){
    return productsData;
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