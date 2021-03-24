  
const Accessory = require('../models/Accessory');

function getAll() {
    return Accessory.find().lean();
}

function getAllUnattached(ids) {
    return Accessory.find({ _id: {$nin: ids} }).lean();
}

function create(data) {
    let accessory = new Accessory(data);

    return accessory.save();
}

function getById(id){    
    return Accessory.findById(id).lean();
}

module.exports = {
    getById,
    getAll,
    getAllUnattached,
    create,
};