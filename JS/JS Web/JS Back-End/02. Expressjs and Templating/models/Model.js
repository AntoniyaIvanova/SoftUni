const fs = require('fs/promises');
const path = require('path');
const productsDB = require('../config/products.json');


class Model{
    save(){
        productsDB.push(this);

        return fs.writeFile(
            path.join(__dirname, '../config/products.json'),
            JSON.stringify(productsDB)
        );
    }
    
    static getAll(){
        return productsDB;
    }

    static getOne(id){
        return productsDB.find(x=>x.id == id);
    }
}

module.exports = Model;