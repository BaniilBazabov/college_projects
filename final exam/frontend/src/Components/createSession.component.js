import React, { Component } from "react";
import axios from 'axios';

export default class CreateSession extends Component {
    constructor(props){
        super(props);


        this.state = {
        Date : '',
        Time: '',
        Client1: '',
        Client2: '',
        Client3:'' ,
        Therapist: '',
        Fee: '',
        SessionNum: '',
        Attendance:'',
        Type: '',
        Notes: ''
        }
        this.onChangeDate = this.onChangeDate.bind(this);
        this.onChangeTime = this.onChangeTime.bind(this);
        this.onChangeClient1 = this.onChangeClient1.bind(this);
        this.onChangeClient2 = this.onChangeClient2.bind(this);
        this.onChangeClient3 = this.onChangeClient3.bind(this);
        this.onChangeTherapist = this.onChangeTherapist.bind(this);
        this.onChangeFee = this.onChangeFee.bind(this);
        this.onChangeSessionNum = this.onChangeSessionNum.bind(this);
        this.onChangeAttendance = this.onChangeAttendance.bind(this);
        this.onChangeType = this.onChangeType.bind(this);
        this.onChangeNotes = this.onChangeNotes.bind(this);
        this.onSubmit = this.onSubmit.bind(this);
    }
    onChangeDate(e){
        this.setState({
            Date: e.target.value
        });
    }
    onChangeTime(e){
        this.setState({
            Time: e.target.value
        });
    }
    onChangeClient1(e){
        this.setState({
            Client1: e.target.value
        });
    }
    onChangeClient2(e){
        this.setState({
            Client2: e.target.value
        });
    }
    onChangeClient3(e){
        this.setState({
            Client3: e.target.value
        });
    }
    onChangeTherapist(e){
        this.setState({
            Therapist: e.target.value
        });
    }
    onChangeFee(e){
        this.setState({
            Fee: e.target.value
        });
    }
    onChangeSessionNum(e){
        this.setState({
            SessionNum: e.target.value
        });
    }
    onChangeAttendance(e){
        this.setState({
            Attendance: e.target.value
        });
    }
    onChangeType(e){
        this.setState({
            Type: e.target.value
        });
    }
    onChangeNotes(e){
        this.setState({
            Notes: e.target.value
        })
    }
    onSubmit(e){
        e.preventDefault();
        const user = {
        Date: this.state.Date,
        Time: this.state.Time,
        Client1: this.state.Client1,
        Client2: this.state.Client2,
        Client3: this.state.Client3,
        Therapist: this.state.Therapist,
        Fee: this.state.Fee,
        SessionNum:this.state.SessionNum,
        Attendance:this.state.Attendance,
        Type:this.state.Type,
        Notes: this.state.Notes
        }

        console.log(user);

        axios.post('http://localhost:8000/sessions', user)
            .then(res => console.log(res.data));
        this.setState({
        Date : '' ,
        Time: '',
        Client1: '',
        Client2: '',
        Client3: '',
        Therapist: '',
        Fee: '',
        SessionNum:'',
        Attendance:'',
        Type:'',
        Notes:''
        })
    }
    render(){
        return (
            <div>
                <h2>Add a session to the Database!</h2>
                <form onSubmit={this.onSubmit}>
                    <div className="form-group">
                    <label>Date</label>
                    <input id="Date" name="Date" value={this.state.Date}  onChange={this.onChangeDate} required ></input>
                    </div>
                    

                    <div className="form-group">
                    <label>Time</label>
                    <input id="Time" name="Time" value={this.state.Time} onChange={this.onChangeTime} required></input>
                    </div>
                    
                    <div className="form-group">
                    <label>Client 1</label>
                    <input id="Client1" name="Client1" value={this.state.Client1} onChange={this.onChangeClient1} required></input>
                    </div>
                    
                    
                    <div className="form-group">
                    <label>Client 2</label>
                    <input id="Client2" name="Client2" value={this.state.Client2} onChange={this.onChangeClient2} ></input>
                    </div>
                    
                    
                    <div className="form-group">
                    <label>Client 3</label>
                    <input id="Client3" name="Client3" value={this.state.Client3} onChange={this.onChangeClient3} ></input>
                    </div>
                    
                    
                    <div className="form-group">
                    <label>Therapist</label>
                    <input id="Therapist" name="Therapist" value={this.state.Therapist} onChange={this.onChangeTherapist} required></input>
                    </div>
                    
                    <div className="form-group">
                    <label>€Fee</label>
                    <input id="Fee" name="Fee" value={this.state.Fee} onChange={this.onChangeFee}></input>
                    </div>
                    
                    
                    <div className="form-group">
                    <label>Session Number</label>
                    <input id="SessionNum" name="SessionNum" value={this.state.SessionNum} onChange={this.onChangeSessionNum} required></input>
                    </div>
                    
                    
                    <div className="form-group">
                    <label>Session Attendance</label>
                    <select id="Attendance" name="Attendance" value={this.state.Attendance} onChange={this.onChangeAttendance} required>
                    <option value="Attended" >Attended</option>
                    <option value="Cancelled">Cancelled</option>
                    <option value="No show">No show</option>
                    </select>
                    </div>

                    <div className="form-group">
                    <label>Session Type</label>
                    <select id="Type" name="Type" value={this.state.Type} onChange={this.onChangeType} required>
                    <option value="Intake" >Intake</option>
                    <option value="Psychotherapy">Psychotherapy</option>
                    <option value="Assessment">Assessment</option>
                    <option value="Other">Other</option>
                    </select>
                    </div>
                    
                    
                    <div className="form-group">
                    <label>Notes</label>
                    <input id="Notes" name="Notes" value={this.state.Notes} onChange={this.onChangeNotes} ></input>
                    </div>
                    
                    <div className="form-group">
                        <input type="submit" value="Add The Session!" className="btn btn-primary"></input>
                    </div>

                </form>
            </div>
        )
    }
};

