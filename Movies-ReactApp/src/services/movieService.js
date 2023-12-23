import { BaseUrl } from '../../src/constants/Paths';

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