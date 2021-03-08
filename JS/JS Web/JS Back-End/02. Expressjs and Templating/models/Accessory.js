const mongoose = require('mongoose');

const accessorySchema = new mongoose.Schema({
    id: mongoose.Types.ObjectId,
    name: {
        type: String,
        required: true,
    },
    description: {
        type: String,
        required: true,
        maxlength: 50,
    },
    imageUrl: {
        type: String,
        required: true,
        validate: /^https?$/
    },
    difficultyLevel: {
        type: Number, 
        require: true,
        min: 1, 
        max: 6,
    },
})


module.exports = mongoose.model('Accessory', accessorySchema);