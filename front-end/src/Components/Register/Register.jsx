import React from "react";
//import { Col, Row } from "react-bootstrap";
import Form from "react-bootstrap/form";
import { Button } from "react-bootstrap";
import "./Register.css";
import { useNavigate } from "react-router-dom";

export default function Register() {
    const navigate = useNavigate();
    const isSignup = () => {
        navigate("/LoginPage");
    }
  return (
    <>
      <div className="fullscreen">
        <div className="center">
          <div className="center-child">
            <h1 className="login-label">Sign up</h1>
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
                  name="password"
                />
              </Form.Group>
              <Form.Group>
                <Form.Label className="label">Re-password</Form.Label>
                <Form.Control
                  className="input"
                  type="password"
                  placeholder="Check password"
                  name="rePassword"
                />
              </Form.Group>
              <Form.Group>
                <Form.Label className="label">Phone number</Form.Label>
                <Form.Control
                  className="input"
                  type="email"
                  placeholder="Enter your phone number"
                />
              </Form.Group>
              <Button className="button" type="submit" onClick={isSignup}>
                SIGN UP
              </Button>
            </Form>
          </div>
        </div>
      </div>
    </>
  );
}
