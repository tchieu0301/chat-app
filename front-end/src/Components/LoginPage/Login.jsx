import React from "react";
//import { Col, Row } from "react-bootstrap";
import Form from "react-bootstrap/form";
import { Button } from "react-bootstrap";
import "./Login.css";
import { useNavigate } from "react-router-dom";
export default function LoginPage() {
  const navigate = useNavigate();
  const changeToSignUp = () => {
    navigate("/Register");
  }
  return (
    <>
      <div className="fullscreen">
        <div className="center">
          <div className="center-child">
            <h1 className="login-label">Login</h1>
            <Form>
              <Form.Group>
                <Form.Label className="label">Username</Form.Label>

                <Form.Control
                  className="input"
                  type="email"
                  placeholder="Enter your email"
                />
              </Form.Group>
              <Form.Group>
                <Form.Label className="label">Password</Form.Label>
                <Form.Control
                  className="input"
                  type="password"
                  placeholder="Enter your password"
                />
                <div className="forgot">
                  <Form.Text>Forgot password ?</Form.Text>
                </div>
              </Form.Group>
              <Button className="button" type="submit">
                LOGIN
              </Button>
              <div className="sign-up">
                <p>Don't have any account ?</p>
                <Button className="button-register" onClick={changeToSignUp}>SIGN UP</Button>
              </div>
            </Form>
          </div>
        </div>
      </div>
    </>
  );
}
