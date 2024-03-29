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
    const [isLoadingMovies, setIsLoadingMovies] = useState(true);
    const [apiResponse, setApiResponse] = useState({});
    const navigate = useNavigate();

    const fetchMovies = (page, itemsPerPage, searchTerm, genreIdFilter, sort) => {
        movieService.getAllMovies(page, itemsPerPage, searchTerm, genreIdFilter, sort)
            .then((res) => {
                setIsLoadingMovies(false);
                setApiResponse(res.result)
            })
            .catch((err) => {
                console.error("Error fetching movies:", err);
            });
    }

    useEffect(() => {
        fetchMovies(1, 4, '', '', '');
    }, []);

    const createMovieHandler = async (movie) => {
        const newMovie = await movieService.createMovie(movie);
        fetchMovies(1, 4, '', '', '');
        ToastNotify("Movie created successfully!", "success");
        navigate(pathToUrl(Paths.MovieDetails, { movieId: newMovie.result.id }))
    }

    const updateMovieHandler = async (movieId, movie) => {
        const editedMovie = await movieService.updateMovie(movieId, movie);
        fetchMovies(1, 4, '', '', '');
        ToastNotify("Movie updated successfully!", "success");
        navigate(pathToUrl(Paths.MovieDetails, { movieId }))
    }

    const deleteMovieHandler = async (movieId) => {
        await movieService.deleteMovie(movieId);
        fetchMovies(1, 4, '', '', '');
    }

    const movieContextValues = {
        apiResponse,
        isLoadingMovies,
        createMovieHandler,
        updateMovieHandler,
        deleteMovieHandler,
        fetchMovies
    }

    return (
        <MovieContext.Provider value={movieContextValues}>
            {children}
        </MovieContext.Provider>
    );
}

export default MovieContext;