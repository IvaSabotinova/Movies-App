import { useContext, useState } from 'react';
import { Link, useNavigate } from 'react-router-dom'

import './Login.css';

import Paths from '../../constants/Paths';
import AuthContext from '../../context/AuthContext';

const LoginFormKeys = {
    Username: 'username',
    Password: 'password'
}

const Login = () => {
    const { loginSubmitHandler } = useContext(AuthContext)
    const [formValues, setFormValues] = useState({
        [LoginFormKeys.Username]: '',
        [LoginFormKeys.Password]: ''
    });

    const [errors, setErrors] = useState({
        [LoginFormKeys.Username]: '',
        [LoginFormKeys.Password]: ''
    });

    const navigate = useNavigate();

    const validateUsername = () => {
        if (formValues.username.length < 3 || formValues.username.length > 30) {
            setErrors(state => ({ ...state, [LoginFormKeys.Username]: 'Username must be between 3 and 30 characters!' }))
        }
        else {
            setErrors(state => ({ ...state, [LoginFormKeys.Username]: '' }))
        }
    };

    const validatePassword = () => {
        if (formValues.password.length < 6 || formValues.password.length > 30) {
            setErrors(state => ({ ...state, [LoginFormKeys.Password]: 'Password must be between 6 and 30 characters!' }))
        } else {
            setErrors(state => ({ ...state, [LoginFormKeys.Password]: '' }));
        }
    }

    const changeHandler = (e) => {
        setFormValues(state => ({ ...state, [e.target.name]: e.target.value }))
    }

    const loginHandler = async (e) => {
        e.preventDefault();
        validateUsername();
        validatePassword();

        if (errors.username != ''
            || errors.password != ''
            || Object.keys(formValues).some(key => formValues[key] === '')) {

            return;
        }
        try {
           loginSubmitHandler(formValues);
            navigate(Paths.Home)
        } catch (err) {
            console.log(err)
        }

    }

    return (
        <div className="login-div">
            <h2>Login</h2>

            <form className="login-form" onSubmit={loginHandler}>
                <label htmlFor="username">Username:</label>
                <input
                    type="text"
                    className="username"
                    name={LoginFormKeys.Username}
                    placeholder="Username"
                    value={formValues.username}
                    onChange={changeHandler}
                    onBlur={validateUsername}
                />
                {errors.username && (<p className="errorMessage">{errors.username}</p>)}

                <label htmlFor="password">Password:</label>
                <input
                    type="password"
                    className="password"
                    name={LoginFormKeys.Password}
                    placeholder="Enter your password"
                    value={formValues.password}
                    onChange={changeHandler}
                    onBlur={validatePassword}
                />
                {errors.password && (<p className="errorMessage">{errors.password}</p>)}
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