import { useContext } from 'react';

import './Home.css';

import MovieContext from '../../contexts/MovieContext';

import MovieItem from './MovieItem';
import Loader from '../loader/Loader';

export default function Home() {
    const { movies, isLoading } = useContext(MovieContext);

    return (
        <>
            <div className="wrapper">
                {isLoading && <Loader />}
                {!isLoading && movies.map(movie => (<MovieItem
                    key={movie.id}
                    {...movie} />))}
            </div>
        </>
    );
}