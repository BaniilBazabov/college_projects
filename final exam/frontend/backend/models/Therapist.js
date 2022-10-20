const mongoose = require('mongoose');

const TherapistSchema = mongoose.Schema({
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
    }

})
module.exports = mongoose.model('Therapists', TherapistSchema);