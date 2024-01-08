import { useContext, useEffect, useState } from 'react';

import './Home.css';

import MovieContext from '../../contexts/MovieContext';
import * as genreService from '../../services/genreService';

import MovieItem from './MovieItem';
import Loader from '../loader/Loader';

export default function Home() {
    const { movies, isLoading } = useContext(MovieContext);
    const [genres, setGenres] = useState([]);
    const [selected, setSelected] = useState({
        genreId: '',
        sort: ''
    })
    const [filteredSortedMovies, setFilteredSortedMovies] = useState(movies);

    useEffect(() => {
        genreService.getAllGenres()
            .then(setGenres)
    }, []);


    const changeHandler = (e) => {
        setSelected(state => ({ ...state, [e.target.name]: e.target.value }))
    }

    useEffect(() => {
        let updatedMovies = [...movies];

        if (selected.genreId) {
            updatedMovies = updatedMovies.filter(movie => movie.genreId === selected.genreId);

        }
        if (selected.sort === 'A-Z') {
            updatedMovies.sort((a, b) => a.title.localeCompare(b.title));

        }
        if (selected.sort === 'Z-A') {
            updatedMovies.sort((a, b) => b.title.localeCompare(a.title));

        }
        setFilteredSortedMovies(updatedMovies)
    }, [selected, movies]);

    return (
        <>
            <div className="wrapper">
                <div className="select">
                    <select className="form-control mt-1 mb-1 form-select select-genre"
                        style={{ width: "200px" }}
                        id="genreId"
                        name="genreId"
                        required
                        value={selected.genreId}
                        onChange={changeHandler}
                    >
                        <option value="" disabled="">Search By Genre</option>
                        {genres.map(genre => (
                            <option key={genre.value} value={genre.value}>{genre.text}</option>
                        ))}
                    </select>
                    <select className="form-control mt-1 mb-1 form-select select-sort"
                        name="sort"
                        id="sort"
                        value={selected.sort}
                        onChange={changeHandler}
                        style={{ width: "200px" }}
                    >
                        <option value="" disabled="">Sort Alphabetically</option>
                        <option value="A-Z" disabled="">Name A-Z</option>
                        <option value="Z-A" disabled="">Name Z-A</option>
                    </select>
                </div>
                <div className="main">
                    {isLoading && <Loader />}
                    {!isLoading && filteredSortedMovies.map(movie => (<MovieItem
                        key={movie.id}
                        {...movie} />))}
                </div>

            </div>
        </>
    );
}