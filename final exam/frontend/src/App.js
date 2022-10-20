import React from "react";
import {BrowserRouter as Router, Routes, Route} from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css";
import  Navbar  from "./Components/navbar.component";
import  Therapists  from "./Components/therapists.component";
import  CreateTherapists  from "./Components/createTherapist.component";
import  Custs from "./Components/custs.component";
import  CreateCusts from "./Components/createCust.component";
import  Sessions from "./Components/session.component";
import  CreateSession from "./Components/createSession.component";
import EditTherapists from "./Components/editTherapist.component";


function App() {
  return (
    <Router>
      <Navbar />
      <Routes>

      <Route exact path="/"  element= {<Therapists/>} ></Route>
      <Route path="/createTherapist"  element= {<CreateTherapists/>}></Route>
      <Route path="/edit/:id" component={<EditTherapists />}></Route>
      <Route path="/custs" element={<Custs />}></Route>
      <Route path="/createCust" element={<CreateCusts />}></Route>
      <Route path="/sessions" element={<Sessions />}></Route>
      <Route path="/createSession" element={<CreateSession />}></Route>

      </Routes>
      
    </Router>
  );
}

export default App;
