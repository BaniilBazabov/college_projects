const express = require('express');
const router = express.Router();
const Therapist = require('../models/Therapist');
//get all the therapists
router.get('/', async (req,res) => {
    try{
        const therapists = await Therapist.find();
        res.json(therapists);
}   catch (err){
        res.json({message :err});
}   
});

//add a therapist to the database
router.post('/', async (req,res) =>{
    const therapists = new Therapist({
        
        Title : req.body.Title,
        FirstName: req.body.FirstName,
        LastName: req.body.LastName,
        Mobile: req.body.Mobile,
        Email: req.body.Email,
        AL1: req.body.AL1,
        AL2: req.body.AL2,
        Town: req.body.Town,
        City: req.body.City,
        Eircode: req.body.Eircode
    });
    try { //submits therapist
        const therapistPosted = await therapists.save();
        res.json(therapistPosted);
    } catch (err) { //catches error
        res.json({ message: err});
    }
});

//find a therapist by specific therapist by ID
router.get('/:therapistId', async (req,res)=>{
    try{
    const therapist = await Therapist.findById(req.params.therapistId)  //finds therapist by ID
    res.json(therapist);
    } catch(err){ //catches error
        res.json({message: err});
    } 
})

//delete specific therapist by ID
router.delete('/:therapistId', async (req,res) => {
    try{
        const removedTherapist = await Therapist.deleteOne({_id: req.params.therapistId}) //deletes therapist with specific ID
        res.json(removedTherapist);
        } catch(err){ //catches error
            res.json({message: err});
        }
});

//update therapist
router.patch('/:therapistId', async (req,res) =>{
    try{
        const updatedTherapist = await Therapist.updateOne({_id: req.params.therapistId}, {$set: {FirstName: req.body.FirstName}}); //updates the therapist's FirstName by ID
        res.json(updatedTherapist);
    }
        catch(err){ //catches error
            res.json({message: err});
        }
})
module.exports = router;