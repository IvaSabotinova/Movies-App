import { useContext, useEffect, useState } from 'react';
import { Form } from 'react-bootstrap';

import './Home.css';

import MovieContext from '../../contexts/MovieContext';
import * as genreService from '../../services/genreService';

import MovieItem from './MovieItem';
import Loader from '../loader/Loader';

export default function Home() {
    const { apiResponse, isLoading, fetchMovies } = useContext(MovieContext);
    const [genres, setGenres] = useState([]);
    const [filters, setFilters] = useState({
        searchTerm: '',
        genreId: '',
        sort: ''
    });
    const [pageOptions, setPageOptions] = useState({
        page: 1,
        pageSize: 4
    })

    useEffect(() => {
        genreService.getAllGenres()
            .then(setGenres)
    }, []);

    const changeHandler = (e) => {
        setFilters(state => ({ ...state, [e.target.name]: e.target.value }))
    }

    useEffect(() => {
        fetchMovies(pageOptions.page, pageOptions.pageSize, filters.searchTerm, filters.genreId, filters.sort);
    }, [pageOptions, filters]);

    const getPageDetails = () => {
        const currentPageStartNumber = (pageOptions.page - 1) * pageOptions.pageSize + 1;
        const currentPageEndNumber = pageOptions.page * pageOptions.pageSize;
        return `${currentPageStartNumber} - ${currentPageEndNumber < apiResponse.allItemsCount ? currentPageEndNumber : apiResponse.allItemsCount} of ${apiResponse.allItemsCount}`
    };

    const handleDirection = (direction) => {
        if (direction === 'prev') {
            setPageOptions(state => ({ ...state, page: pageOptions.page - 1 }))
        } else if (direction === 'next') {
            setPageOptions(state => ({ ...state, page: pageOptions.page + 1 }))
        }
    }

    const pageSizeChangeHandler = (e) => {
        const newPageSize = Number(e.target.value);
        setPageOptions({ page: 1, pageSize: newPageSize });
    }

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
                    {!isLoading && apiResponse.movies.length === 0 && <p className="no-movies">No movies found by these criteria!</p>}
                    {!isLoading && apiResponse.movies.length > 0 && (
                        <>
                            {apiResponse.movies.map(movie => (<MovieItem
                                key={movie.id}
                                {...movie} />))}

                            < div className="d-flex mx-5 justify-content-end align-items-center">
                                <div>Rows per page:  </div>
                                <div>
                                    <select name="pageSize" id="pageSize"
                                        className="form-select mx-2"
                                        style={{ width: "80px" }}
                                        value={pageOptions.pageSize}
                                        onChange={pageSizeChangeHandler}
                                    >
                                        <option value="4">4</option>
                                        <option value="8">8</option>
                                        <option value="12">12</option>
                                        <option value="16">16</option>
                                    </select>
                                </div>
                                <div className="mx-2">{getPageDetails()}</div>
                                <button
                                    onClick={() => handleDirection("prev")}
                                    disabled={!apiResponse.hasPreviousPage}
                                    className="btn btn-outline-info px-3 mx-2"
                                >
                                    <i className="bi bi-chevron-left"></i>
                                </button>
                                <button
                                    onClick={() => handleDirection("next")}
                                    disabled={!apiResponse.hasNextPage}
                                    className="btn btn-outline-info px-3 mx-2"
                                >
                                    <i className="bi bi-chevron-right"></i>
                                </button>
                            </div>
                        </>
                    )}
                </div>
            </div>
        </>
    );
}