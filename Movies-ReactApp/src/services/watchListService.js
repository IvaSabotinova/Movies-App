import { BaseUrl } from "../constants/Paths";

export const addToWatchList = async (userId, movieId) => {
    const httpHeaders = {
        method: 'POST',
        headers: {
            'content-type': 'application/json',
        },
        body: JSON.stringify({ applicationUserId: userId, movieId })
    }

    const token = JSON.parse(localStorage.getItem("auth"))?.token;
    if (token) {
        httpHeaders.headers = {
            ...httpHeaders.headers,
            "Authorization": `Bearer ${token}`
        }
    }

    const response = await fetch(`${BaseUrl}/watchList`, httpHeaders);
    const result = await response.json();
    if (!response.ok) {
        throw result;
    }

    return result;
}

export const getWatchList = async (userId) => {
    const httpHeaders = {};

    const token = JSON.parse(localStorage.getItem("auth"))?.token;
    if (token) {
        httpHeaders.headers = {
            "Authorization": `Bearer ${token}`
        }
    }
    const response = await fetch(`${BaseUrl}/watchList/${userId}`, httpHeaders);
    const result = await response.json();
    if (!response.ok) {
        throw result;
    }

    return result;
}


export const deleteMovieFromWatchList = async (userId, movieId)=>{
    const httpHeaders = {
        method: 'DELETE',
        headers: {
            'content-type': 'application/json',
        },
        body: JSON.stringify({ applicationUserId: userId, movieId })
    }

    const token = JSON.parse(localStorage.getItem("auth"))?.token;
    if (token) {
        httpHeaders.headers = {
            ...httpHeaders.headers,
            "Authorization": `Bearer ${token}`
        }
    }

    const response = await fetch(`${BaseUrl}/watchList`, httpHeaders);
    const result = await response.json();
    if (!response.ok) {
        throw result;
    }

    return result;
}