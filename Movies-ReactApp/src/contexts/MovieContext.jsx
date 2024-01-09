import { createContext, useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";

import * as movieService from '../services/movieService';
import ToastNotify from "../toast/ToastNotify";
import { pathToUrl } from "../utils/pathsUtil";
import Paths from "../constants/Paths";


const MovieContext = createContext();

MovieContext.displayName = 'MovieContext';

export const MovieProvider = ({
    children
}) => {
    const [movies, setMovies] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const navigate = useNavigate();

    const fetchMovies = () => {
        movieService.getAllMovies()
            .then((res) => {
                setIsLoading(false);
                setMovies(res.result);        
            });
    }

    useEffect(() => {
        fetchMovies();
    }, []);

    const createMovieHandler = async (movie) => {
        const newMovie = await movieService.createMovie(movie);
        console.log(newMovie);
        fetchMovies();
        ToastNotify("Movie created successfully!", "success");
        navigate(pathToUrl(Paths.MovieDetails, { movieId: newMovie.result.id }))
    }

    const updateMovieHandler = async (movieId, movie) => {
        const editedMovie = await movieService.updateMovie(movieId, movie);
        console.log(editedMovie);
        fetchMovies();
        ToastNotify("Movie updated successfully!", "success");
        navigate(pathToUrl(Paths.MovieDetails, { movieId }))
    }

    const deleteMovieHandler = async (movieId) => {
        await movieService.deleteMovie(movieId);
        fetchMovies();
    }

    const movieContextValues = {
        movies,
        isLoading,
        createMovieHandler,
        updateMovieHandler,
        deleteMovieHandler,
    }

    return (
        <MovieContext.Provider value={movieContextValues}>
            {children}
        </MovieContext.Provider>
    );
}

export default MovieContext;