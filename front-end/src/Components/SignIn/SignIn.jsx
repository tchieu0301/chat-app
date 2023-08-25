import "./SignIn.css";
import { useNavigate } from "react-router-dom";
export default function SignIn() {
  const navigate = useNavigate(null);
  function toSignUp() {
    navigate("/SignUp");
  }
  return (
    <div className="background">
      <div className="center w-2/5 rounded-lg py-10 bg-white">
        <h1 className="text-center text-2xl font-bold mb-7">Login</h1>
        <form>
          <div className="block justify-center w-4/5 ml-auto mr-auto">
            <label>Username</label>
            <input
              className="block border-b-2 py-2 mb-2 w-full"
              type="text"
              placeholder="Type your Username"
            />
            <label>Password</label>
            <input
              className="block border-b-2 py-2 mb-2 w-full"
              type="password"
              placeholder="Type your Password"
            />
            <p className="font-light text-right">Forgot password ?</p>
            <button className="block justify-center mt-5 ml-auto mr-auto border-solid border-2 border-black w-24 rounded-md">
              Sign In
            </button>
            {/* <p className="font-light text-center mt-10">Or Sign Up With</p> */}
            <button
              onClick={toSignUp}
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
