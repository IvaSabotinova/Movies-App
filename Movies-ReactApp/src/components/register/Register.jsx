import { Link } from 'react-router-dom';

import './Register.css';

import Paths from '../../constants/Paths';

const Register = (

) => {

  return (
    <div className="register-div">
      <h2>Register</h2>
      <form className="register-form">
      <label htmlFor="username">Username:</label>
        <input
          type="text"
          className="username"
          name="username"
          placeholder="Username"
        //   value={registerFormData.username}
        //   onChange={addRegisterData}
        //   onBlur={onBlurHandler}
        />
        {/* {errors.username && (
              <p className='create-error'>Username must be between 3 and 10 characters!</p>
          )} */}
        <label htmlFor="email">Email:</label>
        <input
          type="email"
          className="email"
          name="email"
          placeholder="Email Address"
        //  value={registerFormData.email}
        //  onChange={addRegisterData}
        //   onBlur={onBlurHandler}
        />
        {/* {errors.email && (
              <p className='create-error'>Invalid email</p>
          )} */}
        
        <label htmlFor="password">Password:</label>
        <input
          type="password"
          className="password"
          name="password"
          placeholder="Enter your password"
        // value={registerFormData.password}
        //  onChange={addRegisterData}
        // onBlur={onBlurHandler}
        />
        {/* {errors.password && (
              <p className='create-error'>Password must be between 3 and 10 characters!</p>
          )} */}
        <label htmlFor="repassword">Repeat password:</label>
        <input
          type="password"
          className="repassword"
          name="repassword"
          placeholder="Repeat your password"
        //  value={registerFormData.repass}
        //   onChange={addRegisterData}
        //   onBlur={onBlurHandler}
        />

        {/* {errors.repass && (
              <p className='create-error'>Password dismatch!</p>
          )}

          {errors && (
              <h2 className='create-error'>{errors.serverError}</h2>
          )} */}

        <input type="submit" className="register" value="Register" />
      </form>
      <div className="have-account">
        <p>Already have an account? <Link className='link-to-login' to={Paths.Login}>Login</Link></p>
      </div>
    </div>
  );
}

export default Register;
