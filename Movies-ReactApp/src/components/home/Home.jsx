import { useContext, useEffect, useState } from 'react';

import './Home.css';

import MovieContext from '../../contexts/MovieContext';
import * as genreService from '../../services/genreService';

import MovieItem from './MovieItem';
import Loader from '../loader/Loader';

export default function Home() {
    const { movies, isLoading } = useContext(MovieContext);
    const [genres, setGenres] = useState([]);
    const [selectedGenreId, setSelectedGenreId] = useState("");
    const [filteredMovies, setFilteredMovies] = useState(movies);

    useEffect(() => {
        genreService.getAllGenres()
            .then(setGenres)
    }, []);


    const changeGenreHandler = (e) => {
        const selectedId = e.target.value;
        setSelectedGenreId(selectedId);
    }

    useEffect(() => {
        // If no genre is selected, show all movies
        if (!selectedGenreId) {
            setFilteredMovies(movies);
        } else {
            // Filter movies based on the selected genre
            const filteredByGenre = movies.filter(movie => movie.genreId === selectedGenreId);
            setFilteredMovies(filteredByGenre);
        }
    }, [selectedGenreId, movies]);

    return (
        <>
            <div className="wrapper">
                <div>
                    <select className="form-control mt-1 mb-1 form-select"
                        style={{ width: "200px" }}
                        id="genreId"
                        name="genreId"
                        required
                        value={selectedGenreId}
                        onChange={changeGenreHandler}                   
                    >
                        <option value="" disabled="">Search By Genre</option>
                        {genres.map(genre => (
                            <option key={genre.value} value={genre.value}>{genre.text}</option>
                        ))}
                    </select>
                </div>
                <div className="main">
                    {isLoading && <Loader />}
                    {!isLoading && filteredMovies.map(movie => (<MovieItem
                        key={movie.id}
                        {...movie} />))}
                </div>

            </div>
        </>
    );
}