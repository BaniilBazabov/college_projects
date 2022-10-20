const express = require('express');
const app = express();
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
const cors = require('cors');
require('dotenv/config');
app.use(bodyParser.json());
app.use(cors());
app.use(bodyParser.urlencoded({ extended: true }));


//API routes
const therapistRoute = require('./routes/therapists');
app.use('/therapists', therapistRoute); //everything that has to do with therapists is done here @routes/therapists.js

const custRoute = require('./routes/custs');
app.use('/custs', custRoute); //everything that has to do with customers is done here @routes/custs.js

const sessionRoute = require('./routes/sessions');
app.use('/sessions', sessionRoute); //everything that has to do with sessions is done here @routes/sessions.js

mongoose.connect(process.env.db_connection, ()=>
    console.log('Connected to MongoDB')
);
app.listen(8000,() =>{
    console.log('Listening at localhost:8000')
})