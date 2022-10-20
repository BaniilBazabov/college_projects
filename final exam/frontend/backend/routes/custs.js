const express = require('express');
const router = express.Router();
const Cust = require('../models/Cust');
var today = new Date();
var date = today.getFullYear()+'-'+(today.getMonth()+1)+'-'+today.getDate();
var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
var dateTime = date+' '+time;

//get all the customers
router.get('/', async (req,res) => {
    try{
        const custs = await Cust.find();
        res.json(custs);
}   catch (err){
        res.json({message :err});
}   
});
//add a customer to the database
router.post('/', async (req,res) =>{
    const custs = new Cust({
        
        Title : req.body.Title,
        FirstName: req.body.FirstName,
        LastName: req.body.LastName,
        Mobile: req.body.Mobile,
        Email: req.body.Email,
        AL1: req.body.AL1,
        AL2: req.body.AL2,
        Town: req.body.Town,
        City: req.body.City,
        Eircode: req.body.Eircode,
        DOB: req.body.DOB,
        Parent: req.body.Parent,
        Permission: req.body.Permission,
        Gender: req.body.Gender,
        Marital: req.body.Marital,
        Reference: req.body.Reference ,
        SubDate: dateTime
    });
    try { //submits customer
        const custPosted = await custs.save();
        res.json(custPosted);
    } catch (err) { //catches error
        res.json({ message: err});
    }
});
//find a customer by specific customer by ID
router.get('/:custId', async (req,res)=>{
    try{
    const cust = await Cust.findById(req.params.custId)  //finds customer by ID
    res.json(cust);
    } catch(err){ //catches error
        res.json({message: err});
    } 
})

//delete specific customer by ID
router.delete('/:custId', async (req,res) => {
    try{
        const removedCust = await Cust.deleteOne({_id: req.params.custId}) //deletes customer with specific ID
        res.json(removedCust);
        } catch(err){ //catches error
            res.json({message: err});
        }
});

//update customer
router.patch('/:custId', async (req,res) =>{
    try{
        const updatedCust = await Cust.updateOne({_id: req.params.custId}, {$set: {FirstName: req.body.FirstName}}); //updates the customer's FirstName by ID
        res.json(updatedCust);
    }
        catch(err){ //catches error
            res.json({message: err});
        }
})
module.exports = router;