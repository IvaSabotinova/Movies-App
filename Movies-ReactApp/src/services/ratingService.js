import { BaseUrl } from '../constants/Paths';

const createUpdateRating = async (userId, movieId, rating, method) => {
    const httpHeaders = {
        method,
        headers: {
            'content-type': 'application/json',
        },
        body: JSON.stringify({ applicationUserId: userId, movieId, rating })
    }

    const token = JSON.parse(localStorage.getItem("auth"))?.token;
    if (token) {
        httpHeaders.headers = {
            ...httpHeaders.headers,
            "Authorization": `Bearer ${token}`
        }
    }

    const response = await fetch(`${BaseUrl}/ratings`, httpHeaders);
    const result = await response.json();
    if (!response.ok) {
        throw result;
    }

    return result;
}

export const createRating = async (userId, movieId, rating) => {
    return createUpdateRating(userId, movieId, rating, 'POST')
}

export const updateRating = async (userId, movieId, rating) => {
    return createUpdateRating(userId, movieId, rating, 'PATCH');
}

//checks if a a user with userId has voted for movie with movieId
// and returns true or false
export const getRating = async (userId, movieId) => {
    const response = await fetch(`${BaseUrl}/ratings/${userId}/${movieId}`);
    const result = await response.json();
    console.log(result)
    if (!response.ok) {
        throw result;
    }
    return result;
}



