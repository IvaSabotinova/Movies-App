import { useContext, useEffect } from "react";
import { useNavigate } from 'react-router-dom';

import AuthContext from "../../context/AuthContext";
import * as authService from '../../services/authService';
import Paths from "../../constants/Paths";

export default function Logout() {
    const { logOutHandler } = useContext(AuthContext);
    const navigate = useNavigate();

    useEffect(() => {
        authService.Logout()
            .then(() => {
                logOutHandler();
                navigate(Paths.Home)
            })
            .catch(() => {
                logOutHandler();
                navigate(Paths.Home)
            })
    }, [])
    return null;

}