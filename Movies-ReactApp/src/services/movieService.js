import { BaseUrl } from '../../src/constants/Paths';

export const getAllMovies = async () => {
    const response = await fetch(`${BaseUrl}/movies`);
    const result = response.json();
    if (!response.ok) {
        throw result;
    }
    return result;
}