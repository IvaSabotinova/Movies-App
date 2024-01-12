import { useState, useEffect, useContext } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { toast } from 'react-toastify';

import './MovieDetails.css';

import * as movieService from '../../services/movieService';
import { formatDetailsDate } from '../../utils/dateUtil';
import { pathToUrl } from '../../utils/pathsUtil';
import AuthContext from '../../contexts/AuthContext';
import MovieContext from '../../contexts/MovieContext';
import Paths from '../../constants/Paths';


export default function MovieDetails() {
    const [movie, setMovie] = useState({});
    const { movieId } = useParams();
    const { username } = useContext(AuthContext);
    const { deleteMovieHandler } = useContext(MovieContext)
    const navigate = useNavigate();

    useEffect(() => {
        movieService.getMovieDetails(movieId)
            .then((res) => setMovie(res.result))
    }, [movieId]);

    const deleteMovie = (e) => {
        const hasConfirmed = confirm(`Are you sure you want to delete movie ${movie.title}?`);
        if (hasConfirmed) {
            toast.promise(
                deleteMovieHandler(movieId),
                {
                    pending: 'Processing your request...',
                    success: 'Movie deleted successfully! 👌',
                    error: 'Error encountered 🤯'
                },
                {
                    theme: "dark",
                }
            )
            navigate(Paths.Home);        }
    }

    return (
        <div className="movie-details">
            <div className="movie-image">
                <img src={movie.imageUrl} alt="" />
            </div>
            <div className="movie-allInfo">
                <h2>{movie.title}</h2>
                <div className="rating-stars">
                    <span className="bolded">Rate the movie: </span>
                    <span className="span-star"><i class="bi bi-star"></i></span>
                    <span className="span-star"><i class="bi bi-star"></i></span>
                    <span className="span-star"><i class="bi bi-star"></i></span>
                    <span className="span-star"><i class="bi bi-star"></i></span>
                    <span className="span-star"><i class="bi bi-star"></i></span>
                </div>
                <div className="rating-duration">
                    <div>
                        <span className="span-star"><i class="bi bi-star"></i></span>
                        <span>{movie.rating} IMDb rating</span>
                    </div>
                    {/* <span><span className="bolded">Rating:</span> {movie.rating}</span> */}

                    <p><span className="bolded">Duration:</span> {movie.duration} minutes</p>

                </div>

                <p><span className="bolded">Genre:</span> {movie.genreName}</p>
                <p><span className="bolded">User-Creator:</span> {movie.applicationUserUserName}</p>
                <div>
                    <p><span className="bolded">Information</span></p>
                    <p>{movie.description}</p>
                </div>
                <div className="button-div">
                    <span><span className="bolded">Release date:</span> {formatDetailsDate(movie.releaseDate)}</span>
                    <button onClick={() => { navigate(-1) }}>Back</button>
                </div>
                {(movie.applicationUserUserName === username || username === 'admin') &&
                    <div className="edit-delete-buttons mt-2">
                        <button className="btn btn-info" onClick={() => navigate(pathToUrl(Paths.UpdateMovie, { movieId }))}>
                            <i className="bi bi-pencil-fill"></i> Edit
                        </button>
                        <button className="btn btn-danger mx-2" onClick={deleteMovie}>
                            <i className="bi bi-trash-fill"></i> Delete
                        </button>
                    </div>}
            </div>

        </div>
    );
}