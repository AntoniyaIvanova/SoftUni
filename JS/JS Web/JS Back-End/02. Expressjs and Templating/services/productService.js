const Cube = require('../models/Cube');

async function getAll(query){
    let products = await Cube.find({}).lean();

    if(query.search){
        products = result.filter(x=>x.name.toLowerCase().includes(query.search));
    }

    if(query.from){
        products = result.filter(x=>Number(x.level) >= query.from);
    }

    if(query.to){
        products = result.filter(x=>Number(x.level) >= query.to);
    }

    return products;
}

function getById(id){    
    return Cube.findById(id).lean();
}

function create(data) {

    let cube = new Cube(data);

   return cube.save();
}

module.exports = { create, getAll, getById }