const mongoose = require('mongoose');

const SessionSchema = mongoose.Schema({
    Date: {
        type: String,
        required: true
    },
    Time: {
        type: String,
        required: true
    },
    Client1: {
        type: String,
        required: true
    },
    Client2: {
        type: String
        
    },
    Client3: {
        type: String
        
    },
    Therapist: {
        type: String,
        required: true
    },
    Fee: {
        type: String,
        required: true
    },
    SessionNum: {
        type: String,
        required: true
    },
    Attendance : {
        type: String,
        required: true
    },
    Type : {
        type: String,
        required: true
    },
    Notes : {
        type: String,
        required: true
    },

    
    

})
module.exports = mongoose.model('Sessions', SessionSchema);