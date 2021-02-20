const uniqueId = require('uniqId');
const Cube = require('../models/Cube');
const fs = require('fs');
const path = require('path');

let productsData = require('../config/products.json');

function getAll(){
    return productsData;
}

function create(data) {

    let cube = new Cube(uniqueId(), data.title, data.description, data.imageUrl, data.difficultyLevel);

    productsData.push(cube);

    fs.writeFile(__dirname + '/../config/products.json', JSON.stringify(productsData), (err)=>{
        if(err){
            console.log(err);
            return;
        }
    })
}



module.exports = { create, getAll }