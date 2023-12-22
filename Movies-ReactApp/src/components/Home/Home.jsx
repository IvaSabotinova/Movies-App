import { useState, useEffect } from 'react';

import './Home.css';

import * as movieService from '../../services/movieService';

import MovieItem from './MovieItem';

export default function Home() {
    const [movies, setMovies] = useState([]);
    useEffect(() => {
        movieService.getAllMovies()
            .then((res) => setMovies(res.result));
    }, [])
   
    return (
        <>
            <div className="wrapper">
                {movies.map(movie => (<MovieItem
                    key={movie.id}
                    {...movie} />))}
            </div>
        </>
    );
}