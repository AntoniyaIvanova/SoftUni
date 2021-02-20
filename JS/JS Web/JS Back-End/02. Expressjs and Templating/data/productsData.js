const fs = require('fs');
const path = require('path');

const productsDB = require('../config/products.json');

module.exports = {
    create(cube){

        productsDB.push(cube);

        return fs.writeFile(
            path.join(__dirname, '../config/products.json'),
            JSON.stringify(productsDB)
        );
    },
    getAll(){
        return productsDB;
    },
    getOne(id){
        return productsDB.filter(x=>x.id == id);
    }

}