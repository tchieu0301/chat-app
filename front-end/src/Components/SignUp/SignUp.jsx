export default function SignUp(){
    return (
        <div className="background">
          <div className="center w-2/5 rounded-lg py-10 bg-white">
            <h1 className="text-center text-2xl font-bold mb-7">Sign Up</h1>
            <form>
              <div className="block justify-center w-4/5 ml-auto mr-auto">
                <label>First Name</label>
                <input
                  className="block border-b-2 py-2 mb-2 w-full"
                  type="text"
                  placeholder="Name"
                />
                <label>Last Name</label>
                <input
                  className="block border-b-2 py-2 mb-2 w-full"
                  type="text"
                  placeholder="Name"
                />
                <label>Email</label>
                <input
                  className="block border-b-2 py-2 mb-2 w-full"
                  type="text"
                  placeholder="Email Address"
                />
                <label>Username</label>
                <input
                  className="block border-b-2 py-2 mb-2 w-full"
                  type="text"
                  placeholder="Username..."
                />
                <label>Password</label>
                <input
                  className="block border-b-2 py-2 mb-2 w-full"
                  type="password"
                  placeholder="********"
                />
                <label>Re-Password</label>
                <input
                  className="block border-b-2 py-2 mb-2 w-full"
                  type="password"
                  placeholder="********"
                />
                <button className="block justify-center mt-5 ml-auto mr-auto border-solid border-2 border-black w-24 rounded-md">
                  Sign Up
                </button>
              </div>
            </form>
          </div>
        </div>
    )
}