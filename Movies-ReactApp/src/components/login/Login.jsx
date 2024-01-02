import {Link} from 'react-router-dom'

import './Login.css';

import Paths from '../../constants/Paths';

const Login = () => {
    return (
        <div className="login-div">
        <h2>Login</h2>

        <form className="login-form">
            <label htmlFor="username">Username:</label>
            <input
                type="text"
                className="username"
                name="username"
                placeholder="Username"
                data-testid="username"
             //   value={loginFormData.email}
              //  onChange={addLoginData}
             //   onBlur={onBlurHandler}
            />
            {/* {errors.email && (
                <p className='create-error'>Invalid email!</p>
            )} */}

            <label htmlFor="password">Password:</label>
            <input
                type="password"
                className="password"
                name="password"
                placeholder="Enter your password"
                data-testid="password"
            //    value={loginFormData.password}
            //    onChange={addLoginData}
             //   onBlur={onBlurHandler}
            />
            {/* {errors.password && (
                <p className='create-error'>Password must be between 3 and 10 characters!</p>
            )}
            {errors && (
                <h2 className='create-error'>{errors.serverError}</h2>
            )} */}
            <input
                type="submit"
                className="login"
                value="Login"
                data-testid="login-button" />
        </form>
        <div className="not-have-account">
            <p>Do not have an account? <Link className='link-to-register' to={Paths.Register}>Register</Link></p>
        </div>
    </div>
    );
}

export default Login;