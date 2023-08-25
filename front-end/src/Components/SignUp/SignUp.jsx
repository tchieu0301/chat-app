import axios from "axios";
import { useRef } from "react";
import { useNavigate } from "react-router-dom";
export default function SignUp() {
  const fnameRef = useRef(null);
  const lnameRef = useRef(null);
  const emailRef = useRef(null);
  const unameRef = useRef(null);
  const passwordRef = useRef(null);
  const repasswordRef = useRef(null);
  const navigate = useNavigate();
  async function Register() {
    if (repasswordRef.current.value === passwordRef.current.value) {
      await axios
        .post("http://localhost:5294/account", {
          firstname: fnameRef.current.value,
          lastname: lnameRef.current.value,
          email: emailRef.current.value,
          username: unameRef.current.value,
          password: passwordRef.current.value,
        })
        .then(alert("Sign Up Successful"))
        .then(navigate("/Login"));
    }
  }
  return (
    <div className="background">
      <div className="center w-2/5 rounded-lg py-10 bg-white">
        <h1 className="text-center text-2xl font-bold mb-7">Sign Up</h1>
        <form>
          <div className="block justify-center w-4/5 ml-auto mr-auto">
            <label>First Name</label>
            <input
              ref={fnameRef}
              className="block border-b-2 py-2 mb-2 w-full"
              type="text"
              placeholder="Name"
            />
            <label>Last Name</label>
            <input
              ref={lnameRef}
              className="block border-b-2 py-2 mb-2 w-full"
              type="text"
              placeholder="Name"
            />
            <label>Email</label>
            <input
              ref={emailRef}
              className="block border-b-2 py-2 mb-2 w-full"
              type="text"
              placeholder="Email Address"
            />
            <label>Username</label>
            <input
              ref={unameRef}
              className="block border-b-2 py-2 mb-2 w-full"
              type="text"
              placeholder="Username..."
            />
            <label>Password</label>
            <input
              ref={passwordRef}
              className="block border-b-2 py-2 mb-2 w-full"
              type="password"
              placeholder="********"
            />
            <label>Re-Password</label>
            <input
              ref={repasswordRef}
              className="block border-b-2 py-2 mb-2 w-full"
              type="password"
              placeholder="********"
            />
            <button
              onClick={Register}
              className="block justify-center mt-5 ml-auto mr-auto border-solid border-2 border-black w-24 rounded-md"
            >
              Sign Up
            </button>
          </div>
        </form>
      </div>
    </div>
  );
}
