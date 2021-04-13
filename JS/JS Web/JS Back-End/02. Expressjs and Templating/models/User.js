const mongoose = require('mongoose');

const userSchema = new mongoose.Schema({
    id: mongoose.Types.ObjectId,
    username: {
        type: String,
        required: true,
        unique: true,
        minlength: 5,
        validate: {
            validator: (value) => {
                return /^[A-Za-z0-9]+$/.test(value);
            },
            message: (props) => {
                return `${props.value} is invalid username. Username should consist of English letters and numbers.`
            }
        }
    },
    password: {
        type: String,
        required: true,
        minlength: 8,
        validate: {
            validator: (value) => {
                return /^[A-Za-z0-9]+$/.test(value);
            },
            message: (props) => {
                return `${props.value} is invalid username. Username should consist of English letters and numbers.`
            }
        }
    }
});

module.exports = mongoose.model('User', userSchema);