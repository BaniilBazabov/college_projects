import React, { Component } from "react";
import { Link } from "react-router-dom";
import axios from 'axios';

var Therapist = props => {
<tr>
    <td>{props.therapist.Title}</td>
    <td>{props.therapist.FirstName}</td>
    <td>{props.therapist.LastName}</td>
    <td>{props.therapist.Mobile}</td>
    <td>{props.therapist.Email}</td>
    <td>{props.therapist.AL1}</td>
    <td>{props.therapist.AL2}</td>
    <td>{props.therapist.Town}</td>
    <td>{props.therapist.City}</td>
    <td>{props.therapist.Eircode}</td>
    <td>
        <Link to={"./edit/"+props.therapist._id}>edit</Link> | <button onClick={() => {props.deleteTherapist(props.therapist._id) }}>delete</button>
    </td>
</tr>
}





class Therapists extends Component {
    constructor(props){
        super(props);

        this.deleteTherapist = this.deleteTherapist.bind(this);

        this.state = {therapists: []};
    }

    componentDidMount(){
        axios.get('http://localhost:8000/therapists')
            .then(res => {
                console.log(res);
                this.setState({therapists:res.data})
            })
            .catch((error) =>{
                console.log(error);
            })
    }

    deleteTherapist(id) {
        axios.delete('http://localhost:8000/therapists/' +id)
        .then(res => console.log(res.data));

        this.setState({
            therapists: this.state.therapists.filter(el => el._id !==id)
        })
    }

    therapistsList() {
        return this.state.therapists.map(currentTherapist =>{
            return <Therapist therapist ={currentTherapist} 
            deleteTherapist = {this.deleteTherapist} 
            key={currentTherapist._id}/>;
        })
    }

    render(){
        return (
            <div>
                <h3>Therapists</h3>
                <table className="Table">
                    <thead className="thead-light">
                        <tr>
                            <th>Title</th>
                            <th>FirstName</th>
                            <th>LastName</th>
                            <th>Mobile</th>
                            <th>Email</th>
                            <th>Address Line 1</th>
                            <th>Address Line 2</th>
                            <th>Town</th>
                            <th>City</th>
                            <th>Eircode</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.therapistsList()} 
                    </tbody>
                </table>
            </div>
        )
    }
}
export default Therapists;
