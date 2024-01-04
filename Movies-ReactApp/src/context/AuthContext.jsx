import { createContext } from 'react';
import { useNavigate } from 'react-router-dom';

import useLocalStorage from '../hooks/useLocalStorage';
import * as authService from '../services/authService';
import Paths from '../constants/Paths';
import ToastNotify from '../toast/ToastNotify';


const AuthContext = createContext();

AuthContext.displayName = 'AuthContext';

export const AuthProvider = ({
    children
}) => {
    const [auth, setAuth] = useLocalStorage('auth', {});
    const navigate = useNavigate();

    const registerSubmitHandler = async (data) => {          
        try {
            const result = await authService.Register(data.username, data.email, data.password, data.confirmPassword);  
            ToastNotify('User registered successfully!', 'success');
            navigate(Paths.Login);
        } catch (err) {
            console.log("Registration failed", err);
            ToastNotify(err.errorMessages[1], 'error');
        }    
       
    }

    const loginSubmitHandler = async (data) => {
        try {
            const result = await authService.Login(data.username, data.password);
            setAuth(result.result);        
            ToastNotify("User logged in successfully!", "success")            
            navigate(Paths.Home)
        } catch (err) {
            console.log("Login failed:", err); 
            ToastNotify(err.errorMessages[0], "error")     
            navigate(Paths.Register)   
        }
    }

    const logOutHandler = ()=>{
        setAuth({});       
        navigate(Paths.Home)
    }

    const contextValues = {
        registerSubmitHandler,
        loginSubmitHandler,
        logOutHandler,
        userId: auth.id,
        email: auth.email,
        username: auth.username,
        token: auth.token,
        isAuthenticated: !!auth.token
    }

    return (
        <AuthContext.Provider value={contextValues}>
            {children}
        </AuthContext.Provider>
    );

}

export default AuthContext;