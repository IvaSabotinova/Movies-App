import { useContext, useEffect, useState } from 'react';
import { Form } from 'react-bootstrap';

import './Home.css';

import MovieContext from '../../contexts/MovieContext';
import * as genreService from '../../services/genreService';

import MovieItem from './MovieItem';
import Loader from '../loader/Loader';

export default function Home() {
    const { movies, isLoading } = useContext(MovieContext);
    const [genres, setGenres] = useState([]);
    const [filters, setFilters] = useState({
        searchTerm: '',
        genreId: '',
        sort: ''
    })
    const [filteredSortedMovies, setFilteredSortedMovies] = useState(movies);

    useEffect(() => {
        genreService.getAllGenres()
            .then(setGenres)
    }, []);

    const changeHandler = (e) => {
        setFilters(state => ({ ...state, [e.target.name]: e.target.value }))
    }

    useEffect(() => {
        let updatedMovies = [...movies];

        if (filters.searchTerm) {
            updatedMovies = updatedMovies.filter(movie => movie.title.toLowerCase().includes(filters.searchTerm.toLowerCase()));
        }

        if (filters.genreId) {
            updatedMovies = updatedMovies.filter(movie => movie.genreId === filters.genreId);

        }
        if (filters.sort === 'A-Z') {
            updatedMovies.sort((a, b) => a.title.localeCompare(b.title));

        }
        if (filters.sort === 'Z-A') {
            updatedMovies.sort((a, b) => b.title.localeCompare(a.title));

        }
        setFilteredSortedMovies(updatedMovies)
    }, [filters, movies]);

    return (
        <>
            <div className="wrapper">
                <div className="select">
                    <select className="form-control mt-1 mb-1 form-select select-genre"
                        style={{ width: "200px" }}
                        id="genreId"
                        name="genreId"
                        required
                        value={filters.genreId}
                        onChange={changeHandler}
                    >
                        <option value="" disabled="">Search By Genre</option>
                        {genres.map(genre => (
                            <option key={genre.value} value={genre.value}>{genre.text}</option>
                        ))}
                    </select>

                    <Form className="d-flex col-3 mt-2 mb-1">
                        <Form.Control
                            style={{ height: "37.5px" }}
                            type="search"
                            placeholder="Search movie by title"
                            className="me-2"
                            aria-label="Search"
                            name="searchTerm"
                            value={filters.searchTerm}
                            onChange={changeHandler}
                        />
                        <span style={{ position: "relative", left: "-60px", top: "7px" }}>
                            <i className="bi bi-search"></i>
                        </span>                  
                    </Form>

                    <select className="form-control mt-1 mb-1 form-select select-sort"
                        name="sort"
                        id="sort"
                        value={filters.sort}
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
                    {!isLoading && filteredSortedMovies.length === 0 && <p className="no-movies">No movies found by these criteria!</p>}
                    {!isLoading && filteredSortedMovies.length > 0 && filteredSortedMovies.map(movie => (<MovieItem
                        key={movie.id}
                        {...movie} />))}
                </div>

            </div>
        </>
    );
}