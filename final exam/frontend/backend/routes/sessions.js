const express = require('express');
const router = express.Router();
const Session = require('../models/Session');
//get all the sessions
router.get('/', async (req,res) => {
    try{
        const sessions = await Session.find();
        res.json(sessions);
}   catch (err){
        res.json({message :err});
}   
});

//add a session to the database
router.post('/', async (req,res) =>{
    const sessions = new Session({
        
        Date : req.body.Date,
        Time: req.body.Time,
        Client1: req.body.Client1,
        Client2: req.body.Client2,
        Client3: req.body.Client3,
        Therapist: req.body.Therapist,
        Fee: req.body.Fee,
        SessionNum: req.body.SessionNum,
        Attendance: req.body.Attendance,
        Type: req.body.Type,
        Notes: req.body.Notes
    });
    try { //submits session
        const sessionPosted = await sessions.save();
        res.json(sessionPosted);
    } catch (err) { //catches error
        res.json({ message: err});
    }
});

//find a session by specific session by ID
router.get('/:sessionId', async (req,res)=>{
    try{
    const session = await Session.findById(req.params.sessionId)  //finds session by ID
    res.json(session);
    } catch(err){ //catches error
        res.json({message: err});
    } 
})

//delete specific session by ID
router.delete('/:sessionId', async (req,res) => {
    try{
        const removedSession = await Session.deleteOne({_id: req.params.sessionId}) //deletes session with specific ID
        res.json(removedSession);
        } catch(err){ //catches error
            res.json({message: err});
        }
});

//update session
router.patch('/:sessionId', async (req,res) =>{
    try{
        const updatedSession = await Session.updateOne({_id: req.params.sessionId}, {$set: {SessionNum: req.body.SessionNum}}); //updates the session's SessionNum by ID
        res.json(updatedSession);
    }
        catch(err){ //catches error
            res.json({message: err});
        }
})
module.exports = router;