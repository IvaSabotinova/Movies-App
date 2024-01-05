
import { BaseUrl } from "../constants/Paths";

export const getAllGenres = async () => {
    const response = await fetch(`${BaseUrl}/genres`);
    const result = await response.json();    
    return result;
}