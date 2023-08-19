import SignIn from "./Components/SignIn/SignIn";
import "./App.css";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import SignUp from "./Components/SignUp/SignUp";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/Login" element={<SignIn/>}></Route>
        <Route path="/SignUp" element={<SignUp/>}></Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
