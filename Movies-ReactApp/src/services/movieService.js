import { BaseUrl } from '../../src/constants/Paths';

export const createMovie = async (data) => {

    const httpHeaders = {
        method: 'POST',
        headers: {
            'content-type': 'application/json',
        },
        body: JSON.stringify(data)
    }

    const token = JSON.parse(localStorage.getItem("auth"))?.token;
    if (token) {
        httpHeaders.headers = {
            ...httpHeaders.headers,
            "Authorization": `Bearer ${token}`
        }
    }

    const response = await fetch(`${BaseUrl}/movies`, httpHeaders);
    const result = await response.json();
    if (!response.ok) {
        throw result;
    }

    return result;
}

export const getAllMovies = async () => {
    const response = await fetch(`${BaseUrl}/movies`);
    const result = response.json();
    if (!response.ok) {
        throw result;
    }
    return result;
}

export const getMovieDetails = async (movieId) => {
    const response = await fetch(`${BaseUrl}/movies/${movieId}`);
    const result = response.json();
    if (!response.ok) {
        throw result;
    }
    return result;
}

export const updateMovie = async (movieId, movieData) =>{
    const httpHeaders = {
        method: 'PUT',
        headers: {
            'content-type': 'application/json',
        },
        body: JSON.stringify(movieData)
    }

    const token = JSON.parse(localStorage.getItem("auth"))?.token;
    if (token) {
        httpHeaders.headers = {
            ...httpHeaders.headers,
            "Authorization": `Bearer ${token}`
        }
    }
    const response = await fetch(`${BaseUrl}/movies/${movieId}`, httpHeaders);
    const result = await response.json();
    if (!response.ok) {
        throw result;
    }

    return result;
}

export const deleteMovie = async (movieId) =>{
    const httpHeaders = {
        method: 'DELETE'
    }

    const token = JSON.parse(localStorage.getItem("auth"))?.token;
    if (token) {
        httpHeaders.headers = {
            ...httpHeaders.headers,
            "Authorization": `Bearer ${token}`
        }
    }

    const response = await fetch(`${BaseUrl}/movies/${movieId}`, httpHeaders);
    const result = await response.json();   
    if (!response.ok) {
        throw result;
    }

    return result;

}