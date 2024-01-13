import {BaseUrl} from '../constants/Paths';

export const createUpdateRating = async (userId, movieId, rating) => {

    const httpHeaders = {
        method: 'POST',
        headers: {
            'content-type': 'application/json',
        },
        body: JSON.stringify(userId, movieId, rating)
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

export const getRating = async (userId, movieId) => {
    const response = await fetch(`${BaseUrl}/ratings/${userId}/${movieId}`);
    const result = await response.json();    
    if (!response.ok) {
        throw result;
    }
    return result;
}

// export const updateRating = async (userId, movieId, rating) =>{
//     const httpHeaders = {
//         method: 'PUT',
//         headers: {
//             'content-type': 'application/json',
//         },
//         body: JSON.stringify(userId, movieId, rating)
//     }

//     const token = JSON.parse(localStorage.getItem("auth"))?.token;
//     if (token) {
//         httpHeaders.headers = {
//             ...httpHeaders.headers,
//             "Authorization": `Bearer ${token}`
//         }
//     }
//     const response = await fetch(`${BaseUrl}/ratings/${userId}/${movieId}`, httpHeaders);
//     const result = await response.json();
//     if (!response.ok) {
//         throw result;
//     }

//     return result;
// }