import { BaseUrl } from '../constants/Paths';

const authUrl = `${BaseUrl}/auth`;

export const Register = async (username, email, password, confirmPassword) => {
    const httpHeaders = {
        method: 'POST',
        headers: {
            'content-type': 'application/json',
        },
        body: JSON.stringify({ username, email, password, confirmPassword })
    }
    const response = await fetch(`${authUrl}/register`, httpHeaders);
    const result = await response.json();
    console.log(result)
    if (!response.ok) {
        throw result;
    }

    return result;

}

export const Login = async (username, password) => {
    const httpHeaders = {
        method: 'POST',
        headers: {
            'content-type': 'application/json',
        },
        body: JSON.stringify({ username, password })
    }
    const response = await fetch(`${authUrl}/login`, httpHeaders);
    const result = await response.json();
    console.log(result)
    if (!response.ok) {
        throw result;
    }
    return result;

}

export const Logout = () => fetch(`${authUrl}/logout`, {
    method: 'GET',
    headers: {
        'content-type': 'application/json',
    }
})