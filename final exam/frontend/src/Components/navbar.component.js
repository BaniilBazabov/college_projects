import React,{Component} from "react";
import { Link } from "react-router-dom";

export default class Navbar extends Component{

    render(){
        return (
            <nav className="navbar navbar-dark bg-dark navbar-expand-lg">
                <Link to="/" className="navbar-brand">Navigation Bar</Link>
                <div className="collapse navbar-collapse">
                    <ul className="navbar-nav mr-auto">
                        <li className="navbar-item">
                        <Link to="/" className="nav-link">Therapists</Link>
                        </li>
                        <li className="navbar-item">
                        <Link to="/createTherapist" className="nav-link"> Create Therapist</Link>
                        </li>
                        <li className="navbar-item">
                        <Link to="/custs" className="nav-link">Customers</Link>
                        </li>
                        <li className="navbar-item">
                        <Link to="/createCust" className="nav-link"> Create Customer</Link>
                        </li>
                        <li className="navbar-item">
                        <Link to="sessions" className="nav-link">Sessions</Link>
                        </li>
                        <li className="navbar-item">
                        <Link to="/createSession" className="nav-link"> Create Session</Link>
                        </li>
                        
                    </ul>
                </div>
            </nav>
        )
    }
}