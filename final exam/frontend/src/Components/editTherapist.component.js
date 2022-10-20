import React, { Component } from "react";
import axios from 'axios';

export default class EditTherapists extends Component {
    constructor(props){
        super(props);


        this.state = {
        Title : '',
        FirstName: '',
        LastName: '',
        Mobile: '',
        Email:'' ,
        AL1: '',
        AL2: '',
        Town: '',
        City:'',
        Eircode: ''
        }
        this.onChangeTitle = this.onChangeTitle.bind(this);
        this.onChangeFirstName = this.onChangeFirstName.bind(this);
        this.onChangeLastName = this.onChangeLastName.bind(this);
        this.onChangeMobile = this.onChangeMobile.bind(this);
        this.onChangeEmail = this.onChangeEmail.bind(this);
        this.onChangeAL1 = this.onChangeAL1.bind(this);
        this.onChangeAL2 = this.onChangeAL2.bind(this);
        this.onChangeCity = this.onChangeCity.bind(this);
        this.onChangeTown = this.onChangeTown.bind(this);
        this.onChangeEircode = this.onChangeEircode.bind(this);
        this.onSubmit = this.onSubmit.bind(this);

    }
    componentDidMount(){
        axios.get('http://localhost:8000/therapists'+this.props.match.params.id)
        .then(res=>{
            this.setState({
            Title: res.data.Title,
            FirstName: res.data.FirstName,
            LastName: res.data.LastName,
            Mobile: res.data.Mobile,
            Email: res.data.Email,
            AL1: res.data.AL1,
            AL2: res.data.AL2,
            Town:res.data.Town,
            City:res.data.City,
            Eircode:res.data.Eircode
            })
        })
        .catch(function(error){
            console.log(error);
        })

        axios.get('http://localhost:8000/therapists')
        .then(res => {
            if(res.data.length>0){
                this.setState({
                    therapists: res.data.map(therapist => therapist.FirstName),
                })
            }
        })
    }
    onChangeTitle(e){
        this.setState({
            Title: e.target.value
        });
    }
    onChangeFirstName(e){
        this.setState({
            FirstName: e.target.value
        });
    }
    onChangeLastName(e){
        this.setState({
            LastName: e.target.value
        });
    }
    onChangeMobile(e){
        this.setState({
            Mobile: e.target.value
        });
    }
    onChangeEmail(e){
        this.setState({
            Email: e.target.value
        });
    }
    onChangeAL1(e){
        this.setState({
            AL1: e.target.value
        });
    }
    onChangeAL2(e){
        this.setState({
            AL2: e.target.value
        });
    }
    onChangeTown(e){
        this.setState({
            Town: e.target.value
        });
    }
    onChangeCity(e){
        this.setState({
            City: e.target.value
        });
    }
    onChangeEircode(e){
        this.setState({
            Eircode: e.target.value
        })
    }
    onSubmit(e){
        e.preventDefault();
        const user = {
        Title: this.state.Title,
        FirstName: this.state.FirstName,
        LastName: this.state.LastName,
        Mobile: this.state.Mobile,
        Email: this.state.Email,
        AL1: this.state.AL1,
        AL2: this.state.AL2,
        Town:this.state.Town,
        City:this.state.City,
        Eircode:this.state.Eircode
        }

        console.log(user);

        axios.post('http://localhost:8000/Therapists/update' + this.props.match.params.id, user)
            .then(res => console.log(res.data));

        this.setState({
        Title : '' ,
        FirstName: '',
        LastName: '',
        Mobile: '',
        Email: '',
        AL1: '',
        AL2: '',
        Town:'',
        City:'',
        Eircode:''
        })
    }
    render(){
        return (
            <div>
                <h2>Edit a therapist to the Database!</h2>
                <form onSubmit={this.onSubmit}>
                    <div className="form-group">
                        <label>Title: </label>
                        <select id="Title" name="Title"  value={this.state.Title} onChange={this.onChangeTitle} required>
                        <option value="Mr">Mr</option>
                        <option value="Mrs">Mrs</option>
                        <option value="Mx">Mx</option>
                        <option value="Ms">Ms</option>
                        <option value="Miss">Miss</option>
                        <option value="Dr">Dr</option>
                        <option value="Other">Other</option>
                        </select>
                        </div>

                        <div className="form-group">
                        <label>First Name</label>
                        <input id="FirstName" name="FirstName" value={this.state.FirstName} onChange={this.onChangeFirstName} required></input>
                        </div>
                        
                        <div className="form-group">
                        <label>Last Name</label>
                        <input id="LastName" name="LastName" value={this.state.LastName} onChange={this.onChangeLastName} required></input>
                        </div>
                        
                        
                        <div className="form-group">
                        <label>Mobile number</label>
                        <input id="Mobile" name="Mobile" value={this.state.Mobile} onChange={this.onChangeMobile} required></input>
                        </div>
                        
                        
                        <div className="form-group">
                        <label>Email</label>
                        <input id="Email" name="Email" value={this.state.Email} onChange={this.onChangeEmail} required></input>
                        </div>
                        
                        
                        <div className="form-group">
                        <label>Address Line 1</label>
                        <input id="AL1" name="AL1" value={this.state.AL1} onChange={this.onChangeAL1} required></input>
                        </div>
                        
                        <div className="form-group">
                        <label>Address Line 2</label>
                        <input id="AL2" name="AL2" value={this.state.AL2} onChange={this.onChangeAL2}></input>
                        </div>
                        
                        
                        <div className="form-group">
                        <label>Town</label>
                        <input id="Town" name="Town" value={this.state.Town} onChange={this.onChangeTown} required></input>
                        </div>
                        
                        
                        <div className="form-group">
                        <label>City/County</label>
                        <input id="City" name="City" value={this.state.City} onChange={this.onChangeCity} required></input>
                        </div>
                        
                        
                        <div className="form-group">
                        <label>EIRCODE</label>
                        <input id="Eircode" name="Eircode" value={this.state.Eircode} onChange={this.onChangeEircode} ></input>
                        </div>
                        
                        <div className="form-group">
                            <input type="submit" value="Edit The Therapist!" className="btn btn-primary"></input>
                        </div>

                </form>
            </div>
        )
    }
};

