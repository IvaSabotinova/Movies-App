import { useState, useRef, useEffect, useContext } from 'react';
import { Link, useNavigate } from 'react-router-dom';

import './Register.css';

import Paths from '../../constants/Paths';
import AuthContext from '../../context/AuthContext';

const RegisterFormKeys = {
  Username: 'username',
  Email: 'email',
  Password: 'password',
  ConfirmPassword: 'confirmPassword',
};

const Register = (

) => {
  const { registerSubmitHandler } = useContext(AuthContext)
  const [formValues, setFormValues] = useState({
    [RegisterFormKeys.Username]: '',
    [RegisterFormKeys.Email]: '',
    [RegisterFormKeys.Password]: '',
    [RegisterFormKeys.ConfirmPassword]: '',
  });

  const [errors, setErrors] = useState({
    [RegisterFormKeys.Username]: '',
    [RegisterFormKeys.Email]: '',
    [RegisterFormKeys.Password]: '',
    [RegisterFormKeys.ConfirmPassword]: '',
  })

  const navigate = useNavigate();

  const usernameRef = useRef();

  useEffect(() => {
    usernameRef.current.focus();
  }, [])

  const validateUsername = () => {
    if (formValues.username.length < 3 || formValues.username.length > 30) {
      setErrors(state => ({ ...state, [RegisterFormKeys.Username]: 'Username must be between 3 and 30 characters!' }))
    }
    else {
      setErrors(state => ({ ...state, [RegisterFormKeys.Username]: '' }))
    }
  };

  const validateEmail = () => {
    const emailRegex = /^[a-zA-Z0-9._+-]{2,}@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    const isValidEmail = emailRegex.test(formValues.email);
    if (!isValidEmail) {
      setErrors(state => ({ ...state, [RegisterFormKeys.Email]: 'Email address is not valid!' }))
    } else if (formValues.email.length < 5 || formValues.email.length > 330) {
      setErrors(state => ({ ...state, [RegisterFormKeys.Email]: 'Email address must be between 5 and 330 characters!' }))
    } else {
      setErrors(state => ({ ...state, [RegisterFormKeys.Email]: '' }));
    }
  }

  const validatePassword = () => {
    if (formValues.password.length < 6 || formValues.password.length > 30) {
      setErrors(state => ({ ...state, [RegisterFormKeys.Password]: 'Password must be between 6 and 30 characters!' }))
    } else {
      setErrors(state => ({ ...state, [RegisterFormKeys.Password]: '' }));
    }
  }

  const validateConfirmPassword = () => {
    if (formValues.password !== formValues[RegisterFormKeys.ConfirmPassword]) {
      setErrors(state => ({ ...state, [RegisterFormKeys.ConfirmPassword]: 'Passwords do not match!' }))
    } else {
      setErrors(state => ({ ...state, [RegisterFormKeys.ConfirmPassword]: '' }));
    }
  }

  const changeHandler = (e) => {
    setFormValues(state => ({ ...state, [e.target.name]: e.target.value }))

  }

  const registerHandler = async (e) => {
    e.preventDefault();
    validateUsername();
    validateEmail();
    validatePassword();
    validateConfirmPassword();

    if (errors.username != ''
      || errors.email != ''
      || errors.password != ''
      || errors[RegisterFormKeys.ConfirmPassword] != ''
      || Object.keys(formValues).some(key => formValues[key] === '')) {

      return;
    }
    try {
      registerSubmitHandler(formValues)
      navigate(Paths.Home)
    } catch (err) {
      console.log(err)
    }


  }

  return (
    <div className="register-div">
      <h2>Register</h2>
      <form className="register-form" onSubmit={registerHandler}>
        <label htmlFor="username">Username:</label>
        <input
          type="text"
          className="username"
          name={RegisterFormKeys.Username}
          placeholder="Username"
          value={formValues.username}
          onChange={changeHandler}
          onBlur={validateUsername}
          ref={usernameRef}
        />
        {errors.username && (<p className="errorMessage">{errors.username}</p>)}
        <label htmlFor="email">Email:</label>
        <input
          type="email"
          className="email"
          name={RegisterFormKeys.Email}
          placeholder="Email Address"
          value={formValues.email}
          onChange={changeHandler}
          onBlur={validateEmail}
        />
        {errors.email && (<p className="errorMessage">{errors.email}</p>)}
        <label htmlFor="password">Password:</label>
        <input
          type="password"
          className="password"
          name={RegisterFormKeys.Password}
          placeholder="Enter your password"
          value={formValues.password}
          onChange={changeHandler}
          onBlur={validatePassword}
        />
        {errors.password && (<p className="errorMessage">{errors.password}</p>)}
        <label htmlFor="confirmPassword">Repeat password:</label>
        <input
          type="password"
          className="confirmPassword"
          name={RegisterFormKeys.ConfirmPassword}
          placeholder="Repeat your password"
          value={formValues[RegisterFormKeys.ConfirmPassword]}
          onChange={changeHandler}
          onBlur={validateConfirmPassword}
        />

        {errors[RegisterFormKeys.ConfirmPassword] && (<p className="errorMessage">{errors[RegisterFormKeys.ConfirmPassword]}</p>)}

        <input type="submit" className="register" value="Register" />
      </form>
      <div className="have-account">
        <p>Already have an account? <Link className='link-to-login' to={Paths.Login}>Login</Link></p>
      </div>
    </div>
  );
}

export default Register;
