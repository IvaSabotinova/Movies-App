import { useState, useEffect } from 'react';

import './Home.css';

import * as movieService from '../../services/movieService';

import MovieItem from './MovieItem';
import Loader from '../loader/Loader';

export default function Home() {
    const [movies, setMovies] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    useEffect(() => {
        movieService.getAllMovies()
            .then((res) => {
                setIsLoading(false);
                setMovies(res.result)
            });
    }, [])

    return (
        <>
            <div className="wrapper">
                {isLoading && <Loader/>}
                {!isLoading && movies.map(movie => (<MovieItem
                    key={movie.id}
                    {...movie} />))}
            </div>
        </>
    );
}