import React, { Component } from "react";
import axios from 'axios';

export default class CreateCusts extends Component {
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
        Eircode: '',
        DOB: '',
        Parent: '',
        Permission: '',
        Gender: '',
        Marital: '',
        Reference: ''
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
        this.onChangeDOB = this.onChangeDOB.bind(this);
        this.onChangeParent = this.onChangeParent.bind(this);
        this.onChangePermission = this.onChangePermission.bind(this);
        this.onChangeGender = this.onChangeGender.bind(this);
        this.onChangeMarital = this.onChangeMarital.bind(this);
        this.onChangeReference = this.onChangeReference.bind(this);
        
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
    onChangeDOB(e){
        this.setState({
            DOB: e.target.value
        })
    }
    onChangeParent(e){
        this.setState({
            Parent: e.target.value
        })
    }
    onChangePermission(e){
        this.setState({
            Permission: e.target.value
        })
    }
    onChangeGender(e){
        this.setState({
            Gender: e.target.value
        })
    }
    onChangeMarital(e){
        this.setState({
            Marital: e.target.value
        })
    }
    onChangeReference(e){
        this.setState({
            Reference: e.target.value
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
        Eircode:this.state.Eircode,
        DOB:this.state.DOB,
        Parent:this.state.Parent,
        Permission:this.state.Permission,
        Gender:this.state.Gender,
        Marital:this.state.Marital,
        Reference:this.state.Reference
        }
        

        console.log(user);

        axios.post('http://localhost:8000/custs', user)
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
        Eircode:'',
        DOB:'',
        Parent:'',
        Permission:'',
        Gender:'',
        Marital:'',
        Reference:'',
        
        })
    }
    render(){
        return (
            
            <div>
                <h2>Add a customer to the Database!</h2>
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
                    <label>Date Of Birth</label>
                    <input id="DOB" name="DOB" value={this.state.DOB}  onChange={this.onChangeDOB} required ></input>
                    </div>

                    <div className="form-group">
                    <label>If under 18 (otherwise ignore), do you have parent's/guardian's permission?</label>
                    <select id="Parent" name="Parent" value={this.state.Parent} placeholder="-" onChange={this.onChangeParent} required>
                    <option value="-" >-</option>
                    <option value="Yes">Yes</option>
                    <option value="No">No</option>
                    </select>
                    </div>

                    <div className="form-group">
                    <label>Permission	to	leave	message	by	Phone	or	Email</label>
                    <select id="Permission" name="Permission" value={this.state.Permission}  onChange={this.onChangePermission} required>
                    <option value="Yes">Yes</option>
                    <option value="No">No</option>
                    </select>
                    </div>

                    <div className="form-group">
                    <label>Gender</label>
                    <input id="Gender" name="Gender" value={this.state.Gender}  onChange={this.onChangeGender} required ></input>
                    </div>

                    <div className="form-group">
                    <label>Marital Status</label>
                    <select id="Marital" name="Marital" value={this.state.Marital}  onChange={this.onChangeMarital} required>
                    <option value="Never Married">Never Married</option>
                    <option value="Domestic	Partnership">Domestic	Partnership</option>
                    <option value="Married">Married</option>
                    <option value="Separated">Separated</option>
                    <option value="Divorced">Divorced</option>
                    <option value="Widowed">Widowed</option>
                    </select>
                    </div>
                    
                    <div className="form-group">
                    <label>Referrer</label>
                    <input id="Reference" name="Reference" value={this.state.Reference}  onChange={this.onChangeReference}  ></input>
                    </div>
                    
                    <div className="form-group">
                        <input type="submit" value="Add The Customer!" className="btn btn-primary"></input>
                    </div>

                </form>
            </div>
        )
    }
}

