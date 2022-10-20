const mongoose = require('mongoose');

const CustSchema = mongoose.Schema({
    Title: {
        type: String,
        required : true
    },

    FirstName: {
        type: String,
        required: true
    },

    LastName: {
        type: String,
        required: true
    },

    Mobile: {
        type: String,
        required: true
    },

    Email: {
        type: String,
        required: true
    },

    AL1: {
        type: String,
        required: true
    },

    AL2: {
        type: String,
    },

    Town: {
        type: String,
        required: true
    },

    City: {
        type: String,
        required: true
    },

    Eircode: {
        type: String,
    },
    DOB: {
        type: String,
        required: true
    },
    Parent: {
        type: String,
        required: true
    },
    Permission: {
        type: String,
        required: true
    },
    Gender:{
        type:String,
        required: true
    },
    Marital: {
        type:String,
        required: true
    },
    Reference: {
        type: String
    },
    

})
module.exports = mongoose.model('Custs', CustSchema);