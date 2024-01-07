import { useContext, useEffect } from "react";
import { useNavigate } from 'react-router-dom';

import AuthContext from "../../contexts/AuthContext";
import * as authService from '../../services/authService';
import Paths from "../../constants/Paths";
import ToastNotify from "../../toast/ToastNotify";

export default function Logout() {
    const { logOutHandler } = useContext(AuthContext);
    const navigate = useNavigate();

    useEffect(() => {
        authService.Logout()
            .then(() => {
                logOutHandler();
                ToastNotify("User logged out successfully!", "success") 
                navigate(Paths.Home)
            })
            .catch(() => {
                logOutHandler();
                ToastNotify("Failed to log out!", "error") 
                navigate(Paths.Home)
            })
    }, [])
    return null;

}